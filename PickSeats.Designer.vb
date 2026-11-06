<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickSeats
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
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlTopBar = New Guna.UI2.WinForms.Guna2Panel()
        lblTitle = New Label()
        btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlAirplaneFuselage = New Guna.UI2.WinForms.Guna2Panel()
        lblCockpit = New Label()
        flpSeatGrid = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        pnlRightDetails = New Guna.UI2.WinForms.Guna2Panel()
        lblSelectedSeatTitle = New Label()
        lblSelectedSeatDisplay = New Label()
        lblClassDisplay = New Label()
        lblLegendTitle = New Label()
        lblLegendAvailable = New Label()
        lblLegendSelected = New Label()
        lblLegendOccupied = New Label()
        btnConfirmSeat = New Guna.UI2.WinForms.Guna2Button()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        pnlTopBar.SuspendLayout()
        pnlAirplaneFuselage.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlRightDetails.SuspendLayout()
        SuspendLayout()
        Guna2BorderlessForm1.BorderRadius = 24
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        pnlTopBar.Controls.Add(lblTitle)
        pnlTopBar.Controls.Add(btnClose)
        pnlTopBar.CustomizableEdges = CustomizableEdges10
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        pnlTopBar.Size = New Size(880, 50)
        pnlTopBar.TabIndex = 0
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(301, 21)
        lblTitle.TabIndex = 0
        lblTitle.Text = "✈ INOM Air — Aircraft Seat Selection"
        btnClose.Animated = True
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(836, 10)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "✕"
        pnlAirplaneFuselage.BackColor = Color.Transparent
        pnlAirplaneFuselage.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(215))
        pnlAirplaneFuselage.BorderRadius = 30
        pnlAirplaneFuselage.BorderThickness = 2
        pnlAirplaneFuselage.Controls.Add(flpSeatGrid)
        pnlAirplaneFuselage.Controls.Add(PictureBox1)
        pnlAirplaneFuselage.Controls.Add(lblCockpit)
        pnlAirplaneFuselage.CustomizableEdges = CustomizableEdges7
        pnlAirplaneFuselage.FillColor = Color.White
        pnlAirplaneFuselage.Location = New Point(30, 70)
        pnlAirplaneFuselage.Name = "pnlAirplaneFuselage"
        pnlAirplaneFuselage.ShadowDecoration.BorderRadius = 30
        pnlAirplaneFuselage.ShadowDecoration.Color = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        pnlAirplaneFuselage.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlAirplaneFuselage.ShadowDecoration.Enabled = True
        pnlAirplaneFuselage.Size = New Size(540, 420)
        pnlAirplaneFuselage.TabIndex = 1
        lblCockpit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCockpit.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        lblCockpit.Location = New Point(20, 15)
        lblCockpit.Name = "lblCockpit"
        lblCockpit.Size = New Size(500, 25)
        lblCockpit.TabIndex = 0
        lblCockpit.Text = "◀ COCKPIT / FRONT OF CABIN"
        lblCockpit.TextAlign = ContentAlignment.MiddleCenter
        flpSeatGrid.AutoScroll = True
        flpSeatGrid.Location = New Point(20, 50)
        flpSeatGrid.Name = "flpSeatGrid"
        flpSeatGrid.Padding = New Padding(10)
        flpSeatGrid.Size = New Size(500, 350)
        flpSeatGrid.TabIndex = 1
        PictureBox1.Image = My.Resources.Resources._66ba3ddf_8faf_4108_a1e3_2e78fb6e00b3NOBG
        PictureBox1.Location = New Point(398, -14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        pnlRightDetails.BackColor = Color.Transparent
        pnlRightDetails.BorderColor = Color.FromArgb(CByte(215), CByte(215), CByte(220))
        pnlRightDetails.BorderRadius = 24
        pnlRightDetails.BorderThickness = 1
        pnlRightDetails.Controls.Add(lblSelectedSeatTitle)
        pnlRightDetails.Controls.Add(lblSelectedSeatDisplay)
        pnlRightDetails.Controls.Add(lblClassDisplay)
        pnlRightDetails.Controls.Add(lblLegendTitle)
        pnlRightDetails.Controls.Add(lblLegendAvailable)
        pnlRightDetails.Controls.Add(lblLegendSelected)
        pnlRightDetails.Controls.Add(lblLegendOccupied)
        pnlRightDetails.Controls.Add(btnConfirmSeat)
        pnlRightDetails.Controls.Add(btnCancel)
        pnlRightDetails.CustomizableEdges = CustomizableEdges5
        pnlRightDetails.FillColor = Color.White
        pnlRightDetails.Location = New Point(590, 70)
        pnlRightDetails.Name = "pnlRightDetails"
        pnlRightDetails.ShadowDecoration.BorderRadius = 24
        pnlRightDetails.ShadowDecoration.Color = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        pnlRightDetails.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlRightDetails.ShadowDecoration.Enabled = True
        pnlRightDetails.Size = New Size(260, 420)
        pnlRightDetails.TabIndex = 2
        lblSelectedSeatTitle.Font = New Font("Segoe UI", 11F)
        lblSelectedSeatTitle.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(100))
        lblSelectedSeatTitle.Location = New Point(20, 20)
        lblSelectedSeatTitle.Name = "lblSelectedSeatTitle"
        lblSelectedSeatTitle.Size = New Size(220, 22)
        lblSelectedSeatTitle.TabIndex = 0
        lblSelectedSeatTitle.Text = "Selected Seat:"
        lblSelectedSeatTitle.TextAlign = ContentAlignment.MiddleCenter
        lblSelectedSeatDisplay.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblSelectedSeatDisplay.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblSelectedSeatDisplay.Location = New Point(20, 45)
        lblSelectedSeatDisplay.Name = "lblSelectedSeatDisplay"
        lblSelectedSeatDisplay.Size = New Size(220, 50)
        lblSelectedSeatDisplay.TabIndex = 1
        lblSelectedSeatDisplay.Text = "1A"
        lblSelectedSeatDisplay.TextAlign = ContentAlignment.MiddleCenter
        lblClassDisplay.Font = New Font("Segoe UI", 10F, FontStyle.Italic)
        lblClassDisplay.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        lblClassDisplay.Location = New Point(20, 95)
        lblClassDisplay.Name = "lblClassDisplay"
        lblClassDisplay.Size = New Size(220, 22)
        lblClassDisplay.TabIndex = 2
        lblClassDisplay.Text = "Cabin: Economy Class"
        lblClassDisplay.TextAlign = ContentAlignment.MiddleCenter
        lblLegendTitle.AutoSize = True
        lblLegendTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblLegendTitle.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        lblLegendTitle.Location = New Point(25, 140)
        lblLegendTitle.Name = "lblLegendTitle"
        lblLegendTitle.Size = New Size(95, 19)
        lblLegendTitle.TabIndex = 3
        lblLegendTitle.Text = "Seat Legend:"
        lblLegendAvailable.AutoSize = True
        lblLegendAvailable.Font = New Font("Segoe UI", 9.5F)
        lblLegendAvailable.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblLegendAvailable.Location = New Point(25, 170)
        lblLegendAvailable.Name = "lblLegendAvailable"
        lblLegendAvailable.Size = New Size(132, 17)
        lblLegendAvailable.TabIndex = 4
        lblLegendAvailable.Text = "■ Available (Regular)"
        lblLegendSelected.AutoSize = True
        lblLegendSelected.Font = New Font("Segoe UI", 9.5F)
        lblLegendSelected.ForeColor = Color.FromArgb(CByte(200), CByte(150), CByte(0))
        lblLegendSelected.Location = New Point(25, 200)
        lblLegendSelected.Name = "lblLegendSelected"
        lblLegendSelected.Size = New Size(115, 17)
        lblLegendSelected.TabIndex = 5
        lblLegendSelected.Text = "■ Selected by You"
        lblLegendOccupied.AutoSize = True
        lblLegendOccupied.Font = New Font("Segoe UI", 9.5F)
        lblLegendOccupied.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(170))
        lblLegendOccupied.Location = New Point(25, 230)
        lblLegendOccupied.Name = "lblLegendOccupied"
        lblLegendOccupied.Size = New Size(78, 17)
        lblLegendOccupied.TabIndex = 6
        lblLegendOccupied.Text = "■ Occupied"
        btnConfirmSeat.Animated = True
        btnConfirmSeat.BorderRadius = 14
        btnConfirmSeat.Cursor = Cursors.Hand
        btnConfirmSeat.CustomizableEdges = CustomizableEdges1
        btnConfirmSeat.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnConfirmSeat.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnConfirmSeat.ForeColor = Color.White
        btnConfirmSeat.Location = New Point(25, 280)
        btnConfirmSeat.Name = "btnConfirmSeat"
        btnConfirmSeat.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnConfirmSeat.Size = New Size(210, 48)
        btnConfirmSeat.TabIndex = 7
        btnConfirmSeat.Text = "Confirm Seat "
        btnCancel.Animated = True
        btnCancel.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(215))
        btnCancel.BorderRadius = 14
        btnCancel.BorderThickness = 1
        btnCancel.Cursor = Cursors.Hand
        btnCancel.CustomizableEdges = CustomizableEdges3
        btnCancel.FillColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(90))
        btnCancel.Location = New Point(25, 345)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancel.Size = New Size(210, 42)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(229), CByte(216))
        ClientSize = New Size(880, 520)
        Controls.Add(pnlRightDetails)
        Controls.Add(pnlAirplaneFuselage)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "PickSeats"
        StartPosition = FormStartPosition.CenterParent
        Text = "Seat Selection"
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlAirplaneFuselage.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlRightDetails.ResumeLayout(False)
        pnlRightDetails.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlAirplaneFuselage As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCockpit As Label
    Friend WithEvents flpSeatGrid As FlowLayoutPanel
    Friend WithEvents pnlRightDetails As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSelectedSeatTitle As Label
    Friend WithEvents lblSelectedSeatDisplay As Label
    Friend WithEvents lblClassDisplay As Label
    Friend WithEvents lblLegendTitle As Label
    Friend WithEvents lblLegendAvailable As Label
    Friend WithEvents lblLegendSelected As Label
    Friend WithEvents lblLegendOccupied As Label
    Friend WithEvents btnConfirmSeat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
