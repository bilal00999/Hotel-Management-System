using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class CustomerClass
    {
        public string GenerateCustomerNumber()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(CustomerNumber, 5, LEN(CustomerNumber)-4) AS INT)), 0) FROM Customer";
            int lastNumber = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query));
            lastNumber++;
            return "CUST" + lastNumber.ToString("D4");
        }

        public bool CreateCustomer(string name, string email, string phone, string address,
                                   string idProof, string idNumber, string nationality,
                                   bool isVIP, int createdBy)
        {
            string customerNumber = GenerateCustomerNumber();
            string query = @"INSERT INTO Customer (CustomerNumber, Name, Email, Phone, Address, 
                            IDProof, IDNumber, Nationality, IsVIP, CreatedBy, IsActive) 
                            VALUES (@CustomerNumber, @Name, @Email, @Phone, @Address, 
                            @IDProof, @IDNumber, @Nationality, @IsVIP, @CreatedBy, 1)";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerNumber", customerNumber),
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email ?? ""),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address ?? ""),
                new SqlParameter("@IDProof", idProof ?? ""),
                new SqlParameter("@IDNumber", idNumber ?? ""),
                new SqlParameter("@Nationality", nationality ?? "Pakistani"),
                new SqlParameter("@IsVIP", isVIP),
                new SqlParameter("@CreatedBy", createdBy)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable SearchCustomer(string searchTerm)
        {
            string query = @"SELECT CustomerID, CustomerNumber, Name, Email, Phone, Address, 
                            TotalVisits, TotalSpent, IsVIP 
                            FROM Customer 
                            WHERE IsActive = 1
                            AND (Name LIKE @Search OR Phone LIKE @Search OR CustomerNumber LIKE @Search OR Email LIKE @Search)
                            ORDER BY Name";
            SqlParameter[] parameters = { new SqlParameter("@Search", "%" + searchTerm + "%") };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetCustomerById(int customerId)
        {
            string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
            SqlParameter[] parameters = { new SqlParameter("@CustomerID", customerId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetCustomerByPhone(string phone)
        {
            string query = "SELECT CustomerID, CustomerNumber, Name, Phone, Email, IsVIP FROM Customer WHERE Phone = @Phone AND IsActive = 1";
            SqlParameter[] parameters = { new SqlParameter("@Phone", phone) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool UpdateCustomer(int customerId, string name, string phone, string address, string email, bool isVIP)
        {
            string query = "UPDATE Customer SET Name = @Name, Phone = @Phone, Address = @Address, Email = @Email, IsVIP = @VIP, UpdatedDate = GETDATE() WHERE CustomerID = @CustomerID";
            SqlParameter[] parameters = {
                new SqlParameter("@CustomerID", customerId),
                new SqlParameter("@Name", name),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address ?? ""),
                new SqlParameter("@Email", email ?? ""),
                new SqlParameter("@VIP", isVIP)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetCustomerBookings(int customerId)
        {
            string query = @"SELECT b.BookingID, b.BookingNumber, b.CheckInDate, b.CheckOutDate, 
                            b.TotalPrice, b.BookingStatus, b.PaymentStatus, b.BookingDate,
                            r.RoomNumber, r.RoomType
                            FROM Booking b
                            INNER JOIN Room r ON b.RoomID = r.RoomID
                            WHERE b.CustomerID = @CustomerID
                            ORDER BY b.BookingDate DESC";
            SqlParameter[] parameters = { new SqlParameter("@CustomerID", customerId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetVIPCustomers()
        {
            return DatabaseHelper.ExecuteQuery("SELECT CustomerID, CustomerNumber, Name, Phone, TotalVisits, TotalSpent FROM Customer WHERE IsVIP = 1 AND IsActive = 1 ORDER BY TotalSpent DESC");
        }
    }
}