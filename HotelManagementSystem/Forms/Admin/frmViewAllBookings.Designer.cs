using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    partial class frmViewAllBookings
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblConfirmedLabel;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label lblCheckedInLabel;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblCompletedLabel;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.Label lblCancelledLabel;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblRevenueLabel;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label lblFilterResult;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnCancelBooking;
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
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lblFilterResult = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblRevenueLabel = new System.Windows.Forms.Label();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.lblCancelledLabel = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblCompletedLabel = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.lblCheckedInLabel = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblConfirmedLabel = new System.Windows.Forms.Label();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.grpFilters.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All Bookings";

            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnCancelBooking);
            this.pnlMain.Controls.Add(this.btnViewDetails);
            this.pnlMain.Controls.Add(this.lblFilterResult);
            this.pnlMain.Controls.Add(this.dgvBookings);
            this.pnlMain.Controls.Add(this.grpFilters);
            this.pnlMain.Controls.Add(this.grpStats);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(1100, 650);
            this.pnlMain.TabIndex = 1;

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(980, 580);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 35);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(280, 450);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(120, 35);
            this.btnCancelBooking.TabIndex = 5;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);

            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(160, 450);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(120, 35);
            this.btnViewDetails.TabIndex = 4;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);

            // 
            // lblFilterResult
            // 
            this.lblFilterResult.AutoSize = true;
            this.lblFilterResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterResult.Location = new System.Drawing.Point(20, 450);
            this.lblFilterResult.Name = "lblFilterResult";
            this.lblFilterResult.Size = new System.Drawing.Size(70, 15);
            this.lblFilterResult.TabIndex = 3;
            this.lblFilterResult.Text = "Showing all bookings";

            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.Location = new System.Drawing.Point(20, 190);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1000, 250);  // DECREASED width and height
            this.dgvBookings.TabIndex = 2;
            // Set AutoSizeColumnsMode to fill for better horizontal fit
            this.dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnReset);
            this.grpFilters.Controls.Add(this.txtSearch);
            this.grpFilters.Controls.Add(this.lblSearch);
            this.grpFilters.Controls.Add(this.cmbRoomType);
            this.grpFilters.Controls.Add(this.lblRoomType);
            this.grpFilters.Controls.Add(this.cmbPaymentStatus);
            this.grpFilters.Controls.Add(this.lblPaymentStatus);
            this.grpFilters.Controls.Add(this.cmbStatus);
            this.grpFilters.Controls.Add(this.lblStatus);
            this.grpFilters.Location = new System.Drawing.Point(20, 130);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(1050, 50);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";

            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(950, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 25);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(830, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(780, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";

            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Location = new System.Drawing.Point(600, 20);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(140, 21);
            this.cmbRoomType.TabIndex = 5;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);

            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(530, 23);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(63, 13);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Room Type:";

            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(390, 20);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(120, 21);
            this.cmbPaymentStatus.TabIndex = 3;
            this.cmbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentStatus_SelectedIndexChanged);

            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(300, 23);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(84, 13);
            this.lblPaymentStatus.TabIndex = 2;
            this.lblPaymentStatus.Text = "Payment Status:";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(180, 20);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(130, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";

            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblTotalRevenue);
            this.grpStats.Controls.Add(this.lblRevenueLabel);
            this.grpStats.Controls.Add(this.lblCancelled);
            this.grpStats.Controls.Add(this.lblCancelledLabel);
            this.grpStats.Controls.Add(this.lblCompleted);
            this.grpStats.Controls.Add(this.lblCompletedLabel);
            this.grpStats.Controls.Add(this.lblCheckedIn);
            this.grpStats.Controls.Add(this.lblCheckedInLabel);
            this.grpStats.Controls.Add(this.lblConfirmed);
            this.grpStats.Controls.Add(this.lblConfirmedLabel);
            this.grpStats.Controls.Add(this.lblTotalBookings);
            this.grpStats.Controls.Add(this.lblTotalLabel);
            this.grpStats.Location = new System.Drawing.Point(20, 15);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(1050, 100);
            this.grpStats.TabIndex = 0;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Summary";

            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblTotalRevenue.Location = new System.Drawing.Point(880, 55);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(140, 25);
            this.lblTotalRevenue.TabIndex = 11;
            this.lblTotalRevenue.Text = "PKR 0";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblRevenueLabel
            // 
            this.lblRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRevenueLabel.Location = new System.Drawing.Point(880, 30);
            this.lblRevenueLabel.Name = "lblRevenueLabel";
            this.lblRevenueLabel.Size = new System.Drawing.Size(140, 20);
            this.lblRevenueLabel.TabIndex = 10;
            this.lblRevenueLabel.Text = "Total Revenue";
            this.lblRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCancelled
            // 
            this.lblCancelled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCancelled.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblCancelled.Location = new System.Drawing.Point(710, 55);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(130, 25);
            this.lblCancelled.TabIndex = 9;
            this.lblCancelled.Text = "0";
            this.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCancelledLabel
            // 
            this.lblCancelledLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCancelledLabel.Location = new System.Drawing.Point(710, 30);
            this.lblCancelledLabel.Name = "lblCancelledLabel";
            this.lblCancelledLabel.Size = new System.Drawing.Size(130, 20);
            this.lblCancelledLabel.TabIndex = 8;
            this.lblCancelledLabel.Text = "Cancelled";
            this.lblCancelledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCompleted
            // 
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblCompleted.Location = new System.Drawing.Point(540, 55);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(130, 25);
            this.lblCompleted.TabIndex = 7;
            this.lblCompleted.Text = "0";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCompletedLabel
            // 
            this.lblCompletedLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCompletedLabel.Location = new System.Drawing.Point(540, 30);
            this.lblCompletedLabel.Name = "lblCompletedLabel";
            this.lblCompletedLabel.Size = new System.Drawing.Size(130, 20);
            this.lblCompletedLabel.TabIndex = 6;
            this.lblCompletedLabel.Text = "Completed";
            this.lblCompletedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckedIn.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblCheckedIn.Location = new System.Drawing.Point(370, 55);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(130, 25);
            this.lblCheckedIn.TabIndex = 5;
            this.lblCheckedIn.Text = "0";
            this.lblCheckedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCheckedInLabel
            // 
            this.lblCheckedInLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCheckedInLabel.Location = new System.Drawing.Point(370, 30);
            this.lblCheckedInLabel.Name = "lblCheckedInLabel";
            this.lblCheckedInLabel.Size = new System.Drawing.Size(130, 20);
            this.lblCheckedInLabel.TabIndex = 4;
            this.lblCheckedInLabel.Text = "Checked-In";
            this.lblCheckedInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblConfirmed
            // 
            this.lblConfirmed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmed.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblConfirmed.Location = new System.Drawing.Point(200, 55);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(130, 25);
            this.lblConfirmed.TabIndex = 3;
            this.lblConfirmed.Text = "0";
            this.lblConfirmed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblConfirmedLabel
            // 
            this.lblConfirmedLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblConfirmedLabel.Location = new System.Drawing.Point(200, 30);
            this.lblConfirmedLabel.Name = "lblConfirmedLabel";
            this.lblConfirmedLabel.Size = new System.Drawing.Size(130, 20);
            this.lblConfirmedLabel.TabIndex = 2;
            this.lblConfirmedLabel.Text = "Confirmed";
            this.lblConfirmedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTotalBookings
            // 
            this.lblTotalBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalBookings.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTotalBookings.Location = new System.Drawing.Point(30, 55);
            this.lblTotalBookings.Name = "lblTotalBookings";
            this.lblTotalBookings.Size = new System.Drawing.Size(120, 25);
            this.lblTotalBookings.TabIndex = 1;
            this.lblTotalBookings.Text = "0";
            this.lblTotalBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(30, 30);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(120, 20);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total Bookings";
            this.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // frmViewAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmViewAllBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Bookings";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}