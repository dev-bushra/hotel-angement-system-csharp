Public Class formhistory
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Monbeladb.accdb")
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Check in list" Then
            dt = New DataTable
            Try
                sql = "SELECT * FROM tblcheckin"
                conn.Open()
                With cmd
                    .CommandText = sql
                    .Connection = conn
                End With

                da.SelectCommand = cmd
                da.Fill(dt)
                DataGridView1.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

        elseIf ComboBox1.Text = "Check out list" Then
        dt = New DataTable
        Try
            sql = "SELECT * FROM tblcheckout"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        ElseIf ComboBox1.Text = "Reserve list" Then
            dt = New DataTable
            Try
                sql = "SELECT * FROM tblreserve"
                conn.Open()
                With cmd
                    .CommandText = sql
                    .Connection = conn
                End With

                da.SelectCommand = cmd
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        FormCheckin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("GUESTNAME").Value.ToString
        FormCheckin.txtRoom.Text = DataGridView1.CurrentRow.Cells("ROOM_NO").Value.ToString()
        FormCheckin.rate.Text = DataGridView1.CurrentRow.Cells("ROOM_RATE").Value.ToString()
        FormCheckin.txttype.Text = DataGridView1.CurrentRow.Cells("ROOM_TYPE").Value.ToString()

        FormCheckin.txtdate.Value = DataGridView1.CurrentRow.Cells("CHECKIN_DATE").Value.ToString()
        FormCheckin.txtdays.Text = DataGridView1.CurrentRow.Cells("NOOFDAYS").Value.ToString()
        FormCheckin.txtadults.Text = DataGridView1.CurrentRow.Cells("NOOFADULTS").Value.ToString()
        FormCheckin.txtChildren.Text = DataGridView1.CurrentRow.Cells("NOOFCHILDREN").Value.ToString()
        FormCheckin.txtadvance.Text = DataGridView1.CurrentRow.Cells("ADVANCE").Value.ToString()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "Check in list" Then
          
            dt = New DataTable
            sql = "Select * from tblcheckin where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()
        elseIf ComboBox1.Text = "Check out list" Then
            dt = New DataTable
            sql = "Select * from tblcheckout where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()

        elseIf ComboBox1.Text = "Reserve list" Then
            dt = New DataTable
            sql = "Select * from tblreserve where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()

        End If
      
    End Sub

    Private Sub formhistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class