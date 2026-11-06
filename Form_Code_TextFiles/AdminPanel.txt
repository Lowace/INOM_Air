Imports System.Data
Imports System.Linq

Public Class AdminPanel

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowAdminTab(pnlDashboardView, btnNavDashboard)
        RefreshAllAdminData()
    End Sub

    Public Sub RefreshAllAdminData()
        lblStatPlanesNum.Text = AppState.Aircrafts.Count.ToString()
        lblStatUsersNum.Text = AppState.Users.Count.ToString()
        lblStatFlightsNum.Text = AppState.Flights.Count.ToString()

        LoadPlanesGrid()
        LoadCustomersGrid()
        LoadPilotsGrid()
        LoadSchedulesGrid()
    End Sub

    Private Sub ShowAdminTab(targetView As Guna.UI2.WinForms.Guna2Panel, activeBtn As Guna.UI2.WinForms.Guna2Button)
        pnlDashboardView.Visible = False
        pnlPlanesView.Visible = False
        pnlCustomersView.Visible = False
        pnlPilotsView.Visible = False
        pnlSchedulesView.Visible = False

        Dim navButtons = {btnNavDashboard, btnNavPlanes, btnNavCustomers, btnNavPilots, btnNavSchedules}
        For Each b In navButtons
            b.FillColor = Color.Transparent
            b.ForeColor = Color.FromArgb(40, 40, 50)
        Next

        If activeBtn IsNot Nothing Then
            activeBtn.FillColor = Color.FromArgb(1, 123, 128)
            activeBtn.ForeColor = Color.White
        End If

        targetView.Visible = True
        targetView.BringToFront()
    End Sub


    Private Sub LoadPlanesGrid(Optional searchId As String = "", Optional searchModel As String = "", Optional filterStatus As String = "")
        Dim list = AppState.Aircrafts.AsEnumerable()

        If Not String.IsNullOrWhiteSpace(searchId) Then
            list = list.Where(Function(p) p.AircraftId.IndexOf(searchId, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        If Not String.IsNullOrWhiteSpace(searchModel) Then
            list = list.Where(Function(p) p.Model.IndexOf(searchModel, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        If Not String.IsNullOrWhiteSpace(filterStatus) AndAlso filterStatus <> "All Status" Then
            list = list.Where(Function(p) p.Status.Equals(filterStatus, StringComparison.OrdinalIgnoreCase))
        End If

        Dim dt As New DataTable()
        dt.Columns.Add("Aircraft ID")
        dt.Columns.Add("Model")
        dt.Columns.Add("Capacity")
        dt.Columns.Add("Status")

        For Each a In list
            dt.Rows.Add(a.AircraftId, a.Model, a.Capacity, a.Status)
        Next

        dgvPlanes.DataSource = dt
    End Sub

    Private Sub btnFilterPlanes_Click(sender As Object, e As EventArgs) Handles btnFilterPlanes.Click
        LoadPlanesGrid(txtSearchPlaneId.Text.Trim(), txtSearchPlaneModel.Text.Trim(), cmbFilterPlaneStatus.SelectedItem?.ToString())
    End Sub

    Private Sub btnAddNewPlane_Click(sender As Object, e As EventArgs) Handles btnAddNewPlane.Click
        Dim id = InputBox("Enter Aircraft ID (e.g. P005):", "Add New Aircraft", "P00" & (AppState.Aircrafts.Count + 1))
        If String.IsNullOrWhiteSpace(id) Then Return

        Dim model = InputBox("Enter Aircraft Model (e.g. Boeing 787 Dreamliner):", "Add New Aircraft", "Boeing 787")
        If String.IsNullOrWhiteSpace(model) Then Return

        Dim capStr = InputBox("Enter Passenger Capacity:", "Add New Aircraft", "250")
        Dim cap As Integer = 200
        Integer.TryParse(capStr, cap)

        Dim newPlane As New Aircraft With {
            .AircraftId = id,
            .Model = model,
            .Capacity = cap,
            .Status = "Active"
        }
        AppState.Aircrafts.Add(newPlane)
        AppState.SaveAircraftToDatabase(newPlane)

        MessageBox.Show("Aircraft " & id & " added successfully!", "Aircraft Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshAllAdminData()
    End Sub


    Private Sub LoadCustomersGrid(Optional searchId As String = "", Optional searchName As String = "")
        Dim list = AppState.Users.AsEnumerable()

        If Not String.IsNullOrWhiteSpace(searchId) Then
            list = list.Where(Function(u) u.Username.IndexOf(searchId, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        If Not String.IsNullOrWhiteSpace(searchName) Then
            list = list.Where(Function(u) u.FullName.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        Dim dt As New DataTable()
        dt.Columns.Add("Customer ID / Username")
        dt.Columns.Add("Full Name")
        dt.Columns.Add("Contact Number")
        dt.Columns.Add("Gender")
        dt.Columns.Add("Role")
        dt.Columns.Add("Senior / PWD")

        For Each u In list
            Dim discountTag = If(u.IsSenior, "Senior (60+)", If(u.IsPwd, "PWD", "Standard"))
            dt.Rows.Add(u.Username, u.FullName, u.ContactNumber, u.Gender, u.Role, discountTag)
        Next

        dgvCustomers.DataSource = dt
    End Sub

    Private Sub btnFilterCustomers_Click(sender As Object, e As EventArgs) Handles btnFilterCustomers.Click
        LoadCustomersGrid(txtSearchCustId.Text.Trim(), txtSearchCustName.Text.Trim())
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        Dim username = InputBox("Enter New Customer Username:", "Add Customer", "customer" & (AppState.Users.Count + 1))
        If String.IsNullOrWhiteSpace(username) Then Return

        Dim name = InputBox("Enter Full Name:", "Add Customer", "John Doe")
        If String.IsNullOrWhiteSpace(name) Then Return

        Dim contact = InputBox("Enter Contact Number:", "Add Customer", "+63 9123456789")

        Dim newUser As New UserAccount With {
            .Username = username,
            .Password = "password",
            .GivenName = name,
            .ContactNumber = contact,
            .Role = "Customer"
        }
        AppState.Users.Add(newUser)
        AppState.SaveUserToDatabase(newUser)

        MessageBox.Show("Customer " & username & " registered successfully!", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshAllAdminData()
    End Sub


    Private Sub LoadPilotsGrid(Optional searchId As String = "", Optional searchName As String = "")
        Dim list = AppState.Pilots.AsEnumerable()

        If Not String.IsNullOrWhiteSpace(searchId) Then
            list = list.Where(Function(p) p.PilotId.IndexOf(searchId, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        If Not String.IsNullOrWhiteSpace(searchName) Then
            list = list.Where(Function(p) p.Name.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        Dim dt As New DataTable()
        dt.Columns.Add("Pilot ID")
        dt.Columns.Add("Pilot Name")
        dt.Columns.Add("Assigned Flight")
        dt.Columns.Add("Duty Status")

        For Each p In list
            dt.Rows.Add(p.PilotId, p.Name, p.AssignedFlight, p.Status)
        Next

        dgvPilots.DataSource = dt
    End Sub

    Private Sub btnFilterPilots_Click(sender As Object, e As EventArgs) Handles btnFilterPilots.Click
        LoadPilotsGrid(txtSearchPilotId.Text.Trim(), txtSearchPilotName.Text.Trim())
    End Sub

    Private Sub btnAddNewPilot_Click(sender As Object, e As EventArgs) Handles btnAddNewPilot.Click
        Dim id = InputBox("Enter Pilot ID (e.g. PT005):", "Add New Pilot", "PT00" & (AppState.Pilots.Count + 1))
        If String.IsNullOrWhiteSpace(id) Then Return

        Dim name = InputBox("Enter Pilot Full Name:", "Add New Pilot", "Capt. New Pilot")
        If String.IsNullOrWhiteSpace(name) Then Return

        Dim flight = InputBox("Enter Assigned Flight (e.g. F001):", "Add New Pilot", "F001")

        Dim newPilot As New Pilot With {
            .PilotId = id,
            .Name = name,
            .AssignedFlight = flight,
            .Status = "On Duty"
        }
        AppState.Pilots.Add(newPilot)
        AppState.SavePilotToDatabase(newPilot)

        MessageBox.Show("Pilot " & name & " added successfully!", "Pilot Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshAllAdminData()
    End Sub


    Private Sub LoadSchedulesGrid(Optional searchId As String = "", Optional searchDate As String = "")
        Dim list = AppState.Flights.AsEnumerable()

        If Not String.IsNullOrWhiteSpace(searchId) Then
            list = list.Where(Function(f) f.FlightId.IndexOf(searchId, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        If Not String.IsNullOrWhiteSpace(searchDate) Then
            list = list.Where(Function(f) f.FlightDate.IndexOf(searchDate, StringComparison.OrdinalIgnoreCase) >= 0)
        End If

        Dim dt As New DataTable()
        dt.Columns.Add("Flight ID")
        dt.Columns.Add("Origin")
        dt.Columns.Add("Destination")
        dt.Columns.Add("Date")
        dt.Columns.Add("Departure - Arrival")
        dt.Columns.Add("Fare (PHP)")
        dt.Columns.Add("Status")

        For Each f In list
            dt.Rows.Add(f.FlightId, f.Origin, f.Destination, f.FlightDate, f.TimeDisplay, "PHP " & f.BaseFare.ToString("N2"), f.Status)
        Next

        dgvSchedules.DataSource = dt
    End Sub

    Private Sub btnFilterSchedules_Click(sender As Object, e As EventArgs) Handles btnFilterSchedules.Click
        LoadSchedulesGrid(txtSearchFlightId.Text.Trim(), txtSearchFlightDate.Text.Trim())
    End Sub

    Private Sub btnAddNewSchedule_Click(sender As Object, e As EventArgs) Handles btnAddNewSchedule.Click
        Dim id = InputBox("Enter Flight ID (e.g. F006):", "Add Flight Schedule", "F00" & (AppState.Flights.Count + 1))
        If String.IsNullOrWhiteSpace(id) Then Return

        Dim dest = InputBox("Enter Destination City / Country (Philippines or Asia):", "Add Flight Schedule", "Hong Kong")
        If String.IsNullOrWhiteSpace(dest) Then Return

        Dim fareStr = InputBox("Enter Base Fare (PHP):", "Add Flight Schedule", "4500")
        Dim fare As Decimal = 4500D
        Decimal.TryParse(fareStr, fare)

        Dim newFlight As New FlightSchedule With {
            .FlightId = id,
            .Origin = "Manila",
            .Destination = dest,
            .FlightDate = DateTime.Today.AddDays(7).ToString("MMMM dd, yyyy"),
            .DepartureTime = "09:00 AM",
            .ArrivalTime = "11:30 AM",
            .Duration = "2h 30m",
            .BaseFare = fare,
            .Status = "Scheduled",
            .AircraftModel = "Airbus A320"
        }
        AppState.Flights.Add(newFlight)
        AppState.SaveFlightToDatabase(newFlight)

        MessageBox.Show("Flight Schedule " & id & " to " & dest & " added successfully!", "Flight Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshAllAdminData()
    End Sub


    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        ShowAdminTab(pnlDashboardView, btnNavDashboard)
    End Sub

    Private Sub btnNavPlanes_Click(sender As Object, e As EventArgs) Handles btnNavPlanes.Click, btnGoPlanes.Click
        ShowAdminTab(pnlPlanesView, btnNavPlanes)
    End Sub

    Private Sub btnNavCustomers_Click(sender As Object, e As EventArgs) Handles btnNavCustomers.Click, btnGoUsers.Click
        ShowAdminTab(pnlCustomersView, btnNavCustomers)
    End Sub

    Private Sub btnNavPilots_Click(sender As Object, e As EventArgs) Handles btnNavPilots.Click, btnGoPilots.Click
        ShowAdminTab(pnlPilotsView, btnNavPilots)
    End Sub

    Private Sub btnNavSchedules_Click(sender As Object, e As EventArgs) Handles btnNavSchedules.Click, btnGoSchedules.Click
        ShowAdminTab(pnlSchedulesView, btnNavSchedules)
    End Sub

    Private Sub btnPlanesBack_Click(sender As Object, e As EventArgs) Handles btnPlanesBack.Click, btnCustomersBack.Click, btnPilotsBack.Click, btnSchedulesBack.Click
        ShowAdminTab(pnlDashboardView, btnNavDashboard)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, btnSidebarLogout.Click
        Dim startForm As New StartingPage()
        startForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class