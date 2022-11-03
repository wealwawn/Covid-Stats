using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Developed by Justin Nunley 4/26/2022
namespace Project1b
{
    /// <summary>
    /// Address Base Class
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Private Fields
        /// </summary>
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zipCode;

        /// <summary>
        /// Constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Overloaded Constructor for Base Class
        /// </summary>
        /// <param name="pStreetAddress"></param>
        /// <param name="pCity"></param>
        /// <param name="pState"></param>
        /// <param name="pZipCode"></param>
        public Address(string pStreetAddress, string pCity, string pState, string pZipCode)
        {
            StreetAddress = pStreetAddress;
            City = pCity;
            State = pState;
            ZipCode = pZipCode;
        }

        /// <summary>
        /// Destructor for Base Class
        /// </summary>
        ~Address()
        {
            StreetAddress = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }

        /// <summary>
        /// Getters and Setters for Base Class
        /// </summary>
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value.Trim(); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value.Trim(); }
        }

        public string State
        {
            get { return _state; }
            set { _state = value.Trim(); }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value.Trim(); }
        }

        /// <summary>
        /// Overridden ToString for Base Class
        /// </summary>

    }
    /// <summary>
    /// Derived Class Location From Address
    /// </summary>
    public class Location : Address
    {
        private string _county;
        private string _description;
        private string _phoneNumber;

        /// <summary>
        /// Constructor for Derived class
        /// </summary>
        public Location()
        {

        }
        /// <summary>
        /// Overloadedc Constructor for Derived Class
        /// </summary>
        /// <param name="pCounty"></param>
        /// <param name="pDescription"></param>
        /// <param name="pPhoneNumber"></param>
        /// <param name="pStreetAddress"></param>
        /// <param name="pCity"></param>
        /// <param name="pState"></param>
        /// <param name="pZipCode"></param>
        public Location(string pCounty, string pDescription, string pPhoneNumber, string pStreetAddress, string pCity, string pState, string pZipCode)
        {
            StreetAddress = pStreetAddress;
            City = pCity;
            State = pState;
            ZipCode = pZipCode;

            County = pCounty;
            Description = pDescription;
            PhoneNumber = pPhoneNumber;

        }
        /// <summary>
        /// Destructor for derived class
        /// </summary>
        ~Location()
        {
            County = string.Empty;
            Description = string.Empty;
            PhoneNumber = string.Empty;
        }
        /// <summary>
        /// Getters and setters for derived class
        /// </summary>
        public string County
        {
            get { return _county; }
            set { _county = value.Trim(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value.Trim(); }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value.Trim(); }
        }


        /// <summary>
        /// Overridden ToString for derived class
        /// </summary>
        public virtual string ToString()
        {
            string message;
            message = "The address above is the information currently in the DOH_Info.txt file.";
                return message;
        }
        public virtual string ToStringMaintenance()
        {
            string message;
            message = "You have just saved the following parameters to the DOH_Info.txt file: " + Environment.NewLine +
                 "County: " + County + Environment.NewLine +
               "Description: " + Description + Environment.NewLine +
               "Phone Number: " + PhoneNumber + Environment.NewLine +
               "Street Address: " + StreetAddress + Environment.NewLine +
               "City: " + City + Environment.NewLine + 
               "State: " + State + Environment.NewLine + 
               "Zip Code: " +ZipCode;

            return message;
        }
    }
}