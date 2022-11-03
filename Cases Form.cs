using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this form designed by Justin Nunley//
namespace Project1b
{
    public partial class frmCases : Form
    {
        public frmCases()
        {
            InitializeComponent();

        }
      

        private void casesExitButton_Click(object sender, EventArgs e)
        {
            //This code closes the program//
            this.Close();
        }

        private void casesClearButton_Click(object sender, EventArgs e)
        {
            //This code clears the population textbox and the number of cases text box and sets the population textbox as the focus//
            txtPopulationInput.Clear();
            txtNumCasesInput.Clear();
            txtPopulationInput.Focus();
        }

        private void casesSubmitButton_Click(object sender, EventArgs e)
        {
           // This code declares the variables I will need to perform the calculation//
            int population, numCases;
            decimal casesPer;
           // Calculations are made below
            population = Convert.ToInt32(txtPopulationInput.Text);
            numCases = Convert.ToInt32(txtNumCasesInput.Text);
            casesPer = (decimal)numCases / (decimal)population * 100000;

            //This code sets the label to display text and the results to three decimal places.//
            lblResultCasesPer.Text = "The number of cases per 100k based on the data entered is " + casesPer.ToString("0.###");
        }

    }
}
