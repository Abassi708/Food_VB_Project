Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "kawther" And txtPassword.Text = "kawther123" Then
            MsgBox("YOU LOGIN SUCCESSFULLY !!  ")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("WRONG LOGIN OR PASSWORD !! TRY AGAIN ")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
