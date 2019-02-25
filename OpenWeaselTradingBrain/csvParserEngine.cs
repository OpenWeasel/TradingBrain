using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace OpenWeaselTradingBrain
{
    public partial class csvParserEngine : Form
    {
        public csvParserEngine()
        {
            InitializeComponent();
            using (TextFieldParser parser = new TextFieldParser(@"USD_CAD Historical Data.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool firstLine = true;

            
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }

                    foreach (string field in fields)
                    {
                        Console.WriteLine(field); //TODO: Process field
                    }
                }
            }
        }
    }
}
