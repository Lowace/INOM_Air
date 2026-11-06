<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingStep6
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
        pnlB6LeftRefund = New Guna.UI2.WinForms.Guna2Panel()
        lblB6Title = New Label()
        lblB6Subtitle = New Label()
        pnlOption1 = New Guna.UI2.WinForms.Guna2Panel()
        rbB6NonRefundable = New Guna.UI2.WinForms.Guna2RadioButton()
        lblOption1Desc = New Label()
        pnlOption2 = New Guna.UI2.WinForms.Guna2Panel()
        rbB6Refundable = New Guna.UI2.WinForms.Guna2RadioButton()
        lblOption2Desc = New Label()
        pnlNoticeCard = New Guna.UI2.WinForms.Guna2Panel()
        lblNoticeHeader = New Label()
        lblNoticeText = New Label()
        pnlB6RightSummary = New Guna.UI2.WinForms.Guna2Panel()
        lblB6SummaryHeader = New Label()
        lblB6SummaryDate = New Label()
        lblB6SummaryRoute = New Label()
        lblB6SummaryTime = New Label()
        pnlB6SumDivider = New Panel()
        lblB6SummaryTotalLabel = New Label()
        lblB6SummaryTotalAmount = New Label()
        btnB6Back = New Guna.UI2.WinForms.Guna2Button()
        btnB6Pay = New Guna.UI2.WinForms.Guna2Button()

        pnlTopBar.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlB6LeftRefund.SuspendLayout()
        pnlOption1.SuspendLayout()
        pnlOption2.SuspendLayout()
        pnlNoticeCard.SuspendLayout()
        pnlB6RightSummary.SuspendLayout()
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
        lblStepTitle.Text = "REFUNDABILITY — Step 5 of 6"

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
        pnlBody.Controls.Add(pnlB6LeftRefund)
        pnlBody.Controls.Add(pnlB6RightSummary)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 56)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1020, 544)
        pnlBody.TabIndex = 1

        pnlB6LeftRefund.BorderRadius = 18
        pnlB6LeftRefund.Controls.Add(lblB6Title)
        pnlB6LeftRefund.Controls.Add(lblB6Subtitle)
        pnlB6LeftRefund.Controls.Add(pnlOption1)
        pnlB6LeftRefund.Controls.Add(pnlOption2)
        pnlB6LeftRefund.Controls.Add(pnlNoticeCard)
        pnlB6LeftRefund.FillColor = Color.White
        pnlB6LeftRefund.Location = New Point(35, 25)
        pnlB6LeftRefund.Name = "pnlB6LeftRefund"
        pnlB6LeftRefund.ShadowDecoration.BorderRadius = 18
        pnlB6LeftRefund.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB6LeftRefund.ShadowDecoration.Enabled = True
        pnlB6LeftRefund.Size = New Size(620, 490)
        pnlB6LeftRefund.TabIndex = 0

        lblB6Title.AutoSize = True
        lblB6Title.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblB6Title.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB6Title.Location = New Point(30, 25)
        lblB6Title.Name = "lblB6Title"
        lblB6Title.Size = New Size(335, 28)
        lblB6Title.TabIndex = 0
        lblB6Title.Text = "Booking Protection & Refundability"

        lblB6Subtitle.AutoSize = True
        lblB6Subtitle.Font = New Font("Segoe UI", 9.5F)
        lblB6Subtitle.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB6Subtitle.Location = New Point(32, 58)
        lblB6Subtitle.Name = "lblB6Subtitle"
        lblB6Subtitle.Size = New Size(460, 17)
        lblB6Subtitle.TabIndex = 1
        lblB6Subtitle.Text = "Choose whether your ticket can be refunded if your travel plans change unexpectedly."

        pnlOption1.BorderColor = Color.FromArgb(CByte(220), CByte(220), CByte(230))
        pnlOption1.BorderRadius = 12
        pnlOption1.BorderThickness = 1
        pnlOption1.Controls.Add(rbB6NonRefundable)
        pnlOption1.Controls.Add(lblOption1Desc)
        pnlOption1.FillColor = Color.FromArgb(CByte(248), CByte(249), CByte(251))
        pnlOption1.Location = New Point(30, 95)
        pnlOption1.Name = "pnlOption1"
        pnlOption1.Size = New Size(560, 85)
        pnlOption1.TabIndex = 2

        rbB6NonRefundable.AutoSize = True
        rbB6NonRefundable.Checked = True
        rbB6NonRefundable.CheckedState.BorderColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB6NonRefundable.CheckedState.BorderThickness = 2
        rbB6NonRefundable.CheckedState.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        rbB6NonRefundable.CheckedState.InnerColor = Color.White
        rbB6NonRefundable.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        rbB6NonRefundable.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        rbB6NonRefundable.Location = New Point(20, 16)
        rbB6NonRefundable.Name = "rbB6NonRefundable"
        rbB6NonRefundable.Size = New Size(260, 24)
        rbB6NonRefundable.TabIndex = 0
        rbB6NonRefundable.TabStop = True
        rbB6NonRefundable.Text = "Standard Fare (Non-Refundable)"

        lblOption1Desc.AutoSize = True
        lblOption1Desc.Font = New Font("Segoe UI", 9.0F)
        lblOption1Desc.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblOption1Desc.Location = New Point(42, 45)
        lblOption1Desc.Name = "lblOption1Desc"
        lblOption1Desc.Size = New Size(390, 15)
        lblOption1Desc.TabIndex = 1
        lblOption1Desc.Text = "Standard ticket with no refund option upon voluntary customer cancellation."

        pnlOption2.BorderColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        pnlOption2.BorderRadius = 12
        pnlOption2.BorderThickness = 1
        pnlOption2.Controls.Add(rbB6Refundable)
        pnlOption2.Controls.Add(lblOption2Desc)
        pnlOption2.FillColor = Color.FromArgb(CByte(254), CByte(248), CByte(244))
        pnlOption2.Location = New Point(30, 195)
        pnlOption2.Name = "pnlOption2"
        pnlOption2.Size = New Size(560, 85)
        pnlOption2.TabIndex = 3

        rbB6Refundable.AutoSize = True
        rbB6Refundable.CheckedState.BorderColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        rbB6Refundable.CheckedState.BorderThickness = 2
        rbB6Refundable.CheckedState.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        rbB6Refundable.CheckedState.InnerColor = Color.White
        rbB6Refundable.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        rbB6Refundable.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        rbB6Refundable.Location = New Point(20, 16)
        rbB6Refundable.Name = "rbB6Refundable"
        rbB6Refundable.Size = New Size(280, 24)
        rbB6Refundable.TabIndex = 0
        rbB6Refundable.Text = "Flexible Ticket (Refundable +₱500)"

        lblOption2Desc.AutoSize = True
        lblOption2Desc.Font = New Font("Segoe UI", 9.0F)
        lblOption2Desc.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblOption2Desc.Location = New Point(42, 45)
        lblOption2Desc.Name = "lblOption2Desc"
        lblOption2Desc.Size = New Size(410, 15)
        lblOption2Desc.TabIndex = 1
        lblOption2Desc.Text = "Allows 100% refund of base fare if flight is cancelled 24h prior to departure."

        pnlNoticeCard.BorderRadius = 10
        pnlNoticeCard.Controls.Add(lblNoticeHeader)
        pnlNoticeCard.Controls.Add(lblNoticeText)
        pnlNoticeCard.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        pnlNoticeCard.Location = New Point(30, 305)
        pnlNoticeCard.Name = "pnlNoticeCard"
        pnlNoticeCard.Size = New Size(560, 155)
        pnlNoticeCard.TabIndex = 4

        lblNoticeHeader.AutoSize = True
        lblNoticeHeader.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblNoticeHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblNoticeHeader.Location = New Point(15, 12)
        lblNoticeHeader.Name = "lblNoticeHeader"
        lblNoticeHeader.Size = New Size(160, 19)
        lblNoticeHeader.TabIndex = 0
        lblNoticeHeader.Text = "Cancellation Policy:"

        lblNoticeText.Font = New Font("Segoe UI", 9.0F)
        lblNoticeText.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblNoticeText.Location = New Point(15, 38)
        lblNoticeText.Name = "lblNoticeText"
        lblNoticeText.Size = New Size(530, 105)
        lblNoticeText.TabIndex = 1
        lblNoticeText.Text = "• If cancelled flight by airline: 100% full refund unconditionally." & vbCrLf &
                           "• Passenger cancellation on Refundable ticket: Base fare returned minus ₱200 processing fee." & vbCrLf &
                           "• Senior Citizen & PWD discounts remain active regardless of chosen package."

        pnlB6RightSummary.BorderRadius = 18
        pnlB6RightSummary.Controls.Add(lblB6SummaryHeader)
        pnlB6RightSummary.Controls.Add(lblB6SummaryDate)
        pnlB6RightSummary.Controls.Add(lblB6SummaryRoute)
        pnlB6RightSummary.Controls.Add(lblB6SummaryTime)
        pnlB6RightSummary.Controls.Add(pnlB6SumDivider)
        pnlB6RightSummary.Controls.Add(lblB6SummaryTotalLabel)
        pnlB6RightSummary.Controls.Add(lblB6SummaryTotalAmount)
        pnlB6RightSummary.Controls.Add(btnB6Back)
        pnlB6RightSummary.Controls.Add(btnB6Pay)
        pnlB6RightSummary.FillColor = Color.White
        pnlB6RightSummary.Location = New Point(680, 25)
        pnlB6RightSummary.Name = "pnlB6RightSummary"
        pnlB6RightSummary.ShadowDecoration.BorderRadius = 18
        pnlB6RightSummary.ShadowDecoration.Color = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        pnlB6RightSummary.ShadowDecoration.Enabled = True
        pnlB6RightSummary.Size = New Size(305, 490)
        pnlB6RightSummary.TabIndex = 1

        lblB6SummaryHeader.AutoSize = True
        lblB6SummaryHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblB6SummaryHeader.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblB6SummaryHeader.Location = New Point(25, 25)
        lblB6SummaryHeader.Name = "lblB6SummaryHeader"
        lblB6SummaryHeader.Size = New Size(130, 25)
        lblB6SummaryHeader.TabIndex = 0
        lblB6SummaryHeader.Text = "Trip Summary"

        lblB6SummaryDate.AutoSize = True
        lblB6SummaryDate.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblB6SummaryDate.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(60))
        lblB6SummaryDate.Location = New Point(25, 75)
        lblB6SummaryDate.Name = "lblB6SummaryDate"
        lblB6SummaryDate.Size = New Size(120, 19)
        lblB6SummaryDate.TabIndex = 1
        lblB6SummaryDate.Text = "October 24, 2026"

        lblB6SummaryRoute.AutoSize = True
        lblB6SummaryRoute.Font = New Font("Segoe UI", 10.0F)
        lblB6SummaryRoute.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB6SummaryRoute.Location = New Point(25, 110)
        lblB6SummaryRoute.Name = "lblB6SummaryRoute"
        lblB6SummaryRoute.Size = New Size(160, 19)
        lblB6SummaryRoute.TabIndex = 2
        lblB6SummaryRoute.Text = "Manila (MNL) → Cebu (CEB)"

        lblB6SummaryTime.AutoSize = True
        lblB6SummaryTime.Font = New Font("Segoe UI", 9.5F)
        lblB6SummaryTime.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB6SummaryTime.Location = New Point(25, 145)
        lblB6SummaryTime.Name = "lblB6SummaryTime"
        lblB6SummaryTime.Size = New Size(140, 17)
        lblB6SummaryTime.TabIndex = 3
        lblB6SummaryTime.Text = "08:00 AM (1h 20m)"

        pnlB6SumDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlB6SumDivider.Location = New Point(25, 300)
        pnlB6SumDivider.Name = "pnlB6SumDivider"
        pnlB6SumDivider.Size = New Size(255, 1)
        pnlB6SumDivider.TabIndex = 4

        lblB6SummaryTotalLabel.AutoSize = True
        lblB6SummaryTotalLabel.Font = New Font("Segoe UI", 10.0F)
        lblB6SummaryTotalLabel.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblB6SummaryTotalLabel.Location = New Point(25, 320)
        lblB6SummaryTotalLabel.Name = "lblB6SummaryTotalLabel"
        lblB6SummaryTotalLabel.Size = New Size(100, 19)
        lblB6SummaryTotalLabel.TabIndex = 5
        lblB6SummaryTotalLabel.Text = "Estimated Total"

        lblB6SummaryTotalAmount.AutoSize = True
        lblB6SummaryTotalAmount.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblB6SummaryTotalAmount.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblB6SummaryTotalAmount.Location = New Point(20, 345)
        lblB6SummaryTotalAmount.Name = "lblB6SummaryTotalAmount"
        lblB6SummaryTotalAmount.Size = New Size(185, 37)
        lblB6SummaryTotalAmount.TabIndex = 6
        lblB6SummaryTotalAmount.Text = "PHP 3,690.00"

        btnB6Back.Animated = True
        btnB6Back.BorderColor = Color.FromArgb(CByte(190), CByte(190), CByte(200))
        btnB6Back.BorderRadius = 12
        btnB6Back.BorderThickness = 1
        btnB6Back.Cursor = Cursors.Hand
        btnB6Back.FillColor = Color.Transparent
        btnB6Back.Font = New Font("Segoe UI", 10.0F)
        btnB6Back.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        btnB6Back.Location = New Point(20, 420)
        btnB6Back.Name = "btnB6Back"
        btnB6Back.Size = New Size(80, 45)
        btnB6Back.TabIndex = 7
        btnB6Back.Text = "← Back"

        btnB6Pay.Animated = True
        btnB6Pay.BorderRadius = 12
        btnB6Pay.Cursor = Cursors.Hand
        btnB6Pay.FillColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        btnB6Pay.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnB6Pay.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnB6Pay.Location = New Point(110, 420)
        btnB6Pay.Name = "btnB6Pay"
        btnB6Pay.Size = New Size(175, 45)
        btnB6Pay.TabIndex = 8
        btnB6Pay.Text = "Checkout →"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(1020, 600)
        Controls.Add(pnlBody)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingStep6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INOM Air - Refundability"

        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlB6LeftRefund.ResumeLayout(False)
        pnlB6LeftRefund.PerformLayout()
        pnlOption1.ResumeLayout(False)
        pnlOption1.PerformLayout()
        pnlOption2.ResumeLayout(False)
        pnlOption2.PerformLayout()
        pnlNoticeCard.ResumeLayout(False)
        pnlNoticeCard.PerformLayout()
        pnlB6RightSummary.ResumeLayout(False)
        pnlB6RightSummary.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblBrandHeader As Label
    Friend WithEvents lblStepTitle As Label
    Friend WithEvents btnCloseX As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlB6LeftRefund As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB6Title As Label
    Friend WithEvents lblB6Subtitle As Label
    Friend WithEvents pnlOption1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rbB6NonRefundable As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblOption1Desc As Label
    Friend WithEvents pnlOption2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents rbB6Refundable As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblOption2Desc As Label
    Friend WithEvents pnlNoticeCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblNoticeHeader As Label
    Friend WithEvents lblNoticeText As Label
    Friend WithEvents pnlB6RightSummary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblB6SummaryHeader As Label
    Friend WithEvents lblB6SummaryDate As Label
    Friend WithEvents lblB6SummaryRoute As Label
    Friend WithEvents lblB6SummaryTime As Label
    Friend WithEvents pnlB6SumDivider As Panel
    Friend WithEvents lblB6SummaryTotalLabel As Label
    Friend WithEvents lblB6SummaryTotalAmount As Label
    Friend WithEvents btnB6Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnB6Pay As Guna.UI2.WinForms.Guna2Button

End Class
