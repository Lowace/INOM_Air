Imports System.Linq

Public Class BookingStep1
    Private Sub BookingStep1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbB1Origin.SelectedIndex = 0
        cmbB1Dest.SelectedIndex = 1
        cmbB1TripType.SelectedIndex = 0
    End Sub

    Private Sub btnB1Back_Click(sender As Object, e As EventArgs) Handles btnB1Back.Click
        Me.Close()
    End Sub

    Private Sub btnB1Next_Click(sender As Object, e As EventArgs) Handles btnB1Next.Click
        If cmbB1Origin.SelectedIndex = -1 Or cmbB1Dest.SelectedIndex = -1 Then
            MessageBox.Show("Please select both origin and destination.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim origin = cmbB1Origin.SelectedItem.ToString()
        Dim dest = cmbB1Dest.SelectedItem.ToString()
        If origin.Equals(dest, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Origin and destination cannot be the same.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        AppState.ActiveBooking = New BookingRecord With {
            .Username = AppState.CurrentUser.Username,
            .PassengerName = AppState.CurrentUser.FullName,
            .SeatNumber = "1A"
        }
        AppState.SearchOrigin = origin
        AppState.SearchDest = dest
        AppState.SearchDate = dtpB1Date.Value
        AppState.SearchTripType = cmbB1TripType.SelectedItem.ToString()

        Dim step2 As New BookingStep2()
        AddHandler step2.FormClosed, Sub(s, ev)
                                         If Not Me.IsDisposed AndAlso Not Me.Disposing Then
                                             Me.Show()
                                         End If
                                     End Sub
        step2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class