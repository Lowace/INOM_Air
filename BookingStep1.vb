Public Class BookingStep1
    Private Sub btnB1Next_Click(sender As Object, e As EventArgs) Handles btnB1Next.Click
        If cmbB1Origin.SelectedIndex = -1 Or cmbB1Dest.SelectedIndex = -1 OrElse Then
            MessageBox.Show("Please select both origin and destination.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbB1Origin.Text = cmbB1Dest.Text Then
            MessageBox.Show("Origin and destination cannot be the same.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub
End Class

Dim step2 As New BookingStep2()
step2.lblB2Origin.Text = cmbB1Origin.Text
step2.lblB2Dest.Text = cmbB1Dest.Text
step2.lblB2TripType = cmbB1TripType.Text

step2.Show()
Me.Hide()