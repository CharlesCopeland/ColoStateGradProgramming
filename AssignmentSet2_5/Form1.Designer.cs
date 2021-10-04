
using System;

namespace AssignmentSet2_5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblSquareFootage = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStain = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnDeck = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudFootage = new System.Windows.Forms.NumericUpDown();
            this.nudLumber = new System.Windows.Forms.NumericUpDown();
            this.nudStain = new System.Windows.Forms.NumericUpDown();
            this.lblDeck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            resources.ApplyResources(this.lblHeader1, "lblHeader1");
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeader2
            // 
            resources.ApplyResources(this.lblHeader2, "lblHeader2");
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSquareFootage
            // 
            resources.ApplyResources(this.lblSquareFootage, "lblSquareFootage");
            this.lblSquareFootage.Name = "lblSquareFootage";
            // 
            // lblCost
            // 
            resources.ApplyResources(this.lblCost, "lblCost");
            this.lblCost.Name = "lblCost";
            this.lblCost.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStain
            // 
            resources.ApplyResources(this.lblStain, "lblStain");
            this.lblStain.Name = "lblStain";
            this.lblStain.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblFooter
            // 
            resources.ApplyResources(this.lblFooter, "lblFooter");
            this.lblFooter.Name = "lblFooter";
            // 
            // btnDeck
            // 
            resources.ApplyResources(this.btnDeck, "btnDeck");
            this.btnDeck.Name = "btnDeck";
            this.btnDeck.UseVisualStyleBackColor = true;
            this.btnDeck.Click += new System.EventHandler(this.btnDeck_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudFootage
            // 
            resources.ApplyResources(this.nudFootage, "nudFootage");
            this.nudFootage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFootage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFootage.Name = "nudFootage";
            this.nudFootage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFootage.ValueChanged += new System.EventHandler(this.nudFootage_ValueChanged);
            // 
            // nudLumber
            // 
            this.nudLumber.DecimalPlaces = 2;
            this.nudLumber.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.nudLumber, "nudLumber");
            this.nudLumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLumber.Name = "nudLumber";
            this.nudLumber.ValueChanged += new System.EventHandler(this.nudLumber_ValueChanged);
            // 
            // nudStain
            // 
            this.nudStain.DecimalPlaces = 2;
            this.nudStain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            resources.ApplyResources(this.nudStain, "nudStain");
            this.nudStain.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStain.Name = "nudStain";
            this.nudStain.ValueChanged += new System.EventHandler(this.nudStain_ValueChanged);
            // 
            // lblDeck
            // 
            this.lblDeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblDeck, "lblDeck");
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Click += new System.EventHandler(this.lblDeck_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDeck;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.nudStain);
            this.Controls.Add(this.nudLumber);
            this.Controls.Add(this.nudFootage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeck);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblStain);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblSquareFootage);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblSquareFootage;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStain;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnDeck;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudFootage;
        private System.Windows.Forms.NumericUpDown nudLumber;
        private System.Windows.Forms.NumericUpDown nudStain;
        private System.Windows.Forms.Label lblDeck;
    }
}

