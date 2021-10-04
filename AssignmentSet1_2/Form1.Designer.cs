
namespace AssignmentSet1_2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(210, 388);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(333, 32);
            this.lblDeveloper.TabIndex = 7;
            this.lblDeveloper.Text = "Developed By: Copeland Felts";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(125, 126);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(200, 39);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(468, 126);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(200, 39);
            this.txtRadius.TabIndex = 17;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(55, 198);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(150, 46);
            this.btnArea.TabIndex = 11;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(55, 262);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(150, 46);
            this.btnVolume.TabIndex = 12;
            this.btnVolume.Text = "Volume";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(33, 129);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(90, 32);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "Height";
            // 
            // lblRadius
            // 
            this.lblRadius.Location = new System.Drawing.Point(0, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(100, 23);
            this.lblRadius.TabIndex = 19;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(33, 45);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(601, 37);
            this.lblText.TabIndex = 15;
            this.lblText.Text = "Please enter the height and radius of the cylinder:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(241, 227);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(489, 52);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Radius";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeveloper);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 1 | Program 2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label txtDisplay;
        private System.Windows.Forms.Label label1;
    }
}

