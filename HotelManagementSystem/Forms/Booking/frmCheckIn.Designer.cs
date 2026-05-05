using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    partial class frmCheckIn
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvArrivals;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.TextBox txtCheckOutDate;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.lblBookingNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.dgvArrivals = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1650, 92);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check-In";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnCheckIn);
            this.pnlMain.Controls.Add(this.grpDetails);
            this.pnlMain.Controls.Add(this.lblResultCount);
            this.pnlMain.Controls.Add(this.dgvArrivals);
            this.pnlMain.Controls.Add(this.grpSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 92);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.pnlMain.Size = new System.Drawing.Size(1650, 846);
            this.pnlMain.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1424, 597);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 54);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(1204, 597);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(195, 54);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Confirm Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtCheckOutDate);
            this.grpDetails.Controls.Add(this.lblCheckOutDate);
            this.grpDetails.Controls.Add(this.txtCheckInDate);
            this.grpDetails.Controls.Add(this.lblCheckInDate);
            this.grpDetails.Controls.Add(this.txtRemarks);
            this.grpDetails.Controls.Add(this.lblRemarks);
            this.grpDetails.Controls.Add(this.txtGuests);
            this.grpDetails.Controls.Add(this.lblGuests);
            this.grpDetails.Controls.Add(this.txtPhone);
            this.grpDetails.Controls.Add(this.lblPhone);
            this.grpDetails.Controls.Add(this.txtRoomNumber);
            this.grpDetails.Controls.Add(this.lblRoomNumber);
            this.grpDetails.Controls.Add(this.txtBookingNumber);
            this.grpDetails.Controls.Add(this.lblBookingNumber);
            this.grpDetails.Controls.Add(this.txtCustomerName);
            this.grpDetails.Controls.Add(this.lblCustomerName);
            this.grpDetails.Location = new System.Drawing.Point(870, 123);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetails.Size = new System.Drawing.Size(750, 447);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Booking Details";
            
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Location = new System.Drawing.Point(210, 311);
            this.txtCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.ReadOnly = true;
            this.txtCheckOutDate.Size = new System.Drawing.Size(223, 26);
            this.txtCheckOutDate.TabIndex = 15;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(31, 311);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(88, 20);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "Check Out:";
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Location = new System.Drawing.Point(210, 270);
            this.txtCheckInDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.Size = new System.Drawing.Size(223, 26);
            this.txtCheckInDate.TabIndex = 13;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(31, 270);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(76, 20);
            this.lblCheckInDate.TabIndex = 12;
            this.lblCheckInDate.Text = "Check In:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(210, 348);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(508, 67);
            this.txtRemarks.TabIndex = 11;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(31, 348);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(77, 20);
            this.lblRemarks.TabIndex = 10;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(210, 228);
            this.txtGuests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.ReadOnly = true;
            this.txtGuests.Size = new System.Drawing.Size(148, 26);
            this.txtGuests.TabIndex = 9;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(30, 228);
            this.lblGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(65, 20);
            this.lblGuests.TabIndex = 8;
            this.lblGuests.Text = "Guests:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(210, 188);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(298, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 188);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(210, 146);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(148, 26);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(30, 146);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 20);
            this.lblRoomNumber.TabIndex = 4;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.Location = new System.Drawing.Point(210, 100);
            this.txtBookingNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.ReadOnly = true;
            this.txtBookingNumber.Size = new System.Drawing.Size(298, 26);
            this.txtBookingNumber.TabIndex = 3;
            // 
            // lblBookingNumber
            // 
            this.lblBookingNumber.AutoSize = true;
            this.lblBookingNumber.Location = new System.Drawing.Point(30, 100);
            this.lblBookingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingNumber.Name = "lblBookingNumber";
            this.lblBookingNumber.Size = new System.Drawing.Size(131, 20);
            this.lblBookingNumber.TabIndex = 2;
            this.lblBookingNumber.Text = "Booking Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(210, 47);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(373, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(30, 47);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(128, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultCount.Location = new System.Drawing.Point(30, 723);
            this.lblResultCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(138, 25);
            this.lblResultCount.TabIndex = 2;
            this.lblResultCount.Text = "Found 0 arrivals";
            // 
            // dgvArrivals
            // 
            this.dgvArrivals.AllowUserToAddRows = false;
            this.dgvArrivals.AllowUserToDeleteRows = false;
            this.dgvArrivals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArrivals.BackgroundColor = System.Drawing.Color.White;
            this.dgvArrivals.ColumnHeadersHeight = 34;
            this.dgvArrivals.Location = new System.Drawing.Point(30, 123);
            this.dgvArrivals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArrivals.Name = "dgvArrivals";
            this.dgvArrivals.ReadOnly = true;
            this.dgvArrivals.RowHeadersWidth = 62;
            this.dgvArrivals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArrivals.Size = new System.Drawing.Size(810, 569);
            this.dgvArrivals.TabIndex = 1;
            this.dgvArrivals.SelectionChanged += new System.EventHandler(this.dgvArrivals_SelectionChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Location = new System.Drawing.Point(30, 23);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Size = new System.Drawing.Size(1590, 85);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Bookings";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(600, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(210, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(373, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(45, 38);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by Name/No:";
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 938);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Check-In";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}