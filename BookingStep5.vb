Imports System.Linq

Public Class BookingStep5
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property PreviousForm As Form

    Private Sub BookingStep5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtB5SeatDisplay.Text = "Seat " & AppState.ActiveBooking.SeatNumber
        txtB5CarryOnKg.Text = "7kg (Free Included)"
        cmbB5Meals.SelectedIndex = 0
        cmbB5CheckedKg.SelectedIndex = 0
        RecalculateCurrentPrice()
    End Sub

    Private Sub cmbB5CheckedKg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbB5CheckedKg.SelectedIndexChanged
        RecalculateCurrentPrice()
    End Sub

    Private Sub cmbB5Meals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbB5Meals.SelectedIndexChanged
        If cmbB5Meals.SelectedItem IsNot Nothing Then
            AppState.ActiveBooking.SelectedMeal = cmbB5Meals.SelectedItem.ToString()
        End If
    End Sub

    Private Sub RecalculateCurrentPrice()
        Dim checkedKg As Integer = 0
        Select Case cmbB5CheckedKg.SelectedIndex
            Case 0 : checkedKg = 0
            Case 1 : checkedKg = 10
            Case 2 : checkedKg = 20
            Case 3 : checkedKg = 30
            Case 4 : checkedKg = 40
        End Select
        If cmbB5Meals.SelectedItem IsNot Nothing Then
            AppState.ActiveBooking.SelectedMeal = cmbB5Meals.SelectedItem.ToString()
        End If
        Dim isSenior = AppState.ActiveBooking.DiscountReason.Contains("Senior")
        Dim isPwd = AppState.ActiveBooking.DiscountReason.Contains("PWD")
        AppState.RecalculateActiveBookingPrice(isSenior, isPwd, checkedKg, AppState.ActiveBooking.IsRefundable)
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        Dim b = AppState.ActiveBooking
        If b.Flight Is Nothing Then Return
        lblB5SummaryDate.Text = b.Flight.FlightDate
        lblB5SummaryRoute.Text = b.Flight.RouteDisplay
        lblB5SummaryTime.Text = b.Flight.TimeDisplay & " (" & b.Flight.Duration & ")"
        lblB5SummaryTotalAmount.Text = "PHP " & b.TotalAmount.ToString("N2")
    End Sub

    Private Sub btnB5ChooseSeat_Click(sender As Object, e As EventArgs) Handles btnB5ChooseSeat.Click
        Dim seatPicker As New PickSeats()
        seatPicker.SelectedSeatCode = AppState.ActiveBooking.SeatNumber
        If seatPicker.ShowDialog() = DialogResult.OK Then
            txtB5SeatDisplay.Text = "Seat " & AppState.ActiveBooking.SeatNumber
            Dim seat = AppState.ActiveBooking.SeatNumber
            If seat.StartsWith("1") OrElse seat.StartsWith("2") Then
                AppState.ActiveBooking.CabinClass = "Business Class"
            Else
                AppState.ActiveBooking.CabinClass = "Economy Class"
            End If
            RecalculateCurrentPrice()
        End If
    End Sub

    Private Sub btnB5ViewMeals_Click(sender As Object, e As EventArgs) Handles btnB5ViewMeals.Click
        CustomMessageBox.Show("Selected In-Flight Meal:" & vbCrLf &
                              cmbB5Meals.SelectedItem.ToString() & vbCrLf & vbCrLf &
                              "All INOM Air meals are freshly prepared on the day of flight and served with a complimentary hot or cold beverage.",
                              "Meal Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnB5PriceList_Click(sender As Object, e As EventArgs) Handles btnB5PriceList.Click
        CustomMessageBox.Show("INOM Air Baggage Allowance & Rates Matrix:" & vbCrLf & vbCrLf &
                              "• Carry-on (7kg): Free included" & vbCrLf &
                              "• 10kg Checked: Free standard allowance" & vbCrLf &
                              "• 20kg Checked: +₱500.00" & vbCrLf &
                              "• 30kg Checked: +₱1,000.00" & vbCrLf &
                              "• 40kg Checked: +₱1,500.00" & vbCrLf & vbCrLf &
                              "Excess weight at airport counter: ₱250.00/kg.",
                              "Baggage Rates Matrix", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnB5Back_Click(sender As Object, e As EventArgs) Handles btnB5Back.Click
        If PreviousForm IsNot Nothing AndAlso Not PreviousForm.IsDisposed AndAlso Not PreviousForm.Disposing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnB5Next_Click(sender As Object, e As EventArgs) Handles btnB5Next.Click
        RecalculateCurrentPrice()

        Dim f As New BookingStep6()
        f.PreviousForm = Me
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
