<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingStep3
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
        pnlB3GuestInputs = New Guna.UI2.WinForms.Guna2Panel()
        lblB3GuestHeader = New Label()
        lblB3Subtitle = New Label()
        pnlB3Divider = New Panel()
        lblB3GivenName = New Label()
        txtB3GivenName = New Guna.UI2.WinForms.Guna2TextBox()
        lblB3Surname = New Label()
        txtB3Surname = New Guna.UI2.WinForms.Guna2TextBox()
        lblB3Age = New Label()
        txtB3Age = New Guna.UI2.WinForms.Guna2TextBox()
        lblB3AgeGroup = New Label()
        cmbB3AgeGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        lblB3Gender = New Label()
        cmbB3Gender = New Guna.UI2.WinForms.Guna2ComboBox()
        lblB3Disabled = New Label()
        rbB3DisabledYes = New Guna.UI2.WinForms.Guna2RadioButton()
        rbB3DisabledNo = New Guna.UI2.WinForms.Guna2RadioButton()
        btnB3Back = New Guna.UI2.WinForms.Guna2Button()
        btnB3Next = New Guna.UI2.WinForms.Guna2Button()
        pnlB3RightSummary = New Guna.UI2.WinForms.Guna2Panel()
        lblB3SummaryHeader = New Label()
        lblB3SummaryDate = New Label()
        lblB3SummaryRoute = New Label()
        lblB3SummaryTime = New Label()
        pnlB3SumDivider = New Panel()
        lblB3SummaryTotalLabel = New Label()
        lblB3SummaryTotalAmount = New Label()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlB3GuestInputs.SuspendLayout()
        pnlB3RightSummary.SuspendLayout()
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
        lblStepTitle.Text = "GUEST DETAILS — Step 3 of 6"

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
        pnlBody.Controls.Add(pnlB3GuestInputs)
        pnlBody.Controls.Add(pnlB3RightSummary)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1020, 564)
        pnlBody.TabIndex = 1

        pnlB3GuestInputs.BorderRadius = 18
        pnlB3GuestInputs.Controls.Add(lblB3GuestHeader)
        pnlB3GuestInputs.Controls.Add(lblB3Subtitle)
        pnlB3GuestInputs.Controls.Add(pnlB3Divider)
        pnlB3GuestInputs.Controls.Add(lblB3GivenName)
        pnlB3GuestInputs.Controls.Add(txtB3GivenName)
        pnlB3GuestInputs.Controls.Add(lblB3Surname)
        pnlB3GuestInputs.Controls.Add(txtB3Surname)
        pnlB3GuestInputs.Controls.Add(lblB3Age)
        pnlB3GuestInputs.Controls.Add(txtB3Age)
        pnlB3GuestInputs.Controls.Add(lblB3AgeGroup)
        pnlB3GuestInputs.Controls.Add(cmbB3AgeGroup)
        pnlB3GuestInputs.Controls.Add(lblB3Gender)
        pnlB3GuestInputs.Controls.Add(cmbB3Gender)
        pnlB3GuestInputs.Controls.Add(lblB3Disabled)
        pnlB3GuestInputs.Controls.Add(rbB3DisabledYes)
        pnlB3GuestInputs.Controls.Add(rbB3DisabledNo)
        pnlB3GuestInputs.Controls.Add(btnB3Back)
        pnlB3GuestInputs.Controls.Add(btnB3Next)
        pnlB3GuestInputs.FillColor = Color.White
        pnlB3GuestInputs.Location = New Point(35, 25)
        pnlB3GuestInputs.Name = "pnlB3GuestInputs"
        pnlB3GuestInputs.ShadowDecoration.BorderRadius = 18
        pnlB3GuestInputs.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB3GuestInputs.ShadowDecoration.Enabled = True
        pnlB3GuestInputs.Size = New Size(620, 510)
        pnlB3GuestInputs.TabIndex = 0

        lblB3GuestHeader.AutoSize = True
        lblB3GuestHeader.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblB3GuestHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB3GuestHeader.Location = New Point(30, 25)
        lblB3GuestHeader.Name = "lblB3GuestHeader"
        lblB3GuestHeader.Size = New Size(245, 28)
        lblB3GuestHeader.TabIndex = 0
        lblB3GuestHeader.Text = "Guest Passenger Details"

        lblB3Subtitle.AutoSize = True
        lblB3Subtitle.Font = New Font("Segoe UI", 9.5F)
        lblB3Subtitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3Subtitle.Location = New Point(32, 58)
        lblB3Subtitle.Name = "lblB3Subtitle"
        lblB3Subtitle.Size = New Size(420, 17)
        lblB3Subtitle.TabIndex = 1
        lblB3Subtitle.Text = "Senior citizens (60+) and PWD passengers automatically receive a 20% discount."

        pnlB3Divider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB3Divider.Location = New Point(30, 85)
        pnlB3Divider.Name = "pnlB3Divider"
        pnlB3Divider.Size = New Size(560, 1)
        pnlB3Divider.TabIndex = 2

        lblB3GivenName.AutoSize = True
        lblB3GivenName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3GivenName.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3GivenName.Location = New Point(30, 105)
        lblB3GivenName.Name = "lblB3GivenName"
        lblB3GivenName.Size = New Size(85, 19)
        lblB3GivenName.TabIndex = 3
        lblB3GivenName.Text = "Given Name"

        txtB3GivenName.BorderRadius = 10
        txtB3GivenName.Cursor = Cursors.IBeam
        txtB3GivenName.DefaultText = ""
        txtB3GivenName.Font = New Font("Segoe UI", 10.0F)
        txtB3GivenName.Location = New Point(30, 130)
        txtB3GivenName.Name = "txtB3GivenName"
        txtB3GivenName.PlaceholderText = "First name"
        txtB3GivenName.Size = New Size(265, 42)
        txtB3GivenName.TabIndex = 4

        lblB3Surname.AutoSize = True
        lblB3Surname.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3Surname.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3Surname.Location = New Point(325, 105)
        lblB3Surname.Name = "lblB3Surname"
        lblB3Surname.Size = New Size(65, 19)
        lblB3Surname.TabIndex = 5
        lblB3Surname.Text = "Surname"

        txtB3Surname.BorderRadius = 10
        txtB3Surname.Cursor = Cursors.IBeam
        txtB3Surname.DefaultText = ""
        txtB3Surname.Font = New Font("Segoe UI", 10.0F)
        txtB3Surname.Location = New Point(325, 130)
        txtB3Surname.Name = "txtB3Surname"
        txtB3Surname.PlaceholderText = "Last name"
        txtB3Surname.Size = New Size(265, 42)
        txtB3Surname.TabIndex = 6

        lblB3Age.AutoSize = True
        lblB3Age.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3Age.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3Age.Location = New Point(30, 195)
        lblB3Age.Name = "lblB3Age"
        lblB3Age.Size = New Size(35, 19)
        lblB3Age.TabIndex = 7
        lblB3Age.Text = "Age"

        txtB3Age.BorderRadius = 10
        txtB3Age.Cursor = Cursors.IBeam
        txtB3Age.DefaultText = "25"
        txtB3Age.Font = New Font("Segoe UI", 10.0F)
        txtB3Age.Location = New Point(30, 220)
        txtB3Age.Name = "txtB3Age"
        txtB3Age.Size = New Size(265, 42)
        txtB3Age.TabIndex = 8

        lblB3AgeGroup.AutoSize = True
        lblB3AgeGroup.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3AgeGroup.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3AgeGroup.Location = New Point(325, 195)
        lblB3AgeGroup.Name = "lblB3AgeGroup"
        lblB3AgeGroup.Size = New Size(80, 19)
        lblB3AgeGroup.TabIndex = 9
        lblB3AgeGroup.Text = "Age Group"

        cmbB3AgeGroup.BorderRadius = 10
        cmbB3AgeGroup.Font = New Font("Segoe UI", 10.0F)
        cmbB3AgeGroup.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB3AgeGroup.Items.AddRange(New Object() {"Adult", "Senior Citizen (60+)"})
        cmbB3AgeGroup.Location = New Point(325, 220)
        cmbB3AgeGroup.Name = "cmbB3AgeGroup"
        cmbB3AgeGroup.Size = New Size(265, 42)
        cmbB3AgeGroup.StartIndex = 0
        cmbB3AgeGroup.TabIndex = 10

        lblB3Gender.AutoSize = True
        lblB3Gender.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3Gender.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3Gender.Location = New Point(30, 285)
        lblB3Gender.Name = "lblB3Gender"
        lblB3Gender.Size = New Size(55, 19)
        lblB3Gender.TabIndex = 11
        lblB3Gender.Text = "Gender"

        cmbB3Gender.BorderRadius = 10
        cmbB3Gender.Font = New Font("Segoe UI", 10.0F)
        cmbB3Gender.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB3Gender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        cmbB3Gender.Location = New Point(30, 310)
        cmbB3Gender.Name = "cmbB3Gender"
        cmbB3Gender.Size = New Size(265, 42)
        cmbB3Gender.StartIndex = 0
        cmbB3Gender.TabIndex = 12

        lblB3Disabled.AutoSize = True
        lblB3Disabled.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblB3Disabled.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3Disabled.Location = New Point(325, 285)
        lblB3Disabled.Name = "lblB3Disabled"
        lblB3Disabled.Size = New Size(110, 19)
        lblB3Disabled.TabIndex = 13
        lblB3Disabled.Text = "Person with Disability (PWD)?"

        rbB3DisabledYes.AutoSize = True
        rbB3DisabledYes.CheckedState.BorderColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB3DisabledYes.CheckedState.BorderThickness = 2
        rbB3DisabledYes.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB3DisabledYes.CheckedState.InnerColor = Color.White
        rbB3DisabledYes.Font = New Font("Segoe UI", 10.0F)
        rbB3DisabledYes.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        rbB3DisabledYes.Location = New Point(330, 318)
        rbB3DisabledYes.Name = "rbB3DisabledYes"
        rbB3DisabledYes.Size = New Size(115, 23)
        rbB3DisabledYes.TabIndex = 14
        rbB3DisabledYes.Text = "Yes (20% off)"

        rbB3DisabledNo.AutoSize = True
        rbB3DisabledNo.Checked = True
        rbB3DisabledNo.CheckedState.BorderColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB3DisabledNo.CheckedState.BorderThickness = 2
        rbB3DisabledNo.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB3DisabledNo.CheckedState.InnerColor = Color.White
        rbB3DisabledNo.Font = New Font("Segoe UI", 10.0F)
        rbB3DisabledNo.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        rbB3DisabledNo.Location = New Point(470, 318)
        rbB3DisabledNo.Name = "rbB3DisabledNo"
        rbB3DisabledNo.Size = New Size(45, 23)
        rbB3DisabledNo.TabIndex = 15
        rbB3DisabledNo.TabStop = True
        rbB3DisabledNo.Text = "No"

        btnB3Back.Animated = True
        btnB3Back.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB3Back.BorderRadius = 12
        btnB3Back.BorderThickness = 1
        btnB3Back.Cursor = Cursors.Hand
        btnB3Back.FillColor = Color.Transparent
        btnB3Back.Font = New Font("Segoe UI", 10.0F)
        btnB3Back.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB3Back.Location = New Point(30, 440)
        btnB3Back.Name = "btnB3Back"
        btnB3Back.Size = New Size(140, 45)
        btnB3Back.TabIndex = 16
        btnB3Back.Text = "← Back"

        btnB3Next.Animated = True
        btnB3Next.BorderRadius = 12
        btnB3Next.Cursor = Cursors.Hand
        btnB3Next.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnB3Next.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnB3Next.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnB3Next.Location = New Point(410, 440)
        btnB3Next.Name = "btnB3Next"
        btnB3Next.Size = New Size(180, 45)
        btnB3Next.TabIndex = 17
        btnB3Next.Text = "Next: Concessions →"

        pnlB3RightSummary.BorderRadius = 18
        pnlB3RightSummary.Controls.Add(lblB3SummaryHeader)
        pnlB3RightSummary.Controls.Add(lblB3SummaryDate)
        pnlB3RightSummary.Controls.Add(lblB3SummaryRoute)
        pnlB3RightSummary.Controls.Add(lblB3SummaryTime)
        pnlB3RightSummary.Controls.Add(pnlB3SumDivider)
        pnlB3RightSummary.Controls.Add(lblB3SummaryTotalLabel)
        pnlB3RightSummary.Controls.Add(lblB3SummaryTotalAmount)
        pnlB3RightSummary.FillColor = Color.White
        pnlB3RightSummary.Location = New Point(680, 25)
        pnlB3RightSummary.Name = "pnlB3RightSummary"
        pnlB3RightSummary.ShadowDecoration.BorderRadius = 18
        pnlB3RightSummary.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB3RightSummary.ShadowDecoration.Enabled = True
        pnlB3RightSummary.Size = New Size(305, 510)
        pnlB3RightSummary.TabIndex = 1

        lblB3SummaryHeader.AutoSize = True
        lblB3SummaryHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblB3SummaryHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB3SummaryHeader.Location = New Point(25, 25)
        lblB3SummaryHeader.Name = "lblB3SummaryHeader"
        lblB3SummaryHeader.Size = New Size(130, 25)
        lblB3SummaryHeader.TabIndex = 0
        lblB3SummaryHeader.Text = "Trip Summary"

        lblB3SummaryDate.AutoSize = True
        lblB3SummaryDate.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB3SummaryDate.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblB3SummaryDate.Location = New Point(25, 75)
        lblB3SummaryDate.Name = "lblB3SummaryDate"
        lblB3SummaryDate.Size = New Size(120, 19)
        lblB3SummaryDate.TabIndex = 1
        lblB3SummaryDate.Text = "October 24, 2026"

        lblB3SummaryRoute.AutoSize = True
        lblB3SummaryRoute.Font = New Font("Segoe UI", 10.0F)
        lblB3SummaryRoute.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3SummaryRoute.Location = New Point(25, 110)
        lblB3SummaryRoute.Name = "lblB3SummaryRoute"
        lblB3SummaryRoute.Size = New Size(160, 19)
        lblB3SummaryRoute.TabIndex = 2
        lblB3SummaryRoute.Text = "Manila (MNL) → Cebu (CEB)"

        lblB3SummaryTime.AutoSize = True
        lblB3SummaryTime.Font = New Font("Segoe UI", 9.5F)
        lblB3SummaryTime.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3SummaryTime.Location = New Point(25, 145)
        lblB3SummaryTime.Name = "lblB3SummaryTime"
        lblB3SummaryTime.Size = New Size(140, 17)
        lblB3SummaryTime.TabIndex = 3
        lblB3SummaryTime.Text = "08:00 AM (1h 20m)"

        pnlB3SumDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB3SumDivider.Location = New Point(25, 360)
        pnlB3SumDivider.Name = "pnlB3SumDivider"
        pnlB3SumDivider.Size = New Size(255, 1)
        pnlB3SumDivider.TabIndex = 4

        lblB3SummaryTotalLabel.AutoSize = True
        lblB3SummaryTotalLabel.Font = New Font("Segoe UI", 10.0F)
        lblB3SummaryTotalLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB3SummaryTotalLabel.Location = New Point(25, 385)
        lblB3SummaryTotalLabel.Name = "lblB3SummaryTotalLabel"
        lblB3SummaryTotalLabel.Size = New Size(100, 19)
        lblB3SummaryTotalLabel.TabIndex = 5
        lblB3SummaryTotalLabel.Text = "Estimated Total"

        lblB3SummaryTotalAmount.AutoSize = True
        lblB3SummaryTotalAmount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblB3SummaryTotalAmount.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblB3SummaryTotalAmount.Location = New Point(20, 415)
        lblB3SummaryTotalAmount.Name = "lblB3SummaryTotalAmount"
        lblB3SummaryTotalAmount.Size = New Size(185, 37)
        lblB3SummaryTotalAmount.TabIndex = 6
        lblB3SummaryTotalAmount.Text = "PHP 3,690.00"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1020, 620)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingStep3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Guest Details"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlB3GuestInputs.ResumeLayout(False)
        pnlB3GuestInputs.PerformLayout()
        pnlB3RightSummary.ResumeLayout(False)
        pnlB3RightSummary.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlB3GuestInputs As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB3GuestHeader As Label
    Friend WithEvents lblB3Subtitle As Label
    Friend WithEvents pnlB3Divider As Panel
    Friend WithEvents lblB3GivenName As Label
    Friend WithEvents txtB3GivenName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblB3Surname As Label
    Friend WithEvents txtB3Surname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblB3Age As Label
    Friend WithEvents txtB3Age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblB3AgeGroup As Label
    Friend WithEvents cmbB3AgeGroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblB3Gender As Label
    Friend WithEvents cmbB3Gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblB3Disabled As Label
    Friend WithEvents rbB3DisabledYes As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbB3DisabledNo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnB3Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnB3Next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlB3RightSummary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB3SummaryHeader As Label
    Friend WithEvents lblB3SummaryDate As Label
    Friend WithEvents lblB3SummaryRoute As Label
    Friend WithEvents lblB3SummaryTime As Label
    Friend WithEvents pnlB3SumDivider As Panel
    Friend WithEvents lblB3SummaryTotalLabel As Label
    Friend WithEvents lblB3SummaryTotalAmount As Label

End Class
