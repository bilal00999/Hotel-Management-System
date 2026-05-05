using HotelManagementSystem.Forms.Staff;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmBookRoom : Form
    {
        private BookingClass booking = new BookingClass();
        private CustomerClass customer = new CustomerClass();
        private RoomClass room = new RoomClass();
        private int selectedCustomerId = 0;
        private string selectedCustomerName = "";

        public frmBookRoom()
        {
            InitializeComponent();
            LoadRoomInfo();
            LoadCustomerInfo();
        }

        private void LoadRoomInfo()
        {
            if (Session.CurrentRoomID.HasValue)
            {
                DataTable dt = room.GetRoomById(Session.CurrentRoomID.Value);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblRoomNumber.Text = row["RoomNumber"].ToString();
                    lblRoomType.Text = row["RoomType"].ToString();
                    lblPricePerNight.Text = "PKR " + Convert.ToDecimal(row["Price"]).ToString("N2");
                    lblCapacity.Text = row["Capacity"].ToString() + " persons";

                    if (Session.CheckInDate.HasValue && Session.CheckOutDate.HasValue)
                    {
                        dtpCheckIn.Value = Session.CheckInDate.Value;
                        dtpCheckOut.Value = Session.CheckOutDate.Value;
                        CalculateTotal();
                    }
                }
            }
        }

        private void LoadCustomerInfo()
        {
            if (Session.CurrentCustomerID.HasValue)
            {
                selectedCustomerId = Session.CurrentCustomerID.Value;
                selectedCustomerName = Session.CurrentCustomerName;
                lblSelectedCustomer.Text = selectedCustomerName;
                btnChangeCustomer.Visible = true;
            }
            else
            {
                lblSelectedCustomer.Text = "No customer selected";
                btnChangeCustomer.Visible = true;
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomer search = new frmSearchCustomer();
            if (search.ShowDialog() == DialogResult.OK)
            {
                selectedCustomerId = Session.CurrentCustomerID.Value;
                selectedCustomerName = Session.CurrentCustomerName;
                lblSelectedCustomer.Text = selectedCustomerName;
            }
        }

        private void CalculateTotal()
        {
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;

            if (checkOut <= checkIn)
            {
                dtpCheckOut.Value = checkIn.AddDays(1);
                checkOut = dtpCheckOut.Value;
            }

            int nights = (checkOut - checkIn).Days;
            decimal pricePerNight = Convert.ToDecimal(lblPricePerNight.Text.Replace("PKR ", ""));
            decimal total = pricePerNight * nights;

            lblNights.Text = nights + " night(s)";
            lblTotalPrice.Text = "PKR " + total.ToString("N2");
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
            CalculateTotal();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int nights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                decimal totalPrice = Convert.ToDecimal(lblTotalPrice.Text.Replace("PKR ", ""));

                int bookingId = booking.CreateBooking(
                    selectedCustomerId,
                    Session.CurrentRoomID.Value,
                    Session.StaffID.Value,
                    dtpCheckIn.Value,
                    dtpCheckOut.Value,
                    totalPrice,
                    (int)numGuests.Value,
                    txtSpecialRequests.Text
                );

                if (bookingId > 0)
                {
                    Session.CurrentBookingID = bookingId;

                    DialogResult result = MessageBox.Show("Booking created successfully!\n\nDo you want to process payment now?",
                        "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        frmPayment payment = new frmPayment();
                        payment.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create booking!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}