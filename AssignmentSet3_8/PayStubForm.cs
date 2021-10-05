using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSet3_8
{
    public partial class PayStubForm : Form
    {

        private PayStub aPayStub;

        //Declare local variables
        string employeeName;
        decimal hoursWorked, payRate;

        public PayStubForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePayStub_Click(object sender, EventArgs e)
        {

            //Check txtEmployeeName textbox for valid name
            if (txtEmployeeName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter an employee name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeName.Focus();
                return;
            }

            //Assign input data to variables
            employeeName = txtEmployeeName.Text;
            hoursWorked = nudHoursWorked.Value;
            payRate = nudPayRate.Value;

            //Instantiate a Pay Stub object
            aPayStub = new PayStub(employeeName, hoursWorked, payRate);


            //Format net pay message with 2 decimal places
            string messageNetPay = $"The net pay for {employeeName} is: ${aPayStub.NetPay.ToString("n2"):n2}";

            //Display message
            lblDisplayData.Text = messageNetPay;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset form values
            txtEmployeeName.Clear();
            nudHoursWorked.Value = nudHoursWorked.Minimum;
            nudPayRate.Value = nudPayRate.Minimum;
            lblDisplayData.Text = null;
        }

        private void btnDisplaySummary_Click(object sender, EventArgs e)
        {
            decimal avg = PayStub.AverageNetPay();

            //Assemble the total number of pay stubs, total gross pay, total net pay, and the average net pay
            string messageDisplaySummary = $"Paystub Summary for All Employees: \n Number of paystubs: {PayStub.TotalPayStubs:n0} \n Total Gross Pay: ${PayStub.TotalGrossPay:n2} \n Total Net Pay: ${PayStub.TotalNetPay:n2} \n Average Net Pay: ${avg:n2}";

            //Display message
            lblDisplayData.Text = messageDisplaySummary;
        }
    }
}
