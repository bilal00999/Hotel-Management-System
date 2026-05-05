using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Staff
{
    public partial class frmStaffDashboard : Form
    {
        private RoomClass room = new RoomClass();
        private BookingClass booking = new BookingClass();
        private PaymentClass payment = new PaymentClass();

        public frmStaffDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Room Statistics
                DataTable dtRooms = room.GetAllRooms();
                int total = dtRooms.Rows.Count;
                int available = 0, booked = 0, occupied = 0;

                foreach (DataRow row in dtRooms.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Available") available++;
                    else if (status == "Booked") booked++;
                    else if (status == "Occupied") occupied++;
                }

                lblTotalRooms.Text = total.ToString();
                lblAvailableRooms.Text = available.ToString();
                lblBookedRooms.Text = booked.ToString();
                lblOccupiedRooms.Text = occupied.ToString();

                // Revenue
                lblTodayRevenue.Text = "PKR " + payment.GetTodayRevenue().ToString("N2");

                DataTable dtMonthly = payment.GetMonthlyRevenue(DateTime.Now.Year, DateTime.Now.Month);
                decimal monthlyTotal = 0;
                foreach (DataRow row in dtMonthly.Rows)
                {
                    monthlyTotal += Convert.ToDecimal(row["Revenue"]);
                }
                lblMonthlyRevenue.Text = "PKR " + monthlyTotal.ToString("N2");

                // REMOVED: Today's Arrivals and Today's Departures code
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}