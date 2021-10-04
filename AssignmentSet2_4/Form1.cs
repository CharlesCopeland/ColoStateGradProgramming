using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Class Name:           FormROI : Form 
//Class Description:    Display return on investment amounts and implement calcInvestment class
//Developer Name:       Copeland Felts
//Date Created:         9/19/2021
//Date Last Modified:   9/20/2021

namespace AssignmentSet2_4
{
    public partial class FormROI : Form
    {
        public FormROI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFuture_Click(object sender, EventArgs e)                                           //Declare local variables and call calcInvestment method
        {
            int investmentValue = (int)nudInvestValue.Value;
            double duration = (double)nudDuration.Value;
            double rate = (double)nudRate.Value;

            double futureValue = calcInvestment.calcFutureValue(investmentValue, duration, rate);
            lblTotalValue.Text = $"The future value is: {futureValue:C}";                                 
        }

        private void btnReset_Click(object sender, EventArgs e)                                           //Reset form values to minimums on button click
        {
            nudInvestValue.Value = nudInvestValue.Minimum;
            nudDuration.Value = nudDuration.Minimum;
            nudRate.Value = nudRate.Minimum;
            lblTotalValue.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)                                            //Exit on button click
        {
            this.Close();
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalValue_Click(object sender, EventArgs e)
        {

        }

        private void LblInvestment_Click(object sender, EventArgs e)
        {

        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void lblDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
