Public Class AddEmployee
    Dim Gender As String
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If RadioButton1.Checked Then
            Gender = "Male"
        ElseIf RadioButton2.Checked Then
            Gender = "Female"
        End If
        save("INSERT INTO  tblemployee(FNAME,LNAME,MNAME,ADDRESS,CONTACT_NO,GENDER,EMAIL,BDAY,AGE,STATUS) VALUES ('" & txtFName.Text & "', '" & txtLName.Text & "','" & txtMName.Text & "', '" & txtAddress.Text & "', '" & txtNumber.Text & "', '" & Gender & "', '" & txtEmail.Text & "', '" & bday.Value & "' , '" & txtage.Text & "', '" & cbstatus.Text & "'  )")

    End Sub
End Class