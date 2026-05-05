using HotelManagementSystem.Forms.Booking;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmViewAllBookings : Form
    {
        private BookingClass booking = new BookingClass();
        private DataTable dtBookings;

        public frmViewAllBookings()
        {
            InitializeComponent();
            LoadBookings();
            LoadFilters();
        }

        private void LoadBookings()
        {
            dtBookings = booking.GetAllBookings();
            dgvBookings.DataSource = dtBookings;
            FormatGridView();
            UpdateSummary();
        }

        private void FormatGridView()
        {
            if (dgvBookings.Columns.Contains("BookingID"))
                dgvBookings.Columns["BookingID"].Visible = false;
            if (dgvBookings.Columns.Contains("CustomerID"))
                dgvBookings.Columns["CustomerID"].Visible = false;
            if (dgvBookings.Columns.Contains("RoomID"))
                dgvBookings.Columns["RoomID"].Visible = false;
            if (dgvBookings.Columns.Contains("StaffID"))
                dgvBookings.Columns["StaffID"].Visible = false;

            dgvBookings.Columns["BookingNumber"].HeaderText = "Booking No";
            dgvBookings.Columns["CustomerName"].HeaderText = "Customer";
            dgvBookings.Columns["Email"].HeaderText = "Email";
            dgvBookings.Columns["Phone"].HeaderText = "Phone";
            dgvBookings.Columns["RoomNumber"].HeaderText = "Room No";
            dgvBookings.Columns["RoomType"].HeaderText = "Room Type";
            dgvBookings.Columns["CheckInDate"].HeaderText = "Check In";
            dgvBookings.Columns["CheckOutDate"].HeaderText = "Check Out";
            dgvBookings.Columns["Nights"].HeaderText = "Nights";
            dgvBookings.Columns["TotalPrice"].HeaderText = "Total Price";
            dgvBookings.Columns["BookingStatus"].HeaderText = "Status";
            dgvBookings.Columns["PaymentStatus"].HeaderText = "Payment";

            // Color coding
            foreach (DataGridViewRow row in dgvBookings.Rows)
            {
                string status = row.Cells["BookingStatus"].Value.ToString();
                if (status == "Confirmed")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                else if (status == "CheckedIn")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                else if (status == "Completed")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                else if (status == "Cancelled")
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void LoadFilters()
        {
            // Load Status Filter
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Confirmed");
            cmbStatus.Items.Add("CheckedIn");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0;

            // Load Payment Status Filter
            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.Add("All");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Completed");
            cmbPaymentStatus.SelectedIndex = 0;

            // Load Room Types Filter
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("All");

            if (dtBookings != null && dtBookings.Rows.Count > 0)
            {
                foreach (DataRow row in dtBookings.Rows)
                {
                    string type = row["RoomType"].ToString();
                    if (!string.IsNullOrEmpty(type) && !cmbRoomType.Items.Contains(type))
                        cmbRoomType.Items.Add(type);
                }
            }

            // Add default room types if no bookings exist
            if (cmbRoomType.Items.Count == 1)
            {
                cmbRoomType.Items.Add("Standard");
                cmbRoomType.Items.Add("Deluxe");
                cmbRoomType.Items.Add("Suite");
            }

            cmbRoomType.SelectedIndex = 0;
        }

        private void UpdateSummary()
        {
            if (dtBookings == null) return;

            int total = dtBookings.Rows.Count;
            int confirmed = 0, checkedIn = 0, completed = 0, cancelled = 0;
            decimal totalRevenue = 0;

            foreach (DataRow row in dtBookings.Rows)
            {
                string status = row["BookingStatus"].ToString();
                if (status == "Confirmed") confirmed++;
                else if (status == "CheckedIn") checkedIn++;
                else if (status == "Completed")
                {
                    completed++;
                    totalRevenue += Convert.ToDecimal(row["TotalPrice"]);
                }
                else if (status == "Cancelled") cancelled++;
            }

            lblTotalBookings.Text = total.ToString();
            lblConfirmed.Text = confirmed.ToString();
            lblCheckedIn.Text = checkedIn.ToString();
            lblCompleted.Text = completed.ToString();
            lblCancelled.Text = cancelled.ToString();
            lblTotalRevenue.Text = "PKR " + totalRevenue.ToString("N2");
        }

        private void ApplyFilters()
        {
            if (dtBookings == null) return;

            // SAFE: Check if SelectedItem is not null
            string status = cmbStatus.SelectedItem?.ToString() ?? "All";
            string paymentStatus = cmbPaymentStatus.SelectedItem?.ToString() ?? "All";
            string roomType = cmbRoomType.SelectedItem?.ToString() ?? "All";
            string searchTerm = txtSearch.Text.Trim().ToLower();

            DataTable filtered = dtBookings.Clone();

            foreach (DataRow row in dtBookings.Rows)
            {
                bool statusMatch = (status == "All") || row["BookingStatus"].ToString() == status;
                bool paymentMatch = (paymentStatus == "All") || row["PaymentStatus"].ToString() == paymentStatus;
                bool typeMatch = (roomType == "All") || row["RoomType"].ToString() == roomType;
                bool searchMatch = string.IsNullOrWhiteSpace(searchTerm) ||
                    row["CustomerName"].ToString().ToLower().Contains(searchTerm) ||
                    row["BookingNumber"].ToString().ToLower().Contains(searchTerm) ||
                    row["Phone"].ToString().Contains(searchTerm);

                if (statusMatch && paymentMatch && typeMatch && searchMatch)
                    filtered.ImportRow(row);
            }

            dgvBookings.DataSource = filtered;
            FormatGridView();
            lblFilterResult.Text = $"Showing {filtered.Rows.Count} of {dtBookings.Rows.Count} bookings";
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cmbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilters();

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            if (cmbPaymentStatus.Items.Count > 0) cmbPaymentStatus.SelectedIndex = 0;
            if (cmbRoomType.Items.Count > 0) cmbRoomType.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
                Session.CurrentBookingID = bookingId;
                frmInvoice invoice = new frmInvoice();
                invoice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a booking!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
                int roomId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["RoomID"].Value);
                string status = dgvBookings.SelectedRows[0].Cells["BookingStatus"].Value.ToString();

                if (status == "Completed")
                {
                    MessageBox.Show("Cannot cancel a completed booking!", "Cannot Cancel",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?\n\n" +
                    "This action cannot be undone.", "Confirm Cancellation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (booking.CancelBooking(bookingId, roomId, "Cancelled by admin"))
                    {
                        MessageBox.Show("Booking cancelled successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                        LoadFilters(); // Reload filters to update room types
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
            LoadFilters(); // Refresh filters after loading
            btnReset_Click(sender, e);
        }
    }
}