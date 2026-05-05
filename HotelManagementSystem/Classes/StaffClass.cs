using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public class StaffClass
    {
        public DataTable Login(string username, string password)
        {
            string query = "SELECT StaffID, Username, FullName, Email, Phone, Role, IsActive FROM Staff WHERE Username = @Username AND Password = @Password AND IsActive = 1";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllStaff()
        {
            return DatabaseHelper.ExecuteQuery("SELECT StaffID, Username, FullName, Email, Phone, Role, IsActive, CreatedDate FROM Staff ORDER BY StaffID");
        }

        public DataTable GetStaffById(int staffId)
        {
            string query = "SELECT StaffID, Username, FullName, Email, Phone, Role, IsActive FROM Staff WHERE StaffID = @StaffID";
            SqlParameter[] parameters = { new SqlParameter("@StaffID", staffId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public bool AddStaff(string username, string password, string fullName, string email, string phone, string role)
        {
            string query = @"INSERT INTO Staff (Username, Password, FullName, Email, Phone, Role, IsActive) 
                            VALUES (@Username, @Password, @FullName, @Email, @Phone, @Role, 1)";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@Email", email ?? ""),
                new SqlParameter("@Phone", phone ?? ""),
                new SqlParameter("@Role", role)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateStaff(int staffId, string fullName, string email, string phone, string role)
        {
            string query = "UPDATE Staff SET FullName = @FullName, Email = @Email, Phone = @Phone, Role = @Role WHERE StaffID = @StaffID";
            SqlParameter[] parameters = {
                new SqlParameter("@StaffID", staffId),
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@Email", email ?? ""),
                new SqlParameter("@Phone", phone ?? ""),
                new SqlParameter("@Role", role)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateStaffPassword(int staffId, string newPassword)
        {
            string query = "UPDATE Staff SET Password = @Password WHERE StaffID = @StaffID";
            SqlParameter[] parameters = {
                new SqlParameter("@StaffID", staffId),
                new SqlParameter("@Password", newPassword)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteStaff(int staffId)
        {
            string query = "DELETE FROM Staff WHERE StaffID = @StaffID AND Role != 'SuperAdmin'";
            SqlParameter[] parameters = { new SqlParameter("@StaffID", staffId) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeactivateStaff(int staffId, bool isActive)
        {
            string query = "UPDATE Staff SET IsActive = @IsActive WHERE StaffID = @StaffID AND Role != 'SuperAdmin'";
            SqlParameter[] parameters = {
                new SqlParameter("@StaffID", staffId),
                new SqlParameter("@IsActive", isActive)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Staff WHERE Username = @Username";
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}