/*
 * @author James Houston (maverick)
 * @purpose to predict the market using ML
 * @version v0.007 build 201812111
 * Source code is currently closed while in beta build.
 */


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
using RDotNet;
using LiveCharts;


namespace OpenWeaselTradingBrain
{
    public partial class Main : Form
    {

        private int _ticks;
        public int MouseDownX;
        public int MouseDownY;
        public Boolean BeingDragged = false;

        public Main()
        {






            InitializeComponent();



            /*
            // predictionGraphReload();
            while (true)
            {
                try
                {
                   // predictionGraph.Load("prediction.png");
                    break;
                }
                catch
                {
                    Console.WriteLine("Trying to open Prediction.PNG");
                }
            }
            */
            //backgroundWorker1.RunWorkerAsync();
            TimeZone localZone = TimeZone.CurrentTimeZone;
            lblTimeZoneValue.Text = localZone.StandardName;
            timer1.Start();
            timer2.Start();

            //csvParserEngine csvP = new csvParserEngine();
            //csvP.Show();

            /*
            predictionGraph.Load("blank.png");
            Thread.Sleep(2000);
            System.Diagnostics.Process rplot = new System.Diagnostics.Process();
            rplot.StartInfo.FileName = "dl180days.bat";
            rplot.Start();
            Thread.Sleep(5000);
            predictionGraph.Load("historical180.png");
            */
            predictionGraph.Load("historical180.png");
        }



        private void predictionGraphReload()
        {
            //Main here = new OpenWeaselTradingBrain.Main();
            //  reloadPredictionGraph.Load("prediction.png");            while (true)
            /*
            while (true)
            {
                try
                {
                    predictionGraph.Refresh();
                    System.IO.File.Copy("tempprediction.png", "prediction.png", true);
                    break;
                }
                catch
                {

                }
            }
            */

        }
        /*
        private void predictionGraph_Click(object sender, EventArgs e)
        {
            predictionGraph.Dispose();
            Thread.Sleep(1000);
            
            while (true)
            {
                try
                {
                   // predictionGraph.Load("prediction.png");
                    //System.IO.File.Copy("tempprediction.png", "prediction.png", true);
                    break;
                }
                catch
                {

                }
            }
            
            Thread.Sleep(100);
           // predictionGraph.Load("prediction.png");
        }
        */
        private void lblMeanValue_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           // Main machine = new OpenWeaselTradingBrain.Main();

            _ticks++;


