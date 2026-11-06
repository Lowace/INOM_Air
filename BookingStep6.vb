Imports System.Linq

Public Class BookingStep6
    Private Sub BookingStep6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbB6NonRefundable.Checked = True
        UpdateSummary()
    End Sub

    Private Sub rbB6Refundable_CheckedChanged(sender As Object, e As EventArgs) Handles rbB6Refundable.CheckedChanged, rbB6NonRefundable.CheckedChanged
        If AppState.ActiveBooking IsNot Nothing Then
            Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
            Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
            AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, rbB6Refundable.Checked)
            UpdateSummary()
        End If
    End Sub

    Private Sub UpdateSummary()
        Dim b = AppState.ActiveBooking
        If b.Flight Is Nothing Then Return
        lblB6SummaryDate.Text = b.Flight.FlightDate
        lblB6SummaryRoute.Text = b.Flight.RouteDisplay
        lblB6SummaryTime.Text = b.Flight.TimeDisplay & " (" & b.Flight.Duration & ")"
        lblB6SummaryTotalAmount.Text = "PHP " & b.TotalAmount.ToString("N2")
    End Sub

    Private Sub btnB6Back_Click(sender As Object, e As EventArgs) Handles btnB6Back.Click
        Me.Close()
    End Sub

    Private Sub btnB6Pay_Click(sender As Object, e As EventArgs) Handles btnB6Pay.Click
        Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
        Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
        AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, rbB6Refundable.Checked)

        Dim f As New CheckoutForm()
        AddHandler f.FormClosed, Sub(s, ev)
                                     If Not Me.IsDisposed AndAlso Not Me.Disposing Then
                                         Me.Show()
                                     End If
                                 End Sub
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
