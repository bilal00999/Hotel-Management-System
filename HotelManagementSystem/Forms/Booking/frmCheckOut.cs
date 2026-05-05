using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmCheckOut : Form
    {
        private BookingClass booking = new BookingClass();
        private PaymentClass payment = new PaymentClass();
        private DataTable dtOccupied;
        private decimal roomTotal = 0;
        private decimal additionalCharges = 0;

        public frmCheckOut()
        {
            InitializeComponent();
            LoadOccupiedRooms();

            // Attach event handlers
            this.chkMiniBar.CheckedChanged += new EventHandler(CalculateTotal);
            this.chkRoomService.CheckedChanged += new EventHandler(CalculateTotal);
            this.chkExtraBed.CheckedChanged += new EventHandler(CalculateTotal);
            this.txtOtherCharges.TextChanged += new EventHandler(CalculateTotal);
        }

        private void LoadOccupiedRooms()
        {
            try
            {
                dtOccupied = booking.GetCurrentOccupancy();
                dgvOccupied.DataSource = dtOccupied;
                FormatGridView();

                if (dtOccupied != null && dtOccupied.Rows.Count > 0)
                {
                    lblResultCount.Text = $"Found {dtOccupied.Rows.Count} occupied room(s)";
                    lblResultCount.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultCount.Text = "No occupied rooms found";
                    lblResultCount.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading occupied rooms: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridView()
        {
            if (dgvOccupied.Columns.Contains("RoomID"))
                dgvOccupied.Columns["RoomID"].Visible = false;
            if (dgvOccupied.Columns.Contains("BookingID"))
                dgvOccupied.Columns["BookingID"].Visible = false;

            dgvOccupied.Columns["RoomNumber"].HeaderText = "Room No";
            dgvOccupied.Columns["RoomType"].HeaderText = "Room Type";
            dgvOccupied.Columns["CustomerName"].HeaderText = "Customer Name";
            dgvOccupied.Columns["Phone"].HeaderText = "Phone";
            dgvOccupied.Columns["CheckInDate"].HeaderText = "Check In";
            dgvOccupied.Columns["CheckOutDate"].HeaderText = "Check Out";
            dgvOccupied.Columns["BookingNumber"].HeaderText = "Booking No";

            dgvOccupied.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvOccupied.DataSource = dtOccupied;
                lblResultCount.Text = $"Found {dtOccupied.Rows.Count} occupied room(s)";
                return;
            }

            DataTable filtered = dtOccupied.Clone();

            foreach (DataRow row in dtOccupied.Rows)
            {
                string customerName = row["CustomerName"].ToString().ToLower();
                string roomNumber = row["RoomNumber"].ToString();
                string bookingNumber = row["BookingNumber"].ToString().ToLower();
                string searchLower = searchTerm.ToLower();

                if (customerName.Contains(searchLower) ||
                    roomNumber.Contains(searchTerm) ||
                    bookingNumber.Contains(searchLower))
                {
                    filtered.ImportRow(row);
                }
            }

            dgvOccupied.DataSource = filtered;
            lblResultCount.Text = $"Found {filtered.Rows.Count} occupied room(s)";
        }

        private void dgvOccupied_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOccupied.SelectedRows.Count > 0)
            {
                DataRowView row = (DataRowView)dgvOccupied.SelectedRows[0].DataBoundItem;

                txtCustomerName.Text = row["CustomerName"].ToString();
                txtRoomNumber.Text = row["RoomNumber"].ToString();
                txtRoomType.Text = row["RoomType"].ToString();
                txtCheckIn.Text = Convert.ToDateTime(row["CheckInDate"]).ToShortDateString();
                txtCheckOut.Text = Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString();
                txtPhone.Text = row["Phone"].ToString();

                int bookingId = Convert.ToInt32(row["BookingID"]);
                Session.CurrentBookingID = bookingId;

                LoadBookingDetails(bookingId);
            }
        }

        private void LoadBookingDetails(int bookingId)
        {
            DataTable dt = booking.GetBookingById(bookingId);
            if (dt.Rows.Count > 0)
            {
                roomTotal = Convert.ToDecimal(dt.Rows[0]["TotalPrice"]);
                lblRoomTotal.Text = "PKR " + roomTotal.ToString("N2");

                // Reset additional charges
                additionalCharges = 0;
                chkMiniBar.Checked = false;
                chkRoomService.Checked = false;
                chkExtraBed.Checked = false;
                txtOtherCharges.Text = "0";
                txtRemarks.Text = "";

                CalculateTotal(this, EventArgs.Empty);
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            additionalCharges = 0;

            if (chkMiniBar.Checked)
                additionalCharges += 500;
            if (chkRoomService.Checked)
                additionalCharges += 1000;
            if (chkExtraBed.Checked)
                additionalCharges += 1500;

            if (!string.IsNullOrWhiteSpace(txtOtherCharges.Text))
            {
                if (decimal.TryParse(txtOtherCharges.Text, out decimal other))
                    additionalCharges += other;
            }

            lblAdditionalCharges.Text = "PKR " + additionalCharges.ToString("N2");
            decimal finalTotal = roomTotal + additionalCharges;
            lblFinalTotal.Text = "PKR " + finalTotal.ToString("N2");
        }

        private void btnProcessCheckOut_Click(object sender, EventArgs e)
        {
            if (!Session.CurrentBookingID.HasValue)
            {
                MessageBox.Show("Please select a booking!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate final total
            decimal finalTotal = roomTotal + additionalCharges;

            // Check if additional charges need to be paid
            if (additionalCharges > 0)
            {
                // Store additional charges in session for payment form
                Session.AdditionalCharges = additionalCharges;

                DialogResult result = MessageBox.Show($"Additional Charges: PKR {additionalCharges:N2}\n\nProcess payment for additional charges?",
                    "Additional Charges Due", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Open payment form with additional charges only
                    frmPayment paymentForm = new frmPayment(true);  // true = from check-out
                    paymentForm.ShowDialog();
                }
            }

            // Complete check-out
            DialogResult confirmResult = MessageBox.Show($"Confirm check-out for {txtCustomerName.Text}?\n\n" +
                $"Room: {txtRoomNumber.Text}\n" +
                $"Room Total: PKR {roomTotal:N2}\n" +
                $"Additional Charges: PKR {additionalCharges:N2}\n" +
                $"Final Total: PKR {finalTotal:N2}",
                "Confirm Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Execute check-out stored procedure
                    SqlParameter[] parameters = {
                new SqlParameter("@BookingID", Session.CurrentBookingID.Value),
                new SqlParameter("@StaffID", Session.StaffID.Value),
                new SqlParameter("@AdditionalCharges", additionalCharges),
                new SqlParameter("@Remarks", txtRemarks.Text)
            };

                    DatabaseHelper.ExecuteNonQuery("EXEC sp_CheckOut @BookingID, @StaffID, @AdditionalCharges, @Remarks", parameters);

                    MessageBox.Show($"Check-out completed for {txtCustomerName.Text}!\n\nFinal bill has been generated.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOccupiedRooms();
                    ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearSelection()
        {
            txtCustomerName.Clear();
            txtRoomNumber.Clear();
            txtRoomType.Clear();
            txtCheckIn.Clear();
            txtCheckOut.Clear();
            txtPhone.Clear();
            chkMiniBar.Checked = false;
            chkRoomService.Checked = false;
            chkExtraBed.Checked = false;
            txtOtherCharges.Text = "0";
            txtRemarks.Clear();
            roomTotal = 0;
            additionalCharges = 0;
            lblRoomTotal.Text = "PKR 0";
            lblAdditionalCharges.Text = "PKR 0";
            lblFinalTotal.Text = "PKR 0";
            Session.CurrentBookingID = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOccupiedRooms();
            ClearSelection();
            txtSearch.Clear();
        }
    }
}