using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentSet4_9
{
    public partial class AggieCatering : Form
    {

        //Declare CateringEvent Object Variable
        private CateringEvent aCateringEvent;

        //Declare local variables
        string eventName;
        int numberOfGuests;
        EntreType entreChoice;
        bool openBar, wineWithDinner;

        public AggieCatering()
        {
            InitializeComponent();

            btnModifyEvent.Enabled = false;
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
                txtEventName.Focus();
            }
        }

        private void lblDrinkInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEventName.Clear();
            nudNumOfGuests.Value = nudNumOfGuests.Minimum;
            rabSteak.Checked = true;
            chbOpenBar.Checked = false;
            chbWine.Checked = false;
            lblDisplay.Text = null;

            txtEventName.Focus();
            btnModifyEvent.Enabled = false;
            btnCreateEvent.Enabled = true;
            txtEventName.Enabled = true;

        }

        private void btnModifyEvent_Click(object sender, EventArgs e)
        {
            //Assign inputs to local variables
            numberOfGuests = Convert.ToInt32(nudNumOfGuests.Value);
            openBar = chbOpenBar.Checked;
            wineWithDinner = chbWine.Checked;

            //Check and assign enumeration for entre type
            if (rabSteak.Checked)
            {
                entreChoice = EntreType.RibEyeSteak;
            }
            else if (rabChicken.Checked)
            {
                entreChoice = EntreType.GrilledChicken;
            }
            else
            {
                entreChoice = EntreType.GardenLasagna;
            }

            //Instantiate a new Catering Event object
            aCateringEvent = new CateringEvent(eventName, numberOfGuests, entreChoice, openBar, wineWithDinner);


            //Format display strings
            String line0 = $"Pricing Summary: {eventName}";
            String line1 = $"Entre Price: ${aCateringEvent.EntreCharge}";
            String line2 = $"Drink Price: ${aCateringEvent.DrinksCharge}";
            String line3 = $"Surcharge Price: ${aCateringEvent.SurCharge}";
            String line4 = $"Total Price: ${aCateringEvent.TotalCharge}";

            //Display formated strings
            lblDisplay.Text = line0 + "\n" + "\n" + line1 + "\n" + line2 + "\n" + line3 + "\n" + line4;
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            //Enforce an Event Name
            if (txtEventName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the name of the event!", "Event Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEventName.Focus();
                return;
            }

            //Assign inputs to local variables
            eventName = txtEventName.Text;
            numberOfGuests = Convert.ToInt32(nudNumOfGuests.Value);
            openBar = chbOpenBar.Checked;
            wineWithDinner = chbWine.Checked;

            //Check and assign enumeration for entre type
            if (rabSteak.Checked)
            {
                entreChoice = EntreType.RibEyeSteak;
            }
            else if (rabChicken.Checked)
            {
                entreChoice = EntreType.GrilledChicken;
            }
            else
            {
                entreChoice = EntreType.GardenLasagna;
            }

            //Instantiate a new Catering Event object
            aCateringEvent = new CateringEvent(eventName, numberOfGuests, entreChoice, openBar, wineWithDinner);


            //Format display strings
            String line0 = $"Pricing Summary: {eventName}";
            String line1 = $"Entre Price: ${aCateringEvent.EntreCharge}";
            String line2 = $"Drink Price: ${aCateringEvent.DrinksCharge}";
            String line3 = $"Surcharge Price: ${aCateringEvent.SurCharge}";
            String line4 = $"Total Price: ${aCateringEvent.TotalCharge}";

            //Display formated strings
            lblDisplay.Text = line0 + "\n" + "\n" + line1 + "\n" + line2 + "\n" + line3 + "\n" + line4;

            //Set modify event button to enabled and event name/create event button to disabled
            btnModifyEvent.Enabled = true;
            btnCreateEvent.Enabled = false;
            txtEventName.Enabled = false;

        }
    }
}
