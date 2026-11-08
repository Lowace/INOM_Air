Imports System.Collections.Generic
Imports System.Data
Imports MySql.Data.MySqlClient

Namespace Global.INOM_Air

    Public Class UserAccount
        Public Property CustomerId As String = ""
        Public Property Username As String
        Public Property Password As String
        Public Property GivenName As String
        Public Property Surname As String
        Public ReadOnly Property FullName As String
            Get
                Return If(String.IsNullOrWhiteSpace(Surname), GivenName, GivenName & " " & Surname)
            End Get
        End Property
        Public Property Gender As String = "Male"
        Public Property DateOfBirth As DateTime = New DateTime(2000, 1, 1)
        Public Property ContactNumber As String = "+63 9123456789"
        Public Property Role As String = "Customer"
        Public Property IsSenior As Boolean = False
        Public Property IsPwd As Boolean = False
    End Class

    Public Class FlightSchedule
        Public Property FlightId As String
        Public Property Origin As String
        Public Property Destination As String
        Public Property FlightDate As String
        Public Property DepartureTime As String
        Public Property ArrivalTime As String
        Public Property Duration As String
        Public Property FlightType As String = "Direct Flight"
        Public Property BaseFare As Decimal
        Public Property Status As String = "Scheduled"
        Public Property AircraftModel As String = "Boeing 737-800"

        Public ReadOnly Property TimeDisplay As String
            Get
                Return DepartureTime & " - " & ArrivalTime
            End Get
        End Property

        Public ReadOnly Property RouteDisplay As String
            Get
                Return Origin & " to " & Destination
            End Get
        End Property
    End Class

    Public Class Aircraft
        Public Property AircraftId As String
        Public Property Model As String
        Public Property Capacity As Integer
        Public Property Status As String = "Active"
    End Class

    Public Class Pilot
        Public Property PilotId As String
        Public Property Name As String
        Public Property AssignedFlight As String
        Public Property Status As String = "On Duty"
    End Class

    Public Class BookingRecord
        Public Property TicketNumber As String
        Public Property Username As String
        Public Property PassengerName As String
        Public Property Flight As FlightSchedule
        Public Property CabinClass As String = "Economy"
        Public Property SeatNumber As String = "A1"
        Public Property Gate As String = "A1"
        Public Property SelectedMeal As String = "Standard In-flight Meal"
        Public Property CheckedBaggageKg As Integer = 0
        Public Property CarryOnBaggageKg As Integer = 7
        Public Property BaggageFee As Decimal = 0D
        Public Property IsRefundable As Boolean = False
        Public Property RefundFee As Decimal = 0D
        Public Property DiscountAmount As Decimal = 0D
        Public Property DiscountReason As String = "None"
        Public Property TaxesAndSurcharges As Decimal = 450D
        Public Property TotalAmount As Decimal = 0D
        Public Property BookingDate As DateTime = DateTime.Now
        Public Property Status As String = "Confirmed"
    End Class

    Public Module AppState

        Public ReadOnly ColorPrimary As Color = Color.FromArgb(1, 123, 128)
        Public ReadOnly ColorAccent As Color = Color.FromArgb(254, 115, 73)
        Public ReadOnly ColorBackground As Color = Color.FromArgb(237, 229, 216)
        Public ReadOnly ColorCard As Color = Color.White
        Public ReadOnly ColorTextDark As Color = Color.FromArgb(105, 105, 105)

        Public ReadOnly ConnString As String = "Server=localhost;Port=3306;Database=inomairtest_db;Uid=root;Pwd=;ConvertZeroDateTime=True;AllowUserVariables=True;"
        Public IsDatabaseConnected As Boolean = False

        Public Property CurrentUser As UserAccount
        Public Property Users As New List(Of UserAccount)()
        Public Property Flights As New List(Of FlightSchedule)()
        Public Property Aircrafts As New List(Of Aircraft)()
        Public Property Pilots As New List(Of Pilot)()
        Public Property Bookings As New List(Of BookingRecord)()

        Public Property ActiveBooking As New BookingRecord()

        Public SearchOrigin As String = "MNL"
        Public SearchDest As String = "CEB"
        Public SearchDate As DateTime = DateTime.Today
        Public SearchTripType As String = "One Way"

        Public GuestGivenName As String = ""
        Public GuestSurname As String = ""
        Public GuestGender As String = "Male"
        Public GuestAge As Integer = 25
        Public GuestIsPwd As Boolean = False

        Private isInitialized As Boolean = False

        Sub New()
            InitializeDatabase(False)
        End Sub

        Public Function GetConnection() As MySqlConnection
            Return New MySqlConnection(ConnString)
        End Function

        Public Sub ReconnectDatabase(Optional showStatusMessage As Boolean = True)
            isInitialized = False
            InitializeDatabase(showStatusMessage)
        End Sub

        Public Function GenerateUniqueCustomerId() As String
            Dim rnd As New Random()
            Dim newId As String = ""
            Do
                newId = "CUST-" & rnd.Next(100000, 999999).ToString()
            Loop While Users.Any(Function(u) u.CustomerId = newId)
            Return newId
        End Function

        Public Sub ReloadAllFromDatabase()
            Try
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    IsDatabaseConnected = True
                    EnsureTablesExist(conn)
                    EnsureSeedData(conn)
                    LoadDataFromDatabase(conn)
                End Using
            Catch ex As Exception
                IsDatabaseConnected = False
            End Try
        End Sub

        Public Sub InitializeDatabase(Optional showStatusMessage As Boolean = False)
            If isInitialized Then
                If showStatusMessage Then
                    If IsDatabaseConnected Then
                        CustomMessageBox.Show("XAMPP MySQL database (inomairtest_db) is CONNECTED and ONLINE!" & vbCrLf & vbCrLf &
                                               "• Host: localhost:3306" & vbCrLf &
                                               "• Database: inomairtest_db" & vbCrLf &
                                               "• Synchronization: Real-time Live MySQL active.",
                                               "Database Connection: Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        CustomMessageBox.Show("XAMPP MySQL is currently CLOSED or OFFLINE." & vbCrLf & vbCrLf &
                                               "The application will run in Offline Mode with local memory data." & vbCrLf &
                                               "To synchronize with MySQL, start Apache and MySQL in your XAMPP Control Panel.",
                                               "Database Connection: Offline", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                Return
            End If

            Try
                Using conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;ConvertZeroDateTime=True;")
                    conn.Open()
                    Using cmd As New MySqlCommand("CREATE DATABASE IF NOT EXISTS `inomairtest_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    EnsureTablesExist(conn)
                    EnsureSeedData(conn)
                    LoadDataFromDatabase(conn)
                    IsDatabaseConnected = True
                    isInitialized = True
                End Using

                If showStatusMessage Then
                    CustomMessageBox.Show("XAMPP MySQL database (inomairtest_db) is CONNECTED and ONLINE!" & vbCrLf & vbCrLf &
                                           "• Host: localhost:3306" & vbCrLf &
                                           "• Database: inomairtest_db" & vbCrLf &
                                           "• Synchronization: Real-time Live MySQL active.",
                                           "Database Connection: Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                IsDatabaseConnected = False
                InitializeDefaultData()
                isInitialized = True

                If showStatusMessage Then
                    CustomMessageBox.Show("XAMPP MySQL is currently CLOSED or OFFLINE." & vbCrLf & vbCrLf &
                                           "The application will run in Offline Mode with local memory data." & vbCrLf &
                                           "To synchronize with MySQL, start Apache and MySQL in your XAMPP Control Panel.",
                                           "Database Connection: Offline", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Try
        End Sub

        Private Sub EnsureTablesExist(conn As MySqlConnection)
            Dim sql = "
CREATE TABLE IF NOT EXISTS `users` (
    `username` VARCHAR(50) NOT NULL PRIMARY KEY,
    `customer_id` VARCHAR(30) DEFAULT '',
    `password` VARCHAR(100) NOT NULL,
    `given_name` VARCHAR(100) NOT NULL,
    `surname` VARCHAR(100) NOT NULL,
    `gender` VARCHAR(20) DEFAULT 'Male',
    `date_of_birth` DATE DEFAULT '2000-01-01',
    `contact_number` VARCHAR(30) DEFAULT '+63 9123456789',
    `role` VARCHAR(20) DEFAULT 'Customer',
    `is_senior` TINYINT(1) DEFAULT 0,
    `is_pwd` TINYINT(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `aircrafts` (
    `aircraft_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `model` VARCHAR(100) NOT NULL,
    `capacity` INT NOT NULL,
    `status` VARCHAR(50) DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `pilots` (
    `pilot_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `name` VARCHAR(100) NOT NULL,
    `assigned_flight` VARCHAR(50) DEFAULT '',
    `status` VARCHAR(50) DEFAULT 'On Duty'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `flights` (
    `flight_id` VARCHAR(20) NOT NULL PRIMARY KEY,
    `origin` VARCHAR(50) NOT NULL,
    `destination` VARCHAR(50) NOT NULL,
    `flight_date` VARCHAR(50) NOT NULL,
    `departure_time` VARCHAR(20) NOT NULL,
    `arrival_time` VARCHAR(20) NOT NULL,
    `duration` VARCHAR(20) NOT NULL,
    `flight_type` VARCHAR(50) DEFAULT 'Direct Flight',
    `base_fare` DECIMAL(10,2) NOT NULL,
    `status` VARCHAR(50) DEFAULT 'Scheduled',
    `aircraft_model` VARCHAR(100) DEFAULT 'Boeing 737-800'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `bookings` (
    `ticket_number` VARCHAR(50) NOT NULL PRIMARY KEY,
    `username` VARCHAR(50) NOT NULL,
    `passenger_name` VARCHAR(100) NOT NULL,
    `flight_id` VARCHAR(20) NOT NULL,
    `cabin_class` VARCHAR(30) DEFAULT 'Economy',
    `seat_number` VARCHAR(20) DEFAULT 'A1',
    `gate` VARCHAR(20) DEFAULT 'A1',
    `selected_meal` VARCHAR(100) DEFAULT 'Standard In-flight Meal',
    `checked_baggage_kg` INT DEFAULT 0,
    `carry_on_baggage_kg` INT DEFAULT 7,
    `baggage_fee` DECIMAL(10,2) DEFAULT 0.00,
    `is_refundable` TINYINT(1) DEFAULT 0,
    `refund_fee` DECIMAL(10,2) DEFAULT 0.00,
    `discount_amount` DECIMAL(10,2) DEFAULT 0.00,
    `discount_reason` VARCHAR(100) DEFAULT 'None',
    `taxes_and_surcharges` DECIMAL(10,2) DEFAULT 450.00,
    `total_amount` DECIMAL(10,2) DEFAULT 0.00,
    `booking_date` DATETIME DEFAULT CURRENT_TIMESTAMP,
    `status` VARCHAR(50) DEFAULT 'Confirmed'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using

            Try
                Using cmdCheck As New MySqlCommand("SHOW COLUMNS FROM `users` LIKE 'customer_id';", conn)
                    Dim colExists = cmdCheck.ExecuteScalar()
                    If colExists Is Nothing Then
                        Using cmdAdd As New MySqlCommand("ALTER TABLE `users` ADD COLUMN `customer_id` VARCHAR(30) DEFAULT '' AFTER `username`;", conn)
                            cmdAdd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Private Sub EnsureSeedData(conn As MySqlConnection)
            Dim userCount As Long = 0
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `users`;", conn)
                userCount = Convert.ToInt64(cmd.ExecuteScalar())
            End Using

            If userCount = 0 Then
                Dim sqlSeed = "
INSERT INTO `users` (`username`, `customer_id`, `password`, `given_name`, `surname`, `gender`, `date_of_birth`, `contact_number`, `role`, `is_senior`, `is_pwd`) VALUES
('admin', 'CUST-100001', 'admin123', 'Admin', 'Staff', 'Male', '1990-01-01', '+63 9000000000', 'Admin', 0, 0),
('Naruto', 'CUST-100002', 'password', 'Naruto', 'Uzumaki', 'Male', '1995-10-10', '+63 9123456789', 'Customer', 0, 0);

INSERT INTO `aircrafts` (`aircraft_id`, `model`, `capacity`, `status`) VALUES
('P001', 'Boeing 737-800', 180, 'Active'),
('P002', 'Airbus A320', 150, 'Under Maintenance'),
('P003', 'Boeing 777-300ER', 300, 'Active'),
('P004', 'Airbus A350-900', 280, 'Inactive');

INSERT INTO `pilots` (`pilot_id`, `name`, `assigned_flight`, `status`) VALUES
('PT001', 'Kherjie Manuel', 'F001', 'On Duty'),
('PT002', 'Thess Tan', 'F002', 'On Duty'),
('PT003', 'Richmond Paragas', 'F003', 'Standby'),
('PT004', 'Dhelilah Paragas', 'F004', 'On Leave');

INSERT INTO `flights` (`flight_id`, `origin`, `destination`, `flight_date`, `departure_time`, `arrival_time`, `duration`, `flight_type`, `base_fare`, `status`, `aircraft_model`) VALUES
('F001', 'Manila', 'Cebu', 'November 10, 2026', '10:30 AM', '12:00 PM', '1h 30m', 'Direct Flight', 2000.00, 'Flying', 'Boeing 737-800'),
('F002', 'Manila', 'Cebu', 'November 10, 2026', '2:30 PM', '4:00 PM', '1h 30m', 'Direct Flight', 2000.00, 'Scheduled', 'Airbus A320'),
('F003', 'Manila', 'Tokyo', 'November 12, 2026', '07:22 AM', '12:50 PM', '4h 30m', 'Direct Flight', 8500.00, 'Scheduled', 'Boeing 777-300ER'),
('F004', 'Manila', 'Singapore', 'November 15, 2026', '01:00 PM', '04:40 PM', '3h 40m', 'Direct Flight', 5500.00, 'Scheduled', 'Airbus A350-900'),
('F005', 'Manila', 'Bangkok', 'November 18, 2026', '06:15 PM', '09:45 PM', '3h 30m', 'Direct Flight', 6200.00, 'Scheduled', 'Boeing 737-800'),
('F006', 'Manila', 'Davao', 'November 10, 2026', '08:00 AM', '09:45 AM', '1h 45m', 'Direct Flight', 2800.00, 'Scheduled', 'Airbus A320'),
('F007', 'Manila', 'Davao', 'November 10, 2026', '03:15 PM', '05:00 PM', '1h 45m', 'Direct Flight', 2800.00, 'Scheduled', 'Boeing 737-800'),
('F008', 'Manila', 'Boracay', 'November 11, 2026', '09:30 AM', '10:40 AM', '1h 10m', 'Direct Flight', 2400.00, 'Scheduled', 'Airbus A320'),
('F009', 'Manila', 'Iloilo', 'November 11, 2026', '11:00 AM', '12:15 PM', '1h 15m', 'Direct Flight', 2100.00, 'Scheduled', 'Boeing 737-800'),
('F010', 'Manila', 'Puerto Princesa', 'November 12, 2026', '01:20 PM', '02:40 PM', '1h 20m', 'Direct Flight', 2500.00, 'Scheduled', 'Airbus A320'),
('F011', 'Manila', 'Bacolod', 'November 13, 2026', '07:45 AM', '09:00 AM', '1h 15m', 'Direct Flight', 2200.00, 'Scheduled', 'Boeing 737-800'),
('F012', 'Manila', 'Seoul', 'November 14, 2026', '11:30 AM', '04:45 PM', '4h 15m', 'Direct Flight', 7800.00, 'Scheduled', 'Boeing 777-300ER'),
('F013', 'Manila', 'Hong Kong', 'November 15, 2026', '08:15 AM', '10:30 AM', '2h 15m', 'Direct Flight', 4900.00, 'Scheduled', 'Airbus A320'),
('F014', 'Manila', 'Taipei', 'November 16, 2026', '10:00 AM', '12:15 PM', '2h 15m', 'Direct Flight', 4600.00, 'Scheduled', 'Airbus A320'),
('F015', 'Manila', 'Kuala Lumpur', 'November 17, 2026', '02:00 PM', '05:45 PM', '3h 45m', 'Direct Flight', 5200.00, 'Scheduled', 'Boeing 737-800'),
('F016', 'Manila', 'Osaka', 'November 18, 2026', '09:10 AM', '02:00 PM', '3h 50m', 'Direct Flight', 8100.00, 'Scheduled', 'Boeing 777-300ER'),
('F017', 'Manila', 'Bali', 'November 19, 2026', '04:00 PM', '08:00 PM', '4h 00m', 'Direct Flight', 6800.00, 'Scheduled', 'Airbus A350-900'),
('F018', 'Cebu', 'Davao', 'November 20, 2026', '09:00 AM', '10:00 AM', '1h 00m', 'Direct Flight', 1800.00, 'Scheduled', 'Airbus A320'),
('F019', 'Cebu', 'Tokyo', 'November 21, 2026', '08:30 AM', '01:45 PM', '4h 15m', 'Direct Flight', 9000.00, 'Scheduled', 'Boeing 777-300ER'),
('F020', 'Cebu', 'Singapore', 'November 22, 2026', '01:30 PM', '05:15 PM', '3h 45m', 'Direct Flight', 5800.00, 'Scheduled', 'Airbus A350-900');

INSERT INTO `bookings` (`ticket_number`, `username`, `passenger_name`, `flight_id`, `cabin_class`, `seat_number`, `gate`, `selected_meal`, `checked_baggage_kg`, `carry_on_baggage_kg`, `baggage_fee`, `is_refundable`, `refund_fee`, `discount_amount`, `discount_reason`, `taxes_and_surcharges`, `total_amount`, `booking_date`, `status`) VALUES
('INOM-88239014', 'Naruto', 'Naruto Uzumaki', 'F001', 'Economy', 'A1', 'A1', 'Chicken Teriyaki with Rice', 20, 7, 500.00, 0, 0.00, 0.00, 'None', 450.00, 2950.00, NOW(), 'Confirmed');
"
                Using cmdSeed As New MySqlCommand(sqlSeed, conn)
                    cmdSeed.ExecuteNonQuery()
                End Using
            End If
        End Sub

        Public Sub LoadDataFromDatabase(conn As MySqlConnection)
            Users.Clear()
            Using cmd As New MySqlCommand("SELECT username, customer_id, password, given_name, surname, gender, date_of_birth, contact_number, role, is_senior, is_pwd FROM `users`;", conn)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Dim uId = If(r.IsDBNull(r.GetOrdinal("customer_id")), "", r.GetString("customer_id"))
                        Dim un = r.GetString("username")
                        Dim pw = If(r.IsDBNull(r.GetOrdinal("password")), "password", r.GetString("password"))
                        Dim gn = If(r.IsDBNull(r.GetOrdinal("given_name")), un, r.GetString("given_name"))
                        Dim sn = If(r.IsDBNull(r.GetOrdinal("surname")), "", r.GetString("surname"))
                        Dim gd = If(r.IsDBNull(r.GetOrdinal("gender")), "Male", r.GetString("gender"))
                        Dim dob = If(r.IsDBNull(r.GetOrdinal("date_of_birth")), New DateTime(2000, 1, 1), r.GetDateTime("date_of_birth"))
                        Dim cn = If(r.IsDBNull(r.GetOrdinal("contact_number")), "+63 9123456789", r.GetString("contact_number"))
                        Dim rl = If(r.IsDBNull(r.GetOrdinal("role")), "Customer", r.GetString("role"))
                        Dim sr = If(r.IsDBNull(r.GetOrdinal("is_senior")), False, r.GetBoolean("is_senior"))
                        Dim pwd = If(r.IsDBNull(r.GetOrdinal("is_pwd")), False, r.GetBoolean("is_pwd"))

                        If String.IsNullOrWhiteSpace(uId) Then
                            uId = "CUST-" & (100000 + Users.Count + 1).ToString()
                        End If

                        Users.Add(New UserAccount With {
                            .CustomerId = uId,
                            .Username = un,
                            .Password = pw,
                            .GivenName = gn,
                            .Surname = sn,
                            .Gender = gd,
                            .DateOfBirth = dob,
                            .ContactNumber = cn,
                            .Role = rl,
                            .IsSenior = sr,
                            .IsPwd = pwd
                        })
                    End While
                End Using
            End Using

            Aircrafts.Clear()
            Using cmd As New MySqlCommand("SELECT aircraft_id, model, capacity, status FROM `aircrafts`;", conn)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Aircrafts.Add(New Aircraft With {
                            .AircraftId = r.GetString("aircraft_id"),
                            .Model = r.GetString("model"),
                            .Capacity = r.GetInt32("capacity"),
                            .Status = r.GetString("status")
                        })
                    End While
                End Using
            End Using

            Pilots.Clear()
            Using cmd As New MySqlCommand("SELECT pilot_id, name, assigned_flight, status FROM `pilots`;", conn)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Pilots.Add(New Pilot With {
                            .PilotId = r.GetString("pilot_id"),
                            .Name = r.GetString("name"),
                            .AssignedFlight = If(r.IsDBNull(r.GetOrdinal("assigned_flight")), "", r.GetString("assigned_flight")),
                            .Status = r.GetString("status")
                        })
                    End While
                End Using
            End Using

            Flights.Clear()
            Using cmd As New MySqlCommand("SELECT flight_id, origin, destination, flight_date, departure_time, arrival_time, duration, flight_type, base_fare, status, aircraft_model FROM `flights`;", conn)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Flights.Add(New FlightSchedule With {
                            .FlightId = r.GetString("flight_id"),
                            .Origin = r.GetString("origin"),
                            .Destination = r.GetString("destination"),
                            .FlightDate = r.GetString("flight_date"),
                            .DepartureTime = r.GetString("departure_time"),
                            .ArrivalTime = r.GetString("arrival_time"),
                            .Duration = r.GetString("duration"),
                            .FlightType = r.GetString("flight_type"),
                            .BaseFare = r.GetDecimal("base_fare"),
                            .Status = r.GetString("status"),
                            .AircraftModel = r.GetString("aircraft_model")
                        })
                    End While
                End Using
            End Using

            Bookings.Clear()
            Using cmd As New MySqlCommand("SELECT ticket_number, username, passenger_name, flight_id, cabin_class, seat_number, gate, selected_meal, checked_baggage_kg, carry_on_baggage_kg, baggage_fee, is_refundable, refund_fee, discount_amount, discount_reason, taxes_and_surcharges, total_amount, booking_date, status FROM `bookings`;", conn)
                Using r = cmd.ExecuteReader()
                    While r.Read()
                        Dim fId = r.GetString("flight_id")
                        Dim matchedFlight = Flights.Find(Function(f) f.FlightId.Equals(fId, StringComparison.OrdinalIgnoreCase))

                        Bookings.Add(New BookingRecord With {
                            .TicketNumber = r.GetString("ticket_number"),
                            .Username = r.GetString("username"),
                            .PassengerName = r.GetString("passenger_name"),
                            .Flight = If(matchedFlight, Flights(0)),
                            .CabinClass = r.GetString("cabin_class"),
                            .SeatNumber = r.GetString("seat_number"),
                            .Gate = r.GetString("gate"),
                            .SelectedMeal = r.GetString("selected_meal"),
                            .CheckedBaggageKg = r.GetInt32("checked_baggage_kg"),
                            .CarryOnBaggageKg = r.GetInt32("carry_on_baggage_kg"),
                            .BaggageFee = r.GetDecimal("baggage_fee"),
                            .IsRefundable = r.GetBoolean("is_refundable"),
                            .RefundFee = r.GetDecimal("refund_fee"),
                            .DiscountAmount = r.GetDecimal("discount_amount"),
                            .DiscountReason = r.GetString("discount_reason"),
                            .TaxesAndSurcharges = r.GetDecimal("taxes_and_surcharges"),
                            .TotalAmount = r.GetDecimal("total_amount"),
                            .BookingDate = r.GetDateTime("booking_date"),
                            .Status = r.GetString("status")
                        })
                    End While
                End Using
            End Using

            Dim defaultCust = Users.Find(Function(u) u.Username.Equals("Naruto", StringComparison.OrdinalIgnoreCase))
            If defaultCust IsNot Nothing Then
                CurrentUser = defaultCust
            ElseIf Users.Count > 0 Then
                CurrentUser = Users(0)
            End If
        End Sub

        Public Sub SaveUserToDatabase(u As UserAccount)
            If String.IsNullOrWhiteSpace(u.CustomerId) Then
                u.CustomerId = GenerateUniqueCustomerId()
            End If

            Try
                Using conn = GetConnection()
                    conn.Open()
                    IsDatabaseConnected = True
                    Dim sql = "
INSERT INTO `users` (`username`, `customer_id`, `password`, `given_name`, `surname`, `gender`, `date_of_birth`, `contact_number`, `role`, `is_senior`, `is_pwd`)
VALUES (@un, @cid, @pw, @gn, @sn, @gd, @dob, @cn, @rl, @sr, @pwd)
ON DUPLICATE KEY UPDATE
    `customer_id` = @cid,
    `password` = @pw,
    `given_name` = @gn,
    `surname` = @sn,
    `gender` = @gd,
    `date_of_birth` = @dob,
    `contact_number` = @cn,
    `role` = @rl,
    `is_senior` = @sr,
    `is_pwd` = @pwd;
"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@un", u.Username)
                        cmd.Parameters.AddWithValue("@cid", u.CustomerId)
                        cmd.Parameters.AddWithValue("@pw", If(String.IsNullOrWhiteSpace(u.Password), "password", u.Password))
                        cmd.Parameters.AddWithValue("@gn", If(String.IsNullOrWhiteSpace(u.GivenName), u.Username, u.GivenName))
                        cmd.Parameters.AddWithValue("@sn", If(String.IsNullOrWhiteSpace(u.Surname), "", u.Surname))
                        cmd.Parameters.AddWithValue("@gd", If(String.IsNullOrWhiteSpace(u.Gender), "Male", u.Gender))
                        cmd.Parameters.AddWithValue("@dob", u.DateOfBirth.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@cn", If(String.IsNullOrWhiteSpace(u.ContactNumber), "+63 9123456789", u.ContactNumber))
                        cmd.Parameters.AddWithValue("@rl", If(String.IsNullOrWhiteSpace(u.Role), "Customer", u.Role))
                        cmd.Parameters.AddWithValue("@sr", If(u.IsSenior, 1, 0))
                        cmd.Parameters.AddWithValue("@pwd", If(u.IsPwd, 1, 0))
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub SaveBookingToDatabase(b As BookingRecord)
            If Not IsDatabaseConnected Then Return
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Dim sql = "
INSERT INTO `bookings` (`ticket_number`, `username`, `passenger_name`, `flight_id`, `cabin_class`, `seat_number`, `gate`, `selected_meal`, `checked_baggage_kg`, `carry_on_baggage_kg`, `baggage_fee`, `is_refundable`, `refund_fee`, `discount_amount`, `discount_reason`, `taxes_and_surcharges`, `total_amount`, `booking_date`, `status`)
VALUES (@tk, @un, @pn, @fid, @cc, @sn, @gt, @sm, @ckg, @cog, @bf, @ir, @rf, @da, @dr, @ts, @ta, @bd, @st)
ON DUPLICATE KEY UPDATE `status` = @st;
"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@tk", b.TicketNumber)
                        cmd.Parameters.AddWithValue("@un", b.Username)
                        cmd.Parameters.AddWithValue("@pn", b.PassengerName)
                        cmd.Parameters.AddWithValue("@fid", If(b.Flight IsNot Nothing, b.Flight.FlightId, "F001"))
                        cmd.Parameters.AddWithValue("@cc", b.CabinClass)
                        cmd.Parameters.AddWithValue("@sn", b.SeatNumber)
                        cmd.Parameters.AddWithValue("@gt", b.Gate)
                        cmd.Parameters.AddWithValue("@sm", b.SelectedMeal)
                        cmd.Parameters.AddWithValue("@ckg", b.CheckedBaggageKg)
                        cmd.Parameters.AddWithValue("@cog", b.CarryOnBaggageKg)
                        cmd.Parameters.AddWithValue("@bf", b.BaggageFee)
                        cmd.Parameters.AddWithValue("@ir", If(b.IsRefundable, 1, 0))
                        cmd.Parameters.AddWithValue("@rf", b.RefundFee)
                        cmd.Parameters.AddWithValue("@da", b.DiscountAmount)
                        cmd.Parameters.AddWithValue("@dr", b.DiscountReason)
                        cmd.Parameters.AddWithValue("@ts", b.TaxesAndSurcharges)
                        cmd.Parameters.AddWithValue("@ta", b.TotalAmount)
                        cmd.Parameters.AddWithValue("@bd", b.BookingDate.ToString("yyyy-MM-dd HH:mm:ss"))
                        cmd.Parameters.AddWithValue("@st", b.Status)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub UpdateBookingStatusInDatabase(ticketNumber As String, newStatus As String)
            If Not IsDatabaseConnected Then Return
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Using cmd As New MySqlCommand("UPDATE `bookings` SET `status` = @st WHERE `ticket_number` = @tk;", conn)
                        cmd.Parameters.AddWithValue("@st", newStatus)
                        cmd.Parameters.AddWithValue("@tk", ticketNumber)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub SaveAircraftToDatabase(a As Aircraft)
            If Not IsDatabaseConnected Then Return
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Dim sql = "INSERT INTO `aircrafts` (`aircraft_id`, `model`, `capacity`, `status`) VALUES (@id, @md, @cp, @st) ON DUPLICATE KEY UPDATE `model`=@md, `capacity`=@cp, `status`=@st;"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", a.AircraftId)
                        cmd.Parameters.AddWithValue("@md", a.Model)
                        cmd.Parameters.AddWithValue("@cp", a.Capacity)
                        cmd.Parameters.AddWithValue("@st", a.Status)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub SavePilotToDatabase(p As Pilot)
            If Not IsDatabaseConnected Then Return
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Dim sql = "INSERT INTO `pilots` (`pilot_id`, `name`, `assigned_flight`, `status`) VALUES (@id, @nm, @af, @st) ON DUPLICATE KEY UPDATE `name`=@nm, `assigned_flight`=@af, `status`=@st;"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", p.PilotId)
                        cmd.Parameters.AddWithValue("@nm", p.Name)
                        cmd.Parameters.AddWithValue("@af", p.AssignedFlight)
                        cmd.Parameters.AddWithValue("@st", p.Status)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub SaveFlightToDatabase(f As FlightSchedule)
            If Not IsDatabaseConnected Then Return
            Try
                Using conn = GetConnection()
                    conn.Open()
                    Dim sql = "INSERT INTO `flights` (`flight_id`, `origin`, `destination`, `flight_date`, `departure_time`, `arrival_time`, `duration`, `flight_type`, `base_fare`, `status`, `aircraft_model`) VALUES (@id, @og, @ds, @fd, @dt, @at, @dr, @ft, @bf, @st, @am) ON DUPLICATE KEY UPDATE `status`=@st, `base_fare`=@bf;"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", f.FlightId)
                        cmd.Parameters.AddWithValue("@og", f.Origin)
                        cmd.Parameters.AddWithValue("@ds", f.Destination)
                        cmd.Parameters.AddWithValue("@fd", f.FlightDate)
                        cmd.Parameters.AddWithValue("@dt", f.DepartureTime)
                        cmd.Parameters.AddWithValue("@at", f.ArrivalTime)
                        cmd.Parameters.AddWithValue("@dr", f.Duration)
                        cmd.Parameters.AddWithValue("@ft", f.FlightType)
                        cmd.Parameters.AddWithValue("@bf", f.BaseFare)
                        cmd.Parameters.AddWithValue("@st", f.Status)
                        cmd.Parameters.AddWithValue("@am", f.AircraftModel)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End Sub

        Public Sub InitializeDefaultData()
            Users.Clear()
            Aircrafts.Clear()
            Pilots.Clear()
            Flights.Clear()
            Bookings.Clear()

            Users.Add(New UserAccount With {
                .CustomerId = "CUST-100001",
                .Username = "admin",
                .Password = "admin123",
                .GivenName = "Admin",
                .Surname = "Staff",
                .Role = "Admin",
                .ContactNumber = "+63 9000000000"
            })

            Dim defaultCustomer = New UserAccount With {
                .CustomerId = "CUST-100002",
                .Username = "Naruto",
                .Password = "password",
                .GivenName = "Naruto",
                .Surname = "Uzumaki",
                .Gender = "Male",
                .ContactNumber = "+63 9123456789",
                .DateOfBirth = New DateTime(1995, 10, 10),
                .Role = "Customer",
                .IsSenior = False,
                .IsPwd = False
            }
            Users.Add(defaultCustomer)

            Aircrafts.Add(New Aircraft With {.AircraftId = "P001", .Model = "Boeing 737-800", .Capacity = 180, .Status = "Active"})
            Aircrafts.Add(New Aircraft With {.AircraftId = "P002", .Model = "Airbus A320", .Capacity = 150, .Status = "Under Maintenance"})
            Aircrafts.Add(New Aircraft With {.AircraftId = "P003", .Model = "Boeing 777-300ER", .Capacity = 300, .Status = "Active"})
            Aircrafts.Add(New Aircraft With {.AircraftId = "P004", .Model = "Airbus A350-900", .Capacity = 280, .Status = "Inactive"})

            Pilots.Add(New Pilot With {.PilotId = "PT001", .Name = "Kherjie Manuel", .AssignedFlight = "F001", .Status = "On Duty"})
            Pilots.Add(New Pilot With {.PilotId = "PT002", .Name = "Thess Tan", .AssignedFlight = "F002", .Status = "On Duty"})
            Pilots.Add(New Pilot With {.PilotId = "PT003", .Name = "Richmond Paragas", .AssignedFlight = "F003", .Status = "Standby"})
            Pilots.Add(New Pilot With {.PilotId = "PT004", .Name = "Dhelilah Paragas", .AssignedFlight = "F004", .Status = "On Leave"})

            Flights.Add(New FlightSchedule With {
                .FlightId = "F001",
                .Origin = "Manila",
                .Destination = "Cebu",
                .FlightDate = "November 10, 2026",
                .DepartureTime = "10:30 AM",
                .ArrivalTime = "12:00 PM",
                .Duration = "1h 30m",
                .FlightType = "Direct Flight",
                .BaseFare = 2000D,
                .Status = "Flying",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F002",
                .Origin = "Manila",
                .Destination = "Cebu",
                .FlightDate = "November 10, 2026",
                .DepartureTime = "2:30 PM",
                .ArrivalTime = "4:00 PM",
                .Duration = "1h 30m",
                .FlightType = "Direct Flight",
                .BaseFare = 2000D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F003",
                .Origin = "Manila",
                .Destination = "Tokyo",
                .FlightDate = "November 12, 2026",
                .DepartureTime = "07:22 AM",
                .ArrivalTime = "12:50 PM",
                .Duration = "4h 30m",
                .FlightType = "Direct Flight",
                .BaseFare = 8500D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 777-300ER"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F004",
                .Origin = "Manila",
                .Destination = "Singapore",
                .FlightDate = "November 15, 2026",
                .DepartureTime = "01:00 PM",
                .ArrivalTime = "04:40 PM",
                .Duration = "3h 40m",
                .FlightType = "Direct Flight",
                .BaseFare = 5500D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A350-900"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F005",
                .Origin = "Manila",
                .Destination = "Bangkok",
                .FlightDate = "November 18, 2026",
                .DepartureTime = "06:15 PM",
                .ArrivalTime = "09:45 PM",
                .Duration = "3h 30m",
                .FlightType = "Direct Flight",
                .BaseFare = 6200D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F006",
                .Origin = "Manila",
                .Destination = "Davao",
                .FlightDate = "November 10, 2026",
                .DepartureTime = "08:00 AM",
                .ArrivalTime = "09:45 AM",
                .Duration = "1h 45m",
                .FlightType = "Direct Flight",
                .BaseFare = 2800D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F007",
                .Origin = "Manila",
                .Destination = "Davao",
                .FlightDate = "November 10, 2026",
                .DepartureTime = "03:15 PM",
                .ArrivalTime = "05:00 PM",
                .Duration = "1h 45m",
                .FlightType = "Direct Flight",
                .BaseFare = 2800D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F008",
                .Origin = "Manila",
                .Destination = "Boracay",
                .FlightDate = "November 11, 2026",
                .DepartureTime = "09:30 AM",
                .ArrivalTime = "10:40 AM",
                .Duration = "1h 10m",
                .FlightType = "Direct Flight",
                .BaseFare = 2400D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F009",
                .Origin = "Manila",
                .Destination = "Iloilo",
                .FlightDate = "November 11, 2026",
                .DepartureTime = "11:00 AM",
                .ArrivalTime = "12:15 PM",
                .Duration = "1h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 2100D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F010",
                .Origin = "Manila",
                .Destination = "Puerto Princesa",
                .FlightDate = "November 12, 2026",
                .DepartureTime = "01:20 PM",
                .ArrivalTime = "02:40 PM",
                .Duration = "1h 20m",
                .FlightType = "Direct Flight",
                .BaseFare = 2500D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F011",
                .Origin = "Manila",
                .Destination = "Bacolod",
                .FlightDate = "November 13, 2026",
                .DepartureTime = "07:45 AM",
                .ArrivalTime = "09:00 AM",
                .Duration = "1h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 2200D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F012",
                .Origin = "Manila",
                .Destination = "Seoul",
                .FlightDate = "November 14, 2026",
                .DepartureTime = "11:30 AM",
                .ArrivalTime = "04:45 PM",
                .Duration = "4h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 7800D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 777-300ER"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F013",
                .Origin = "Manila",
                .Destination = "Hong Kong",
                .FlightDate = "November 15, 2026",
                .DepartureTime = "08:15 AM",
                .ArrivalTime = "10:30 AM",
                .Duration = "2h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 4900D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F014",
                .Origin = "Manila",
                .Destination = "Taipei",
                .FlightDate = "November 16, 2026",
                .DepartureTime = "10:00 AM",
                .ArrivalTime = "12:15 PM",
                .Duration = "2h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 4600D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F015",
                .Origin = "Manila",
                .Destination = "Kuala Lumpur",
                .FlightDate = "November 17, 2026",
                .DepartureTime = "02:00 PM",
                .ArrivalTime = "05:45 PM",
                .Duration = "3h 45m",
                .FlightType = "Direct Flight",
                .BaseFare = 5200D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 737-800"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F016",
                .Origin = "Manila",
                .Destination = "Osaka",
                .FlightDate = "November 18, 2026",
                .DepartureTime = "09:10 AM",
                .ArrivalTime = "02:00 PM",
                .Duration = "3h 50m",
                .FlightType = "Direct Flight",
                .BaseFare = 8100D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 777-300ER"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F017",
                .Origin = "Manila",
                .Destination = "Bali",
                .FlightDate = "November 19, 2026",
                .DepartureTime = "04:00 PM",
                .ArrivalTime = "08:00 PM",
                .Duration = "4h 00m",
                .FlightType = "Direct Flight",
                .BaseFare = 6800D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A350-900"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F018",
                .Origin = "Cebu",
                .Destination = "Davao",
                .FlightDate = "November 20, 2026",
                .DepartureTime = "09:00 AM",
                .ArrivalTime = "10:00 AM",
                .Duration = "1h 00m",
                .FlightType = "Direct Flight",
                .BaseFare = 1800D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A320"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F019",
                .Origin = "Cebu",
                .Destination = "Tokyo",
                .FlightDate = "November 21, 2026",
                .DepartureTime = "08:30 AM",
                .ArrivalTime = "01:45 PM",
                .Duration = "4h 15m",
                .FlightType = "Direct Flight",
                .BaseFare = 9000D,
                .Status = "Scheduled",
                .AircraftModel = "Boeing 777-300ER"
            })
            Flights.Add(New FlightSchedule With {
                .FlightId = "F020",
                .Origin = "Cebu",
                .Destination = "Singapore",
                .FlightDate = "November 22, 2026",
                .DepartureTime = "01:30 PM",
                .ArrivalTime = "05:15 PM",
                .Duration = "3h 45m",
                .FlightType = "Direct Flight",
                .BaseFare = 5800D,
                .Status = "Scheduled",
                .AircraftModel = "Airbus A350-900"
            })

            Dim initialFlight = Flights(0)
            Bookings.Add(New BookingRecord With {
                .TicketNumber = "INOM-88239014",
                .Username = "Naruto",
                .PassengerName = "Naruto Uzumaki",
                .Flight = initialFlight,
                .CabinClass = "Economy",
                .SeatNumber = "A1",
                .Gate = "A1",
                .SelectedMeal = "Chicken Teriyaki with Rice",
                .CheckedBaggageKg = 20,
                .CarryOnBaggageKg = 7,
                .BaggageFee = 500D,
                .IsRefundable = False,
                .RefundFee = 0D,
                .DiscountAmount = 0D,
                .TaxesAndSurcharges = 450D,
                .TotalAmount = 2950D,
                .BookingDate = DateTime.Now.AddDays(-2),
                .Status = "Confirmed"
            })

            CurrentUser = defaultCustomer
        End Sub

        Public Sub RecalculateActiveBookingPrice(isSenior As Boolean, isPwd As Boolean, checkedKg As Integer, isRefundable As Boolean)
            If ActiveBooking.Flight Is Nothing Then Return

            Dim base = ActiveBooking.Flight.BaseFare
            Dim isBusiness = ActiveBooking.CabinClass IsNot Nothing AndAlso ActiveBooking.CabinClass.IndexOf("Business", StringComparison.OrdinalIgnoreCase) >= 0
            Dim cabinMultiplier = If(isBusiness, 1.8D, 1.0D)
            Dim adjustedBase = base * cabinMultiplier

            Dim baggageFee As Decimal = 0D
            Select Case checkedKg
                Case 10 : baggageFee = 1000D
                Case 20 : baggageFee = 1800D
                Case 40 : baggageFee = 3000D
                Case Else : baggageFee = 0D
            End Select
            ActiveBooking.CheckedBaggageKg = checkedKg
            ActiveBooking.BaggageFee = baggageFee

            Dim adminFee As Decimal = 100D
            Dim fuelFee As Decimal = 150D
            Dim vatFee As Decimal = adjustedBase * 0.12D
            Dim terminalFee As Decimal = 200D
            Dim taxes As Decimal = adminFee + fuelFee + vatFee + terminalFee
            ActiveBooking.TaxesAndSurcharges = taxes

            Dim refundProtection As Decimal = If(isRefundable, 500D, 0D)
            ActiveBooking.IsRefundable = isRefundable
            ActiveBooking.RefundFee = refundProtection

            Dim subtotal = adjustedBase + baggageFee + taxes + refundProtection

            Dim discount As Decimal = 0D
            Dim reason As String = "None"
            If isSenior Then
                discount = adjustedBase * 0.2D
                reason = "Senior Citizen (20%)"
            ElseIf isPwd Then
                discount = adjustedBase * 0.2D
                reason = "PWD (20%)"
            End If

            ActiveBooking.DiscountAmount = discount
            ActiveBooking.DiscountReason = reason
            ActiveBooking.TotalAmount = Math.Max(0D, subtotal - discount)
        End Sub

    End Module

End Namespace
