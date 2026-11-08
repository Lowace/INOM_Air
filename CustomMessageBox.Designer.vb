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
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMessageBox))
        pnlBorder = New Guna.UI2.WinForms.Guna2Panel()
        pnlBody = New Panel()
        rtbScrollMessage = New RichTextBox()
        lblMessage = New Label()
        iconCircle = New Guna.UI2.WinForms.Guna2Panel()
        lblIconSymbol = New Label()
        pnlDivider = New Panel()
        pnlFooter = New Panel()
        lblScrollHint = New Label()
        btnSecondary = New Guna.UI2.WinForms.Guna2Button()
        btnPrimary = New Guna.UI2.WinForms.Guna2Button()
        pnlHeader = New Panel()
        lblTitle = New Label()
        btnCloseHeader = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pnlBorder.SuspendLayout()
        pnlBody.SuspendLayout()
        iconCircle.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        pnlBorder.BackColor = Color.Transparent
        pnlBorder.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        pnlBorder.BorderRadius = 18
        pnlBorder.BorderThickness = 1
        pnlBorder.Controls.Add(pnlBody)
        pnlBorder.Controls.Add(pnlDivider)
        pnlBorder.Controls.Add(pnlFooter)
        pnlBorder.Controls.Add(pnlHeader)
        pnlBorder.CustomizableEdges = CustomizableEdges10
        pnlBorder.Dock = DockStyle.Fill
        pnlBorder.FillColor = Color.White
        pnlBorder.Location = New Point(0, 0)
        pnlBorder.Name = "pnlBorder"
        pnlBorder.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        pnlBorder.Size = New Size(500, 220)
        pnlBorder.TabIndex = 0
        pnlBody.BackColor = Color.White
        pnlBody.Controls.Add(rtbScrollMessage)
        pnlBody.Controls.Add(lblMessage)
        pnlBody.Controls.Add(iconCircle)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 50)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(500, 111)
        pnlBody.TabIndex = 1
        rtbScrollMessage.BackColor = Color.White
        rtbScrollMessage.BorderStyle = BorderStyle.None
        rtbScrollMessage.Font = New Font("Segoe UI", 9.5F)
        rtbScrollMessage.ForeColor = Color.FromArgb(CByte(45), CByte(50), CByte(58))
        rtbScrollMessage.Location = New Point(24, 10)
        rtbScrollMessage.Name = "rtbScrollMessage"
        rtbScrollMessage.ReadOnly = True
        rtbScrollMessage.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbScrollMessage.Size = New Size(452, 92)
        rtbScrollMessage.TabIndex = 3
        rtbScrollMessage.Text = ""
        rtbScrollMessage.Visible = False
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Segoe UI", 9.75F)
        lblMessage.ForeColor = Color.FromArgb(CByte(45), CByte(50), CByte(58))
        lblMessage.Location = New Point(82, 16)
        lblMessage.MaximumSize = New Size(400, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(61, 17)
        lblMessage.TabIndex = 2
        lblMessage.Text = "Message"
        iconCircle.BackColor = Color.Transparent
        iconCircle.BorderRadius = 22
        iconCircle.Controls.Add(lblIconSymbol)
        iconCircle.CustomizableEdges = CustomizableEdges12
        iconCircle.FillColor = Color.FromArgb(CByte(230), CByte(246), CByte(245))
        iconCircle.Location = New Point(24, 14)
        iconCircle.Name = "iconCircle"
        iconCircle.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        iconCircle.Size = New Size(44, 44)
        iconCircle.TabIndex = 1
        lblIconSymbol.BackColor = Color.Transparent
        lblIconSymbol.Dock = DockStyle.Fill
        lblIconSymbol.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
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
        pnlDivider.TabIndex = 2
        pnlFooter.BackColor = Color.FromArgb(CByte(250), CByte(251), CByte(253))
        pnlFooter.Controls.Add(lblScrollHint)
        pnlFooter.Controls.Add(btnSecondary)
        pnlFooter.Controls.Add(btnPrimary)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 162)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(500, 58)
        pnlFooter.TabIndex = 3
        lblScrollHint.AutoSize = True
        lblScrollHint.BackColor = Color.Transparent
        lblScrollHint.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic)
        lblScrollHint.ForeColor = Color.FromArgb(CByte(140), CByte(145), CByte(155))
        lblScrollHint.Location = New Point(24, 20)
        lblScrollHint.Name = "lblScrollHint"
        lblScrollHint.Size = New Size(203, 15)
        lblScrollHint.TabIndex = 2
        lblScrollHint.Text = "⬇ Please scroll to the bottom to accept"
        lblScrollHint.Visible = False
        btnSecondary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSecondary.Animated = True
        btnSecondary.BorderColor = Color.FromArgb(CByte(215), CByte(218), CByte(225))
        btnSecondary.BorderRadius = 10
        btnSecondary.BorderThickness = 1
        btnSecondary.Cursor = Cursors.Hand
        btnSecondary.CustomizableEdges = CustomizableEdges14
        btnSecondary.FillColor = Color.White
        btnSecondary.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSecondary.ForeColor = Color.FromArgb(CByte(90), CByte(95), CByte(105))
        btnSecondary.Location = New Point(280, 11)
        btnSecondary.Name = "btnSecondary"
        btnSecondary.ShadowDecoration.CustomizableEdges = CustomizableEdges15
        btnSecondary.Size = New Size(90, 36)
        btnSecondary.TabIndex = 1
        btnSecondary.Text = "Cancel"
        btnSecondary.Visible = False
        btnPrimary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnPrimary.Animated = True
        btnPrimary.BorderRadius = 10
        btnPrimary.Cursor = Cursors.Hand
        btnPrimary.CustomizableEdges = CustomizableEdges16
        btnPrimary.DisabledState.BorderColor = Color.FromArgb(CByte(215), CByte(218), CByte(225))
        btnPrimary.DisabledState.FillColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        btnPrimary.DisabledState.ForeColor = Color.FromArgb(CByte(140), CByte(145), CByte(155))
        btnPrimary.FillColor = Color.FromArgb(CByte(1), CByte(123), CByte(128))
        btnPrimary.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnPrimary.ForeColor = Color.White
        btnPrimary.Location = New Point(384, 11)
        btnPrimary.Name = "btnPrimary"
        btnPrimary.ShadowDecoration.CustomizableEdges = CustomizableEdges17
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
        lblTitle.UseMnemonic = False
        btnCloseHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCloseHeader.Animated = True
        btnCloseHeader.BackColor = Color.Transparent
        btnCloseHeader.Cursor = Cursors.Hand
        btnCloseHeader.FillColor = Color.FromArgb(CByte(245), CByte(245), CByte(248))
        btnCloseHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnCloseHeader.ForeColor = Color.FromArgb(CByte(120), CByte(125), CByte(135))
        btnCloseHeader.Location = New Point(458, 12)
        btnCloseHeader.Name = "btnCloseHeader"
        btnCloseHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnCloseHeader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnCloseHeader.Size = New Size(28, 28)
        btnCloseHeader.TabIndex = 1
        btnCloseHeader.Text = "✕"
        Guna2Elipse1.BorderRadius = 30
        Guna2Elipse1.TargetControl = Me
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        iconCircle.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        pnlFooter.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBorder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCloseHeader As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pnlBody As Panel
    Friend WithEvents iconCircle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblIconSymbol As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents rtbScrollMessage As RichTextBox
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblScrollHint As Label
    Friend WithEvents btnPrimary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSecondary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
