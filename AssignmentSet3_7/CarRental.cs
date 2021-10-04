using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//***********Class Information****************
//********************************************
//Class Description:  Calculate car rental charge with customer name, rental charge, 
//                    beginning and ending odometer reading, and number of days rented 
//Developer Name:     Copeland Felts
//Date Created:       10/04/2021
//Date Last Modified: 10/04/2021
//********************************************
//********************************************

namespace AssignmentSet3_7
{
    class CarRental
    {

        //Create three private fields
        #region "Fields"                                
        private int beginOdometerReading, daysRented, endOdometerReading;
        #endregion

        //Create three instance properties to access the private fields with public get and set accessors for each
        #region "Properties"
        public int BeginOdometerReading
        {
            get
            {
                return beginOdometerReading;
            }
            set
            {
                beginOdometerReading = value;
            }
        }

        public int DaysRented
        {
            get
            {
                return daysRented;
            }
            set
            {
                daysRented = value;
            }
        }

        public int EndOdometerReading
        {
            get
            {
                return endOdometerReading;
            }
            set
            {
                endOdometerReading = value;
            }
        }

        //Create two auto-implemented properties with public get and set accessors for each
        public String CustomerName { get; set; }

        public decimal RentalCharge { get; private set; }
        #endregion

        //Create the constructor to instantiate the walk object and set the three properties
        #region "Constructors"
        public CarRental()
        {
            BeginOdometerReading = beginOdometerReading;
            DaysRented = daysRented;
            EndOdometerReading = endOdometerReading;
        }

        //Create the overloaded constructor instantiate object and set four properties:
        //customer name, ending odometer reading, beginning odometer reading, and number of days rented - using parameters
        //Call the CalculateRentalCharge method
        public CarRental(String customerName, int beginOdometerReading, int daysRented, int endOdometerReading)
        {
            CustomerName = customerName;
            BeginOdometerReading = beginOdometerReading;
            DaysRented = daysRented;
            EndOdometerReading = endOdometerReading;

            CalculateRentalCharge();
        }
        #endregion

        //Create a private instance method to calculate and return the miles walked | Set RentalCharge property so that the value can be accessed
        #region "Methods"
        private void CalculateRentalCharge() 
        {
            double dailyRate = 69.25;
            double costPerMile = 0.51;
            RentalCharge = (decimal)((DaysRented * (double)dailyRate) + ((EndOdometerReading - BeginOdometerReading) * costPerMile));
        }
        #endregion

    }
}
