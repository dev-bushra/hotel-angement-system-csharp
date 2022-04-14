Public Class formCheckinlist
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim Fname As String
    Dim Lname As String

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Monbeladb.accdb")
    End Function
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        'Me.Text = GuestId
        'checkin

        'FormCheckin.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        'FormCheckin.txtgname.Text = DataGridView1.CurrentRow.Cells("LNAME").Value.ToString()
        'FormCheckin.txtgname.Text = DataGridView1.CurrentRow.Cells("MNAME").Value.ToString()


        ''reservation
        'FromReserve.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        'FromReserve.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        'FromReserve.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("MNAME").Value.ToString

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'checkin

        FormCheckin.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        FormCheckin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        FormCheckin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("MNAME").Value.ToString
        ' FormCheckin.rate.Text = DataGridView1.CurrentRow.Cells("Status").Value.ToString()
        'reservation
        FromReserve.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        FromReserve.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        FromReserve.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("MNAME").Value.ToString
        MainForm.BringToFront()


        Me.Hide()
    End Sub

    


    Private Sub formCheckinlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            sql = "SELECT * FROM tblguest"
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
            DataGridView2.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

  

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        'FormCheckin.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        'FormCheckin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        'FormCheckin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("MNAME").Value.ToString
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        dt = New DataTable
        GuestId = DataGridView2.CurrentRow.Cells("ID").Value.ToString
        FormCheckin.txtgname.Text &= " " & DataGridView2.CurrentRow.Cells("GUESTNAME").Value.ToString
        FormCheckin.txtRoom.Text = DataGridView2.CurrentRow.Cells("ROOM_NO").Value.ToString()
        FormCheckin.rate.Text = DataGridView2.CurrentRow.Cells("ROOM_RATE").Value.ToString()
        FormCheckin.txttype.Text = DataGridView2.CurrentRow.Cells("ROOM_TYPE").Value.ToString()

        FormCheckin.txtdate.Value = DataGridView2.CurrentRow.Cells("CHECKIN_DATE").Value.ToString()
        FormCheckin.txtdays.Text = DataGridView2.CurrentRow.Cells("NOOFDAYS").Value.ToString()
        FormCheckin.txtadults.Text = DataGridView2.CurrentRow.Cells("NOOFADULTS").Value.ToString()
        FormCheckin.txtChildren.Text = DataGridView2.CurrentRow.Cells("NOOFCHILDREN").Value.ToString()
        FormCheckin.txtadvance.Text = DataGridView2.CurrentRow.Cells("ADVANCE").Value.ToString()





        Me.Close()
    End Sub
End Class