
namespace AssignmentSet2_4
{
    partial class FormROI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormROI));
            this.lblTop = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnFuture = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudInvestValue = new System.Windows.Forms.NumericUpDown();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblInvestment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvestValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(80, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(260, 24);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Future Value of Investment";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(37, 50);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(167, 15);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Enter Investment Details:";
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // btnFuture
            // 
            this.btnFuture.Location = new System.Drawing.Point(48, 231);
            this.btnFuture.Name = "btnFuture";
            this.btnFuture.Size = new System.Drawing.Size(75, 23);
            this.btnFuture.TabIndex = 5;
            this.btnFuture.Text = "Future Value";
            this.btnFuture.UseVisualStyleBackColor = true;
            this.btnFuture.Click += new System.EventHandler(this.btnFuture_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(379, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(48, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(155, 323);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(149, 13);
            this.lblDeveloper.TabIndex = 12;
            this.lblDeveloper.Text = "Developed by: Copeland Felts";
            // 
            // nudRate
            // 
            this.nudRate.DecimalPlaces = 1;
            this.nudRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRate.Location = new System.Drawing.Point(255, 178);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(100, 20);
            this.nudRate.TabIndex = 13;
            this.nudRate.ValueChanged += new System.EventHandler(this.nudRate_ValueChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.DecimalPlaces = 1;
            this.nudDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDuration.Location = new System.Drawing.Point(255, 129);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(100, 20);
            this.nudDuration.TabIndex = 14;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
            // 
            // nudInvestValue
            // 
            this.nudInvestValue.Location = new System.Drawing.Point(255, 85);
            this.nudInvestValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudInvestValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInvestValue.Name = "nudInvestValue";
            this.nudInvestValue.Size = new System.Drawing.Size(100, 20);
            this.nudInvestValue.TabIndex = 15;
            this.nudInvestValue.ThousandsSeparator = true;
            this.nudInvestValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Location = new System.Drawing.Point(158, 231);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(197, 23);
            this.lblTotalValue.TabIndex = 16;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalValue.Click += new System.EventHandler(this.lblTotalValue_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(42, 178);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(162, 13);
            this.lblRate.TabIndex = 17;
            this.lblRate.Text = "Annual Interest Rate Percentage";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(49, 129);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(155, 13);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration of Investment in Years";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblInvestment
            // 
            this.lblInvestment.AutoSize = true;
            this.lblInvestment.Location = new System.Drawing.Point(117, 87);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(87, 13);
            this.lblInvestment.TabIndex = 19;
            this.lblInvestment.Text = "Amount to Invest";
            this.lblInvestment.Click += new System.EventHandler(this.LblInvestment_Click);
            // 
            // FormROI
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(466, 345);
            this.Controls.Add(this.lblInvestment);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.nudInvestValue);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFuture);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormROI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return on Investment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInvestValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnFuture;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudInvestValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblInvestment;
    }
}

