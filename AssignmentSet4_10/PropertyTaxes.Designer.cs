
namespace AssignmentSet4_10
{
    partial class PropertyTaxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyTaxes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPropertyOwner = new System.Windows.Forms.Label();
            this.lblBuildingSquareFootage = new System.Windows.Forms.Label();
            this.lblLandSquareFootage = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblPropertyLocation = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.nudBuildingSquareFootage = new System.Windows.Forms.NumericUpDown();
            this.nudLandSquareFootage = new System.Windows.Forms.NumericUpDown();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.radUrban = new System.Windows.Forms.RadioButton();
            this.radSuburban = new System.Windows.Forms.RadioButton();
            this.radRural = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.gpbDisplay = new System.Windows.Forms.GroupBox();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.btnCreatePropertyTax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildingSquareFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSquareFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.gpbDisplay.SuspendLayout();
            this.gpbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRural);
            this.groupBox1.Controls.Add(this.radSuburban);
            this.groupBox1.Controls.Add(this.radUrban);
            this.groupBox1.Controls.Add(this.nudYearBuilt);
            this.groupBox1.Controls.Add(this.nudLandSquareFootage);
            this.groupBox1.Controls.Add(this.nudBuildingSquareFootage);
            this.groupBox1.Controls.Add(this.txtOwnerName);
            this.groupBox1.Controls.Add(this.lblPropertyLocation);
            this.groupBox1.Controls.Add(this.lblYearBuilt);
            this.groupBox1.Controls.Add(this.lblLandSquareFootage);
            this.groupBox1.Controls.Add(this.lblBuildingSquareFootage);
            this.groupBox1.Controls.Add(this.lblPropertyOwner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Information";
            // 
            // lblPropertyOwner
            // 
            this.lblPropertyOwner.AutoSize = true;
            this.lblPropertyOwner.Location = new System.Drawing.Point(6, 27);
            this.lblPropertyOwner.Name = "lblPropertyOwner";
            this.lblPropertyOwner.Size = new System.Drawing.Size(114, 13);
            this.lblPropertyOwner.TabIndex = 0;
            this.lblPropertyOwner.Text = "Property Owner Name:";
            // 
            // lblBuildingSquareFootage
            // 
            this.lblBuildingSquareFootage.AutoSize = true;
            this.lblBuildingSquareFootage.Location = new System.Drawing.Point(6, 64);
            this.lblBuildingSquareFootage.Name = "lblBuildingSquareFootage";
            this.lblBuildingSquareFootage.Size = new System.Drawing.Size(126, 13);
            this.lblBuildingSquareFootage.TabIndex = 1;
            this.lblBuildingSquareFootage.Text = "Building Square Footage:";
            // 
            // lblLandSquareFootage
            // 
            this.lblLandSquareFootage.AutoSize = true;
            this.lblLandSquareFootage.Location = new System.Drawing.Point(7, 103);
            this.lblLandSquareFootage.Name = "lblLandSquareFootage";
            this.lblLandSquareFootage.Size = new System.Drawing.Size(113, 13);
            this.lblLandSquareFootage.TabIndex = 2;
            this.lblLandSquareFootage.Text = "Land Square Footage:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(6, 135);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(55, 13);
            this.lblYearBuilt.TabIndex = 3;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // lblPropertyLocation
            // 
            this.lblPropertyLocation.AutoSize = true;
            this.lblPropertyLocation.Location = new System.Drawing.Point(6, 171);
            this.lblPropertyLocation.Name = "lblPropertyLocation";
            this.lblPropertyLocation.Size = new System.Drawing.Size(105, 13);
            this.lblPropertyLocation.TabIndex = 4;
            this.lblPropertyLocation.Text = "Location of Property:";
            this.lblPropertyLocation.Click += new System.EventHandler(this.lblPropertyLocation_Click);
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(156, 24);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(177, 20);
            this.txtOwnerName.TabIndex = 5;
            this.txtOwnerName.TextChanged += new System.EventHandler(this.txtOwnerName_TextChanged);
            // 
            // nudBuildingSquareFootage
            // 
            this.nudBuildingSquareFootage.Location = new System.Drawing.Point(156, 62);
            this.nudBuildingSquareFootage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBuildingSquareFootage.Name = "nudBuildingSquareFootage";
            this.nudBuildingSquareFootage.Size = new System.Drawing.Size(120, 20);
            this.nudBuildingSquareFootage.TabIndex = 6;
            // 
            // nudLandSquareFootage
            // 
            this.nudLandSquareFootage.Location = new System.Drawing.Point(156, 101);
            this.nudLandSquareFootage.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudLandSquareFootage.Name = "nudLandSquareFootage";
            this.nudLandSquareFootage.Size = new System.Drawing.Size(120, 20);
            this.nudLandSquareFootage.TabIndex = 7;
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(156, 135);
            this.nudYearBuilt.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYearBuilt.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYearBuilt.Name = "nudYearBuilt";
            this.nudYearBuilt.Size = new System.Drawing.Size(120, 20);
            this.nudYearBuilt.TabIndex = 8;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // radUrban
            // 
            this.radUrban.AutoSize = true;
            this.radUrban.Checked = true;
            this.radUrban.Location = new System.Drawing.Point(156, 171);
            this.radUrban.Name = "radUrban";
            this.radUrban.Size = new System.Drawing.Size(54, 17);
            this.radUrban.TabIndex = 9;
            this.radUrban.TabStop = true;
            this.radUrban.Text = "Urban";
            this.radUrban.UseVisualStyleBackColor = true;
            // 
            // radSuburban
            // 
            this.radSuburban.AutoSize = true;
            this.radSuburban.Location = new System.Drawing.Point(156, 194);
            this.radSuburban.Name = "radSuburban";
            this.radSuburban.Size = new System.Drawing.Size(71, 17);
            this.radSuburban.TabIndex = 10;
            this.radSuburban.Text = "Suburban";
            this.radSuburban.UseVisualStyleBackColor = true;
            // 
            // radRural
            // 
            this.radRural.AutoSize = true;
            this.radRural.Location = new System.Drawing.Point(156, 217);
            this.radRural.Name = "radRural";
            this.radRural.Size = new System.Drawing.Size(50, 17);
            this.radRural.TabIndex = 11;
            this.radRural.Text = "Rural";
            this.radRural.UseVisualStyleBackColor = true;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(6, 16);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(231, 148);
            this.lblDisplay.TabIndex = 1;
            // 
            // gpbDisplay
            // 
            this.gpbDisplay.Controls.Add(this.lblDisplay);
            this.gpbDisplay.Location = new System.Drawing.Point(366, 95);
            this.gpbDisplay.Name = "gpbDisplay";
            this.gpbDisplay.Size = new System.Drawing.Size(243, 175);
            this.gpbDisplay.TabIndex = 2;
            this.gpbDisplay.TabStop = false;
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.btnExit);
            this.gpbButtons.Controls.Add(this.btnClear);
            this.gpbButtons.Controls.Add(this.btnCreatePropertyTax);
            this.gpbButtons.Location = new System.Drawing.Point(366, 12);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(243, 88);
            this.gpbButtons.TabIndex = 3;
            this.gpbButtons.TabStop = false;
            // 
            // btnCreatePropertyTax
            // 
            this.btnCreatePropertyTax.Location = new System.Drawing.Point(6, 17);
            this.btnCreatePropertyTax.Name = "btnCreatePropertyTax";
            this.btnCreatePropertyTax.Size = new System.Drawing.Size(231, 23);
            this.btnCreatePropertyTax.TabIndex = 4;
            this.btnCreatePropertyTax.Text = "Create Property Tax";
            this.btnCreatePropertyTax.UseVisualStyleBackColor = true;
            this.btnCreatePropertyTax.Click += new System.EventHandler(this.btnCreatePropertyTax_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 54);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PropertyTaxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 281);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.gpbDisplay);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PropertyTaxes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Tax Assessment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildingSquareFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSquareFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.gpbDisplay.ResumeLayout(false);
            this.gpbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRural;
        private System.Windows.Forms.RadioButton radSuburban;
        private System.Windows.Forms.RadioButton radUrban;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.NumericUpDown nudLandSquareFootage;
        private System.Windows.Forms.NumericUpDown nudBuildingSquareFootage;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblPropertyLocation;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblLandSquareFootage;
        private System.Windows.Forms.Label lblBuildingSquareFootage;
        private System.Windows.Forms.Label lblPropertyOwner;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox gpbDisplay;
        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreatePropertyTax;
    }
}

