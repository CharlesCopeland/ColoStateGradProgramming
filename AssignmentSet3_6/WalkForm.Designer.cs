
namespace AssignmentSet3_6
{
    partial class WalkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalkForm));
            this.gpbInputs = new System.Windows.Forms.GroupBox();
            this.lblLengthOfStep = new System.Windows.Forms.Label();
            this.lblNumOfSteps = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtWalkerName = new System.Windows.Forms.TextBox();
            this.nudNumberOfSteps = new System.Windows.Forms.NumericUpDown();
            this.nudLengthOfStep = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengthOfStep)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInputs
            // 
            this.gpbInputs.Controls.Add(this.lblLengthOfStep);
            this.gpbInputs.Controls.Add(this.lblNumOfSteps);
            this.gpbInputs.Controls.Add(this.lblName);
            this.gpbInputs.Controls.Add(this.txtWalkerName);
            this.gpbInputs.Controls.Add(this.nudNumberOfSteps);
            this.gpbInputs.Controls.Add(this.nudLengthOfStep);
            this.gpbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInputs.Location = new System.Drawing.Point(12, 48);
            this.gpbInputs.Name = "gpbInputs";
            this.gpbInputs.Size = new System.Drawing.Size(255, 146);
            this.gpbInputs.TabIndex = 0;
            this.gpbInputs.TabStop = false;
            this.gpbInputs.Text = "Walker Data";
            // 
            // lblLengthOfStep
            // 
            this.lblLengthOfStep.AutoSize = true;
            this.lblLengthOfStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthOfStep.Location = new System.Drawing.Point(16, 108);
            this.lblLengthOfStep.Name = "lblLengthOfStep";
            this.lblLengthOfStep.Size = new System.Drawing.Size(80, 26);
            this.lblLengthOfStep.TabIndex = 5;
            this.lblLengthOfStep.Text = "Length of Step:\r\n(inches)";
            this.lblLengthOfStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumOfSteps
            // 
            this.lblNumOfSteps.AutoSize = true;
            this.lblNumOfSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfSteps.Location = new System.Drawing.Point(6, 67);
            this.lblNumOfSteps.Name = "lblNumOfSteps";
            this.lblNumOfSteps.Size = new System.Drawing.Size(89, 13);
            this.lblNumOfSteps.TabIndex = 4;
            this.lblNumOfSteps.Text = "Number of Steps:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtWalkerName
            // 
            this.txtWalkerName.Location = new System.Drawing.Point(117, 26);
            this.txtWalkerName.Name = "txtWalkerName";
            this.txtWalkerName.Size = new System.Drawing.Size(120, 20);
            this.txtWalkerName.TabIndex = 2;
            // 
            // nudNumberOfSteps
            // 
            this.nudNumberOfSteps.Location = new System.Drawing.Point(117, 65);
            this.nudNumberOfSteps.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumberOfSteps.Name = "nudNumberOfSteps";
            this.nudNumberOfSteps.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfSteps.TabIndex = 1;
            // 
            // nudLengthOfStep
            // 
            this.nudLengthOfStep.Location = new System.Drawing.Point(117, 106);
            this.nudLengthOfStep.Name = "nudLengthOfStep";
            this.nudLengthOfStep.Size = new System.Drawing.Size(120, 20);
            this.nudLengthOfStep.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(48, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(189, 26);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Please enter your information below to \r\ncalculate your miles walked:";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateObject.Location = new System.Drawing.Point(66, 210);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(156, 23);
            this.btnCreateObject.TabIndex = 4;
            this.btnCreateObject.Text = "Calculate Miles Walked";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 249);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(255, 34);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(66, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(147, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WalkForm
            // 
            this.AcceptButton = this.btnCreateObject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(281, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gpbInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WalkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walk Calculator";
            this.gpbInputs.ResumeLayout(false);
            this.gpbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengthOfStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInputs;
        private System.Windows.Forms.Label lblLengthOfStep;
        private System.Windows.Forms.Label lblNumOfSteps;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtWalkerName;
        private System.Windows.Forms.NumericUpDown nudNumberOfSteps;
        private System.Windows.Forms.NumericUpDown nudLengthOfStep;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

