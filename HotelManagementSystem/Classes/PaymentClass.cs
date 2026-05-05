using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class PaymentClass
    {
        public string GeneratePaymentNumber()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(PaymentNumber, 4, LEN(PaymentNumber)-3) AS INT)), 0) FROM Payment";
            int lastNumber = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
            lastNumber++;
            return "PAY" + lastNumber.ToString("D6");
        }

        public bool ProcessPayment(int bookingId, decimal amount, string paymentMethod, int receivedBy)
        {
            string paymentNumber = GeneratePaymentNumber();
            string query = @"INSERT INTO Payment (PaymentNumber, BookingID, Amount, PaymentMethod, PaymentStatus, ReceivedBy) 
                            VALUES (@PaymentNumber, @BookingID, @Amount, @PaymentMethod, 'Completed', @ReceivedBy)";

            SqlParameter[] parameters = {
                new SqlParameter("@PaymentNumber", paymentNumber),
                new SqlParameter("@BookingID", bookingId),
                new SqlParameter("@Amount", amount),
                new SqlParameter("@PaymentMethod", paymentMethod),
                new SqlParameter("@ReceivedBy", receivedBy)
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                // Update booking payment status
                BookingClass booking = new BookingClass();
                booking.UpdatePaymentStatus(bookingId, "Completed");
                return true;
            }
            return false;
        }

        public DataTable GetPaymentByBookingId(int bookingId)
        {
            string query = "SELECT * FROM Payment WHERE BookingID = @BookingID";
            SqlParameter[] parameters = { new SqlParameter("@BookingID", bookingId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllPayments()
        {
            string query = @"SELECT p.*, b.BookingNumber, c.Name as CustomerName 
                            FROM Payment p 
                            INNER JOIN Booking b ON p.BookingID = b.BookingID
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                            ORDER BY p.PaymentDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetPaymentsByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT p.*, b.BookingNumber, c.Name as CustomerName 
                            FROM Payment p 
                            INNER JOIN Booking b ON p.BookingID = b.BookingID
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                            WHERE p.PaymentDate >= @StartDate AND p.PaymentDate <= @EndDate
                            ORDER BY p.PaymentDate";
            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public decimal GetDailyRevenue(DateTime date)
        {
            string query = "SELECT ISNULL(SUM(Amount), 0) FROM Payment WHERE CAST(PaymentDate AS DATE) = @Date AND PaymentStatus = 'Completed'";
            SqlParameter[] parameters = { new SqlParameter("@Date", date.Date) };
            return Convert.ToDecimal(DatabaseHelper.ExecuteScalar(query, parameters));
        }

        public DataTable GetMonthlyRevenue(int year, int month)
        {
            string query = @"SELECT DAY(PaymentDate) as Day, COUNT(*) as TransactionCount, ISNULL(SUM(Amount), 0) as Revenue
                            FROM Payment 
                            WHERE YEAR(PaymentDate) = @Year AND MONTH(PaymentDate) = @Month
                            AND PaymentStatus = 'Completed'
                            GROUP BY DAY(PaymentDate)
                            ORDER BY Day";
            SqlParameter[] parameters = {
                new SqlParameter("@Year", year),
                new SqlParameter("@Month", month)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public decimal GetTodayRevenue()
        {
            return GetDailyRevenue(DateTime.Today);
        }

        public decimal GetMonthlyRevenueTotal(int year, int month)
        {
            string query = "SELECT ISNULL(SUM(Amount), 0) FROM Payment WHERE YEAR(PaymentDate) = @Year AND MONTH(PaymentDate) = @Month AND PaymentStatus = 'Completed'";
            SqlParameter[] parameters = {
                new SqlParameter("@Year", year),
                new SqlParameter("@Month", month)
            };
            return Convert.ToDecimal(DatabaseHelper.ExecuteScalar(query, parameters));
        }
    }
}