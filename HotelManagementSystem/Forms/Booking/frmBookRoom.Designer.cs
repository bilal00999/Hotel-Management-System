namespace HotelManagementSystem.Forms.Booking
{
    partial class frmBookRoom
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnChangeCustomer;
        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomNumberValue;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomTypeValue;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.Label lblPricePerNightValue;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblNightsValue;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.NumericUpDown numGuests;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.TextBox txtSpecialRequests;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnChangeCustomer = new System.Windows.Forms.Button();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblPricePerNightValue = new System.Windows.Forms.Label();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.lblRoomTypeValue = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumberValue = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.lblNightsValue = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.numGuests = new System.Windows.Forms.NumericUpDown();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpRoom.SuspendLayout();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnChangeCustomer);
            this.grpCustomer.Controls.Add(this.btnSelectCustomer);
            this.grpCustomer.Controls.Add(this.lblSelectedCustomer);
            this.grpCustomer.Controls.Add(this.lblCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(15, 15);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(550, 60);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // btnChangeCustomer
            // 
            this.btnChangeCustomer.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnChangeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangeCustomer.ForeColor = System.Drawing.Color.White;
            this.btnChangeCustomer.Location = new System.Drawing.Point(430, 22);
            this.btnChangeCustomer.Name = "btnChangeCustomer";
            this.btnChangeCustomer.Size = new System.Drawing.Size(100, 25);
            this.btnChangeCustomer.TabIndex = 3;
            this.btnChangeCustomer.Text = "Change";
            this.btnChangeCustomer.UseVisualStyleBackColor = false;
            this.btnChangeCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSelectCustomer.Location = new System.Drawing.Point(320, 22);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(100, 25);
            this.btnSelectCustomer.TabIndex = 2;
            this.btnSelectCustomer.Text = "Select";
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCustomer.Location = new System.Drawing.Point(120, 25);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(60, 19);
            this.lblSelectedCustomer.TabIndex = 1;
            this.lblSelectedCustomer.Text = "None";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.Location = new System.Drawing.Point(20, 25);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(77, 19);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer:";
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.lblCapacityValue);
            this.grpRoom.Controls.Add(this.lblCapacity);
            this.grpRoom.Controls.Add(this.lblPricePerNightValue);
            this.grpRoom.Controls.Add(this.lblPricePerNight);
            this.grpRoom.Controls.Add(this.lblRoomTypeValue);
            this.grpRoom.Controls.Add(this.lblRoomType);
            this.grpRoom.Controls.Add(this.lblRoomNumberValue);
            this.grpRoom.Controls.Add(this.lblRoomNumber);
            this.grpRoom.Location = new System.Drawing.Point(15, 85);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(550, 100);
            this.grpRoom.TabIndex = 1;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Room Details";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCapacityValue.Location = new System.Drawing.Point(380, 65);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(39, 19);
            this.lblCapacityValue.TabIndex = 7;
            this.lblCapacityValue.Text = "2 persons";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.Location = new System.Drawing.Point(300, 65);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(66, 19);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblPricePerNightValue
            // 
            this.lblPricePerNightValue.AutoSize = true;
            this.lblPricePerNightValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPricePerNightValue.Location = new System.Drawing.Point(380, 35);
            this.lblPricePerNightValue.Name = "lblPricePerNightValue";
            this.lblPricePerNightValue.Size = new System.Drawing.Size(48, 19);
            this.lblPricePerNightValue.TabIndex = 5;
            this.lblPricePerNightValue.Text = "PKR 0";
            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPricePerNight.Location = new System.Drawing.Point(260, 35);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(106, 19);
            this.lblPricePerNight.TabIndex = 4;
            this.lblPricePerNight.Text = "Price Per Night:";
            // 
            // lblRoomTypeValue
            // 
            this.lblRoomTypeValue.AutoSize = true;
            this.lblRoomTypeValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomTypeValue.Location = new System.Drawing.Point(120, 65);
            this.lblRoomTypeValue.Name = "lblRoomTypeValue";
            this.lblRoomTypeValue.Size = new System.Drawing.Size(66, 19);
            this.lblRoomTypeValue.TabIndex = 3;
            this.lblRoomTypeValue.Text = "Standard";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.Location = new System.Drawing.Point(20, 65);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(84, 19);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lblRoomNumberValue
            // 
            this.lblRoomNumberValue.AutoSize = true;
            this.lblRoomNumberValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomNumberValue.Location = new System.Drawing.Point(120, 35);
            this.lblRoomNumberValue.Name = "lblRoomNumberValue";
            this.lblRoomNumberValue.Size = new System.Drawing.Size(39, 19);
            this.lblRoomNumberValue.TabIndex = 1;
            this.lblRoomNumberValue.Text = "101";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 35);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(102, 19);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.lblNightsValue);
            this.grpDates.Controls.Add(this.lblNights);
            this.grpDates.Controls.Add(this.dtpCheckOut);
            this.grpDates.Controls.Add(this.lblCheckOut);
            this.grpDates.Controls.Add(this.dtpCheckIn);
            this.grpDates.Controls.Add(this.lblCheckIn);
            this.grpDates.Location = new System.Drawing.Point(15, 195);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(550, 80);
            this.grpDates.TabIndex = 2;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "Booking Dates";
            // 
            // lblNightsValue
            // 
            this.lblNightsValue.AutoSize = true;
            this.lblNightsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNightsValue.Location = new System.Drawing.Point(430, 45);
            this.lblNightsValue.Name = "lblNightsValue";
            this.lblNightsValue.Size = new System.Drawing.Size(30, 19);
            this.lblNightsValue.TabIndex = 5;
            this.lblNightsValue.Text = "0";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(380, 48);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(44, 13);
            this.lblNights.TabIndex = 4;
            this.lblNights.Text = "Nights:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(220, 45);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckOut.TabIndex = 3;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(150, 48);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(64, 13);
            this.lblCheckOut.TabIndex = 2;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(220, 20);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckIn.TabIndex = 1;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(150, 23);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(56, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check In:";
            // 
            // numGuests
            // 
            this.numGuests.Location = new System.Drawing.Point(140, 295);
            this.numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numGuests.Name = "numGuests";
            this.numGuests.Size = new System.Drawing.Size(100, 20);
            this.numGuests.TabIndex = 4;
            this.numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGuests.Location = new System.Drawing.Point(20, 295);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(105, 19);
            this.lblGuests.TabIndex = 3;
            this.lblGuests.Text = "Number of Guests:";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Location = new System.Drawing.Point(140, 330);
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.Size = new System.Drawing.Size(420, 60);
            this.txtSpecialRequests.TabIndex = 6;
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoSize = true;
            this.lblSpecialRequests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpecialRequests.Location = new System.Drawing.Point(20, 330);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(118, 19);
            this.lblSpecialRequests.TabIndex = 5;
            this.lblSpecialRequests.Text = "Special Requests:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 410);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(114, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Amount:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblTotalPrice.Location = new System.Drawing.Point(140, 405);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(67, 30);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "PKR 0";
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(300, 460);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(130, 40);
            this.btnConfirmBooking.TabIndex = 9;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(450, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSpecialRequests);
            this.Controls.Add(this.lblSpecialRequests);
            this.Controls.Add(this.numGuests);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.grpCustomer);
            this.Name = "frmBookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Room";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}