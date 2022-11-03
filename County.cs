using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1b
{
    public class County
    {
        /// <summary>
        /// Private Fields
        /// </summary>
        private string _countyName;
        private int _Population;
        /// <summary>
        /// Constructor
        /// </summary>
        public County()
        {

        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="pCountyName"></param>
        /// <param name="pPopulation"></param>
        public County(string pCountyName, int pPopulation)
        {
            CountyName = pCountyName;
            Population = pPopulation;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~County()
        {
            CountyName = string.Empty;
        }
        /// <summary>
        /// Getters and Setters for the public properties
        /// </summary>
        public string CountyName
        {
            get { return _countyName; }
            set { _countyName = value.Trim(); }
        }

        public int Population
        {
            get;
            set;
        }
        /// <summary>
        /// Override ToString for the class
        /// </summary>
        public override string ToString()
        {
            string message = "You have succesfully updated the population of the county " + CountyName + " to " + Population + ".";
            return message;
        }
    }
}