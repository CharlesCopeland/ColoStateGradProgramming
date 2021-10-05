
namespace AssignmentSet3_8
{
    partial class PayStubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayStubForm));
            this.gpbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnCreatePayStub = new System.Windows.Forms.Button();
            this.lblDisplayData = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplaySummary = new System.Windows.Forms.Button();
            this.gpbEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEmployeeDetails
            // 
            this.gpbEmployeeDetails.Controls.Add(this.lblPayRate);
            this.gpbEmployeeDetails.Controls.Add(this.lblHoursWorked);
            this.gpbEmployeeDetails.Controls.Add(this.lblName);
            this.gpbEmployeeDetails.Controls.Add(this.nudPayRate);
            this.gpbEmployeeDetails.Controls.Add(this.nudHoursWorked);
            this.gpbEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gpbEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEmployeeDetails.Location = new System.Drawing.Point(12, 12);
            this.gpbEmployeeDetails.Name = "gpbEmployeeDetails";
            this.gpbEmployeeDetails.Size = new System.Drawing.Size(286, 132);
            this.gpbEmployeeDetails.TabIndex = 0;
            this.gpbEmployeeDetails.TabStop = false;
            this.gpbEmployeeDetails.Text = "Employee Pay Details";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(39, 87);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(54, 13);
            this.lblPayRate.TabIndex = 6;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(15, 61);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 5;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Employee Name:";
            // 
            // nudPayRate
            // 
            this.nudPayRate.DecimalPlaces = 2;
            this.nudPayRate.Location = new System.Drawing.Point(108, 84);
            this.nudPayRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(120, 20);
            this.nudPayRate.TabIndex = 3;
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.DecimalPlaces = 2;
            this.nudHoursWorked.Location = new System.Drawing.Point(108, 58);
            this.nudHoursWorked.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(120, 20);
            this.nudHoursWorked.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 32);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(154, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // btnCreatePayStub
            // 
            this.btnCreatePayStub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePayStub.Location = new System.Drawing.Point(315, 21);
            this.btnCreatePayStub.Name = "btnCreatePayStub";
            this.btnCreatePayStub.Size = new System.Drawing.Size(241, 23);
            this.btnCreatePayStub.TabIndex = 1;
            this.btnCreatePayStub.Text = "Create Paystub";
            this.btnCreatePayStub.UseVisualStyleBackColor = true;
            this.btnCreatePayStub.Click += new System.EventHandler(this.btnCreatePayStub_Click);
            // 
            // lblDisplayData
            // 
            this.lblDisplayData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayData.Location = new System.Drawing.Point(315, 73);
            this.lblDisplayData.Name = "lblDisplayData";
            this.lblDisplayData.Size = new System.Drawing.Size(241, 71);
            this.lblDisplayData.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(315, 152);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplaySummary
            // 
            this.btnDisplaySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySummary.Location = new System.Drawing.Point(315, 47);
            this.btnDisplaySummary.Name = "btnDisplaySummary";
            this.btnDisplaySummary.Size = new System.Drawing.Size(241, 23);
            this.btnDisplaySummary.TabIndex = 5;
            this.btnDisplaySummary.Text = "Display Summary";
            this.btnDisplaySummary.UseVisualStyleBackColor = true;
            this.btnDisplaySummary.Click += new System.EventHandler(this.btnDisplaySummary_Click);
            // 
            // PayStubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 187);
            this.Controls.Add(this.btnDisplaySummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDisplayData);
            this.Controls.Add(this.btnCreatePayStub);
            this.Controls.Add(this.gpbEmployeeDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayStubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Paystubs";
            this.gpbEmployeeDetails.ResumeLayout(false);
            this.gpbEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEmployeeDetails;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Button btnCreatePayStub;
        private System.Windows.Forms.Label lblDisplayData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplaySummary;
    }
}

