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
{  // Developed by Justin Nunley
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        
        { //declare variables for tryparses later in the decision structure
            double resultcases, resultpositivity;
            /* decision structure makes sure that the fields aren't empty
            then makes sure that a numberless County name isn't entered
            finally, the try parse grabs the value from the cases and positivity rate
            textboxes, and gives an error message if not a double.
            if all succesful, it the instantiates the object with the tryparsed values and the
            text box / date time pickers values in the last else. */
                if (txtCountyName.Text.Trim() == string.Empty)
            {
                lblResults.Text = "Please enter a county name.";
            }
                if (txtNewCases.Text.Trim() == string.Empty)
            {
                lblResults.Text = "Please enter the amount of cases per 100k people.";
            }
                if (txtPositivityRate.Text.Trim() == string.Empty)
            {
                lblResults.Text = "Please enter a positivity rate.";
            }
                if (txtCountyName.Text.Any(Char.IsDigit))
            {
                lblResults.Text = "Please enter a valid county name.";
            }
                 double.TryParse(txtNewCases.Text, out resultcases);
                if (!(resultcases >= 0 && resultcases <= 100000))
                {
                    lblResults.Text = "Please enter a number between 0 and 100000 for the cases per 100k.";
                }
                     double.TryParse(txtPositivityRate.Text, out resultpositivity);
                if (!(resultpositivity >= 0 && resultpositivity <= 100))
                {
                    lblResults.Text = "Please enter a number between 0 and 100 for the positivity rate";
                }
                else
                {
                     Community myCommunity = new Community(txtCountyName.Text, dtpTransmissionsDatePicker.Value, resultcases, resultpositivity);
                // Uses the tostring class to put information in the results label
                 lblResults.Text = myCommunity.ToString();
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* clears all text boxes, the result label, sets the date time picker to todays date,
             and sets focus to the first field*/
            txtCountyName.Clear();
            txtNewCases.Clear();
            txtPositivityRate.Clear();
            lblResults.Text = null;
            dtpTransmissionsDatePicker.Value = DateTime.Now;
            txtCountyName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the Community Transmission Form
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
