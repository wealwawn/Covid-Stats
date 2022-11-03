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
    public partial class LoginForm : Form
    {
        public bool hasLoggedIn = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password123")
            {
                hasLoggedIn = true;
                lblLoginResults.Text = "You have succesfully logged in. You can now see the maintenance forms in the maintenance menu.";
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                hasLoggedIn = false;
                lblLoginResults.Text = "You have entered the wrong login information";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            lblLoginResults.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

