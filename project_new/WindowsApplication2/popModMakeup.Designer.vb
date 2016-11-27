<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popModMakeup
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
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.cmbReason = New System.Windows.Forms.ComboBox()
        Me.dtpMakeUpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFacID = New System.Windows.Forms.TextBox()
        Me.txtFacName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtbxRoom = New System.Windows.Forms.TextBox()
        Me.txtbxStart = New System.Windows.Forms.TextBox()
        Me.txtbxEnd = New System.Windows.Forms.TextBox()
        Me.cmbbxCourse = New System.Windows.Forms.ComboBox()
        Me.cmbbxSection = New System.Windows.Forms.ComboBox()
        Me.txtbxReason = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(330, 290)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 87
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(132, 290)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(90, 30)
        Me.bttnModify.TabIndex = 86
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'cmbReason
        '
        Me.cmbReason.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReason.FormattingEnabled = True
        Me.cmbReason.Location = New System.Drawing.Point(216, 250)
        Me.cmbReason.Name = "cmbReason"
        Me.cmbReason.Size = New System.Drawing.Size(72, 28)
        Me.cmbReason.TabIndex = 104
        '
        'dtpMakeUpDate
        '
        Me.dtpMakeUpDate.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMakeUpDate.Location = New System.Drawing.Point(216, 70)
        Me.dtpMakeUpDate.Name = "dtpMakeUpDate"
        Me.dtpMakeUpDate.Size = New System.Drawing.Size(313, 26)
        Me.dtpMakeUpDate.TabIndex = 103
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(105, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 20)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Start Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(115, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "End Time:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(148, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Room:"
        '
        'txtFacID
        '
        Me.txtFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacID.Location = New System.Drawing.Point(216, 10)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.Size = New System.Drawing.Size(120, 26)
        Me.txtFacID.TabIndex = 92
        '
        'txtFacName
        '
        Me.txtFacName.Enabled = False
        Me.txtFacName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacName.Location = New System.Drawing.Point(216, 40)
        Me.txtFacName.Name = "txtFacName"
        Me.txtFacName.ReadOnly = True
        Me.txtFacName.Size = New System.Drawing.Size(313, 26)
        Me.txtFacName.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(71, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Make-Up Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(19, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 20)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Reason For Absence:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(110, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Faculty ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(79, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Faculty Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(135, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Course:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(132, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Section:"
        '
        'txtbxRoom
        '
        Me.txtbxRoom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRoom.Location = New System.Drawing.Point(216, 160)
        Me.txtbxRoom.Name = "txtbxRoom"
        Me.txtbxRoom.Size = New System.Drawing.Size(120, 26)
        Me.txtbxRoom.TabIndex = 110
        '
        'txtbxStart
        '
        Me.txtbxStart.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStart.Location = New System.Drawing.Point(216, 190)
        Me.txtbxStart.Name = "txtbxStart"
        Me.txtbxStart.Size = New System.Drawing.Size(120, 26)
        Me.txtbxStart.TabIndex = 111
        '
        'txtbxEnd
        '
        Me.txtbxEnd.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnd.Location = New System.Drawing.Point(216, 220)
        Me.txtbxEnd.Name = "txtbxEnd"
        Me.txtbxEnd.Size = New System.Drawing.Size(120, 26)
        Me.txtbxEnd.TabIndex = 112
        '
        'cmbbxCourse
        '
        Me.cmbbxCourse.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxCourse.FormattingEnabled = True
        Me.cmbbxCourse.Location = New System.Drawing.Point(216, 100)
        Me.cmbbxCourse.Name = "cmbbxCourse"
        Me.cmbbxCourse.Size = New System.Drawing.Size(120, 28)
        Me.cmbbxCourse.TabIndex = 114
        '
        'cmbbxSection
        '
        Me.cmbbxSection.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSection.FormattingEnabled = True
        Me.cmbbxSection.Location = New System.Drawing.Point(216, 130)
        Me.cmbbxSection.Name = "cmbbxSection"
        Me.cmbbxSection.Size = New System.Drawing.Size(120, 28)
        Me.cmbbxSection.TabIndex = 115
        '
        'txtbxReason
        '
        Me.txtbxReason.Enabled = False
        Me.txtbxReason.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxReason.Location = New System.Drawing.Point(294, 250)
        Me.txtbxReason.Name = "txtbxReason"
        Me.txtbxReason.ReadOnly = True
        Me.txtbxReason.Size = New System.Drawing.Size(235, 26)
        Me.txtbxReason.TabIndex = 116
        '
        'popModMakeup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 331)
        Me.Controls.Add(Me.txtbxReason)
        Me.Controls.Add(Me.cmbbxSection)
        Me.Controls.Add(Me.cmbbxCourse)
        Me.Controls.Add(Me.txtbxEnd)
        Me.Controls.Add(Me.txtbxStart)
        Me.Controls.Add(Me.txtbxRoom)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbReason)
        Me.Controls.Add(Me.dtpMakeUpDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFacID)
        Me.Controls.Add(Me.txtFacName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnModify)
        Me.Name = "popModMakeup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Make Up Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnBack As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents dtpMakeUpDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFacID As TextBox
    Friend WithEvents txtFacName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbxRoom As TextBox
    Friend WithEvents txtbxStart As TextBox
    Friend WithEvents txtbxEnd As TextBox
    Friend WithEvents cmbbxCourse As ComboBox
    Friend WithEvents cmbbxSection As ComboBox
    Friend WithEvents txtbxReason As TextBox
End Class
