<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingStep1
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
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        lblPlaneLogo = New Label()
        lblBrandHeader = New Label()
        lblStepTitle = New Label()
        btnCloseX = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlBody = New Guna.UI2.WinForms.Guna2Panel()
        pnlMainCard = New Guna.UI2.WinForms.Guna2Panel()
        lblB1Title = New Label()
        lblB1Subtitle = New Label()
        pnlB1Divider = New Panel()
        lblB1Origin = New Label()
        cmbB1Origin = New Guna.UI2.WinForms.Guna2ComboBox()
        lblB1Dest = New Label()
        cmbB1Dest = New Guna.UI2.WinForms.Guna2ComboBox()
        lblB1Date = New Label()
        dtpB1Date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        lblB1TripType = New Label()
        cmbB1TripType = New Guna.UI2.WinForms.Guna2ComboBox()
        btnB1Back = New Guna.UI2.WinForms.Guna2Button()
        btnB1Next = New Guna.UI2.WinForms.Guna2Button()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlMainCard.SuspendLayout()
        SuspendLayout()

        Guna2BorderlessForm1.BorderRadius = 24
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True

        pnlTopBar.BackColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Controls.Add(lblPlaneLogo)
        pnlTopBar.Controls.Add(lblBrandHeader)
        pnlTopBar.Controls.Add(lblStepTitle)
        pnlTopBar.Controls.Add(btnCloseX)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(980, 56)
        pnlTopBar.TabIndex = 0

        lblPlaneLogo.Font = New Font("Segoe UI Emoji", 18.0F)
        lblPlaneLogo.ForeColor = Color.White
        lblPlaneLogo.Location = New Point(15, 10)
        lblPlaneLogo.Name = "lblPlaneLogo"
        lblPlaneLogo.Size = New Size(36, 36)
        lblPlaneLogo.TabIndex = 0
        lblPlaneLogo.Text = "✈"
        lblPlaneLogo.TextAlign = ContentAlignment.MiddleCenter

        lblBrandHeader.AutoSize = True
        lblBrandHeader.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblBrandHeader.ForeColor = Color.White
        lblBrandHeader.Location = New Point(58, 10)
        lblBrandHeader.Name = "lblBrandHeader"
        lblBrandHeader.Size = New Size(100, 20)
        lblBrandHeader.TabIndex = 1
        lblBrandHeader.Text = "INOM Air"

        lblStepTitle.AutoSize = True
        lblStepTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblStepTitle.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        lblStepTitle.Location = New Point(58, 30)
        lblStepTitle.Name = "lblStepTitle"
        lblStepTitle.Size = New Size(300, 19)
        lblStepTitle.TabIndex = 2
        lblStepTitle.Text = "BOOK A FLIGHT — Step 1 of 6"

        btnCloseX.Animated = True
        btnCloseX.BackColor = Color.Transparent
        btnCloseX.Cursor = Cursors.Hand
        btnCloseX.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnCloseX.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCloseX.ForeColor = Color.White
        btnCloseX.Location = New Point(935, 13)
        btnCloseX.Name = "btnCloseX"
        btnCloseX.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnCloseX.Size = New Size(30, 30)
        btnCloseX.TabIndex = 3
        btnCloseX.Text = "✕"

        pnlBody.BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.Controls.Add(pnlMainCard)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(980, 544)
        pnlBody.TabIndex = 1

        pnlMainCard.BorderRadius = 18
        pnlMainCard.Controls.Add(lblB1Title)
        pnlMainCard.Controls.Add(lblB1Subtitle)
        pnlMainCard.Controls.Add(pnlB1Divider)
        pnlMainCard.Controls.Add(lblB1Origin)
        pnlMainCard.Controls.Add(cmbB1Origin)
        pnlMainCard.Controls.Add(lblB1Dest)
        pnlMainCard.Controls.Add(cmbB1Dest)
        pnlMainCard.Controls.Add(lblB1Date)
        pnlMainCard.Controls.Add(dtpB1Date)
        pnlMainCard.Controls.Add(lblB1TripType)
        pnlMainCard.Controls.Add(cmbB1TripType)
        pnlMainCard.Controls.Add(btnB1Back)
        pnlMainCard.Controls.Add(btnB1Next)
        pnlMainCard.FillColor = Color.White
        pnlMainCard.Location = New Point(45, 25)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.ShadowDecoration.BorderRadius = 18
        pnlMainCard.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlMainCard.ShadowDecoration.Enabled = True
        pnlMainCard.Size = New Size(890, 485)
        pnlMainCard.TabIndex = 0

        lblB1Title.AutoSize = True
        lblB1Title.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblB1Title.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB1Title.Location = New Point(40, 30)
        lblB1Title.Name = "lblB1Title"
        lblB1Title.Size = New Size(280, 32)
        lblB1Title.TabIndex = 0
        lblB1Title.Text = "Where are you flying?"

        lblB1Subtitle.AutoSize = True
        lblB1Subtitle.Font = New Font("Segoe UI", 10.0F)
        lblB1Subtitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB1Subtitle.Location = New Point(42, 66)
        lblB1Subtitle.Name = "lblB1Subtitle"
        lblB1Subtitle.Size = New Size(365, 19)
        lblB1Subtitle.TabIndex = 1
        lblB1Subtitle.Text = "Search flights across all major destinations in the Philippines."

        pnlB1Divider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB1Divider.Location = New Point(40, 95)
        pnlB1Divider.Name = "pnlB1Divider"
        pnlB1Divider.Size = New Size(810, 1)
        pnlB1Divider.TabIndex = 2

        lblB1Origin.AutoSize = True
        lblB1Origin.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB1Origin.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB1Origin.Location = New Point(40, 120)
        lblB1Origin.Name = "lblB1Origin"
        lblB1Origin.Size = New Size(175, 19)
        lblB1Origin.TabIndex = 3
        lblB1Origin.Text = "Origin Departure Airport"

        cmbB1Origin.BorderRadius = 12
        cmbB1Origin.Font = New Font("Segoe UI", 10.0F)
        cmbB1Origin.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB1Origin.Items.AddRange(New Object() {"MNL - Manila", "CEB - Cebu", "DVO - Davao", "ILO - Iloilo", "BCD - Bacolod"})
        cmbB1Origin.Location = New Point(40, 145)
        cmbB1Origin.Name = "cmbB1Origin"
        cmbB1Origin.Size = New Size(385, 42)
        cmbB1Origin.StartIndex = 0
        cmbB1Origin.TabIndex = 4

        lblB1Dest.AutoSize = True
        lblB1Dest.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB1Dest.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB1Dest.Location = New Point(40, 215)
        lblB1Dest.Name = "lblB1Dest"
        lblB1Dest.Size = New Size(175, 19)
        lblB1Dest.TabIndex = 5
        lblB1Dest.Text = "Destination Arrival Airport"

        cmbB1Dest.BorderRadius = 12
        cmbB1Dest.Font = New Font("Segoe UI", 10.0F)
        cmbB1Dest.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB1Dest.Items.AddRange(New Object() {"MNL - Manila", "CEB - Cebu", "DVO - Davao", "ILO - Iloilo", "BCD - Bacolod"})
        cmbB1Dest.Location = New Point(40, 240)
        cmbB1Dest.Name = "cmbB1Dest"
        cmbB1Dest.Size = New Size(385, 42)
        cmbB1Dest.StartIndex = 1
        cmbB1Dest.TabIndex = 6

        lblB1Date.AutoSize = True
        lblB1Date.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB1Date.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB1Date.Location = New Point(465, 120)
        lblB1Date.Name = "lblB1Date"
        lblB1Date.Size = New Size(110, 19)
        lblB1Date.TabIndex = 7
        lblB1Date.Text = "Departure Date"

        dtpB1Date.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(223))
        dtpB1Date.BorderRadius = 12
        dtpB1Date.BorderThickness = 1
        dtpB1Date.Checked = True
        dtpB1Date.FillColor = Color.White
        dtpB1Date.Font = New Font("Segoe UI", 10.0F)
        dtpB1Date.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        dtpB1Date.Format = DateTimePickerFormat.Short
        dtpB1Date.Location = New Point(465, 145)
        dtpB1Date.Name = "dtpB1Date"
        dtpB1Date.Size = New Size(385, 42)
        dtpB1Date.TabIndex = 8
        dtpB1Date.Value = DateTime.Today.AddDays(7)

        lblB1TripType.AutoSize = True
        lblB1TripType.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB1TripType.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB1TripType.Location = New Point(465, 215)
        lblB1TripType.Name = "lblB1TripType"
        lblB1TripType.Size = New Size(65, 19)
        lblB1TripType.TabIndex = 9
        lblB1TripType.Text = "Trip Type"

        cmbB1TripType.BorderRadius = 12
        cmbB1TripType.Font = New Font("Segoe UI", 10.0F)
        cmbB1TripType.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB1TripType.Items.AddRange(New Object() {"One Way", "Round Trip"})
        cmbB1TripType.Location = New Point(465, 240)
        cmbB1TripType.Name = "cmbB1TripType"
        cmbB1TripType.Size = New Size(385, 42)
        cmbB1TripType.StartIndex = 0
        cmbB1TripType.TabIndex = 10

        btnB1Back.Animated = True
        btnB1Back.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB1Back.BorderRadius = 12
        btnB1Back.BorderThickness = 1
        btnB1Back.Cursor = Cursors.Hand
        btnB1Back.FillColor = Color.Transparent
        btnB1Back.Font = New Font("Segoe UI", 10.5F)
        btnB1Back.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB1Back.Location = New Point(40, 400)
        btnB1Back.Name = "btnB1Back"
        btnB1Back.Size = New Size(190, 48)
        btnB1Back.TabIndex = 11
        btnB1Back.Text = "← Back to Dashboard"

        btnB1Next.Animated = True
        btnB1Next.BorderRadius = 12
        btnB1Next.Cursor = Cursors.Hand
        btnB1Next.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnB1Next.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnB1Next.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnB1Next.Location = New Point(650, 400)
        btnB1Next.Name = "btnB1Next"
        btnB1Next.Size = New Size(200, 48)
        btnB1Next.TabIndex = 12
        btnB1Next.Text = "Search Flights →"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(980, 600)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingStep1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Search Flights"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlMainCard.ResumeLayout(False)
        pnlMainCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlMainCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB1Title As Label
    Friend WithEvents lblB1Subtitle As Label
    Friend WithEvents pnlB1Divider As Panel
    Friend WithEvents lblB1Origin As Label
    Friend WithEvents cmbB1Origin As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblB1Dest As Label
    Friend WithEvents cmbB1Dest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblB1Date As Label
    Friend WithEvents dtpB1Date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblB1TripType As Label
    Friend WithEvents cmbB1TripType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnB1Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnB1Next As Guna.UI2.WinForms.Guna2Button

End Class
