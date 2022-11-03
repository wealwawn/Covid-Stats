using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1b
{
    public class Community
    {
        ///declares private strings
        private string countyName;
        private DateTime date;
        private double casesPer100;
        private double positivityRate;
        ///basic Community constructor
        public Community()
        {
            
        }
        /// Overloaded Community constructor
        public Community(string pCountyName, DateTime pDate, double pCasesPer100, double pPositivityRate)
        {
            CountyName = pCountyName;
            Date = pDate;
            CasesPer100 = pCasesPer100;
            PositivityRate = pPositivityRate;
        }
        /// Community Destructor
        ~Community()
        {
            countyName = null;
        }
        /// Setters and Getters
        public string CountyName
        {
            get { return countyName;  }
            set { countyName = value.Trim(); }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value;}
        }

        public double CasesPer100
        {
            get { return casesPer100; }
            set { casesPer100 = value; }
        }

        public double PositivityRate
        {
            get { return positivityRate; }
            set { positivityRate = value; }
        }
        /// readonly getter only that takes the positivity rate and Cases fields and decides the status
        private string Status
        {
            get
            {
                string statusValue = "Error";
                if (CasesPer100 < 9.99 || PositivityRate < 4.99)
                {
                    statusValue = "Low";
                }
                if (CasesPer100 >= 10 && CasesPer100 <= 49.99 || PositivityRate >= 4.99 && PositivityRate <= 7.99)
                {
                    statusValue = "Moderate";
                }
                if (CasesPer100 >= 50 && CasesPer100 <= 99.99 || PositivityRate >= 8 && PositivityRate <= 9.99)
                {
                    statusValue = "Substantial";
                }
                 if (CasesPer100 >= 100 || PositivityRate >= 10 )
                {
                    statusValue = "High";
                }
                return statusValue;
            }
        }
        /// readonly getter only that takes the positivity rate and Cases fields and decides the color
        private string Color
        {
            get
            {
                string colorValue = "Error";
                if (CasesPer100 < 9.99 || PositivityRate < 4.99)
                {
                    colorValue = "Blue";
                }
                if (CasesPer100 >= 10 && CasesPer100 <= 49.99 || PositivityRate >= 4.99 && PositivityRate <= 7.99)
                {
                    colorValue = "Yellow";
                }
                if (CasesPer100 >= 50 && CasesPer100 <= 99.99 || PositivityRate >= 8 && PositivityRate <= 9.99)
                {
                    colorValue = "Orange";
                }
                if (CasesPer100 >= 100 || PositivityRate >= 10)
                {
                    colorValue = "Red";
                }
                return colorValue;
            }
        }
        /// To String Method that returns a message in the form code
        public override string ToString()
        {
            string message = CountyName + " County on date " + Date.ToString("d") + " has "
                + CasesPer100 + " new case(s) per 100k people with a positivity rate of " + PositivityRate + "% giving it a status of "
                + Status + " or the corresponding color " + Color;
            return message;
        }
    }
}