using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//***********Class Information****************
//********************************************
//Class Description:  Create/display paystubs with employee name, pay rate, hours worked, and net pay
//                    Implement net pay with total paystubs, gross pay, and net pay
//Developer Name:     Copeland Felts
//Date Created:       10/04/2021
//Date Last Modified: 10/04/2021
//********************************************
//********************************************

namespace AssignmentSet3_8
{
    class PayStub
    {
        #region "Fields"     
        //Create four read-only fields
        public readonly string EmployeeName;
        public readonly decimal HoursWorked, NetPay, PayRate;
        #endregion

        #region "Properties"
        //Create three static properties
        public static decimal TotalGrossPay { get; private set; }

        public static decimal TotalNetPay { get; private set; }

        public static decimal TotalPayStubs { get; private set; }
        #endregion

        #region "Constructor"
        //Create the overloaded constructor to instantiate the object and set the three properties
        //Call the CalculateNetPay method and set the NetPay field
        public PayStub(String employeeName, decimal hoursWorked, decimal payRate)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
            PayRate = payRate;

            NetPay = CalculateNetPay();
        }
        #endregion

        #region "Private Methods"
        //Create a private instance method to calculate Net Pay and increment properties
        private decimal CalculateNetPay()
        {
            decimal GrossPay = HoursWorked * PayRate;
            const double V1 = .1188;
            const double V2 = .0505;
            const double V3 = .0616;
            const double V4 = .0149;

            decimal FederalIncomeTax = GrossPay * (decimal)V1;
            decimal StateIncomeTax = GrossPay * (decimal)V2;
            decimal SocialSecurityTax = GrossPay * (decimal)V3;
            decimal MedicareTax = GrossPay * (decimal)V4;

            decimal pay = (GrossPay - FederalIncomeTax - StateIncomeTax - SocialSecurityTax - MedicareTax);

            TotalGrossPay += GrossPay;
            TotalNetPay += pay;
            TotalPayStubs++;

            return pay;

        }
        #endregion

        #region "Public Static Methods"
        //Calculate and return the average net pay
        public static decimal AverageNetPay()
        {
            decimal avgNetPay = 0;
            avgNetPay = TotalNetPay / TotalPayStubs;
            return avgNetPay;
        }
        #endregion
    }
}
