using System;
using System.Windows.Forms;

namespace Project1b
{ //The creator of this program is Justin Nunley, this iteration was finalized 4/10/2022 for Cop2360c//
    public partial class frmHealthData : Form
    {
        Project1b.LoginForm loginform;
        public frmHealthData()
        {
            InitializeComponent();
        }
       //this method enables menu items if the user succesfully logs in and then uses a message box to let the user know that they logged in
        public bool loggedin(bool plogin)
        {
           
            if (loginform.hasLoggedIn == true)
            {
                mnuLogin.Enabled = false;
                mnuCovidDataMaintenance.Visible = true;
                mnuCountyDataMaintenance.Visible = true;
                mnuLogout.Enabled = true;
                MessageBox.Show("You have logged in!");
            }
            return plogin;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //This code closes the form//
            this.Close();
        }
        //Instantiates and opens the Vaccination Cases per 100k form
        private void CasesButton_Click(object sender, EventArgs e)
        {
           //This code was provided by the professor to generate the new form//
            frmCases casesForm = new frmCases();
            casesForm.ShowDialog();
        }

        // Instantiates and opens the Vaccination form
        private void btnVaccinated_Click(object sender, EventArgs e)
        {
            Project1b.VaccinationForm vaccinatedForm = new Project1b.VaccinationForm();
            vaccinatedForm.ShowDialog();
        }
        // Instantiates and opens the Community transmission form
        private void button1_Click(object sender, EventArgs e)
        {
            Project1b.Form4 transmissionForm = new Project1b.Form4();
            transmissionForm.ShowDialog();
        }
        // Instantiates and opens the Vaccination by age form
        private void btnVaxByAge_Click(object sender, EventArgs e)
        {
            Project1b.Form5 vaccinationsByAgeForm = new Project1b.Form5();
            vaccinationsByAgeForm.ShowDialog();
        }
        // Instantiates and opens the CovidData form
        private void btnCovidData_Click(object sender, EventArgs e)
        {
            Project1b.CovidDataForm dataForm = new Project1b.CovidDataForm();
            dataForm.ShowDialog();
        }
        // Menu strip for logging in, takes the dialog result from logging in and executes the loggedin function with the true bool
        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginform = new Project1b.LoginForm();
            DialogResult loginresult = loginform.ShowDialog();
            if (loginresult == DialogResult.OK)
            {
                loggedin(true);
            }
            else
            {

            }
        }
        //Instantiates and opes the about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project1b.AboutBox1 aboutbox = new Project1b.AboutBox1();
            aboutbox.ShowDialog();
        }
        // Instantiates and opens the CovidData Maintenance form
        private void cOVIDDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project1b.CovidDataMaintenanceForm covidDataMaintenance = new Project1b.CovidDataMaintenanceForm();
            covidDataMaintenance.ShowDialog();
        }
        // Instantiates and opens the County Maintenance form
        private void mnuCountyDataMaintenance_Click(object sender, EventArgs e)
        {
            Project1b.CountyPopulationMaintenanceForm frmCountyData = new Project1b.CountyPopulationMaintenanceForm();
            frmCountyData.ShowDialog();
        }
        // hides the appropriate menu items when the user logs out
        private void logout()
        {
            mnuLogin.Enabled = true;
            mnuCovidDataMaintenance.Visible = false;
            mnuCountyDataMaintenance.Visible = false;
            mnuLogout.Enabled = false;
            MessageBox.Show("You have logged out!");
        }
        // calls the logout method when clicking logout in the menu strip
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            logout();
        }
        //Event handler for opening the DoH info form, wired to both menu system and main form
        private void btnDOHInfo_Click(object sender, EventArgs e)
        {
            Project1b.DOHinfoform dohForm = new Project1b.DOHinfoform();
            dohForm.ShowDialog();
        }
        // Menu item event handler for opening Doh info maintance form
        private void dOHInfoMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project1b.DOHInfo_Maintenance dohMaintenanceForm = new Project1b.DOHInfo_Maintenance();
            dohMaintenanceForm.ShowDialog();
        }
    }
}
