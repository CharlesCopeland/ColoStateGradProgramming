using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*******************************************************************
//Class Name:            frmMain : Form
//Class Description:     Call method and display area and volume from user input
//Developer Name:        Copeland Felts
//Date Created:          09/03/2021
//Date Last Modified:    09/03/2021
//*******************************************************************

namespace AssignmentSet1_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                             //Close program
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            int inputHeight = 0;                                       //Declare height variable
            int inputRadius = 0;                                       //Declare radius variable

            inputHeight = int.Parse(txtHeight.Text);                   //Pass the height input to var
            inputRadius = int.Parse(txtRadius.Text);                   //Pass the radius input to var  

            txtDisplay.Text = "The volume of the cylinder is: " + Cylinder.CalcVolume(Convert.ToInt32(inputRadius), Convert.ToInt32(inputHeight)).ToString("N2");   //Call volume method and pass inputs - return double
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int inputHeight = 0;                                       //Declare height variable
            int inputRadius = 0;                                       //Declare radius variable

            inputHeight = int.Parse(txtHeight.Text);                   //Pass the height input to var
            inputRadius = int.Parse(txtRadius.Text);                   //Pass the radius input to var  

            txtDisplay.Text = "The area of the cylinder is: " + Cylinder.CalcArea(Convert.ToInt32(inputRadius), Convert.ToInt32(inputHeight)).ToString("N2");     //Call area method and pass inputs - return double
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
   
}
