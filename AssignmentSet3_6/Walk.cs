using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//***********Class Information****************
//********************************************
//Class Description:  Calculate miles walked with walker's name, 
//                    number of steps, and typical length of step
//Developer Name:     Copeland Felts
//Date Created:       10/04/2021
//Date Last Modified: 10/04/2021
//********************************************
//********************************************

namespace AssignmentSet3_6
{
    class Walk
    {

        //Create three private fields
        #region "Fields"                                
        private int lengthOfStep, numberOfSteps;
        private String walkerName;
        #endregion

        //Create three instance properties to access the private fields with public get and set accessors for each
        #region "Properties"
        public int LengthOfStep
        {
            get
            {
                return lengthOfStep;
            }
            set
            {
                lengthOfStep = value;
            }
        }

        public int NumberOfSteps
        {
            get
            {
                return numberOfSteps;
            }
            set
            {
                numberOfSteps = value;
            }
        }

        public String WalkerName
        {
            get
            {
                return walkerName;
            }
            set
            {
                walkerName = value;
            }
        }
        #endregion

        //Create the constructor to instantiate the walk object and set the three properties
        #region "Constructors"
        public Walk(int lengthOfStep, int numberOfSteps, String walkerName)
        {
            LengthOfStep = lengthOfStep;
            NumberOfSteps = numberOfSteps;
            WalkerName = walkerName;
        }   
        #endregion

        //Create a public instance method to calculate and return the miles walked
        #region "Methods"
        public double CalculateMilesWalked()
        {
            double milesWalked;
            return milesWalked = (double)numberOfSteps * (double)lengthOfStep / 63360;
        }
        #endregion
    }
}
