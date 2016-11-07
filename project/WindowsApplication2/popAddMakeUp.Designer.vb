<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popAddMakeUp
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
        Me.dtpMakeUpDate = New System.Windows.Forms.DateTimePicker()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtChecker = New System.Windows.Forms.TextBox()
        Me.txtEncoder = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbReason = New System.Windows.Forms.ComboBox()
        Me.dtpFiled = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpMakeUpDate
        '
        Me.dtpMakeUpDate.Location = New System.Drawing.Point(216, 35)
        Me.dtpMakeUpDate.Name = "dtpMakeUpDate"
        Me.dtpMakeUpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpMakeUpDate.TabIndex = 62
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(349, 214)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(95, 70)
        Me.bttnBack.TabIndex = 61
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(162, 214)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(95, 70)
        Me.bttnAdd.TabIndex = 60
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(216, 114)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(121, 20)
        Me.txtStart.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(103, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 18)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Start Time:"
        '
        'txtChecker
        '
        Me.txtChecker.Location = New System.Drawing.Point(450, 185)
        Me.txtChecker.Name = "txtChecker"
        Me.txtChecker.Size = New System.Drawing.Size(121, 20)
        Me.txtChecker.TabIndex = 57
        '
        'txtEncoder
        '
        Me.txtEncoder.Location = New System.Drawing.Point(216, 188)
        Me.txtEncoder.Name = "txtEncoder"
        Me.txtEncoder.Size = New System.Drawing.Size(121, 20)
        Me.txtEncoder.TabIndex = 56
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(216, 140)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(121, 20)
        Me.txtEnd.TabIndex = 55
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(216, 88)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(121, 20)
        Me.txtRoom.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(124, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Encoder:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(112, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "End Time:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(146, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Room:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(106, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Date Filed:"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(216, 9)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(121, 20)
        Me.txtRef.TabIndex = 46
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(294, 163)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(235, 20)
        Me.txtReason.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(80, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Make-Up Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(110, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(26, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Reason For Absence:"
        '
        'cmbReason
        '
        Me.cmbReason.FormattingEnabled = True
        Me.cmbReason.Location = New System.Drawing.Point(216, 162)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(72, 21)
        Me.cmbReason.TabIndex = 64
        '
        'dtpFiled
        '
        Me.dtpFiled.Location = New System.Drawing.Point(216, 62)
        Me.dtpFiled.Name = "dtpFiled"
        Me.dtpFiled.Size = New System.Drawing.Size(200, 20)
        Me.dtpFiled.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(361, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Checker:"
        '
        'popAddMakeUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFiled)
        Me.Controls.Add(Me.cmbReason)
        Me.Controls.Add(Me.dtpMakeUpDate)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtChecker)
        Me.Controls.Add(Me.txtEncoder)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "popAddMakeUp"
        Me.Text = "Add Make Up Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpMakeUpDate As DateTimePicker
    Friend WithEvents bttnBack As Button
    Friend WithEvents bttnAdd As Button
    Friend WithEvents txtStart As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtChecker As TextBox
    Friend WithEvents txtEncoder As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents dtpFiled As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
