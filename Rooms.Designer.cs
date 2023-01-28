namespace HostelProject
{
    partial class Rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.lblUpdareRoom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbNewRoomstatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbUpdateRoomstatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSearchRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.lblAllRooms = new System.Windows.Forms.Label();
            this.dgrAllrooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblRoomAdded = new System.Windows.Forms.Label();
            this.lblExistingRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAllrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRoom.ForeColor = System.Drawing.Color.White;
            this.lblNewRoom.Location = new System.Drawing.Point(30, 26);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(175, 25);
            this.lblNewRoom.TabIndex = 0;
            this.lblNewRoom.Text = "Add New Room";
            // 
            // lblUpdareRoom
            // 
            this.lblUpdareRoom.AutoSize = true;
            this.lblUpdareRoom.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdareRoom.ForeColor = System.Drawing.Color.White;
            this.lblUpdareRoom.Location = new System.Drawing.Point(30, 169);
            this.lblUpdareRoom.Name = "lblUpdareRoom";
            this.lblUpdareRoom.Size = new System.Drawing.Size(287, 25);
            this.lblUpdareRoom.TabIndex = 1;
            this.lblUpdareRoom.Text = "Update or Delete Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(305, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Active or Deactive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(305, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Active or Deactive";
            // 
            // txtUpdateRoomNumber
            // 
            this.txtUpdateRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateRoomNumber.DefaultText = "";
            this.txtUpdateRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateRoomNumber.DisabledState.Parent = this.txtUpdateRoomNumber;
            this.txtUpdateRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateRoomNumber.FocusedState.Parent = this.txtUpdateRoomNumber;
            this.txtUpdateRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateRoomNumber.HoverState.Parent = this.txtUpdateRoomNumber;
            this.txtUpdateRoomNumber.Location = new System.Drawing.Point(145, 243);
            this.txtUpdateRoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateRoomNumber.Name = "txtUpdateRoomNumber";
            this.txtUpdateRoomNumber.PasswordChar = '\0';
            this.txtUpdateRoomNumber.PlaceholderText = "";
            this.txtUpdateRoomNumber.SelectedText = "";
            this.txtUpdateRoomNumber.ShadowDecoration.Parent = this.txtUpdateRoomNumber;
            this.txtUpdateRoomNumber.Size = new System.Drawing.Size(135, 25);
            this.txtUpdateRoomNumber.TabIndex = 2;

            // 
            // txtNewRoomNumber
            // 
            this.txtNewRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewRoomNumber.DefaultText = "";
            this.txtNewRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewRoomNumber.DisabledState.Parent = this.txtNewRoomNumber;
            this.txtNewRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewRoomNumber.FocusedState.Parent = this.txtNewRoomNumber;
            this.txtNewRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewRoomNumber.HoverState.Parent = this.txtNewRoomNumber;
            this.txtNewRoomNumber.Location = new System.Drawing.Point(145, 80);
            this.txtNewRoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewRoomNumber.Name = "txtNewRoomNumber";
            this.txtNewRoomNumber.PasswordChar = '\0';
            this.txtNewRoomNumber.PlaceholderText = "";
            this.txtNewRoomNumber.SelectedText = "";
            this.txtNewRoomNumber.ShadowDecoration.Parent = this.txtNewRoomNumber;
            this.txtNewRoomNumber.Size = new System.Drawing.Size(135, 25);
            this.txtNewRoomNumber.TabIndex = 1;
            // 
            // cbNewRoomstatus
            // 
            this.cbNewRoomstatus.AutoSize = true;
            this.cbNewRoomstatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNewRoomstatus.CheckedState.BorderRadius = 0;
            this.cbNewRoomstatus.CheckedState.BorderThickness = 0;
            this.cbNewRoomstatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNewRoomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbNewRoomstatus.ForeColor = System.Drawing.Color.White;
            this.cbNewRoomstatus.Location = new System.Drawing.Point(473, 86);
            this.cbNewRoomstatus.Name = "cbNewRoomstatus";
            this.cbNewRoomstatus.Size = new System.Drawing.Size(56, 20);
            this.cbNewRoomstatus.TabIndex = 10;
            this.cbNewRoomstatus.Text = "YES";
            this.cbNewRoomstatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbNewRoomstatus.UncheckedState.BorderRadius = 0;
            this.cbNewRoomstatus.UncheckedState.BorderThickness = 0;
            this.cbNewRoomstatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbUpdateRoomstatus
            // 
            this.cbUpdateRoomstatus.AutoSize = true;
            this.cbUpdateRoomstatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateRoomstatus.CheckedState.BorderRadius = 0;
            this.cbUpdateRoomstatus.CheckedState.BorderThickness = 0;
            this.cbUpdateRoomstatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUpdateRoomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cbUpdateRoomstatus.ForeColor = System.Drawing.Color.White;
            this.cbUpdateRoomstatus.Location = new System.Drawing.Point(473, 248);
            this.cbUpdateRoomstatus.Name = "cbUpdateRoomstatus";
            this.cbUpdateRoomstatus.Size = new System.Drawing.Size(56, 20);
            this.cbUpdateRoomstatus.TabIndex = 12;
            this.cbUpdateRoomstatus.Text = "YES";
            this.cbUpdateRoomstatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbUpdateRoomstatus.UncheckedState.BorderRadius = 0;
            this.cbUpdateRoomstatus.UncheckedState.BorderThickness = 0;
            this.cbUpdateRoomstatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BorderRadius = 20;
            this.btnSearchRoom.CheckedState.Parent = this.btnSearchRoom;
            this.btnSearchRoom.CustomImages.Parent = this.btnSearchRoom;
            this.btnSearchRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchRoom.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoom.HoverState.Parent = this.btnSearchRoom;
            this.btnSearchRoom.Location = new System.Drawing.Point(57, 304);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.ShadowDecoration.Parent = this.btnSearchRoom;
            this.btnSearchRoom.Size = new System.Drawing.Size(81, 40);
            this.btnSearchRoom.TabIndex = 13;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.BorderRadius = 20;
            this.btnAddNewRoom.CheckedState.Parent = this.btnAddNewRoom;
            this.btnAddNewRoom.CustomImages.Parent = this.btnAddNewRoom;
            this.btnAddNewRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRoom.HoverState.Parent = this.btnAddNewRoom;
            this.btnAddNewRoom.Location = new System.Drawing.Point(625, 80);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.ShadowDecoration.Parent = this.btnAddNewRoom;
            this.btnAddNewRoom.Size = new System.Drawing.Size(81, 40);
            this.btnAddNewRoom.TabIndex = 13;
            this.btnAddNewRoom.Text = "Add Room";
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BorderRadius = 20;
            this.btnDeleteRoom.CheckedState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.CustomImages.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.HoverState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Location = new System.Drawing.Point(760, 248);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.ShadowDecoration.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Size = new System.Drawing.Size(81, 40);
            this.btnDeleteRoom.TabIndex = 13;
            this.btnDeleteRoom.Text = "Delete";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BorderRadius = 20;
            this.btnUpdateRoom.CheckedState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.CustomImages.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.HoverState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Location = new System.Drawing.Point(616, 248);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.ShadowDecoration.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Size = new System.Drawing.Size(81, 40);
            this.btnUpdateRoom.TabIndex = 13;
            this.btnUpdateRoom.Text = "Update";
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // lblAllRooms
            // 
            this.lblAllRooms.AutoSize = true;
            this.lblAllRooms.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllRooms.ForeColor = System.Drawing.Color.White;
            this.lblAllRooms.Location = new System.Drawing.Point(389, 341);
            this.lblAllRooms.Name = "lblAllRooms";
            this.lblAllRooms.Size = new System.Drawing.Size(110, 28);
            this.lblAllRooms.TabIndex = 14;
            this.lblAllRooms.Text = "All Rooms";
            // 
            // dgrAllrooms
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgrAllrooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrAllrooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrAllrooms.BackgroundColor = System.Drawing.Color.White;
            this.dgrAllrooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrAllrooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrAllrooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrAllrooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrAllrooms.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrAllrooms.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgrAllrooms.EnableHeadersVisualStyles = false;
            this.dgrAllrooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrAllrooms.Location = new System.Drawing.Point(12, 383);
            this.dgrAllrooms.Name = "dgrAllrooms";
            this.dgrAllrooms.RowHeadersVisible = false;
            this.dgrAllrooms.RowHeadersWidth = 51;
            this.dgrAllrooms.RowTemplate.Height = 24;
            this.dgrAllrooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrAllrooms.Size = new System.Drawing.Size(879, 212);
            this.dgrAllrooms.TabIndex = 15;
            this.dgrAllrooms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgrAllrooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrAllrooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrAllrooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrAllrooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrAllrooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrAllrooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgrAllrooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrAllrooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgrAllrooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgrAllrooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrAllrooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgrAllrooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrAllrooms.ThemeStyle.HeaderStyle.Height = 4;
            this.dgrAllrooms.ThemeStyle.ReadOnly = false;
            this.dgrAllrooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrAllrooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrAllrooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgrAllrooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgrAllrooms.ThemeStyle.RowsStyle.Height = 24;
            this.dgrAllrooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgrAllrooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 20;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(815, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(56, 48);
            this.btnExit.TabIndex = 16;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRoomAdded
            // 
            this.lblRoomAdded.AutoSize = true;
            this.lblRoomAdded.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomAdded.ForeColor = System.Drawing.Color.Yellow;
            this.lblRoomAdded.Location = new System.Drawing.Point(177, 122);
            this.lblRoomAdded.Name = "lblRoomAdded";
            this.lblRoomAdded.Size = new System.Drawing.Size(67, 21);
            this.lblRoomAdded.TabIndex = 2;
            this.lblRoomAdded.Text = "setText";
            // 
            // lblExistingRoom
            // 
            this.lblExistingRoom.AutoSize = true;
            this.lblExistingRoom.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingRoom.ForeColor = System.Drawing.Color.Yellow;
            this.lblExistingRoom.Location = new System.Drawing.Point(187, 282);
            this.lblExistingRoom.Name = "lblExistingRoom";
            this.lblExistingRoom.Size = new System.Drawing.Size(67, 21);
            this.lblExistingRoom.TabIndex = 2;
            this.lblExistingRoom.Text = "setText";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(907, 612);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgrAllrooms);
            this.Controls.Add(this.lblAllRooms);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnAddNewRoom);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.cbUpdateRoomstatus);
            this.Controls.Add(this.cbNewRoomstatus);
            this.Controls.Add(this.txtNewRoomNumber);
            this.Controls.Add(this.txtUpdateRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblExistingRoom);
            this.Controls.Add(this.lblRoomAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUpdareRoom);
            this.Controls.Add(this.lblNewRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrAllrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.Label lblUpdareRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtNewRoomNumber;
        private Guna.UI2.WinForms.Guna2CheckBox cbNewRoomstatus;
        private Guna.UI2.WinForms.Guna2CheckBox cbUpdateRoomstatus;
        private Guna.UI2.WinForms.Guna2Button btnSearchRoom;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private System.Windows.Forms.Label lblAllRooms;
        private Guna.UI2.WinForms.Guna2DataGridView dgrAllrooms;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblRoomAdded;
        private System.Windows.Forms.Label lblExistingRoom;
    }
}