Imports System.Linq

Public Class SignInPage

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim enteredUsername = txtUsername.Text.Trim()
        Dim enteredPassword = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(enteredUsername) OrElse String.IsNullOrWhiteSpace(enteredPassword) Then
            MessageBox.Show("Please enter both username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim account = AppState.Users.FirstOrDefault(Function(u) u.Username.Equals(enteredUsername, StringComparison.OrdinalIgnoreCase) AndAlso u.Password = enteredPassword)

        If account IsNot Nothing Then
            AppState.CurrentUser = account

            If account.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                Dim adminForm As New AdminPanel()
                adminForm.Show()
                Me.Close()
            Else
                Dim custForm As New CustomerForm()
                custForm.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Invalid username or password. Please try again." & vbCrLf & "(Hint: Naruto / password or admin / admin123)", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim startForm As New StartingPage()
        startForm.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub lblGoToSignUp_Click(sender As Object, e As EventArgs) Handles lblGoToSignUp.Click
        Dim signupForm As New SignUpPage()
        signupForm.Show()
        Me.Close()
    End Sub

End Class