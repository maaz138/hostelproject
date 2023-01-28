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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.Show();
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            this.Hide();
        }
    }
}
