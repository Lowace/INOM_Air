Imports System.Linq

Public Class BookingStep3
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property PreviousForm As Form

    Private epSenior As New ErrorProvider()

    Private Sub BookingStep3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        epSenior.BlinkStyle = ErrorBlinkStyle.NeverBlink
        txtB3GivenName.Text = AppState.GuestGivenName
        txtB3Surname.Text = AppState.GuestSurname
        cmbB3Gender.SelectedItem = AppState.GuestGender
        If cmbB3Gender.SelectedIndex < 0 Then cmbB3Gender.SelectedIndex = 0
        txtB3Age.Text = AppState.GuestAge.ToString()
        cmbB3AgeGroup.SelectedIndex = If(AppState.GuestAge >= 60, 1, 0)
        rbB3DisabledYes.Checked = AppState.GuestIsPwd
        rbB3DisabledNo.Checked = Not AppState.GuestIsPwd
        RecalculateCurrentPrice()
    End Sub

    Private Sub ConcessionChanged(sender As Object, e As EventArgs) Handles rbB3DisabledYes.CheckedChanged, rbB3DisabledNo.CheckedChanged, cmbB3AgeGroup.SelectedIndexChanged, txtB3Age.TextChanged
        RecalculateCurrentPrice()
    End Sub

    Private Function ValidateSeniorConcession() As Boolean
        Dim ageVal As Integer = 0
        Dim parsed = Integer.TryParse(txtB3Age.Text.Trim(), ageVal)
        Dim isSeniorGroup = (cmbB3AgeGroup.SelectedIndex = 1)

        If Not parsed OrElse ageVal <= 0 OrElse ageVal > 120 Then
            epSenior.SetError(txtB3Age, "Please enter a valid age between 1 and 120.")
            epSenior.SetError(cmbB3AgeGroup, "")
            Return False
        End If

        If isSeniorGroup AndAlso ageVal < 60 Then
            epSenior.SetError(txtB3Age, "Passenger is not a Senior Citizen (Age must be 60 or above).")
            epSenior.SetError(cmbB3AgeGroup, "Senior Citizen concession requires passenger age to be 60 or above.")
            Return False
        Else
            epSenior.SetError(txtB3Age, "")
            epSenior.SetError(cmbB3AgeGroup, "")
            Return True
        End If
    End Function

    Private Sub RecalculateCurrentPrice()
        ValidateSeniorConcession()
        Dim ageVal As Integer = 25
        Integer.TryParse(txtB3Age.Text.Trim(), ageVal)
        Dim isSenior = (ageVal >= 60) AndAlso (cmbB3AgeGroup.SelectedIndex = 1)
        Dim isPwd = rbB3DisabledYes.Checked
        AppState.RecalculateActiveBookingPrice(isSenior, isPwd, AppState.ActiveBooking.CheckedBaggageKg, AppState.ActiveBooking.IsRefundable)
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        Dim b = AppState.ActiveBooking
        If b.Flight Is Nothing Then Return
        lblB3SummaryDate.Text = b.Flight.FlightDate
        lblB3SummaryRoute.Text = b.Flight.RouteDisplay
        lblB3SummaryTime.Text = b.Flight.TimeDisplay & " (" & b.Flight.Duration & ")"
        lblB3SummaryTotalAmount.Text = "PHP " & b.TotalAmount.ToString("N2")
    End Sub

    Private Sub btnB3Back_Click(sender As Object, e As EventArgs) Handles btnB3Back.Click
        If PreviousForm IsNot Nothing AndAlso Not PreviousForm.IsDisposed AndAlso Not PreviousForm.Disposing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnB3Next_Click(sender As Object, e As EventArgs) Handles btnB3Next.Click
        Dim given = txtB3GivenName.Text.Trim()
        Dim surname = txtB3Surname.Text.Trim()
        If String.IsNullOrWhiteSpace(given) OrElse String.IsNullOrWhiteSpace(surname) Then
            CustomMessageBox.Show("Please enter guest given name and surname.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ageVal As Integer = 0
        Integer.TryParse(txtB3Age.Text.Trim(), ageVal)
        If cmbB3AgeGroup.SelectedIndex = 1 AndAlso ageVal < 60 Then
            CustomMessageBox.Show("The passenger does not qualify for the Senior Citizen discount." & vbCrLf &
                                  "Senior Citizen concession is strictly reserved for passengers aged 60 and above." & vbCrLf & vbCrLf &
                                  "Entered age: " & ageVal.ToString() & " years old." & vbCrLf &
                                  "Please verify the entered age or select the Adult category.",
                                  "Senior Concession Ineligible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtB3Age.Focus()
            Return
        End If

        If Not ValidateSeniorConcession() Then
            CustomMessageBox.Show("Please check passenger age before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtB3Age.Focus()
            Return
        End If

        AppState.ActiveBooking.PassengerName = given & " " & surname
        RecalculateCurrentPrice()

        Dim f As New BookingStep5()
        f.PreviousForm = Me
        Me.Hide()
        f.Show()
    End Sub

    Private Sub btnCloseX_Click(sender As Object, e As EventArgs) Handles btnCloseX.Click
        Application.Exit()
    End Sub
End Class
