using HotelManagementSystem.Forms.Admin;
using HotelManagementSystem.Forms.Booking;
using HotelManagementSystem.Forms.Staff;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Public
{
    public partial class frmMain : Form
    {
        private Timer clockTimer;

        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadUserSpecificMenu();
            StartClock();
            LoadDashboard();
        }

        private void StartClock()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy  HH:mm:ss");
            clockTimer.Start();
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy  HH:mm:ss");
        }

        private void LoadUserSpecificMenu()
        {
            lblWelcome.Text = $"Welcome, {Session.StaffName} ({Session.StaffRole})";

            // Hide admin menu items for receptionist
            if (Session.IsReceptionist())
            {
                btnManageRooms.Visible = false;
                btnReports.Visible = false;
                btnManageStaff.Visible = false;
            }
            else if (Session.IsManager())
            {
                btnManageRooms.Visible = true;
                btnReports.Visible = true;
                btnManageStaff.Visible = false;
            }
            else if (Session.IsSuperAdmin())
            {
                btnManageRooms.Visible = true;
                btnReports.Visible = true;
                btnManageStaff.Visible = true;
            }
        }

        private void LoadDashboard()
        {
            frmStaffDashboard dashboard = new frmStaffDashboard();
            LoadFormIntoContent(dashboard);
        }

        private void LoadFormIntoContent(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer createCustomer = new frmCreateCustomer();
            createCustomer.ShowDialog();
            LoadDashboard();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomer searchCustomer = new frmSearchCustomer();
            searchCustomer.ShowDialog();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            frmCheckAvailability checkAvail = new frmCheckAvailability();
            LoadFormIntoContent(checkAvail);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn checkIn = new frmCheckIn();
            LoadFormIntoContent(checkIn);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut checkOut = new frmCheckOut();
            LoadFormIntoContent(checkOut);
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            frmManageRooms manageRooms = new frmManageRooms();
            LoadFormIntoContent(manageRooms);
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            frmViewAllBookings viewBookings = new frmViewAllBookings();
            LoadFormIntoContent(viewBookings);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            LoadFormIntoContent(reports);
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            if (Session.IsSuperAdmin())
            {
                frmManageStaff manageStaff = new frmManageStaff();
                LoadFormIntoContent(manageStaff);
            }
            else
            {
                MessageBox.Show("Access Denied! Only SuperAdmin can manage staff.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.ClearStaffSession();
                frmStaffLogin login = new frmStaffLogin();
                login.Show();
                this.Close();
            }
        }
    }
}