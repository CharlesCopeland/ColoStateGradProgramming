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
//Class Name:            FromMain: Form
//Class Description:     Initialize buttons and return results in lbl
//Developer Name:        Copeland Felts
//Date Created:          09/03/2021
//Date Last Modified:    09/03/2021
//*******************************************************************

namespace AssignmentSet1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                                             //Close Program
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            lblFavorites.Text = MyFavorites.MyFavoriteHobby();       //Call Hobby method and display
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            lblFavorites.Text = MyFavorites.MyFavoriteSport();       //Call Sport method and display
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            lblFavorites.Text = MyFavorites.MyFavoriteFood();        //Call Food method and display
        }
    }
}