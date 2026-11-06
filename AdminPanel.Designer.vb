<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPanel
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()

        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        lblAdminHeaderTitle = New Label()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        btnNavDashboard = New Guna.UI2.WinForms.Guna2Button()
        btnNavPlanes = New Guna.UI2.WinForms.Guna2Button()
        btnNavCustomers = New Guna.UI2.WinForms.Guna2Button()
        btnNavPilots = New Guna.UI2.WinForms.Guna2Button()
        btnNavSchedules = New Guna.UI2.WinForms.Guna2Button()
        btnSidebarLogout = New Guna.UI2.WinForms.Guna2Button()
        pnlMainWorkspace = New Guna.UI2.WinForms.Guna2Panel()

        pnlDashboardView = New Guna.UI2.WinForms.Guna2Panel()
        lblDashGreeting = New Label()
        pnlStatPlanes = New Guna.UI2.WinForms.Guna2Panel()
        lblStatPlanesTitle = New Label()
        lblStatPlanesNum = New Label()
        pnlStatUsers = New Guna.UI2.WinForms.Guna2Panel()
        lblStatUsersTitle = New Label()
        lblStatUsersNum = New Label()
        pnlStatFlights = New Guna.UI2.WinForms.Guna2Panel()
        lblStatFlightsTitle = New Label()
        lblStatFlightsNum = New Label()
        pnlCardPlanes = New Guna.UI2.WinForms.Guna2Panel()
        lblCardPlanesTitle = New Label()
        lblCardPlanesDesc = New Label()
        btnGoPlanes = New Guna.UI2.WinForms.Guna2Button()
        pnlCardUsers = New Guna.UI2.WinForms.Guna2Panel()
        lblCardUsersTitle = New Label()
        lblCardUsersDesc = New Label()
        btnGoUsers = New Guna.UI2.WinForms.Guna2Button()
        pnlCardPilots = New Guna.UI2.WinForms.Guna2Panel()
        lblCardPilotsTitle = New Label()
        lblCardPilotsDesc = New Label()
        btnGoPilots = New Guna.UI2.WinForms.Guna2Button()
        pnlCardSchedules = New Guna.UI2.WinForms.Guna2Panel()
        lblCardSchedulesTitle = New Label()
        lblCardSchedulesDesc = New Label()
        btnGoSchedules = New Guna.UI2.WinForms.Guna2Button()

        pnlPlanesView = New Guna.UI2.WinForms.Guna2Panel()
        lblPlanesHeader = New Label()
        txtSearchPlaneId = New Guna.UI2.WinForms.Guna2TextBox()
        txtSearchPlaneModel = New Guna.UI2.WinForms.Guna2TextBox()
        cmbFilterPlaneStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        btnFilterPlanes = New Guna.UI2.WinForms.Guna2Button()
        btnAddNewPlane = New Guna.UI2.WinForms.Guna2Button()
        dgvPlanes = New DataGridView()
        btnPlanesBack = New Guna.UI2.WinForms.Guna2Button()

        pnlCustomersView = New Guna.UI2.WinForms.Guna2Panel()
        lblCustomersHeader = New Label()
        txtSearchCustId = New Guna.UI2.WinForms.Guna2TextBox()
        txtSearchCustName = New Guna.UI2.WinForms.Guna2TextBox()
        btnFilterCustomers = New Guna.UI2.WinForms.Guna2Button()
        btnAddNewCustomer = New Guna.UI2.WinForms.Guna2Button()
        dgvCustomers = New DataGridView()
        btnCustomersBack = New Guna.UI2.WinForms.Guna2Button()

        pnlPilotsView = New Guna.UI2.WinForms.Guna2Panel()
        lblPilotsHeader = New Label()
        txtSearchPilotId = New Guna.UI2.WinForms.Guna2TextBox()
        txtSearchPilotName = New Guna.UI2.WinForms.Guna2TextBox()
        btnFilterPilots = New Guna.UI2.WinForms.Guna2Button()
        btnAddNewPilot = New Guna.UI2.WinForms.Guna2Button()
        dgvPilots = New DataGridView()
        btnPilotsBack = New Guna.UI2.WinForms.Guna2Button()

        pnlSchedulesView = New Guna.UI2.WinForms.Guna2Panel()
        lblSchedulesHeader = New Label()
        txtSearchFlightId = New Guna.UI2.WinForms.Guna2TextBox()
        txtSearchFlightDate = New Guna.UI2.WinForms.Guna2TextBox()
        btnFilterSchedules = New Guna.UI2.WinForms.Guna2Button()
        btnAddNewSchedule = New Guna.UI2.WinForms.Guna2Button()
        dgvSchedules = New DataGridView()
        btnSchedulesBack = New Guna.UI2.WinForms.Guna2Button()

        pnlTopBar.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMainWorkspace.SuspendLayout()
        pnlDashboardView.SuspendLayout()
        pnlStatPlanes.SuspendLayout()
        pnlStatUsers.SuspendLayout()
        pnlStatFlights.SuspendLayout()
        pnlCardPlanes.SuspendLayout()
        pnlCardUsers.SuspendLayout()
        pnlCardPilots.SuspendLayout()
        pnlCardSchedules.SuspendLayout()
        pnlPlanesView.SuspendLayout()
        CType(dgvPlanes, ComponentModel.ISupportInitialize).BeginInit()
        pnlCustomersView.SuspendLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        pnlPilotsView.SuspendLayout()
        CType(dgvPilots, ComponentModel.ISupportInitialize).BeginInit()
        pnlSchedulesView.SuspendLayout()
        CType(dgvSchedules, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        Guna2BorderlessForm1.BorderRadius = 30
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        pnlTopBar.BackColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Controls.Add(lblAdminHeaderTitle)
        pnlTopBar.Controls.Add(btnLogout)
        pnlTopBar.Controls.Add(btnClose)
        pnlTopBar.CustomizableEdges = CustomizableEdges1
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1000, 56)
        pnlTopBar.TabIndex = 0
        lblAdminHeaderTitle.AutoSize = True
        lblAdminHeaderTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblAdminHeaderTitle.ForeColor = Color.White
        lblAdminHeaderTitle.Location = New Point(20, 16)
        lblAdminHeaderTitle.Name = "lblAdminHeaderTitle"
        lblAdminHeaderTitle.Size = New Size(328, 25)
        lblAdminHeaderTitle.TabIndex = 0
        lblAdminHeaderTitle.Text = "International NOM Airlines � Admin / Staff"
        btnLogout.Animated = True
        btnLogout.BorderColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnLogout.BorderRadius = 12
        btnLogout.BorderThickness = 1
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FillColor = Color.FromArgb(CByte(40), CByte(255), CByte(255), CByte(255))
        btnLogout.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(855, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(90, 32)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Log out"
        btnClose.Animated = True
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnClose.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(955, 13)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 2
        btnClose.Text = "?"
        pnlSidebar.BackColor = Color.FromArgb(CByte(220), CByte(225), CByte(235))
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(btnNavPlanes)
        pnlSidebar.Controls.Add(btnNavCustomers)
        pnlSidebar.Controls.Add(btnNavPilots)
        pnlSidebar.Controls.Add(btnNavSchedules)
        pnlSidebar.Controls.Add(btnSidebarLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.FillColor = Color.FromArgb(CByte(220), CByte(225), CByte(235))
        pnlSidebar.Location = New Point(0, 56)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(190, 584)
        pnlSidebar.TabIndex = 1
        btnNavDashboard.Animated = True
        btnNavDashboard.BorderRadius = 12
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnNavDashboard.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavDashboard.ForeColor = Color.White
        btnNavDashboard.Location = New Point(15, 30)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(160, 44)
        btnNavDashboard.TabIndex = 0
        btnNavDashboard.Text = "?? Dashboard"
        btnNavPlanes.Animated = True
        btnNavPlanes.BorderRadius = 12
        btnNavPlanes.Cursor = Cursors.Hand
        btnNavPlanes.FillColor = Color.Transparent
        btnNavPlanes.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavPlanes.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        btnNavPlanes.Location = New Point(15, 85)
        btnNavPlanes.Name = "btnNavPlanes"
        btnNavPlanes.Size = New Size(160, 44)
        btnNavPlanes.TabIndex = 1
        btnNavPlanes.Text = "? Planes"
        btnNavCustomers.Animated = True
        btnNavCustomers.BorderRadius = 12
        btnNavCustomers.Cursor = Cursors.Hand
        btnNavCustomers.FillColor = Color.Transparent
        btnNavCustomers.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavCustomers.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        btnNavCustomers.Location = New Point(15, 140)
        btnNavCustomers.Name = "btnNavCustomers"
        btnNavCustomers.Size = New Size(160, 44)
        btnNavCustomers.TabIndex = 2
        btnNavCustomers.Text = "?? Customers"
        btnNavPilots.Animated = True
        btnNavPilots.BorderRadius = 12
        btnNavPilots.Cursor = Cursors.Hand
        btnNavPilots.FillColor = Color.Transparent
        btnNavPilots.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavPilots.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        btnNavPilots.Location = New Point(15, 195)
        btnNavPilots.Name = "btnNavPilots"
        btnNavPilots.Size = New Size(160, 44)
        btnNavPilots.TabIndex = 3
        btnNavPilots.Text = "???? Pilots"
        btnNavSchedules.Animated = True
        btnNavSchedules.BorderRadius = 12
        btnNavSchedules.Cursor = Cursors.Hand
        btnNavSchedules.FillColor = Color.Transparent
        btnNavSchedules.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavSchedules.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        btnNavSchedules.Location = New Point(15, 250)
        btnNavSchedules.Name = "btnNavSchedules"
        btnNavSchedules.Size = New Size(160, 44)
        btnNavSchedules.TabIndex = 4
        btnNavSchedules.Text = "?? Flights"
        btnSidebarLogout.Animated = True
        btnSidebarLogout.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        btnSidebarLogout.BorderRadius = 12
        btnSidebarLogout.BorderThickness = 1
        btnSidebarLogout.Cursor = Cursors.Hand
        btnSidebarLogout.FillColor = Color.White
        btnSidebarLogout.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSidebarLogout.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnSidebarLogout.Location = New Point(15, 515)
        btnSidebarLogout.Name = "btnSidebarLogout"
        btnSidebarLogout.Size = New Size(160, 40)
        btnSidebarLogout.TabIndex = 5
        btnSidebarLogout.Text = "Log out"
        pnlMainWorkspace.BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlMainWorkspace.Controls.Add(pnlDashboardView)
        pnlMainWorkspace.Controls.Add(pnlPlanesView)
        pnlMainWorkspace.Controls.Add(pnlCustomersView)
        pnlMainWorkspace.Controls.Add(pnlPilotsView)
        pnlMainWorkspace.Controls.Add(pnlSchedulesView)
        pnlMainWorkspace.CustomizableEdges = CustomizableEdges2
        pnlMainWorkspace.Dock = DockStyle.Fill
        pnlMainWorkspace.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlMainWorkspace.Location = New Point(190, 56)
        pnlMainWorkspace.Name = "pnlMainWorkspace"
        pnlMainWorkspace.Size = New Size(810, 584)
        pnlMainWorkspace.TabIndex = 2
        pnlDashboardView.Controls.Add(lblDashGreeting)
        pnlDashboardView.Controls.Add(pnlStatPlanes)
        pnlDashboardView.Controls.Add(pnlStatUsers)
        pnlDashboardView.Controls.Add(pnlStatFlights)
        pnlDashboardView.Controls.Add(pnlCardPlanes)
        pnlDashboardView.Controls.Add(pnlCardUsers)
        pnlDashboardView.Controls.Add(pnlCardPilots)
        pnlDashboardView.Controls.Add(pnlCardSchedules)
        pnlDashboardView.Dock = DockStyle.Fill
        pnlDashboardView.Location = New Point(0, 0)
        pnlDashboardView.Name = "pnlDashboardView"
        pnlDashboardView.Size = New Size(810, 584)
        pnlDashboardView.TabIndex = 0
        lblDashGreeting.AutoSize = True
        lblDashGreeting.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblDashGreeting.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblDashGreeting.Location = New Point(25, 20)
        lblDashGreeting.Name = "lblDashGreeting"
        lblDashGreeting.Size = New Size(198, 30)
        lblDashGreeting.TabIndex = 0
        lblDashGreeting.Text = "Admin Dashboard"
        pnlStatPlanes.BorderRadius = 14
        pnlStatPlanes.Controls.Add(lblStatPlanesTitle)
        pnlStatPlanes.Controls.Add(lblStatPlanesNum)
        pnlStatPlanes.FillColor = Color.White
        pnlStatPlanes.Location = New Point(25, 65)
        pnlStatPlanes.Name = "pnlStatPlanes"
        pnlStatPlanes.ShadowDecoration.BorderRadius = 14
        pnlStatPlanes.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlStatPlanes.ShadowDecoration.Enabled = True
        pnlStatPlanes.Size = New Size(230, 80)
        pnlStatPlanes.TabIndex = 1
        lblStatPlanesTitle.AutoSize = True
        lblStatPlanesTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStatPlanesTitle.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        lblStatPlanesTitle.Location = New Point(15, 12)
        lblStatPlanesTitle.Name = "lblStatPlanesTitle"
        lblStatPlanesTitle.Size = New Size(95, 17)
        lblStatPlanesTitle.TabIndex = 0
        lblStatPlanesTitle.Text = "Active Aircraft"
        lblStatPlanesNum.AutoSize = True
        lblStatPlanesNum.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblStatPlanesNum.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblStatPlanesNum.Location = New Point(15, 32)
        lblStatPlanesNum.Name = "lblStatPlanesNum"
        lblStatPlanesNum.Size = New Size(32, 37)
        lblStatPlanesNum.TabIndex = 1
        lblStatPlanesNum.Text = "4"
        pnlStatUsers.BorderRadius = 14
        pnlStatUsers.Controls.Add(lblStatUsersTitle)
        pnlStatUsers.Controls.Add(lblStatUsersNum)
        pnlStatUsers.FillColor = Color.White
        pnlStatUsers.Location = New Point(285, 65)
        pnlStatUsers.Name = "pnlStatUsers"
        pnlStatUsers.ShadowDecoration.BorderRadius = 14
        pnlStatUsers.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlStatUsers.ShadowDecoration.Enabled = True
        pnlStatUsers.Size = New Size(230, 80)
        pnlStatUsers.TabIndex = 2
        lblStatUsersTitle.AutoSize = True
        lblStatUsersTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStatUsersTitle.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        lblStatUsersTitle.Location = New Point(15, 12)
        lblStatUsersTitle.Name = "lblStatUsersTitle"
        lblStatUsersTitle.Size = New Size(141, 17)
        lblStatUsersTitle.TabIndex = 0
        lblStatUsersTitle.Text = "Registered Customers"
        lblStatUsersNum.AutoSize = True
        lblStatUsersNum.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblStatUsersNum.ForeColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        lblStatUsersNum.Location = New Point(15, 32)
        lblStatUsersNum.Name = "lblStatUsersNum"
        lblStatUsersNum.Size = New Size(32, 37)
        lblStatUsersNum.TabIndex = 1
        lblStatUsersNum.Text = "2"
        pnlStatFlights.BorderRadius = 14
        pnlStatFlights.Controls.Add(lblStatFlightsTitle)
        pnlStatFlights.Controls.Add(lblStatFlightsNum)
        pnlStatFlights.FillColor = Color.White
        pnlStatFlights.Location = New Point(545, 65)
        pnlStatFlights.Name = "pnlStatFlights"
        pnlStatFlights.ShadowDecoration.BorderRadius = 14
        pnlStatFlights.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlStatFlights.ShadowDecoration.Enabled = True
        pnlStatFlights.Size = New Size(240, 80)
        pnlStatFlights.TabIndex = 3
        lblStatFlightsTitle.AutoSize = True
        lblStatFlightsTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStatFlightsTitle.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        lblStatFlightsTitle.Location = New Point(15, 12)
        lblStatFlightsTitle.Name = "lblStatFlightsTitle"
        lblStatFlightsTitle.Size = New Size(117, 17)
        lblStatFlightsTitle.TabIndex = 0
        lblStatFlightsTitle.Text = "Scheduled Flights"
        lblStatFlightsNum.AutoSize = True
        lblStatFlightsNum.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblStatFlightsNum.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblStatFlightsNum.Location = New Point(15, 32)
        lblStatFlightsNum.Name = "lblStatFlightsNum"
        lblStatFlightsNum.Size = New Size(32, 37)
        lblStatFlightsNum.TabIndex = 1
        lblStatFlightsNum.Text = "5"
        pnlCardPlanes.BorderRadius = 16
        pnlCardPlanes.Controls.Add(lblCardPlanesTitle)
        pnlCardPlanes.Controls.Add(lblCardPlanesDesc)
        pnlCardPlanes.Controls.Add(btnGoPlanes)
        pnlCardPlanes.FillColor = Color.White
        pnlCardPlanes.Location = New Point(25, 175)
        pnlCardPlanes.Name = "pnlCardPlanes"
        pnlCardPlanes.ShadowDecoration.BorderRadius = 16
        pnlCardPlanes.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCardPlanes.ShadowDecoration.Enabled = True
        pnlCardPlanes.Size = New Size(365, 180)
        pnlCardPlanes.TabIndex = 4
        lblCardPlanesTitle.AutoSize = True
        lblCardPlanesTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCardPlanesTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCardPlanesTitle.Location = New Point(20, 20)
        lblCardPlanesTitle.Name = "lblCardPlanesTitle"
        lblCardPlanesTitle.Size = New Size(157, 21)
        lblCardPlanesTitle.TabIndex = 0
        lblCardPlanesTitle.Text = "? Manage Aircraft"
        lblCardPlanesDesc.Font = New Font("Segoe UI", 9.0F)
        lblCardPlanesDesc.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblCardPlanesDesc.Location = New Point(20, 50)
        lblCardPlanesDesc.Name = "lblCardPlanesDesc"
        lblCardPlanesDesc.Size = New Size(325, 55)
        lblCardPlanesDesc.TabIndex = 1
        lblCardPlanesDesc.Text = "� View active plane inventory" & vbCrLf & "� Update passenger capacities" & vbCrLf & "� Set maintenance status"
        btnGoPlanes.Animated = True
        btnGoPlanes.BorderRadius = 12
        btnGoPlanes.Cursor = Cursors.Hand
        btnGoPlanes.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnGoPlanes.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoPlanes.ForeColor = Color.White
        btnGoPlanes.Location = New Point(110, 125)
        btnGoPlanes.Name = "btnGoPlanes"
        btnGoPlanes.Size = New Size(150, 36)
        btnGoPlanes.TabIndex = 2
        btnGoPlanes.Text = "Manage Planes"
        pnlCardUsers.BorderRadius = 16
        pnlCardUsers.Controls.Add(lblCardUsersTitle)
        pnlCardUsers.Controls.Add(lblCardUsersDesc)
        pnlCardUsers.Controls.Add(btnGoUsers)
        pnlCardUsers.FillColor = Color.White
        pnlCardUsers.Location = New Point(420, 175)
        pnlCardUsers.Name = "pnlCardUsers"
        pnlCardUsers.ShadowDecoration.BorderRadius = 16
        pnlCardUsers.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCardUsers.ShadowDecoration.Enabled = True
        pnlCardUsers.Size = New Size(365, 180)
        pnlCardUsers.TabIndex = 5
        lblCardUsersTitle.AutoSize = True
        lblCardUsersTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCardUsersTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCardUsersTitle.Location = New Point(20, 20)
        lblCardUsersTitle.Name = "lblCardUsersTitle"
        lblCardUsersTitle.Size = New Size(191, 21)
        lblCardUsersTitle.TabIndex = 0
        lblCardUsersTitle.Text = "?? Review User Profiles"
        lblCardUsersDesc.Font = New Font("Segoe UI", 9.0F)
        lblCardUsersDesc.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblCardUsersDesc.Location = New Point(20, 50)
        lblCardUsersDesc.Name = "lblCardUsersDesc"
        lblCardUsersDesc.Size = New Size(325, 55)
        lblCardUsersDesc.TabIndex = 1
        lblCardUsersDesc.Text = "� Review registered user profiles" & vbCrLf & "� Manage customer reservations" & vbCrLf & "� Manage registered users"
        btnGoUsers.Animated = True
        btnGoUsers.BorderRadius = 12
        btnGoUsers.Cursor = Cursors.Hand
        btnGoUsers.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnGoUsers.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoUsers.ForeColor = Color.White
        btnGoUsers.Location = New Point(110, 125)
        btnGoUsers.Name = "btnGoUsers"
        btnGoUsers.Size = New Size(150, 36)
        btnGoUsers.TabIndex = 2
        btnGoUsers.Text = "Manage Users"
        pnlCardPilots.BorderRadius = 16
        pnlCardPilots.Controls.Add(lblCardPilotsTitle)
        pnlCardPilots.Controls.Add(lblCardPilotsDesc)
        pnlCardPilots.Controls.Add(btnGoPilots)
        pnlCardPilots.FillColor = Color.White
        pnlCardPilots.Location = New Point(25, 375)
        pnlCardPilots.Name = "pnlCardPilots"
        pnlCardPilots.ShadowDecoration.BorderRadius = 16
        pnlCardPilots.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCardPilots.ShadowDecoration.Enabled = True
        pnlCardPilots.Size = New Size(365, 180)
        pnlCardPilots.TabIndex = 6
        lblCardPilotsTitle.AutoSize = True
        lblCardPilotsTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCardPilotsTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCardPilotsTitle.Location = New Point(20, 20)
        lblCardPilotsTitle.Name = "lblCardPilotsTitle"
        lblCardPilotsTitle.Size = New Size(191, 21)
        lblCardPilotsTitle.TabIndex = 0
        lblCardPilotsTitle.Text = "???? Manage Flight Crew"
        lblCardPilotsDesc.Font = New Font("Segoe UI", 9.0F)
        lblCardPilotsDesc.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblCardPilotsDesc.Location = New Point(20, 50)
        lblCardPilotsDesc.Name = "lblCardPilotsDesc"
        lblCardPilotsDesc.Size = New Size(325, 55)
        lblCardPilotsDesc.TabIndex = 1
        lblCardPilotsDesc.Text = "� View pilot duty status" & vbCrLf & "� Assign flight deck captains" & vbCrLf & "� Manage pilots"
        btnGoPilots.Animated = True
        btnGoPilots.BorderRadius = 12
        btnGoPilots.Cursor = Cursors.Hand
        btnGoPilots.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnGoPilots.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoPilots.ForeColor = Color.White
        btnGoPilots.Location = New Point(110, 125)
        btnGoPilots.Name = "btnGoPilots"
        btnGoPilots.Size = New Size(150, 36)
        btnGoPilots.TabIndex = 2
        btnGoPilots.Text = "Manage Pilots"
        pnlCardSchedules.BorderRadius = 16
        pnlCardSchedules.Controls.Add(lblCardSchedulesTitle)
        pnlCardSchedules.Controls.Add(lblCardSchedulesDesc)
        pnlCardSchedules.Controls.Add(btnGoSchedules)
        pnlCardSchedules.FillColor = Color.White
        pnlCardSchedules.Location = New Point(420, 375)
        pnlCardSchedules.Name = "pnlCardSchedules"
        pnlCardSchedules.ShadowDecoration.BorderRadius = 16
        pnlCardSchedules.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCardSchedules.ShadowDecoration.Enabled = True
        pnlCardSchedules.Size = New Size(365, 180)
        pnlCardSchedules.TabIndex = 7
        lblCardSchedulesTitle.AutoSize = True
        lblCardSchedulesTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCardSchedulesTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCardSchedulesTitle.Location = New Point(20, 20)
        lblCardSchedulesTitle.Name = "lblCardSchedulesTitle"
        lblCardSchedulesTitle.Size = New Size(218, 21)
        lblCardSchedulesTitle.TabIndex = 0
        lblCardSchedulesTitle.Text = "?? Manage Flight Schedules"
        lblCardSchedulesDesc.Font = New Font("Segoe UI", 9.0F)
        lblCardSchedulesDesc.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(115))
        lblCardSchedulesDesc.Location = New Point(20, 50)
        lblCardSchedulesDesc.Name = "lblCardSchedulesDesc"
        lblCardSchedulesDesc.Size = New Size(325, 55)
        lblCardSchedulesDesc.TabIndex = 1
        lblCardSchedulesDesc.Text = "� Create new flights" & vbCrLf & "� Update departure/arrival times" & vbCrLf & "� Modify route schedules"
        btnGoSchedules.Animated = True
        btnGoSchedules.BorderRadius = 12
        btnGoSchedules.Cursor = Cursors.Hand
        btnGoSchedules.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnGoSchedules.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnGoSchedules.ForeColor = Color.White
        btnGoSchedules.Location = New Point(110, 125)
        btnGoSchedules.Name = "btnGoSchedules"
        btnGoSchedules.Size = New Size(150, 36)
        btnGoSchedules.TabIndex = 2
        btnGoSchedules.Text = "Manage Schedules"
        pnlPlanesView.Controls.Add(lblPlanesHeader)
        pnlPlanesView.Controls.Add(txtSearchPlaneId)
        pnlPlanesView.Controls.Add(txtSearchPlaneModel)
        pnlPlanesView.Controls.Add(cmbFilterPlaneStatus)
        pnlPlanesView.Controls.Add(btnFilterPlanes)
        pnlPlanesView.Controls.Add(btnAddNewPlane)
        pnlPlanesView.Controls.Add(dgvPlanes)
        pnlPlanesView.Controls.Add(btnPlanesBack)
        pnlPlanesView.Dock = DockStyle.Fill
        pnlPlanesView.Location = New Point(0, 0)
        pnlPlanesView.Name = "pnlPlanesView"
        pnlPlanesView.Size = New Size(810, 584)
        pnlPlanesView.TabIndex = 1
        pnlPlanesView.Visible = False
        lblPlanesHeader.AutoSize = True
        lblPlanesHeader.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblPlanesHeader.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblPlanesHeader.Location = New Point(25, 20)
        lblPlanesHeader.Name = "lblPlanesHeader"
        lblPlanesHeader.Size = New Size(183, 30)
        lblPlanesHeader.TabIndex = 0
        lblPlanesHeader.Text = "Manage Aircrafts"
        txtSearchPlaneId.BorderRadius = 12
        txtSearchPlaneId.Font = New Font("Segoe UI", 9.5F)
        txtSearchPlaneId.Location = New Point(25, 65)
        txtSearchPlaneId.Name = "txtSearchPlaneId"
        txtSearchPlaneId.PlaceholderText = "Aircraft ID"
        txtSearchPlaneId.Size = New Size(130, 38)
        txtSearchPlaneId.TabIndex = 1
        txtSearchPlaneModel.BorderRadius = 12
        txtSearchPlaneModel.Font = New Font("Segoe UI", 9.5F)
        txtSearchPlaneModel.Location = New Point(165, 65)
        txtSearchPlaneModel.Name = "txtSearchPlaneModel"
        txtSearchPlaneModel.PlaceholderText = "Model"
        txtSearchPlaneModel.Size = New Size(160, 38)
        txtSearchPlaneModel.TabIndex = 2
        cmbFilterPlaneStatus.BorderRadius = 12
        cmbFilterPlaneStatus.Font = New Font("Segoe UI", 9.5F)
        cmbFilterPlaneStatus.Items.AddRange(New Object() {"All Status", "Active", "Under Maintenance", "Inactive"})
        cmbFilterPlaneStatus.Location = New Point(335, 65)
        cmbFilterPlaneStatus.Name = "cmbFilterPlaneStatus"
        cmbFilterPlaneStatus.Size = New Size(160, 38)
        cmbFilterPlaneStatus.StartIndex = 0
        cmbFilterPlaneStatus.TabIndex = 3
        btnFilterPlanes.Animated = True
        btnFilterPlanes.BorderRadius = 12
        btnFilterPlanes.Cursor = Cursors.Hand
        btnFilterPlanes.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnFilterPlanes.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterPlanes.ForeColor = Color.White
        btnFilterPlanes.Location = New Point(505, 65)
        btnFilterPlanes.Name = "btnFilterPlanes"
        btnFilterPlanes.Size = New Size(100, 38)
        btnFilterPlanes.TabIndex = 4
        btnFilterPlanes.Text = "Search"
        btnAddNewPlane.Animated = True
        btnAddNewPlane.BorderRadius = 12
        btnAddNewPlane.Cursor = Cursors.Hand
        btnAddNewPlane.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnAddNewPlane.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddNewPlane.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnAddNewPlane.Location = New Point(635, 65)
        btnAddNewPlane.Name = "btnAddNewPlane"
        btnAddNewPlane.Size = New Size(150, 38)
        btnAddNewPlane.TabIndex = 5
        btnAddNewPlane.Text = "+ Add New Aircraft"
        dgvPlanes.AllowUserToAddRows = False
        dgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPlanes.BackgroundColor = Color.White
        dgvPlanes.BorderStyle = BorderStyle.None
        dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPlanes.Location = New Point(25, 120)
        dgvPlanes.Name = "dgvPlanes"
        dgvPlanes.ReadOnly = True
        dgvPlanes.RowHeadersVisible = False
        dgvPlanes.RowTemplate.Height = 35
        dgvPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPlanes.Size = New Size(760, 390)
        dgvPlanes.TabIndex = 6
        btnPlanesBack.Animated = True
        btnPlanesBack.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        btnPlanesBack.BorderRadius = 12
        btnPlanesBack.BorderThickness = 1
        btnPlanesBack.Cursor = Cursors.Hand
        btnPlanesBack.FillColor = Color.White
        btnPlanesBack.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnPlanesBack.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        btnPlanesBack.Location = New Point(685, 525)
        btnPlanesBack.Name = "btnPlanesBack"
        btnPlanesBack.Size = New Size(100, 36)
        btnPlanesBack.TabIndex = 7
        btnPlanesBack.Text = "Back"
        pnlCustomersView.Controls.Add(lblCustomersHeader)
        pnlCustomersView.Controls.Add(txtSearchCustId)
        pnlCustomersView.Controls.Add(txtSearchCustName)
        pnlCustomersView.Controls.Add(btnFilterCustomers)
        pnlCustomersView.Controls.Add(btnAddNewCustomer)
        pnlCustomersView.Controls.Add(dgvCustomers)
        pnlCustomersView.Controls.Add(btnCustomersBack)
        pnlCustomersView.Dock = DockStyle.Fill
        pnlCustomersView.Location = New Point(0, 0)
        pnlCustomersView.Name = "pnlCustomersView"
        pnlCustomersView.Size = New Size(810, 584)
        pnlCustomersView.TabIndex = 2
        pnlCustomersView.Visible = False
        lblCustomersHeader.AutoSize = True
        lblCustomersHeader.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblCustomersHeader.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCustomersHeader.Location = New Point(25, 20)
        lblCustomersHeader.Name = "lblCustomersHeader"
        lblCustomersHeader.Size = New Size(309, 30)
        lblCustomersHeader.TabIndex = 0
        lblCustomersHeader.Text = "Manage Registered Customers"
        txtSearchCustId.BorderRadius = 12
        txtSearchCustId.Font = New Font("Segoe UI", 9.5F)
        txtSearchCustId.Location = New Point(25, 65)
        txtSearchCustId.Name = "txtSearchCustId"
        txtSearchCustId.PlaceholderText = "Customer ID"
        txtSearchCustId.Size = New Size(150, 38)
        txtSearchCustId.TabIndex = 1
        txtSearchCustName.BorderRadius = 12
        txtSearchCustName.Font = New Font("Segoe UI", 9.5F)
        txtSearchCustName.Location = New Point(185, 65)
        txtSearchCustName.Name = "txtSearchCustName"
        txtSearchCustName.PlaceholderText = "Name"
        txtSearchCustName.Size = New Size(200, 38)
        txtSearchCustName.TabIndex = 2
        btnFilterCustomers.Animated = True
        btnFilterCustomers.BorderRadius = 12
        btnFilterCustomers.Cursor = Cursors.Hand
        btnFilterCustomers.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnFilterCustomers.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterCustomers.ForeColor = Color.White
        btnFilterCustomers.Location = New Point(400, 65)
        btnFilterCustomers.Name = "btnFilterCustomers"
        btnFilterCustomers.Size = New Size(100, 38)
        btnFilterCustomers.TabIndex = 3
        btnFilterCustomers.Text = "Search"
        btnAddNewCustomer.Animated = True
        btnAddNewCustomer.BorderRadius = 12
        btnAddNewCustomer.Cursor = Cursors.Hand
        btnAddNewCustomer.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnAddNewCustomer.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddNewCustomer.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnAddNewCustomer.Location = New Point(625, 65)
        btnAddNewCustomer.Name = "btnAddNewCustomer"
        btnAddNewCustomer.Size = New Size(160, 38)
        btnAddNewCustomer.TabIndex = 4
        btnAddNewCustomer.Text = "+ Add New Customer"
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomers.BackgroundColor = Color.White
        dgvCustomers.BorderStyle = BorderStyle.None
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(25, 120)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.RowTemplate.Height = 35
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomers.Size = New Size(760, 390)
        dgvCustomers.TabIndex = 5
        btnCustomersBack.Animated = True
        btnCustomersBack.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        btnCustomersBack.BorderRadius = 12
        btnCustomersBack.BorderThickness = 1
        btnCustomersBack.Cursor = Cursors.Hand
        btnCustomersBack.FillColor = Color.White
        btnCustomersBack.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnCustomersBack.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        btnCustomersBack.Location = New Point(685, 525)
        btnCustomersBack.Name = "btnCustomersBack"
        btnCustomersBack.Size = New Size(100, 36)
        btnCustomersBack.TabIndex = 6
        btnCustomersBack.Text = "Back"
        pnlPilotsView.Controls.Add(lblPilotsHeader)
        pnlPilotsView.Controls.Add(txtSearchPilotId)
        pnlPilotsView.Controls.Add(txtSearchPilotName)
        pnlPilotsView.Controls.Add(btnFilterPilots)
        pnlPilotsView.Controls.Add(btnAddNewPilot)
        pnlPilotsView.Controls.Add(dgvPilots)
        pnlPilotsView.Controls.Add(btnPilotsBack)
        pnlPilotsView.Dock = DockStyle.Fill
        pnlPilotsView.Location = New Point(0, 0)
        pnlPilotsView.Name = "pnlPilotsView"
        pnlPilotsView.Size = New Size(810, 584)
        pnlPilotsView.TabIndex = 3
        pnlPilotsView.Visible = False
        lblPilotsHeader.AutoSize = True
        lblPilotsHeader.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblPilotsHeader.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblPilotsHeader.Location = New Point(25, 20)
        lblPilotsHeader.Name = "lblPilotsHeader"
        lblPilotsHeader.Size = New Size(157, 30)
        lblPilotsHeader.TabIndex = 0
        lblPilotsHeader.Text = "Manage Pilots"
        txtSearchPilotId.BorderRadius = 12
        txtSearchPilotId.Font = New Font("Segoe UI", 9.5F)
        txtSearchPilotId.Location = New Point(25, 65)
        txtSearchPilotId.Name = "txtSearchPilotId"
        txtSearchPilotId.PlaceholderText = "Pilot ID"
        txtSearchPilotId.Size = New Size(150, 38)
        txtSearchPilotId.TabIndex = 1
        txtSearchPilotName.BorderRadius = 12
        txtSearchPilotName.Font = New Font("Segoe UI", 9.5F)
        txtSearchPilotName.Location = New Point(185, 65)
        txtSearchPilotName.Name = "txtSearchPilotName"
        txtSearchPilotName.PlaceholderText = "Name"
        txtSearchPilotName.Size = New Size(200, 38)
        txtSearchPilotName.TabIndex = 2
        btnFilterPilots.Animated = True
        btnFilterPilots.BorderRadius = 12
        btnFilterPilots.Cursor = Cursors.Hand
        btnFilterPilots.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnFilterPilots.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterPilots.ForeColor = Color.White
        btnFilterPilots.Location = New Point(400, 65)
        btnFilterPilots.Name = "btnFilterPilots"
        btnFilterPilots.Size = New Size(100, 38)
        btnFilterPilots.TabIndex = 3
        btnFilterPilots.Text = "Search"
        btnAddNewPilot.Animated = True
        btnAddNewPilot.BorderRadius = 12
        btnAddNewPilot.Cursor = Cursors.Hand
        btnAddNewPilot.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnAddNewPilot.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddNewPilot.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnAddNewPilot.Location = New Point(645, 65)
        btnAddNewPilot.Name = "btnAddNewPilot"
        btnAddNewPilot.Size = New Size(140, 38)
        btnAddNewPilot.TabIndex = 4
        btnAddNewPilot.Text = "+ Add New Pilot"
        dgvPilots.AllowUserToAddRows = False
        dgvPilots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPilots.BackgroundColor = Color.White
        dgvPilots.BorderStyle = BorderStyle.None
        dgvPilots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPilots.Location = New Point(25, 120)
        dgvPilots.Name = "dgvPilots"
        dgvPilots.ReadOnly = True
        dgvPilots.RowHeadersVisible = False
        dgvPilots.RowTemplate.Height = 35
        dgvPilots.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPilots.Size = New Size(760, 390)
        dgvPilots.TabIndex = 5
        btnPilotsBack.Animated = True
        btnPilotsBack.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        btnPilotsBack.BorderRadius = 12
        btnPilotsBack.BorderThickness = 1
        btnPilotsBack.Cursor = Cursors.Hand
        btnPilotsBack.FillColor = Color.White
        btnPilotsBack.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnPilotsBack.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        btnPilotsBack.Location = New Point(685, 525)
        btnPilotsBack.Name = "btnPilotsBack"
        btnPilotsBack.Size = New Size(100, 36)
        btnPilotsBack.TabIndex = 6
        btnPilotsBack.Text = "Back"
        pnlSchedulesView.Controls.Add(lblSchedulesHeader)
        pnlSchedulesView.Controls.Add(txtSearchFlightId)
        pnlSchedulesView.Controls.Add(txtSearchFlightDate)
        pnlSchedulesView.Controls.Add(btnFilterSchedules)
        pnlSchedulesView.Controls.Add(btnAddNewSchedule)
        pnlSchedulesView.Controls.Add(dgvSchedules)
        pnlSchedulesView.Controls.Add(btnSchedulesBack)
        pnlSchedulesView.Dock = DockStyle.Fill
        pnlSchedulesView.Location = New Point(0, 0)
        pnlSchedulesView.Name = "pnlSchedulesView"
        pnlSchedulesView.Size = New Size(810, 584)
        pnlSchedulesView.TabIndex = 4
        pnlSchedulesView.Visible = False
        lblSchedulesHeader.AutoSize = True
        lblSchedulesHeader.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblSchedulesHeader.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblSchedulesHeader.Location = New Point(25, 20)
        lblSchedulesHeader.Name = "lblSchedulesHeader"
        lblSchedulesHeader.Size = New Size(269, 30)
        lblSchedulesHeader.TabIndex = 0
        lblSchedulesHeader.Text = "Manage Flight Schedules"
        txtSearchFlightId.BorderRadius = 12
        txtSearchFlightId.Font = New Font("Segoe UI", 9.5F)
        txtSearchFlightId.Location = New Point(25, 65)
        txtSearchFlightId.Name = "txtSearchFlightId"
        txtSearchFlightId.PlaceholderText = "Flight ID (e.g. F001)"
        txtSearchFlightId.Size = New Size(160, 38)
        txtSearchFlightId.TabIndex = 1
        txtSearchFlightDate.BorderRadius = 12
        txtSearchFlightDate.Font = New Font("Segoe UI", 9.5F)
        txtSearchFlightDate.Location = New Point(195, 65)
        txtSearchFlightDate.Name = "txtSearchFlightDate"
        txtSearchFlightDate.PlaceholderText = "Date & Time"
        txtSearchFlightDate.Size = New Size(190, 38)
        txtSearchFlightDate.TabIndex = 2
        btnFilterSchedules.Animated = True
        btnFilterSchedules.BorderRadius = 12
        btnFilterSchedules.Cursor = Cursors.Hand
        btnFilterSchedules.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnFilterSchedules.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterSchedules.ForeColor = Color.White
        btnFilterSchedules.Location = New Point(400, 65)
        btnFilterSchedules.Name = "btnFilterSchedules"
        btnFilterSchedules.Size = New Size(100, 38)
        btnFilterSchedules.TabIndex = 3
        btnFilterSchedules.Text = "Search"
        btnAddNewSchedule.Animated = True
        btnAddNewSchedule.BorderRadius = 12
        btnAddNewSchedule.Cursor = Cursors.Hand
        btnAddNewSchedule.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnAddNewSchedule.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnAddNewSchedule.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnAddNewSchedule.Location = New Point(640, 65)
        btnAddNewSchedule.Name = "btnAddNewSchedule"
        btnAddNewSchedule.Size = New Size(145, 38)
        btnAddNewSchedule.TabIndex = 4
        btnAddNewSchedule.Text = "+ Add New Flight"
        dgvSchedules.AllowUserToAddRows = False
        dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSchedules.BackgroundColor = Color.White
        dgvSchedules.BorderStyle = BorderStyle.None
        dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchedules.Location = New Point(25, 120)
        dgvSchedules.Name = "dgvSchedules"
        dgvSchedules.ReadOnly = True
        dgvSchedules.RowHeadersVisible = False
        dgvSchedules.RowTemplate.Height = 35
        dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchedules.Size = New Size(760, 390)
        dgvSchedules.TabIndex = 5
        btnSchedulesBack.Animated = True
        btnSchedulesBack.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(210))
        btnSchedulesBack.BorderRadius = 12
        btnSchedulesBack.BorderThickness = 1
        btnSchedulesBack.Cursor = Cursors.Hand
        btnSchedulesBack.FillColor = Color.White
        btnSchedulesBack.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSchedulesBack.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        btnSchedulesBack.Location = New Point(685, 525)
        btnSchedulesBack.Name = "btnSchedulesBack"
        btnSchedulesBack.Size = New Size(100, 36)
        btnSchedulesBack.TabIndex = 6
        btnSchedulesBack.Text = "Back"
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1000, 640)
        Controls.Add(pnlMainWorkspace)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminPanel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Admin Dashboard"
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlMainWorkspace.ResumeLayout(False)
        pnlDashboardView.ResumeLayout(False)
        pnlDashboardView.PerformLayout()
        pnlStatPlanes.ResumeLayout(False)
        pnlStatPlanes.PerformLayout()
        pnlStatUsers.ResumeLayout(False)
        pnlStatUsers.PerformLayout()
        pnlStatFlights.ResumeLayout(False)
        pnlStatFlights.PerformLayout()
        pnlCardPlanes.ResumeLayout(False)
        pnlCardPlanes.PerformLayout()
        pnlCardUsers.ResumeLayout(False)
        pnlCardUsers.PerformLayout()
        pnlCardPilots.ResumeLayout(False)
        pnlCardPilots.PerformLayout()
        pnlCardSchedules.ResumeLayout(False)
        pnlCardSchedules.PerformLayout()
        pnlPlanesView.ResumeLayout(False)
        pnlPlanesView.PerformLayout()
        CType(dgvPlanes, ComponentModel.ISupportInitialize).EndInit()
        pnlCustomersView.ResumeLayout(False)
        pnlCustomersView.PerformLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        pnlPilotsView.ResumeLayout(False)
        pnlPilotsView.PerformLayout()
        CType(dgvPilots, ComponentModel.ISupportInitialize).EndInit()
        pnlSchedulesView.ResumeLayout(False)
        pnlSchedulesView.PerformLayout()
        CType(dgvSchedules, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAdminHeaderTitle As Label
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnNavDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNavPlanes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNavCustomers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNavPilots As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNavSchedules As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSidebarLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMainWorkspace As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents pnlDashboardView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDashGreeting As Label
    Friend WithEvents pnlStatPlanes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatPlanesTitle As Label
    Friend WithEvents lblStatPlanesNum As Label
    Friend WithEvents pnlStatUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatUsersTitle As Label
    Friend WithEvents lblStatUsersNum As Label
    Friend WithEvents pnlStatFlights As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatFlightsTitle As Label
    Friend WithEvents lblStatFlightsNum As Label
    Friend WithEvents pnlCardPlanes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardPlanesTitle As Label
    Friend WithEvents lblCardPlanesDesc As Label
    Friend WithEvents btnGoPlanes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCardUsers As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardUsersTitle As Label
    Friend WithEvents lblCardUsersDesc As Label
    Friend WithEvents btnGoUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCardPilots As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardPilotsTitle As Label
    Friend WithEvents lblCardPilotsDesc As Label
    Friend WithEvents btnGoPilots As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCardSchedules As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCardSchedulesTitle As Label
    Friend WithEvents lblCardSchedulesDesc As Label
    Friend WithEvents btnGoSchedules As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents pnlPlanesView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlanesHeader As Label
    Friend WithEvents txtSearchPlaneId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchPlaneModel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbFilterPlaneStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnFilterPlanes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddNewPlane As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvPlanes As DataGridView
    Friend WithEvents btnPlanesBack As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents pnlCustomersView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCustomersHeader As Label
    Friend WithEvents txtSearchCustId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchCustName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFilterCustomers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddNewCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnCustomersBack As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents pnlPilotsView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPilotsHeader As Label
    Friend WithEvents txtSearchPilotId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchPilotName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFilterPilots As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddNewPilot As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvPilots As DataGridView
    Friend WithEvents btnPilotsBack As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents pnlSchedulesView As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSchedulesHeader As Label
    Friend WithEvents txtSearchFlightId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchFlightDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnFilterSchedules As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddNewSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvSchedules As DataGridView
    Friend WithEvents btnSchedulesBack As Guna.UI2.WinForms.Guna2Button

End Class
