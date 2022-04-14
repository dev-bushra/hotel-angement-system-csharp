Public Class MainForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuest.Click
        GuestInfo.ShowDialog()
        GuestInfo.cleartextfields()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreserved.Click
        FromReserve.ShowDialog()
        FromReserve.cleartextfields()
    End Sub

    Private Sub btncheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheckin.Click
        FormCheckin.ShowDialog()
        FormCheckin.cleartextfields()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccount.Click

        btnaccount.BackgroundImage = My.Resources._012_power_512
        LoginForm.ShowDialog()

        LoginForm.txtuser.Text = "admin"
        LoginForm.txtpass.Text = "admin"




    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        FormSearch.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formcashier.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BringToFront()
    End Sub

    Private Sub btnsettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddemployee.Click
        AddEmployee.ShowDialog()
    End Sub

    Private Sub btnrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrooms.Click
        RoomStatus.ShowDialog()
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhistory.Click
        formhistory.ShowDialog()
    End Sub
End Class
