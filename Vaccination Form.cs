using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Justin Nunley Feb 15 2022 Spring-2222-COP2360C-4233
namespace Project1b
{
    public partial class VaccinationForm : Form
    {
        public VaccinationForm()
        {
            InitializeComponent();
        }
        //This is the event handler for clicking the submit button. It instantiates
        //the constructor and then sets the results label to the class ToString method
        /// <summary>
        /// This is the event handler for clicking the submit button. It instantiates
        /// the constructor and then sets the results label to the class ToString method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Vaccination myVaccination = new Vaccination(txtCountyName.Text, int.Parse(txtPopulationTotal.Text), int.Parse(txtNumVax.Text));

            lblVaxResults.Text = myVaccination.ToString();
        }
        /// <summary>
        ///         This is the event handler for the clear button.
        ///         It clears all the text boxes and puts the focus on the top box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCountyName.Clear();
            txtNumVax.Clear();
            txtPopulationTotal.Clear();
            txtCountyName.Focus();
        }

        /// <summary>
        /// This is the event handler for the close button. The code within closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();        
        }
    }
}
