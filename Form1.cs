using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="admin" && txtPassword.Text == "12345")
            {
                this.Hide();
                Dashboard d = new Dashboard();
                d.Show();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
    }
}
