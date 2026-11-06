Imports System.Linq

Public Class BookingStep2
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property PreviousForm As Form

    Private currentFlight1 As FlightSchedule = Nothing
    Private currentFlight2 As FlightSchedule = Nothing

    Private Sub BookingStep2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblB2Origin.Text = "Origin: " & AppState.SearchOrigin
        lblB2Dest.Text = "To: " & AppState.SearchDest
        lblB2TripType.Text = "Trip Type: " & AppState.SearchTripType
        lblB2DateHeader.Text = AppState.SearchDate.ToString("MMMM dd, yyyy")
        cmbB2CabinClass.SelectedIndex = 0

        Dim matches = AppState.Flights.Where(Function(f) f.Origin.Equals(AppState.SearchOrigin, StringComparison.OrdinalIgnoreCase) AndAlso f.Destination.Equals(AppState.SearchDest, StringComparison.OrdinalIgnoreCase)).ToList()
        If matches.Count >= 2 Then
            currentFlight1 = matches(0)
            currentFlight2 = matches(1)
        ElseIf matches.Count = 1 Then
            currentFlight1 = matches(0)
            currentFlight2 = matches(0)
        ElseIf AppState.Flights.Count >= 2 Then
            currentFlight1 = AppState.Flights(0)
            currentFlight2 = AppState.Flights(1)
        ElseIf AppState.Flights.Count = 1 Then
            currentFlight1 = AppState.Flights(0)
            currentFlight2 = AppState.Flights(0)
        End If

        DisplayFlights()
    End Sub

    Private Sub cmbB2CabinClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbB2CabinClass.SelectedIndexChanged
        DisplayFlights()
    End Sub

    Private Sub DisplayFlights()
        If currentFlight1 Is Nothing OrElse currentFlight2 Is Nothing Then Return
        Dim isBusiness = cmbB2CabinClass.SelectedItem IsNot Nothing AndAlso cmbB2CabinClass.SelectedItem.ToString().Contains("Business")
        Dim mult = If(isBusiness, 1.8D, 1.0D)

        lblF1Time.Text = currentFlight1.TimeDisplay
        lblF1Duration.Text = currentFlight1.Duration
        lblF1Type.Text = currentFlight1.FlightType
        lblF1Fare.Text = "PHP " & (currentFlight1.BaseFare * mult).ToString("N0")

        lblF2Time.Text = currentFlight2.TimeDisplay
        lblF2Duration.Text = currentFlight2.Duration
        lblF2Type.Text = currentFlight2.FlightType
        lblF2Fare.Text = "PHP " & (currentFlight2.BaseFare * mult).ToString("N0")
    End Sub

    Private Sub SelectFlightAndProceed(flight As FlightSchedule)
        AppState.ActiveBooking.Flight = flight
        AppState.ActiveBooking.CabinClass = cmbB2CabinClass.SelectedItem.ToString()

        Dim u = AppState.CurrentUser
        AppState.GuestGivenName = u.GivenName
        AppState.GuestSurname = u.Surname
        AppState.GuestGender = u.Gender
        AppState.GuestAge = DateTime.Today.Year - u.DateOfBirth.Year
        AppState.GuestIsPwd = u.IsPwd

        Dim f As New BookingStep3()
        f.PreviousForm = Me
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnF1Select_Click(sender As Object, e As EventArgs) Handles btnF1Select.Click
        SelectFlightAndProceed(currentFlight1)
    End Sub

    Private Sub btnF2Select_Click(sender As Object, e As EventArgs) Handles btnF2Select.Click
        SelectFlightAndProceed(currentFlight2)
    End Sub

    Private Sub btnB2Back_Click(sender As Object, e As EventArgs) Handles btnB2Back.Click
        If PreviousForm IsNot Nothing AndAlso Not PreviousForm.IsDisposed AndAlso Not PreviousForm.Disposing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
