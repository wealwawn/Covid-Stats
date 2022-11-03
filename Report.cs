using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1b
{
    public class Report
    {
        /// <summary>
        /// Private fields
        /// </summary>
        private int _countyID;
        private int _numOfCases;
        private double _positivityRate;
        private DateTime _reportDate;
        /// <summary>
        /// 
        /// </summary>
        public Report()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCountyId"></param>
        /// <param name="pNumOfCases"></param>
        /// <param name="pPositivityRate"></param>
        /// <param name="pReportDate"></param>
        public Report(int pCountyId, int pNumOfCases, double pPositivityRate, DateTime pReportDate)
        {
            CountyID = pCountyId;
            NumOfCases = pNumOfCases;
            PositivityRate = pPositivityRate;
            ReportDate = pReportDate;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Report()
        {
            ReportDate = DateTime.Today;
        }

        /// <summary>
        /// Getters and Setters for public properties
        /// </summary>
        public int CountyID
        {
            get;
            set;
        }

        public int NumOfCases
        {
            get;
            set;
        }

        public double PositivityRate
        {
            get { return _positivityRate; }
            set { _positivityRate = value; }
        }

        public DateTime ReportDate
        {
            get { return _reportDate; }
            set { _reportDate = value; }
        }

        /// <summary>
        /// ToString Override for the class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message = "You have succesfully made an entry into the COVID_Data database to the county ID" + CountyID + " There are " + NumOfCases
                + " recorded cases of covid with a positivity rate of  " + PositivityRate + " on the day of " + ReportDate + '.';
            return message;
        }
    }
}