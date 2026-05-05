namespace HotelManagementSystem.Forms.Booking
{
    partial class frmPayment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpBookingSummary;
        private System.Windows.Forms.Label lblBookingNumberLabel;
        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRoomNumberLabel;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomTypeLabel;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckInLabel;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOutLabel;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblNightsLabel;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountLabel;
        private System.Windows.Forms.Label lblDueAmount;
        private System.Windows.Forms.Label lblDueAmountLabel;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Panel pnlCardDetails;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAmountReceived;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeAmount;
        private System.Windows.Forms.Label lblInfo;

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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblChangeAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.lblAmountReceived = new System.Windows.Forms.Label();
            this.pnlCardDetails = new System.Windows.Forms.Panel();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDueAmount = new System.Windows.Forms.Label();
            this.lblDueAmountLabel = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpBookingSummary = new System.Windows.Forms.GroupBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblNightsLabel = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckOutLabel = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckInLabel = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomTypeLabel = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomNumberLabel = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblBookingNumber = new System.Windows.Forms.Label();
            this.lblBookingNumberLabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.pnlCardDetails.SuspendLayout();
            this.grpBookingSummary.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1125, 92);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment Portal";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnProcessPayment);
            this.pnlMain.Controls.Add(this.grpPayment);
            this.pnlMain.Controls.Add(this.grpBookingSummary);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 92);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.pnlMain.Size = new System.Drawing.Size(1125, 958);
            this.pnlMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(896, 824);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 62);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(655, 821);
            this.btnProcessPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(210, 62);
            this.btnProcessPayment.TabIndex = 2;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblChangeAmount);
            this.grpPayment.Controls.Add(this.lblChange);
            this.grpPayment.Controls.Add(this.txtAmountReceived);
            this.grpPayment.Controls.Add(this.lblAmountReceived);
            this.grpPayment.Controls.Add(this.pnlCardDetails);
            this.grpPayment.Controls.Add(this.cmbPaymentMethod);
            this.grpPayment.Controls.Add(this.lblPaymentMethod);
            this.grpPayment.Controls.Add(this.lblDueAmount);
            this.grpPayment.Controls.Add(this.lblDueAmountLabel);
            this.grpPayment.Controls.Add(this.lblTotalAmount);
            this.grpPayment.Controls.Add(this.lblTotalAmountLabel);
            this.grpPayment.Controls.Add(this.lblInfo);
            this.grpPayment.Location = new System.Drawing.Point(30, 381);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPayment.Size = new System.Drawing.Size(1065, 428);
            this.grpPayment.TabIndex = 1;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // lblChangeAmount
            // 
            this.lblChangeAmount.AutoSize = true;
            this.lblChangeAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChangeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblChangeAmount.Location = new System.Drawing.Point(825, 385);
            this.lblChangeAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeAmount.Name = "lblChangeAmount";
            this.lblChangeAmount.Size = new System.Drawing.Size(68, 28);
            this.lblChangeAmount.TabIndex = 10;
            this.lblChangeAmount.Text = "PKR 0";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(750, 389);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(69, 20);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "Change:";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Location = new System.Drawing.Point(825, 338);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(148, 26);
            this.txtAmountReceived.TabIndex = 8;
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.txtAmountReceived_TextChanged);
            this.txtAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountReceived_KeyPress);
            // 
            // lblAmountReceived
            // 
            this.lblAmountReceived.AutoSize = true;
            this.lblAmountReceived.Location = new System.Drawing.Point(660, 343);
            this.lblAmountReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountReceived.Name = "lblAmountReceived";
            this.lblAmountReceived.Size = new System.Drawing.Size(139, 20);
            this.lblAmountReceived.TabIndex = 7;
            this.lblAmountReceived.Text = "Amount Received:";
            this.lblAmountReceived.Visible = false;
            // 
            // pnlCardDetails
            // 
            this.pnlCardDetails.Controls.Add(this.txtCVV);
            this.pnlCardDetails.Controls.Add(this.lblCVV);
            this.pnlCardDetails.Controls.Add(this.txtExpiry);
            this.pnlCardDetails.Controls.Add(this.lblExpiry);
            this.pnlCardDetails.Controls.Add(this.txtCardHolder);
            this.pnlCardDetails.Controls.Add(this.lblCardHolder);
            this.pnlCardDetails.Controls.Add(this.txtCardNumber);
            this.pnlCardDetails.Controls.Add(this.lblCardNumber);
            this.pnlCardDetails.Location = new System.Drawing.Point(30, 169);
            this.pnlCardDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCardDetails.Name = "pnlCardDetails";
            this.pnlCardDetails.Size = new System.Drawing.Size(1005, 154);
            this.pnlCardDetails.TabIndex = 6;
            this.pnlCardDetails.Visible = false;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(825, 15);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(118, 26);
            this.txtCVV.TabIndex = 7;
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(765, 20);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(46, 20);
            this.lblCVV.TabIndex = 6;
            this.lblCVV.Text = "CVV:";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(630, 15);
            this.txtExpiry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpiry.MaxLength = 5;
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(118, 26);
            this.txtExpiry.TabIndex = 5;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(555, 20);
            this.lblExpiry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(55, 20);
            this.lblExpiry.TabIndex = 4;
            this.lblExpiry.Text = "Expiry:";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.Location = new System.Drawing.Point(180, 77);
            this.txtCardHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(373, 26);
            this.txtCardHolder.TabIndex = 3;
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(30, 82);
            this.lblCardHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(98, 20);
            this.lblCardHolder.TabIndex = 2;
            this.lblCardHolder.Text = "Card Holder:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(180, 15);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCardNumber.MaxLength = 19;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(373, 26);
            this.txtCardNumber.TabIndex = 1;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(30, 20);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(107, 20);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Bank Transfer"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(185, 71);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(298, 28);
            this.cmbPaymentMethod.TabIndex = 5;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(34, 71);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(133, 20);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblDueAmount
            // 
            this.lblDueAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDueAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblDueAmount.Location = new System.Drawing.Point(825, 108);
            this.lblDueAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueAmount.Name = "lblDueAmount";
            this.lblDueAmount.Size = new System.Drawing.Size(180, 38);
            this.lblDueAmount.TabIndex = 3;
            this.lblDueAmount.Text = "PKR 0";
            this.lblDueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDueAmountLabel
            // 
            this.lblDueAmountLabel.AutoSize = true;
            this.lblDueAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDueAmountLabel.Location = new System.Drawing.Point(660, 112);
            this.lblDueAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueAmountLabel.Name = "lblDueAmountLabel";
            this.lblDueAmountLabel.Size = new System.Drawing.Size(137, 28);
            this.lblDueAmountLabel.TabIndex = 2;
            this.lblDueAmountLabel.Text = "Due Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(825, 46);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(180, 38);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "PKR 0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountLabel
            // 
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(630, 51);
            this.lblTotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.Size = new System.Drawing.Size(146, 28);
            this.lblTotalAmountLabel.TabIndex = 0;
            this.lblTotalAmountLabel.Text = "Total Amount:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblInfo.Location = new System.Drawing.Point(30, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(190, 28);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Total Amount Due:";
            // 
            // grpBookingSummary
            // 
            this.grpBookingSummary.Controls.Add(this.lblNights);
            this.grpBookingSummary.Controls.Add(this.lblNightsLabel);
            this.grpBookingSummary.Controls.Add(this.lblCheckOut);
            this.grpBookingSummary.Controls.Add(this.lblCheckOutLabel);
            this.grpBookingSummary.Controls.Add(this.lblCheckIn);
            this.grpBookingSummary.Controls.Add(this.lblCheckInLabel);
            this.grpBookingSummary.Controls.Add(this.lblRoomType);
            this.grpBookingSummary.Controls.Add(this.lblRoomTypeLabel);
            this.grpBookingSummary.Controls.Add(this.lblRoomNumber);
            this.grpBookingSummary.Controls.Add(this.lblRoomNumberLabel);
            this.grpBookingSummary.Controls.Add(this.lblCustomerName);
            this.grpBookingSummary.Controls.Add(this.lblCustomerNameLabel);
            this.grpBookingSummary.Controls.Add(this.lblBookingNumber);
            this.grpBookingSummary.Controls.Add(this.lblBookingNumberLabel);
            this.grpBookingSummary.Location = new System.Drawing.Point(30, 31);
            this.grpBookingSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBookingSummary.Name = "grpBookingSummary";
            this.grpBookingSummary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBookingSummary.Size = new System.Drawing.Size(1065, 336);
            this.grpBookingSummary.TabIndex = 0;
            this.grpBookingSummary.TabStop = false;
            this.grpBookingSummary.Text = "Booking Summary";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNights.Location = new System.Drawing.Point(780, 292);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(24, 28);
            this.lblNights.TabIndex = 13;
            this.lblNights.Text = "0";
            // 
            // lblNightsLabel
            // 
            this.lblNightsLabel.AutoSize = true;
            this.lblNightsLabel.Location = new System.Drawing.Point(690, 297);
            this.lblNightsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNightsLabel.Name = "lblNightsLabel";
            this.lblNightsLabel.Size = new System.Drawing.Size(58, 20);
            this.lblNightsLabel.TabIndex = 12;
            this.lblNightsLabel.Text = "Nights:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.Location = new System.Drawing.Point(780, 231);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(126, 28);
            this.lblCheckOut.TabIndex = 11;
            this.lblCheckOut.Text = "00/00/0000";
            // 
            // lblCheckOutLabel
            // 
            this.lblCheckOutLabel.AutoSize = true;
            this.lblCheckOutLabel.Location = new System.Drawing.Point(660, 235);
            this.lblCheckOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutLabel.Name = "lblCheckOutLabel";
            this.lblCheckOutLabel.Size = new System.Drawing.Size(88, 20);
            this.lblCheckOutLabel.TabIndex = 10;
            this.lblCheckOutLabel.Text = "Check Out:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(780, 169);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(126, 28);
            this.lblCheckIn.TabIndex = 9;
            this.lblCheckIn.Text = "00/00/0000";
            // 
            // lblCheckInLabel
            // 
            this.lblCheckInLabel.AutoSize = true;
            this.lblCheckInLabel.Location = new System.Drawing.Point(675, 174);
            this.lblCheckInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInLabel.Name = "lblCheckInLabel";
            this.lblCheckInLabel.Size = new System.Drawing.Size(76, 20);
            this.lblCheckInLabel.TabIndex = 8;
            this.lblCheckInLabel.Text = "Check In:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.Location = new System.Drawing.Point(780, 108);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(97, 28);
            this.lblRoomType.TabIndex = 7;
            this.lblRoomType.Text = "Standard";
            // 
            // lblRoomTypeLabel
            // 
            this.lblRoomTypeLabel.AutoSize = true;
            this.lblRoomTypeLabel.Location = new System.Drawing.Point(645, 112);
            this.lblRoomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomTypeLabel.Name = "lblRoomTypeLabel";
            this.lblRoomTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.lblRoomTypeLabel.TabIndex = 6;
            this.lblRoomTypeLabel.Text = "Room Type:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Location = new System.Drawing.Point(180, 292);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(48, 28);
            this.lblRoomNumber.TabIndex = 5;
            this.lblRoomNumber.Text = "101";
            // 
            // lblRoomNumberLabel
            // 
            this.lblRoomNumberLabel.AutoSize = true;
            this.lblRoomNumberLabel.Location = new System.Drawing.Point(45, 297);
            this.lblRoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumberLabel.Name = "lblRoomNumberLabel";
            this.lblRoomNumberLabel.Size = new System.Drawing.Size(116, 20);
            this.lblRoomNumberLabel.TabIndex = 4;
            this.lblRoomNumberLabel.Text = "Room Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(180, 231);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(164, 28);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(30, 235);
            this.lblCustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(128, 20);
            this.lblCustomerNameLabel.TabIndex = 2;
            this.lblCustomerNameLabel.Text = "Customer Name:";
            // 
            // lblBookingNumber
            // 
            this.lblBookingNumber.AutoSize = true;
            this.lblBookingNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingNumber.Location = new System.Drawing.Point(180, 169);
            this.lblBookingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingNumber.Name = "lblBookingNumber";
            this.lblBookingNumber.Size = new System.Drawing.Size(135, 28);
            this.lblBookingNumber.TabIndex = 1;
            this.lblBookingNumber.Text = "BKG0000000";
            // 
            // lblBookingNumberLabel
            // 
            this.lblBookingNumberLabel.AutoSize = true;
            this.lblBookingNumberLabel.Location = new System.Drawing.Point(30, 174);
            this.lblBookingNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingNumberLabel.Name = "lblBookingNumberLabel";
            this.lblBookingNumberLabel.Size = new System.Drawing.Size(131, 20);
            this.lblBookingNumberLabel.TabIndex = 0;
            this.lblBookingNumberLabel.Text = "Booking Number:";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 1050);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Portal";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.pnlCardDetails.ResumeLayout(false);
            this.pnlCardDetails.PerformLayout();
            this.grpBookingSummary.ResumeLayout(false);
            this.grpBookingSummary.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}