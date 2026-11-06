Imports System.Linq

Public Class CheckoutForm
    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBreakdownModal.Visible = False
        UpdateCheckoutBreakdown()
    End Sub

    Private Sub UpdateCheckoutBreakdown()
        Dim b = AppState.ActiveBooking
        If b.Flight Is Nothing Then Return

        lblCheckoutRoute.Text = b.Flight.RouteDisplay & "  (" & b.CabinClass & " Class)"
        lblCheckoutStats.Text = b.Flight.FlightDate & " | " & b.Flight.TimeDisplay & " | " & b.Flight.FlightType
        lblCheckoutPassenger.Text = "Passenger: " & b.PassengerName & " | Seat: " & b.SeatNumber

        Dim base = b.Flight.BaseFare * If(b.CabinClass = "Business", 1.8D, 1D)
        lblCkBaseFare.Text = "Base fare:                                PHP " & base.ToString("N2")
        lblCkTaxes.Text = "Taxes & surcharges:                 PHP " & b.TaxesAndSurcharges.ToString("N2")
        lblCkAddons.Text = "Add-ons (Baggage/Prot):        PHP " & (b.BaggageFee + b.RefundFee).ToString("N2")
        lblCkDiscount.Text = "Discount (20% Senior/PWD):  -PHP " & b.DiscountAmount.ToString("N2")
        lblCkTotal.Text = "Total Amount: PHP " & b.TotalAmount.ToString("N2")

        lblRightTotal.Text = "PHP " & b.TotalAmount.ToString("N2")

        lblModBaseFare.Text = "Base fare                                                                PHP " & base.ToString("N2")
        lblModAdminFee.Text = "• Administrative Fee                                                 PHP 100.00"
        lblModFuel.Text = "• Fuel Surcharge                                                     PHP 150.00"
        lblModVAT.Text = "• Value Added Tax (VAT 12%)                                PHP 240.00"
        lblModTerminalFee.Text = "• Domestic Passenger Terminal Fee                    PHP 200.00"
        lblModAddons.Text = "Add-ons (Baggage / Refundability)                    PHP " & (b.BaggageFee + b.RefundFee).ToString("N2")
        lblModDiscount.Text = b.DiscountReason & "                                - PHP " & b.DiscountAmount.ToString("N2")
        lblModTotal.Text = "Total Amount Payable: PHP " & b.TotalAmount.ToString("N2")
    End Sub

    Private Sub btnShowMoreDeets_Click(sender As Object, e As EventArgs) Handles btnShowMoreDeets.Click
        pnlBreakdownModal.Visible = True
        pnlBreakdownModal.BringToFront()
    End Sub

    Private Sub btnModalClose_Click(sender As Object, e As EventArgs) Handles btnModalClose.Click
        pnlBreakdownModal.Visible = False
    End Sub

    Private Sub btnCheckoutBack_Click(sender As Object, e As EventArgs) Handles btnCheckoutBack.Click
        Me.Close()
    End Sub

    Private Sub btnContinueToPayment_Click(sender As Object, e As EventArgs) Handles btnContinueToPayment.Click
        Dim f As New PaymentForm()
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
