<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popFindFacAtt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.rbttnName = New System.Windows.Forms.RadioButton()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.rbttnID = New System.Windows.Forms.RadioButton()
        Me.txtFacID = New System.Windows.Forms.TextBox()
        Me.rbttnCourse = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.rbttnName)
        Me.GroupBox1.Controls.Add(Me.txtSec)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.rbttnID)
        Me.GroupBox1.Controls.Add(Me.txtFacID)
        Me.GroupBox1.Controls.Add(Me.rbttnCourse)
        Me.GroupBox1.Controls.Add(Me.bttnCancel)
        Me.GroupBox1.Controls.Add(Me.bttnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 248)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Attendance By:"
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(134, 206)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(90, 23)
        Me.bttnCancel.TabIndex = 54
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(28, 206)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(90, 23)
        Me.bttnSearch.TabIndex = 48
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(133, 49)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(114, 20)
        Me.txtFirstname.TabIndex = 62
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(13, 49)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(114, 20)
        Me.txtLastname.TabIndex = 61
        '
        'rbttnName
        '
        Me.rbttnName.AutoSize = True
        Me.rbttnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnName.Location = New System.Drawing.Point(13, 26)
        Me.rbttnName.Name = "rbttnName"
        Me.rbttnName.Size = New System.Drawing.Size(174, 20)
        Me.rbttnName.TabIndex = 60
        Me.rbttnName.Text = "Lastname / Firstname"
        Me.rbttnName.UseVisualStyleBackColor = True
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(93, 160)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(50, 20)
        Me.txtSec.TabIndex = 59
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(11, 160)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(76, 20)
        Me.txtCourse.TabIndex = 58
        '
        'rbttnID
        '
        Me.rbttnID.AutoSize = True
        Me.rbttnID.Checked = True
        Me.rbttnID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnID.Location = New System.Drawing.Point(11, 79)
        Me.rbttnID.Name = "rbttnID"
        Me.rbttnID.Size = New System.Drawing.Size(95, 20)
        Me.rbttnID.TabIndex = 55
        Me.rbttnID.TabStop = True
        Me.rbttnID.Text = "Faculty ID"
        Me.rbttnID.UseVisualStyleBackColor = True
        '
        'txtFacID
        '
        Me.txtFacID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacID.Location = New System.Drawing.Point(11, 102)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.Size = New System.Drawing.Size(234, 20)
        Me.txtFacID.TabIndex = 57
        '
        'rbttnCourse
        '
        Me.rbttnCourse.AutoSize = True
        Me.rbttnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnCourse.Location = New System.Drawing.Point(11, 137)
        Me.rbttnCourse.Name = "rbttnCourse"
        Me.rbttnCourse.Size = New System.Drawing.Size(132, 20)
        Me.rbttnCourse.TabIndex = 56
        Me.rbttnCourse.Text = "Course/Section"
        Me.rbttnCourse.UseVisualStyleBackColor = True
        '
        'popFindFacAtt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "popFindFacAtt"
        Me.Text = "Find Faculty Attendance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSearch As Button
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents rbttnName As RadioButton
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents rbttnID As RadioButton
    Friend WithEvents txtFacID As TextBox
    Friend WithEvents rbttnCourse As RadioButton
End Class
