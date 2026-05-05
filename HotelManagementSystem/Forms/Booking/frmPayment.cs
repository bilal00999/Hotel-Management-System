using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms.Booking
{
    public partial class frmPayment : Form
    {
        private PaymentClass payment = new PaymentClass();
        private BookingClass booking = new BookingClass();
        private DataTable dtBooking;
        private decimal totalAmount = 0;
        private decimal alreadyPaid = 0;
        private bool isFromCheckOut = false;

        public frmPayment(bool fromCheckOut = false)
        {
            InitializeComponent();
            isFromCheckOut = fromCheckOut;
            LoadPaymentDetails();
        }

        private void LoadPaymentDetails()
        {
            if (Session.CurrentBookingID.HasValue)
            {
                dtBooking = booking.GetBookingById(Session.CurrentBookingID.Value);
                if (dtBooking.Rows.Count > 0)
                {
                    DataRow row = dtBooking.Rows[0];
                    lblBookingNumber.Text = row["BookingNumber"].ToString();
                    lblCustomerName.Text = row["CustomerName"].ToString();
                    lblRoomNumber.Text = row["RoomNumber"].ToString();
                    lblRoomType.Text = row["RoomType"].ToString();
                    lblCheckIn.Text = Convert.ToDateTime(row["CheckInDate"]).ToShortDateString();
                    lblCheckOut.Text = Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString();

                    int nights = (Convert.ToDateTime(row["CheckOutDate"]) - Convert.ToDateTime(row["CheckInDate"])).Days;
                    lblNights.Text = nights + " night(s)";

                    totalAmount = Convert.ToDecimal(row["TotalPrice"]);

                    // Get already paid amount
                    DataTable dtPayment = payment.GetPaymentByBookingId(Session.CurrentBookingID.Value);
                    if (dtPayment.Rows.Count > 0)
                    {
                        alreadyPaid = Convert.ToDecimal(dtPayment.Rows[0]["Amount"]);
                    }

                    decimal dueAmount = totalAmount - alreadyPaid;

                    // If coming from Check-Out with additional charges
                    if (isFromCheckOut && Session.AdditionalCharges.HasValue)
                    {
                        dueAmount = Session.AdditionalCharges.Value;
                        lblInfo.Text = "Additional charges due for check-out:";
                    }
                    else
                    {
                        lblInfo.Text = "Total Amount Due:";
                    }

                    lblTotalAmount.Text = "PKR " + dueAmount.ToString("N2");
                    lblDueAmount.Text = "PKR " + dueAmount.ToString("N2");
                }
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string method = cmbPaymentMethod.SelectedItem.ToString();
            pnlCardDetails.Visible = (method == "Credit Card" || method == "Debit Card");

            if (method == "Cash")
            {
                lblAmountReceived.Visible = true;
                txtAmountReceived.Visible = true;
                lblChange.Visible = true;
                lblChangeAmount.Visible = true;
            }
            else
            {
                lblAmountReceived.Visible = false;
                txtAmountReceived.Visible = false;
                lblChange.Visible = false;
                lblChangeAmount.Visible = false;
            }
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            decimal dueAmount = Convert.ToDecimal(lblDueAmount.Text.Replace("PKR ", ""));
            if (decimal.TryParse(txtAmountReceived.Text, out decimal received))
            {
                decimal change = received - dueAmount;
                if (change < 0) change = 0;
                lblChangeAmount.Text = "PKR " + change.ToString("N2");
            }
            else
            {
                lblChangeAmount.Text = "PKR 0";
            }
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (Session.CurrentBookingID.HasValue)
            {
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();
                decimal amountToPay = Convert.ToDecimal(lblDueAmount.Text.Replace("PKR ", ""));

                if (paymentMethod == "Cash")
                {
                    if (!decimal.TryParse(txtAmountReceived.Text, out decimal received) || received < amountToPay)
                    {
                        MessageBox.Show("Please enter valid amount received!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Validate card details if needed
                if (paymentMethod == "Credit Card" || paymentMethod == "Debit Card")
                {
                    if (string.IsNullOrWhiteSpace(txtCardNumber.Text) || txtCardNumber.Text.Length < 16)
                    {
                        MessageBox.Show("Please enter valid card number (16 digits)!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtCardHolder.Text))
                    {
                        MessageBox.Show("Please enter card holder name!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtExpiry.Text) || txtExpiry.Text.Length != 5)
                    {
                        MessageBox.Show("Please enter valid expiry date (MM/YY)!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtCVV.Text) || txtCVV.Text.Length < 3)
                    {
                        MessageBox.Show("Please enter valid CVV!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                try
                {
                    bool success = payment.ProcessPayment(
                        Session.CurrentBookingID.Value,
                        amountToPay,
                        paymentMethod,
                        Session.StaffID.Value
                    );

                    if (success)
                    {
                        if (isFromCheckOut)
                        {
                            // Clear additional charges session
                            Session.AdditionalCharges = null;
                            MessageBox.Show("Additional charges payment processed successfully!\n\nCheck-out completed.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment processed successfully!\n\nInvoice has been generated.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        frmInvoice invoice = new frmInvoice();
                        invoice.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Payment failed. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}