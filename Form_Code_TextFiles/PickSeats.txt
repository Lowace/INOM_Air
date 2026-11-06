Imports Guna.UI2.WinForms

Public Class PickSeats

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedSeatCode As String = "1A"
    Private currentSelectedButton As Guna2Button = Nothing

    Private Sub PickSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildSeatGrid()
    End Sub

    Private Sub BuildSeatGrid()
        flpSeatGrid.Controls.Clear()

        Dim rows = 6
        Dim cols = {"A", "B", "C", "D", "E", "F"}
        Dim occupiedSeats = New HashSet(Of String)() From {"2B", "3D", "4A", "5F"}

        For r As Integer = 1 To rows
            Dim rowPanel As New Panel()
            rowPanel.Size = New Size(480, 48)
            rowPanel.Margin = New Padding(0, 4, 0, 4)

            Dim lblRow As New Label()
            lblRow.Text = "Row " & r
            lblRow.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblRow.ForeColor = Color.FromArgb(100, 100, 115)
            lblRow.Size = New Size(55, 38)
            lblRow.TextAlign = ContentAlignment.MiddleCenter
            lblRow.Location = New Point(0, 5)
            rowPanel.Controls.Add(lblRow)

            Dim xPos As Integer = 60

            For c As Integer = 0 To cols.Length - 1
                If c = 3 Then
                    xPos += 30
                End If

                Dim seatCode = r.ToString() & cols(c)
                Dim isOccupied = occupiedSeats.Contains(seatCode)
                Dim isBusiness = (r <= 2)

                Dim btnSeat As New Guna2Button()
                btnSeat.Size = New Size(54, 38)
                btnSeat.Location = New Point(xPos, 5)
                btnSeat.BorderRadius = 8
                btnSeat.Text = seatCode
                btnSeat.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
                btnSeat.Tag = seatCode
                btnSeat.Cursor = Cursors.Hand

                If isOccupied Then
                    btnSeat.FillColor = Color.FromArgb(210, 210, 215)
                    btnSeat.ForeColor = Color.FromArgb(140, 140, 150)
                    btnSeat.Enabled = False
                ElseIf isBusiness Then
                    btnSeat.FillColor = Color.FromArgb(254, 115, 73)
                    btnSeat.ForeColor = Color.FromArgb(105, 105, 105)
                    btnSeat.BorderColor = Color.FromArgb(220, 190, 80)
                    btnSeat.BorderThickness = 1
                Else
                    btnSeat.FillColor = Color.FromArgb(1, 123, 128)
                    btnSeat.ForeColor = Color.White
                End If

                If seatCode = SelectedSeatCode AndAlso Not isOccupied Then
                    SelectSeat(btnSeat, seatCode)
                End If

                AddHandler btnSeat.Click, Sub(s, ev)
                                              SelectSeat(CType(s, Guna2Button), seatCode)
                                          End Sub

                rowPanel.Controls.Add(btnSeat)
                xPos += 60
            Next

            flpSeatGrid.Controls.Add(rowPanel)
        Next
    End Sub

    Private Sub SelectSeat(btn As Guna2Button, code As String)
        If currentSelectedButton IsNot Nothing AndAlso currentSelectedButton.Enabled Then
            Dim prevCode = CStr(currentSelectedButton.Tag)
            Dim isPrevBusiness = prevCode.StartsWith("1") OrElse prevCode.StartsWith("2")
            If isPrevBusiness Then
                currentSelectedButton.FillColor = Color.FromArgb(254, 115, 73)
                currentSelectedButton.ForeColor = Color.FromArgb(105, 105, 105)
            Else
                currentSelectedButton.FillColor = Color.FromArgb(1, 123, 128)
                currentSelectedButton.ForeColor = Color.White
            End If
        End If

        currentSelectedButton = btn
        SelectedSeatCode = code
        btn.FillColor = Color.FromArgb(46, 204, 113)
        btn.ForeColor = Color.White

        lblSelectedSeatDisplay.Text = code
        Dim isBusiness = code.StartsWith("1") OrElse code.StartsWith("2")
        lblClassDisplay.Text = If(isBusiness, "Cabin: Business Class (+₱500)", "Cabin: Economy Class")
    End Sub

    Private Sub btnConfirmSeat_Click(sender As Object, e As EventArgs) Handles btnConfirmSeat.Click
        AppState.ActiveBooking.SeatNumber = SelectedSeatCode
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
