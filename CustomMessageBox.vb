Imports System.Drawing
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

<System.ComponentModel.DesignerCategory("")>
Public Class CustomMessageBox

    Public Shared Function Show(message As String, Optional title As String = "INOM Air", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Dim active = Form.ActiveForm
        Using dlg As New MessageBoxDialog(message, title, buttons, icon)
            If active IsNot Nothing AndAlso Not active.IsDisposed AndAlso active.Visible Then
                Return dlg.ShowDialog(active)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function

    Public Shared Function Show(owner As IWin32Window, message As String, Optional title As String = "INOM Air", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Using dlg As New MessageBoxDialog(message, title, buttons, icon)
            If owner IsNot Nothing Then
                Return dlg.ShowDialog(owner)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function

    <System.ComponentModel.DesignerCategory("")>
    <System.ComponentModel.DesignTimeVisible(False)>
    <System.ComponentModel.ToolboxItem(False)>
    Private Class MessageBoxDialog
        Inherits Form

        Private pnlBorder As Guna2Panel
        Private pnlHeader As Panel
        Private lblTitle As Label
        Private btnCloseHeader As Guna2CircleButton
        Private iconCircle As Guna2Panel
        Private lblIconSymbol As Label
        Private lblMessage As Label
        Private pnlFooter As Panel
        Private pnlDivider As Panel
        Private btnPrimary As Guna2Button
        Private btnSecondary As Guna2Button
        Private shadowForm As Guna2ShadowForm
        Private dragCtrl As Guna2DragControl
        Private formElipse As Guna2Elipse

        Public Sub New(message As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
            Me.FormBorderStyle = FormBorderStyle.None
            Me.StartPosition = FormStartPosition.CenterParent
            Me.ShowInTaskbar = False
            Me.BackColor = Color.White

            formElipse = New Guna2Elipse()
            formElipse.TargetControl = Me
            formElipse.BorderRadius = 18

            shadowForm = New Guna2ShadowForm()
            shadowForm.TargetForm = Me
            shadowForm.BorderRadius = 18

            pnlBorder = New Guna2Panel With {
                .Dock = DockStyle.Fill,
                .FillColor = Color.White,
                .BorderRadius = 18,
                .BorderThickness = 1,
                .BorderColor = Color.FromArgb(220, 224, 230),
                .BackColor = Color.Transparent
            }
            Me.Controls.Add(pnlBorder)

            pnlHeader = New Panel With {
                .Dock = DockStyle.Top,
                .Height = 50,
                .BackColor = Color.White
            }
            pnlBorder.Controls.Add(pnlHeader)

            dragCtrl = New Guna2DragControl()
            dragCtrl.TargetControl = pnlHeader

            lblTitle = New Label With {
                .Text = If(String.IsNullOrWhiteSpace(title), "INOM Air", title),
                .Font = New Font("Segoe UI", 11.5F, FontStyle.Bold),
                .ForeColor = Color.FromArgb(1, 123, 128),
                .Location = New Point(24, 16),
                .AutoSize = True,
                .BackColor = Color.Transparent
            }
            pnlHeader.Controls.Add(lblTitle)

            btnCloseHeader = New Guna2CircleButton With {
                .Text = "✕",
                .Size = New Size(28, 28),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                .FillColor = Color.FromArgb(245, 245, 248),
                .ForeColor = Color.FromArgb(120, 125, 135),
                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .Cursor = Cursors.Hand
            }
            AddHandler btnCloseHeader.Click, Sub(s, e)
                                                 Me.DialogResult = If(buttons = MessageBoxButtons.YesNo, DialogResult.No, DialogResult.Cancel)
                                                 Me.Close()
                                             End Sub
            pnlHeader.Controls.Add(btnCloseHeader)

            iconCircle = New Guna2Panel With {
                .Size = New Size(44, 44),
                .BorderRadius = 22,
                .Location = New Point(24, 62),
                .BackColor = Color.Transparent
            }
            pnlBorder.Controls.Add(iconCircle)

            lblIconSymbol = New Label With {
                .Dock = DockStyle.Fill,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI", 15.0F, FontStyle.Bold),
                .BackColor = Color.Transparent
            }
            iconCircle.Controls.Add(lblIconSymbol)

            Select Case icon
                Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
                    iconCircle.FillColor = Color.FromArgb(254, 240, 240)
                    lblIconSymbol.ForeColor = Color.FromArgb(220, 53, 69)
                    lblIconSymbol.Text = "✕"
                Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
                    iconCircle.FillColor = Color.FromArgb(255, 244, 235)
                    lblIconSymbol.ForeColor = Color.FromArgb(254, 115, 73)
                    lblIconSymbol.Text = "!"
                Case MessageBoxIcon.Question
                    iconCircle.FillColor = Color.FromArgb(232, 243, 252)
                    lblIconSymbol.ForeColor = Color.FromArgb(13, 110, 253)
                    lblIconSymbol.Text = "?"
                Case Else
                    iconCircle.FillColor = Color.FromArgb(230, 246, 245)
                    lblIconSymbol.ForeColor = Color.FromArgb(1, 123, 128)
                    lblIconSymbol.Text = "✓"
            End Select

            lblMessage = New Label With {
                .Text = message,
                .Font = New Font("Segoe UI", 9.75F, FontStyle.Regular),
                .ForeColor = Color.FromArgb(45, 50, 58),
                .Location = New Point(82, 64),
                .AutoSize = True,
                .MaximumSize = New Size(420, 0),
                .BackColor = Color.Transparent
            }
            pnlBorder.Controls.Add(lblMessage)

            pnlFooter = New Panel With {
                .Dock = DockStyle.Bottom,
                .Height = 58,
                .BackColor = Color.FromArgb(250, 251, 253)
            }
            pnlBorder.Controls.Add(pnlFooter)

            pnlDivider = New Panel With {
                .Dock = DockStyle.Bottom,
                .Height = 1,
                .BackColor = Color.FromArgb(235, 238, 242)
            }
            pnlBorder.Controls.Add(pnlDivider)

            btnPrimary = New Guna2Button With {
                .BorderRadius = 10,
                .Cursor = Cursors.Hand,
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .ForeColor = Color.White,
                .FillColor = Color.FromArgb(1, 123, 128),
                .Size = New Size(96, 36),
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            }
            pnlFooter.Controls.Add(btnPrimary)

            btnSecondary = New Guna2Button With {
                .BorderRadius = 10,
                .Cursor = Cursors.Hand,
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .ForeColor = Color.FromArgb(90, 95, 105),
                .FillColor = Color.White,
                .BorderThickness = 1,
                .BorderColor = Color.FromArgb(215, 218, 225),
                .Size = New Size(90, 36),
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right,
                .Visible = False
            }
            pnlFooter.Controls.Add(btnSecondary)

            If buttons = MessageBoxButtons.YesNo Then
                btnPrimary.Text = "Yes"
                btnSecondary.Text = "No"
                btnSecondary.Visible = True
                AddHandler btnPrimary.Click, Sub(s, e)
                                                 Me.DialogResult = DialogResult.Yes
                                                 Me.Close()
                                             End Sub
                AddHandler btnSecondary.Click, Sub(s, e)
                                                   Me.DialogResult = DialogResult.No
                                                   Me.Close()
                                               End Sub
                Me.AcceptButton = btnPrimary
                Me.CancelButton = btnSecondary
            ElseIf buttons = MessageBoxButtons.OKCancel Then
                btnPrimary.Text = "OK"
                btnSecondary.Text = "Cancel"
                btnSecondary.Visible = True
                AddHandler btnPrimary.Click, Sub(s, e)
                                                 Me.DialogResult = DialogResult.OK
                                                 Me.Close()
                                             End Sub
                AddHandler btnSecondary.Click, Sub(s, e)
                                                   Me.DialogResult = DialogResult.Cancel
                                                   Me.Close()
                                               End Sub
                Me.AcceptButton = btnPrimary
                Me.CancelButton = btnSecondary
            Else
                btnPrimary.Text = "OK"
                AddHandler btnPrimary.Click, Sub(s, e)
                                                 Me.DialogResult = DialogResult.OK
                                                 Me.Close()
                                             End Sub
                Me.AcceptButton = btnPrimary
                Me.CancelButton = btnPrimary
            End If

            Dim textWidth = lblMessage.PreferredWidth
            Dim calculatedWidth = Math.Max(480, Math.Min(600, textWidth + 120))
            Dim textHeight = lblMessage.PreferredHeight
            Dim contentHeight = Math.Max(iconCircle.Height, textHeight)
            Dim calculatedHeight = 50 + contentHeight + 36 + 1 + 58

            Me.ClientSize = New Size(calculatedWidth, Math.Max(190, calculatedHeight))

            btnCloseHeader.Location = New Point(calculatedWidth - 42, 12)
            btnPrimary.Location = New Point(calculatedWidth - 116, 11)
            btnSecondary.Location = New Point(calculatedWidth - 216, 11)
        End Sub
    End Class
End Class