            calculations();


            


        }
        private void buy()
        {

        }
        private void sell()
        {

        }
        private void calculations()
        {
            
            while (true)
            {
                try
                {

                    string mean = System.IO.File.ReadAllText("MEAN.txt");
                    Console.WriteLine(mean);
                    string symboltext = File.ReadAllText("symbol.txt");
                    lblSymbolTitle.Text = symboltext;

                    string sd = File.ReadAllText("sd.txt");
                    Console.WriteLine(sd);
                    if (sd.Length == 2)
                    {
                        sd = mean;
                    }
                    string price = File.ReadAllText("currentPrice.txt");
                    Console.WriteLine(price);


                    double sdDec = Convert.ToDouble(sd);
                    double meanDec = Convert.ToDouble(mean);
                    double priceDec = Convert.ToDouble(price);


                    double meanPTDec = ((meanDec / 100) * priceDec) + priceDec;
                    double sdPTDec = ((sdDec / 100) * priceDec) + priceDec;
                    double indicatorCheck = (sdDec + meanDec) / 2;
                    double tpCheck = (meanPTDec + sdPTDec) / 2;

                    if (indicatorCheck > 0)
                    {
                        lblIndicatorValue.Text = "Buy";

                    }
                    else
                    {
                        lblIndicatorValue.Text = "Sell";
                        lblTP1.Text = "SL1";
                        lblTP2.Text = "SL2";
                        lblTP3.Text = "Sl3";

                        lblSL1.Text = "TP1";
                        lblSL2.Text = "TP2";
                        lblSL3.Text = "TP3";

                        lblLossRisk.Text = "Win Reward";
                        lblWinReward.Text = "Loss Risk";
                    }

                    int risk = 2;
                    if (lblIndicatorValue.Text == "Buy")
                    {
                        double tp1Value = (tpCheck - priceDec) * (.33) + priceDec;
                        double tp2Value = (tpCheck - priceDec) * (.66) + priceDec;
                        double tp3Value = tpCheck;
                        double sl3Value = priceDec - (tpCheck - priceDec) * (.33/risk);
                        double sl2Value = priceDec - (tpCheck - priceDec) * (.66/risk);
                        double sl1Value = priceDec - (tpCheck - priceDec) * (.50);
                        //double lossriskValue = priceDec / (sl3Value + sl2Value + sl1Value);
                        double lossriskValue = (priceDec * 3) - (sl3Value + sl2Value + sl1Value);
                        double winrewardValue = (tp3Value + tp2Value + tp1Value) - (priceDec * 3);
                       // double winrewardValue = (tp3Value + tp2Value + tp1Value) / priceDec;
                        string meanRounded = Convert.ToString(Math.Round(meanDec, 4));
                        string sdRounded = Convert.ToString(Math.Round(sdDec, 4));
                        string priceRounded = Convert.ToString(Math.Round(priceDec, 4));
                        string indicatorValue = Convert.ToString(Math.Round(indicatorCheck, 4));
                        string meanPTValue = Convert.ToString(Math.Round(meanPTDec, 4));
                        string sdPTValue = Convert.ToString(Math.Round(sdPTDec, 4));
                        string tp1ValueRounded = Convert.ToString(Math.Round(tp1Value, 4));
                        string tp2ValueRounded = Convert.ToString(Math.Round(tp2Value, 4));
                        string tp3ValueRounded = Convert.ToString(Math.Round(tp3Value, 4));
                        string sl1ValueRounded = Convert.ToString(Math.Round(sl1Value, 4));
                        string sl2ValueRounded = Convert.ToString(Math.Round(sl2Value, 4));
                        string sl3ValueRounded = Convert.ToString(Math.Round(sl3Value, 4));
                        string lossriskValueRounded = Convert.ToString(Math.Round(lossriskValue, 4));
                        string winrewardValueRounded = Convert.ToString(Math.Round(winrewardValue, 4));
                        lblMeanValue.Text = meanRounded;
                        lblSDValue.Text = sdRounded;

                        lblMeanPTValue.Text = meanPTValue;
                        lblSDPTValue.Text = sdPTValue;
                        lblCurrentPriceValue.Text = priceRounded;
                        lblTP1Value.Text = tp1ValueRounded;
                        lblTP2Value.Text = tp2ValueRounded;
                        lblTP3Value.Text = tp3ValueRounded;
                        lblSL1Value.Text = sl1ValueRounded;
                        lblSL2Value.Text = sl2ValueRounded;
                        lblSL3Value.Text = sl3ValueRounded;
                        lblLossRiskValue.Text = lossriskValueRounded + " pips";
                        lblWinRewardValue.Text = winrewardValueRounded + " pips";
                    }
                    else
                    {
                        double sl1Value = ((tpCheck - priceDec) * (.33*risk)) + priceDec;
                        double sl2Value = ((tpCheck - priceDec) * (.66*risk)) + priceDec;
                        double sl3Value = ((tpCheck - priceDec) * (risk)) + priceDec;
                       // double tp3Value = tpCheck * (1/risk) + priceDec;
                        double tp3Value = priceDec - (tpCheck - priceDec) * (.33/risk);
                        double tp2Value = priceDec - (tpCheck - priceDec) * (.66/risk);
                        double tp1Value = priceDec - (tpCheck - priceDec);
                       // double lossriskValue = (tp1Value + tp2Value + tp3Value) / priceDec;
                        double lossriskValue = (priceDec * 3) - (sl1Value + sl2Value + sl3Value);
                        //double winrewardValue = priceDec / (sl3Value + sl2Value + sl1Value);
                        double winrewardValue = (priceDec * 3) - (tp3Value + tp2Value + tp3Value);
                        string meanRounded = Convert.ToString(Math.Round(meanDec, 4));
                        string sdRounded = Convert.ToString(Math.Round(sdDec, 4));
                        string priceRounded = Convert.ToString(Math.Round(priceDec, 4));
                        string indicatorValue = Convert.ToString(Math.Round(indicatorCheck, 4));
                        string meanPTValue = Convert.ToString(Math.Round(meanPTDec, 4));
                        string sdPTValue = Convert.ToString(Math.Round(sdPTDec, 4));
                        string tp1ValueRounded = Convert.ToString(Math.Round(tp1Value, 4));
                        string tp2ValueRounded = Convert.ToString(Math.Round(tp2Value, 4));
                        string tp3ValueRounded = Convert.ToString(Math.Round(tp3Value, 4));
                        string sl1ValueRounded = Convert.ToString(Math.Round(sl1Value, 4));
                        string sl2ValueRounded = Convert.ToString(Math.Round(sl2Value, 4));
                        string sl3ValueRounded = Convert.ToString(Math.Round(sl3Value, 4));
                        string lossriskValueRounded = Convert.ToString(Math.Round(lossriskValue, 4));
                        string winrewardValueRounded = Convert.ToString(Math.Round(winrewardValue, 4));
                        lblMeanValue.Text = meanRounded;
                        lblSDValue.Text = sdRounded;

                        lblMeanPTValue.Text = meanPTValue;
                        lblSDPTValue.Text = sdPTValue;
                        lblCurrentPriceValue.Text = priceRounded;
                        lblTP1Value.Text = tp1ValueRounded;
                        lblTP2Value.Text = tp2ValueRounded;
                        lblTP3Value.Text = tp3ValueRounded;
                        lblSL1Value.Text = sl1ValueRounded;
                        lblSL2Value.Text = sl2ValueRounded;
                        lblSL3Value.Text = sl3ValueRounded;
                        lblLossRiskValue.Text = lossriskValueRounded + " pips";
                        lblWinRewardValue.Text = winrewardValueRounded + " pips";
                    }


                    //double sl1Value = tp1Value * .33)
                    // Thread.Sleep(10000);
                    //predictionGraph.Refresh();
                    



                    
                    lblTimeValue.Text = DateTime.Now.ToString("ddd, dd MMM yyy HH:mm:ss ");
                    //plotR();
                    break;
                }
                catch
                {
                    Console.WriteLine("Error occured trying to run calculations again.");
                }
            }




        }

