using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Class Name:           AssignmentSet2_5
//Class Description:    Compute the cost to build a deck using an instance class
//Developer Name:       Copeland Felts
//Date Created:         9/19/2021
//Date Last Modified:   9/21/2021

namespace AssignmentSet2_5
{
    public partial class Form1 : Form
    {
        public Form1()                                                                      //Initialize form
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudFootage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudLumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudStain_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeck_Click(object sender, EventArgs e)                         //Create a new deck object on button click, call CalcBuildCost method
        {
            int sqFt;
            double lumber, stain, deckTotal;                                           //Declare local variables

            Deck deck1;

            sqFt = (int)nudFootage.Value;
            lumber = (double)nudLumber.Value;
            stain = (double)nudStain.Value;

            deck1 = new Deck                                                          //Create deck1 object
            {
                SquareFootage = sqFt,
                Lumber = lumber,
                Stain = stain
            };

            deckTotal = deck1.CalcBuildCost();                                       //Call method

            lblDeck.Text = $"Nice Deck Total: {deckTotal:C}";
        }

        private void lblDeck_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)                       //Reset number up/down and label to default values on buton click
        {
            nudFootage.Value = 1;
            nudLumber.Value = 0;
            nudStain.Value = 0;
            lblDeck.Text = null;
        }
    }
}