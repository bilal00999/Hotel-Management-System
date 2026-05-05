using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HotelManagementSystem.Forms.Public;  // Add this for frmMain if needed

namespace HotelManagementSystem.Forms.Admin
{
    public partial class frmReports : Form
    {
        private BookingClass booking = new BookingClass();
        private PaymentClass payment = new PaymentClass();
        private RoomClass room = new RoomClass();

        public frmReports()
        {
            InitializeComponent();
            LoadReportTypes();
            SetDefaultDates();
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Booking Report");
            cmbReportType.Items.Add("Payment Report");
            cmbReportType.Items.Add("Revenue Report");
            cmbReportType.Items.Add("Room Occupancy Report");
            cmbReportType.SelectedIndex = 0;
        }

        private void SetDefaultDates()
        {
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString();

            if (reportType == "Revenue Report")
            {
                dtpStartDate.Format = DateTimePickerFormat.Custom;
                dtpStartDate.CustomFormat = "MMMM yyyy";
                dtpEndDate.Visible = false;
                lblTo.Visible = false;
            }
            else
            {
                dtpStartDate.Format = DateTimePickerFormat.Short;
                dtpEndDate.Visible = true;
                lblTo.Visible = true;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString();

            switch (reportType)
            {
                case "Booking Report":
                    GenerateBookingReport();
                    break;
                case "Payment Report":
                    GeneratePaymentReport();
                    break;
                case "Revenue Report":
                    GenerateRevenueReport();
                    break;
                case "Room Occupancy Report":
                    GenerateOccupancyReport();
                    break;
            }
        }

        private void GenerateBookingReport()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            DataTable dt = booking.GetBookingsByDateRange(startDate, endDate);

            if (dt.Rows.Count > 0)
            {
                dgvReport.DataSource = dt;
                FormatBookingGrid();
                UpdateSummary(dt, startDate, endDate);
                tabControl.SelectedTab = tabReport;
            }
            else
            {
                MessageBox.Show("No bookings found for selected date range!", "No Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormatBookingGrid()
        {
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvReport.Columns.Contains("BookingID"))
                dgvReport.Columns["BookingID"].Visible = false;
            if (dgvReport.Columns.Contains("CustomerID"))
                dgvReport.Columns["CustomerID"].Visible = false;
            if (dgvReport.Columns.Contains("RoomID"))
                dgvReport.Columns["RoomID"].Visible = false;
            if (dgvReport.Columns.Contains("StaffID"))
                dgvReport.Columns["StaffID"].Visible = false;

            dgvReport.Columns["BookingNumber"].HeaderText = "Booking No";
            dgvReport.Columns["CustomerName"].HeaderText = "Customer";
            dgvReport.Columns["Email"].HeaderText = "Email";
            dgvReport.Columns["Phone"].HeaderText = "Phone";
            dgvReport.Columns["RoomNumber"].HeaderText = "Room No";
            dgvReport.Columns["RoomType"].HeaderText = "Room Type";
            dgvReport.Columns["CheckInDate"].HeaderText = "Check In";
            dgvReport.Columns["CheckOutDate"].HeaderText = "Check Out";
            dgvReport.Columns["Nights"].HeaderText = "Nights";
            dgvReport.Columns["TotalPrice"].HeaderText = "Total Price (PKR)";
            dgvReport.Columns["BookingStatus"].HeaderText = "Status";
        }

        private void GeneratePaymentReport()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            DataTable dt = payment.GetPaymentsByDateRange(startDate, endDate);

            if (dt.Rows.Count > 0)
            {
                dgvReport.DataSource = dt;
                FormatPaymentGrid();
                UpdatePaymentSummary(dt, startDate, endDate);
                tabControl.SelectedTab = tabReport;
            }
            else
            {
                MessageBox.Show("No payments found for selected date range!", "No Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormatPaymentGrid()
        {
            if (dgvReport.Columns.Contains("PaymentID"))
                dgvReport.Columns["PaymentID"].Visible = false;
            if (dgvReport.Columns.Contains("BookingID"))
                dgvReport.Columns["BookingID"].Visible = false;
            if (dgvReport.Columns.Contains("ReceivedBy"))
                dgvReport.Columns["ReceivedBy"].Visible = false;

            dgvReport.Columns["PaymentNumber"].HeaderText = "Payment No";
            dgvReport.Columns["BookingNumber"].HeaderText = "Booking No";
            dgvReport.Columns["CustomerName"].HeaderText = "Customer";
            dgvReport.Columns["Amount"].HeaderText = "Amount (PKR)";
            dgvReport.Columns["PaymentDate"].HeaderText = "Payment Date";
            dgvReport.Columns["PaymentMethod"].HeaderText = "Method";
            dgvReport.Columns["PaymentStatus"].HeaderText = "Status";
        }

        private void GenerateRevenueReport()
        {
            int year = dtpStartDate.Value.Year;
            int month = dtpStartDate.Value.Month;

            DataTable dt = payment.GetMonthlyRevenue(year, month);

            if (dt.Rows.Count > 0)
            {
                DisplayRevenueChart(dt, year, month);
                tabControl.SelectedTab = tabChart;
            }
            else
            {
                MessageBox.Show($"No revenue data for {dtpStartDate.Value.ToString("MMMM yyyy")}!", "No Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayRevenueChart(DataTable dtRevenue, int year, int month)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            chartRevenue.Titles.Add($"Daily Revenue - {dtpStartDate.Value.ToString("MMMM yyyy")}");
            chartRevenue.ChartAreas[0].AxisX.Title = "Day of Month";
            chartRevenue.ChartAreas[0].AxisY.Title = "Revenue (PKR)";

            var series = new Series
            {
                Name = "Revenue",
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(52, 152, 219),
                IsValueShownAsLabel = true
            };

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                decimal revenue = 0;
                DataRow[] rows = dtRevenue.Select($"Day = {day}");
                if (rows.Length > 0)
                    revenue = Convert.ToDecimal(rows[0]["Revenue"]);

                series.Points.AddXY(day, revenue);
            }

            chartRevenue.Series.Add(series);

            decimal totalRevenue = payment.GetMonthlyRevenueTotal(year, month);
            lblChartSummary.Text = $"Total Revenue for {dtpStartDate.Value.ToString("MMMM yyyy")}: PKR {totalRevenue.ToString("N2")}";
        }

        private void GenerateOccupancyReport()
        {
            DataTable dtRooms = room.GetAllRooms();

            int total = dtRooms.Rows.Count;
            int available = 0, booked = 0, occupied = 0, maintenance = 0;

            foreach (DataRow row in dtRooms.Rows)
            {
                string status = row["Status"].ToString();
                if (status == "Available") available++;
                else if (status == "Booked") booked++;
                else if (status == "Occupied") occupied++;
                else if (status == "Maintenance") maintenance++;
            }

            DisplayOccupancyChart(available, booked, occupied, maintenance, total);
            tabControl.SelectedTab = tabChart;
        }

        private void DisplayOccupancyChart(int available, int booked, int occupied, int maintenance, int total)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            chartRevenue.Titles.Add("Room Occupancy Status");
            chartRevenue.ChartAreas[0].AxisX.Title = "Room Status";
            chartRevenue.ChartAreas[0].AxisY.Title = "Number of Rooms";

            var series = new Series
            {
                Name = "Rooms",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            series.Points.AddXY("Available", available);
            series.Points.AddXY("Booked", booked);
            series.Points.AddXY("Occupied", occupied);
            series.Points.AddXY("Maintenance", maintenance);

            series.Points[0].Color = Color.FromArgb(46, 204, 113);
            series.Points[1].Color = Color.FromArgb(241, 196, 15);
            series.Points[2].Color = Color.FromArgb(52, 152, 219);
            series.Points[3].Color = Color.FromArgb(149, 165, 166);

            chartRevenue.Series.Add(series);

            double occupancyRate = total > 0 ? (double)(occupied + booked) / total * 100 : 0;
            lblChartSummary.Text = $"Total Rooms: {total} | Available: {available} | Booked: {booked} | Occupied: {occupied} | Occupancy Rate: {occupancyRate.ToString("F1")}%";
        }

        private void UpdateSummary(DataTable dt, DateTime startDate, DateTime endDate)
        {
            int total = dt.Rows.Count;
            int confirmed = 0, cancelled = 0;
            decimal revenue = 0;

            foreach (DataRow row in dt.Rows)
            {
                string status = row["BookingStatus"].ToString();
                if (status == "Confirmed") confirmed++;
                else if (status == "Cancelled") cancelled++;
                if (status == "Completed")
                    revenue += Convert.ToDecimal(row["TotalPrice"]);
            }

            lblSummaryTotal.Text = $"Total Bookings: {total}";
            lblSummaryConfirmed.Text = $"Confirmed: {confirmed}";
            lblSummaryCancelled.Text = $"Cancelled: {cancelled}";
            lblSummaryRevenue.Text = $"Revenue: PKR {revenue.ToString("N2")}";
            lblSummaryPeriod.Text = $"Period: {startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";
        }

        private void UpdatePaymentSummary(DataTable dt, DateTime startDate, DateTime endDate)
        {
            int total = dt.Rows.Count;
            decimal totalAmount = 0;

            foreach (DataRow row in dt.Rows)
                totalAmount += Convert.ToDecimal(row["Amount"]);

            decimal average = total > 0 ? totalAmount / total : 0;

            lblSummaryTotal.Text = $"Total Payments: {total}";
            lblSummaryConfirmed.Text = $"Total Amount: PKR {totalAmount.ToString("N2")}";
            lblSummaryCancelled.Text = $"Average: PKR {average.ToString("N2")}";
            lblSummaryRevenue.Text = $"";
            lblSummaryPeriod.Text = $"Period: {startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export! Generate a report first.", "No Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files|*.xls|CSV Files|*.csv";
            saveDialog.Title = "Export Report";
            saveDialog.FileName = $"{cmbReportType.SelectedItem}_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new System.IO.StreamWriter(saveDialog.FileName))
                {
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        writer.Write(dgvReport.Columns[i].HeaderText);
                        if (i < dgvReport.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            string value = row.Cells[i].Value?.ToString() ?? "";
                            if (value.Contains(","))
                                value = "\"" + value + "\"";
                            writer.Write(value);
                            if (i < dgvReport.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Report exported successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}