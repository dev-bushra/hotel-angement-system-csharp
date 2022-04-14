Imports System.Data.OleDb

Public Class GuestInfo
    Dim Gender As String

    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If RadioButton1.Checked Then
            Gender = "Male"
        ElseIf RadioButton2.Checked Then
            Gender = "Female"
        End If
        save("INSERT INTO  tblguest(FNAME,LNAME,MNAME,ADDRESS,CONTACT_NO,GENDER,EMAIL) VALUES ('" & txtFName.Text & "', '" & txtLName.Text & "','" & txtMName.Text & "', '" & txtAddress.Text & "', '" & txtNumber.Text & "', '" & Gender & "', '" & txtEmail.Text & "')")
      
    End Sub


    Public Sub cleartextfields()
        For Each crt As Control In Me.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next
    End Sub

   
End Class