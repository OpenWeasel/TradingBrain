namespace OpenWeaselTradingBrain
{
    partial class Chart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGraphPrediction = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphPrediction)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraphPrediction
            // 
            this.pbGraphPrediction.Location = new System.Drawing.Point(0, 0);
            this.pbGraphPrediction.Name = "pbGraphPrediction";
            this.pbGraphPrediction.Size = new System.Drawing.Size(507, 595);
            this.pbGraphPrediction.TabIndex = 0;
            this.pbGraphPrediction.TabStop = false;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGraphPrediction);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(1045, 595);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphPrediction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphPrediction;
    }
}
