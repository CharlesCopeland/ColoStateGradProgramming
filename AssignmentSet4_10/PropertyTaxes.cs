using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSet4_10
{
    public partial class PropertyTaxes : Form
    {
        //Declare Property Tax Object Variable
        private PropertyTax aPropertyTax;

        //Declare local variables
        string propertyOwner;
        int propertySquareFootage, buildingSquareFootage;
        LocationType propertyLocation;
        int yearBuilt;

        public PropertyTaxes()
        {
            InitializeComponent();
        }

        private void lblPropertyLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePropertyTax_Click(object sender, EventArgs e)
        {
            int currentYear = 2021;

            //Enforce an Event Name
            if (txtOwnerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the name of the property owner!", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerName.Focus();
                return;
            }

            if (txtOwnerName.Text.Trim().Length > 30)
            {
                MessageBox.Show("Property owner name cannot exceed 30 characters!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerName.Focus();
                txtOwnerName.Clear();
                return;
            }

            if (Convert.ToInt32(nudYearBuilt.Value) > currentYear)
            {
                MessageBox.Show("Year built cannot be in the future!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudYearBuilt.Focus();
                nudYearBuilt.Value = nudYearBuilt.Minimum;
                return;
            }

            //Assign inputs to local variables
            propertyOwner = txtOwnerName.Text;
            propertySquareFootage = Convert.ToInt32(nudLandSquareFootage.Value);
            buildingSquareFootage = Convert.ToInt32(nudBuildingSquareFootage.Value);
            yearBuilt = Convert.ToInt32(nudYearBuilt.Value);

            //Check and assign enumeration for location type
            if (radUrban.Checked)
            {
                propertyLocation = LocationType.Urban;
            }
            else if (radSuburban.Checked)
            {
                propertyLocation = LocationType.Suburban;
            }
            else
            {
                propertyLocation = LocationType.Rural;
            }

            //Instantiate a new Property Tax object
            aPropertyTax = new PropertyTax(propertyOwner, propertyLocation, buildingSquareFootage, propertySquareFootage, yearBuilt);


            //Format display strings
            String line0 = $"Building Summary for: {propertyOwner}";
            String line1 = $"Building Age: {aPropertyTax.BuildingAge:n0} Years";
            String line2 = $"Building Tax: ${aPropertyTax.BuildingTax:n2}";
            String line3 = $"Building Tax Deduction: ${aPropertyTax.BuildingTaxDeduction:n2}";
            String line4 = $"Land Tax: ${aPropertyTax.LandTax:n2}";
            String line5 = $"Land Tax Deduction: ${aPropertyTax.LandTaxDeduction:n2}";
            String line6 = $"Total Property Tax: ${aPropertyTax.TotalPropertyTax:n2}";

            //Display formated strings
            lblDisplay.Text = line0 + "\n" + "\n" + line1 + "\n" + line2 + "\n" + line4 + "\n" + line3 + "\n" + line5 + "\n" + "\n" + line6;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult aResult;

            aResult = MessageBox.Show("Do you really wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtOwnerName.Focus();
            }
        }

        private void txtOwnerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOwnerName.Clear();
            nudBuildingSquareFootage.Value = nudBuildingSquareFootage.Minimum;
            nudLandSquareFootage.Value = nudLandSquareFootage.Minimum;
            nudYearBuilt.Value = nudYearBuilt.Minimum;

            radUrban.Checked = true;

            lblDisplay.Text = null;
        }
    }
}
