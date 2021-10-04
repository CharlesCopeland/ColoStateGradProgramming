using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class Name:           calcInvestment
//Class Description:    Calulate return on investment amounts
//Developer Name:       Copeland Felts
//Date Created:         9/19/2021
//Date Last Modified:   9/20/2021

namespace AssignmentSet2_4
{
   static class calcInvestment
    {
        public static double calcFutureValue(int investment, double duration, double interestRate)
        {
            double futureValue = (investment * Math.Pow((1 + interestRate / 100), duration));

            return futureValue;
        }
    }
}
