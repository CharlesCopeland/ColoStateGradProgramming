using System;
using System.Collections.Generic;
using System.Text;

//*******************************************************************
//Class Name:            Cylinder
//Class Description:     Calcs area and volume from user input
//Developer Name:        Copeland Felts
//Date Created:          09/03/2021
//Date Last Modified:    09/03/2021
//*******************************************************************

namespace AssignmentSet1_2
{
    static class Cylinder
    {
        public static double CalcArea(int Radius, int Height)
        {
            return (2 * Math.PI * Radius) * (Radius + Height);   //Calculate area  
        }

        public static double CalcVolume(int Radius, int Height)
        {
            return (Math.PI * Math.Pow(Radius, 2) * Height);   //Calculate volume
        }
    }
}
