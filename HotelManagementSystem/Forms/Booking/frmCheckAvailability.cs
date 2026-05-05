using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmCheckAvailability : Form
    {
        private RoomClass room = new RoomClass();
        private DataTable dtAvailableRooms;
        private int selectedRoomId = -1;
        private int selectedRoomNumber = 0;
        private decimal selectedRoomPrice = 0;

        public frmCheckAvailability()
        {
            InitializeComponent();
            SetDefaultDates();
            LoadRoomTypes();
            LoadPriceFilters();
        }

        private void SetDefaultDates()
        {
            dtpCheckIn.Value = DateTime.Today.AddDays(1);
            dtpCheckOut.Value = DateTime.Today.AddDays(2);
        }

        private void LoadRoomTypes()
        {
            cmbFilterRoomType.Items.Clear();
            cmbFilterRoomType.Items.Add("All");
            cmbFilterRoomType.Items.Add("Standard");
            cmbFilterRoomType.Items.Add("Deluxe");
            cmbFilterRoomType.Items.Add("Suite");
            cmbFilterRoomType.SelectedIndex = 0;
        }

        private void LoadPriceFilters()
        {
            cmbFilterPrice.Items.Clear();
            cmbFilterPrice.Items.Add("All");
            cmbFilterPrice.Items.Add("Under PKR 5000");
            cmbFilterPrice.Items.Add("PKR 5000 - 10000");
            cmbFilterPrice.Items.Add("Above PKR 10000");
            cmbFilterPrice.SelectedIndex = 0;
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;

            if (checkIn < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past!", "Invalid Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dtAvailableRooms = room.GetAvailableRoomsByDate(checkIn, checkOut);

                if (dtAvailableRooms.Rows.Count > 0)
                {
                    dgvRooms.DataSource = dtAvailableRooms;
                    FormatGridView();
                    ApplyFilters();
                    lblStatus.Text = $"Found {dtAvailableRooms.Rows.Count} available room(s)";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    btnBookRoom.Enabled = true;
                }
                else
                {
                    dgvRooms.DataSource = null;
                    lblStatus.Text = "No rooms available for selected dates!";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    btnBookRoom.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGridView()
        {
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRooms.Columns.Contains("RoomID"))
                dgvRooms.Columns["RoomID"].Visible = false;
            if (dgvRooms.Columns.Contains("IsActive"))
                dgvRooms.Columns["IsActive"].Visible = false;
            if (dgvRooms.Columns.Contains("CreatedDate"))
                dgvRooms.Columns["CreatedDate"].Visible = false;

            dgvRooms.Columns["RoomNumber"].HeaderText = "Room No";
            dgvRooms.Columns["RoomType"].HeaderText = "Room Type";
            dgvRooms.Columns["Price"].HeaderText = "Price/Night";
            dgvRooms.Columns["Status"].HeaderText = "Status";
            dgvRooms.Columns["Capacity"].HeaderText = "Max Guests";
            dgvRooms.Columns["Floor"].HeaderText = "Floor";
            dgvRooms.Columns["Features"].HeaderText = "Features";
        }

        private void ApplyFilters()
        {
            if (dtAvailableRooms == null) return;

            string roomType = cmbFilterRoomType.SelectedItem.ToString();
            string priceRange = cmbFilterPrice.SelectedItem.ToString();

            DataTable filtered = dtAvailableRooms.Clone();

            foreach (DataRow row in dtAvailableRooms.Rows)
            {
                bool typeMatch = (roomType == "All") || row["RoomType"].ToString() == roomType;

                bool priceMatch = true;
                decimal price = Convert.ToDecimal(row["Price"]);

                if (priceRange == "Under PKR 5000")
                    priceMatch = price < 5000;
                else if (priceRange == "PKR 5000 - 10000")
                    priceMatch = price >= 5000 && price <= 10000;
                else if (priceRange == "Above PKR 10000")
                    priceMatch = price > 10000;

                if (typeMatch && priceMatch)
                    filtered.ImportRow(row);
            }

            dgvRooms.DataSource = filtered;
        }

        private void cmbFilterRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilterPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                selectedRoomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
                selectedRoomNumber = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomNumber"].Value);
                selectedRoomPrice = Convert.ToDecimal(dgvRooms.SelectedRows[0].Cells["Price"].Value);

                int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
                decimal total = selectedRoomPrice * nights;

                lblSelectedRoom.Text = $"Selected: Room {selectedRoomNumber} - PKR {selectedRoomPrice:N0}/night, Total: PKR {total:N0} for {nights} night(s)";
                btnBookRoom.Enabled = true;
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session.CurrentRoomID = selectedRoomId;
            Session.CurrentRoomNumber = selectedRoomNumber;
            Session.SetBookingDates(dtpCheckIn.Value, dtpCheckOut.Value);

            frmBookRoom bookRoom = new frmBookRoom();
            bookRoom.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFilterRoomType.SelectedIndex = 0;
            cmbFilterPrice.SelectedIndex = 0;
            ApplyFilters();
        }
    }
}