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
{
    public partial class CovidDataForm : Form
    {
        public CovidDataForm()
        {
            InitializeComponent();
        }

        private void CovidDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);

        }

        private void btnCountySearch_Click(object sender, EventArgs e)
        {
            string searchCounty = "%" + txtCountySearch.Text + "%";
            try
            {
                this.cOVID_DataTableAdapter.CountySearch(this.cOVID_DBDataSet.COVID_Data, searchCounty);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnMinCaseAmt_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOVID_DataTableAdapter.Mincases(this.cOVID_DBDataSet.COVID_Data, ((int)(System.Convert.ChangeType(txtMinCasesAmt.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);              
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void countySearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOVID_DataTableAdapter.CountySearch(this.cOVID_DBDataSet.COVID_Data, valueToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
