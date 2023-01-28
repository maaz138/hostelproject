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
    public partial class Rooms : Form

    {
        functionality fn = new functionality();
        String query;
        public Rooms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 190);
            lblRoomAdded.Visible = false;
            lblExistingRoom.Visible = false;

            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dgrAllrooms.DataSource = ds.Tables[0];
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo =" + txtNewRoomNumber.Text+ "";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if (cbNewRoomstatus.Checked)
                {
                    status = "Yes";

                }
                else
                {
                    status = "No";
                }
                lblRoomAdded.Visible = false;
                query = " insert into rooms(roomNo,roomStatus) values("+txtNewRoomNumber.Text+", '"+status+"')";
                fn.setData(query,"Room Added..");
                Rooms_Load(this, null);
                txtNewRoomNumber.Clear();
            }
            else
            {
                lblRoomAdded.Text = "Room already Exists";
                lblRoomAdded.Enabled = true;
            }
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo =" + txtUpdateRoomNumber.Text + "";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count == 0)
            {
                lblExistingRoom.Text = "No room exist";
                lblExistingRoom.Visible = true;
                cbUpdateRoomstatus.Checked = false;
            }
            else
            {
                lblExistingRoom.Text = "Room found";
                lblExistingRoom.Visible = true;
                if(ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    cbUpdateRoomstatus.Checked = true;
                }
                else
                {
                    cbUpdateRoomstatus.Checked = false;
                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string status;
            if (cbUpdateRoomstatus.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = " update rooms set roomStatus = '"+status+"' where roomNo = "+txtUpdateRoomNumber.Text+"";
            fn.setData(query, "Details Updated");
            Rooms_Load(this, null);
            txtUpdateRoomNumber.Clear();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if(lblExistingRoom.Text == "Room found")
            {
                query = "delete from rooms where roomNo=" + txtUpdateRoomNumber.Text + "";
                fn.setData(query, "Room deleted");
                Rooms_Load(this, null);
                txtUpdateRoomNumber.Clear();
            }
            else
            {
                MessageBox.Show("It doesnt exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
