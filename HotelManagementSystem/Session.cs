using System;

namespace HotelManagementSystem
{
    public static class Session
    {
        // Staff Session Properties
        public static int? StaffID { get; set; }
        public static string StaffName { get; set; }
        public static string StaffRole { get; set; } // Receptionist, Manager, SuperAdmin
        public static string StaffUsername { get; set; }

        // Booking Session Properties
        public static int? CurrentBookingID { get; set; }
        public static int? CurrentCustomerID { get; set; }
        public static string CurrentCustomerName { get; set; }
        public static int? CurrentRoomID { get; set; }
        public static int? CurrentRoomNumber { get; set; }

        // Date Session Properties
        public static DateTime? CheckInDate { get; set; }
        public static DateTime? CheckOutDate { get; set; }

        // Payment Session Properties
        public static decimal? PaymentAmount { get; set; }
        public static decimal? AdditionalCharges { get; set; }

        /// <summary>
        /// Clears all staff-related session data
        /// </summary>
        public static void ClearStaffSession()
        {
            StaffID = null;
            StaffName = null;
            StaffRole = null;
            StaffUsername = null;
            ClearBookingSession();
        }

        /// <summary>
        /// Clears all booking-related session data
        /// </summary>
        public static void ClearBookingSession()
        {
            CurrentBookingID = null;
            CurrentCustomerID = null;
            CurrentCustomerName = null;
            CurrentRoomID = null;
            CurrentRoomNumber = null;
            CheckInDate = null;
            CheckOutDate = null;
            PaymentAmount = null;
            AdditionalCharges = null; 
        }

        /// <summary>
        /// Checks if a staff member is currently logged in
        /// </summary>
        public static bool IsStaffLoggedIn()
        {
            return StaffID.HasValue && StaffID.Value > 0;
        }

        /// <summary>
        /// Checks if logged-in staff is Admin (Manager or SuperAdmin)
        /// </summary>
        public static bool IsAdmin()
        {
            return StaffRole == "Manager" || StaffRole == "SuperAdmin";
        }

        /// <summary>
        /// Checks if logged-in staff is SuperAdmin
        /// </summary>
        public static bool IsSuperAdmin()
        {
            return StaffRole == "SuperAdmin";
        }

        /// <summary>
        /// Checks if logged-in staff is Manager
        /// </summary>
        public static bool IsManager()
        {
            return StaffRole == "Manager";
        }

        /// <summary>
        /// Checks if logged-in staff is Receptionist
        /// </summary>
        public static bool IsReceptionist()
        {
            return StaffRole == "Receptionist";
        }

        /// <summary>
        /// Sets current customer for booking
        /// </summary>
        public static void SetCurrentCustomer(int customerId, string customerName)
        {
            CurrentCustomerID = customerId;
            CurrentCustomerName = customerName;
        }

        /// <summary>
        /// Sets booking dates
        /// </summary>
        public static void SetBookingDates(DateTime checkIn, DateTime checkOut)
        {
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
        }

        /// <summary>
        /// Gets number of nights
        /// </summary>
        public static int GetNights()
        {
            if (CheckInDate.HasValue && CheckOutDate.HasValue)
            {
                return (CheckOutDate.Value - CheckInDate.Value).Days;
            }
            return 0;
        }
    }
}