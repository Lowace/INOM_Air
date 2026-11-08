Imports System.Linq

Public Class SignUpPage
    Private termsAccepted As Boolean = False

    Private Sub SignUpPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmitSignup.Enabled = termsAccepted
    End Sub

    Private Sub btnNextStep_Click(sender As Object, e As EventArgs) Handles btnNextStep.Click
        Dim username = txtRegUsername.Text.Trim()
        Dim password = txtRegPassword.Text.Trim()
        Dim confirmPass = txtRegConfirmPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            CustomMessageBox.Show("Please enter a valid username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirmPass Then
            CustomMessageBox.Show("Passwords do not match. Please re-check.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AppState.Users.Any(Function(u) u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) Then
            CustomMessageBox.Show("That username is already taken. Please choose another.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        pnlStep1.Visible = False
        pnlStep2.Visible = True
        pnlStep2.BringToFront()
        btnSubmitSignup.Enabled = termsAccepted
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
        If Not termsAccepted Then
            CustomMessageBox.Show("Please review and accept the Terms & Conditions before creating your account.", "Terms Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim givenName = txtGivenName.Text.Trim()
        Dim surname = txtSurname.Text.Trim()
        Dim contact = txtContactNumber.Text.Trim()

        If String.IsNullOrWhiteSpace(givenName) OrElse String.IsNullOrWhiteSpace(surname) Then
            CustomMessageBox.Show("Please enter your given name and surname.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        CustomMessageBox.Show("Account successfully created!" & vbCrLf & vbCrLf & "Welcome to INOM Air, " & newUser.GivenName & "!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim custForm As New CustomerForm()
        custForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSignupTerms_Click(sender As Object, e As EventArgs) Handles btnSignupTerms.Click
        Dim res = CustomMessageBox.ShowTermsAndConditions(Me, requireAccept:=True)
        If res = DialogResult.OK Then
            termsAccepted = True
            btnSubmitSignup.Enabled = True
            btnSignupTerms.Text = "✓ Terms and Conditions Accepted (Click to re-read)"
            btnSignupTerms.ForeColor = Color.FromArgb(1, 123, 128)
        End If
    End Sub


End Class