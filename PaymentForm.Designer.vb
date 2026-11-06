<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentForm
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
        pnlPaySidebar = New Guna.UI2.WinForms.Guna2Panel()
        lblSidebarTitle = New Label()
        lblPayPassenger = New Label()
        lblPayRoute = New Label()
        lblPayTime = New Label()
        pnlSideDivider = New Panel()
        lblPayTotalLabel = New Label()
        lblPayTotal = New Label()
        btnCancelPayment = New Guna.UI2.WinForms.Guna2Button()
        pnlPayMain = New Guna.UI2.WinForms.Guna2Panel()
        btnTabCreditDebit = New Guna.UI2.WinForms.Guna2Button()
        btnTabOnlineBanking = New Guna.UI2.WinForms.Guna2Button()
        btnTabWallet = New Guna.UI2.WinForms.Guna2Button()
        pnlPayInputs = New Guna.UI2.WinForms.Guna2Panel()
        lblPayInstruction = New Label()
        txtPayField1 = New Guna.UI2.WinForms.Guna2TextBox()
        txtPayField2 = New Guna.UI2.WinForms.Guna2TextBox()
        txtPayField3 = New Guna.UI2.WinForms.Guna2TextBox()
        btnConfirmPayment = New Guna.UI2.WinForms.Guna2Button()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlPaySidebar.SuspendLayout()
        pnlPayMain.SuspendLayout()
        pnlPayInputs.SuspendLayout()
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
        lblStepTitle.Size = New Size(240, 19)
        lblStepTitle.TabIndex = 2
        lblStepTitle.Text = "PAYMENT OPTIONS"

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
        pnlBody.Controls.Add(pnlPaySidebar)
        pnlBody.Controls.Add(pnlPayMain)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(980, 544)
        pnlBody.TabIndex = 1

        pnlPaySidebar.BorderRadius = 18
        pnlPaySidebar.Controls.Add(lblSidebarTitle)
        pnlPaySidebar.Controls.Add(lblPayPassenger)
        pnlPaySidebar.Controls.Add(lblPayRoute)
        pnlPaySidebar.Controls.Add(lblPayTime)
        pnlPaySidebar.Controls.Add(pnlSideDivider)
        pnlPaySidebar.Controls.Add(lblPayTotalLabel)
        pnlPaySidebar.Controls.Add(lblPayTotal)
        pnlPaySidebar.Controls.Add(btnCancelPayment)
        pnlPaySidebar.FillColor = Color.White
        pnlPaySidebar.Location = New Point(35, 25)
        pnlPaySidebar.Name = "pnlPaySidebar"
        pnlPaySidebar.ShadowDecoration.BorderRadius = 18
        pnlPaySidebar.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlPaySidebar.ShadowDecoration.Enabled = True
        pnlPaySidebar.Size = New Size(310, 490)
        pnlPaySidebar.TabIndex = 0

        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblSidebarTitle.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblSidebarTitle.Location = New Point(25, 25)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(165, 25)
        lblSidebarTitle.TabIndex = 0
        lblSidebarTitle.Text = "Payment Summary"

        lblPayPassenger.AutoSize = True
        lblPayPassenger.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblPayPassenger.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblPayPassenger.Location = New Point(25, 70)
        lblPayPassenger.Name = "lblPayPassenger"
        lblPayPassenger.Size = New Size(115, 19)
        lblPayPassenger.TabIndex = 1
        lblPayPassenger.Text = "Naruto Uzumaki"

        lblPayRoute.AutoSize = True
        lblPayRoute.Font = New Font("Segoe UI", 9.5F)
        lblPayRoute.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblPayRoute.Location = New Point(25, 100)
        lblPayRoute.Name = "lblPayRoute"
        lblPayRoute.Size = New Size(160, 17)
        lblPayRoute.TabIndex = 2
        lblPayRoute.Text = "Manila (MNL) → Cebu (CEB)"

        lblPayTime.AutoSize = True
        lblPayTime.Font = New Font("Segoe UI", 9.0F)
        lblPayTime.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblPayTime.Location = New Point(25, 125)
        lblPayTime.Name = "lblPayTime"
        lblPayTime.Size = New Size(140, 15)
        lblPayTime.TabIndex = 3
        lblPayTime.Text = "Oct 24, 2026 | 08:00 AM"

        pnlSideDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlSideDivider.Location = New Point(25, 160)
        pnlSideDivider.Name = "pnlSideDivider"
        pnlSideDivider.Size = New Size(260, 1)
        pnlSideDivider.TabIndex = 4

        lblPayTotalLabel.AutoSize = True
        lblPayTotalLabel.Font = New Font("Segoe UI", 10.0F)
        lblPayTotalLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblPayTotalLabel.Location = New Point(25, 200)
        lblPayTotalLabel.Name = "lblPayTotalLabel"
        lblPayTotalLabel.Size = New Size(140, 19)
        lblPayTotalLabel.TabIndex = 5
        lblPayTotalLabel.Text = "Total Amount Payable"

        lblPayTotal.AutoSize = True
        lblPayTotal.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblPayTotal.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblPayTotal.Location = New Point(20, 225)
        lblPayTotal.Name = "lblPayTotal"
        lblPayTotal.Size = New Size(205, 40)
        lblPayTotal.TabIndex = 6
        lblPayTotal.Text = "PHP 3,690.00"

        btnCancelPayment.Animated = True
        btnCancelPayment.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnCancelPayment.BorderRadius = 12
        btnCancelPayment.BorderThickness = 1
        btnCancelPayment.Cursor = Cursors.Hand
        btnCancelPayment.FillColor = Color.Transparent
        btnCancelPayment.Font = New Font("Segoe UI", 10.0F)
        btnCancelPayment.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnCancelPayment.Location = New Point(25, 420)
        btnCancelPayment.Name = "btnCancelPayment"
        btnCancelPayment.Size = New Size(260, 45)
        btnCancelPayment.TabIndex = 7
        btnCancelPayment.Text = "← Cancel Transaction"

        pnlPayMain.BorderRadius = 18
        pnlPayMain.Controls.Add(btnTabCreditDebit)
        pnlPayMain.Controls.Add(btnTabOnlineBanking)
        pnlPayMain.Controls.Add(btnTabWallet)
        pnlPayMain.Controls.Add(pnlPayInputs)
        pnlPayMain.FillColor = Color.White
        pnlPayMain.Location = New Point(365, 25)
        pnlPayMain.Name = "pnlPayMain"
        pnlPayMain.ShadowDecoration.BorderRadius = 18
        pnlPayMain.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlPayMain.ShadowDecoration.Enabled = True
        pnlPayMain.Size = New Size(580, 490)
        pnlPayMain.TabIndex = 1

        btnTabCreditDebit.Animated = True
        btnTabCreditDebit.BorderRadius = 10
        btnTabCreditDebit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnTabCreditDebit.Checked = True
        btnTabCreditDebit.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnTabCreditDebit.CheckedState.ForeColor = Color.White
        btnTabCreditDebit.Cursor = Cursors.Hand
        btnTabCreditDebit.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnTabCreditDebit.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnTabCreditDebit.ForeColor = Color.White
        btnTabCreditDebit.Location = New Point(20, 20)
        btnTabCreditDebit.Name = "btnTabCreditDebit"
        btnTabCreditDebit.Size = New Size(165, 42)
        btnTabCreditDebit.TabIndex = 0
        btnTabCreditDebit.Text = "💳 Credit / Debit"

        btnTabOnlineBanking.Animated = True
        btnTabOnlineBanking.BorderRadius = 10
        btnTabOnlineBanking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnTabOnlineBanking.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnTabOnlineBanking.CheckedState.ForeColor = Color.White
        btnTabOnlineBanking.Cursor = Cursors.Hand
        btnTabOnlineBanking.FillColor = Color.Transparent
        btnTabOnlineBanking.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnTabOnlineBanking.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnTabOnlineBanking.Location = New Point(195, 20)
        btnTabOnlineBanking.Name = "btnTabOnlineBanking"
        btnTabOnlineBanking.Size = New Size(170, 42)
        btnTabOnlineBanking.TabIndex = 1
        btnTabOnlineBanking.Text = "🏛 Online Bank"

        btnTabWallet.Animated = True
        btnTabWallet.BorderRadius = 10
        btnTabWallet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        btnTabWallet.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnTabWallet.CheckedState.ForeColor = Color.White
        btnTabWallet.Cursor = Cursors.Hand
        btnTabWallet.FillColor = Color.Transparent
        btnTabWallet.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnTabWallet.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnTabWallet.Location = New Point(375, 20)
        btnTabWallet.Name = "btnTabWallet"
        btnTabWallet.Size = New Size(185, 42)
        btnTabWallet.TabIndex = 2
        btnTabWallet.Text = "📱 GCash / Maya"

        pnlPayInputs.BorderRadius = 12
        pnlPayInputs.Controls.Add(lblPayInstruction)
        pnlPayInputs.Controls.Add(txtPayField1)
        pnlPayInputs.Controls.Add(txtPayField2)
        pnlPayInputs.Controls.Add(txtPayField3)
        pnlPayInputs.Controls.Add(btnConfirmPayment)
        pnlPayInputs.FillColor = Color.FromArgb(CByte(248), CByte(249), CByte(251))
        pnlPayInputs.Location = New Point(20, 80)
        pnlPayInputs.Name = "pnlPayInputs"
        pnlPayInputs.Size = New Size(540, 385)
        pnlPayInputs.TabIndex = 3

        lblPayInstruction.AutoSize = True
        lblPayInstruction.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblPayInstruction.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblPayInstruction.Location = New Point(25, 25)
        lblPayInstruction.Name = "lblPayInstruction"
        lblPayInstruction.Size = New Size(220, 21)
        lblPayInstruction.TabIndex = 0
        lblPayInstruction.Text = "Enter Card Payment Details"

        txtPayField1.BorderRadius = 10
        txtPayField1.Cursor = Cursors.IBeam
        txtPayField1.DefaultText = ""
        txtPayField1.Font = New Font("Segoe UI", 10.0F)
        txtPayField1.Location = New Point(25, 65)
        txtPayField1.Name = "txtPayField1"
        txtPayField1.PasswordChar = ChrW(0)
        txtPayField1.PlaceholderText = "16-digit Card Number (e.g. 4532 ...)"
        txtPayField1.Size = New Size(490, 48)
        txtPayField1.TabIndex = 1

        txtPayField2.BorderRadius = 10
        txtPayField2.Cursor = Cursors.IBeam
        txtPayField2.DefaultText = ""
        txtPayField2.Font = New Font("Segoe UI", 10.0F)
        txtPayField2.Location = New Point(25, 125)
        txtPayField2.Name = "txtPayField2"
        txtPayField2.PasswordChar = ChrW(0)
        txtPayField2.PlaceholderText = "Cardholder Full Name"
        txtPayField2.Size = New Size(490, 48)
        txtPayField2.TabIndex = 2

        txtPayField3.BorderRadius = 10
        txtPayField3.Cursor = Cursors.IBeam
        txtPayField3.DefaultText = ""
        txtPayField3.Font = New Font("Segoe UI", 10.0F)
        txtPayField3.Location = New Point(25, 185)
        txtPayField3.Name = "txtPayField3"
        txtPayField3.PasswordChar = ChrW(0)
        txtPayField3.PlaceholderText = "MM/YY Expiry  •  3-digit CVV"
        txtPayField3.Size = New Size(490, 48)
        txtPayField3.TabIndex = 3

        btnConfirmPayment.Animated = True
        btnConfirmPayment.BorderRadius = 14
        btnConfirmPayment.Cursor = Cursors.Hand
        btnConfirmPayment.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnConfirmPayment.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnConfirmPayment.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnConfirmPayment.Location = New Point(25, 295)
        btnConfirmPayment.Name = "btnConfirmPayment"
        btnConfirmPayment.Size = New Size(490, 56)
        btnConfirmPayment.TabIndex = 4
        btnConfirmPayment.Text = "Confirm & Pay PHP 3,690.00 ✓"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(980, 600)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Payment"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlPaySidebar.ResumeLayout(False)
        pnlPaySidebar.PerformLayout()
        pnlPayMain.ResumeLayout(False)
        pnlPayInputs.ResumeLayout(False)
        pnlPayInputs.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlPaySidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents lblPayPassenger As Label
    Friend WithEvents lblPayRoute As Label
    Friend WithEvents lblPayTime As Label
    Friend WithEvents pnlSideDivider As Panel
    Friend WithEvents lblPayTotalLabel As Label
    Friend WithEvents lblPayTotal As Label
    Friend WithEvents btnCancelPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlPayMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnTabCreditDebit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTabOnlineBanking As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTabWallet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlPayInputs As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPayInstruction As Label
    Friend WithEvents txtPayField1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPayField2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPayField3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnConfirmPayment As Guna.UI2.WinForms.Guna2Button

End Class
