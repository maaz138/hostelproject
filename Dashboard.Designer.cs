namespace HostelProject
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pbHostelPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNavBar = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManageRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHostelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHostelPic
            // 
            this.pbHostelPic.BorderRadius = 30;
            this.pbHostelPic.Image = ((System.Drawing.Image)(resources.GetObject("pbHostelPic.Image")));
            this.pbHostelPic.Location = new System.Drawing.Point(242, 87);
            this.pbHostelPic.Name = "pbHostelPic";
            this.pbHostelPic.ShadowDecoration.Parent = this.pbHostelPic;
            this.pbHostelPic.Size = new System.Drawing.Size(1107, 600);
            this.pbHostelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHostelPic.TabIndex = 0;
            this.pbHostelPic.TabStop = false;
            // 
            // lblNavBar
            // 
            this.lblNavBar.AutoSize = true;
            this.lblNavBar.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavBar.ForeColor = System.Drawing.Color.White;
            this.lblNavBar.Location = new System.Drawing.Point(21, 27);
            this.lblNavBar.Name = "lblNavBar";
            this.lblNavBar.Size = new System.Drawing.Size(192, 39);
            this.lblNavBar.TabIndex = 1;
            this.lblNavBar.Text = "Navigation Bar";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(587, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(512, 69);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Hostel Management System";
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BorderRadius = 20;
            this.btnManageRoom.CheckedState.Parent = this.btnManageRoom;
            this.btnManageRoom.CustomImages.Parent = this.btnManageRoom;
            this.btnManageRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnManageRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.White;
            this.btnManageRoom.HoverState.FillColor = System.Drawing.Color.White;
            this.btnManageRoom.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnManageRoom.HoverState.Parent = this.btnManageRoom;
            this.btnManageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRoom.Image")));
            this.btnManageRoom.Location = new System.Drawing.Point(17, 272);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.ShadowDecoration.Parent = this.btnManageRoom;
            this.btnManageRoom.Size = new System.Drawing.Size(211, 40);
            this.btnManageRoom.TabIndex = 3;
            this.btnManageRoom.Text = "Manage Rooms";
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(118)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogout.Location = new System.Drawing.Point(304, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(140, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderThickness = 1;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(1274, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(56, 56);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1365, 708);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageRoom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNavBar);
            this.Controls.Add(this.pbHostelPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pbHostelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbHostelPic;
        private System.Windows.Forms.Label lblNavBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnManageRoom;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}