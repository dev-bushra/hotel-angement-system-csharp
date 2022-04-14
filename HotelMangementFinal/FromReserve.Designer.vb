<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromReserve
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnreserved = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtdate = New System.Windows.Forms.DateTimePicker
        Me.txttype = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.rate = New System.Windows.Forms.TextBox
        Me.txtRoom = New System.Windows.Forms.TextBox
        Me.txtgname = New System.Windows.Forms.TextBox
        Me.txtreserveend = New System.Windows.Forms.DateTimePicker
        Me.txtadvance = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtChildren = New System.Windows.Forms.TextBox
        Me.txtdays = New System.Windows.Forms.TextBox
        Me.txtadults = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(201, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "...."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Stencil", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(110, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(262, 42)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "RESERVATION"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-8, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(832, 13)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "_________________________________________________________________________________" & _
            "________________________________________________________-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Reserve  Date end"
        '
        'btnreserved
        '
        Me.btnreserved.Location = New System.Drawing.Point(302, 348)
        Me.btnreserved.Name = "btnreserved"
        Me.btnreserved.Size = New System.Drawing.Size(91, 50)
        Me.btnreserved.TabIndex = 16
        Me.btnreserved.Text = "Reserved"
        Me.btnreserved.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(399, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 50)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(201, 133)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 23)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "...."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtdate
        '
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(32, 279)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(163, 20)
        Me.txtdate.TabIndex = 74
        '
        'txttype
        '
        Me.txttype.Enabled = False
        Me.txttype.Location = New System.Drawing.Point(31, 182)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(163, 20)
        Me.txttype.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Reserve Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Room Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Room Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Room Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Guest Name"
        '
        'rate
        '
        Me.rate.Enabled = False
        Me.rate.Location = New System.Drawing.Point(31, 230)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(163, 20)
        Me.rate.TabIndex = 67
        '
        'txtRoom
        '
        Me.txtRoom.Enabled = False
        Me.txtRoom.Location = New System.Drawing.Point(32, 136)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(163, 20)
        Me.txtRoom.TabIndex = 66
        '
        'txtgname
        '
        Me.txtgname.Enabled = False
        Me.txtgname.Location = New System.Drawing.Point(32, 89)
        Me.txtgname.Name = "txtgname"
        Me.txtgname.Size = New System.Drawing.Size(163, 20)
        Me.txtgname.TabIndex = 65
        '
        'txtreserveend
        '
        Me.txtreserveend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtreserveend.Location = New System.Drawing.Point(294, 89)
        Me.txtreserveend.Name = "txtreserveend"
        Me.txtreserveend.Size = New System.Drawing.Size(163, 20)
        Me.txtreserveend.TabIndex = 75
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(295, 287)
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(162, 20)
        Me.txtadvance.TabIndex = 83
        Me.txtadvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Advance Payment"
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(295, 230)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(162, 20)
        Me.txtChildren.TabIndex = 81
        Me.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdays
        '
        Me.txtdays.Enabled = False
        Me.txtdays.Location = New System.Drawing.Point(295, 132)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(162, 20)
        Me.txtdays.TabIndex = 80
        '
        'txtadults
        '
        Me.txtadults.Location = New System.Drawing.Point(295, 182)
        Me.txtadults.Name = "txtadults"
        Me.txtadults.Size = New System.Drawing.Size(162, 20)
        Me.txtadults.TabIndex = 79
        Me.txtadults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "No. Of Children"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "No. of Adults"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "No. Of Days"
        '
        'FromReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 410)
        Me.Controls.Add(Me.txtadvance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtChildren)
        Me.Controls.Add(Me.txtdays)
        Me.Controls.Add(Me.txtadults)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtreserveend)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.txtgname)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnreserved)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Name = "FromReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FromReserve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnreserved As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttype As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtgname As System.Windows.Forms.TextBox
    Friend WithEvents txtreserveend As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChildren As System.Windows.Forms.TextBox
    Friend WithEvents txtdays As System.Windows.Forms.TextBox
    Friend WithEvents txtadults As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
