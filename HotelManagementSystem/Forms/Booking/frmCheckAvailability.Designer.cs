using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    partial class frmCheckAvailability
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbFilterRoomType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbFilterPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.Button btnBookRoom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbFilterPrice = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbFilterRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnCheckAvailability);
            this.grpSearch.Controls.Add(this.dtpCheckOut);
            this.grpSearch.Controls.Add(this.lblCheckOut);
            this.grpSearch.Controls.Add(this.dtpCheckIn);
            this.grpSearch.Controls.Add(this.lblCheckIn);
            this.grpSearch.Location = new System.Drawing.Point(15, 15);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(950, 60);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Select Dates";
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvailability.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btnCheckAvailability.Location = new System.Drawing.Point(700, 20);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(150, 30);
            this.btnCheckAvailability.TabIndex = 4;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = false;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(420, 25);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(350, 28);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(64, 13);
            this.lblCheckOut.TabIndex = 2;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(220, 25);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckIn.TabIndex = 1;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(150, 28);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(56, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check In:";
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnReset);
            this.grpFilters.Controls.Add(this.cmbFilterPrice);
            this.grpFilters.Controls.Add(this.lblPrice);
            this.grpFilters.Controls.Add(this.cmbFilterRoomType);
            this.grpFilters.Controls.Add(this.lblRoomType);
            this.grpFilters.Location = new System.Drawing.Point(15, 85);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(950, 50);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(800, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 25);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Filters";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbFilterPrice
            // 
            this.cmbFilterPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterPrice.Location = new System.Drawing.Point(550, 20);
            this.cmbFilterPrice.Name = "cmbFilterPrice";
            this.cmbFilterPrice.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterPrice.TabIndex = 3;
            this.cmbFilterPrice.SelectedIndexChanged += new System.EventHandler(this.cmbFilterPrice_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(500, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // cmbFilterRoomType
            // 
            this.cmbFilterRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterRoomType.Location = new System.Drawing.Point(300, 20);
            this.cmbFilterRoomType.Name = "cmbFilterRoomType";
            this.cmbFilterRoomType.Size = new System.Drawing.Size(180, 21);
            this.cmbFilterRoomType.TabIndex = 1;
            this.cmbFilterRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterRoomType_SelectedIndexChanged);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(220, 23);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(72, 13);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type:";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.Location = new System.Drawing.Point(15, 145);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(950, 280);
            this.dgvRooms.TabIndex = 2;
            this.dgvRooms.SelectionChanged += new System.EventHandler(this.dgvRooms_SelectionChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(15, 435);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(500, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Select dates to check availability";
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedRoom.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblSelectedRoom.Location = new System.Drawing.Point(15, 460);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(700, 25);
            this.lblSelectedRoom.TabIndex = 4;
            this.lblSelectedRoom.Text = "No room selected";
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnBookRoom.Enabled = false;
            this.btnBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRoom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookRoom.ForeColor = System.Drawing.Color.White;
            this.btnBookRoom.Location = new System.Drawing.Point(750, 455);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(200, 40);
            this.btnBookRoom.TabIndex = 5;
            this.btnBookRoom.Text = "Book Selected Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // frmCheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 510);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.lblSelectedRoom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmCheckAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Room Availability";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
        }
    }
}