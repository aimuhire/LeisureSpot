Public Class UCLoginRegister


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If tbEmail.Text Is "" Or tbPassword.Text Is "" Then
            MessageBox.Show("All fields are required")
            Exit Sub
        End If

        Dim dbHelper As New DbHelper

        Dim res As Response = dbHelper.Login(tbEmail.Text, tbPassword.Text)
        If (res.Success) Then
            If res.Message = "admin" Then
                LoginInfo.access = "admin"
                MainForm.createScreen("leisurespot.ucadminpanel")
                MainForm.myMenu.Items.Clear()
                MainForm.addSpotsBtn()
                MainForm.addAdminButtons()
                tbEmail.Clear()
                tbPassword.Clear()


            End If
        Else
            MessageBox.Show("Login Failed: " + res.Message)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If tbPassreg.Text <> tbPassregconfirm.Text Then
            lblErrorTip.Visible = True
            Exit Sub
        Else
            lblErrorTip.Visible = False
        End If

        If tbPassreg.Text Is Nothing Or tbEmail.Text Is Nothing Or tbPassregconfirm.Text Is Nothing Then
            MessageBox.Show("All fields are required")
            Exit Sub
        End If
        Dim dbHelper As New DbHelper

        Dim res As Response = dbHelper.registerUser(tbEmailreg.Text, tbPassreg.Text)
        If (res.Success) Then
            MessageBox.Show("User created.")
        Else
            MessageBox.Show("User not created: " + res.Message)
        End If

    End Sub


End Class
