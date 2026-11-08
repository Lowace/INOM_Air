Imports System.Drawing
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Partial Public Class CustomMessageBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ConfigureDialog(message As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        lblTitle.Text = If(String.IsNullOrWhiteSpace(title), "INOM Air", title)
        lblMessage.Text = message

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
            btnSecondary.Visible = False
            AddHandler btnPrimary.Click, Sub(s, e)
                                             Me.DialogResult = DialogResult.OK
                                             Me.Close()
                                         End Sub
            Me.AcceptButton = btnPrimary
            Me.CancelButton = btnPrimary
        End If

        AddHandler btnCloseHeader.Click, Sub(s, e)
                                             Me.DialogResult = If(buttons = MessageBoxButtons.YesNo, DialogResult.No, DialogResult.Cancel)
                                             Me.Close()
                                         End Sub

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

    Public Shadows Shared Function Show(message As String, Optional title As String = "INOM Air", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Dim active = Form.ActiveForm
        Using dlg As New CustomMessageBox()
            dlg.ConfigureDialog(message, title, buttons, icon)
            If active IsNot Nothing AndAlso Not active.IsDisposed AndAlso active.Visible Then
                Return dlg.ShowDialog(active)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function

    Public Shadows Shared Function Show(owner As IWin32Window, message As String, Optional title As String = "INOM Air", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information) As DialogResult
        Using dlg As New CustomMessageBox()
            dlg.ConfigureDialog(message, title, buttons, icon)
            If owner IsNot Nothing Then
                Return dlg.ShowDialog(owner)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function
End Class
