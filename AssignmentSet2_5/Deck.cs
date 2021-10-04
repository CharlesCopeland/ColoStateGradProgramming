using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class Name:           AssignmentSet2_5
//Class Description:    Create a deck instance class
//Developer Name:       Copeland Felts
//Date Created:         9/19/2021
//Date Last Modified:   9/21/2021

namespace AssignmentSet2_5
{
    class Deck
    {
        #region "Variables/Fields"
                                                                                                 //Declare provate variables
        private int squareFootage;
        private double lumber, stain;

        #endregion

        #region "Properties"                                                                       
                                                                                                  //Declare getters and setters
        public int SquareFootage { get { return squareFootage; } set { squareFootage = value; } }
        public double Lumber { get { return lumber; } set { lumber = value; } }
        public double Stain { get { return stain; } set { stain = value; } }


        #endregion

        #region "Methods"

        public double CalcBuildCost()                                                             //Calculate deck cost using parameters
        {
            const int stainCoverage = 225;
            const double laborRate = 21.45;

            double totalCost;
            totalCost = (SquareFootage * Lumber) + (((double)SquareFootage / Stain) * stainCoverage) + (squareFootage * laborRate);

            return totalCost;
        }
        #endregion
    }
}