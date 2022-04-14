Public Class FromReserve

    Private Sub FromReserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        formCheckinlist.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreserved.Click

        Dim sql = "INSERT INTO  tblreserve(GUESTNAME,ROOM_NO,ROOM_TYPE,ROOM_RATE,CHECKIN_DATE,NOOFDAYS,NOOFADULTS,NOOFCHILDREN,ADVANCE,REMARKS,RESERVATIONEND) VALUES ('" & txtgname.Text & "', '" & txtRoom.Text & "','" & txttype.Text & "', '" & rate.Text & "', '" & txtdate.Value & "', '" & txtdays.Text & "', '" & txtadults.Text & "', '" & txtChildren.Text & "', '" & txtadvance.Text & "','" & btnreserved.Text & "', '" & txtreserveend.Value & "')"

        save(sql)
        Try
            sql = "UPDATE tblrooms SET Status='Reserve' WHERE IDrooms=" & RoomID

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
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        formroomslist.ShowDialog()
    End Sub

    Private Sub txtreserveend_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreserveend.ValueChanged
        Dim dt1 As Date = Convert.ToDateTime(txtdate.Text)
        Dim dt2 As Date = Convert.ToDateTime(txtreserveend.Text)
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
       
        Me.Close()
    End Sub

End Class