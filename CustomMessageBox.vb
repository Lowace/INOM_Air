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

        Private pnlCard As Guna2Panel
        Private lblTitle As Label
        Private lblMessage As Label
        Private btnPrimary As Guna2Button
        Private btnSecondary As Guna2Button
        Private btnCloseHeader As Guna2CircleButton
        Private badgeIcon As Guna2CircleButton
        Private shadowForm As Guna2ShadowForm
        Private dragCtrl As Guna2DragControl

        Public Sub New(message As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
            Me.FormBorderStyle = FormBorderStyle.None
            Me.StartPosition = FormStartPosition.CenterParent
            Me.ShowInTaskbar = False
            Me.BackColor = Color.FromArgb(237, 229, 216)
            Me.Padding = New Padding(10)

            shadowForm = New Guna2ShadowForm()
            shadowForm.TargetForm = Me
            shadowForm.BorderRadius = 18

            pnlCard = New Guna2Panel With {
                .Dock = DockStyle.Fill,
                .FillColor = Color.White,
                .BorderRadius = 16,
                .BorderThickness = 1,
                .BorderColor = Color.FromArgb(220, 215, 205),
                .Padding = New Padding(20, 14, 20, 16)
            }
            Me.Controls.Add(pnlCard)

            Dim pnlHeader As New Panel With {
                .Dock = DockStyle.Top,
                .Height = 40,
                .BackColor = Color.Transparent
            }
            pnlCard.Controls.Add(pnlHeader)

            dragCtrl = New Guna2DragControl()
            dragCtrl.TargetControl = pnlHeader

            lblTitle = New Label With {
                .Text = If(String.IsNullOrWhiteSpace(title), "INOM Air", title),
                .Font = New Font("Segoe UI", 11.0F, FontStyle.Bold),
                .ForeColor = Color.FromArgb(1, 123, 128),
                .Location = New Point(0, 6),
                .AutoSize = True
            }
            pnlHeader.Controls.Add(lblTitle)

            btnCloseHeader = New Guna2CircleButton With {
                .Text = "✕",
                .Size = New Size(26, 26),
                .Location = New Point(pnlHeader.Width - 28, 4),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                .FillColor = Color.FromArgb(242, 238, 230),
                .ForeColor = Color.FromArgb(120, 120, 120),
                .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
                .Cursor = Cursors.Hand
            }
            AddHandler btnCloseHeader.Click, Sub(s, e)
                                                 Me.DialogResult = If(buttons = MessageBoxButtons.YesNo, DialogResult.No, DialogResult.Cancel)
                                                 Me.Close()
                                             End Sub
            pnlHeader.Controls.Add(btnCloseHeader)

            badgeIcon = New Guna2CircleButton With {
                .Size = New Size(40, 40),
                .Location = New Point(20, 58),
                .Enabled = False,
                .Font = New Font("Segoe UI", 13.0F, FontStyle.Bold),
                .Cursor = Cursors.Default
            }
            pnlCard.Controls.Add(badgeIcon)

            Select Case icon
                Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
                    badgeIcon.FillColor = Color.FromArgb(220, 53, 69)
                    badgeIcon.ForeColor = Color.White
                    badgeIcon.Text = "✕"
                Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
                    badgeIcon.FillColor = Color.FromArgb(254, 115, 73)
                    badgeIcon.ForeColor = Color.White
                    badgeIcon.Text = "!"
                Case MessageBoxIcon.Question
                    badgeIcon.FillColor = Color.FromArgb(1, 123, 128)
                    badgeIcon.ForeColor = Color.White
                    badgeIcon.Text = "?"
                Case Else
                    badgeIcon.FillColor = Color.FromArgb(1, 123, 128)
                    badgeIcon.ForeColor = Color.White
                    badgeIcon.Text = "✓"
            End Select

            lblMessage = New Label With {
                .Text = message,
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Regular),
                .ForeColor = Color.FromArgb(60, 60, 65),
                .Location = New Point(72, 60),
                .AutoSize = True,
                .MaximumSize = New Size(430, 0)
            }
            pnlCard.Controls.Add(lblMessage)

            Dim pnlButtons As New Panel With {
                .Dock = DockStyle.Bottom,
                .Height = 46,
                .BackColor = Color.Transparent
            }
            pnlCard.Controls.Add(pnlButtons)

            btnPrimary = New Guna2Button With {
                .BorderRadius = 10,
                .Cursor = Cursors.Hand,
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .ForeColor = Color.White,
                .FillColor = Color.FromArgb(1, 123, 128),
                .Size = New Size(96, 36),
                .Location = New Point(pnlButtons.Width - 96, 5),
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            }
            pnlButtons.Controls.Add(btnPrimary)

            btnSecondary = New Guna2Button With {
                .BorderRadius = 10,
                .Cursor = Cursors.Hand,
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .ForeColor = Color.FromArgb(105, 105, 105),
                .FillColor = Color.FromArgb(242, 238, 230),
                .BorderThickness = 1,
                .BorderColor = Color.FromArgb(215, 208, 198),
                .Size = New Size(88, 36),
                .Location = New Point(pnlButtons.Width - 192, 5),
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right,
                .Visible = False
            }
            pnlButtons.Controls.Add(btnSecondary)

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

            Dim contentHeight = Math.Max(badgeIcon.Height, lblMessage.PreferredHeight)
            Dim calculatedHeight = 40 + contentHeight + 46 + 40
            Dim calculatedWidth = Math.Max(420, Math.Min(560, lblMessage.PreferredWidth + 110))
            Me.ClientSize = New Size(calculatedWidth, Math.Max(175, calculatedHeight))
        End Sub
    End Class
End Class
