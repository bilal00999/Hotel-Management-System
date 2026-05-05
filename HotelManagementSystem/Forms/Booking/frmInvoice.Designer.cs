namespace HotelManagementSystem.Forms.Booking
{
    partial class frmInvoice
    {
        private System.ComponentModel.IContainer components = null;

        // Labels
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInvoiceTitle;

        // Buttons
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnClose;

        // Panels
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Panel pnlFooter;

        // GroupBoxes
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.GroupBox grpBookingInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();

            // GroupBoxes
            this.grpBookingInfo = new System.Windows.Forms.GroupBox();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();

            // Labels inside groupboxes
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblBookingNumber = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpBookingInfo.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpRoomInfo.SuspendLayout();
            this.grpPaymentInfo.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 50);
            this.pnlHeader.TabIndex = 0;

            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(750, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Invoice";

            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.btnDownload);
            this.pnlMain.Controls.Add(this.btnPrint);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlInvoice);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(850, 520);
            this.pnlMain.TabIndex = 1;

            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(660, 470);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(85, 35);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);

            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(750, 470);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlFooter.Location = new System.Drawing.Point(20, 440);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(810, 20);
            this.pnlFooter.TabIndex = 1;

            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.White;
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.grpPaymentInfo);
            this.pnlInvoice.Controls.Add(this.grpRoomInfo);
            this.pnlInvoice.Controls.Add(this.grpCustomerInfo);
            this.pnlInvoice.Controls.Add(this.grpBookingInfo);
            this.pnlInvoice.Controls.Add(this.lblInvoiceTitle);
            this.pnlInvoice.Location = new System.Drawing.Point(20, 15);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(810, 420);
            this.pnlInvoice.TabIndex = 0;

            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTitle.Location = new System.Drawing.Point(360, 10);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(100, 32);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "INVOICE";

            // 
            // grpBookingInfo
            // 
            this.grpBookingInfo.Controls.Add(this.lblBookingDate);
            this.grpBookingInfo.Controls.Add(this.lblBookingNumber);
            this.grpBookingInfo.Controls.Add(this.lblInvoiceDate);
            this.grpBookingInfo.Controls.Add(this.lblInvoiceNumber);
            this.grpBookingInfo.Location = new System.Drawing.Point(15, 50);
            this.grpBookingInfo.Name = "grpBookingInfo";
            this.grpBookingInfo.Size = new System.Drawing.Size(780, 65);
            this.grpBookingInfo.TabIndex = 1;
            this.grpBookingInfo.TabStop = false;
            this.grpBookingInfo.Text = "Booking Information";

            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumber.Location = new System.Drawing.Point(15, 25);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(80, 15);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "INV-0000000";

            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(620, 28);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(67, 13);
            this.lblInvoiceDate.TabIndex = 1;
            this.lblInvoiceDate.Text = "00/00/0000";

            // 
            // lblBookingNumber
            // 
            this.lblBookingNumber.AutoSize = true;
            this.lblBookingNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingNumber.Location = new System.Drawing.Point(15, 45);
            this.lblBookingNumber.Name = "lblBookingNumber";
            this.lblBookingNumber.Size = new System.Drawing.Size(80, 15);
            this.lblBookingNumber.TabIndex = 2;
            this.lblBookingNumber.Text = "BKG0000000";

            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(620, 48);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(67, 13);
            this.lblBookingDate.TabIndex = 3;
            this.lblBookingDate.Text = "00/00/0000";

            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblCustomerAddress);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerPhone);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerEmail);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Location = new System.Drawing.Point(15, 125);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(780, 85);
            this.grpCustomerInfo.TabIndex = 2;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Details";

            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(15, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(95, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";

            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(15, 42);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(87, 13);
            this.lblCustomerEmail.TabIndex = 1;
            this.lblCustomerEmail.Text = "customer@email.com";

            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(15, 62);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(67, 13);
            this.lblCustomerPhone.TabIndex = 2;
            this.lblCustomerPhone.Text = "9876543210";

            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(400, 22);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.Text = "Customer Address";

            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Controls.Add(this.lblPricePerNight);
            this.grpRoomInfo.Controls.Add(this.lblNights);
            this.grpRoomInfo.Controls.Add(this.lblCheckOut);
            this.grpRoomInfo.Controls.Add(this.lblCheckIn);
            this.grpRoomInfo.Controls.Add(this.lblRoomType);
            this.grpRoomInfo.Controls.Add(this.lblRoomNumber);
            this.grpRoomInfo.Location = new System.Drawing.Point(15, 220);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(780, 85);
            this.grpRoomInfo.TabIndex = 3;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Room Details";

            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(15, 25);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(25, 13);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "101";

            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(15, 45);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(53, 13);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Standard";

            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(300, 25);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(55, 13);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "00/00/0000";

            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(300, 45);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(55, 13);
            this.lblCheckOut.TabIndex = 3;
            this.lblCheckOut.Text = "00/00/0000";

            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(600, 25);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(13, 13);
            this.lblNights.TabIndex = 4;
            this.lblNights.Text = "0";

            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Location = new System.Drawing.Point(600, 45);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(48, 13);
            this.lblPricePerNight.TabIndex = 5;
            this.lblPricePerNight.Text = "PKR 0";

            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.lblPaidAmount);
            this.grpPaymentInfo.Controls.Add(this.lblTransactionId);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentDate);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentMethod);
            this.grpPaymentInfo.Controls.Add(this.lblTotalAmount);
            this.grpPaymentInfo.Controls.Add(this.lblSubtotal);
            this.grpPaymentInfo.Location = new System.Drawing.Point(15, 315);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(780, 90);
            this.grpPaymentInfo.TabIndex = 4;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment Details";

            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(15, 25);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(38, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "PKR 0";

            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 45);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(48, 15);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "PKR 0";

            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(400, 25);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(66, 13);
            this.lblPaymentMethod.TabIndex = 2;
            this.lblPaymentMethod.Text = "Credit Card";

            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(400, 45);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(67, 13);
            this.lblPaymentDate.TabIndex = 3;
            this.lblPaymentDate.Text = "00/00/0000";

            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Location = new System.Drawing.Point(400, 65);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(75, 13);
            this.lblTransactionId.TabIndex = 4;
            this.lblTransactionId.Text = "PAY000000";

            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaidAmount.Location = new System.Drawing.Point(15, 65);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(48, 15);
            this.lblPaidAmount.TabIndex = 5;
            this.lblPaidAmount.Text = "PKR 0";

            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpBookingInfo.ResumeLayout(false);
            this.grpBookingInfo.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}