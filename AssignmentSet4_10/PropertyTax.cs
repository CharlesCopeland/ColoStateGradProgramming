using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//***********Class Information****************
//********************************************
//Clas Name:          PropertyTax.cs
//Class Description:  Create a project to calculate property tax based on:
//                    a) square footage of the building (assume one building per property)
//                    b) square footage of the land
//                    c) age of the building
//                    d) location of the property
//
//Developer Name:     Copeland Felts
//Date Created:       10/17/2021
//Date Last Modified: 10/17/2021
//********************************************
//********************************************

namespace AssignmentSet4_10
{
    #region "Enumerations"
    public enum LocationType
    {
        Urban = 1,
        Suburban = 2,
        Rural = 3
    }
    #endregion

    class PropertyTax
    {
        #region "Constants"
        const int Size1 = 1000;
        const int Size2 = 2000;
        const int Size3 = 3000;
        const int Size4 = 4000;

        const int Size5 = 10000;
        const int Size6 = 20000;
        const int Size7 = 30000;
        const int Size8 = 40000;

        const decimal BuildingTax_1 = 0.83M;
        const decimal BuildingTax_2 = 830.00M;
        const decimal BuildingTax_2_Additional = 0.085M;
        const decimal BuildingTax_3 = 1680.00M;
        const decimal BuildingTax_3_Additional = 0.087M;
        const decimal BuildingTax_4 = 2550.00M;
        const decimal BuildingTax_4_Additional = 0.089M;
        const decimal BuildingTax_5 = 3440.00M;
        const decimal BuildingTax_5_Additional = 0.091M;

        const decimal LandTax_1 = 0.05M;
        const decimal LandTax_2 = 500.00M;
        const decimal LandTax_2_Additional = 0.07M;
        const decimal LandTax_3 = 1200.00M;
        const decimal LandTax_3_Additional = 0.09M;
        const decimal LandTax_4 = 2100.00M;
        const decimal LandTax_4_Additional = 0.11M;
        const decimal LandTax_5 = 3200.00M;
        const decimal LandTax_5_Additional = 0.13M;

        const decimal AgeDeduction_13_Greater = 0.005M;
        const decimal RuralDeduction_2300_Less = 0.0225M;
        const decimal RuralDeduction_2300_Greater = .015M;

        const int CurrentYear = 2021;
        const int AgeDeduction = 13;
        const int MaxLandSize = 23000;
        #endregion

        #region "Fields"
        private readonly string propertyOwner;
        private readonly LocationType propertyLocation;
        private readonly int buildingSquareFootage, landSquareFootage;
        private readonly int yearBuilt;
        #endregion

        #region "Properties"
        public decimal BuildingAge { get; private set; }
        public decimal BuildingTax { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal BuildingTaxDeduction { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropertyTax { get; private set; }
        #endregion

        #region "Constructors"
        public PropertyTax(String PropertyOwner, LocationType PropertyLocation, int BuildingSquareFootage, int LandSquareFootage, int YearBuilt)
        {
            propertyOwner = PropertyOwner;
            propertyLocation = PropertyLocation;
            buildingSquareFootage = BuildingSquareFootage;
            landSquareFootage = LandSquareFootage;
            yearBuilt = YearBuilt;

            BuildingAge = CurrentYear - yearBuilt;

            CalcTotalPropertyTax();
        }
        #endregion

        #region "Methods"

        //Calc building tax based on chart
        private void CalcBuildingTax()
        {
            if (buildingSquareFootage <= Size1)
            {
                BuildingTax = buildingSquareFootage * BuildingTax_1;
            }
            else if (buildingSquareFootage <= Size2)
            {
                BuildingTax = BuildingTax_2 + ((Size2 - buildingSquareFootage) * BuildingTax_2_Additional);
            }
            else if (buildingSquareFootage <= Size3)
            {
                BuildingTax = BuildingTax_3 + ((Size3 - buildingSquareFootage) * BuildingTax_3_Additional);
            }
            else if (buildingSquareFootage <= Size4)
            {
                BuildingTax = BuildingTax_4 + ((Size4 - buildingSquareFootage) * BuildingTax_4_Additional);
            }
            else
            {
                BuildingTax = BuildingTax_5 + ((buildingSquareFootage - Size4) * BuildingTax_5_Additional);
            }
        }

        //Calc land tax based on chart
        private void CalcLandTax()
        {
            if (landSquareFootage <= Size5)
            {
                LandTax = landSquareFootage * LandTax_1;
            }
            else if (landSquareFootage <= Size6)
            {
                LandTax = LandTax_2 + ((Size6 - landSquareFootage) * LandTax_2_Additional);
            }
            else if (landSquareFootage <= Size7)
            {
                LandTax = LandTax_3 + ((Size7 - landSquareFootage) * LandTax_3_Additional);
            }
            else if (landSquareFootage <= Size8)
            {
                LandTax = LandTax_4 + ((Size8 - landSquareFootage) * LandTax_4_Additional);
            }
            else
            {
                LandTax = LandTax_5 + ((landSquareFootage - Size8) * LandTax_5_Additional);
            }
        }

        //Calc building deduction
        private void CalcBuildingTaxDeduction()
        {
            if ((CurrentYear - yearBuilt) > AgeDeduction)
            {
                BuildingTaxDeduction = (CurrentYear - yearBuilt) * (AgeDeduction_13_Greater * BuildingTax);
            }
            else
            {
                BuildingTaxDeduction = 0;
            }
        }

        //Calc land deduction
        private void CalcLandTaxDeduction()
        {
            if (landSquareFootage <= MaxLandSize)
            {
                LandTaxDeduction = LandTax * RuralDeduction_2300_Less;
            }
            else if (landSquareFootage > MaxLandSize)
            {
                LandTaxDeduction = LandTax * RuralDeduction_2300_Greater;
            }
            else
                LandTaxDeduction = 0;
        }

        //Calc total property tax values
        private void CalcTotalPropertyTax()
        {
            CalcBuildingTax();
            CalcLandTax();

            if (BuildingAge > AgeDeduction)
            {
                CalcBuildingTaxDeduction();
            }

            if (propertyLocation == LocationType.Rural)
            {
                CalcLandTaxDeduction();
            }

            TotalPropertyTax = BuildingTax + LandTax - BuildingTaxDeduction - LandTaxDeduction;
        }
        #endregion
    }
}
