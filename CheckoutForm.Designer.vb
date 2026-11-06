<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckoutForm
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
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        lblPlaneLogo = New Label()
        lblBrandHeader = New Label()
        lblStepTitle = New Label()
        btnCloseX = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlBody = New Guna.UI2.WinForms.Guna2Panel()
        pnlBreakdownModal = New Guna.UI2.WinForms.Guna2Panel()
        lblModalHeader = New Label()
        lblModBaseFare = New Label()
        lblModAdminFee = New Label()
        lblModFuel = New Label()
        lblModVAT = New Label()
        lblModTerminalFee = New Label()
        lblModAddons = New Label()
        lblModDiscount = New Label()
        pnlModDivider = New Panel()
        lblModTotal = New Label()
        btnModalClose = New Guna.UI2.WinForms.Guna2Button()
        pnlCheckoutLeft = New Guna.UI2.WinForms.Guna2Panel()
        lblCheckoutTitle = New Label()
        lblCheckoutRoute = New Label()
        lblCheckoutStats = New Label()
        lblCheckoutPassenger = New Label()
        pnlDivider1 = New Panel()
        lblCkBaseFare = New Label()
        lblCkTaxes = New Label()
        lblCkAddons = New Label()
        lblCkDiscount = New Label()
        pnlDivider2 = New Panel()
        lblCkTotal = New Label()
        btnShowMoreDeets = New Guna.UI2.WinForms.Guna2Button()
        pnlCheckoutRight = New Guna.UI2.WinForms.Guna2Panel()
        lblReadyTitle = New Label()
        lblSecureBadge = New Label()
        lblRightTotalLabel = New Label()
        lblRightTotal = New Label()
        btnContinueToPayment = New Guna.UI2.WinForms.Guna2Button()
        btnCheckoutBack = New Guna.UI2.WinForms.Guna2Button()
        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlBreakdownModal.SuspendLayout()
        pnlCheckoutLeft.SuspendLayout()
        pnlCheckoutRight.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 24
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Controls.Add(lblPlaneLogo)
        pnlTopBar.Controls.Add(lblBrandHeader)
        pnlTopBar.Controls.Add(lblStepTitle)
        pnlTopBar.Controls.Add(btnCloseX)
        pnlTopBar.CustomizableEdges = CustomizableEdges18
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Margin = New Padding(4, 5, 4, 5)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.ShadowDecoration.CustomizableEdges = CustomizableEdges19
        pnlTopBar.Size = New Size(1500, 93)
        pnlTopBar.TabIndex = 0
        ' 
        ' lblPlaneLogo
        ' 
        lblPlaneLogo.Font = New Font("Segoe UI Emoji", 18F)
        lblPlaneLogo.ForeColor = Color.White
        lblPlaneLogo.Location = New Point(21, 17)
        lblPlaneLogo.Margin = New Padding(4, 0, 4, 0)
        lblPlaneLogo.Name = "lblPlaneLogo"
        lblPlaneLogo.Size = New Size(51, 60)
        lblPlaneLogo.TabIndex = 0
        lblPlaneLogo.Text = "✈"
        lblPlaneLogo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBrandHeader
        ' 
        lblBrandHeader.AutoSize = True
        lblBrandHeader.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblBrandHeader.ForeColor = Color.White
        lblBrandHeader.Location = New Point(83, 17)
        lblBrandHeader.Margin = New Padding(4, 0, 4, 0)
        lblBrandHeader.Name = "lblBrandHeader"
        lblBrandHeader.Size = New Size(111, 30)
        lblBrandHeader.TabIndex = 1
        lblBrandHeader.Text = "INOM Air"
        ' 
        ' lblStepTitle
        ' 
        lblStepTitle.AutoSize = True
        lblStepTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblStepTitle.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        lblStepTitle.Location = New Point(83, 50)
        lblStepTitle.Margin = New Padding(4, 0, 4, 0)
        lblStepTitle.Name = "lblStepTitle"
        lblStepTitle.Size = New Size(376, 30)
        lblStepTitle.TabIndex = 2
        lblStepTitle.Text = "CHECKOUT SUMMARY — Step 6 of 6"
        ' 
        ' btnCloseX
        ' 
        btnCloseX.Animated = True
        btnCloseX.BackColor = Color.Transparent
        btnCloseX.Cursor = Cursors.Hand
        btnCloseX.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnCloseX.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCloseX.ForeColor = Color.White
        btnCloseX.Location = New Point(1436, 22)
        btnCloseX.Margin = New Padding(4, 5, 4, 5)
        btnCloseX.Name = "btnCloseX"
        btnCloseX.ShadowDecoration.CustomizableEdges = CustomizableEdges17
        btnCloseX.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnCloseX.Size = New Size(43, 50)
        btnCloseX.TabIndex = 3
        btnCloseX.Text = "✕"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.Controls.Add(pnlBreakdownModal)
        pnlBody.Controls.Add(pnlCheckoutLeft)
        pnlBody.Controls.Add(pnlCheckoutRight)
        pnlBody.CustomizableEdges = CustomizableEdges15
        pnlBody.Dock = DockStyle.Fill
        pnlBody.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlBody.Location = New Point(0, 93)
        pnlBody.Margin = New Padding(4, 5, 4, 5)
        pnlBody.Name = "pnlBody"
        pnlBody.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        pnlBody.Size = New Size(1500, 990)
        pnlBody.TabIndex = 1
        ' 
        ' pnlBreakdownModal
        ' 
        pnlBreakdownModal.BackColor = Color.Transparent
        pnlBreakdownModal.BorderRadius = 18
        pnlBreakdownModal.Controls.Add(lblModalHeader)
        pnlBreakdownModal.Controls.Add(lblModBaseFare)
        pnlBreakdownModal.Controls.Add(lblModAdminFee)
        pnlBreakdownModal.Controls.Add(lblModFuel)
        pnlBreakdownModal.Controls.Add(lblModVAT)
        pnlBreakdownModal.Controls.Add(lblModTerminalFee)
        pnlBreakdownModal.Controls.Add(lblModAddons)
        pnlBreakdownModal.Controls.Add(lblModDiscount)
        pnlBreakdownModal.Controls.Add(pnlModDivider)
        pnlBreakdownModal.Controls.Add(lblModTotal)
        pnlBreakdownModal.Controls.Add(btnModalClose)
        pnlBreakdownModal.CustomizableEdges = CustomizableEdges3
        pnlBreakdownModal.FillColor = Color.White
        pnlBreakdownModal.Location = New Point(300, 67)
        pnlBreakdownModal.Margin = New Padding(4, 5, 4, 5)
        pnlBreakdownModal.Name = "pnlBreakdownModal"
        pnlBreakdownModal.ShadowDecoration.BorderRadius = 18
        pnlBreakdownModal.ShadowDecoration.Color = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        pnlBreakdownModal.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlBreakdownModal.ShadowDecoration.Depth = 40
        pnlBreakdownModal.ShadowDecoration.Enabled = True
        pnlBreakdownModal.Size = New Size(900, 800)
        pnlBreakdownModal.TabIndex = 2
        pnlBreakdownModal.Visible = False
        ' 
        ' lblModalHeader
        ' 
        lblModalHeader.AutoSize = True
        lblModalHeader.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblModalHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblModalHeader.Location = New Point(43, 42)
        lblModalHeader.Margin = New Padding(4, 0, 4, 0)
        lblModalHeader.Name = "lblModalHeader"
        lblModalHeader.Size = New Size(346, 38)
        lblModalHeader.TabIndex = 0
        lblModalHeader.Text = "Detailed Fare Breakdown"
        ' 
        ' lblModBaseFare
        ' 
        lblModBaseFare.AutoSize = True
        lblModBaseFare.Font = New Font("Segoe UI", 10F)
        lblModBaseFare.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModBaseFare.Location = New Point(43, 117)
        lblModBaseFare.Margin = New Padding(4, 0, 4, 0)
        lblModBaseFare.Name = "lblModBaseFare"
        lblModBaseFare.Size = New Size(524, 28)
        lblModBaseFare.TabIndex = 1
        lblModBaseFare.Text = "Base fare                                                                PHP 3,000.00"
        ' 
        ' lblModAdminFee
        ' 
        lblModAdminFee.AutoSize = True
        lblModAdminFee.Font = New Font("Segoe UI", 10F)
        lblModAdminFee.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModAdminFee.Location = New Point(43, 175)
        lblModAdminFee.Margin = New Padding(4, 0, 4, 0)
        lblModAdminFee.Name = "lblModAdminFee"
        lblModAdminFee.Size = New Size(532, 28)
        lblModAdminFee.TabIndex = 2
        lblModAdminFee.Text = "• Administrative Fee                                                 PHP 100.00"
        ' 
        ' lblModFuel
        ' 
        lblModFuel.AutoSize = True
        lblModFuel.Font = New Font("Segoe UI", 10F)
        lblModFuel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModFuel.Location = New Point(43, 233)
        lblModFuel.Margin = New Padding(4, 0, 4, 0)
        lblModFuel.Name = "lblModFuel"
        lblModFuel.Size = New Size(519, 28)
        lblModFuel.TabIndex = 3
        lblModFuel.Text = "• Fuel Surcharge                                                     PHP 150.00"
        ' 
        ' lblModVAT
        ' 
        lblModVAT.AutoSize = True
        lblModVAT.Font = New Font("Segoe UI", 10F)
        lblModVAT.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModVAT.Location = New Point(43, 292)
        lblModVAT.Margin = New Padding(4, 0, 4, 0)
        lblModVAT.Name = "lblModVAT"
        lblModVAT.Size = New Size(521, 28)
        lblModVAT.TabIndex = 4
        lblModVAT.Text = "• Value Added Tax (VAT 12%)                                PHP 240.00"
        ' 
        ' lblModTerminalFee
        ' 
        lblModTerminalFee.AutoSize = True
        lblModTerminalFee.Font = New Font("Segoe UI", 10F)
        lblModTerminalFee.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModTerminalFee.Location = New Point(43, 350)
        lblModTerminalFee.Margin = New Padding(4, 0, 4, 0)
        lblModTerminalFee.Name = "lblModTerminalFee"
        lblModTerminalFee.Size = New Size(511, 28)
        lblModTerminalFee.TabIndex = 5
        lblModTerminalFee.Text = "• Domestic Passenger Terminal Fee                    PHP 200.00"
        ' 
        ' lblModAddons
        ' 
        lblModAddons.AutoSize = True
        lblModAddons.Font = New Font("Segoe UI", 10F)
        lblModAddons.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblModAddons.Location = New Point(43, 408)
        lblModAddons.Margin = New Padding(4, 0, 4, 0)
        lblModAddons.Name = "lblModAddons"
        lblModAddons.Size = New Size(493, 28)
        lblModAddons.TabIndex = 6
        lblModAddons.Text = "Add-ons (Baggage / Refundability)                    PHP 0.00"
        ' 
        ' lblModDiscount
        ' 
        lblModDiscount.AutoSize = True
        lblModDiscount.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblModDiscount.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblModDiscount.Location = New Point(43, 467)
        lblModDiscount.Margin = New Padding(4, 0, 4, 0)
        lblModDiscount.Name = "lblModDiscount"
        lblModDiscount.Size = New Size(565, 28)
        lblModDiscount.TabIndex = 7
        lblModDiscount.Text = "Discount (20% Senior/PWD)                               - PHP 0.00"
        ' 
        ' pnlModDivider
        ' 
        pnlModDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlModDivider.Location = New Point(43, 533)
        pnlModDivider.Margin = New Padding(4, 5, 4, 5)
        pnlModDivider.Name = "pnlModDivider"
        pnlModDivider.Size = New Size(814, 2)
        pnlModDivider.TabIndex = 8
        ' 
        ' lblModTotal
        ' 
        lblModTotal.AutoSize = True
        lblModTotal.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblModTotal.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblModTotal.Location = New Point(43, 567)
        lblModTotal.Margin = New Padding(4, 0, 4, 0)
        lblModTotal.Name = "lblModTotal"
        lblModTotal.Size = New Size(460, 36)
        lblModTotal.TabIndex = 9
        lblModTotal.Text = "Total Amount Payable: PHP 3,690.00"
        ' 
        ' btnModalClose
        ' 
        btnModalClose.Animated = True
        btnModalClose.BorderRadius = 12
        btnModalClose.Cursor = Cursors.Hand
        btnModalClose.CustomizableEdges = CustomizableEdges1
        btnModalClose.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnModalClose.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnModalClose.ForeColor = Color.White
        btnModalClose.Location = New Point(329, 675)
        btnModalClose.Margin = New Padding(4, 5, 4, 5)
        btnModalClose.Name = "btnModalClose"
        btnModalClose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnModalClose.Size = New Size(243, 75)
        btnModalClose.TabIndex = 10
        btnModalClose.Text = "Close Breakdown"
        ' 
        ' pnlCheckoutLeft
        ' 
        pnlCheckoutLeft.BackColor = Color.Transparent
        pnlCheckoutLeft.BorderRadius = 18
        pnlCheckoutLeft.Controls.Add(lblCheckoutTitle)
        pnlCheckoutLeft.Controls.Add(lblCheckoutRoute)
        pnlCheckoutLeft.Controls.Add(lblCheckoutStats)
        pnlCheckoutLeft.Controls.Add(lblCheckoutPassenger)
        pnlCheckoutLeft.Controls.Add(pnlDivider1)
        pnlCheckoutLeft.Controls.Add(lblCkBaseFare)
        pnlCheckoutLeft.Controls.Add(lblCkTaxes)
        pnlCheckoutLeft.Controls.Add(lblCkAddons)
        pnlCheckoutLeft.Controls.Add(lblCkDiscount)
        pnlCheckoutLeft.Controls.Add(pnlDivider2)
        pnlCheckoutLeft.Controls.Add(lblCkTotal)
        pnlCheckoutLeft.Controls.Add(btnShowMoreDeets)
        pnlCheckoutLeft.CustomizableEdges = CustomizableEdges7
        pnlCheckoutLeft.FillColor = Color.White
        pnlCheckoutLeft.Location = New Point(50, 42)
        pnlCheckoutLeft.Margin = New Padding(4, 5, 4, 5)
        pnlCheckoutLeft.Name = "pnlCheckoutLeft"
        pnlCheckoutLeft.ShadowDecoration.BorderRadius = 18
        pnlCheckoutLeft.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCheckoutLeft.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlCheckoutLeft.ShadowDecoration.Enabled = True
        pnlCheckoutLeft.Size = New Size(900, 900)
        pnlCheckoutLeft.TabIndex = 0
        ' 
        ' lblCheckoutTitle
        ' 
        lblCheckoutTitle.AutoSize = True
        lblCheckoutTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblCheckoutTitle.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblCheckoutTitle.Location = New Point(43, 42)
        lblCheckoutTitle.Margin = New Padding(4, 0, 4, 0)
        lblCheckoutTitle.Name = "lblCheckoutTitle"
        lblCheckoutTitle.Size = New Size(458, 41)
        lblCheckoutTitle.TabIndex = 0
        lblCheckoutTitle.Text = "Booking Summary & Fare Details"
        ' 
        ' lblCheckoutRoute
        ' 
        lblCheckoutRoute.AutoSize = True
        lblCheckoutRoute.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCheckoutRoute.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblCheckoutRoute.Location = New Point(43, 108)
        lblCheckoutRoute.Margin = New Padding(4, 0, 4, 0)
        lblCheckoutRoute.Name = "lblCheckoutRoute"
        lblCheckoutRoute.Size = New Size(533, 32)
        lblCheckoutRoute.TabIndex = 1
        lblCheckoutRoute.Text = "Manila (MNL) → Cebu (CEB)  (Economy Class)"
        ' 
        ' lblCheckoutStats
        ' 
        lblCheckoutStats.AutoSize = True
        lblCheckoutStats.Font = New Font("Segoe UI", 9.5F)
        lblCheckoutStats.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblCheckoutStats.Location = New Point(43, 158)
        lblCheckoutStats.Margin = New Padding(4, 0, 4, 0)
        lblCheckoutStats.Name = "lblCheckoutStats"
        lblCheckoutStats.Size = New Size(439, 25)
        lblCheckoutStats.TabIndex = 2
        lblCheckoutStats.Text = "October 24, 2026 | 08:00 AM - 09:20 AM | Non-Stop"
        ' 
        ' lblCheckoutPassenger
        ' 
        lblCheckoutPassenger.AutoSize = True
        lblCheckoutPassenger.Font = New Font("Segoe UI", 9.5F, FontStyle.Italic)
        lblCheckoutPassenger.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblCheckoutPassenger.Location = New Point(43, 200)
        lblCheckoutPassenger.Margin = New Padding(4, 0, 4, 0)
        lblCheckoutPassenger.Name = "lblCheckoutPassenger"
        lblCheckoutPassenger.Size = New Size(320, 25)
        lblCheckoutPassenger.TabIndex = 3
        lblCheckoutPassenger.Text = "Passenger: Naruto Uzumaki | Seat: 1A"
        ' 
        ' pnlDivider1
        ' 
        pnlDivider1.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlDivider1.Location = New Point(43, 250)
        pnlDivider1.Margin = New Padding(4, 5, 4, 5)
        pnlDivider1.Name = "pnlDivider1"
        pnlDivider1.Size = New Size(814, 2)
        pnlDivider1.TabIndex = 4
        ' 
        ' lblCkBaseFare
        ' 
        lblCkBaseFare.AutoSize = True
        lblCkBaseFare.Font = New Font("Segoe UI", 10.5F)
        lblCkBaseFare.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblCkBaseFare.Location = New Point(43, 283)
        lblCkBaseFare.Margin = New Padding(4, 0, 4, 0)
        lblCkBaseFare.Name = "lblCkBaseFare"
        lblCkBaseFare.Size = New Size(416, 30)
        lblCkBaseFare.TabIndex = 5
        lblCkBaseFare.Text = "Base fare:                                PHP 3,000.00"
        ' 
        ' lblCkTaxes
        ' 
        lblCkTaxes.AutoSize = True
        lblCkTaxes.Font = New Font("Segoe UI", 10.5F)
        lblCkTaxes.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblCkTaxes.Location = New Point(43, 342)
        lblCkTaxes.Margin = New Padding(4, 0, 4, 0)
        lblCkTaxes.Name = "lblCkTaxes"
        lblCkTaxes.Size = New Size(387, 30)
        lblCkTaxes.TabIndex = 6
        lblCkTaxes.Text = "Taxes & surcharges:                 PHP 690.00"
        ' 
        ' lblCkAddons
        ' 
        lblCkAddons.AutoSize = True
        lblCkAddons.Font = New Font("Segoe UI", 10.5F)
        lblCkAddons.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(70))
        lblCkAddons.Location = New Point(43, 400)
        lblCkAddons.Margin = New Padding(4, 0, 4, 0)
        lblCkAddons.Name = "lblCkAddons"
        lblCkAddons.Size = New Size(373, 30)
        lblCkAddons.TabIndex = 7
        lblCkAddons.Text = "Add-ons (Baggage/Prot):        PHP 0.00"
        ' 
        ' lblCkDiscount
        ' 
        lblCkDiscount.AutoSize = True
        lblCkDiscount.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblCkDiscount.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblCkDiscount.Location = New Point(43, 458)
        lblCkDiscount.Margin = New Padding(4, 0, 4, 0)
        lblCkDiscount.Name = "lblCkDiscount"
        lblCkDiscount.Size = New Size(407, 30)
        lblCkDiscount.TabIndex = 8
        lblCkDiscount.Text = "Discount (20% Senior/PWD):  -PHP 0.00"
        ' 
        ' pnlDivider2
        ' 
        pnlDivider2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlDivider2.Location = New Point(43, 525)
        pnlDivider2.Margin = New Padding(4, 5, 4, 5)
        pnlDivider2.Name = "pnlDivider2"
        pnlDivider2.Size = New Size(814, 2)
        pnlDivider2.TabIndex = 9
        ' 
        ' lblCkTotal
        ' 
        lblCkTotal.AutoSize = True
        lblCkTotal.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblCkTotal.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblCkTotal.Location = New Point(43, 558)
        lblCkTotal.Margin = New Padding(4, 0, 4, 0)
        lblCkTotal.Name = "lblCkTotal"
        lblCkTotal.Size = New Size(388, 38)
        lblCkTotal.TabIndex = 10
        lblCkTotal.Text = "Total Amount: PHP 3,690.00"
        ' 
        ' btnShowMoreDeets
        ' 
        btnShowMoreDeets.Animated = True
        btnShowMoreDeets.BorderColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnShowMoreDeets.BorderRadius = 10
        btnShowMoreDeets.BorderThickness = 1
        btnShowMoreDeets.Cursor = Cursors.Hand
        btnShowMoreDeets.CustomizableEdges = CustomizableEdges5
        btnShowMoreDeets.FillColor = Color.Transparent
        btnShowMoreDeets.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnShowMoreDeets.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnShowMoreDeets.Location = New Point(43, 700)
        btnShowMoreDeets.Margin = New Padding(4, 5, 4, 5)
        btnShowMoreDeets.Name = "btnShowMoreDeets"
        btnShowMoreDeets.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnShowMoreDeets.Size = New Size(343, 75)
        btnShowMoreDeets.TabIndex = 11
        btnShowMoreDeets.Text = "View Detailed Breakdown"
        ' 
        ' pnlCheckoutRight
        ' 
        pnlCheckoutRight.BackColor = Color.Transparent
        pnlCheckoutRight.BorderRadius = 18
        pnlCheckoutRight.Controls.Add(lblReadyTitle)
        pnlCheckoutRight.Controls.Add(lblSecureBadge)
        pnlCheckoutRight.Controls.Add(lblRightTotalLabel)
        pnlCheckoutRight.Controls.Add(lblRightTotal)
        pnlCheckoutRight.Controls.Add(btnContinueToPayment)
        pnlCheckoutRight.Controls.Add(btnCheckoutBack)
        pnlCheckoutRight.CustomizableEdges = CustomizableEdges13
        pnlCheckoutRight.FillColor = Color.White
        pnlCheckoutRight.Location = New Point(979, 42)
        pnlCheckoutRight.Margin = New Padding(4, 5, 4, 5)
        pnlCheckoutRight.Name = "pnlCheckoutRight"
        pnlCheckoutRight.ShadowDecoration.BorderRadius = 18
        pnlCheckoutRight.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlCheckoutRight.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        pnlCheckoutRight.ShadowDecoration.Enabled = True
        pnlCheckoutRight.Size = New Size(471, 900)
        pnlCheckoutRight.TabIndex = 1
        ' 
        ' lblReadyTitle
        ' 
        lblReadyTitle.AutoSize = True
        lblReadyTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblReadyTitle.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblReadyTitle.Location = New Point(43, 50)
        lblReadyTitle.Margin = New Padding(4, 0, 4, 0)
        lblReadyTitle.Name = "lblReadyTitle"
        lblReadyTitle.Size = New Size(198, 38)
        lblReadyTitle.TabIndex = 0
        lblReadyTitle.Text = "Ready to Pay?"
        ' 
        ' lblSecureBadge
        ' 
        lblSecureBadge.AutoSize = True
        lblSecureBadge.Font = New Font("Segoe UI", 9F)
        lblSecureBadge.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblSecureBadge.Location = New Point(43, 108)
        lblSecureBadge.Margin = New Padding(4, 0, 4, 0)
        lblSecureBadge.Name = "lblSecureBadge"
        lblSecureBadge.Size = New Size(290, 25)
        lblSecureBadge.TabIndex = 1
        lblSecureBadge.Text = "🔒 256-bit SSL Encrypted Payment"
        ' 
        ' lblRightTotalLabel
        ' 
        lblRightTotalLabel.AutoSize = True
        lblRightTotalLabel.Font = New Font("Segoe UI", 10F)
        lblRightTotalLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblRightTotalLabel.Location = New Point(43, 400)
        lblRightTotalLabel.Margin = New Padding(4, 0, 4, 0)
        lblRightTotalLabel.Name = "lblRightTotalLabel"
        lblRightTotalLabel.Size = New Size(202, 28)
        lblRightTotalLabel.TabIndex = 2
        lblRightTotalLabel.Text = "Total Amount Payable"
        ' 
        ' lblRightTotal
        ' 
        lblRightTotal.AutoSize = True
        lblRightTotal.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblRightTotal.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblRightTotal.Location = New Point(36, 447)
        lblRightTotal.Margin = New Padding(4, 0, 4, 0)
        lblRightTotal.Name = "lblRightTotal"
        lblRightTotal.Size = New Size(299, 60)
        lblRightTotal.TabIndex = 3
        lblRightTotal.Text = "PHP 3,690.00"
        ' 
        ' btnContinueToPayment
        ' 
        btnContinueToPayment.Animated = True
        btnContinueToPayment.BorderRadius = 14
        btnContinueToPayment.Cursor = Cursors.Hand
        btnContinueToPayment.CustomizableEdges = CustomizableEdges9
        btnContinueToPayment.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnContinueToPayment.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnContinueToPayment.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnContinueToPayment.Location = New Point(36, 658)
        btnContinueToPayment.Margin = New Padding(4, 5, 4, 5)
        btnContinueToPayment.Name = "btnContinueToPayment"
        btnContinueToPayment.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnContinueToPayment.Size = New Size(400, 87)
        btnContinueToPayment.TabIndex = 4
        btnContinueToPayment.Text = "Continue to Payment →"
        ' 
        ' btnCheckoutBack
        ' 
        btnCheckoutBack.Animated = True
        btnCheckoutBack.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnCheckoutBack.BorderRadius = 12
        btnCheckoutBack.BorderThickness = 1
        btnCheckoutBack.Cursor = Cursors.Hand
        btnCheckoutBack.CustomizableEdges = CustomizableEdges11
        btnCheckoutBack.FillColor = Color.Transparent
        btnCheckoutBack.Font = New Font("Segoe UI", 10F)
        btnCheckoutBack.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnCheckoutBack.Location = New Point(36, 775)
        btnCheckoutBack.Margin = New Padding(4, 5, 4, 5)
        btnCheckoutBack.Name = "btnCheckoutBack"
        btnCheckoutBack.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnCheckoutBack.Size = New Size(400, 70)
        btnCheckoutBack.TabIndex = 5
        btnCheckoutBack.Text = "← Back to Refundability"
        ' 
        ' CheckoutForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1500, 1083)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "CheckoutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Checkout Summary"
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBreakdownModal.ResumeLayout(False)
        pnlBreakdownModal.PerformLayout()
        pnlCheckoutLeft.ResumeLayout(False)
        pnlCheckoutLeft.PerformLayout()
        pnlCheckoutRight.ResumeLayout(False)
        pnlCheckoutRight.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlCheckoutLeft As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCheckoutTitle As Label
    Friend WithEvents lblCheckoutRoute As Label
    Friend WithEvents lblCheckoutStats As Label
    Friend WithEvents lblCheckoutPassenger As Label
    Friend WithEvents pnlDivider1 As Panel
    Friend WithEvents lblCkBaseFare As Label
    Friend WithEvents lblCkTaxes As Label
    Friend WithEvents lblCkAddons As Label
    Friend WithEvents lblCkDiscount As Label
    Friend WithEvents pnlDivider2 As Panel
    Friend WithEvents lblCkTotal As Label
    Friend WithEvents btnShowMoreDeets As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCheckoutRight As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblReadyTitle As Label
    Friend WithEvents lblSecureBadge As Label
    Friend WithEvents lblRightTotalLabel As Label
    Friend WithEvents lblRightTotal As Label
    Friend WithEvents btnContinueToPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheckoutBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlBreakdownModal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblModalHeader As Label
    Friend WithEvents lblModBaseFare As Label
    Friend WithEvents lblModAdminFee As Label
    Friend WithEvents lblModFuel As Label
    Friend WithEvents lblModVAT As Label
    Friend WithEvents lblModTerminalFee As Label
    Friend WithEvents lblModAddons As Label
    Friend WithEvents lblModDiscount As Label
    Friend WithEvents pnlModDivider As Panel
    Friend WithEvents lblModTotal As Label
    Friend WithEvents btnModalClose As Guna.UI2.WinForms.Guna2Button

End Class
