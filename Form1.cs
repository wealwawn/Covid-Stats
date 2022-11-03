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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cOVID_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOVID_DataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOVID_DBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID_DBDataSet.COVID_Data' table. You can move, or remove it, as needed.
            this.cOVID_DataTableAdapter.Fill(this.cOVID_DBDataSet.COVID_Data);

        }
    }
}
