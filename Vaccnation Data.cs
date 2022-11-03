using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1b
{
    public class VaccinationData
    {
        //Declares private fields
        private string _countyName;
        private DateTime _date;

        //Basic constructor
        public VaccinationData()
        {

        }
        //OConstructor with 4 paramters
        public VaccinationData(string pCountyName, DateTime pDate, string[] pAgeRanges, int[] pNumVaxed)
        {
            CountyName = pCountyName;
            Date = pDate;
            AgeRanges = pAgeRanges;
            NumVaxed = pNumVaxed;
        }
        //Destructor that sets a private field to empty
        ~VaccinationData()
        {
            _countyName = string.Empty;
        }
        //Get and Set for County Name Property
        public string CountyName
        {
            get { return _countyName; }
            set { _countyName = value.Trim(); }
        }
        //Get and Set for Date Property
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        //Auto-implemented Get and Set for AgeRanges Array Property
        public string[] AgeRanges
        {
            get;
            set;
        }
        //Auto-implemented Get and Set for NumVaxed Array Property
        public int[] NumVaxed
        {
            get;
            set;
        }
        //Get only private read only Property for Vaccination Total
        private int TotalVax
        {
            get { return NumVaxed.Sum(); }
        }
        
        // ToString that feeds an index parameter from the forms code to give a specific message for the Add Button
        public string ToString(int pIndex)
        {
            string message;

            message = "The age range of ( " + AgeRanges[pIndex] + " )has had their number of vaccinations entered as "
                + NumVaxed[pIndex] + ", leading to a total vaccinated population in " + CountyName + " County of " + TotalVax
            + " as of " + Date.ToString("d");

                return message;
        }
        // ToString that feeds an index parameter from the forms code to give a specific message for the Remove Button
        public string ToStringEdit(int pIndex)
        {
            string message;

            message = "The age range of ( " + AgeRanges[pIndex] + " )has had their number of vaccinations edited to "
                + NumVaxed[pIndex] + ", leading to a total vaccinated population in " + CountyName + " County of " + TotalVax
            + " as of " + Date.ToString("d");

            return message;
        }
        // ToString that feeds an index parameter from the forms code to give a specific message for the Remove Button
        public string ToStringRemove(int pIndex)
        {
            string message;

            message = "The age range of ( " + AgeRanges[pIndex] + " )has had their number of vaccinations entry removed "
            + " leading to a total vaccinated population in " + CountyName + " County of " + TotalVax
            + " as of " + Date.ToString("d");

            return message;
        }
    }
}
