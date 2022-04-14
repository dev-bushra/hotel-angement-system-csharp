Imports System.Data.OleDb
Public Class FormCheckin
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim remarks As String = "Checkin"
    Dim con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Monbeladb.accdb")
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheckin.Click

        Dim sql = "INSERT INTO  tblcheckin(GUESTNAME,ROOM_NO,ROOM_TYPE,ROOM_RATE,CHECKIN_DATE,NOOFDAYS,NOOFADULTS,NOOFCHILDREN,ADVANCE,REMARKS) VALUES ('" & txtgname.Text & "', '" & txtRoom.Text & "','" & txttype.Text & "', '" & rate.Text & "', '" & txtdate.Value & "', '" & txtdays.Text & "', '" & txtadults.Text & "', '" & txtChildren.Text & "', '" & txtadvance.Text & "', '" & btncheckin.Text & "')"
        cashiersave(sql)

        Try
            sql = "UPDATE tblrooms SET Status='Unavailable' WHERE IDrooms=" & RoomID

            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()



        End Try
        Try
            sql = "DELETE * FROM tblreserve  WHERE ID=" & GuestId
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()


        End Try
      

        txtadults.Text = Nothing
        txtgname.Text = Nothing
        txtdays.Text = Nothing
        txttype.Text = Nothing
        txtRoom.Text = Nothing
        txtChildren.Text = Nothing
        rate.Text = Nothing
        txtadvance.Text = Nothing
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        formroomslist.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        formCheckinlist.ShowDialog()
    End Sub


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim dt1 As Date = Convert.ToDateTime(DateTimePicker1.Text)
        Dim dt2 As Date = Convert.ToDateTime(DateTimePicker2.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)
        txtdays.Text = Convert.ToInt32(ts.Days)
        Convert.ToInt32(ts.Days)
    End Sub

    Public Sub cleartextfields()
        For Each crt As Control In Me.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cleartextfields()
        'txtadults.Text = Nothing
        'txtgname.Text = Nothing
        'txtdays.Text = Nothing
        'txttype.Text = Nothing
        'txtRoom.Text = Nothing
        'txtChildren.Text = Nothing
        'rate.Text = Nothing
        'txtadvance.Text = Nothing
        Me.Close()
    End Sub
End Class
