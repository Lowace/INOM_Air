Imports System.Linq

Public Class PaymentForm
    Private currentPaymentMode As String = "Card"

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b = AppState.ActiveBooking
        If b IsNot Nothing Then
            lblPayPassenger.Text = b.PassengerName
            If b.Flight IsNot Nothing Then
                lblPayRoute.Text = b.Flight.RouteDisplay
                lblPayTime.Text = b.Flight.FlightDate & " | " & b.Flight.TimeDisplay
            End If
            lblPayTotal.Text = "PHP " & b.TotalAmount.ToString("N2")
            btnConfirmPayment.Text = "Confirm & Pay PHP " & b.TotalAmount.ToString("N2") & " ✓"
        End If

        SetCardMode()
    End Sub

    Private Sub SetCardMode()
        currentPaymentMode = "Card"
        btnTabCreditDebit.FillColor = Color.FromArgb(1, 123, 128)
        btnTabCreditDebit.ForeColor = Color.White
        btnTabOnlineBanking.FillColor = Color.Transparent
        btnTabOnlineBanking.ForeColor = Color.FromArgb(105, 105, 105)
        btnTabWallet.FillColor = Color.Transparent
        btnTabWallet.ForeColor = Color.FromArgb(105, 105, 105)

        lblPayInstruction.Text = "Enter Card Payment Details"
        txtPayField1.PlaceholderText = "16-digit Card Number (e.g. 4532 ...)"
        txtPayField2.PlaceholderText = "Cardholder Full Name"
        txtPayField3.PlaceholderText = "MM/YY Expiry  •  3-digit CVV"
        txtPayField3.Visible = True
    End Sub

    Private Sub btnTabCreditDebit_Click(sender As Object, e As EventArgs) Handles btnTabCreditDebit.Click
        SetCardMode()
    End Sub

    Private Sub btnTabOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnTabOnlineBanking.Click
        currentPaymentMode = "Bank"
        btnTabOnlineBanking.FillColor = Color.FromArgb(1, 123, 128)
        btnTabOnlineBanking.ForeColor = Color.White
        btnTabCreditDebit.FillColor = Color.Transparent
        btnTabCreditDebit.ForeColor = Color.FromArgb(105, 105, 105)
        btnTabWallet.FillColor = Color.Transparent
        btnTabWallet.ForeColor = Color.FromArgb(105, 105, 105)

        lblPayInstruction.Text = "Online Banking Direct Debit"
        txtPayField1.PlaceholderText = "Bank Name (BDO, BPI, Metrobank, UnionBank)"
        txtPayField2.PlaceholderText = "Account / Reference Number"
        txtPayField3.Visible = False
    End Sub

    Private Sub btnTabWallet_Click(sender As Object, e As EventArgs) Handles btnTabWallet.Click
        currentPaymentMode = "Wallet"
        btnTabWallet.FillColor = Color.FromArgb(1, 123, 128)
        btnTabWallet.ForeColor = Color.White
        btnTabCreditDebit.FillColor = Color.Transparent
        btnTabCreditDebit.ForeColor = Color.FromArgb(105, 105, 105)
        btnTabOnlineBanking.FillColor = Color.Transparent
        btnTabOnlineBanking.ForeColor = Color.FromArgb(105, 105, 105)

        lblPayInstruction.Text = "E-Wallet (GCash / Maya) Payment"
        txtPayField1.PlaceholderText = "Registered Mobile Number (0917 ...)"
        txtPayField2.PlaceholderText = "Account Holder Full Name"
        txtPayField3.Visible = False
    End Sub

    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        Dim f1 = txtPayField1.Text.Trim()
        Dim f2 = txtPayField2.Text.Trim()
        If String.IsNullOrWhiteSpace(f1) OrElse String.IsNullOrWhiteSpace(f2) Then
            MessageBox.Show("Please fill in the required payment details.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim rand As New Random()
        Dim ticketNo = "INOM-" & rand.Next(10000000, 99999999).ToString()

        Dim b = AppState.ActiveBooking
        b.TicketNumber = ticketNo
        b.BookingDate = DateTime.Now
        b.Status = "Confirmed"

        AppState.Bookings.Add(b)
        AppState.SaveBookingToDatabase(b)

        MessageBox.Show("Payment Successful!" & vbCrLf &
                        "Your flight has been officially confirmed." & vbCrLf &
                        "Ticket Number: " & ticketNo & vbCrLf &
                        "Seat: " & b.SeatNumber & " | Gate: " & b.Gate,
                        "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        For Each frm As Form In Application.OpenForms.Cast(Of Form)().ToList()
            If TypeOf frm Is CustomerForm Then
                frm.Show()
                CType(frm, CustomerForm).RefreshDashboard()
            ElseIf Not (TypeOf frm Is StartingPage) AndAlso Not (TypeOf frm Is SignInPage) Then
                frm.Close()
            End If
        Next
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
