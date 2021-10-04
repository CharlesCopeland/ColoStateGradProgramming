using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Class Name:           AssignmentSet2 (AssignmentSet2_3)
//Class Description:    Initialize and configure form utilities
//Developer Name:       Copeland Felts
//Date Created:         9/16/2021
//Date Last Modified:   9/16/2021

namespace AssignmentSet2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                                                     //Exit application on button click - on escape key
        }

        private void cbxLogo_CheckedChanged(object sender, EventArgs e)                       //Set Logo as visible - boolean
        {
            pbxLogo.Visible = cbxLogo.Checked;
        }

        private void cbxName_CheckedChanged(object sender, EventArgs e)                       //Set Name as visible - boolean
        {
            lblName.Visible = cbxName.Checked;
        }

        private void cbxTagline_CheckedChanged(object sender, EventArgs e)                    //Set Tagline as visible - boolean
        {
            lblTagline.Visible = cbxTagline.Checked;
        }

        private void cbxDeveloper_CheckedChanged(object sender, EventArgs e)                  //Set Developer as visible - boolean
        {
            lblDeveloper.Visible = cbxDeveloper.Checked;
        }

        private void rbtnBlue_CheckedChanged(object sender, EventArgs e)                      //Set Tagline as blue when selected
        {
            lblTagline.ForeColor = Color.Blue;
        }

        private void rbtnBlack_CheckedChanged(object sender, EventArgs e)                     //Set Tagline as black when selected
        {
            lblTagline.ForeColor = Color.Black;
        }

        private void rbtnGreen_CheckedChanged(object sender, EventArgs e)                     //Set Tagline as green when selected
        {
            lblTagline.ForeColor = Color.Green;
        }

        private void rbtnRed_CheckedChanged(object sender, EventArgs e)                      //Set Tagline as red when selected
        {
            lblTagline.ForeColor = Color.Red;
        }

        private void btnReset_Click(object sender, EventArgs e)                              //Reset form to inital state - on enter key
        {
            pbxLogo.Visible = true;
            lblTagline.Visible = true;
            lblName.Visible = true;
            lblTagline.Visible = true;
            lblDeveloper.Visible = true;

            lblTagline.ForeColor = Color.Black;

            rbtnBlack.Checked = true;
            rbtnBlue.Checked = false;
            rbtnGreen.Checked = false;
            rbtnRed.Checked = false;

            cbxDeveloper.Checked = true;
            cbxLogo.Checked = true;
            cbxName.Checked = true;
            cbxTagline.Checked = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
