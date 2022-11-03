using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Justin Nunley Feb 15 2022 Spring-2222-COP2360C-4233
namespace Project1b
{
    #region Properties
    class Vaccination
    {
        // this code sets private fields!
        private string countyName;
        private int populationTotal;
        private int numberVaxed;

        //The properties CountyName, PopulationTotal, NumberVaxed getters and setters are below.
        //The read only property VaxPercentage has a getter that does
        //the calculations to get the percentage of vaccinated people.
        public string CountyName
        {
            get { return countyName; }
            set { countyName = value.Trim(); }

        }

        public int PopulationTotal
        {
            get { return populationTotal; }
            set { populationTotal = value; }
        }

        public int NumberVaxed
        {
            get { return numberVaxed; }
            set { numberVaxed = value; }
        }

        private double VaxPercentage
        {
            get { return Math.Round(((double)numberVaxed / (double)populationTotal) * 100, 2); }
        }

        #endregion

        #region Utility Methods
        /// <summary>
        /// string representation of the object
        /// </summary>
        /// <returns>string representation of the object</returns>
        public override string ToString()
            {
                string message;

            message = CountyName + " county has a population of " + PopulationTotal +
            " and the number of vaccinated people is " + NumberVaxed + " leading to a vaccination percentage of " + VaxPercentage + "%";
            return message;
            }
            /// <summary>
            /// Clears the state of the object.
            /// </summary>
            public void Clear()
            {
                countyName = string.Empty;
                populationTotal = 0;
                numberVaxed = 0;
            }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructors
        /// </summary>
        public Vaccination()
        {
            Clear();

        }

        public Vaccination(string pCountyName, int pPopulationTotal, int pNumberVaxed)
        {
            CountyName = pCountyName;
            PopulationTotal = pPopulationTotal;
            NumberVaxed = pNumberVaxed;
        }
        #endregion
        #region Destructors
        /// <summary>
        /// Destructor
        /// </summary>
        ~Vaccination()
            {
                countyName = null;
            }
        }
        #endregion

}
