<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwModFacultyDaily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwModFacultyDaily))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxFacID = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbbxCourse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbxStart = New System.Windows.Forms.TextBox()
        Me.cmbbxRemarks = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbxEnd = New System.Windows.Forms.TextBox()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.txtbxChecker = New System.Windows.Forms.TextBox()
        Me.cmbbxSection = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxDay = New System.Windows.Forms.TextBox()
        Me.txtbxRoom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(92, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Faculty ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(63, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Faculty name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(73, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Absent date:"
        '
        'txtbxFacID
        '
        Me.txtbxFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacID.Location = New System.Drawing.Point(198, 10)
        Me.txtbxFacID.Name = "txtbxFacID"
        Me.txtbxFacID.Size = New System.Drawing.Size(165, 26)
        Me.txtbxFacID.TabIndex = 1
        '
        'txtbxName
        '
        Me.txtbxName.Enabled = False
        Me.txtbxName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxName.Location = New System.Drawing.Point(198, 40)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.ReadOnly = True
        Me.txtbxName.Size = New System.Drawing.Size(313, 26)
        Me.txtbxName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(117, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Course:"
        '
        'cmbbxCourse
        '
        Me.cmbbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxCourse.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxCourse.FormattingEnabled = True
        Me.cmbbxCourse.Location = New System.Drawing.Point(198, 100)
        Me.cmbbxCourse.Name = "cmbbxCourse"
        Me.cmbbxCourse.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxCourse.Sorted = True
        Me.cmbbxCourse.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(114, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Section:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(130, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Room:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(104, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Remarks:"
        '
        'txtbxStart
        '
        Me.txtbxStart.Enabled = False
        Me.txtbxStart.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStart.Location = New System.Drawing.Point(198, 220)
        Me.txtbxStart.Name = "txtbxStart"
        Me.txtbxStart.ReadOnly = True
        Me.txtbxStart.Size = New System.Drawing.Size(165, 26)
        Me.txtbxStart.TabIndex = 8
        '
        'cmbbxRemarks
        '
        Me.cmbbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxRemarks.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxRemarks.FormattingEnabled = True
        Me.cmbbxRemarks.Location = New System.Drawing.Point(198, 280)
        Me.cmbbxRemarks.Name = "cmbbxRemarks"
        Me.cmbbxRemarks.Size = New System.Drawing.Size(313, 28)
        Me.cmbbxRemarks.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(107, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Checker:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(91, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Start time:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(101, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "End time:"
        '
        'txtbxEnd
        '
        Me.txtbxEnd.Enabled = False
        Me.txtbxEnd.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnd.Location = New System.Drawing.Point(198, 250)
        Me.txtbxEnd.Name = "txtbxEnd"
        Me.txtbxEnd.ReadOnly = True
        Me.txtbxEnd.Size = New System.Drawing.Size(165, 26)
        Me.txtbxEnd.TabIndex = 9
        '
        'bttnModify
        '
        Me.bttnModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(132, 350)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(90, 30)
        Me.bttnModify.TabIndex = 36
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(330, 350)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 37
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(198, 70)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(313, 26)
        Me.dtp.TabIndex = 3
        '
        'txtbxChecker
        '
        Me.txtbxChecker.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxChecker.Location = New System.Drawing.Point(198, 311)
        Me.txtbxChecker.Name = "txtbxChecker"
        Me.txtbxChecker.Size = New System.Drawing.Size(165, 26)
        Me.txtbxChecker.TabIndex = 11
        '
        'cmbbxSection
        '
        Me.cmbbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSection.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSection.FormattingEnabled = True
        Me.cmbbxSection.Location = New System.Drawing.Point(198, 130)
        Me.cmbbxSection.Name = "cmbbxSection"
        Me.cmbbxSection.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxSection.Sorted = True
        Me.cmbbxSection.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(147, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Day:"
        '
        'txtbxDay
        '
        Me.txtbxDay.Enabled = False
        Me.txtbxDay.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDay.Location = New System.Drawing.Point(198, 190)
        Me.txtbxDay.Name = "txtbxDay"
        Me.txtbxDay.ReadOnly = True
        Me.txtbxDay.Size = New System.Drawing.Size(165, 26)
        Me.txtbxDay.TabIndex = 7
        '
        'txtbxRoom
        '
        Me.txtbxRoom.Enabled = False
        Me.txtbxRoom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRoom.Location = New System.Drawing.Point(198, 160)
        Me.txtbxRoom.Name = "txtbxRoom"
        Me.txtbxRoom.ReadOnly = True
        Me.txtbxRoom.Size = New System.Drawing.Size(165, 26)
        Me.txtbxRoom.TabIndex = 6
        '
        'wdwModFacultyDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 396)
        Me.Controls.Add(Me.txtbxRoom)
        Me.Controls.Add(Me.txtbxDay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbbxSection)
        Me.Controls.Add(Me.txtbxChecker)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.txtbxEnd)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbbxRemarks)
        Me.Controls.Add(Me.txtbxStart)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbbxCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.txtbxFacID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wdwModFacultyDaily"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Faculty Daily Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxFacID As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbbxCourse As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbxStart As TextBox
    Friend WithEvents cmbbxRemarks As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbxEnd As TextBox
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents txtbxChecker As TextBox
    Friend WithEvents cmbbxSection As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxDay As TextBox
    Friend WithEvents txtbxRoom As TextBox
End Class
