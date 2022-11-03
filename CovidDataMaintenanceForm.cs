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
    public partial class CovidDataMaintenanceForm : Form
    {
        //Constructor/ Initializer for form, also sets the date time picker to today so it is not null
        public CovidDataMaintenanceForm()
        {
            InitializeComponent();
            report_DateDateTimePicker.Value = DateTime.Now;
        }


        private void CovidDataMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);

        }
        //Validation and data entry method
        private void validateModuleDetails()
        {
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    if (string.IsNullOrWhiteSpace(textbox.Text)) 
                    { MessageBox.Show("Please enter data into all fields or delete the entry."); 
                    }
                    else
                    {
                        this.Validate();
                        this.cOVID_DataBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.cOVID_DBDataSet);

                    }
                    
                }
            }

        }
        //Calls the validation method and instantiates the object
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            validateModuleDetails();
            Report report = new Report(Int32.Parse(county_IDTextBox.Text), Int32.Parse(casesTextBox.Text), Double.Parse(case_PositivityTextBox.Text), report_DateDateTimePicker.Value);
            MessageBox.Show(report.ToString());
        }
        // Automatically populates the first field with the count function and focuses the next field also resets datetime so not null
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            report_DateDateTimePicker.Value = DateTime.Now;
            idTextBox.Text = cOVID_DataBindingSource.Count.ToString();
            county_IDTextBox.Focus();
        }

    }
}
