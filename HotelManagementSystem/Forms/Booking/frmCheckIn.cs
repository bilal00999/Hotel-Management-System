using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmCheckIn : Form
    {
        private BookingClass booking = new BookingClass();
        private DataTable dtArrivals;

        public frmCheckIn()
        {
            InitializeComponent();
            LoadBookingsForCheckIn();
        }

        private void LoadBookingsForCheckIn()
        {
            try
            {
                // Get all Confirmed bookings (not yet checked in)
                string query = @"SELECT 
                                    b.BookingID,
                                    b.BookingNumber,
                                    c.Name as CustomerName,
                                    c.Phone,
                                    r.RoomNumber,
                                    r.RoomType,
                                    b.CheckInDate,
                                    b.CheckOutDate,
                                    b.NumberOfGuests,
                                    b.BookingStatus
                                FROM Booking b
                                INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                                INNER JOIN Room r ON b.RoomID = r.RoomID
                                WHERE b.BookingStatus = 'Confirmed'
                                ORDER BY b.CheckInDate";

                dtArrivals = DatabaseHelper.ExecuteQuery(query);
                dgvArrivals.DataSource = dtArrivals;
                FormatGridView();

                if (dtArrivals != null && dtArrivals.Rows.Count > 0)
                {
                    lblResultCount.Text = $"Found {dtArrivals.Rows.Count} booking(s) ready for check-in";
                    lblResultCount.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResultCount.Text = "No bookings found for check-in";
                    lblResultCount.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridView()
        {
            if (dgvArrivals.Columns.Contains("BookingID"))
                dgvArrivals.Columns["BookingID"].Visible = false;

            dgvArrivals.Columns["BookingNumber"].HeaderText = "Booking No";
            dgvArrivals.Columns["CustomerName"].HeaderText = "Customer Name";
            dgvArrivals.Columns["Phone"].HeaderText = "Phone";
            dgvArrivals.Columns["RoomNumber"].HeaderText = "Room No";
            dgvArrivals.Columns["RoomType"].HeaderText = "Room Type";
            dgvArrivals.Columns["CheckInDate"].HeaderText = "Check In";
            dgvArrivals.Columns["CheckOutDate"].HeaderText = "Check Out";
            dgvArrivals.Columns["NumberOfGuests"].HeaderText = "Guests";
            dgvArrivals.Columns["BookingStatus"].HeaderText = "Status";

            dgvArrivals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadBookingsForCheckIn();
                return;
            }

            DataTable filtered = dtArrivals.Clone();
            foreach (DataRow row in dtArrivals.Rows)
            {
                if (row["CustomerName"].ToString().ToLower().Contains(searchTerm.ToLower()) ||
                    row["BookingNumber"].ToString().ToLower().Contains(searchTerm.ToLower()) ||
                    row["Phone"].ToString().Contains(searchTerm))
                {
                    filtered.ImportRow(row);
                }
            }
            dgvArrivals.DataSource = filtered;
            lblResultCount.Text = $"Found {filtered.Rows.Count} booking(s)";
        }

        private void dgvArrivals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArrivals.SelectedRows.Count > 0)
            {
                DataRow row = ((DataRowView)dgvArrivals.SelectedRows[0].DataBoundItem).Row;
                txtCustomerName.Text = row["CustomerName"].ToString();
                txtBookingNumber.Text = row["BookingNumber"].ToString();
                txtRoomNumber.Text = row["RoomNumber"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtGuests.Text = row["NumberOfGuests"].ToString();
                txtCheckInDate.Text = Convert.ToDateTime(row["CheckInDate"]).ToShortDateString();
                txtCheckOutDate.Text = Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString();
                Session.CurrentBookingID = Convert.ToInt32(row["BookingID"]);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (!Session.CurrentBookingID.HasValue)
            {
                MessageBox.Show("Please select a booking!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if already checked in
            string checkStatusQuery = "SELECT BookingStatus FROM Booking WHERE BookingID = @BookingID";
            SqlParameter[] checkParams = { new SqlParameter("@BookingID", Session.CurrentBookingID.Value) };
            DataTable dtStatus = DatabaseHelper.ExecuteQuery(checkStatusQuery, checkParams);

            if (dtStatus.Rows.Count > 0 && dtStatus.Rows[0]["BookingStatus"].ToString() == "CheckedIn")
            {
                MessageBox.Show("This booking has already been checked in!", "Already Checked In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Confirm check-in for {txtCustomerName.Text}?\n\n" +
                $"Room: {txtRoomNumber.Text}\n" +
                $"Guests: {txtGuests.Text}\n" +
                $"Check-in Date: {txtCheckInDate.Text}",
                "Confirm Check-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Execute check-in stored procedure
                    SqlParameter[] parameters = {
                        new SqlParameter("@BookingID", Session.CurrentBookingID.Value),
                        new SqlParameter("@StaffID", Session.StaffID.Value),
                        new SqlParameter("@Remarks", txtRemarks.Text)
                    };

                    DatabaseHelper.ExecuteNonQuery("EXEC sp_CheckIn @BookingID, @StaffID, @Remarks", parameters);

                    MessageBox.Show($"Check-in completed for {txtCustomerName.Text}!\n\n" +
                        $"Room key has been assigned.\n" +
                        $"Room {txtRoomNumber.Text} is now OCCUPIED.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookingsForCheckIn();
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
            txtBookingNumber.Clear();
            txtRoomNumber.Clear();
            txtPhone.Clear();
            txtGuests.Clear();
            txtCheckInDate.Clear();
            txtCheckOutDate.Clear();
            txtRemarks.Clear();
            Session.CurrentBookingID = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookingsForCheckIn();
            ClearSelection();
            txtSearch.Clear();
        }

       
    }
}