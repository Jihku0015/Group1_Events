Imports MySql.Data.MySqlClient

Public Class LOGIN_FORM


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelReg.LinkClicked
        Me.Hide()
        REGISTRATION_FORM.Show()
    End Sub

    Private Sub TextBoxUser_Enter(sender As Object, e As EventArgs) Handles TextBoxUser.Enter
        'When textbox for pass gains focus for input'
        Dim user As String = TextBoxUser.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If user.Trim().ToLower() = "username" Or user.Trim() = "" Then
            TextBoxUser.Text = ""
            TextBoxUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxUser_Leave(sender As Object, e As EventArgs) Handles TextBoxUser.Leave
        'When textbox for pass gains focus for input'
        Dim user As String = TextBoxUser.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If user.Trim().ToLower() = "username" Or user.Trim() = "" Then
            TextBoxUser.Text = "Username"
            TextBoxUser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBoxPass_Enter(sender As Object, e As EventArgs) Handles TextBoxPass.Enter
        'When textbox for pass gains focus for input'
        Dim pass As String = TextBoxPass.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBoxPass.Text = ""
            TextBoxPass.ForeColor = Color.Black
            TextBoxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBoxPass_Leave(sender As Object, e As EventArgs) Handles TextBoxPass.Leave
        'when textbox for pass leaves focus'
        Dim pass As String = TextBoxPass.Text

        'Checks if the textbox is empty or not and clears the textbox and makes the forecolor Black'
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            TextBoxPass.Text = "Password"
            TextBoxPass.ForeColor = Color.DarkGray
            TextBoxPass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim conn As New My_Connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @usr And `password` = @pass", conn.getConnection())

        command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = TextBoxUser.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPass.Text

        If TextBoxUser.Text = "" Or TextBoxUser.Text.Trim() = "Username" Then
            MsgBox("Empty Username Field")
        ElseIf TextBoxPass.Text = "" Or TextBoxPass.Text.Trim() = "Password" Then
            MsgBox("Empty Password Field")

        Else
            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                Me.Hide()
                MainPage.Show()

            Else
                MsgBox("Please Create an Account First!")
            End If
        End If



    End Sub



    Private Sub TextBoxUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUser.TextChanged
        MainPage.Label3.Text = TextBoxUser.Text
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class