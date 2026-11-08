Public Class StartingPage

    Private Sub StartingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppState.InitializeDefaultData()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New SignInPage()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim signupForm As New SignUpPage()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, btnClose.Click
        Application.Exit()
    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click
        AppState.ReconnectDatabase(True)
    End Sub

    Private Sub btnStartingTerms_Click(sender As Object, e As EventArgs) Handles btnStartingTerms.Click
        CustomMessageBox.ShowTermsAndConditions(Me, requireAccept:=False)
    End Sub
End Class