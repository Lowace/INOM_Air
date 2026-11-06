<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingStep5
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
        pnlB5Left = New Guna.UI2.WinForms.Guna2Panel()
        lblB5PlaneArrangement = New Label()
        lblB5Subtitle = New Label()
        pnlB5Divider = New Panel()
        lblB5SeatLabel = New Label()
        txtB5SeatDisplay = New Guna.UI2.WinForms.Guna2TextBox()
        btnB5ChooseSeat = New Guna.UI2.WinForms.Guna2Button()
        lblB5MealsTitle = New Label()
        cmbB5Meals = New Guna.UI2.WinForms.Guna2ComboBox()
        btnB5ViewMeals = New Guna.UI2.WinForms.Guna2Button()
        lblB5BaggageTitle = New Label()
        cmbB5CheckedKg = New Guna.UI2.WinForms.Guna2ComboBox()
        lblB5CarryOn = New Label()
        txtB5CarryOnKg = New Guna.UI2.WinForms.Guna2TextBox()
        btnB5PriceList = New Guna.UI2.WinForms.Guna2Button()
        btnB5Back = New Guna.UI2.WinForms.Guna2Button()
        btnB5Next = New Guna.UI2.WinForms.Guna2Button()
        pnlB5RightSummary = New Guna.UI2.WinForms.Guna2Panel()
        lblB5SummaryHeader = New Label()
        lblB5SummaryDate = New Label()
        lblB5SummaryRoute = New Label()
        lblB5SummaryTime = New Label()
        pnlB5SumDivider = New Panel()
        lblB5SummaryTotalLabel = New Label()
        lblB5SummaryTotalAmount = New Label()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlB5Left.SuspendLayout()
        pnlB5RightSummary.SuspendLayout()
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
        lblStepTitle.Text = "CONCESSIONS & SEATS — Step 4 of 6"

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
        pnlBody.Controls.Add(pnlB5Left)
        pnlBody.Controls.Add(pnlB5RightSummary)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1020, 584)
        pnlBody.TabIndex = 1

        pnlB5Left.BorderRadius = 18
        pnlB5Left.Controls.Add(lblB5PlaneArrangement)
        pnlB5Left.Controls.Add(lblB5Subtitle)
        pnlB5Left.Controls.Add(pnlB5Divider)
        pnlB5Left.Controls.Add(lblB5SeatLabel)
        pnlB5Left.Controls.Add(txtB5SeatDisplay)
        pnlB5Left.Controls.Add(btnB5ChooseSeat)
        pnlB5Left.Controls.Add(lblB5MealsTitle)
        pnlB5Left.Controls.Add(cmbB5Meals)
        pnlB5Left.Controls.Add(btnB5ViewMeals)
        pnlB5Left.Controls.Add(lblB5BaggageTitle)
        pnlB5Left.Controls.Add(cmbB5CheckedKg)
        pnlB5Left.Controls.Add(lblB5CarryOn)
        pnlB5Left.Controls.Add(txtB5CarryOnKg)
        pnlB5Left.Controls.Add(btnB5PriceList)
        pnlB5Left.Controls.Add(btnB5Back)
        pnlB5Left.Controls.Add(btnB5Next)
        pnlB5Left.FillColor = Color.White
        pnlB5Left.Location = New Point(35, 25)
        pnlB5Left.Name = "pnlB5Left"
        pnlB5Left.ShadowDecoration.BorderRadius = 18
        pnlB5Left.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB5Left.ShadowDecoration.Enabled = True
        pnlB5Left.Size = New Size(620, 530)
        pnlB5Left.TabIndex = 0

        lblB5PlaneArrangement.AutoSize = True
        lblB5PlaneArrangement.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblB5PlaneArrangement.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB5PlaneArrangement.Location = New Point(30, 20)
        lblB5PlaneArrangement.Name = "lblB5PlaneArrangement"
        lblB5PlaneArrangement.Size = New Size(265, 28)
        lblB5PlaneArrangement.TabIndex = 0
        lblB5PlaneArrangement.Text = "Concessions & Seat Selection"

        lblB5Subtitle.AutoSize = True
        lblB5Subtitle.Font = New Font("Segoe UI", 9.5F)
        lblB5Subtitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5Subtitle.Location = New Point(32, 52)
        lblB5Subtitle.Name = "lblB5Subtitle"
        lblB5Subtitle.Size = New Size(400, 17)
        lblB5Subtitle.TabIndex = 1
        lblB5Subtitle.Text = "Customize your flight with your preferred seat, meals, and baggage allowance."

        pnlB5Divider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB5Divider.Location = New Point(30, 78)
        pnlB5Divider.Name = "pnlB5Divider"
        pnlB5Divider.Size = New Size(560, 1)
        pnlB5Divider.TabIndex = 2

        lblB5SeatLabel.AutoSize = True
        lblB5SeatLabel.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB5SeatLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5SeatLabel.Location = New Point(30, 95)
        lblB5SeatLabel.Name = "lblB5SeatLabel"
        lblB5SeatLabel.Size = New Size(100, 19)
        lblB5SeatLabel.TabIndex = 3
        lblB5SeatLabel.Text = "Assigned Seat"

        txtB5SeatDisplay.BorderRadius = 10
        txtB5SeatDisplay.Cursor = Cursors.IBeam
        txtB5SeatDisplay.DefaultText = "Seat 1A"
        txtB5SeatDisplay.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        txtB5SeatDisplay.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        txtB5SeatDisplay.Location = New Point(30, 120)
        txtB5SeatDisplay.Name = "txtB5SeatDisplay"
        txtB5SeatDisplay.ReadOnly = True
        txtB5SeatDisplay.Size = New Size(240, 42)
        txtB5SeatDisplay.TabIndex = 4

        btnB5ChooseSeat.Animated = True
        btnB5ChooseSeat.BorderRadius = 10
        btnB5ChooseSeat.Cursor = Cursors.Hand
        btnB5ChooseSeat.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnB5ChooseSeat.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnB5ChooseSeat.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnB5ChooseSeat.Location = New Point(285, 120)
        btnB5ChooseSeat.Name = "btnB5ChooseSeat"
        btnB5ChooseSeat.Size = New Size(170, 42)
        btnB5ChooseSeat.TabIndex = 5
        btnB5ChooseSeat.Text = "Select Seat Map 💺"

        lblB5MealsTitle.AutoSize = True
        lblB5MealsTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB5MealsTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5MealsTitle.Location = New Point(30, 185)
        lblB5MealsTitle.Name = "lblB5MealsTitle"
        lblB5MealsTitle.Size = New Size(130, 19)
        lblB5MealsTitle.TabIndex = 6
        lblB5MealsTitle.Text = "In-Flight Meal Plan"

        cmbB5Meals.BorderRadius = 10
        cmbB5Meals.Font = New Font("Segoe UI", 10.0F)
        cmbB5Meals.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB5Meals.Items.AddRange(New Object() {"Standard Meal (Chicken Adobo)", "Vegetarian Delight (Tofu)", "Kids Fun Meal", "No In-Flight Meal"})
        cmbB5Meals.Location = New Point(30, 210)
        cmbB5Meals.Name = "cmbB5Meals"
        cmbB5Meals.Size = New Size(360, 42)
        cmbB5Meals.StartIndex = 0
        cmbB5Meals.TabIndex = 7

        btnB5ViewMeals.Animated = True
        btnB5ViewMeals.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB5ViewMeals.BorderRadius = 10
        btnB5ViewMeals.BorderThickness = 1
        btnB5ViewMeals.Cursor = Cursors.Hand
        btnB5ViewMeals.FillColor = Color.Transparent
        btnB5ViewMeals.Font = New Font("Segoe UI", 9.5F)
        btnB5ViewMeals.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB5ViewMeals.Location = New Point(405, 210)
        btnB5ViewMeals.Name = "btnB5ViewMeals"
        btnB5ViewMeals.Size = New Size(125, 42)
        btnB5ViewMeals.TabIndex = 8
        btnB5ViewMeals.Text = "Meal Info"

        lblB5BaggageTitle.AutoSize = True
        lblB5BaggageTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB5BaggageTitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5BaggageTitle.Location = New Point(30, 275)
        lblB5BaggageTitle.Name = "lblB5BaggageTitle"
        lblB5BaggageTitle.Size = New Size(175, 19)
        lblB5BaggageTitle.TabIndex = 9
        lblB5BaggageTitle.Text = "Checked Baggage Add-on"

        cmbB5CheckedKg.BorderRadius = 10
        cmbB5CheckedKg.Font = New Font("Segoe UI", 10.0F)
        cmbB5CheckedKg.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        cmbB5CheckedKg.Items.AddRange(New Object() {"No Extra Checked Baggage (0kg)", "10kg Checked (Free included)", "20kg Checked (+PHP 500.00)", "30kg Checked (+PHP 1,000.00)", "40kg Checked (+PHP 1,500.00)"})
        cmbB5CheckedKg.Location = New Point(30, 300)
        cmbB5CheckedKg.Name = "cmbB5CheckedKg"
        cmbB5CheckedKg.Size = New Size(360, 42)
        cmbB5CheckedKg.StartIndex = 0
        cmbB5CheckedKg.TabIndex = 10

        lblB5CarryOn.AutoSize = True
        lblB5CarryOn.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB5CarryOn.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5CarryOn.Location = New Point(30, 365)
        lblB5CarryOn.Name = "lblB5CarryOn"
        lblB5CarryOn.Size = New Size(125, 19)
        lblB5CarryOn.TabIndex = 11
        lblB5CarryOn.Text = "Carry-on Baggage"

        txtB5CarryOnKg.BorderRadius = 10
        txtB5CarryOnKg.Cursor = Cursors.IBeam
        txtB5CarryOnKg.DefaultText = "7kg (Free Included)"
        txtB5CarryOnKg.Font = New Font("Segoe UI", 10.0F)
        txtB5CarryOnKg.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        txtB5CarryOnKg.Location = New Point(30, 390)
        txtB5CarryOnKg.Name = "txtB5CarryOnKg"
        txtB5CarryOnKg.ReadOnly = True
        txtB5CarryOnKg.Size = New Size(240, 42)
        txtB5CarryOnKg.TabIndex = 12

        btnB5PriceList.Animated = True
        btnB5PriceList.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB5PriceList.BorderRadius = 10
        btnB5PriceList.BorderThickness = 1
        btnB5PriceList.Cursor = Cursors.Hand
        btnB5PriceList.FillColor = Color.Transparent
        btnB5PriceList.Font = New Font("Segoe UI", 9.5F)
        btnB5PriceList.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB5PriceList.Location = New Point(285, 390)
        btnB5PriceList.Name = "btnB5PriceList"
        btnB5PriceList.Size = New Size(125, 42)
        btnB5PriceList.TabIndex = 13
        btnB5PriceList.Text = "Rates Matrix"

        btnB5Back.Animated = True
        btnB5Back.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB5Back.BorderRadius = 12
        btnB5Back.BorderThickness = 1
        btnB5Back.Cursor = Cursors.Hand
        btnB5Back.FillColor = Color.Transparent
        btnB5Back.Font = New Font("Segoe UI", 10.0F)
        btnB5Back.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB5Back.Location = New Point(30, 465)
        btnB5Back.Name = "btnB5Back"
        btnB5Back.Size = New Size(140, 45)
        btnB5Back.TabIndex = 14
        btnB5Back.Text = "← Back"

        btnB5Next.Animated = True
        btnB5Next.BorderRadius = 12
        btnB5Next.Cursor = Cursors.Hand
        btnB5Next.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnB5Next.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnB5Next.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnB5Next.Location = New Point(400, 465)
        btnB5Next.Name = "btnB5Next"
        btnB5Next.Size = New Size(190, 45)
        btnB5Next.TabIndex = 15
        btnB5Next.Text = "Next: Refundability →"

        pnlB5RightSummary.BorderRadius = 18
        pnlB5RightSummary.Controls.Add(lblB5SummaryHeader)
        pnlB5RightSummary.Controls.Add(lblB5SummaryDate)
        pnlB5RightSummary.Controls.Add(lblB5SummaryRoute)
        pnlB5RightSummary.Controls.Add(lblB5SummaryTime)
        pnlB5RightSummary.Controls.Add(pnlB5SumDivider)
        pnlB5RightSummary.Controls.Add(lblB5SummaryTotalLabel)
        pnlB5RightSummary.Controls.Add(lblB5SummaryTotalAmount)
        pnlB5RightSummary.FillColor = Color.White
        pnlB5RightSummary.Location = New Point(680, 25)
        pnlB5RightSummary.Name = "pnlB5RightSummary"
        pnlB5RightSummary.ShadowDecoration.BorderRadius = 18
        pnlB5RightSummary.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB5RightSummary.ShadowDecoration.Enabled = True
        pnlB5RightSummary.Size = New Size(305, 530)
        pnlB5RightSummary.TabIndex = 1

        lblB5SummaryHeader.AutoSize = True
        lblB5SummaryHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblB5SummaryHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB5SummaryHeader.Location = New Point(25, 25)
        lblB5SummaryHeader.Name = "lblB5SummaryHeader"
        lblB5SummaryHeader.Size = New Size(130, 25)
        lblB5SummaryHeader.TabIndex = 0
        lblB5SummaryHeader.Text = "Trip Summary"

        lblB5SummaryDate.AutoSize = True
        lblB5SummaryDate.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB5SummaryDate.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblB5SummaryDate.Location = New Point(25, 75)
        lblB5SummaryDate.Name = "lblB5SummaryDate"
        lblB5SummaryDate.Size = New Size(120, 19)
        lblB5SummaryDate.TabIndex = 1
        lblB5SummaryDate.Text = "October 24, 2026"

        lblB5SummaryRoute.AutoSize = True
        lblB5SummaryRoute.Font = New Font("Segoe UI", 10.0F)
        lblB5SummaryRoute.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5SummaryRoute.Location = New Point(25, 110)
        lblB5SummaryRoute.Name = "lblB5SummaryRoute"
        lblB5SummaryRoute.Size = New Size(160, 19)
        lblB5SummaryRoute.TabIndex = 2
        lblB5SummaryRoute.Text = "Manila (MNL) → Cebu (CEB)"

        lblB5SummaryTime.AutoSize = True
        lblB5SummaryTime.Font = New Font("Segoe UI", 9.5F)
        lblB5SummaryTime.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5SummaryTime.Location = New Point(25, 145)
        lblB5SummaryTime.Name = "lblB5SummaryTime"
        lblB5SummaryTime.Size = New Size(140, 17)
        lblB5SummaryTime.TabIndex = 3
        lblB5SummaryTime.Text = "08:00 AM (1h 20m)"

        pnlB5SumDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB5SumDivider.Location = New Point(25, 380)
        pnlB5SumDivider.Name = "pnlB5SumDivider"
        pnlB5SumDivider.Size = New Size(255, 1)
        pnlB5SumDivider.TabIndex = 4

        lblB5SummaryTotalLabel.AutoSize = True
        lblB5SummaryTotalLabel.Font = New Font("Segoe UI", 10.0F)
        lblB5SummaryTotalLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB5SummaryTotalLabel.Location = New Point(25, 405)
        lblB5SummaryTotalLabel.Name = "lblB5SummaryTotalLabel"
        lblB5SummaryTotalLabel.Size = New Size(100, 19)
        lblB5SummaryTotalLabel.TabIndex = 5
        lblB5SummaryTotalLabel.Text = "Estimated Total"

        lblB5SummaryTotalAmount.AutoSize = True
        lblB5SummaryTotalAmount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblB5SummaryTotalAmount.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblB5SummaryTotalAmount.Location = New Point(20, 435)
        lblB5SummaryTotalAmount.Name = "lblB5SummaryTotalAmount"
        lblB5SummaryTotalAmount.Size = New Size(185, 37)
        lblB5SummaryTotalAmount.TabIndex = 6
        lblB5SummaryTotalAmount.Text = "PHP 3,690.00"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1020, 640)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingStep5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Concessions"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlB5Left.ResumeLayout(False)
        pnlB5Left.PerformLayout()
        pnlB5RightSummary.ResumeLayout(False)
        pnlB5RightSummary.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlB5Left As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB5PlaneArrangement As Label
    Friend WithEvents lblB5Subtitle As Label
    Friend WithEvents pnlB5Divider As Panel
    Friend WithEvents lblB5SeatLabel As Label
    Friend WithEvents txtB5SeatDisplay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnB5ChooseSeat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblB5MealsTitle As Label
    Friend WithEvents cmbB5Meals As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnB5ViewMeals As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblB5BaggageTitle As Label
    Friend WithEvents cmbB5CheckedKg As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblB5CarryOn As Label
    Friend WithEvents txtB5CarryOnKg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnB5PriceList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnB5Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnB5Next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlB5RightSummary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB5SummaryHeader As Label
    Friend WithEvents lblB5SummaryDate As Label
    Friend WithEvents lblB5SummaryRoute As Label
    Friend WithEvents lblB5SummaryTime As Label
    Friend WithEvents pnlB5SumDivider As Panel
    Friend WithEvents lblB5SummaryTotalLabel As Label
    Friend WithEvents lblB5SummaryTotalAmount As Label

End Class
