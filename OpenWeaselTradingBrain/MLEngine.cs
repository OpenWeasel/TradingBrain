using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Transforms;
using Microsoft.ML.Runtime;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.EntryPoints;


namespace OpenWeaselTradingBrain
{
    public partial class MLEngine : Form
    {
        private int _ticks;
        public MLEngine()
        {
            
        //timer1.Start();
            int x = 0;
            InitializeComponent();
            while (x < 10)
            {
                startEngine();
                x++;
            }
            
           
        }
        public void startEngine()
        {
            // STEP 2: Create a ML.NET environment  
            var mlContext = new MLContext();

            // If working in Visual Studio, make sure the 'Copy to Output Directory'
            // property of iris-data.txt is set to 'Copy always'
            string dataPath = "DATA.txt";
            var reader = mlContext.Data.TextReader(new TextLoader.Arguments()
            {
                Separator = ",",
                HasHeader = true,
                Column = new[]
                {
                    new TextLoader.Column("SepalLength", DataKind.R4, 0),
                    new TextLoader.Column("SepalWidth", DataKind.R4, 1),
                    new TextLoader.Column("PetalLength", DataKind.R4, 2),
                    new TextLoader.Column("PetalWidth", DataKind.R4, 3),
                    new TextLoader.Column("Label", DataKind.Text, 4)
                }
            });



            IDataView trainingDataView = reader.Read(new MultiFileSource(dataPath));

            // STEP 3: Transform your data and add a learner
            // Assign numeric values to text in the "Label" column, because only
            // numbers can be processed during model training.
            // Add a learning algorithm to the pipeline. e.g.(What type of iris is this?)
            // Convert the Label back into original text (after converting to number in step 3)
            var pipeline = mlContext.Transforms.Categorical.MapValueToKey("Label")
                .Append(mlContext.Transforms.Concatenate("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"))
                .Append(mlContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(label: "Label", features: "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // STEP 4: Train your model based on the data set  
            var model = pipeline.Fit(trainingDataView);
            string currentPrice = System.IO.File.ReadAllText("currentPrice.txt");
            string openPrice = System.IO.File.ReadAllText("openPrice.txt");
            string highPrice = System.IO.File.ReadAllText("highPrice.txt");
            string lowPrice = System.IO.File.ReadAllText("lowPrice.txt");
            float col0 = float.Parse(currentPrice);
            float col1 = float.Parse(openPrice);
            float col2 = float.Parse(highPrice);
            float col3 = float.Parse(lowPrice);
            // STEP 5: Use your model to make a prediction
            // You can change these numbers to test different predictions
            var prediction = model.MakePredictionFunction<IrisData, IrisPrediction>(mlContext).Predict(
                new IrisData()
                {
                    SepalLength = col0,
                    SepalWidth = col1,
                    PetalLength = col2,
                    PetalWidth = col3,
                });

            Console.WriteLine($"Prediction: {prediction.PredictedLabels}");
            while (true)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(@"prediction.txt"))
                    {
                        sw.WriteLine(prediction.PredictedLabels);
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("trying again to write to file");
                }
            }

        }
        // STEP 1: Define your data structures

        // IrisData is used to provide training data, and as 
        // input for prediction operations
        // - First 4 properties are inputs/features used to predict the label
        // - Label is what you are predicting, and is only set when training
        public class IrisData
        {
            [Column("0")]
            public float SepalLength;

            [Column("1")]
            public float SepalWidth;

            [Column("2")]
            public float PetalLength;

            [Column("3")]
            public float PetalWidth;

            [Column("4")]
            [ColumnName("Label")]
            public string Label;
        }
        // IrisPrediction is the result returned from prediction operations
        public class IrisPrediction
        {
            [ColumnName("PredictedLabel")]
            public string PredictedLabels;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
           // assignPrices();
        }
        /*
        public void assignPrices()
        {
            string currentPrice = System.IO.File.ReadAllText("currentPrice.txt");
            string openPrice = System.IO.File.ReadAllText("openPrice.txt") + "f";
            string highPrice = System.IO.File.ReadAllText("highPrice.txt" + "f");
            string lowPrice = System.IO.File.ReadAllText("lowPrice.txt" + "f");
        }
        */
    }

}
