using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class RoomClass
    {
        public DataTable GetAllRooms()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM Room WHERE IsActive = 1 ORDER BY RoomNumber");
        }

        public DataTable GetAvailableRooms()
        {
            return DatabaseHelper.ExecuteQuery("SELECT * FROM Room WHERE Status = 'Available' AND IsActive = 1 ORDER BY RoomNumber");
        }

        public DataTable GetAvailableRoomsByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = @"SELECT r.* FROM Room r
                            WHERE r.Status IN ('Available', 'Booked')
                            AND r.IsActive = 1
                            AND r.RoomID NOT IN (
                                SELECT RoomID FROM Booking 
                                WHERE (CheckInDate <= @CheckOut AND CheckOutDate >= @CheckIn)
                                AND BookingStatus NOT IN ('Cancelled', 'Completed')
                            )
                            ORDER BY r.RoomNumber";

            SqlParameter[] parameters = {
                new SqlParameter("@CheckIn", checkIn),
                new SqlParameter("@CheckOut", checkOut)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetRoomsByType(string roomType)
        {
            string query = "SELECT * FROM Room WHERE RoomType = @RoomType AND IsActive = 1 ORDER BY RoomNumber";
            SqlParameter[] parameters = { new SqlParameter("@RoomType", roomType) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetRoomsByStatus(string status)
        {
            string query = "SELECT * FROM Room WHERE Status = @Status AND IsActive = 1 ORDER BY RoomNumber";
            SqlParameter[] parameters = { new SqlParameter("@Status", status) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool AddRoom(int roomNumber, string roomType, decimal price, string description, int capacity, int floor, string features)
        {
            string query = @"INSERT INTO Room (RoomNumber, RoomType, Price, Description, Capacity, Floor, Features, Status, IsActive) 
                            VALUES (@RoomNumber, @RoomType, @Price, @Description, @Capacity, @Floor, @Features, 'Available', 1)";

            SqlParameter[] parameters = {
                new SqlParameter("@RoomNumber", roomNumber),
                new SqlParameter("@RoomType", roomType),
                new SqlParameter("@Price", price),
                new SqlParameter("@Description", description ?? ""),
                new SqlParameter("@Capacity", capacity),
                new SqlParameter("@Floor", floor),
                new SqlParameter("@Features", features ?? "")
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateRoom(int roomId, int roomNumber, string roomType, decimal price, string description, int capacity, int floor, string features)
        {
            string query = @"UPDATE Room SET RoomNumber = @RoomNumber, RoomType = @RoomType, 
                            Price = @Price, Description = @Description, Capacity = @Capacity, 
                            Floor = @Floor, Features = @Features 
                            WHERE RoomID = @RoomID";

            SqlParameter[] parameters = {
                new SqlParameter("@RoomID", roomId),
                new SqlParameter("@RoomNumber", roomNumber),
                new SqlParameter("@RoomType", roomType),
                new SqlParameter("@Price", price),
                new SqlParameter("@Description", description ?? ""),
                new SqlParameter("@Capacity", capacity),
                new SqlParameter("@Floor", floor),
                new SqlParameter("@Features", features ?? "")
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteRoom(int roomId)
        {
            string query = "DELETE FROM Room WHERE RoomID = @RoomID";
            SqlParameter[] parameters = { new SqlParameter("@RoomID", roomId) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool SoftDeleteRoom(int roomId)
        {
            string query = "UPDATE Room SET IsActive = 0 WHERE RoomID = @RoomID";
            SqlParameter[] parameters = { new SqlParameter("@RoomID", roomId) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetRoomById(int roomId)
        {
            string query = "SELECT * FROM Room WHERE RoomID = @RoomID";
            SqlParameter[] parameters = { new SqlParameter("@RoomID", roomId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool UpdateRoomStatus(int roomId, string status)
        {
            string query = "UPDATE Room SET Status = @Status WHERE RoomID = @RoomID";
            SqlParameter[] parameters = {
                new SqlParameter("@Status", status),
                new SqlParameter("@RoomID", roomId)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsRoomNumberExists(int roomNumber)
        {
            string query = "SELECT COUNT(*) FROM Room WHERE RoomNumber = @RoomNumber";
            SqlParameter[] parameters = { new SqlParameter("@RoomNumber", roomNumber) };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}