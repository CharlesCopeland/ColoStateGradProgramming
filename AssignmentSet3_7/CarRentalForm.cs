using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSet3_7
{
    public partial class CarRentalForm : Form
    {
        //Declare object
        private CarRental aCarRental;

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            //Check txtCustomerName textbox for valid name
            if (txtCustomerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a customer name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }

            //Declare local variables
            string customerName;
            int beginOdometerReading, daysRented, endOdometerReading;

            //Assign input data to variables
            customerName = txtCustomerName.Text;
            beginOdometerReading = (int)nudBeginOdom.Value;
            endOdometerReading = (int)nudEndOdom.Value;
            daysRented = (int)nudDaysRented.Value;

            //Instantiate a Car Rental object
            aCarRental = new CarRental(customerName, beginOdometerReading, daysRented, endOdometerReading);


            //Format message with 2 decimal places
            string message = $"The total car rental amount for {customerName} is ${aCarRental.RentalCharge:n2}.";

            //Display message
            lblDisplayData.Text = message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resest form fields
            lblDisplayData.Text = null;
            txtCustomerName.Clear();
            nudBeginOdom.Value = nudBeginOdom.Minimum;
            nudEndOdom.Value = nudEndOdom.Minimum;
            nudDaysRented.Value = nudDaysRented.Minimum;
        }
    }
}
