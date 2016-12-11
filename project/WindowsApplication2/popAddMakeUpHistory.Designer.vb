<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popAddMakeUpHistory
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxFacID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxFacName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbbxSY = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnAddClear = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.cmbbxCourse = New System.Windows.Forms.ComboBox()
        Me.cmbbxSec = New System.Windows.Forms.ComboBox()
        Me.txtbxRoom = New System.Windows.Forms.TextBox()
        Me.txtbxStart = New System.Windows.Forms.TextBox()
        Me.txtbxEnd = New System.Windows.Forms.TextBox()
        Me.cmbbxReason = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(110, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Faculty ID:"
        '
        'txtbxFacID
        '
        Me.txtbxFacID.Enabled = False
        Me.txtbxFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacID.Location = New System.Drawing.Point(216, 10)
        Me.txtbxFacID.Name = "txtbxFacID"
        Me.txtbxFacID.Size = New System.Drawing.Size(165, 26)
        Me.txtbxFacID.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(81, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Faculty name:"
        '
        'txtbxFacName
        '
        Me.txtbxFacName.Enabled = False
        Me.txtbxFacName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacName.Location = New System.Drawing.Point(216, 40)
        Me.txtbxFacName.Name = "txtbxFacName"
        Me.txtbxFacName.ReadOnly = True
        Me.txtbxFacName.Size = New System.Drawing.Size(313, 26)
        Me.txtbxFacName.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(84, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Makeup date:"
        '
        'dtp
        '
        Me.dtp.CalendarFont = New System.Drawing.Font("Goudy Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(216, 130)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(313, 26)
        Me.dtp.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Academic Year:"
        '
        'cmbbxSY
        '
        Me.cmbbxSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSY.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSY.FormattingEnabled = True
        Me.cmbbxSY.Location = New System.Drawing.Point(216, 70)
        Me.cmbbxSY.Name = "cmbbxSY"
        Me.cmbbxSY.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxSY.TabIndex = 239
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(151, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 240
        Me.Label10.Text = "Term:"
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(216, 100)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxTerm.TabIndex = 241
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(135, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Course:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(132, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 243
        Me.Label11.Text = "Section:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(148, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 244
        Me.Label7.Text = "Room:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(109, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 245
        Me.Label13.Text = "Start time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(119, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 246
        Me.Label9.Text = "End time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 247
        Me.Label2.Text = "Reason for absence:"
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(65, 350)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(90, 30)
        Me.bttnAdd.TabIndex = 248
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnAddClear
        '
        Me.bttnAddClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddClear.Location = New System.Drawing.Point(207, 350)
        Me.bttnAddClear.Name = "bttnAddClear"
        Me.bttnAddClear.Size = New System.Drawing.Size(140, 30)
        Me.bttnAddClear.TabIndex = 249
        Me.bttnAddClear.Text = "Add and Clear"
        Me.bttnAddClear.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(397, 350)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 250
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'cmbbxCourse
        '
        Me.cmbbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxCourse.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxCourse.FormattingEnabled = True
        Me.cmbbxCourse.Location = New System.Drawing.Point(216, 160)
        Me.cmbbxCourse.Name = "cmbbxCourse"
        Me.cmbbxCourse.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxCourse.TabIndex = 251
        '
        'cmbbxSec
        '
        Me.cmbbxSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxSec.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxSec.FormattingEnabled = True
        Me.cmbbxSec.Location = New System.Drawing.Point(216, 190)
        Me.cmbbxSec.Name = "cmbbxSec"
        Me.cmbbxSec.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxSec.TabIndex = 252
        '
        'txtbxRoom
        '
        Me.txtbxRoom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRoom.Location = New System.Drawing.Point(216, 220)
        Me.txtbxRoom.Name = "txtbxRoom"
        Me.txtbxRoom.Size = New System.Drawing.Size(165, 26)
        Me.txtbxRoom.TabIndex = 253
        '
        'txtbxStart
        '
        Me.txtbxStart.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStart.Location = New System.Drawing.Point(216, 250)
        Me.txtbxStart.Name = "txtbxStart"
        Me.txtbxStart.Size = New System.Drawing.Size(165, 26)
        Me.txtbxStart.TabIndex = 254
        '
        'txtbxEnd
        '
        Me.txtbxEnd.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEnd.Location = New System.Drawing.Point(216, 280)
        Me.txtbxEnd.Name = "txtbxEnd"
        Me.txtbxEnd.Size = New System.Drawing.Size(165, 26)
        Me.txtbxEnd.TabIndex = 255
        '
        'cmbbxReason
        '
        Me.cmbbxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxReason.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxReason.FormattingEnabled = True
        Me.cmbbxReason.Location = New System.Drawing.Point(216, 310)
        Me.cmbbxReason.Name = "cmbbxReason"
        Me.cmbbxReason.Size = New System.Drawing.Size(313, 28)
        Me.cmbbxReason.TabIndex = 256
        '
        'popAddMakeUpHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 386)
        Me.Controls.Add(Me.cmbbxReason)
        Me.Controls.Add(Me.txtbxEnd)
        Me.Controls.Add(Me.txtbxStart)
        Me.Controls.Add(Me.txtbxRoom)
        Me.Controls.Add(Me.cmbbxSec)
        Me.Controls.Add(Me.cmbbxCourse)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnAddClear)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbbxSY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbxFacName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxFacID)
        Me.Controls.Add(Me.Label5)
        Me.Name = "popAddMakeUpHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Make-Up History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxFacID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxFacName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbbxSY As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbbxTerm As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnAddClear As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents cmbbxCourse As ComboBox
    Friend WithEvents cmbbxSec As ComboBox
    Friend WithEvents txtbxRoom As TextBox
    Friend WithEvents txtbxStart As TextBox
    Friend WithEvents txtbxEnd As TextBox
    Friend WithEvents cmbbxReason As ComboBox
End Class
