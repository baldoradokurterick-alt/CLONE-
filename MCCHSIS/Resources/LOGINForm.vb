

Public Class LOGINForm



    Private Sub LOGINForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Closing Exams",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            DashboardForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("You have entered an incorrect login details", "Closing Exams",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub pnlCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlCard.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class