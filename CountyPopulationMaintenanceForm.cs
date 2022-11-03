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
    public partial class CountyPopulationMaintenanceForm : Form
    {
        string countyname;
        int countyid;

        public CountyPopulationMaintenanceForm()
        {
            InitializeComponent();
        }

        private void populationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            countyid = Int32.Parse(countyIDTextBox.Text);
            countyname = (string)countiesTableAdapter.GetCountyName(countyid);
            validateModuleDetails();

            County countyobj = new County(countyname, Int32.Parse(populationTextBox.Text));
            MessageBox.Show(countyobj.ToString());
            
        }

        private void CountyPopulationMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.Counties' table. You can move, or remove it, as needed.
            this.countiesTableAdapter.Fill(this.cOVID_DBDataSet.Counties);
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.Populations' table. You can move, or remove it, as needed.
            this.populationsTableAdapter.Fill(this.cOVID_DBDataSet.Populations);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            idTextBox.Text = populationsBindingSource.Count.ToString();
            countyIDTextBox.Focus();
        }
        void validateModuleDetails()
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    if (string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        MessageBox.Show("Please enter data into all fields.");
                    }
                    else
                    {
                        this.Validate();
                        this.populationsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.cOVID_DBDataSet);
                    }
                }
            }
        }
    }
}
