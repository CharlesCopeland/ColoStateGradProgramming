using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//***********Class Information****************
//********************************************
//Clas Name:          CateringEvent.cs
//Class Description:  Create a project to calculate event charges for Aggie Catering.  
//                    The program must determine the charges for an event based on the 
//                    number of guests, the selected entre, and chosen drink options. 
//Developer Name:     Copeland Felts
//Date Created:       10/17/2021
//Date Last Modified: 10/17/2021
//********************************************
//********************************************

namespace AssignmentSet4_9
{
    #region "Enumerations"
    public enum EntreType
    {
        RibEyeSteak = 1,
        GrilledChicken = 2,
        GardenLasagna = 3
    }
    #endregion

    class CateringEvent
    {
        #region "Constants"
        const decimal SteakPrice = 87.26M;
        const decimal ChickenPrice = 64.93M;
        const decimal LasagnaPrice = 51.48M;
        const decimal openBarPrice = 54.27M;
        const decimal wineWithDinnerPrice = 47.84M;
        const decimal guestSurcharge = 43.00M;
        const int maxGuest = 75;
        #endregion

        #region "Fields"
        private int numberOfGuests;
        private bool openBar, wineWithDinner;
        private EntreType entreChoice;
        #endregion

        #region "Properties"
        public decimal DrinksCharge { get; private set; }
        public decimal EntreCharge { get; private set; }
        public string EventName { get; set; }
        public decimal SurCharge { get; private set; }
        public decimal TotalCharge { get; private set; }
        public int NumberOfGuests 
        {
            get
            {
                return numberOfGuests;
            }
            set
            {
                numberOfGuests = value;
                EventCharge();
            }
        }
        public EntreType EntreChoice
        {
            get
            {
                return entreChoice;
            }
            set
            {
                entreChoice = value;
                EventCharge();
            }
        }
        public bool OpenBar
        {
            get
            {
                return openBar;
            }
            set
            {
                openBar = value;
                EventCharge();
            }
        }
        public bool WineWithDinner
        {
            get
            {
                return wineWithDinner;
            }
            set
            {
                wineWithDinner = value;
                EventCharge();
            }
        }
        #endregion

        #region "Constructors"
        public CateringEvent(string eventName, int numberOfGuests, EntreType entreChoice, bool openBar, bool wineWithDinner)
        {
            EventName = eventName;
            NumberOfGuests = numberOfGuests;
            EntreChoice = entreChoice;
            OpenBar = openBar;
            WineWithDinner = wineWithDinner;
        }
        #endregion

        #region "Methods"
        //Return price per entre per guest (using a switch statement)
        private decimal PriceOfEntre()
        {
            #region 'Switch Statement: Enumeration'
            decimal entrePrice;
            switch (EntreChoice)
            {
                case EntreType.RibEyeSteak:
                    entrePrice = SteakPrice;
                    break;
                case EntreType.GrilledChicken:
                    entrePrice = ChickenPrice;
                    break;
                case EntreType.GardenLasagna:
                    entrePrice = LasagnaPrice;
                    break;
                default:
                    entrePrice = 0;
                    break;
            }
            #endregion

            return entrePrice;
        }

        //Calculate the entre charge, drink charge, surcharge, and total charge for the event
        private void EventCharge()
        {
            EntreCharge = PriceOfEntre() * numberOfGuests;

                #region 'Check Drinks With Dinner'
                if (OpenBar == true && WineWithDinner == true)
                {
                    DrinksCharge = (NumberOfGuests * openBarPrice) + (NumberOfGuests * wineWithDinnerPrice);
                }
                else if (OpenBar == true && WineWithDinner == false)
                {
                    DrinksCharge = (NumberOfGuests * openBarPrice);
                }
                else if (WineWithDinner == true && OpenBar == false)
                {
                    DrinksCharge = (NumberOfGuests * wineWithDinnerPrice);
                }
                else
                {
                    DrinksCharge = 0;
                }
                #endregion

                #region 'Check Surcharge'
                if (NumberOfGuests > maxGuest && OpenBar == true)
                {
                    SurCharge = (numberOfGuests - 75) * guestSurcharge;
                }
                else
                {
                SurCharge = 0;
                }
                #endregion

            TotalCharge = EntreCharge + DrinksCharge + SurCharge;
        }
        #endregion
    }
}