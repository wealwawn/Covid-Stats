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
    public partial class DOHinfoform : Form
    {
        //Strings declared to work with the file and modularize
        string county, description, phoneNumber, streetAddress, city, state, zipCode;
      
        //Form Initizlize 
        public DOHinfoform()
        {
            InitializeComponent();
        }
        //Handler for the Close button. Code closes the form
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Event handler for the form loading. It uses the open data method to read the file data, instantiates a Location object, and calls the ToString
        private void DOHinfo_Load(object sender, EventArgs e)
        {
            openData("DOH_Info.txt");
            Location MyLocation = new Location(county, description, phoneNumber, streetAddress ,city, state, zipCode);
           lblResults.Text = MyLocation.ToString();
        }
        //Method that checks for the file to see if it exists, then sets the file variables to the data in the file.
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

                    // while (!myFile.EndOfStream)
                    //  {
                    //   input = myFile.ReadLine();
                    //     lstColors.Items.Add(input);
                    //   }
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
            // Method to set the labels to the file variables saved data.
            void loadInfo()
            {
                lblCounty.Text = county;
                lblDescription.Text = description;
                lblPhoneNumber.Text = phoneNumber;
                lblStreetAddress.Text = streetAddress;
                lblCity.Text = city;
                lblState.Text = state;
                lblZipCode.Text = zipCode;
            }
        }
    }
}
