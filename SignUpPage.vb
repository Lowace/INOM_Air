Imports System.Linq

Public Class SignUpPage

    Private Sub btnNextStep_Click(sender As Object, e As EventArgs) Handles btnNextStep.Click
        Dim username = txtRegUsername.Text.Trim()
        Dim password = txtRegPassword.Text.Trim()
        Dim confirmPass = txtRegConfirmPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter a valid username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPass Then
            MessageBox.Show("Passwords do not match. Please re-check.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AppState.Users.Any(Function(u) u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) Then
            MessageBox.Show("That username is already taken. Please choose another.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        pnlStep1.Visible = False
        pnlStep2.Visible = True
        pnlStep2.BringToFront()
    End Sub

    Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
        Dim startForm As New StartingPage()
        startForm.Show()
        Me.Close()
    End Sub

    Private Sub btnBackToStep1_Click(sender As Object, e As EventArgs) Handles btnBackToStep1.Click
        pnlStep2.Visible = False
        pnlStep1.Visible = True
        pnlStep1.BringToFront()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnSubmitSignup_Click(sender As Object, e As EventArgs) Handles btnSubmitSignup.Click
        Dim givenName = txtGivenName.Text.Trim()
        Dim surname = txtSurname.Text.Trim()
        Dim contact = txtContactNumber.Text.Trim()

        If String.IsNullOrWhiteSpace(givenName) OrElse String.IsNullOrWhiteSpace(surname) Then
            MessageBox.Show("Please enter your given name and surname.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dob = dtpBirthDate.Value
        Dim today = DateTime.Today
        Dim age = today.Year - dob.Year
        If dob.Date > today.AddYears(-age) Then age -= 1

        Dim isSeniorCitizen = (age >= 60) OrElse chkSeniorPwd.Checked
        Dim isPwdCustomer = chkSeniorPwd.Checked

        Dim newUser As New UserAccount With {
            .Username = txtRegUsername.Text.Trim(),
            .Password = txtRegPassword.Text.Trim(),
            .GivenName = givenName,
            .Surname = surname,
            .Gender = If(rbFemale.Checked, "Female", "Male"),
            .DateOfBirth = dob,
            .ContactNumber = "+63 " & contact,
            .Role = "Customer",
            .IsSenior = isSeniorCitizen,
            .IsPwd = isPwdCustomer
        }

        AppState.Users.Add(newUser)
        AppState.SaveUserToDatabase(newUser)
        AppState.CurrentUser = newUser

        MessageBox.Show("Account successfully created!" & vbCrLf & "Welcome to INOM Air, " & newUser.GivenName & "!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim custForm As New CustomerForm()
        custForm.Show()
        Me.Close()
    End Sub

End Class