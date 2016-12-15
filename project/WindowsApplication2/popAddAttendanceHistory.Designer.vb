<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popAddAttendanceHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popAddAttendanceHistory))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnAddClear = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.txtbxFacID = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.cmbbxSY = New System.Windows.Forms.ComboBox()
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.cmbbxCourse = New System.Windows.Forms.ComboBox()
        Me.cmbbxSection = New System.Windows.Forms.ComboBox()
        Me.txtbxRoom = New System.Windows.Forms.TextBox()
        Me.txtbxDay = New System.Windows.Forms.TextBox()
        Me.txtbxStart = New System.Windows.Forms.TextBox()
        Me.txtbxEnd = New System.Windows.Forms.TextBox()
        Me.cmbbxRemarks = New System.Windows.Forms.ComboBox()
        Me.txtbxChecker = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Faculty ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Faculty name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Absent date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Academic Year:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "Term:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Course:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Section:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "Room:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 227
        Me.Label6.Text = "Day:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 228
        Me.Label8.Text = "Start time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(101, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 229
        Me.Label9.Text = "End time:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 20)
        Me.Label12.TabIndex = 230
        Me.Label12.Text = "Remarks:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(107, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 231
        Me.Label13.Text = "Checker:"
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(65, 410)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(90, 30)
        Me.bttnAdd.TabIndex = 14
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnAddClear
        '
        Me.bttnAddClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddClear.Location = New System.Drawing.Point(207, 410)
        Me.bttnAddClear.Name = "bttnAddClear"
        Me.bttnAddClear.Size = New System.Drawing.Size(140, 30)
        Me.bttnAddClear.TabIndex = 15
        Me.bttnAddClear.Text = "Add and Clear"
        Me.bttnAddClear.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(397, 410)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 16
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'txtbxFacID
        '
        Me.txtbxFacID.Enabled = False
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
        Me.txtbxName.Size = New System.Drawing.Size(315, 26)
        Me.txtbxName.TabIndex = 2
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(198, 130)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(315, 26)
        Me.dtp.TabIndex = 5
        '
        'cmbbxSY
        '
        Me.cmbbxSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSY.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSY.FormattingEnabled = True
        Me.cmbbxSY.Location = New System.Drawing.Point(198, 70)
        Me.cmbbxSY.Name = "cmbbxSY"
        Me.cmbbxSY.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxSY.TabIndex = 3
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(198, 100)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxTerm.TabIndex = 4
        '
        'cmbbxCourse
        '
        Me.cmbbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxCourse.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxCourse.FormattingEnabled = True
        Me.cmbbxCourse.Location = New System.Drawing.Point(198, 160)
        Me.cmbbxCourse.Name = "cmbbxCourse"
        Me.cmbbxCourse.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxCourse.TabIndex = 6
        '
        'cmbbxSection
        '
        Me.cmbbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSection.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSection.FormattingEnabled = True
        Me.cmbbxSection.Location = New System.Drawing.Point(198, 190)
        Me.cmbbxSection.Name = "cmbbxSection"
        Me.cmbbxSection.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxSection.TabIndex = 7
        '
        'txtbxRoom
        '
        Me.txtbxRoom.Enabled = False
        Me.txtbxRoom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRoom.Location = New System.Drawing.Point(198, 221)
        Me.txtbxRoom.Name = "txtbxRoom"
        Me.txtbxRoom.Size = New System.Drawing.Size(165, 26)
        Me.txtbxRoom.TabIndex = 8
        '
        'txtbxDay
        '
        Me.txtbxDay.Enabled = False
        Me.txtbxDay.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDay.Location = New System.Drawing.Point(198, 251)
        Me.txtbxDay.Name = "txtbxDay"
        Me.txtbxDay.Size = New System.Drawing.Size(165, 26)
        Me.txtbxDay.TabIndex = 9
        '
        'txtbxStart
        '
        Me.txtbxStart.Enabled = False
        Me.txtbxStart.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStart.Location = New System.Drawing.Point(198, 281)
        Me.txtbxStart.Name = "txtbxStart"
        Me.txtbxStart.Size = New System.Drawing.Size(165, 26)
        Me.txtbxStart.TabIndex = 10
        '
        'txtbxEnd
        '
        Me.txtbxEnd.Enabled = False
        Me.txtbxEnd.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnd.Location = New System.Drawing.Point(198, 310)
        Me.txtbxEnd.Name = "txtbxEnd"
        Me.txtbxEnd.Size = New System.Drawing.Size(165, 26)
        Me.txtbxEnd.TabIndex = 11
        '
        'cmbbxRemarks
        '
        Me.cmbbxRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxRemarks.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxRemarks.FormattingEnabled = True
        Me.cmbbxRemarks.Location = New System.Drawing.Point(198, 340)
        Me.cmbbxRemarks.Name = "cmbbxRemarks"
        Me.cmbbxRemarks.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxRemarks.TabIndex = 12
        '
        'txtbxChecker
        '
        Me.txtbxChecker.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxChecker.Location = New System.Drawing.Point(198, 370)
        Me.txtbxChecker.Name = "txtbxChecker"
        Me.txtbxChecker.Size = New System.Drawing.Size(165, 26)
        Me.txtbxChecker.TabIndex = 13
        '
        'popAddAttendanceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 453)
        Me.Controls.Add(Me.txtbxChecker)
        Me.Controls.Add(Me.cmbbxRemarks)
        Me.Controls.Add(Me.txtbxEnd)
        Me.Controls.Add(Me.txtbxStart)
        Me.Controls.Add(Me.txtbxDay)
        Me.Controls.Add(Me.txtbxRoom)
        Me.Controls.Add(Me.cmbbxSection)
        Me.Controls.Add(Me.cmbbxCourse)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.cmbbxSY)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.txtbxFacID)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnAddClear)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "popAddAttendanceHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Attendance History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnAddClear As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents txtbxFacID As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents cmbbxSY As ComboBox
    Friend WithEvents cmbbxTerm As ComboBox
    Friend WithEvents cmbbxCourse As ComboBox
    Friend WithEvents cmbbxSection As ComboBox
    Friend WithEvents txtbxRoom As TextBox
    Friend WithEvents txtbxDay As TextBox
    Friend WithEvents txtbxStart As TextBox
    Friend WithEvents txtbxEnd As TextBox
    Friend WithEvents cmbbxRemarks As ComboBox
    Friend WithEvents txtbxChecker As TextBox
End Class
