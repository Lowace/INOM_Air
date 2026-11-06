<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingStep2
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
        pnlB2Left = New Guna.UI2.WinForms.Guna2Panel()
        lblB2SummaryTitle = New Label()
        pnlB2LeftDivider = New Panel()
        lblB2Origin = New Label()
        lblB2Dest = New Label()
        lblB2TripType = New Label()
        lblB2CabinClass = New Label()
        cmbB2CabinClass = New Guna.UI2.WinForms.Guna2ComboBox()
        btnB2Back = New Guna.UI2.WinForms.Guna2Button()
        pnlB2Right = New Guna.UI2.WinForms.Guna2Panel()
        lblB2DateHeader = New Label()
        pnlB2FlightCard1 = New Guna.UI2.WinForms.Guna2Panel()
        lblF1Time = New Label()
        lblF1Duration = New Label()
        lblF1Type = New Label()
        lblF1Fare = New Label()
        btnF1Select = New Guna.UI2.WinForms.Guna2Button()
        pnlB2FlightCard2 = New Guna.UI2.WinForms.Guna2Panel()
        lblF2Time = New Label()
        lblF2Duration = New Label()
        lblF2Type = New Label()
        lblF2Fare = New Label()
        btnF2Select = New Guna.UI2.WinForms.Guna2Button()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlB2Left.SuspendLayout()
        pnlB2Right.SuspendLayout()
        pnlB2FlightCard1.SuspendLayout()
        pnlB2FlightCard2.SuspendLayout()
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
        pnlTopBar.Size = New Size(1020, 56)
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
        lblStepTitle.Text = "SELECT YOUR FLIGHT — Step 2 of 6"

        btnCloseX.Animated = True
        btnCloseX.BackColor = Color.Transparent
        btnCloseX.Cursor = Cursors.Hand
        btnCloseX.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnCloseX.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCloseX.ForeColor = Color.White
        btnCloseX.Location = New Point(975, 13)
        btnCloseX.Name = "btnCloseX"
        btnCloseX.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnCloseX.Size = New Size(30, 30)
        btnCloseX.TabIndex = 3
        btnCloseX.Text = "✕"

        pnlBody.BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.Controls.Add(pnlB2Left)
        pnlBody.Controls.Add(pnlB2Right)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1020, 564)
        pnlBody.TabIndex = 1

        pnlB2Left.BorderRadius = 18
        pnlB2Left.Controls.Add(lblB2SummaryTitle)
        pnlB2Left.Controls.Add(pnlB2LeftDivider)
        pnlB2Left.Controls.Add(lblB2Origin)
        pnlB2Left.Controls.Add(lblB2Dest)
        pnlB2Left.Controls.Add(lblB2TripType)
        pnlB2Left.Controls.Add(lblB2CabinClass)
        pnlB2Left.Controls.Add(cmbB2CabinClass)
        pnlB2Left.Controls.Add(btnB2Back)
        pnlB2Left.FillColor = Color.White
        pnlB2Left.Location = New Point(35, 25)
        pnlB2Left.Name = "pnlB2Left"
        pnlB2Left.ShadowDecoration.BorderRadius = 18
        pnlB2Left.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB2Left.ShadowDecoration.Enabled = True
        pnlB2Left.Size = New Size(310, 510)
        pnlB2Left.TabIndex = 0

        lblB2SummaryTitle.AutoSize = True
        lblB2SummaryTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblB2SummaryTitle.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB2SummaryTitle.Location = New Point(25, 25)
        lblB2SummaryTitle.Name = "lblB2SummaryTitle"
        lblB2SummaryTitle.Size = New Size(155, 25)
        lblB2SummaryTitle.TabIndex = 0
        lblB2SummaryTitle.Text = "Search Summary"

        pnlB2LeftDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB2LeftDivider.Location = New Point(25, 60)
        pnlB2LeftDivider.Name = "pnlB2LeftDivider"
        pnlB2LeftDivider.Size = New Size(260, 1)
        pnlB2LeftDivider.TabIndex = 1

        lblB2Origin.AutoSize = True
        lblB2Origin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblB2Origin.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblB2Origin.Location = New Point(25, 80)
        lblB2Origin.Name = "lblB2Origin"
        lblB2Origin.Size = New Size(150, 20)
        lblB2Origin.TabIndex = 2
        lblB2Origin.Text = "Origin: MNL - Manila"

        lblB2Dest.AutoSize = True
        lblB2Dest.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblB2Dest.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblB2Dest.Location = New Point(25, 120)
        lblB2Dest.Name = "lblB2Dest"
        lblB2Dest.Size = New Size(130, 20)
        lblB2Dest.TabIndex = 3
        lblB2Dest.Text = "To: CEB - Cebu"

        lblB2TripType.AutoSize = True
        lblB2TripType.Font = New Font("Segoe UI", 10.0F)
        lblB2TripType.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB2TripType.Location = New Point(25, 160)
        lblB2TripType.Name = "lblB2TripType"
        lblB2TripType.Size = New Size(125, 19)
        lblB2TripType.TabIndex = 4
        lblB2TripType.Text = "Trip Type: One Way"

        lblB2CabinClass.AutoSize = True
        lblB2CabinClass.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB2CabinClass.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB2CabinClass.Location = New Point(25, 220)
        lblB2CabinClass.Name = "lblB2CabinClass"
        lblB2CabinClass.Size = New Size(85, 19)
        lblB2CabinClass.TabIndex = 5
        lblB2CabinClass.Text = "Cabin Class"

        cmbB2CabinClass.BorderRadius = 12
        cmbB2CabinClass.Font = New Font("Segoe UI", 10.0F)
        cmbB2CabinClass.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB2CabinClass.Items.AddRange(New Object() {"Economy Class", "Business Class (+80%)"})
        cmbB2CabinClass.Location = New Point(25, 245)
        cmbB2CabinClass.Name = "cmbB2CabinClass"
        cmbB2CabinClass.Size = New Size(260, 42)
        cmbB2CabinClass.StartIndex = 0
        cmbB2CabinClass.TabIndex = 6

        btnB2Back.Animated = True
        btnB2Back.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB2Back.BorderRadius = 12
        btnB2Back.BorderThickness = 1
        btnB2Back.Cursor = Cursors.Hand
        btnB2Back.FillColor = Color.Transparent
        btnB2Back.Font = New Font("Segoe UI", 10.0F)
        btnB2Back.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB2Back.Location = New Point(25, 440)
        btnB2Back.Name = "btnB2Back"
        btnB2Back.Size = New Size(260, 45)
        btnB2Back.TabIndex = 7
        btnB2Back.Text = "← Change Search"

        pnlB2Right.BorderRadius = 18
        pnlB2Right.Controls.Add(lblB2DateHeader)
        pnlB2Right.Controls.Add(pnlB2FlightCard1)
        pnlB2Right.Controls.Add(pnlB2FlightCard2)
        pnlB2Right.FillColor = Color.White
        pnlB2Right.Location = New Point(365, 25)
        pnlB2Right.Name = "pnlB2Right"
        pnlB2Right.ShadowDecoration.BorderRadius = 18
        pnlB2Right.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB2Right.ShadowDecoration.Enabled = True
        pnlB2Right.Size = New Size(620, 510)
        pnlB2Right.TabIndex = 1

        lblB2DateHeader.AutoSize = True
        lblB2DateHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblB2DateHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB2DateHeader.Location = New Point(30, 25)
        lblB2DateHeader.Name = "lblB2DateHeader"
        lblB2DateHeader.Size = New Size(260, 25)
        lblB2DateHeader.TabIndex = 0
        lblB2DateHeader.Text = "Available Flights for Your Date"

        pnlB2FlightCard1.BorderColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        pnlB2FlightCard1.BorderRadius = 14
        pnlB2FlightCard1.BorderThickness = 1
        pnlB2FlightCard1.Controls.Add(lblF1Time)
        pnlB2FlightCard1.Controls.Add(lblF1Duration)
        pnlB2FlightCard1.Controls.Add(lblF1Type)
        pnlB2FlightCard1.Controls.Add(lblF1Fare)
        pnlB2FlightCard1.Controls.Add(btnF1Select)
        pnlB2FlightCard1.FillColor = Color.FromArgb(CByte(248), CByte(249), CByte(251))
        pnlB2FlightCard1.Location = New Point(30, 80)
        pnlB2FlightCard1.Name = "pnlB2FlightCard1"
        pnlB2FlightCard1.Size = New Size(560, 110)
        pnlB2FlightCard1.TabIndex = 1

        lblF1Time.AutoSize = True
        lblF1Time.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblF1Time.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        lblF1Time.Location = New Point(20, 20)
        lblF1Time.Name = "lblF1Time"
        lblF1Time.Size = New Size(185, 25)
        lblF1Time.TabIndex = 0
        lblF1Time.Text = "08:00 AM - 09:20 AM"

        lblF1Duration.AutoSize = True
        lblF1Duration.Font = New Font("Segoe UI", 9.5F)
        lblF1Duration.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblF1Duration.Location = New Point(20, 50)
        lblF1Duration.Name = "lblF1Duration"
        lblF1Duration.Size = New Size(100, 17)
        lblF1Duration.TabIndex = 1
        lblF1Duration.Text = "1h 20m Duration"

        lblF1Type.AutoSize = True
        lblF1Type.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblF1Type.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblF1Type.Location = New Point(20, 75)
        lblF1Type.Name = "lblF1Type"
        lblF1Type.Size = New Size(65, 17)
        lblF1Type.TabIndex = 2
        lblF1Type.Text = "Direct • Non-Stop"

        lblF1Fare.AutoSize = True
        lblF1Fare.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblF1Fare.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblF1Fare.Location = New Point(285, 38)
        lblF1Fare.Name = "lblF1Fare"
        lblF1Fare.Size = New Size(125, 30)
        lblF1Fare.TabIndex = 3
        lblF1Fare.Text = "PHP 3,000"

        btnF1Select.Animated = True
        btnF1Select.BorderRadius = 12
        btnF1Select.Cursor = Cursors.Hand
        btnF1Select.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnF1Select.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnF1Select.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnF1Select.Location = New Point(430, 32)
        btnF1Select.Name = "btnF1Select"
        btnF1Select.Size = New Size(110, 46)
        btnF1Select.TabIndex = 4
        btnF1Select.Text = "Select"

        pnlB2FlightCard2.BorderColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        pnlB2FlightCard2.BorderRadius = 14
        pnlB2FlightCard2.BorderThickness = 1
        pnlB2FlightCard2.Controls.Add(lblF2Time)
        pnlB2FlightCard2.Controls.Add(lblF2Duration)
        pnlB2FlightCard2.Controls.Add(lblF2Type)
        pnlB2FlightCard2.Controls.Add(lblF2Fare)
        pnlB2FlightCard2.Controls.Add(btnF2Select)
        pnlB2FlightCard2.FillColor = Color.FromArgb(CByte(248), CByte(249), CByte(251))
        pnlB2FlightCard2.Location = New Point(30, 215)
        pnlB2FlightCard2.Name = "pnlB2FlightCard2"
        pnlB2FlightCard2.Size = New Size(560, 110)
        pnlB2FlightCard2.TabIndex = 2

        lblF2Time.AutoSize = True
        lblF2Time.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblF2Time.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        lblF2Time.Location = New Point(20, 20)
        lblF2Time.Name = "lblF2Time"
        lblF2Time.Size = New Size(185, 25)
        lblF2Time.TabIndex = 0
        lblF2Time.Text = "01:30 PM - 02:50 PM"

        lblF2Duration.AutoSize = True
        lblF2Duration.Font = New Font("Segoe UI", 9.5F)
        lblF2Duration.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblF2Duration.Location = New Point(20, 50)
        lblF2Duration.Name = "lblF2Duration"
        lblF2Duration.Size = New Size(100, 17)
        lblF2Duration.TabIndex = 1
        lblF2Duration.Text = "1h 20m Duration"

        lblF2Type.AutoSize = True
        lblF2Type.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblF2Type.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblF2Type.Location = New Point(20, 75)
        lblF2Type.Name = "lblF2Type"
        lblF2Type.Size = New Size(65, 17)
        lblF2Type.TabIndex = 2
        lblF2Type.Text = "Direct • Non-Stop"

        lblF2Fare.AutoSize = True
        lblF2Fare.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblF2Fare.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblF2Fare.Location = New Point(285, 38)
        lblF2Fare.Name = "lblF2Fare"
        lblF2Fare.Size = New Size(125, 30)
        lblF2Fare.TabIndex = 3
        lblF2Fare.Text = "PHP 2,800"

        btnF2Select.Animated = True
        btnF2Select.BorderRadius = 12
        btnF2Select.Cursor = Cursors.Hand
        btnF2Select.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnF2Select.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnF2Select.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnF2Select.Location = New Point(430, 32)
        btnF2Select.Name = "btnF2Select"
        btnF2Select.Size = New Size(110, 46)
        btnF2Select.TabIndex = 4
        btnF2Select.Text = "Select"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1020, 620)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingStep2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Select Flight"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlB2Left.ResumeLayout(False)
        pnlB2Left.PerformLayout()
        pnlB2Right.ResumeLayout(False)
        pnlB2Right.PerformLayout()
        pnlB2FlightCard1.ResumeLayout(False)
        pnlB2FlightCard1.PerformLayout()
        pnlB2FlightCard2.ResumeLayout(False)
        pnlB2FlightCard2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlB2Left As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB2SummaryTitle As Label
    Friend WithEvents pnlB2LeftDivider As Panel
    Friend WithEvents lblB2Origin As Label
    Friend WithEvents lblB2Dest As Label
    Friend WithEvents lblB2TripType As Label
    Friend WithEvents lblB2CabinClass As Label
    Friend WithEvents cmbB2CabinClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnB2Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlB2Right As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB2DateHeader As Label
    Friend WithEvents pnlB2FlightCard1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblF1Time As Label
    Friend WithEvents lblF1Duration As Label
    Friend WithEvents lblF1Type As Label
    Friend WithEvents lblF1Fare As Label
    Friend WithEvents btnF1Select As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlB2FlightCard2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblF2Time As Label
    Friend WithEvents lblF2Duration As Label
    Friend WithEvents lblF2Type As Label
    Friend WithEvents lblF2Fare As Label
    Friend WithEvents btnF2Select As Guna.UI2.WinForms.Guna2Button

End Class
