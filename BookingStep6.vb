Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Public Class BookingStep6
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property PreviousForm As Form

    Private Sub BookingStep6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlOption1.Cursor = Cursors.Hand
        pnlOption2.Cursor = Cursors.Hand
        lblOption1Desc.Cursor = Cursors.Hand
        lblOption2Desc.Cursor = Cursors.Hand
        rbB6NonRefundable.Cursor = Cursors.Hand
        rbB6Refundable.Cursor = Cursors.Hand

        If AppState.ActiveBooking IsNot Nothing AndAlso AppState.ActiveBooking.IsRefundable Then
            SelectRefundable()
        Else
            SelectNonRefundable()
        End If
    End Sub

    Private Sub SelectNonRefundable()
        rbB6NonRefundable.Checked = True
        rbB6Refundable.Checked = False

        pnlOption1.BorderColor = Color.FromArgb(1, 123, 128)
        pnlOption1.BorderThickness = 2
        pnlOption1.FillColor = Color.FromArgb(240, 248, 248)
        rbB6NonRefundable.ForeColor = Color.FromArgb(1, 123, 128)

        pnlOption2.BorderColor = Color.FromArgb(220, 220, 230)
        pnlOption2.BorderThickness = 1
        pnlOption2.FillColor = Color.FromArgb(248, 249, 251)
        rbB6Refundable.ForeColor = Color.FromArgb(105, 105, 105)

        If AppState.ActiveBooking IsNot Nothing Then
            Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
            Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
            AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, False)
            UpdateSummary()
        End If
    End Sub

    Private Sub SelectRefundable()
        rbB6NonRefundable.Checked = False
        rbB6Refundable.Checked = True

        pnlOption1.BorderColor = Color.FromArgb(220, 220, 230)
        pnlOption1.BorderThickness = 1
        pnlOption1.FillColor = Color.FromArgb(248, 249, 251)
        rbB6NonRefundable.ForeColor = Color.FromArgb(105, 105, 105)

        pnlOption2.BorderColor = Color.FromArgb(254, 115, 73)
        pnlOption2.BorderThickness = 2
        pnlOption2.FillColor = Color.FromArgb(254, 248, 244)
        rbB6Refundable.ForeColor = Color.FromArgb(254, 115, 73)

        If AppState.ActiveBooking IsNot Nothing Then
            Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
            Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
            AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, True)
            UpdateSummary()
        End If
    End Sub

    Private Sub Option1_Clicked(sender As Object, e As EventArgs) Handles rbB6NonRefundable.Click, pnlOption1.Click, lblOption1Desc.Click
        SelectNonRefundable()
    End Sub

    Private Sub Option2_Clicked(sender As Object, e As EventArgs) Handles rbB6Refundable.Click, pnlOption2.Click, lblOption2Desc.Click
        SelectRefundable()
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
        If PreviousForm IsNot Nothing AndAlso Not PreviousForm.IsDisposed AndAlso Not PreviousForm.Disposing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnB6Pay_Click(sender As Object, e As EventArgs) Handles btnB6Pay.Click
        Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
        Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
        AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, rbB6Refundable.Checked)

        Dim f As New CheckoutForm()
        f.PreviousForm = Me
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub

    Private Sub btnB6Terms_Click(sender As Object, e As EventArgs) Handles btnB6Terms.Click
        CustomMessageBox.ShowTermsAndConditions(Me, requireAccept:=False)
    End Sub
End Class
