<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomMessageBox
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMessageBox))
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlBorder = New Guna.UI2.WinForms.Guna2Panel()
        lblMessage = New Label()
        iconCircle = New Guna.UI2.WinForms.Guna2Panel()
        lblIconSymbol = New Label()
        pnlDivider = New Panel()
        pnlFooter = New Panel()
        btnSecondary = New Guna.UI2.WinForms.Guna2Button()
        btnPrimary = New Guna.UI2.WinForms.Guna2Button()
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnCloseHeader = New Guna.UI2.WinForms.Guna2CircleButton()
        pnlBorder.SuspendLayout()
        iconCircle.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        Guna2BorderlessForm1.BorderRadius = 18
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        pnlBorder.BackColor = Color.Transparent
        pnlBorder.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        pnlBorder.BorderRadius = 18
        pnlBorder.BorderThickness = 1
        pnlBorder.Controls.Add(lblMessage)
        pnlBorder.Controls.Add(iconCircle)
        pnlBorder.Controls.Add(pnlDivider)
        pnlBorder.Controls.Add(pnlFooter)
        pnlBorder.Controls.Add(pnlHeader)
        pnlBorder.CustomizableEdges = CustomizableEdges8
        pnlBorder.Dock = DockStyle.Fill
        pnlBorder.FillColor = Color.White
        pnlBorder.Location = New Point(0, 0)
        pnlBorder.Name = "pnlBorder"
        pnlBorder.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        pnlBorder.Size = New Size(500, 220)
        pnlBorder.TabIndex = 0
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Segoe UI", 9.75F)
        lblMessage.ForeColor = Color.FromArgb(CByte(45), CByte(50), CByte(58))
        lblMessage.Location = New Point(82, 64)
        lblMessage.MaximumSize = New Size(400, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(61, 17)
        lblMessage.TabIndex = 2
        lblMessage.Text = "Message"
        iconCircle.BackColor = Color.Transparent
        iconCircle.BorderRadius = 22
        iconCircle.Controls.Add(lblIconSymbol)
        iconCircle.CustomizableEdges = CustomizableEdges1
        iconCircle.FillColor = Color.FromArgb(CByte(230), CByte(246), CByte(245))
        iconCircle.Location = New Point(24, 62)
        iconCircle.Name = "iconCircle"
        iconCircle.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        iconCircle.Size = New Size(44, 44)
        iconCircle.TabIndex = 1
        lblIconSymbol.BackColor = Color.Transparent
        lblIconSymbol.Dock = DockStyle.Fill
        lblIconSymbol.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblIconSymbol.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblIconSymbol.Location = New Point(0, 0)
        lblIconSymbol.Name = "lblIconSymbol"
        lblIconSymbol.Size = New Size(44, 44)
        lblIconSymbol.TabIndex = 0
        lblIconSymbol.Text = "✓"
        lblIconSymbol.TextAlign = ContentAlignment.MiddleCenter
        pnlDivider.BackColor = Color.FromArgb(CByte(235), CByte(238), CByte(242))
        pnlDivider.Dock = DockStyle.Bottom
        pnlDivider.Location = New Point(0, 161)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(500, 1)
        pnlDivider.TabIndex = 3
        pnlFooter.BackColor = Color.FromArgb(CByte(250), CByte(251), CByte(253))
        pnlFooter.Controls.Add(btnSecondary)
        pnlFooter.Controls.Add(btnPrimary)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 162)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(500, 58)
        pnlFooter.TabIndex = 4
        btnSecondary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSecondary.Animated = True
        btnSecondary.BorderColor = Color.FromArgb(CByte(215), CByte(218), CByte(225))
        btnSecondary.BorderRadius = 10
        btnSecondary.BorderThickness = 1
        btnSecondary.Cursor = Cursors.Hand
        btnSecondary.CustomizableEdges = CustomizableEdges3
        btnSecondary.FillColor = Color.White
        btnSecondary.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSecondary.ForeColor = Color.FromArgb(CByte(90), CByte(95), CByte(105))
        btnSecondary.Location = New Point(280, 11)
        btnSecondary.Name = "btnSecondary"
        btnSecondary.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSecondary.Size = New Size(90, 36)
        btnSecondary.TabIndex = 1
        btnSecondary.Text = "Cancel"
        btnSecondary.Visible = False
        btnPrimary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnPrimary.Animated = True
        btnPrimary.BorderRadius = 10
        btnPrimary.Cursor = Cursors.Hand
        btnPrimary.CustomizableEdges = CustomizableEdges5
        btnPrimary.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnPrimary.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnPrimary.ForeColor = Color.White
        btnPrimary.Location = New Point(384, 11)
        btnPrimary.Name = "btnPrimary"
        btnPrimary.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnPrimary.Size = New Size(96, 36)
        btnPrimary.TabIndex = 0
        btnPrimary.Text = "OK"
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnCloseHeader)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(500, 50)
        pnlHeader.TabIndex = 0
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        lblTitle.Location = New Point(24, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(81, 21)
        lblTitle.TabIndex = 0
        lblTitle.Text = "INOM Air"
        btnCloseHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCloseHeader.Animated = True
        btnCloseHeader.BackColor = Color.Transparent
        btnCloseHeader.Cursor = Cursors.Hand
        btnCloseHeader.FillColor = Color.FromArgb(CByte(245), CByte(245), CByte(248))
        btnCloseHeader.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCloseHeader.ForeColor = Color.FromArgb(CByte(120), CByte(125), CByte(135))
        btnCloseHeader.Location = New Point(458, 12)
        btnCloseHeader.Name = "btnCloseHeader"
        btnCloseHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        btnCloseHeader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnCloseHeader.Size = New Size(28, 28)
        btnCloseHeader.TabIndex = 1
        btnCloseHeader.Text = "✕"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(500, 220)
        Controls.Add(pnlBorder)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CustomMessageBox"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "INOM Air"
        pnlBorder.ResumeLayout(False)
        pnlBorder.PerformLayout()
        iconCircle.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlBorder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCloseHeader As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents iconCircle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblIconSymbol As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnPrimary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSecondary As Guna.UI2.WinForms.Guna2Button
End Class
