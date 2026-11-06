Imports System.Linq

Public Class BookingStep2
    Private Sub BookingStep2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblB2Origin.Text = "Origin: " & AppState.SearchOrigin
        lblB2Dest.Text = "To: " & AppState.SearchDest
        lblB2TripType.Text = "Trip Type: " & AppState.SearchTripType
        lblB2DateHeader.Text = AppState.SearchDate.ToString("MMMM dd, yyyy")
        cmbB2CabinClass.SelectedIndex = 0

        Dim f1 = AppState.Flights(0)
        Dim f2 = AppState.Flights(1)
        lblF1Time.Text = f1.TimeDisplay
        lblF1Duration.Text = f1.Duration
        lblF1Type.Text = f1.FlightType
        lblF1Fare.Text = "PHP " & f1.BaseFare.ToString("N0")
        lblF2Time.Text = f2.TimeDisplay
        lblF2Duration.Text = f2.Duration
        lblF2Type.Text = f2.FlightType
        lblF2Fare.Text = "PHP " & f2.BaseFare.ToString("N0")
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
        AddHandler f.FormClosed, Sub(s, ev) Me.Show()
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnF1Select_Click(sender As Object, e As EventArgs) Handles btnF1Select.Click
        SelectFlightAndProceed(AppState.Flights(0))
    End Sub

    Private Sub btnF2Select_Click(sender As Object, e As EventArgs) Handles btnF2Select.Click
        SelectFlightAndProceed(AppState.Flights(1))
    End Sub

    Private Sub btnB2Back_Click(sender As Object, e As EventArgs) Handles btnB2Back.Click
        Me.Close()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
