Imports System.Linq

Public Class BoardingTicket

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property TargetTicketNumber As String = ""

    Private Sub BoardingTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTicketData()
    End Sub

    Public Sub PopulateTicketData()
        Dim booking As BookingRecord = Nothing

        If Not String.IsNullOrEmpty(TargetTicketNumber) Then
            booking = AppState.Bookings.FirstOrDefault(Function(b) b.TicketNumber = TargetTicketNumber)
        End If

        If booking Is Nothing Then
            booking = AppState.Bookings.LastOrDefault()
        End If

        If booking IsNot Nothing Then
            lblPassengerName.Text = If(String.IsNullOrWhiteSpace(booking.PassengerName), "Valued Passenger", booking.PassengerName)
            lblGateValue.Text = booking.Gate
            lblSeatValue.Text = booking.SeatNumber
            lblTicketId.Text = "Ticket: " & booking.TicketNumber
            lblClassValue.Text = If(booking.CabinClass.EndsWith("Class", StringComparison.OrdinalIgnoreCase), booking.CabinClass, booking.CabinClass & " Class")

            If booking.Flight IsNot Nothing Then
                lblFlightNoValue.Text = booking.Flight.FlightId & " (" & booking.Flight.AircraftModel & ")"
                lblTimeValue.Text = booking.Flight.DepartureTime
                lblFromValue.Text = booking.Flight.Origin & " (" & booking.Flight.FlightType & ")"
                lblToValue.Text = booking.Flight.Destination
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblFromValue_Click(sender As Object, e As EventArgs) Handles lblFromValue.Click

    End Sub


End Class