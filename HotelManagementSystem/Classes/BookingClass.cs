using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class BookingClass
    {
        public string GenerateBookingNumber()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(BookingNumber, 4, LEN(BookingNumber)-3) AS INT)), 0) FROM Booking";
            int lastNumber = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
            lastNumber++;
            return "BKG" + lastNumber.ToString("D6");
        }

        public int CreateBooking(int customerId, int roomId, int staffId, DateTime checkIn, DateTime checkOut,
                                   decimal totalPrice, int guests, string specialRequests)
        {
            string bookingNumber = GenerateBookingNumber();
            string query = @"INSERT INTO Booking (BookingNumber, CustomerID, RoomID, StaffID, CheckInDate, 
                            CheckOutDate, TotalPrice, NumberOfGuests, SpecialRequests, BookingStatus, PaymentStatus) 
                            VALUES (@BookingNumber, @CustomerID, @RoomID, @StaffID, @CheckInDate, @CheckOutDate, 
                                    @TotalPrice, @NumberOfGuests, @SpecialRequests, 'Confirmed', 'Pending')";

            SqlParameter[] parameters = {
                new SqlParameter("@BookingNumber", bookingNumber),
                new SqlParameter("@CustomerID", customerId),
                new SqlParameter("@RoomID", roomId),
                new SqlParameter("@StaffID", staffId),
                new SqlParameter("@CheckInDate", checkIn),
                new SqlParameter("@CheckOutDate", checkOut),
                new SqlParameter("@TotalPrice", totalPrice),
                new SqlParameter("@NumberOfGuests", guests),
                new SqlParameter("@SpecialRequests", specialRequests ?? "")
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                RoomClass room = new RoomClass();
                room.UpdateRoomStatus(roomId, "Booked");

                // Get the inserted Booking ID
                string getIdQuery = "SELECT MAX(BookingID) FROM Booking WHERE BookingNumber = @BookingNumber";
                SqlParameter[] idParam = { new SqlParameter("@BookingNumber", bookingNumber) };
                return Convert.ToInt32(DatabaseHelper.ExecuteScalar(getIdQuery, idParam));
            }
            return 0;
        }

        public DataTable GetBookingById(int bookingId)
        {
            string query = @"SELECT b.*, c.Name as CustomerName, c.Email, c.Phone, c.Address, c.CustomerNumber,
                            r.RoomNumber, r.RoomType, r.Price as RoomPrice, r.Floor, r.Capacity,
                            s.FullName as BookedByStaff
                            FROM Booking b 
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID 
                            INNER JOIN Room r ON b.RoomID = r.RoomID
                            INNER JOIN Staff s ON b.StaffID = s.StaffID
                            WHERE b.BookingID = @BookingID";
            SqlParameter[] parameters = { new SqlParameter("@BookingID", bookingId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetBookingsByCustomer(int customerId)
        {
            string query = @"SELECT b.*, r.RoomNumber, r.RoomType, r.Price 
                            FROM Booking b 
                            INNER JOIN Room r ON b.RoomID = r.RoomID 
                            WHERE b.CustomerID = @CustomerID 
                            ORDER BY b.BookingDate DESC";
            SqlParameter[] parameters = { new SqlParameter("@CustomerID", customerId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetBookingsByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT b.*, c.Name as CustomerName, c.Email, c.Phone, r.RoomNumber, r.RoomType,
                            DATEDIFF(DAY, b.CheckInDate, b.CheckOutDate) as Nights
                            FROM Booking b 
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID 
                            INNER JOIN Room r ON b.RoomID = r.RoomID 
                            WHERE b.BookingDate >= @StartDate AND b.BookingDate <= @EndDate
                            ORDER BY b.BookingDate DESC";
            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllBookings()
        {
            string query = @"SELECT b.*, c.Name as CustomerName, c.Email, c.Phone, r.RoomNumber, r.RoomType,
                            DATEDIFF(DAY, b.CheckInDate, b.CheckOutDate) as Nights
                            FROM Booking b 
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID 
                            INNER JOIN Room r ON b.RoomID = r.RoomID 
                            ORDER BY b.BookingDate DESC";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetTodayArrivals()
        {
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
                    WHERE CAST(b.CheckInDate AS DATE) = CAST(GETDATE() AS DATE)
                    AND b.BookingStatus = 'Confirmed'
                    ORDER BY b.CheckInDate";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public DataTable GetTodayDepartures()
        {
            string query = @"SELECT b.BookingID, b.BookingNumber, c.Name as CustomerName, c.Phone, 
                            r.RoomNumber, r.RoomType, b.TotalPrice
                            FROM Booking b 
                            INNER JOIN Customer c ON b.CustomerID = c.CustomerID 
                            INNER JOIN Room r ON b.RoomID = r.RoomID 
                            WHERE CAST(b.CheckOutDate AS DATE) = CAST(GETDATE() AS DATE)
                            AND b.BookingStatus = 'Confirmed'";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public bool CancelBooking(int bookingId, int roomId, string reason)
        {
            string query = "UPDATE Booking SET BookingStatus = 'Cancelled', Remarks = @Reason WHERE BookingID = @BookingID";
            SqlParameter[] parameters = {
                new SqlParameter("@BookingID", bookingId),
                new SqlParameter("@Reason", reason ?? "")
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                RoomClass room = new RoomClass();
                room.UpdateRoomStatus(roomId, "Available");
                return true;
            }
            return false;
        }

        public bool UpdateBookingStatus(int bookingId, string status)
        {
            string query = "UPDATE Booking SET BookingStatus = @Status WHERE BookingID = @BookingID";
            SqlParameter[] parameters = {
                new SqlParameter("@Status", status),
                new SqlParameter("@BookingID", bookingId)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdatePaymentStatus(int bookingId, string status)
        {
            string query = "UPDATE Booking SET PaymentStatus = @Status WHERE BookingID = @BookingID";
            SqlParameter[] parameters = {
                new SqlParameter("@Status", status),
                new SqlParameter("@BookingID", bookingId)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public decimal CalculateTotalPrice(int roomId, DateTime checkIn, DateTime checkOut)
        {
            DataTable room = new RoomClass().GetRoomById(roomId);
            if (room.Rows.Count > 0)
            {
                decimal pricePerDay = Convert.ToDecimal(room.Rows[0]["Price"]);
                int days = (checkOut - checkIn).Days;
                return pricePerDay * days;
            }
            return 0;
        }

        public DataTable GetCurrentOccupancy()
        {
            string query = @"SELECT b.BookingID, b.BookingNumber, c.Name as CustomerName, c.Phone,
                    r.RoomID, r.RoomNumber, r.RoomType, r.Status,
                    b.CheckInDate, b.CheckOutDate, b.NumberOfGuests
                    FROM Booking b
                    INNER JOIN Customer c ON b.CustomerID = c.CustomerID
                    INNER JOIN Room r ON b.RoomID = r.RoomID
                    WHERE b.BookingStatus = 'CheckedIn' 
                    OR (b.BookingStatus = 'Confirmed' AND b.CheckInDate <= GETDATE() AND b.CheckOutDate >= GETDATE())
                    ORDER BY r.RoomNumber";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}