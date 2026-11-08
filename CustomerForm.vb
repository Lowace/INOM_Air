Imports System.Linq

Public Class CustomerForm
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDashboard()
    End Sub

    Public Sub RefreshDashboard()
        Dim user = AppState.CurrentUser
        If user Is Nothing Then Return
        lblWelcomeName.Text = user.GivenName
        lblInfoName.Text = "Name:" & vbCrLf & user.FullName
        lblInfoContact.Text = "Contact No:" & vbCrLf & user.ContactNumber
        lblInfoGender.Text = "Gender:" & vbCrLf & user.Gender
        Dim userBookings = AppState.Bookings.Where(Function(b) b.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase)).ToList()
        lblStatTotalNum.Text = userBookings.Count.ToString()
        lblStatCompletedNum.Text = userBookings.Where(Function(b) b.Status = "Completed").Count().ToString()
        lblStatCancelledNum.Text = userBookings.Where(Function(b) b.Status = "Cancelled").Count().ToString()
        Dim activeBooking = userBookings.LastOrDefault(Function(b) b.Status = "Confirmed")
        If activeBooking IsNot Nothing Then
            pnlNoBookings.Visible = False
            pnlHasBooking.Visible = True
            lblTicketTag.Text = "Ticket-#: " & activeBooking.TicketNumber
            If activeBooking.Flight IsNot Nothing Then
                lblTicketRoute.Text = "Origin: " & activeBooking.Flight.Origin & vbCrLf & "To: " & activeBooking.Flight.Destination
                lblTicketTime.Text = "Schedule: " & activeBooking.Flight.FlightDate & " • " & activeBooking.Flight.DepartureTime & vbCrLf &
                                     "Passenger: " & activeBooking.PassengerName & vbCrLf &
                                     "Seat: " & activeBooking.SeatNumber & " (" & activeBooking.CabinClass & ") • Gate: " & activeBooking.Gate & vbCrLf &
                                     "Baggage: " & activeBooking.CheckedBaggageKg & "kg Checked (" & activeBooking.CarryOnBaggageKg & "kg Carry-on)" & vbCrLf &
                                     "Meal: " & activeBooking.SelectedMeal & vbCrLf &
                                     "Total Paid: PHP " & activeBooking.TotalAmount.ToString("N2") & " (" & activeBooking.DiscountReason & ")"
            End If
        Else
            pnlNoBookings.Visible = True
            pnlHasBooking.Visible = False
        End If
    End Sub

    Private Sub btnStartBooking_Click(sender As Object, e As EventArgs) Handles btnStartBooking.Click
        Dim f As New BookingStep1()
        f.PreviousForm = Me
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnViewFullDetails_Click(sender As Object, e As EventArgs) Handles btnViewFullDetails.Click
        Dim userBookings = AppState.Bookings.Where(Function(b) b.Username.Equals(AppState.CurrentUser.Username, StringComparison.OrdinalIgnoreCase) AndAlso b.Status = "Confirmed").ToList()
        Dim lastBooking = userBookings.LastOrDefault()
        Dim ticketForm As New BoardingTicket()
        If lastBooking IsNot Nothing Then
            ticketForm.TargetTicketNumber = lastBooking.TicketNumber
        End If
        ticketForm.ShowDialog()
    End Sub

    Private Sub btnEditBooking_Click(sender As Object, e As EventArgs) Handles btnEditBooking.Click
        Dim res = CustomMessageBox.Show("Do you want to rebook or reschedule this flight?", "Rebooking Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then btnStartBooking_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click
        Dim res = CustomMessageBox.Show("Are you sure you want to cancel this booking and submit a refund request?" & vbCrLf & vbCrLf & "(Per airline policy, refund will be credited based on refundability option chosen)", "Cancel & Refund Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Dim userBookings = AppState.Bookings.Where(Function(b) b.Username.Equals(AppState.CurrentUser.Username, StringComparison.OrdinalIgnoreCase) AndAlso b.Status = "Confirmed").ToList()
            Dim lastBooking = userBookings.LastOrDefault()
            If lastBooking IsNot Nothing Then
                lastBooking.Status = "Cancelled"
                AppState.UpdateBookingStatusInDatabase(lastBooking.TicketNumber, "Cancelled")
            End If
            CustomMessageBox.Show("Flight successfully cancelled. Refund request has been recorded.", "Cancellation Processed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshDashboard()
        End If
    End Sub

    Private Sub btnViewProfileInfo_Click(sender As Object, e As EventArgs) Handles btnViewProfileInfo.Click
        Dim u = AppState.CurrentUser
        CustomMessageBox.Show("Customer Profile Details:" & vbCrLf & vbCrLf &
                              "• Full Name: " & u.FullName & vbCrLf &
                              "• Gender: " & u.Gender & vbCrLf &
                              "• Contact: " & u.ContactNumber & vbCrLf &
                              "• Date of Birth: " & u.DateOfBirth.ToString("MMMM dd, yyyy") & vbCrLf &
                              "• Senior Citizen (60+): " & If(u.IsSenior, "Yes", "No") & vbCrLf &
                              "• PWD: " & If(u.IsPwd, "Yes", "No"), "Profile Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCustomerTerms_Click(sender As Object, e As EventArgs) Handles btnCustomerTerms.Click
        CustomMessageBox.ShowTermsAndConditions(Me, requireAccept:=False)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim startForm As New StartingPage()
        startForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
