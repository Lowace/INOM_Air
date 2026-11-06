<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BoardingTicket
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
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        lblPlaneLogo = New Label()
        lblAirlineTitle = New Label()
        lblItineraryTag = New Label()
        btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlTicketCard = New Guna.UI2.WinForms.Guna2Panel()
        lblFlightDetailsHeader = New Label()
        lblPassengerLabel = New Label()
        lblPassengerName = New Label()
        lblGateLabel = New Label()
        lblGateValue = New Label()
        lblSeatLabel = New Label()
        lblSeatValue = New Label()
        lblTimeLabel = New Label()
        lblTimeValue = New Label()
        lblFlightNoLabel = New Label()
        lblFlightNoValue = New Label()
        lblFromLabel = New Label()
        lblFromValue = New Label()
        lblToLabel = New Label()
        lblToValue = New Label()
        lblClassLabel = New Label()
        lblClassValue = New Label()
        pnlDottedSeparator = New Guna.UI2.WinForms.Guna2Panel()
        lblTicketBarcode = New Label()
        lblTicketId = New Label()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        pnlTopBar.SuspendLayout()
        pnlTicketCard.SuspendLayout()
        SuspendLayout()
        Guna2BorderlessForm1.BorderRadius = 24
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        pnlTopBar.BackColor = Color.Transparent
        pnlTopBar.Controls.Add(lblPlaneLogo)
        pnlTopBar.Controls.Add(lblAirlineTitle)
        pnlTopBar.Controls.Add(lblItineraryTag)
        pnlTopBar.Controls.Add(btnClose)
        pnlTopBar.CustomizableEdges = CustomizableEdges8
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        pnlTopBar.Size = New Size(760, 56)
        pnlTopBar.TabIndex = 0
        lblPlaneLogo.Font = New Font("Segoe UI Emoji", 20F)
        lblPlaneLogo.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        lblPlaneLogo.Location = New Point(20, 8)
        lblPlaneLogo.Name = "lblPlaneLogo"
        lblPlaneLogo.Size = New Size(40, 40)
        lblPlaneLogo.TabIndex = 0
        lblPlaneLogo.Text = "✈"
        lblPlaneLogo.TextAlign = ContentAlignment.MiddleCenter
        lblAirlineTitle.AutoSize = True
        lblAirlineTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblAirlineTitle.ForeColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        lblAirlineTitle.Location = New Point(68, 17)
        lblAirlineTitle.Name = "lblAirlineTitle"
        lblAirlineTitle.Size = New Size(255, 21)
        lblAirlineTitle.TabIndex = 1
        lblAirlineTitle.Text = "INTERNATIONAL NOM AIRLINES"
        lblItineraryTag.AutoSize = True
        lblItineraryTag.Font = New Font("Segoe UI", 13F, FontStyle.Italic)
        lblItineraryTag.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblItineraryTag.Location = New Point(610, 15)
        lblItineraryTag.Name = "lblItineraryTag"
        lblItineraryTag.Size = New Size(78, 25)
        lblItineraryTag.TabIndex = 2
        lblItineraryTag.Text = "Itinerary"
        btnClose.Animated = True
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnClose.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(715, 14)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnClose.Size = New Size(28, 28)
        btnClose.TabIndex = 3
        btnClose.Text = "✕"
        pnlTicketCard.BackColor = Color.Transparent
        pnlTicketCard.BorderColor = Color.FromArgb(CByte(215), CByte(215), CByte(220))
        pnlTicketCard.BorderRadius = 20
        pnlTicketCard.BorderThickness = 1
        pnlTicketCard.Controls.Add(lblFlightDetailsHeader)
        pnlTicketCard.Controls.Add(lblPassengerLabel)
        pnlTicketCard.Controls.Add(lblPassengerName)
        pnlTicketCard.Controls.Add(lblGateLabel)
        pnlTicketCard.Controls.Add(lblGateValue)
        pnlTicketCard.Controls.Add(lblSeatLabel)
        pnlTicketCard.Controls.Add(lblSeatValue)
        pnlTicketCard.Controls.Add(lblTimeLabel)
        pnlTicketCard.Controls.Add(lblTimeValue)
        pnlTicketCard.Controls.Add(lblFlightNoLabel)
        pnlTicketCard.Controls.Add(lblFlightNoValue)
        pnlTicketCard.Controls.Add(lblFromLabel)
        pnlTicketCard.Controls.Add(lblFromValue)
        pnlTicketCard.Controls.Add(lblToLabel)
        pnlTicketCard.Controls.Add(lblToValue)
        pnlTicketCard.Controls.Add(lblClassLabel)
        pnlTicketCard.Controls.Add(lblClassValue)
        pnlTicketCard.Controls.Add(pnlDottedSeparator)
        pnlTicketCard.Controls.Add(lblTicketBarcode)
        pnlTicketCard.Controls.Add(lblTicketId)
        pnlTicketCard.Controls.Add(btnBack)
        pnlTicketCard.CustomizableEdges = CustomizableEdges5
        pnlTicketCard.FillColor = Color.White
        pnlTicketCard.Location = New Point(30, 80)
        pnlTicketCard.Name = "pnlTicketCard"
        pnlTicketCard.ShadowDecoration.BorderRadius = 20
        pnlTicketCard.ShadowDecoration.Color = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        pnlTicketCard.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlTicketCard.ShadowDecoration.Enabled = True
        pnlTicketCard.Size = New Size(700, 390)
        pnlTicketCard.TabIndex = 1
        lblFlightDetailsHeader.AutoSize = True
        lblFlightDetailsHeader.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblFlightDetailsHeader.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblFlightDetailsHeader.Location = New Point(40, 25)
        lblFlightDetailsHeader.Name = "lblFlightDetailsHeader"
        lblFlightDetailsHeader.Size = New Size(123, 25)
        lblFlightDetailsHeader.TabIndex = 0
        lblFlightDetailsHeader.Text = "Flight Details"
        lblPassengerLabel.AutoSize = True
        lblPassengerLabel.Font = New Font("Segoe UI", 9.5F)
        lblPassengerLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblPassengerLabel.Location = New Point(40, 65)
        lblPassengerLabel.Name = "lblPassengerLabel"
        lblPassengerLabel.Size = New Size(107, 17)
        lblPassengerLabel.TabIndex = 1
        lblPassengerLabel.Text = "Passenger name:"
        lblPassengerName.AutoSize = True
        lblPassengerName.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblPassengerName.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblPassengerName.Location = New Point(40, 85)
        lblPassengerName.Name = "lblPassengerName"
        lblPassengerName.Size = New Size(159, 25)
        lblPassengerName.TabIndex = 2
        lblPassengerName.Text = "Naruto Uzumaki"
        lblGateLabel.AutoSize = True
        lblGateLabel.Font = New Font("Segoe UI", 9.5F)
        lblGateLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblGateLabel.Location = New Point(40, 140)
        lblGateLabel.Name = "lblGateLabel"
        lblGateLabel.Size = New Size(35, 17)
        lblGateLabel.TabIndex = 3
        lblGateLabel.Text = "Gate"
        lblGateValue.AutoSize = True
        lblGateValue.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblGateValue.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblGateValue.Location = New Point(40, 160)
        lblGateValue.Name = "lblGateValue"
        lblGateValue.Size = New Size(41, 30)
        lblGateValue.TabIndex = 4
        lblGateValue.Text = "A1"
        lblSeatLabel.AutoSize = True
        lblSeatLabel.Font = New Font("Segoe UI", 9.5F)
        lblSeatLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblSeatLabel.Location = New Point(40, 205)
        lblSeatLabel.Name = "lblSeatLabel"
        lblSeatLabel.Size = New Size(33, 17)
        lblSeatLabel.TabIndex = 5
        lblSeatLabel.Text = "Seat"
        lblSeatValue.AutoSize = True
        lblSeatValue.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblSeatValue.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblSeatValue.Location = New Point(40, 225)
        lblSeatValue.Name = "lblSeatValue"
        lblSeatValue.Size = New Size(41, 30)
        lblSeatValue.TabIndex = 6
        lblSeatValue.Text = "1A"
        lblTimeLabel.AutoSize = True
        lblTimeLabel.Font = New Font("Segoe UI", 9.5F)
        lblTimeLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblTimeLabel.Location = New Point(40, 270)
        lblTimeLabel.Name = "lblTimeLabel"
        lblTimeLabel.Size = New Size(36, 17)
        lblTimeLabel.TabIndex = 7
        lblTimeLabel.Text = "Time"
        lblTimeValue.AutoSize = True
        lblTimeValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTimeValue.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblTimeValue.Location = New Point(40, 290)
        lblTimeValue.Name = "lblTimeValue"
        lblTimeValue.Size = New Size(97, 25)
        lblTimeValue.TabIndex = 8
        lblTimeValue.Text = "10:30 AM"
        lblFlightNoLabel.AutoSize = True
        lblFlightNoLabel.Font = New Font("Segoe UI", 9.5F)
        lblFlightNoLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblFlightNoLabel.Location = New Point(320, 65)
        lblFlightNoLabel.Name = "lblFlightNoLabel"
        lblFlightNoLabel.Size = New Size(59, 17)
        lblFlightNoLabel.TabIndex = 9
        lblFlightNoLabel.Text = "flight no."
        lblFlightNoValue.AutoSize = True
        lblFlightNoValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblFlightNoValue.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblFlightNoValue.Location = New Point(420, 60)
        lblFlightNoValue.Name = "lblFlightNoValue"
        lblFlightNoValue.Size = New Size(136, 25)
        lblFlightNoValue.TabIndex = 10
        lblFlightNoValue.Text = "F001 / Boeing"
        lblFromLabel.AutoSize = True
        lblFromLabel.Font = New Font("Segoe UI", 9.5F)
        lblFromLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblFromLabel.Location = New Point(320, 120)
        lblFromLabel.Name = "lblFromLabel"
        lblFromLabel.Size = New Size(36, 17)
        lblFromLabel.TabIndex = 11
        lblFromLabel.Text = "from"
        lblFromValue.AutoSize = True
        lblFromValue.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblFromValue.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblFromValue.Location = New Point(420, 115)
        lblFromValue.Name = "lblFromValue"
        lblFromValue.Size = New Size(173, 25)
        lblFromValue.TabIndex = 12
        lblFromValue.Text = "Manila, Philippines"
        lblToLabel.AutoSize = True
        lblToLabel.Font = New Font("Segoe UI", 9.5F)
        lblToLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblToLabel.Location = New Point(320, 175)
        lblToLabel.Name = "lblToLabel"
        lblToLabel.Size = New Size(20, 17)
        lblToLabel.TabIndex = 13
        lblToLabel.Text = "to"
        lblToValue.AutoSize = True
        lblToValue.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblToValue.ForeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        lblToValue.Location = New Point(420, 170)
        lblToValue.Name = "lblToValue"
        lblToValue.Size = New Size(158, 25)
        lblToValue.TabIndex = 14
        lblToValue.Text = "Cebu, Philippines"
        lblClassLabel.AutoSize = True
        lblClassLabel.Font = New Font("Segoe UI", 9.5F)
        lblClassLabel.ForeColor = Color.FromArgb(CByte(110), CByte(110), CByte(125))
        lblClassLabel.Location = New Point(320, 230)
        lblClassLabel.Name = "lblClassLabel"
        lblClassLabel.Size = New Size(36, 17)
        lblClassLabel.TabIndex = 15
        lblClassLabel.Text = "class"
        lblClassValue.AutoSize = True
        lblClassValue.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblClassValue.ForeColor = Color.FromArgb(CByte(254), CByte(115), CByte(73))
        lblClassValue.Location = New Point(420, 225)
        lblClassValue.Name = "lblClassValue"
        lblClassValue.Size = New Size(137, 25)
        lblClassValue.TabIndex = 16
        lblClassValue.Text = "Economy Class"
        pnlDottedSeparator.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(235))
        pnlDottedSeparator.CustomizableEdges = CustomizableEdges1
        pnlDottedSeparator.Location = New Point(40, 335)
        pnlDottedSeparator.Name = "pnlDottedSeparator"
        pnlDottedSeparator.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlDottedSeparator.Size = New Size(620, 2)
        pnlDottedSeparator.TabIndex = 17
        lblTicketBarcode.AutoSize = True
        lblTicketBarcode.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblTicketBarcode.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(150))
        lblTicketBarcode.Location = New Point(40, 350)
        lblTicketBarcode.Name = "lblTicketBarcode"
        lblTicketBarcode.Size = New Size(148, 15)
        lblTicketBarcode.TabIndex = 18
        lblTicketBarcode.Text = "||| | || |||| | | ||| || |||||| | ||| |||| | ||"
        lblTicketId.AutoSize = True
        lblTicketId.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTicketId.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        lblTicketId.Location = New Point(290, 350)
        lblTicketId.Name = "lblTicketId"
        lblTicketId.Size = New Size(142, 15)
        lblTicketId.TabIndex = 19
        lblTicketId.Text = "Ticket: INOM-88239014"
        btnBack.Animated = True
        btnBack.BorderRadius = 12
        btnBack.Cursor = Cursors.Hand
        btnBack.CustomizableEdges = CustomizableEdges3
        btnBack.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnBack.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(540, 345)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBack.Size = New Size(120, 36)
        btnBack.TabIndex = 20
        btnBack.Text = "Back"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(760, 500)
        Controls.Add(pnlTicketCard)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "BoardingTicket"
        StartPosition = FormStartPosition.CenterParent
        Text = "Boarding Ticket"
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlTicketCard.ResumeLayout(False)
        pnlTicketCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPlaneLogo As Label
    Friend WithEvents lblAirlineTitle As Label
    Friend WithEvents lblItineraryTag As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlTicketCard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFlightDetailsHeader As Label
    Friend WithEvents lblPassengerLabel As Label
    Friend WithEvents lblPassengerName As Label
    Friend WithEvents lblGateLabel As Label
    Friend WithEvents lblGateValue As Label
    Friend WithEvents lblSeatLabel As Label
    Friend WithEvents lblSeatValue As Label
    Friend WithEvents lblTimeLabel As Label
    Friend WithEvents lblTimeValue As Label
    Friend WithEvents lblFlightNoLabel As Label
    Friend WithEvents lblFlightNoValue As Label
    Friend WithEvents lblFromLabel As Label
    Friend WithEvents lblFromValue As Label
    Friend WithEvents lblToLabel As Label
    Friend WithEvents lblToValue As Label
    Friend WithEvents lblClassLabel As Label
    Friend WithEvents lblClassValue As Label
    Friend WithEvents pnlDottedSeparator As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTicketBarcode As Label
    Friend WithEvents lblTicketId As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button

End Class
