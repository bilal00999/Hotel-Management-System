using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using HotelManagementSystem;
using HotelManagementSystem.Forms.Admin;
using HotelManagementSystem.Forms.Public;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmInvoice : Form
    {
        private BookingClass booking = new BookingClass();
        private PaymentClass payment = new PaymentClass();
        private DataTable dtBooking;
        private DataTable dtPayment;

        public frmInvoice()
        {
            InitializeComponent();
            LoadInvoice();
        }

        private void LoadInvoice()
        {
            if (Session.CurrentBookingID.HasValue)
            {
                dtBooking = booking.GetBookingById(Session.CurrentBookingID.Value);
                dtPayment = payment.GetPaymentByBookingId(Session.CurrentBookingID.Value);

                if (dtBooking.Rows.Count > 0)
                {
                    DataRow row = dtBooking.Rows[0];

                    lblInvoiceNumber.Text = "INV-" + row["BookingNumber"].ToString();
                    lblInvoiceDate.Text = DateTime.Now.ToShortDateString();
                    lblBookingNumber.Text = row["BookingNumber"].ToString();
                    lblBookingDate.Text = Convert.ToDateTime(row["BookingDate"]).ToShortDateString();

                    lblCustomerName.Text = row["CustomerName"].ToString();
                    lblCustomerEmail.Text = row["Email"].ToString();
                    lblCustomerPhone.Text = row["Phone"].ToString();
                    lblCustomerAddress.Text = row["Address"].ToString();

                    lblRoomNumber.Text = row["RoomNumber"].ToString();
                    lblRoomType.Text = row["RoomType"].ToString();
                    lblCheckIn.Text = Convert.ToDateTime(row["CheckInDate"]).ToShortDateString();
                    lblCheckOut.Text = Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString();

                    int nights = (Convert.ToDateTime(row["CheckOutDate"]) - Convert.ToDateTime(row["CheckInDate"])).Days;
                    decimal pricePerNight = Convert.ToDecimal(row["RoomPrice"]);
                    decimal totalAmount = Convert.ToDecimal(row["TotalPrice"]);

                    lblNights.Text = nights.ToString();
                    lblPricePerNight.Text = "PKR " + pricePerNight.ToString("N2");
                    lblSubtotal.Text = "PKR " + (pricePerNight * nights).ToString("N2");
                    lblTotalAmount.Text = "PKR " + totalAmount.ToString("N2");

                    if (dtPayment.Rows.Count > 0)
                    {
                        DataRow payRow = dtPayment.Rows[0];
                        lblPaymentMethod.Text = payRow["PaymentMethod"].ToString();
                        lblPaymentDate.Text = Convert.ToDateTime(payRow["PaymentDate"]).ToShortDateString();
                        lblTransactionId.Text = payRow["PaymentNumber"].ToString();
                        lblPaidAmount.Text = "PKR " + Convert.ToDecimal(payRow["Amount"]).ToString("N2");
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10, FontStyle.Regular);
            Font smallFont = new Font("Arial", 8, FontStyle.Regular);

            float y = 50;
            int x = 50;
            int pageWidth = e.PageBounds.Width;

            // Header
            e.Graphics.DrawString("HOTEL MANAGEMENT SYSTEM", titleFont, Brushes.Black, (pageWidth / 2) - 150, y);
            y += 35;
            e.Graphics.DrawString("INVOICE", headerFont, Brushes.Black, (pageWidth / 2) - 40, y);
            y += 30;

            // Draw line
            e.Graphics.DrawLine(new Pen(Color.Black, 1), x, y, pageWidth - x, y);
            y += 15;

            // Invoice Details
            e.Graphics.DrawString($"Invoice No: {lblInvoiceNumber.Text}", normalFont, Brushes.Black, x, y);
            e.Graphics.DrawString($"Date: {lblInvoiceDate.Text}", normalFont, Brushes.Black, pageWidth - 200, y);
            y += 20;

            e.Graphics.DrawString($"Booking No: {lblBookingNumber.Text}", normalFont, Brushes.Black, x, y);
            e.Graphics.DrawString($"Booking Date: {lblBookingDate.Text}", normalFont, Brushes.Black, pageWidth - 200, y);
            y += 30;

            // Customer Details
            e.Graphics.DrawString("Customer Details:", headerFont, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString($"Name: {lblCustomerName.Text}", normalFont, Brushes.Black, x + 15, y);
            y += 18;
            e.Graphics.DrawString($"Email: {lblCustomerEmail.Text}", normalFont, Brushes.Black, x + 15, y);
            y += 18;
            e.Graphics.DrawString($"Phone: {lblCustomerPhone.Text}", normalFont, Brushes.Black, x + 15, y);
            y += 18;
            e.Graphics.DrawString($"Address: {lblCustomerAddress.Text}", normalFont, Brushes.Black, x + 15, y);
            y += 25;

            // Room Details
            e.Graphics.DrawString("Room Details:", headerFont, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString($"Room No: {lblRoomNumber.Text}", normalFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString($"Room Type: {lblRoomType.Text}", normalFont, Brushes.Black, x + 200, y);
            y += 18;
            e.Graphics.DrawString($"Check In: {lblCheckIn.Text}", normalFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString($"Check Out: {lblCheckOut.Text}", normalFont, Brushes.Black, x + 200, y);
            y += 18;
            e.Graphics.DrawString($"Nights: {lblNights.Text}", normalFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString($"Price/Night: {lblPricePerNight.Text}", normalFont, Brushes.Black, x + 200, y);
            y += 25;

            // Payment Summary
            e.Graphics.DrawString("Payment Summary:", headerFont, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString($"Subtotal:", normalFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString(lblSubtotal.Text, normalFont, Brushes.Black, pageWidth - 150, y);
            y += 18;
            e.Graphics.DrawString($"Total Amount:", headerFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString(lblTotalAmount.Text, headerFont, Brushes.Black, pageWidth - 150, y);
            y += 22;

            e.Graphics.DrawString($"Payment Method: {lblPaymentMethod.Text}", normalFont, Brushes.Black, x + 15, y);
            e.Graphics.DrawString($"Paid Amount: {lblPaidAmount.Text}", normalFont, Brushes.Black, pageWidth - 150, y);
            y += 18;
            e.Graphics.DrawString($"Transaction ID: {lblTransactionId.Text}", normalFont, Brushes.Black, x + 15, y);
            y += 30;

            // Footer
            e.Graphics.DrawLine(new Pen(Color.Black, 1), x, y, pageWidth - x, y);
            y += 15;
            e.Graphics.DrawString("Thank you for choosing us!", headerFont, Brushes.Black, (pageWidth / 2) - 100, y);
            y += 20;
            e.Graphics.DrawString("This is a computer generated invoice.", smallFont, Brushes.Black, (pageWidth / 2) - 120, y);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files|*.txt";
            saveDialog.Title = "Save Invoice";
            saveDialog.FileName = $"Invoice_{lblInvoiceNumber.Text}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveDialog.FileName);
                writer.WriteLine("=".PadRight(60, '='));
                writer.WriteLine("HOTEL MANAGEMENT SYSTEM - INVOICE");
                writer.WriteLine("=".PadRight(60, '='));
                writer.WriteLine($"Invoice No: {lblInvoiceNumber.Text}");
                writer.WriteLine($"Date: {lblInvoiceDate.Text}");
                writer.WriteLine($"Booking No: {lblBookingNumber.Text}");
                writer.WriteLine($"Booking Date: {lblBookingDate.Text}");
                writer.WriteLine();
                writer.WriteLine("Customer Details:");
                writer.WriteLine($"  Name: {lblCustomerName.Text}");
                writer.WriteLine($"  Email: {lblCustomerEmail.Text}");
                writer.WriteLine($"  Phone: {lblCustomerPhone.Text}");
                writer.WriteLine($"  Address: {lblCustomerAddress.Text}");
                writer.WriteLine();
                writer.WriteLine("Room Details:");
                writer.WriteLine($"  Room No: {lblRoomNumber.Text}");
                writer.WriteLine($"  Room Type: {lblRoomType.Text}");
                writer.WriteLine($"  Check In: {lblCheckIn.Text}");
                writer.WriteLine($"  Check Out: {lblCheckOut.Text}");
                writer.WriteLine($"  Nights: {lblNights.Text}");
                writer.WriteLine($"  Price/Night: {lblPricePerNight.Text}");
                writer.WriteLine();
                writer.WriteLine("Payment Summary:");
                writer.WriteLine($"  Subtotal: {lblSubtotal.Text}");
                writer.WriteLine($"  Total Amount: {lblTotalAmount.Text}");
                writer.WriteLine($"  Payment Method: {lblPaymentMethod.Text}");
                writer.WriteLine($"  Paid Amount: {lblPaidAmount.Text}");
                writer.WriteLine($"  Transaction ID: {lblTransactionId.Text}");
                writer.WriteLine();
                writer.WriteLine("Thank you for choosing us!");
                writer.WriteLine("This is a computer generated invoice.");
                writer.Close();

                MessageBox.Show("Invoice saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Since this is a staff-only system, just close the form
            this.Close();
        }
    }
}