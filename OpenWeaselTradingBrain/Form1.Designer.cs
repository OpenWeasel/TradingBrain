namespace OpenWeaselTradingBrain
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.predictionGraph = new System.Windows.Forms.PictureBox();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblMeanValue = new System.Windows.Forms.Label();
            this.lblStandardDeviation = new System.Windows.Forms.Label();
            this.lblSDValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btReset = new System.Windows.Forms.Label();
            this.lblSimulate = new System.Windows.Forms.Label();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.lblIndicatorValue = new System.Windows.Forms.Label();
            this.tbCurrentPrice = new System.Windows.Forms.TextBox();
            this.tbOpen = new System.Windows.Forms.TextBox();
            this.tbHigh = new System.Windows.Forms.TextBox();
            this.tbLow = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nASDAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCurrencyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBPUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDCADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDMXNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCryptoCurrencyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTCUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTHUSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMeanPTValue = new System.Windows.Forms.Label();
            this.lblSDPTValue = new System.Windows.Forms.Label();
            this.lblTP1 = new System.Windows.Forms.Label();
            this.lblTP1Value = new System.Windows.Forms.Label();
            this.lblTP2 = new System.Windows.Forms.Label();
            this.lblTP3 = new System.Windows.Forms.Label();
            this.lblTP2Value = new System.Windows.Forms.Label();
            this.lblTP3Value = new System.Windows.Forms.Label();
            this.lblCurrrentPrice = new System.Windows.Forms.Label();
            this.lblCurrentPriceValue = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.lblSL1 = new System.Windows.Forms.Label();
            this.lblSL2 = new System.Windows.Forms.Label();
            this.lblSL3 = new System.Windows.Forms.Label();
            this.lblSL1Value = new System.Windows.Forms.Label();
            this.lblSL2Value = new System.Windows.Forms.Label();
            this.lblSL3Value = new System.Windows.Forms.Label();
            this.lblLossRisk = new System.Windows.Forms.Label();
            this.lblWinReward = new System.Windows.Forms.Label();
            this.lblLossRiskValue = new System.Windows.Forms.Label();
            this.lblWinRewardValue = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btUpdatePrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btUpdateOpen = new System.Windows.Forms.Label();
            this.btUpdateHigh = new System.Windows.Forms.Label();
            this.btUpdateLow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btReleaseGraph = new System.Windows.Forms.Label();
            this.btRunCalculation = new System.Windows.Forms.Label();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker10 = new System.ComponentModel.BackgroundWorker();
            this.btLiveData = new System.Windows.Forms.Label();
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.btUpdateSymbol = new System.Windows.Forms.Label();
            this.lblSymbolTitle = new System.Windows.Forms.Label();
            this.btImportData = new System.Windows.Forms.Label();
            this.openFileDialogData = new System.Windows.Forms.OpenFileDialog();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTimeZoneValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predictionGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // predictionGraph
            // 
            this.predictionGraph.BackColor = System.Drawing.Color.White;
            this.predictionGraph.Location = new System.Drawing.Point(3, 78);
            this.predictionGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.predictionGraph.Name = "predictionGraph";
            this.predictionGraph.Size = new System.Drawing.Size(728, 598);
            this.predictionGraph.TabIndex = 0;
            this.predictionGraph.TabStop = false;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMean.Location = new System.Drawing.Point(749, 49);
            this.lblMean.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(65, 17);
            this.lblMean.TabIndex = 1;
            this.lblMean.Text = "Mean %";
            // 
            // lblMeanValue
            // 
            this.lblMeanValue.AutoSize = true;
            this.lblMeanValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanValue.Location = new System.Drawing.Point(755, 78);
            this.lblMeanValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeanValue.Name = "lblMeanValue";
            this.lblMeanValue.Size = new System.Drawing.Size(31, 17);
            this.lblMeanValue.TabIndex = 2;
            this.lblMeanValue.Text = "N/A";
            this.lblMeanValue.Click += new System.EventHandler(this.lblMeanValue_Click);
            // 
            // lblStandardDeviation
            // 
            this.lblStandardDeviation.AutoSize = true;
            this.lblStandardDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardDeviation.Location = new System.Drawing.Point(863, 49);
            this.lblStandardDeviation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStandardDeviation.Name = "lblStandardDeviation";
            this.lblStandardDeviation.Size = new System.Drawing.Size(47, 17);
            this.lblStandardDeviation.TabIndex = 3;
            this.lblStandardDeviation.Text = "SD %";
            this.lblStandardDeviation.Click += new System.EventHandler(this.lblStandardDeviation_Click);
            // 
            // lblSDValue
            // 
            this.lblSDValue.AutoSize = true;
            this.lblSDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDValue.Location = new System.Drawing.Point(871, 78);
            this.lblSDValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDValue.Name = "lblSDValue";
            this.lblSDValue.Size = new System.Drawing.Size(31, 17);
            this.lblSDValue.TabIndex = 4;
            this.lblSDValue.Text = "N/A";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btReset
            // 
            this.btReset.AutoSize = true;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(1065, 660);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(50, 17);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lblSimulate
            // 
            this.lblSimulate.AutoSize = true;
            this.lblSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulate.Location = new System.Drawing.Point(929, 660);
            this.lblSimulate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimulate.Name = "lblSimulate";
            this.lblSimulate.Size = new System.Drawing.Size(123, 17);
            this.lblSimulate.TabIndex = 5;
            this.lblSimulate.Text = "Start Simulation";
            this.lblSimulate.Click += new System.EventHandler(this.lblSimulate_Click);
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.Location = new System.Drawing.Point(968, 49);
            this.lblIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(71, 17);
            this.lblIndicator.TabIndex = 5;
            this.lblIndicator.Text = "Indicator";
            // 
            // lblIndicatorValue
            // 
            this.lblIndicatorValue.AutoSize = true;
            this.lblIndicatorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicatorValue.Location = new System.Drawing.Point(985, 78);
            this.lblIndicatorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicatorValue.Name = "lblIndicatorValue";
            this.lblIndicatorValue.Size = new System.Drawing.Size(31, 17);
            this.lblIndicatorValue.TabIndex = 4;
            this.lblIndicatorValue.Text = "N/A";
            // 
            // tbCurrentPrice
            // 
            this.tbCurrentPrice.Location = new System.Drawing.Point(968, 437);
            this.tbCurrentPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCurrentPrice.Name = "tbCurrentPrice";
            this.tbCurrentPrice.Size = new System.Drawing.Size(84, 22);
            this.tbCurrentPrice.TabIndex = 3;
            // 
            // tbOpen
            // 
            this.tbOpen.Location = new System.Drawing.Point(753, 534);
            this.tbOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(84, 22);
            this.tbOpen.TabIndex = 4;
            // 
            // tbHigh
            // 
            this.tbHigh.Location = new System.Drawing.Point(865, 534);
            this.tbHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHigh.Name = "tbHigh";
            this.tbHigh.Size = new System.Drawing.Size(84, 22);
            this.tbHigh.TabIndex = 5;
            // 
            // tbLow
            // 
            this.tbLow.Location = new System.Drawing.Point(968, 534);
            this.tbLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLow.Name = "tbLow";
            this.tbLow.Size = new System.Drawing.Size(84, 22);
            this.tbLow.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(968, 416);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(749, 514);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(47, 17);
            this.lblOpen.TabIndex = 1;
            this.lblOpen.Text = "Open";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(863, 514);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(41, 17);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Text = "High";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(968, 514);
            this.lblLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(36, 17);
            this.lblLow.TabIndex = 1;
            this.lblLow.Text = "Low";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.importCurrencyDataToolStripMenuItem,
            this.importCryptoCurrencyDataToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocksToolStripMenuItem,
            this.nASDAQToolStripMenuItem});
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.importDataToolStripMenuItem.Text = "Import Stock Data";
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.stocksToolStripMenuItem.Text = "SPY";
            // 
            // nASDAQToolStripMenuItem
            // 
            this.nASDAQToolStripMenuItem.Name = "nASDAQToolStripMenuItem";
            this.nASDAQToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.nASDAQToolStripMenuItem.Text = "NASDAQ";
            // 
            // importCurrencyDataToolStripMenuItem
            // 
            this.importCurrencyDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eURUSDToolStripMenuItem,
            this.gBPUSDToolStripMenuItem,
            this.uSDCADToolStripMenuItem,
            this.uSDMXNToolStripMenuItem});
            this.importCurrencyDataToolStripMenuItem.Name = "importCurrencyDataToolStripMenuItem";
            this.importCurrencyDataToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.importCurrencyDataToolStripMenuItem.Text = "Import Currency Data";
            // 
            // eURUSDToolStripMenuItem
            // 
            this.eURUSDToolStripMenuItem.Name = "eURUSDToolStripMenuItem";
            this.eURUSDToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eURUSDToolStripMenuItem.Text = "EURUSD";
            // 
            // gBPUSDToolStripMenuItem
            // 
            this.gBPUSDToolStripMenuItem.Name = "gBPUSDToolStripMenuItem";
            this.gBPUSDToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.gBPUSDToolStripMenuItem.Text = "GBPUSD";
            // 
            // uSDCADToolStripMenuItem
            // 
            this.uSDCADToolStripMenuItem.Name = "uSDCADToolStripMenuItem";
            this.uSDCADToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.uSDCADToolStripMenuItem.Text = "USDCAD";
            // 
            // uSDMXNToolStripMenuItem
            // 
            this.uSDMXNToolStripMenuItem.Name = "uSDMXNToolStripMenuItem";
            this.uSDMXNToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.uSDMXNToolStripMenuItem.Text = "USDMXN";
            // 
            // importCryptoCurrencyDataToolStripMenuItem
            // 
            this.importCryptoCurrencyDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTCUSDToolStripMenuItem,
            this.eTHUSDToolStripMenuItem});
            this.importCryptoCurrencyDataToolStripMenuItem.Name = "importCryptoCurrencyDataToolStripMenuItem";
            this.importCryptoCurrencyDataToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.importCryptoCurrencyDataToolStripMenuItem.Text = "Import CryptoCurrency Data";
            // 
            // bTCUSDToolStripMenuItem
            // 
            this.bTCUSDToolStripMenuItem.Name = "bTCUSDToolStripMenuItem";
            this.bTCUSDToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.bTCUSDToolStripMenuItem.Text = "BTCUSD";
            // 
            // eTHUSDToolStripMenuItem
            // 
            this.eTHUSDToolStripMenuItem.Name = "eTHUSDToolStripMenuItem";
            this.eTHUSDToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.eTHUSDToolStripMenuItem.Text = "ETHUSD";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mean PT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(863, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SD PT";
            // 
            // lblMeanPTValue
            // 
            this.lblMeanPTValue.AutoSize = true;
            this.lblMeanPTValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeanPTValue.Location = new System.Drawing.Point(755, 145);
            this.lblMeanPTValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeanPTValue.Name = "lblMeanPTValue";
            this.lblMeanPTValue.Size = new System.Drawing.Size(31, 17);
            this.lblMeanPTValue.TabIndex = 4;
            this.lblMeanPTValue.Text = "N/A";
            // 
            // lblSDPTValue
            // 
            this.lblSDPTValue.AutoSize = true;
            this.lblSDPTValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDPTValue.Location = new System.Drawing.Point(871, 145);
            this.lblSDPTValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDPTValue.Name = "lblSDPTValue";
            this.lblSDPTValue.Size = new System.Drawing.Size(31, 17);
            this.lblSDPTValue.TabIndex = 4;
            this.lblSDPTValue.Text = "N/A";
            // 
            // lblTP1
            // 
            this.lblTP1.AutoSize = true;
            this.lblTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP1.Location = new System.Drawing.Point(749, 182);
            this.lblTP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP1.Name = "lblTP1";
            this.lblTP1.Size = new System.Drawing.Size(37, 17);
            this.lblTP1.TabIndex = 1;
            this.lblTP1.Text = "TP1";
            // 
            // lblTP1Value
            // 
            this.lblTP1Value.AutoSize = true;
            this.lblTP1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP1Value.Location = new System.Drawing.Point(755, 204);
            this.lblTP1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP1Value.Name = "lblTP1Value";
            this.lblTP1Value.Size = new System.Drawing.Size(31, 17);
            this.lblTP1Value.TabIndex = 4;
            this.lblTP1Value.Text = "N/A";
            // 
            // lblTP2
            // 
            this.lblTP2.AutoSize = true;
            this.lblTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP2.Location = new System.Drawing.Point(863, 182);
            this.lblTP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP2.Name = "lblTP2";
            this.lblTP2.Size = new System.Drawing.Size(37, 17);
            this.lblTP2.TabIndex = 1;
            this.lblTP2.Text = "TP2";
            // 
            // lblTP3
            // 
            this.lblTP3.AutoSize = true;
            this.lblTP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP3.Location = new System.Drawing.Point(968, 182);
            this.lblTP3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP3.Name = "lblTP3";
            this.lblTP3.Size = new System.Drawing.Size(37, 17);
            this.lblTP3.TabIndex = 1;
            this.lblTP3.Text = "TP3";
            // 
            // lblTP2Value
            // 
            this.lblTP2Value.AutoSize = true;
            this.lblTP2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP2Value.Location = new System.Drawing.Point(871, 204);
            this.lblTP2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP2Value.Name = "lblTP2Value";
            this.lblTP2Value.Size = new System.Drawing.Size(31, 17);
            this.lblTP2Value.TabIndex = 4;
            this.lblTP2Value.Text = "N/A";
            // 
            // lblTP3Value
            // 
            this.lblTP3Value.AutoSize = true;
            this.lblTP3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP3Value.Location = new System.Drawing.Point(985, 204);
            this.lblTP3Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTP3Value.Name = "lblTP3Value";
            this.lblTP3Value.Size = new System.Drawing.Size(31, 17);
            this.lblTP3Value.TabIndex = 4;
            this.lblTP3Value.Text = "N/A";
            // 
            // lblCurrrentPrice
            // 
            this.lblCurrrentPrice.AutoSize = true;
            this.lblCurrrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrrentPrice.Location = new System.Drawing.Point(968, 119);
            this.lblCurrrentPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrrentPrice.Name = "lblCurrrentPrice";
            this.lblCurrrentPrice.Size = new System.Drawing.Size(104, 17);
            this.lblCurrrentPrice.TabIndex = 1;
            this.lblCurrrentPrice.Text = "Current Price";
            // 
            // lblCurrentPriceValue
            // 
            this.lblCurrentPriceValue.AutoSize = true;
            this.lblCurrentPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPriceValue.Location = new System.Drawing.Point(985, 145);
            this.lblCurrentPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPriceValue.Name = "lblCurrentPriceValue";
            this.lblCurrentPriceValue.Size = new System.Drawing.Size(31, 17);
            this.lblCurrentPriceValue.TabIndex = 4;
            this.lblCurrentPriceValue.Text = "N/A";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(739, 660);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Simulation Idle";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // lblSL1
            // 
            this.lblSL1.AutoSize = true;
            this.lblSL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL1.Location = new System.Drawing.Point(749, 251);
            this.lblSL1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL1.Name = "lblSL1";
            this.lblSL1.Size = new System.Drawing.Size(36, 17);
            this.lblSL1.TabIndex = 1;
            this.lblSL1.Text = "SL1";
            // 
            // lblSL2
            // 
            this.lblSL2.AutoSize = true;
            this.lblSL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL2.Location = new System.Drawing.Point(863, 251);
            this.lblSL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL2.Name = "lblSL2";
            this.lblSL2.Size = new System.Drawing.Size(36, 17);
            this.lblSL2.TabIndex = 1;
            this.lblSL2.Text = "SL2";
            // 
            // lblSL3
            // 
            this.lblSL3.AutoSize = true;
            this.lblSL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL3.Location = new System.Drawing.Point(968, 251);
            this.lblSL3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL3.Name = "lblSL3";
            this.lblSL3.Size = new System.Drawing.Size(36, 17);
            this.lblSL3.TabIndex = 1;
            this.lblSL3.Text = "SL3";
            // 
            // lblSL1Value
            // 
            this.lblSL1Value.AutoSize = true;
            this.lblSL1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL1Value.Location = new System.Drawing.Point(755, 273);
            this.lblSL1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL1Value.Name = "lblSL1Value";
            this.lblSL1Value.Size = new System.Drawing.Size(31, 17);
            this.lblSL1Value.TabIndex = 4;
            this.lblSL1Value.Text = "N/A";
            // 
            // lblSL2Value
            // 
            this.lblSL2Value.AutoSize = true;
            this.lblSL2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL2Value.Location = new System.Drawing.Point(871, 273);
            this.lblSL2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL2Value.Name = "lblSL2Value";
            this.lblSL2Value.Size = new System.Drawing.Size(31, 17);
            this.lblSL2Value.TabIndex = 4;
            this.lblSL2Value.Text = "N/A";
            // 
            // lblSL3Value
            // 
            this.lblSL3Value.AutoSize = true;
            this.lblSL3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL3Value.Location = new System.Drawing.Point(985, 273);
            this.lblSL3Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSL3Value.Name = "lblSL3Value";
            this.lblSL3Value.Size = new System.Drawing.Size(31, 17);
            this.lblSL3Value.TabIndex = 4;
            this.lblSL3Value.Text = "N/A";
            // 
            // lblLossRisk
            // 
            this.lblLossRisk.AutoSize = true;
            this.lblLossRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossRisk.Location = new System.Drawing.Point(749, 305);
            this.lblLossRisk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLossRisk.Name = "lblLossRisk";
            this.lblLossRisk.Size = new System.Drawing.Size(78, 17);
            this.lblLossRisk.TabIndex = 1;
            this.lblLossRisk.Text = "Loss Risk";
            // 
            // lblWinReward
            // 
            this.lblWinReward.AutoSize = true;
            this.lblWinReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinReward.Location = new System.Drawing.Point(863, 305);
            this.lblWinReward.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinReward.Name = "lblWinReward";
            this.lblWinReward.Size = new System.Drawing.Size(94, 17);
            this.lblWinReward.TabIndex = 1;
            this.lblWinReward.Text = "Win Reward";
            // 
            // lblLossRiskValue
            // 
            this.lblLossRiskValue.AutoSize = true;
            this.lblLossRiskValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossRiskValue.Location = new System.Drawing.Point(755, 327);
            this.lblLossRiskValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLossRiskValue.Name = "lblLossRiskValue";
            this.lblLossRiskValue.Size = new System.Drawing.Size(31, 17);
            this.lblLossRiskValue.TabIndex = 4;
            this.lblLossRiskValue.Text = "N/A";
            // 
            // lblWinRewardValue
            // 
            this.lblWinRewardValue.AutoSize = true;
            this.lblWinRewardValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinRewardValue.Location = new System.Drawing.Point(871, 327);
            this.lblWinRewardValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinRewardValue.Name = "lblWinRewardValue";
            this.lblWinRewardValue.Size = new System.Drawing.Size(31, 17);
            this.lblWinRewardValue.TabIndex = 4;
            this.lblWinRewardValue.Text = "N/A";
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btUpdatePrice
            // 
            this.btUpdatePrice.AutoSize = true;
            this.btUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdatePrice.Location = new System.Drawing.Point(968, 466);
            this.btUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btUpdatePrice.Name = "btUpdatePrice";
            this.btUpdatePrice.Size = new System.Drawing.Size(60, 17);
            this.btUpdatePrice.TabIndex = 5;
            this.btUpdatePrice.Text = "Update";
            this.btUpdatePrice.Click += new System.EventHandler(this.btUpdatePrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vol Total";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(867, 436);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(81, 22);
            this.tbVolume.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(863, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Update";
            this.label4.Click += new System.EventHandler(this.btUpdateVolume_Click);
            // 
            // btUpdateOpen
            // 
            this.btUpdateOpen.AutoSize = true;
            this.btUpdateOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateOpen.Location = new System.Drawing.Point(749, 574);
            this.btUpdateOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btUpdateOpen.Name = "btUpdateOpen";
            this.btUpdateOpen.Size = new System.Drawing.Size(60, 17);
            this.btUpdateOpen.TabIndex = 5;
            this.btUpdateOpen.Text = "Update";
            this.btUpdateOpen.Click += new System.EventHandler(this.btUpdateOpen_Click);
            // 
            // btUpdateHigh
            // 
            this.btUpdateHigh.AutoSize = true;
            this.btUpdateHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateHigh.Location = new System.Drawing.Point(863, 574);
            this.btUpdateHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btUpdateHigh.Name = "btUpdateHigh";
            this.btUpdateHigh.Size = new System.Drawing.Size(60, 17);
            this.btUpdateHigh.TabIndex = 5;
            this.btUpdateHigh.Text = "Update";
            this.btUpdateHigh.Click += new System.EventHandler(this.btUpdateHigh_Click);
            // 
            // btUpdateLow
            // 
            this.btUpdateLow.AutoSize = true;
            this.btUpdateLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateLow.Location = new System.Drawing.Point(968, 574);
            this.btUpdateLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btUpdateLow.Name = "btUpdateLow";
            this.btUpdateLow.Size = new System.Drawing.Size(60, 17);
            this.btUpdateLow.TabIndex = 5;
            this.btUpdateLow.Text = "Update";
            this.btUpdateLow.Click += new System.EventHandler(this.btUpdateLow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 636);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Refresh Graph";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.btRefreshGraph_Click);
            // 
            // btReleaseGraph
            // 
            this.btReleaseGraph.AutoSize = true;
            this.btReleaseGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReleaseGraph.Location = new System.Drawing.Point(997, 636);
            this.btReleaseGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btReleaseGraph.Name = "btReleaseGraph";
            this.btReleaseGraph.Size = new System.Drawing.Size(117, 17);
            this.btReleaseGraph.TabIndex = 8;
            this.btReleaseGraph.Text = "Release Graph";
            this.btReleaseGraph.Visible = false;
            this.btReleaseGraph.Click += new System.EventHandler(this.btReleaseGraph_Click);
            // 
            // btRunCalculation
            // 
            this.btRunCalculation.AutoSize = true;
            this.btRunCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunCalculation.Location = new System.Drawing.Point(159, 48);
            this.btRunCalculation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btRunCalculation.Name = "btRunCalculation";
            this.btRunCalculation.Size = new System.Drawing.Size(122, 17);
            this.btRunCalculation.TabIndex = 9;
            this.btRunCalculation.Text = "Run Calculation";
            this.btRunCalculation.Click += new System.EventHandler(this.btRunCalculation_Click);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.WorkerSupportsCancellation = true;
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.WorkerSupportsCancellation = true;
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.WorkerSupportsCancellation = true;
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            // 
            // backgroundWorker8
            // 
            this.backgroundWorker8.WorkerSupportsCancellation = true;
            this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker8_DoWork);
            // 
            // backgroundWorker9
            // 
            this.backgroundWorker9.WorkerSupportsCancellation = true;
            this.backgroundWorker9.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker9_DoWork);
            // 
            // backgroundWorker10
            // 
            this.backgroundWorker10.WorkerSupportsCancellation = true;
            this.backgroundWorker10.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker10_DoWork);
            // 
            // btLiveData
            // 
            this.btLiveData.AutoSize = true;
            this.btLiveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLiveData.Location = new System.Drawing.Point(323, 48);
            this.btLiveData.Name = "btLiveData";
            this.btLiveData.Size = new System.Drawing.Size(152, 17);
            this.btLiveData.TabIndex = 10;
            this.btLiveData.Text = "Download Live Data";
            this.btLiveData.Click += new System.EventHandler(this.btLiveData_Click);
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(753, 436);
            this.tbSymbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(85, 22);
            this.tbSymbol.TabIndex = 1;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(749, 416);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(60, 17);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "Symbol";
            // 
            // btUpdateSymbol
            // 
            this.btUpdateSymbol.AutoSize = true;
            this.btUpdateSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateSymbol.Location = new System.Drawing.Point(749, 466);
            this.btUpdateSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btUpdateSymbol.Name = "btUpdateSymbol";
            this.btUpdateSymbol.Size = new System.Drawing.Size(60, 17);
            this.btUpdateSymbol.TabIndex = 5;
            this.btUpdateSymbol.Text = "Update";
            this.btUpdateSymbol.Click += new System.EventHandler(this.btUpdateSymbol_Click);
            // 
            // lblSymbolTitle
            // 
            this.lblSymbolTitle.AutoSize = true;
            this.lblSymbolTitle.Location = new System.Drawing.Point(13, 48);
            this.lblSymbolTitle.Name = "lblSymbolTitle";
            this.lblSymbolTitle.Size = new System.Drawing.Size(31, 17);
            this.lblSymbolTitle.TabIndex = 12;
            this.lblSymbolTitle.Text = "N\\A";
            // 
            // btImportData
            // 
            this.btImportData.AutoSize = true;
            this.btImportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportData.Location = new System.Drawing.Point(520, 48);
            this.btImportData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btImportData.Name = "btImportData";
            this.btImportData.Size = new System.Drawing.Size(92, 17);
            this.btImportData.TabIndex = 1;
            this.btImportData.Text = "Import Data";
            this.btImportData.Click += new System.EventHandler(this.btImportData_Click);
            // 
            // openFileDialogData
            // 
            this.openFileDialogData.DefaultExt = "csv";
            this.openFileDialogData.Title = "Import Data Set";
            this.openFileDialogData.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogData_FileOk);
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.Location = new System.Drawing.Point(763, 608);
            this.lblTimeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(31, 17);
            this.lblTimeValue.TabIndex = 4;
            this.lblTimeValue.Text = "N/A";
            // 
            // lblTimeZoneValue
            // 
            this.lblTimeZoneValue.AutoSize = true;
            this.lblTimeZoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZoneValue.Location = new System.Drawing.Point(763, 624);
            this.lblTimeZoneValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeZoneValue.Name = "lblTimeZoneValue";
            this.lblTimeZoneValue.Size = new System.Drawing.Size(31, 17);
            this.lblTimeZoneValue.TabIndex = 4;
            this.lblTimeZoneValue.Text = "N/A";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 690);
            this.Controls.Add(this.lblSymbolTitle);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.btLiveData);
            this.Controls.Add(this.btRunCalculation);
            this.Controls.Add(this.btReleaseGraph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLow);
            this.Controls.Add(this.tbHigh);
            this.Controls.Add(this.tbOpen);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbCurrentPrice);
            this.Controls.Add(this.btUpdateLow);
            this.Controls.Add(this.btUpdateHigh);
            this.Controls.Add(this.btUpdateOpen);
            this.Controls.Add(this.btUpdateSymbol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btUpdatePrice);
            this.Controls.Add(this.lblSimulate);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSL3Value);
            this.Controls.Add(this.lblTP3Value);
            this.Controls.Add(this.lblTimeZoneValue);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblWinRewardValue);
            this.Controls.Add(this.lblSL2Value);
            this.Controls.Add(this.lblTP2Value);
            this.Controls.Add(this.lblLossRiskValue);
            this.Controls.Add(this.lblSL1Value);
            this.Controls.Add(this.lblTP1Value);
            this.Controls.Add(this.lblCurrentPriceValue);
            this.Controls.Add(this.lblSDPTValue);
            this.Controls.Add(this.lblMeanPTValue);
            this.Controls.Add(this.lblIndicatorValue);
            this.Controls.Add(this.lblSDValue);
            this.Controls.Add(this.lblStandardDeviation);
            this.Controls.Add(this.lblMeanValue);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblSL3);
            this.Controls.Add(this.btImportData);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblWinReward);
            this.Controls.Add(this.lblSL2);
            this.Controls.Add(this.lblLossRisk);
            this.Controls.Add(this.lblTP3);
            this.Controls.Add(this.lblSL1);
            this.Controls.Add(this.lblTP2);
            this.Controls.Add(this.lblTP1);
            this.Controls.Add(this.lblCurrrentPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.predictionGraph);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "OWTradingBrain";
            ((System.ComponentModel.ISupportInitialize)(this.predictionGraph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox predictionGraph;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblMeanValue;
        private System.Windows.Forms.Label lblStandardDeviation;
        private System.Windows.Forms.Label lblSDValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label btReset;
        private System.Windows.Forms.Label lblSimulate;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Label lblIndicatorValue;
        private System.Windows.Forms.TextBox tbCurrentPrice;
        private System.Windows.Forms.TextBox tbOpen;
        private System.Windows.Forms.TextBox tbHigh;
        private System.Windows.Forms.TextBox tbLow;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMeanPTValue;
        private System.Windows.Forms.Label lblSDPTValue;
        private System.Windows.Forms.Label lblTP1;
        private System.Windows.Forms.Label lblTP1Value;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nASDAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCurrencyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBPUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDCADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDMXNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCryptoCurrencyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTCUSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eTHUSDToolStripMenuItem;
        private System.Windows.Forms.Label lblTP2;
        private System.Windows.Forms.Label lblTP3;
        private System.Windows.Forms.Label lblTP2Value;
        private System.Windows.Forms.Label lblTP3Value;
        private System.Windows.Forms.Label lblCurrrentPrice;
        private System.Windows.Forms.Label lblCurrentPriceValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Label lblSL1;
        private System.Windows.Forms.Label lblSL2;
        private System.Windows.Forms.Label lblSL3;
        private System.Windows.Forms.Label lblSL1Value;
        private System.Windows.Forms.Label lblSL2Value;
        private System.Windows.Forms.Label lblSL3Value;
        private System.Windows.Forms.Label lblLossRisk;
        private System.Windows.Forms.Label lblWinReward;
        private System.Windows.Forms.Label lblLossRiskValue;
        private System.Windows.Forms.Label lblWinRewardValue;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label btUpdatePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btUpdateOpen;
        private System.Windows.Forms.Label btUpdateHigh;
        private System.Windows.Forms.Label btUpdateLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btReleaseGraph;
        private System.Windows.Forms.Label btRunCalculation;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.ComponentModel.BackgroundWorker backgroundWorker9;
        private System.ComponentModel.BackgroundWorker backgroundWorker10;
        private System.Windows.Forms.Label btLiveData;
        private System.Windows.Forms.TextBox tbSymbol;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label btUpdateSymbol;
        private System.Windows.Forms.Label lblSymbolTitle;
        private System.Windows.Forms.Label btImportData;
        private System.Windows.Forms.OpenFileDialog openFileDialogData;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTimeZoneValue;
    }
}

