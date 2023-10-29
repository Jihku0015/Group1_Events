Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class REGISTRATION_FORM


    Private Sub TextBoxRegUser_Enter(sender As Object, e As EventArgs) Handles TextBoxRegUser.Enter

        Dim user As String = TextBoxRegUser.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If user.Trim().ToLower() = "username" Or user.Trim() = "" Then
            TextBoxRegUser.Text = ""
            TextBoxRegUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxRegUser_Leave(sender As Object, e As EventArgs) Handles TextBoxRegUser.Leave

        Dim user As String = TextBoxRegUser.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If user.Trim().ToLower() = "username" Or user.Trim() = "" Then
            TextBoxRegUser.Text = "Username"
            TextBoxRegUser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBoxRegPass_Enter(sender As Object, e As EventArgs) Handles TextBoxRegPass.Enter

        Dim pass As String = TextBoxRegPass.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBoxRegPass.Text = ""
            TextBoxRegPass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxRegPass_Leave(sender As Object, e As EventArgs) Handles TextBoxRegPass.Leave

        Dim pass As String = TextBoxRegPass.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBoxRegPass.Text = "Password"
            TextBoxRegPass.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBoxEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxEmail.Enter

        Dim email As String = TextBoxEmail.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If email.Trim().ToLower() = "email address" Or email.Trim() = "" Then
            TextBoxEmail.Text = ""
            TextBoxEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave

        Dim email As String = TextBoxEmail.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If email.Trim().ToLower() = "email address" Or email.Trim() = "" Then
            TextBoxEmail.Text = "Email Address"
            TextBoxEmail.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub RegButton_Click(sender As Object, e As EventArgs) Handles RegButton.Click

        Dim reguser As String = TextBoxRegUser.Text
        Dim regpass As String = TextBoxRegPass.Text
        Dim email As String = TextBoxEmail.Text
        Dim otp As String
        Dim cotp As String
        If reguser.Trim() = "" Or regpass.Trim() = "" Or email.Trim() = "" Then
            MsgBox("There are Empty Fields")
        ElseIf usernameExist(reguser) Then
            MsgBox("Username Already Exist")
        Else
            Dim conn As New My_Connection()
            Dim command As New MySqlCommand("INSERT INTO `users`(`username`, `password`, `email`) VALUES (@reguser, @regpass, @email)", conn.getConnection())

            command.Parameters.Add("@reguser", MySqlDbType.VarChar).Value = reguser
            command.Parameters.Add("@regpass", MySqlDbType.VarChar).Value = regpass
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email

            conn.openConnection()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("User Inserted")
                Me.Hide()
                LOGIN_FORM.Show()
            Else
                MsgBox("User Not Inserted")
            End If

        End If



    End Sub

    Public Function usernameExist(ByVal reguser As String) As Boolean
        Dim con As New My_Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT `username` FROM `users` WHERE `username` = @user", con.getConnection())
        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = reguser

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LOGIN_FORM.Close()
    End Sub

    Private Sub LabelRegPass_Click(sender As Object, e As EventArgs) Handles LabelRegPass.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged

    End Sub
End Class