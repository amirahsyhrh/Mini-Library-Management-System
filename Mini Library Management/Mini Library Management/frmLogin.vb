Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strusername As String = "Umdimi"
        Dim strPassword As String = "1234"
        Dim strUser As String
        Dim strPass As String

        strUser = txtUsername.Text
        strPass = txtPassword.Text
        If txtPassword.Text = String.Empty Or txtUsername.Text = String.Empty Then
            MsgBox("Please Enter Username & Password!")
        Else
            If strUser = strusername And strPass = strPassword Then
                MsgBox("Login Successful")
                frmHomeScreen.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Username or Password")
                txtPassword.Text = ""
                txtUsername.Text = ""
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        SplashScreen1.Close()
    End Sub
End Class
