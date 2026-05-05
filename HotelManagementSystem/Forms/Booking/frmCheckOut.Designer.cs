using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    partial class frmCheckOut
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvOccupied;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label lblPhone;           // ADD THIS
        private System.Windows.Forms.TextBox txtPhone;        // ADD THIS
        private System.Windows.Forms.GroupBox grpCharges;
        private System.Windows.Forms.CheckBox chkMiniBar;
        private System.Windows.Forms.CheckBox chkRoomService;
        private System.Windows.Forms.CheckBox chkExtraBed;
        private System.Windows.Forms.Label lblOtherCharges;
        private System.Windows.Forms.TextBox txtOtherCharges;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRoomTotal;
        private System.Windows.Forms.Label lblAdditionalCharges;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Button btnProcessCheckOut;
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
            this.btnProcessCheckOut = new System.Windows.Forms.Button();
            this.grpCharges = new System.Windows.Forms.GroupBox();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblAdditionalCharges = new System.Windows.Forms.Label();
            this.lblRoomTotal = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtOtherCharges = new System.Windows.Forms.TextBox();
            this.lblOtherCharges = new System.Windows.Forms.Label();
            this.chkExtraBed = new System.Windows.Forms.CheckBox();
            this.chkRoomService = new System.Windows.Forms.CheckBox();
            this.chkMiniBar = new System.Windows.Forms.CheckBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.dgvOccupied = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpCharges.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupied)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1650, 77);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check-Out";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnProcessCheckOut);
            this.pnlMain.Controls.Add(this.grpCharges);
            this.pnlMain.Controls.Add(this.grpDetails);
            this.pnlMain.Controls.Add(this.lblResultCount);
            this.pnlMain.Controls.Add(this.dgvOccupied);
            this.pnlMain.Controls.Add(this.grpSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 77);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.pnlMain.Size = new System.Drawing.Size(1650, 973);
            this.pnlMain.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1419, 695);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 62);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnProcessCheckOut
            // 
            this.btnProcessCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProcessCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessCheckOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcessCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnProcessCheckOut.Location = new System.Drawing.Point(1192, 695);
            this.btnProcessCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcessCheckOut.Name = "btnProcessCheckOut";
            this.btnProcessCheckOut.Size = new System.Drawing.Size(210, 62);
            this.btnProcessCheckOut.TabIndex = 5;
            this.btnProcessCheckOut.Text = "Process Check-Out";
            this.btnProcessCheckOut.UseVisualStyleBackColor = false;
            this.btnProcessCheckOut.Click += new System.EventHandler(this.btnProcessCheckOut_Click);
            // 
            // grpCharges
            // 
            this.grpCharges.Controls.Add(this.lblFinalTotal);
            this.grpCharges.Controls.Add(this.lblAdditionalCharges);
            this.grpCharges.Controls.Add(this.lblRoomTotal);
            this.grpCharges.Controls.Add(this.txtRemarks);
            this.grpCharges.Controls.Add(this.lblRemarks);
            this.grpCharges.Controls.Add(this.txtOtherCharges);
            this.grpCharges.Controls.Add(this.lblOtherCharges);
            this.grpCharges.Controls.Add(this.chkExtraBed);
            this.grpCharges.Controls.Add(this.chkRoomService);
            this.grpCharges.Controls.Add(this.chkMiniBar);
            this.grpCharges.Location = new System.Drawing.Point(870, 123);
            this.grpCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCharges.Name = "grpCharges";
            this.grpCharges.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCharges.Size = new System.Drawing.Size(750, 562);
            this.grpCharges.TabIndex = 4;
            this.grpCharges.TabStop = false;
            this.grpCharges.Text = "Additional Charges";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblFinalTotal.Location = new System.Drawing.Point(30, 507);
            this.lblFinalTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(651, 46);
            this.lblFinalTotal.TabIndex = 9;
            this.lblFinalTotal.Text = "Final Total: PKR 0";
            this.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdditionalCharges
            // 
            this.lblAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblAdditionalCharges.Location = new System.Drawing.Point(30, 456);
            this.lblAdditionalCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditionalCharges.Name = "lblAdditionalCharges";
            this.lblAdditionalCharges.Size = new System.Drawing.Size(651, 38);
            this.lblAdditionalCharges.TabIndex = 8;
            this.lblAdditionalCharges.Text = "Additional Charges: PKR 0";
            this.lblAdditionalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomTotal
            // 
            this.lblRoomTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblRoomTotal.Location = new System.Drawing.Point(30, 397);
            this.lblRoomTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomTotal.Name = "lblRoomTotal";
            this.lblRoomTotal.Size = new System.Drawing.Size(651, 38);
            this.lblRoomTotal.TabIndex = 7;
            this.lblRoomTotal.Text = "Room Total: PKR 0";
            this.lblRoomTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(30, 297);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(639, 75);
            this.txtRemarks.TabIndex = 6;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(30, 252);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(77, 20);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtOtherCharges
            // 
            this.txtOtherCharges.Location = new System.Drawing.Point(222, 197);
            this.txtOtherCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOtherCharges.Name = "txtOtherCharges";
            this.txtOtherCharges.Size = new System.Drawing.Size(223, 26);
            this.txtOtherCharges.TabIndex = 4;
            // 
            // lblOtherCharges
            // 
            this.lblOtherCharges.AutoSize = true;
            this.lblOtherCharges.Location = new System.Drawing.Point(30, 203);
            this.lblOtherCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtherCharges.Name = "lblOtherCharges";
            this.lblOtherCharges.Size = new System.Drawing.Size(163, 20);
            this.lblOtherCharges.TabIndex = 3;
            this.lblOtherCharges.Text = "Other Charges (PKR):";
            // 
            // chkExtraBed
            // 
            this.chkExtraBed.AutoSize = true;
            this.chkExtraBed.Location = new System.Drawing.Point(30, 137);
            this.chkExtraBed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkExtraBed.Name = "chkExtraBed";
            this.chkExtraBed.Size = new System.Drawing.Size(204, 24);
            this.chkExtraBed.TabIndex = 2;
            this.chkExtraBed.Text = "Extra Bed (+PKR 1,500)";
            // 
            // chkRoomService
            // 
            this.chkRoomService.AutoSize = true;
            this.chkRoomService.Location = new System.Drawing.Point(30, 94);
            this.chkRoomService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRoomService.Name = "chkRoomService";
            this.chkRoomService.Size = new System.Drawing.Size(233, 24);
            this.chkRoomService.TabIndex = 1;
            this.chkRoomService.Text = "Room Service (+PKR 1,000)";
            // 
            // chkMiniBar
            // 
            this.chkMiniBar.AutoSize = true;
            this.chkMiniBar.Location = new System.Drawing.Point(30, 50);
            this.chkMiniBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMiniBar.Name = "chkMiniBar";
            this.chkMiniBar.Size = new System.Drawing.Size(178, 24);
            this.chkMiniBar.TabIndex = 0;
            this.chkMiniBar.Text = "Mini Bar (+PKR 500)";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtPhone);
            this.grpDetails.Controls.Add(this.lblPhone);
            this.grpDetails.Controls.Add(this.txtCheckOut);
            this.grpDetails.Controls.Add(this.lblCheckOut);
            this.grpDetails.Controls.Add(this.txtCheckIn);
            this.grpDetails.Controls.Add(this.lblCheckIn);
            this.grpDetails.Controls.Add(this.txtRoomType);
            this.grpDetails.Controls.Add(this.lblRoomType);
            this.grpDetails.Controls.Add(this.txtRoomNumber);
            this.grpDetails.Controls.Add(this.lblRoomNumber);
            this.grpDetails.Controls.Add(this.txtCustomerName);
            this.grpDetails.Controls.Add(this.lblCustomerName);
            this.grpDetails.Location = new System.Drawing.Point(870, 123);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetails.Size = new System.Drawing.Size(750, 354);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Booking Details";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(210, 292);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(298, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(45, 297);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone:";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(210, 246);
            this.txtCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(223, 26);
            this.txtCheckOut.TabIndex = 9;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(45, 251);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(88, 20);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(210, 200);
            this.txtCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(223, 26);
            this.txtCheckIn.TabIndex = 7;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(45, 205);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(76, 20);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(210, 154);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(223, 26);
            this.txtRoomType.TabIndex = 5;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(45, 158);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(94, 20);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Room Type:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(210, 108);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(148, 26);
            this.txtRoomNumber.TabIndex = 3;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(45, 112);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 20);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(210, 46);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(373, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(45, 51);
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
            this.lblResultCount.Location = new System.Drawing.Point(30, 492);
            this.lblResultCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(155, 25);
            this.lblResultCount.TabIndex = 2;
            this.lblResultCount.Text = "Found 0 occupied";
            // 
            // dgvOccupied
            // 
            this.dgvOccupied.AllowUserToAddRows = false;
            this.dgvOccupied.AllowUserToDeleteRows = false;
            this.dgvOccupied.BackgroundColor = System.Drawing.Color.White;
            this.dgvOccupied.ColumnHeadersHeight = 34;
            this.dgvOccupied.Location = new System.Drawing.Point(30, 123);
            this.dgvOccupied.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOccupied.Name = "dgvOccupied";
            this.dgvOccupied.ReadOnly = true;
            this.dgvOccupied.RowHeadersWidth = 62;
            this.dgvOccupied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOccupied.Size = new System.Drawing.Size(810, 354);
            this.dgvOccupied.TabIndex = 1;
            this.dgvOccupied.SelectionChanged += new System.EventHandler(this.dgvOccupied_SelectionChanged);
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
            this.grpSearch.Text = "Search Occupied Rooms";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(600, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 43);
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
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1050);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Check-Out";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpCharges.ResumeLayout(false);
            this.grpCharges.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupied)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}