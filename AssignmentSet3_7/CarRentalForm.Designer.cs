
namespace AssignmentSet3_7
{
    partial class CarRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentalForm));
            this.gpbRentalValues = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.nudBeginOdom = new System.Windows.Forms.NumericUpDown();
            this.nudEndOdom = new System.Windows.Forms.NumericUpDown();
            this.nudDaysRented = new System.Windows.Forms.NumericUpDown();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBeginOdom = new System.Windows.Forms.Label();
            this.lblEndOdom = new System.Windows.Forms.Label();
            this.lblDaysRented = new System.Windows.Forms.Label();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayData = new System.Windows.Forms.Label();
            this.gpbRentalValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginOdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndOdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRentalValues
            // 
            this.gpbRentalValues.Controls.Add(this.lblCustomerName);
            this.gpbRentalValues.Controls.Add(this.lblBeginOdom);
            this.gpbRentalValues.Controls.Add(this.lblEndOdom);
            this.gpbRentalValues.Controls.Add(this.lblDaysRented);
            this.gpbRentalValues.Controls.Add(this.txtCustomerName);
            this.gpbRentalValues.Controls.Add(this.nudBeginOdom);
            this.gpbRentalValues.Controls.Add(this.nudEndOdom);
            this.gpbRentalValues.Controls.Add(this.nudDaysRented);
            this.gpbRentalValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRentalValues.Location = new System.Drawing.Point(12, 12);
            this.gpbRentalValues.Name = "gpbRentalValues";
            this.gpbRentalValues.Size = new System.Drawing.Size(304, 143);
            this.gpbRentalValues.TabIndex = 0;
            this.gpbRentalValues.TabStop = false;
            this.gpbRentalValues.Text = "Car Rental Values";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 25);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(164, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // nudBeginOdom
            // 
            this.nudBeginOdom.Location = new System.Drawing.Point(164, 51);
            this.nudBeginOdom.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudBeginOdom.Name = "nudBeginOdom";
            this.nudBeginOdom.Size = new System.Drawing.Size(120, 20);
            this.nudBeginOdom.TabIndex = 2;
            // 
            // nudEndOdom
            // 
            this.nudEndOdom.Location = new System.Drawing.Point(164, 77);
            this.nudEndOdom.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudEndOdom.Name = "nudEndOdom";
            this.nudEndOdom.Size = new System.Drawing.Size(120, 20);
            this.nudEndOdom.TabIndex = 3;
            // 
            // nudDaysRented
            // 
            this.nudDaysRented.Location = new System.Drawing.Point(164, 103);
            this.nudDaysRented.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDaysRented.Name = "nudDaysRented";
            this.nudDaysRented.Size = new System.Drawing.Size(120, 20);
            this.nudDaysRented.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(27, 27);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblBeginOdom
            // 
            this.lblBeginOdom.AutoSize = true;
            this.lblBeginOdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginOdom.Location = new System.Drawing.Point(6, 53);
            this.lblBeginOdom.Name = "lblBeginOdom";
            this.lblBeginOdom.Size = new System.Drawing.Size(106, 13);
            this.lblBeginOdom.TabIndex = 2;
            this.lblBeginOdom.Text = "Beginning Odometer:";
            // 
            // lblEndOdom
            // 
            this.lblEndOdom.AutoSize = true;
            this.lblEndOdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOdom.Location = new System.Drawing.Point(20, 79);
            this.lblEndOdom.Name = "lblEndOdom";
            this.lblEndOdom.Size = new System.Drawing.Size(92, 13);
            this.lblEndOdom.TabIndex = 3;
            this.lblEndOdom.Text = "Ending Odometer:";
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRented.Location = new System.Drawing.Point(40, 105);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(72, 13);
            this.lblDaysRented.TabIndex = 4;
            this.lblDaysRented.Text = "Days Rented:";
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCar.Location = new System.Drawing.Point(338, 12);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(197, 23);
            this.btnCreateCar.TabIndex = 1;
            this.btnCreateCar.Text = "Create Car Rental";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnReset
            // 
            this.btnReset.AllowDrop = true;
            this.btnReset.Location = new System.Drawing.Point(338, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(460, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayData
            // 
            this.lblDisplayData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayData.Location = new System.Drawing.Point(338, 44);
            this.lblDisplayData.Name = "lblDisplayData";
            this.lblDisplayData.Size = new System.Drawing.Size(197, 65);
            this.lblDisplayData.TabIndex = 4;
            this.lblDisplayData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarRentalForm
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(555, 173);
            this.Controls.Add(this.lblDisplayData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.gpbRentalValues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental";
            this.gpbRentalValues.ResumeLayout(false);
            this.gpbRentalValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginOdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndOdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRentalValues;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBeginOdom;
        private System.Windows.Forms.Label lblEndOdom;
        private System.Windows.Forms.Label lblDaysRented;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.NumericUpDown nudBeginOdom;
        private System.Windows.Forms.NumericUpDown nudEndOdom;
        private System.Windows.Forms.NumericUpDown nudDaysRented;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplayData;
    }
}

