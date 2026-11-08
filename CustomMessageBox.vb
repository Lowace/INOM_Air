Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Partial Public Class CustomMessageBox

    <StructLayout(LayoutKind.Sequential)>
    Private Structure SCROLLINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public nMin As Integer
        Public nMax As Integer
        Public nPage As Integer
        Public nPos As Integer
        Public nTrackPos As Integer
    End Structure

    Private Const SB_VERT As Integer = 1
    Private Const SIF_ALL As Integer = &H1 Or &H2 Or &H4

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetScrollInfo(hWnd As IntPtr, nBar As Integer, ByRef lpsi As SCROLLINFO) As Boolean
    End Function

    Private isDragging As Boolean = False
    Private dragCursorPoint As Point
    Private dragFormPoint As Point

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Header_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            dragCursorPoint = Cursor.Position
            dragFormPoint = Me.Location
        End If
    End Sub

    Private Sub Header_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, lblTitle.MouseMove
        If isDragging Then
            Dim diff As Point = Point.Subtract(Cursor.Position, New Size(dragCursorPoint))
            Me.Location = Point.Add(dragFormPoint, New Size(diff))
        End If
    End Sub

    Private Sub Header_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, lblTitle.MouseUp
        isDragging = False
    End Sub

    Private Sub AppendSection(heading As String, content As String)
        rtbScrollMessage.SelectionFont = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        rtbScrollMessage.SelectionColor = Color.FromArgb(1, 123, 128)
        rtbScrollMessage.AppendText(heading & vbCrLf)

        rtbScrollMessage.SelectionFont = New Font("Segoe UI", 9.25F, FontStyle.Regular)
        rtbScrollMessage.SelectionColor = Color.FromArgb(45, 50, 58)
        rtbScrollMessage.AppendText(content & vbCrLf & vbCrLf)
    End Sub

    Private Sub LoadDefaultTermsAndConditions()
        rtbScrollMessage.SelectionFont = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        rtbScrollMessage.SelectionColor = Color.FromArgb(1, 123, 128)
        rtbScrollMessage.AppendText("INOM AIR PASSENGER AGREEMENT & CONDITIONS OF CARRIAGE" & vbCrLf)

        rtbScrollMessage.SelectionFont = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        rtbScrollMessage.SelectionColor = Color.FromArgb(115, 120, 130)
        rtbScrollMessage.AppendText("Please read and review these conditions carefully before booking, paying, or travelling with INOM Air." & vbCrLf & vbCrLf)

        AppendSection("1. CONTRACT OF CARRIAGE & APPLICABILITY",
                      "By booking a ticket, purchasing flight concessions, or boarding an INOM Air aircraft, the passenger agrees to be bound by these Conditions of Carriage, government aviation regulations, and fare rules. Carriage is subject to the rules and limitations established by the Civil Aeronautics Board (CAB) and Philippine aviation laws.")

        AppendSection("2. PASSENGER IDENTIFICATION & TICKETING",
                      "• All tickets are non-transferable and valid exclusively for the person named on the booking." & vbCrLf &
                      "• Passengers must provide accurate personal details (Full Name, Date of Birth, Gender, and Contact Number) during registration and booking." & vbCrLf &
                      "• A valid government-issued photo ID (Passport, Driver's License, UMID, Postal ID, Senior OSCA ID, or PWD ID) matching the ticket name is mandatory upon airport check-in and boarding gate inspection.")

        AppendSection("3. SENIOR CITIZEN & PWD CONCESSIONS (RA 9994 & RA 10754)",
                      "• In accordance with Philippine law (Republic Act No. 9994 and Republic Act No. 10754), qualified Senior Citizens (aged 60 and above) and Persons with Disability (PWD) are entitled to a 20% concessionary discount and Value-Added Tax (VAT) exemption on domestic flight base fares." & vbCrLf &
                      "• Proof of entitlement (Original OSCA ID or National PWD ID) must be presented during check-in. If the passenger fails to present valid original credentials, INOM Air reserves the right to collect the discounted amount plus a verification surcharge prior to boarding.")

        AppendSection("4. BAGGAGE ALLOWANCE & RESTRICTED ITEMS",
                      "• Carry-on Baggage: Each passenger is entitled to one (1) carry-on baggage not exceeding 7 kilograms with maximum dimensions of 56cm x 36cm x 23cm." & vbCrLf &
                      "• Checked Baggage: Checked baggage allowance depends on the tier purchased during booking (20kg or 32kg). Excess baggage beyond the prepaid allowance is subject to airport excess baggage fees per kilogram." & vbCrLf &
                      "• Dangerous Goods: Flammable substances, explosives, compressed gases, corrosive chemicals, and unauthorized weapons are strictly prohibited under national and international civil aviation safety rules.")

        AppendSection("5. CHECK-IN, BOARDING & NO-SHOW REGULATIONS",
                      "• Airport check-in counters open two (2) hours prior to scheduled domestic departure and close strictly forty-five (45) minutes before departure." & vbCrLf &
                      "• Boarding gates close fifteen (15) minutes prior to scheduled departure. Passengers who fail to arrive at the boarding gate before closure will be classified as No-Show, and the ticket may be forfeited in accordance with fare rules.")

        AppendSection("6. FLIGHT CANCELLATIONS, REBOOKING & REFUNDS",
                      "• Standard Fare: Tickets issued under Standard Fares are non-refundable upon voluntary passenger cancellation." & vbCrLf &
                      "• Flexible Ticket Option: Passengers who availed the Flexible Ticket protection may request a refund of the base fare if cancellation is submitted at least twenty-four (24) hours prior to departure, subject to a PHP 500.00 administrative fee." & vbCrLf &
                      "• Airline-Initiated Cancellations: If a flight is delayed beyond three (3) hours, cancelled, or rescheduled by INOM Air due to weather, maintenance, or operational constraints, passengers may opt for free rebooking, travel fund conversion, or 100% full refund.")

        AppendSection("7. PASSENGER CONDUCT & FLIGHT SAFETY",
                      "• INOM Air strictly enforces a zero-tolerance policy against unruly behavior, harassment, physical aggression, or non-compliance with crew instructions." & vbCrLf &
                      "• INOM Air reserves the right to refuse carriage or offload any passenger who appears visibly intoxicated, poses a security threat, or compromises the safety and comfort of passengers and crew.")

        AppendSection("8. DATA PRIVACY & CONFIDENTIALITY (RA 10173)",
                      "• Personal information gathered through the INOM Air reservation system is protected under the Philippine Data Privacy Act of 2012." & vbCrLf &
                      "• Information is collected strictly for flight reservations, aviation security screening, passenger manifest submission to airport authorities, and customer support services.")
    End Sub

    Private Sub ConfigureDialog(message As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        lblTitle.Text = If(String.IsNullOrWhiteSpace(title), "INOM Air", title)
        lblScrollHint.Visible = False
        btnPrimary.Enabled = True

        Dim lines = message.Split(New String() {vbCrLf, vbLf}, StringSplitOptions.None)
        Dim isLong = (message.Length > 280) OrElse (lines.Length > 6)

        If isLong Then
            rtbScrollMessage.Visible = True
            lblMessage.Visible = False
            iconCircle.Visible = False
            rtbScrollMessage.Clear()
            rtbScrollMessage.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Regular)
            rtbScrollMessage.SelectionColor = Color.FromArgb(45, 50, 58)
            rtbScrollMessage.AppendText(message)
            rtbScrollMessage.Select(0, 0)
            rtbScrollMessage.ScrollToCaret()

            AddHandler rtbScrollMessage.MouseEnter, Sub(s, e)
                                                        rtbScrollMessage.Focus()
                                                    End Sub

            Dim calculatedWidth = 560
            Dim calculatedHeight = 440
            Me.ClientSize = New Size(calculatedWidth, calculatedHeight)

            rtbScrollMessage.Location = New Point(24, 10)
            rtbScrollMessage.Size = New Size(calculatedWidth - 48, pnlBody.Height - 20)
            rtbScrollMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Else
            rtbScrollMessage.Visible = False
            lblMessage.Visible = True
            iconCircle.Visible = True
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

            Dim textWidth = lblMessage.PreferredWidth
            Dim calculatedWidth = Math.Max(480, Math.Min(600, textWidth + 120))
            Dim textHeight = lblMessage.PreferredHeight
            Dim contentHeight = Math.Max(iconCircle.Height, textHeight)
            Dim calculatedHeight = 50 + contentHeight + 36 + 1 + 58

            Me.ClientSize = New Size(calculatedWidth, Math.Max(190, calculatedHeight))
        End If

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

        btnCloseHeader.Location = New Point(Me.ClientSize.Width - 42, 12)
        btnPrimary.Location = New Point(Me.ClientSize.Width - 116, 11)
        btnSecondary.Location = New Point(Me.ClientSize.Width - 216, 11)
    End Sub

    Private Sub ConfigureTermsAndConditions(title As String, customTerms As String, requireAccept As Boolean)
        lblTitle.Text = If(String.IsNullOrWhiteSpace(title), "INOM Air - Terms & Conditions", title)

        rtbScrollMessage.Visible = True
        lblMessage.Visible = False
        iconCircle.Visible = False
        rtbScrollMessage.Clear()

        Dim calculatedWidth = 620
        Dim calculatedHeight = 540
        Me.ClientSize = New Size(calculatedWidth, calculatedHeight)

        rtbScrollMessage.Location = New Point(24, 10)
        rtbScrollMessage.Size = New Size(calculatedWidth - 48, pnlBody.Height - 20)
        rtbScrollMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        If Not String.IsNullOrWhiteSpace(customTerms) Then
            rtbScrollMessage.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Regular)
            rtbScrollMessage.SelectionColor = Color.FromArgb(45, 50, 58)
            rtbScrollMessage.AppendText(customTerms)
        Else
            LoadDefaultTermsAndConditions()
        End If

        rtbScrollMessage.Select(0, 0)
        rtbScrollMessage.ScrollToCaret()

        AddHandler rtbScrollMessage.MouseEnter, Sub(s, e)
                                                    rtbScrollMessage.Focus()
                                                End Sub

        If requireAccept Then
            btnPrimary.Text = "I Agree"
            btnPrimary.Size = New Size(100, 36)
            btnPrimary.Location = New Point(calculatedWidth - 120, 11)
            btnPrimary.Enabled = False

            lblScrollHint.Text = "⬇ Please scroll to the bottom to accept"
            lblScrollHint.ForeColor = Color.FromArgb(140, 145, 155)
            lblScrollHint.Visible = True

            Dim checkScrollBottom = Sub()
                                        If btnPrimary.Enabled Then Return
                                        Dim isAtBottom = False
                                        Dim clientBottomPt As New Point(rtbScrollMessage.ClientSize.Width - 30, rtbScrollMessage.ClientSize.Height - 15)
                                        Dim lastVisibleChar = rtbScrollMessage.GetCharIndexFromPosition(clientBottomPt)
                                        If lastVisibleChar >= rtbScrollMessage.TextLength - 140 Then
                                            isAtBottom = True
                                        End If
                                        If Not isAtBottom Then
                                            Dim si As New SCROLLINFO()
                                            si.cbSize = Marshal.SizeOf(GetType(SCROLLINFO))
                                            si.fMask = SIF_ALL
                                            If GetScrollInfo(rtbScrollMessage.Handle, SB_VERT, si) Then
                                                If si.nPage > 0 AndAlso (si.nPos + si.nPage >= si.nMax - 20) Then
                                                    isAtBottom = True
                                                End If
                                            End If
                                        End If
                                        If isAtBottom Then
                                            btnPrimary.Enabled = True
                                            lblScrollHint.Text = "✓ You may now accept the terms"
                                            lblScrollHint.ForeColor = Color.FromArgb(1, 123, 128)
                                        End If
                                    End Sub

            AddHandler rtbScrollMessage.VScroll, Sub(s, e) checkScrollBottom()
            AddHandler rtbScrollMessage.MouseWheel, Sub(s, e) checkScrollBottom()
            AddHandler rtbScrollMessage.KeyUp, Sub(s, e) checkScrollBottom()
            AddHandler rtbScrollMessage.SelectionChanged, Sub(s, e) checkScrollBottom()
            checkScrollBottom()

            btnSecondary.Text = "Decline"
            btnSecondary.Size = New Size(92, 36)
            btnSecondary.Location = New Point(calculatedWidth - 222, 11)
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
            btnPrimary.Text = "Close"
            btnPrimary.Size = New Size(96, 36)
            btnPrimary.Location = New Point(calculatedWidth - 116, 11)
            btnPrimary.Enabled = True
            lblScrollHint.Visible = False
            btnSecondary.Visible = False

            AddHandler btnPrimary.Click, Sub(s, e)
                                             Me.DialogResult = DialogResult.OK
                                             Me.Close()
                                         End Sub
            Me.AcceptButton = btnPrimary
            Me.CancelButton = btnPrimary
        End If

        AddHandler btnCloseHeader.Click, Sub(s, e)
                                             Me.DialogResult = DialogResult.Cancel
                                             Me.Close()
                                         End Sub

        btnCloseHeader.Location = New Point(calculatedWidth - 42, 12)
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

    Public Shadows Shared Function ShowTermsAndConditions(Optional owner As IWin32Window = Nothing, Optional customTerms As String = Nothing, Optional requireAccept As Boolean = True) As DialogResult
        Using dlg As New CustomMessageBox()
            dlg.ConfigureTermsAndConditions("INOM Air - Terms & Conditions", customTerms, requireAccept)
            Dim targetOwner = owner
            If targetOwner Is Nothing Then
                Dim active = Form.ActiveForm
                If active IsNot Nothing AndAlso Not active.IsDisposed AndAlso active.Visible Then
                    targetOwner = active
                End If
            End If
            If targetOwner IsNot Nothing Then
                Return dlg.ShowDialog(targetOwner)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function

    Public Shadows Shared Function ShowScrollable(message As String, Optional title As String = "INOM Air", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information, Optional owner As IWin32Window = Nothing) As DialogResult
        Using dlg As New CustomMessageBox()
            dlg.ConfigureTermsAndConditions(title, message, buttons = MessageBoxButtons.OKCancel OrElse buttons = MessageBoxButtons.YesNo)
            Dim targetOwner = owner
            If targetOwner Is Nothing Then
                Dim active = Form.ActiveForm
                If active IsNot Nothing AndAlso Not active.IsDisposed AndAlso active.Visible Then
                    targetOwner = active
                End If
            End If
            If targetOwner IsNot Nothing Then
                Return dlg.ShowDialog(targetOwner)
            Else
                dlg.StartPosition = FormStartPosition.CenterScreen
                Return dlg.ShowDialog()
            End If
        End Using
    End Function

    Private Sub btnPrimary_Click(sender As Object, e As EventArgs) Handles btnPrimary.Click

    End Sub
End Class
