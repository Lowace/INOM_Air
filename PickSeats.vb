Imports Guna.UI2.WinForms

Public Class PickSeats

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedSeatCode As String = "1A"
    Private currentSelectedButton As Guna2Button = Nothing

    Private Sub PickSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuildSeatGrid()

    End Sub

    Private Sub SelectSeat(btn As Guna2Button, code As String)

    End Sub

    Private Sub btnConfirmSeat_Click(sender As Object, e As EventArgs) Handles btnConfirmSeat.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click

    End Sub

End Class