        private void lblStandardDeviation_Click(object sender, EventArgs e)
        {

        }

        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(1);

            MLEngine mle = new MLEngine();
            mle.Show();





            backgroundWorker1.ReportProgress(2);
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = "Simulation Started";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Finished";
            lblSimulate.Text = "Start Simulation";
        }
        private void btUpdatePrice_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("currentPrice.txt", false))
            {
                writer.Write(tbCurrentPrice.Text);
            }
        }
        private void btUpdateOpen_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("openPrice.txt", false))
            {
                writer.Write(tbOpen.Text);
            }
        }
        private void btUpdateHigh_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("highPrice.txt", false))
            {
                writer.Write(tbHigh.Text);
            }
        }
        private void btUpdateLow_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("lowPrice.txt", false))
            {
                writer.Write(tbLow.Text);
            }
        }
        private void btUpdateVolume_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("volume.txt", false))
            {
                writer.Write(tbVolume.Text);
            }
        }

        private void btUpdateSymbol_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("symbol.txt", false))
            {
                writer.Write(tbSymbol.Text);
            }
        }
        private void lblSimulate_Click(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            if (backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
            }
            if (backgroundWorker3.IsBusy != true)
            {
                backgroundWorker3.RunWorkerAsync();
            }
            if (backgroundWorker4.IsBusy != true)
            {
                backgroundWorker4.RunWorkerAsync();
            }
            if (backgroundWorker5.IsBusy != true)
            {
                backgroundWorker5.RunWorkerAsync();
            }
            if (backgroundWorker6.IsBusy != true)
            {
                backgroundWorker6.RunWorkerAsync();
            }
            if (backgroundWorker7.IsBusy != true)
            {
                backgroundWorker7.RunWorkerAsync();
            }
            if (backgroundWorker8.IsBusy != true)
            {
                backgroundWorker8.RunWorkerAsync();
            }
            if (backgroundWorker9.IsBusy != true)
            {
                backgroundWorker9.RunWorkerAsync();
            }
            if (backgroundWorker10.IsBusy != true)
            {
                backgroundWorker10.RunWorkerAsync();
            }
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker2.CancelAsync();
                backgroundWorker2.CancelAsync();
                backgroundWorker3.CancelAsync();
                backgroundWorker4.CancelAsync();
                backgroundWorker5.CancelAsync();
                backgroundWorker6.CancelAsync();
                backgroundWorker7.CancelAsync();
                backgroundWorker8.CancelAsync();
                backgroundWorker9.CancelAsync();
                backgroundWorker10.CancelAsync();
                lblSimulate.Text = "Can't Stop";
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle2 = new MLEngine();
            mle2.Show();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle3 = new MLEngine();
            mle3.Show();   
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle4 = new MLEngine();
            mle4.Show();
        }
        private void btRunCalculation_Click(object sender, EventArgs e)
        {
            predictionGraph.Load("blank.png");
            Thread.Sleep(2000);
            System.Diagnostics.Process rplot = new System.Diagnostics.Process();
            rplot.StartInfo.FileName = "plot.bat";
            rplot.Start();
            Thread.Sleep(5000);
            predictionGraph.Load("prediction.png");
        }
        private void plotR()
        {
            /*
            //System.Diagnostics.Process rplot = new System.Diagnostics.Process();
            System.Diagnostics.Process rplot = new System.Diagnostics.Process();
            rplot.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            rplot.StartInfo.CreateNoWindow = true;
            rplot.StartInfo.UseShellExecute = false;
            rplot.StartInfo.FileName = "plot.bat";
            //rplot.StartInfo.Arguments = "/c " + path;
            rplot.EnableRaisingEvents = true;
           // rplot.Exited += new EventHandler(process_Exited);
            rplot.Start();
            rplot.WaitForExit();
           // System.Diagnostics.Process.ExitCode = rplot.ExitCode;
           */
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks++;
            // plotR();
            predictionGraphReload();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("prediction.txt", false))
            {
                writer.Write("");
            }
        }

        private void btRefreshGraph_Click(object sender, EventArgs e)
        {
            /*
            List<Image> imagelist = new List<Image>();

            foreach (FileInfo oneFile in new DirectoryInfo("/").GetFiles())
            {
                imagelist.Add(Image.FromFile("prediction.png"));
            }
            */
            //  predictionGraph.Image = Image.FromFile(imagelist[0]);
            //predictionGraph.Image.Save("prediction.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            predictionGraph.Load(@"prediction.png");
            /*
            Image oldImage = horPicBox.Image;
            horPicBox.Image = Image.FromFile(imagePaths[index]);
            oldImage.Dispose();
            */

            //predictionGraph.Dispose();
            //predictionGraph.Load("prediction.png");
            // lblSimulate.Text="lol";
            //Thread.Sleep(10000);
            // UseWaitCursor.Equals(false);
            // predictionGraph.Load(@"prediction.png");
            //  Thread.Sleep(10000);
            // System.IO.File.Copy("tempprediction.png", "prediction.png", true);
            //predictionGraph.Load(@"prediction.png");
        }
        private void btReleaseGraph_Click(object sender, EventArgs e)
        {
            predictionGraph.Load("blank.png");
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle5 = new MLEngine();
            mle5.Show();
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle6 = new MLEngine();
            mle6.Show();
        }
        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle7 = new MLEngine();
            mle7.Show();
        }
        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle8 = new MLEngine();
            mle8.Show();
        }
        private void backgroundWorker9_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle9 = new MLEngine();
            mle9.Show();
        }
        private void backgroundWorker10_DoWork(object sender, DoWorkEventArgs e)
        {
            MLEngine mle10 = new MLEngine();
            mle10.Show();
        }

        private void btLiveData_Click(object sender, EventArgs e)
        {
            predictionGraph.Load("blank.png");
            Thread.Sleep(2000);
            System.Diagnostics.Process rplot = new System.Diagnostics.Process();
            rplot.StartInfo.FileName = "dl180days.bat";
            rplot.Start();
            Thread.Sleep(20000);
            predictionGraph.Load("historical180.png");
        }

        private void btImportData_Click(object sender, EventArgs e)
        {
            openFileDialogData.Filter = "CSV|*.csv";

            if (openFileDialogData.ShowDialog() == DialogResult.OK)
            {
               var fileName = openFileDialogData.FileName;
                File.Copy(fileName, Path.Combine(Path.GetDirectoryName(fileName), Path.GetDirectoryName(Application.ExecutablePath) + "/Import" + ".csv"), true);
                Console.WriteLine(Path.GetDirectoryName(Application.ExecutablePath));
                System.Diagnostics.Process createData = new System.Diagnostics.Process();
                createData.StartInfo.FileName = "createData.bat";
                createData.Start();
            }

            
        }

        private void openFileDialogData_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = true;
                MouseDownX = e.X;
                MouseDownY = e.Y;
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (BeingDragged == true)
            {
                var tmp = new System.Drawing.Point();
                tmp.X = this.Location.X + (e.X - MouseDownX);
                tmp.Y = this.Location.Y + (e.Y - MouseDownY);
                this.Location = tmp;
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = false;
            }
        }


        private void tbSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("symbol.txt", false))
                {
                    writer.Write(tbSymbol.Text);
                }
                SendKeys.Send("{TAB}");
            }
        }

        private void tbVolume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("volume.txt", false))
                {
                    writer.Write(tbVolume.Text);
                }
                SendKeys.Send("{TAB}");
            }
        }

        private void tbCurrentPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("currentPrice.txt", false))
                {
                    writer.Write(tbCurrentPrice.Text);
                }
                SendKeys.Send("{TAB}");
            }
        }

        private void tbOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("openPrice.txt", false))
                {
                    writer.Write(tbOpen.Text);
                }
                SendKeys.Send("{TAB}");
            }
        }

        private void tbHigh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("highPrice.txt", false))
                {
                    writer.Write(tbHigh.Text);
                }
                SendKeys.Send("{TAB}");
            }

        }

        private void tbLow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                using (StreamWriter writer = new StreamWriter("lowPrice.txt", false))
                {
                    writer.Write(tbLow.Text);
                }
                SendKeys.Send("{TAB}");
            }
        }
    }
 
}

