
Imports System.Globalization
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class MainPage


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LOGIN_FORM.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eventname As String = EventNameBox.Text
        Dim eventvenue As String = Venue.Text
        Dim strtime As String = StartTime.Value.ToShortTimeString()
        Dim enddtime As String = EndTime.Value.ToShortTimeString()
        Dim strtdate As String = StartingDate.Value.ToShortDateString()
        Dim endate As String = EndingDate.Value.ToShortDateString()

        If eventname.Trim() = "" Or eventvenue.Trim() = "" Then
            MsgBox("There are Empty Fields")
        ElseIf dateExist(strtdate) And timeExist(strtime) Then
            MsgBox("Date And Time was Already Occupied")
        Else
            Dim conn As New My_Connection()
            Dim command As New MySqlCommand("INSERT INTO `events`(`EventName`, `Venue`, `startTime`, `endTime`, `startDate`, `endDate`) VALUES (@evntname, @venue, @strtime, @enddtime, @strtdate, @endate)", conn.getConnection())

            command.Parameters.Add("@evntname", MySqlDbType.VarChar).Value = eventname
            command.Parameters.Add("@venue", MySqlDbType.VarChar).Value = eventvenue
            command.Parameters.Add("@strtime", MySqlDbType.VarChar).Value = strtime
            command.Parameters.Add("@enddtime", MySqlDbType.VarChar).Value = enddtime
            command.Parameters.Add("@strtdate", MySqlDbType.VarChar).Value = strtdate
            command.Parameters.Add("@endate", MySqlDbType.VarChar).Value = endate

            conn.openConnection()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("User Inserted")
            Else
                MsgBox("User Not Inserted")
            End If
        End If

    End Sub
    Public Function dateExist(ByVal strtdate As String) As Boolean
        Dim con As New My_Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  `startDate` FROM `events` WHERE `startDate` = @date", con.getConnection())
        command.Parameters.Add("@date", MySqlDbType.VarChar).Value = strtdate

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function timeExist(ByVal strtime As String) As Boolean
        Dim con As New My_Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  `startTime` FROM `events` WHERE `startTime` = @strtime", con.getConnection())
        command.Parameters.Add("@strtime", MySqlDbType.VarChar).Value = strtime

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub StartingDate_ValueChanged(sender As Object, e As EventArgs) Handles StartingDate.ValueChanged


        EndingDate.MinDate = StartingDate.Value
    End Sub

    Private Sub StartTime_ValueChanged(sender As Object, e As EventArgs) Handles StartTime.ValueChanged
        EndTime.MinDate = StartTime.Value
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class