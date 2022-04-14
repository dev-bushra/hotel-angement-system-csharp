Public Class formroomslist
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
    Private Sub formroomslist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            sql = "SELECT * FROM tblrooms"
            conn.Open()
            With cmd
                .CommandText = Sql
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
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim RoomStatus = DataGridView1.CurrentRow.Cells("Status").Value.ToString

        'checkin
      
        If RoomStatus = "Unavailable" Or RoomStatus = "Reserve" Then
            MessageBox.Show("Not Available")
        Else

            RoomID = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString

            FormCheckin.txtRoom.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
            FormCheckin.txttype.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
            FormCheckin.rate.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString
            ' reserved
            FromReserve.txtRoom.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
            FromReserve.txttype.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
            FromReserve.rate.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString


        End If

        Me.Close()

    End Sub

    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        ' DataGridView1.Columns("IDrooms").Visible = False
    End Sub



   

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        'Me.Text = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
        ''checkin
        'FormCheckin.txtRoom.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
        'FormCheckin.txttype.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
        'FormCheckin.rate.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString

        '' reserved
        'FromReserve.txtRoom.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
        'FromReserve.txttype.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
        'FromReserve.rate.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class