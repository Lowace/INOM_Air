Public Class CustomerForm

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshDashboard()

    End Sub

    Private Sub btnStartBooking_Click(sender As Object, e As EventArgs) Handles btnStartBooking.Click
        Dim book1 As New BookingStep1
        book1.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewFullDetails_Click(sender As Object, e As EventArgs) Handles btnViewFullDetails.Click

    End Sub

    Private Sub btnEditBooking_Click(sender As Object, e As EventArgs) Handles btnEditBooking.Click

    End Sub

    Private Sub btnCancelBooking_Click(sender As Object, e As EventArgs) Handles btnCancelBooking.Click

    End Sub

    Private Sub btnViewProfileInfo_Click(sender As Object, e As EventArgs) Handles btnViewProfileInfo.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim startpage As New StartingPage
        startpage.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

End Class
