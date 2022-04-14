<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtgname = New System.Windows.Forms.TextBox
        Me.txtRoom = New System.Windows.Forms.TextBox
        Me.rate = New System.Windows.Forms.TextBox
        Me.btncheckin = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtadults = New System.Windows.Forms.TextBox
        Me.txtdays = New System.Windows.Forms.TextBox
        Me.txtChildren = New System.Windows.Forms.TextBox
        Me.txttype = New System.Windows.Forms.TextBox
        Me.txtdate = New System.Windows.Forms.DateTimePicker
        Me.txtadvance = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtgname
        '
        Me.txtgname.Enabled = False
        Me.txtgname.Location = New System.Drawing.Point(33, 120)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(163, 20)
        Me.txtgname.TabIndex = 0
        '
        'txtRoom
        '
        Me.txtRoom.Enabled = False
        Me.txtRoom.Location = New System.Drawing.Point(33, 174)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(163, 20)
        Me.txtRoom.TabIndex = 1
        '
        'rate
        '
        Me.rate.Enabled = False
        Me.rate.Location = New System.Drawing.Point(33, 290)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(163, 20)
        Me.rate.TabIndex = 3
        '
        'btncheckin
        '
        Me.btncheckin.Location = New System.Drawing.Point(278, 420)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(75, 40)
        Me.btncheckin.TabIndex = 11
        Me.btncheckin.Text = "Check in"
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(370, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Guest Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Room Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Check in Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "No. Of Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "No. of Adults"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No. Of Children"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(-5, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(715, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "_________________________________________________________________________________" & _
            "_____________________________________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(176, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(190, 44)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Check In"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(202, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 24)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "...."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(202, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 24)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "...."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtadults
        '
        Me.txtadults.Location = New System.Drawing.Point(308, 234)
        Me.txtadults.Name = "txtadults"
        Me.txtadults.Size = New System.Drawing.Size(167, 20)
        Me.txtadults.TabIndex = 33
        Me.txtadults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdays
        '
        Me.txtdays.Enabled = False
        Me.txtdays.Location = New System.Drawing.Point(308, 174)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(167, 20)
        Me.txtdays.TabIndex = 34
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(308, 291)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(167, 20)
        Me.txtChildren.TabIndex = 35
        Me.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttype
        '
        Me.txttype.Enabled = False
        Me.txttype.Location = New System.Drawing.Point(33, 234)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(163, 20)
        Me.txttype.TabIndex = 36
        '
        'txtdate
        '
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(33, 351)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(163, 20)
        Me.txtdate.TabIndex = 37
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(308, 351)
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(167, 20)
        Me.txtadvance.TabIndex = 39
        Me.txtadvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Advance Payment"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(308, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(80, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(394, 117)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(81, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Date start"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Date End"
        '
        'FormCheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 472)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtadvance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtChildren)
        Me.Controls.Add(Me.txtdays)
        Me.Controls.Add(Me.txtadults)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.txtgname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "FormCheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCheckin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtgname As System.Windows.Forms.TextBox
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents btncheckin As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtadults As System.Windows.Forms.TextBox
    Friend WithEvents txtdays As System.Windows.Forms.TextBox
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
