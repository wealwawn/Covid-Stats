using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1b
{ //Developed by Justin Nunley
    public partial class Form5 : Form
    {
        //Strings are declared to work with in the form
        string[] AgeRanges = { "5-11", "12-19", "20-29", "30-39", "40-49", "50-59", "60-64", "65+" };
        int[] numvax = { 0, 0, 0, 0, 0, 0, 0, 0 };

        //Form is initialized
        public Form5()
        {
            InitializeComponent();
        }

        // Sets the --- input that I have to 0's to match the array on the Form5_Load Event
        private void Form5_Load(object sender, EventArgs e)
        {
            int index;
            for (index = 0; index < numvax.Length; index++)
            {
                lstNumVax.Items[index] = 0;
            }
        }

        /*Validates that there is a 0 currently for that AgeRanges related index entry in the numvax array
        Then uses tIsSelected and the IsValid methods to assure a listbox selection is selected and the data is valid
        If everything is valid it instantiates the object and then runs the first of 3 ToStrings
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (numvax[lstAgeRange.SelectedIndex] < 0)
            {
                lblOutput.Text = "Please enter a positive integer.";
            }
            if (numvax[lstAgeRange.SelectedIndex] > 0)
            {
                    lblOutput.Text = "Please edit the current value instead.";
            }
            if (IsSelected() && IsValid())
            {
                
                
                    VaccinationData myVaccinationData = new VaccinationData(txtCounty.Text, dtpTransmissionsDatePicker.Value, AgeRanges, numvax);
                    lblOutput.Text = myVaccinationData.ToString(lstAgeRange.SelectedIndex);
                
            }
        }


        /*Validates that there is not a 0 and is larget tnan 0 currently for that AgeRanges related index entry in the numvax array
        Then uses tIsSelected and the IsValid methods to assure a listbox selection is selected and the data is valid
        If everything is valid it instantiates the object and then runs the second of 3 ToStrings.
        */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (numvax[lstAgeRange.SelectedIndex] == 0)
            {
                lblOutput.Text = "Please add a population to this range before editing.";
            }
            if (numvax[lstAgeRange.SelectedIndex] < 0)
            {
                lblOutput.Text = "Please enter a positive integer.";
            }
            if (IsSelected() && IsValid())
            {
                {
                    VaccinationData myVaccinationData = new VaccinationData(txtCounty.Text, dtpTransmissionsDatePicker.Value, AgeRanges, numvax);
                    lblOutput.Text = myVaccinationData.ToStringEdit(lstAgeRange.SelectedIndex);

                }
            }
        }

        /*Validates that there is a non 0 number currently for that AgeRanges related index entry in the numvax array
        Then uses tIsSelected and the IsValid methods to assure a listbox selection is selected and the data is valid
        If everything is valid it sets the array and listbox entry corresponding and instantiates the object and then runs the third of 3 ToStrings.
        */
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (numvax[lstAgeRange.SelectedIndex] == 0)
            {
                lblOutput.Text = "The selected age range was never entered or has already been removed.";
            }
            if (IsSelected() && IsValid())
            {
                numvax[lstAgeRange.SelectedIndex] = 0;
                lstNumVax.Items[lstAgeRange.SelectedIndex] = 0;
                VaccinationData myVaccinationData = new VaccinationData(txtCounty.Text, dtpTransmissionsDatePicker.Value, AgeRanges, numvax);
                lblOutput.Text = myVaccinationData.ToStringRemove(lstAgeRange.SelectedIndex);
            }
        }

        //Closes the form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Clears the forms controls and selections, focuses the county textbox, sets all entries 
         * to the array to and changes the listbox with a for loop to reflect that.  */
        private void btnClear_Click(object sender, EventArgs e)
        {
            int index;
            
            txtCounty.Text = string.Empty;
            txtNumVax.Text = string.Empty;
            lblOutput.Text = string.Empty;
            lstAgeRange.SelectedIndex = -1;
            txtCounty.Focus();
            int[] numvax = { 0, 0, 0, 0, 0, 0, 0, 0 };
            
            for (index = 0; index < numvax.Length; index++)
            {
                lstNumVax.Items[index] = 0;
            }
        }
    


         //Returns a false boolean if the string is empty   
        private bool IsPresent(TextBox pTextBox, string pName)
        {
                bool present = false;

                if (pTextBox.Text.Trim() == string.Empty)
                {

                }
                else
                {
                    present = true;
                }
                return present;

        }
       //Ensures that a listbox entry is selected or gives an error
        private bool IsSelected()
        {
                bool selected = false;
                if (lstAgeRange.SelectedIndex == -1)
                {
                    lblOutput.Text = "Please select an age range to enter a population for.";
                }
                else
                {
                    selected = true;
                }
                return selected;
        }
        /*Uses the is present method to check to see if there are entries, 
         * then validates the entries if there are there
         If they are, sets the array and listbox to reflect and returns a true boolean
         */
        private bool IsValid()
        {
                bool valid = false;
                int vaxpop;

                if (!IsPresent(txtCounty, "County") || !IsPresent(txtNumVax, "Number of Vaccinations"))
                {
                    lblOutput.Text = "Please enter missing data.";
                }
                else if (txtCounty.Text.Any(char.IsDigit))
                {
                    lblOutput.Text = "Please enter a county name with no numbers.";
                    txtCounty.SelectAll();
                    txtCounty.Focus();
                }
                else if (Int32.TryParse(txtNumVax.Text, out vaxpop) == false)
                {
                    lblOutput.Text = "Please enter a number of population corresponding to the age range in the county.";
                    txtNumVax.SelectAll();
                    txtNumVax.Focus();
                }
                else
                {
                    numvax[lstAgeRange.SelectedIndex] = vaxpop;
                    lstNumVax.Items[lstAgeRange.SelectedIndex] = vaxpop;
                    valid = true;
                }
                return valid;
        }


        }
    }

