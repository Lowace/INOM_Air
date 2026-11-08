Imports System.Linq

Public Class BookingStep2
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property PreviousForm As Form

    Private currentFlight1 As FlightSchedule = Nothing
    Private currentFlight2 As FlightSchedule = Nothing

    Private Function ExtractCityName(loc As String) As String
        If String.IsNullOrWhiteSpace(loc) Then Return ""
        Dim s = loc
        If s.Contains("-"c) Then
            Dim parts = s.Split("-"c)
            s = parts(1).Trim()
        End If
        If s.Contains(","c) Then
            s = s.Split(","c)(0).Trim()
        End If
        If s.Contains("("c) Then
            s = s.Split("("c)(0).Trim()
        End If
        Return s.Trim()
    End Function

    Private Function LocationsMatch(flightLocation As String, searchLocation As String) As Boolean
        If String.IsNullOrWhiteSpace(flightLocation) OrElse String.IsNullOrWhiteSpace(searchLocation) Then Return False
        If flightLocation.Equals(searchLocation, StringComparison.OrdinalIgnoreCase) Then Return True
        Dim cityF = ExtractCityName(flightLocation)
        Dim cityS = ExtractCityName(searchLocation)
        If Not String.IsNullOrEmpty(cityF) AndAlso Not String.IsNullOrEmpty(cityS) Then
            If cityF.Equals(cityS, StringComparison.OrdinalIgnoreCase) Then Return True
            If searchLocation.IndexOf(cityF, StringComparison.OrdinalIgnoreCase) >= 0 Then Return True
            If flightLocation.IndexOf(cityS, StringComparison.OrdinalIgnoreCase) >= 0 Then Return True
        End If
        Return False
    End Function

    Private Sub BookingStep2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblB2Origin.Text = "Origin: " & AppState.SearchOrigin
        lblB2Dest.Text = "To: " & AppState.SearchDest
        lblB2TripType.Text = "Trip Type: " & AppState.SearchTripType
        lblB2DateHeader.Text = AppState.SearchDate.ToString("MMMM dd, yyyy")
        cmbB2CabinClass.SelectedIndex = 0

        Dim matches = AppState.Flights.Where(Function(f) LocationsMatch(f.Origin, AppState.SearchOrigin) AndAlso LocationsMatch(f.Destination, AppState.SearchDest)).ToList()

        If matches.Count = 0 Then
            Dim cityOrig = ExtractCityName(AppState.SearchOrigin)
            If String.IsNullOrEmpty(cityOrig) Then cityOrig = "Manila"
            Dim cityDest = ExtractCityName(AppState.SearchDest)
            If String.IsNullOrEmpty(cityDest) Then cityDest = "Cebu"

            Dim isIntl As Boolean = AppState.SearchDest.Contains("Japan") OrElse AppState.SearchDest.Contains("Singapore") OrElse AppState.SearchDest.Contains("Korea") OrElse AppState.SearchDest.Contains("Thailand") OrElse AppState.SearchDest.Contains("Hong Kong") OrElse AppState.SearchDest.Contains("Taiwan") OrElse AppState.SearchDest.Contains("Malaysia") OrElse AppState.SearchDest.Contains("Indonesia")

            Dim baseFare As Decimal = If(isIntl, If(cityDest.Contains("Tokyo") OrElse cityDest.Contains("Osaka"), 8500D, If(cityDest.Contains("Seoul"), 7800D, 5500D)), 2800D)
            Dim durationStr As String = If(isIntl, "3h 45m", "1h 45m")
            Dim plane1 As String = If(isIntl, "Boeing 777-300ER", "Airbus A320")
            Dim plane2 As String = If(isIntl, "Airbus A350-900", "Boeing 737-800")

            Dim dyn1 As New FlightSchedule With {
                .FlightId = "F" & (AppState.Flights.Count + 1).ToString("000"),
                .Origin = cityOrig,
                .Destination = cityDest,
                .FlightDate = AppState.SearchDate.ToString("MMMM dd, yyyy"),
                .DepartureTime = "10:30 AM",
                .ArrivalTime = "12:15 PM",
                .Duration = durationStr,
                .FlightType = "Direct Flight",
                .BaseFare = baseFare,
                .Status = "Scheduled",
                .AircraftModel = plane1
            }

            Dim dyn2 As New FlightSchedule With {
                .FlightId = "F" & (AppState.Flights.Count + 2).ToString("000"),
                .Origin = cityOrig,
                .Destination = cityDest,
                .FlightDate = AppState.SearchDate.ToString("MMMM dd, yyyy"),
                .DepartureTime = "02:30 PM",
                .ArrivalTime = "04:15 PM",
                .Duration = durationStr,
                .FlightType = "Direct Flight",
                .BaseFare = baseFare,
                .Status = "Scheduled",
                .AircraftModel = plane2
            }

            AppState.Flights.Add(dyn1)
            AppState.Flights.Add(dyn2)
            matches.Add(dyn1)
            matches.Add(dyn2)
        End If

        If matches.Count >= 2 Then
            currentFlight1 = matches(0)
            currentFlight2 = matches(1)
        ElseIf matches.Count = 1 Then
            currentFlight1 = matches(0)
            currentFlight2 = matches(0)
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
