Imports System.Data.OleDb
Public Class LoginForm

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Monbeladb.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand( _
                   "SELECT * FROM tblaccount WHERE username = '" & _
                  txtuser.Text & "'  AND [Password] = '" & txtpass.Text & "' ", con)
        Dim user As String = ""
        Dim pass As String = ""

        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("username")
            pass = sdr("password")
            '  MessageBox.Show("The user is Invalid !")
            MainForm.BringToFront()
            MainForm.Show()
            MainForm.btncheckin.Enabled = True
            '              MainForm.btncheckout.Enabled = True
            MainForm.btnGuest.Enabled = True
            MainForm.btnreserved.Enabled = True
            MainForm.btnsearch.Enabled = True
            MainForm.btnAddemployee.Enabled = True
            MainForm.btnrooms.Enabled = True
            MainForm.Button1.Enabled = True
            MainForm.btnaccount.BackgroundImage = My.Resources._012_power_512red
            MainForm.btnhistory.Enabled = True

            Me.Close()


        Else

            MessageBox.Show("Invalid keyword!")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Text = "admin"
        txtpass.Text = "admin"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        MainForm.btncheckin.Enabled = False
        '              MainForm.btncheckout.Enabled = False
        MainForm.btnGuest.Enabled = False
        MainForm.btnreserved.Enabled = False
        MainForm.btnsearch.Enabled = False
        MainForm.btnAddemployee.Enabled = False
        MainForm.btnrooms.Enabled = False
        MainForm.Button1.Enabled = False
        MainForm.btnhistory.Enabled = False
    End Sub
End Class