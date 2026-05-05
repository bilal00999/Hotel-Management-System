# Hotel Management System — Project Documentation

## 1. Overview
A Windows Forms (.NET Framework 4.7.2, C# 7.3) Hotel Management System for managing rooms, customers, bookings, payments, invoices, and reports with role-based access for staff/admin.

**Key modules:**
- Authentication (staff/admin/customer)
- Customer management
- Room management
- Booking management
- Payments & invoicing
- Reporting (bookings, payments, revenue, occupancy)

---

## 2. Tech Stack
- **UI:** Windows Forms
- **Runtime:** .NET Framework 4.7.2
- **Language:** C# 7.3
- **Database:** Microsoft SQL Server (via `System.Data.SqlClient`)

---

## 3. Project Structure
```text
HotelManagementSystem/
│
├── Program.cs                          # Application entry point
├── App.config                          # Database connection settings
├── Session.cs                          # Global session management
│
├── Classes/                            # Business Logic Layer
│   ├── DatabaseHelper.cs               # Database connection & execution
│   ├── StaffClass.cs                   # Staff operations
│   ├── CustomerClass.cs                # Customer operations
│   ├── RoomClass.cs                    # Room operations
│   ├── BookingClass.cs                 # Booking operations
│   ├── PaymentClass.cs                 # Payment operations
│   └── ReportClass.cs                  # Reporting operations
│
├── Forms/                              # Presentation Layer
│   ├── Public/
│   │   ├── frmSplash.cs
│   │   ├── frmSplash.Designer.cs
│   │   ├── frmMain.cs
│   │   └── frmMain.Designer.cs
│   │
│   ├── Staff/
│   │   ├── frmStaffLogin.cs
│   │   ├── frmStaffLogin.Designer.cs
│   │   ├── frmStaffDashboard.cs
│   │   ├── frmStaffDashboard.Designer.cs
│   │   ├── frmCreateCustomer.cs
│   │   ├── frmCreateCustomer.Designer.cs
│   │   ├── frmSearchCustomer.cs
│   │   ├── frmSearchCustomer.Designer.cs
│   │   ├── frmCustomerDetails.cs
│   │   └── frmCustomerDetails.Designer.cs
│   │
│   ├── Admin/
│   │   ├── frmManageRooms.cs
│   │   ├── frmManageRooms.Designer.cs
│   │   ├── frmAddRoom.cs
│   │   ├── frmAddRoom.Designer.cs
│   │   ├── frmManageStaff.cs
│   │   ├── frmManageStaff.Designer.cs
│   │   ├── frmViewAllBookings.cs
│   │   ├── frmViewAllBookings.Designer.cs
│   │   ├── frmReports.cs
│   │   └── frmReports.Designer.cs
│   │
│   ├── Booking/
│   │   ├── frmCheckAvailability.cs
│   │   ├── frmCheckAvailability.Designer.cs
│   │   ├── frmBookRoom.cs
│   │   ├── frmBookRoom.Designer.cs
│   │   ├── frmPayment.cs
│   │   ├── frmPayment.Designer.cs
│   │   ├── frmInvoice.cs
│   │   ├── frmInvoice.Designer.cs
│   │   ├── frmCheckIn.cs
│   │   ├── frmCheckIn.Designer.cs
│   │   ├── frmCheckOut.cs
│   │   └── frmCheckOut.Designer.cs
│   │
│   └── Controls/
│       ├── RoundedButton.cs
│       ├── GradientPanel.cs
│       └── LoadingSpinner.cs
│
└── Resources/
    ├── logo.png
    ├── hotel-icon.png
    └── loading.gif
```

---

## 4. Application Startup (`Program.cs`)
**Purpose:** Application entry point. Shows splash screen, then opens the main container.

**Flow:**
- Start → Show `frmSplash` → Close splash → Open `frmMain`

---

## 5. Configuration (`App.config`)
**Purpose:** Stores the SQL Server connection string.

Example:
```xml
<connectionStrings>
  <add name="HotelDB"
       connectionString="Data Source=localhost;Initial Catalog=HotelManagementSystem;Integrated Security=True;"
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

**Common data sources:**
- Default: `Data Source=localhost`
- SQL Express: `Data Source=.\SQLEXPRESS`
- LocalDB: `Data Source=(localdb)\MSSQLLocalDB`

---

## 6. Global Session (`Session.cs`)
**Purpose:** Stores information about the currently logged-in user and current booking context.

Typical properties:
- Staff: `StaffID`, `StaffName`, `StaffRole`
- Booking: `CurrentBookingID`, `CurrentCustomerID`, `CheckInDate`, `CheckOutDate`

Typical usage:
- Set after login
- Check role/permissions
- Clear session on logout

---

## 7. Business Logic Layer (`Classes/`)

### 7.1 `DatabaseHelper.cs`
**Purpose:** Central helper for SQL operations.

Common methods:
- `GetConnection()`
- `ExecuteQuery(sql, params)` → returns `DataTable`
- `ExecuteNonQuery(sql, params)` → returns affected rows / success
- `ExecuteScalar(sql, params)` → returns single value

### 7.2 `StaffClass.cs`
**Purpose:** Staff authentication and staff CRUD.

Common operations:
- `Login(username, password)`
- `GetAllStaff()`
- `AddStaff(...)`, `UpdateStaff(...)`, `DeleteStaff(staffId)`

### 7.3 `CustomerClass.cs`
**Purpose:** Customer CRUD + searching.

Common operations:
- `CreateCustomer(...)`
- `SearchCustomer(searchTerm)`
- `GetCustomerById(customerId)`
- `UpdateCustomer(...)`
- `GetCustomerBookings(customerId)`

### 7.4 `RoomClass.cs`
**Purpose:** Room CRUD and availability.

Common operations:
- `GetAllRooms()` / `GetAvailableRooms()`
- `GetAvailableRoomsByDate(checkIn, checkOut)`
- `AddRoom(...)`, `UpdateRoom(...)`, `DeleteRoom(roomId)`
- `UpdateRoomStatus(roomId, status)`

Room status values:
- `Available`, `Booked`, `Occupied`, `Maintenance`

### 7.5 `BookingClass.cs`
**Purpose:** Booking lifecycle.

Common operations:
- `CreateBooking(...)`
- `GetBookingById(bookingId)`
- `GetBookingsByDateRange(start, end)`
- `CancelBooking(bookingId, roomId)`
- `UpdateBookingStatus(bookingId, status)`

Booking status values:
- `Confirmed`, `CheckedIn`, `Completed`, `Cancelled`

### 7.6 `PaymentClass.cs`
**Purpose:** Payment transactions.

Common operations:
- `ProcessPayment(bookingId, amount, method, receivedBy)`
- `GetPaymentByBookingId(bookingId)`
- `GetPaymentsByDateRange(start, end)`

Payment methods:
- Cash, Credit Card, Debit Card, UPI, Bank Transfer

### 7.7 `ReportClass.cs`
**Purpose:** Reporting queries (revenue, occupancy, etc.).

---

## 8. UI Layer (`Forms/`)

### 8.1 Public Forms
- `frmSplash`: loading screen
- `frmMain`: main container (header + sidebar + content area)

### 8.2 Staff Forms
- `frmStaffLogin`: staff login
- `frmStaffDashboard`: staff dashboard
- `frmCreateCustomer`: create customer
- `frmSearchCustomer`: search customers
- `frmCustomerDetails`: view/edit customer

### 8.3 Admin Forms
- `frmManageRooms`, `frmAddRoom`
- `frmManageStaff`
- `frmViewAllBookings`
- `frmReports`

### 8.4 Booking Forms
- `frmCheckAvailability`
- `frmBookRoom`
- `frmPayment`
- `frmInvoice`
- `frmCheckIn`
- `frmCheckOut`

---

## 9. Core End-to-End Workflow (Walk-in booking example)
1. Staff login
2. Create/search customer
3. Check availability
4. Create booking
5. Process payment
6. Generate invoice
7. Check-in (arrival)
8. Check-out (departure)

---

## 10. Role-Based Access Summary
| Feature | Receptionist | Manager | SuperAdmin |
|---|---:|---:|---:|
| Create/Search/Edit Customer | ✅ | ✅ | ✅ |
| Delete Customer | ❌ | ❌ | ✅ |
| Check Availability / Create Booking | ✅ | ✅ | ✅ |
| Cancel Booking | ✅ | ✅ | ✅ |
| Manage Rooms (Add/Edit/Delete) | ❌ | ✅ | ✅ |
| View Revenue/Payment Reports | ❌ | ✅ | ✅ |
| Manage Staff | ❌ | ❌ | ✅ |

---

## 11. Notes / Common Customizations
- Update SQL Server connection string in `App.config`.
- Ensure role checks use `Session` before allowing access to admin-only forms.
- For consistent currency display, prefer showing amounts as `PKR {amount:N2}`.
