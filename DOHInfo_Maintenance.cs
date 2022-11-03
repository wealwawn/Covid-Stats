using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Developed by Justin Nunley 4/26/2022
namespace Project1b
{
    public partial class DOHInfo_Maintenance : Form
    {
        // Declaring variables for working with the files
        string county, description, phoneNumber, streetAddress, city, state, zipCode;
       
        //Form initialization
        public DOHInfo_Maintenance()
        {
            InitializeComponent();
        }

        // Method for opening a specific file. Launches dialog with a filter for text files.
        private void btnOpen_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    diaOpenFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    diaOpenFile.Title = "Select a File to save";
                    if (diaOpenFile.ShowDialog() == DialogResult.OK)
                    {
                        openData(diaOpenFile.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File exception" + ex.Message, "Error");
                }
            }

        }
        /*Method for the save button event handler, validates there is data in the text boxes, takes the data from the textboxes, 
         writes them to the file, instantiates an address object, then uses the tostringmaintenance method to put that data in the results label*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCounty.Text == string.Empty || txtCounty.Text == null)
            {
                lblResults.Text = "Please enter data into the County textbox.";
            }
            else if (txtDescription.Text == string.Empty || txtDescription.Text == null)
            {
                lblResults.Text = "Please enter data into the Description textbox.";
            }
            else if (txtPhoneNumber.Text == string.Empty || txtPhoneNumber.Text == null)
            {
                lblResults.Text = "Please enter data into the Phone Number textbox.";
            }
            else if (txtStreetAddress.Text == string.Empty || txtStreetAddress.Text == null)
            {
                lblResults.Text = "Please enter data into the Street Address textbox.";
            }
            else if (txtCity.Text == string.Empty || txtCity.Text == null)
            {
                lblResults.Text = "Please enter data into the City textbox.";
            }
            else if (txtState.Text == string.Empty || txtState.Text == null)
            {
                lblResults.Text = "Please enter data into the State textbox.";
            }
            else if (txtZipCode.Text == string.Empty || txtZipCode.Text == null)
            {
                lblResults.Text = "Please enter data into the Zip Code textbox.";
            }
            else
            {
                takeinfo();
                saveData("DOH_info.txt");
                Address myAddress = new Address(streetAddress, city, state, zipCode);
                Location MyLocation = new Location(county, description, phoneNumber, streetAddress, city, state, zipCode);
                lblResults.Text = MyLocation.ToStringMaintenance();
            }
        }
        /*Method handler for the clear event button, uses the ClearTextBoxes Lambda expression
         * to clear the the text boxes and then clears the results label*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblResults.Text = string.Empty;
        }
        //Method for the close button, closes the form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Method for writing the data to a specific file name, uses the data from TakeInfo
        private void saveData(string fileName)
        {

            System.IO.StreamWriter myFile = new StreamWriter(fileName);
            myFile.WriteLine(county);
            myFile.WriteLine(description);
            myFile.WriteLine(phoneNumber);
            myFile.WriteLine(streetAddress);
            myFile.WriteLine(city);
            myFile.WriteLine(state);
            myFile.WriteLine(zipCode);
            myFile.Close();
        }
        //Method that uses a lambda expression to clear all of the textboxes in the field
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        /*Method that takes the text boxes text properties and switches them
         * to the variables used to held info from the file for modulariztion*/
        void loadInfo()
        {
            txtCounty.Text = county;
            txtDescription.Text = description;
            txtPhoneNumber.Text = phoneNumber;
            txtStreetAddress.Text = streetAddress;
            txtCity.Text = city;
            txtState.Text = state;
            txtZipCode.Text = zipCode;
        }
     //Inverse method of loadinfo, assigns the text propertys from the control to the file variables
        void takeinfo()
        {
            county = txtCounty.Text;
            description = txtDescription.Text;
            phoneNumber = txtPhoneNumber.Text;
            streetAddress = txtStreetAddress.Text;
            city = txtCity.Text;
            state = txtState.Text;
            zipCode = txtZipCode.Text;
        }
        // Method that reads the data from the file
        private void openData(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader myFile = File.OpenText(fileName);

                try
                {
                    while (!myFile.EndOfStream)
                    {
                        county = myFile.ReadLine();
                        description = myFile.ReadLine();
                        phoneNumber = myFile.ReadLine();
                        streetAddress = myFile.ReadLine();
                        city = myFile.ReadLine();
                        state = myFile.ReadLine();
                        zipCode = myFile.ReadLine();
                        loadInfo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File exception" + ex.Message, "file error(read)");
                }
                finally
                {
                    myFile.Close();
                }
            }
        }
    }
}

