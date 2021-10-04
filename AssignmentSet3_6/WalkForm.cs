using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSet3_6
{
    public partial class WalkForm : Form
    {
        //Declare object variable
        private Walk aWalker;

        public WalkForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            //Check txtWalkerName textbox for valid name
            if (txtWalkerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWalkerName.Focus();
                return;
            }

            //Declare local variables
            string walkerName;
            int numberOfSteps, lengthOfStep;

            //Assign input data to variables
            walkerName = txtWalkerName.Text;
            numberOfSteps = (int)nudNumberOfSteps.Value;
            lengthOfStep = (int)nudLengthOfStep.Value;

            //Instantiate a Walk object
            aWalker = new Walk(lengthOfStep, numberOfSteps, walkerName);

            //Call CalculateMilesWalked method
            double milesWalked;
            milesWalked = aWalker.CalculateMilesWalked();

            //Format message with 2 decimal places
            string message = $"{walkerName} has walked {milesWalked:n2} miles!";

            //Display message
            lblDisplay.Text = message;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resest form fields
            lblDisplay.Text = null;
            txtWalkerName.Clear();
            nudLengthOfStep.Value = nudLengthOfStep.Minimum;
            nudNumberOfSteps.Value = nudNumberOfSteps.Minimum;
        }
    }
}
