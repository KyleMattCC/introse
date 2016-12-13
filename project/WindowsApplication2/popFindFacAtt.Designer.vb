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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popFindFacAtt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.rbttnName = New System.Windows.Forms.RadioButton()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.rbttnID = New System.Windows.Forms.RadioButton()
        Me.txtFacID = New System.Windows.Forms.TextBox()
        Me.rbttnCourse = New System.Windows.Forms.RadioButton()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSearch = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(347, 305)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Attendance By:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(177, 60)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(151, 23)
        Me.txtFirstname.TabIndex = 62
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(17, 60)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(151, 23)
        Me.txtLastname.TabIndex = 61
        '
        'rbttnName
        '
        Me.rbttnName.AutoSize = True
        Me.rbttnName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnName.Location = New System.Drawing.Point(17, 32)
        Me.rbttnName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbttnName.Name = "rbttnName"
        Me.rbttnName.Size = New System.Drawing.Size(214, 24)
        Me.rbttnName.TabIndex = 60
        Me.rbttnName.Text = "Lastname / Firstname"
        Me.rbttnName.UseVisualStyleBackColor = True
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(124, 197)
        Me.txtSec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(65, 23)
        Me.txtSec.TabIndex = 59
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(15, 197)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 23)
        Me.txtCourse.TabIndex = 58
        '
        'rbttnID
        '
        Me.rbttnID.AutoSize = True
        Me.rbttnID.Checked = True
        Me.rbttnID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnID.Location = New System.Drawing.Point(15, 97)
        Me.rbttnID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbttnID.Name = "rbttnID"
        Me.rbttnID.Size = New System.Drawing.Size(116, 24)
        Me.rbttnID.TabIndex = 55
        Me.rbttnID.TabStop = True
        Me.rbttnID.Text = "Faculty ID"
        Me.rbttnID.UseVisualStyleBackColor = True
        '
        'txtFacID
        '
        Me.txtFacID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacID.Location = New System.Drawing.Point(15, 126)
        Me.txtFacID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.Size = New System.Drawing.Size(311, 23)
        Me.txtFacID.TabIndex = 57
        '
        'rbttnCourse
        '
        Me.rbttnCourse.AutoSize = True
        Me.rbttnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnCourse.Location = New System.Drawing.Point(15, 169)
        Me.rbttnCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbttnCourse.Name = "rbttnCourse"
        Me.rbttnCourse.Size = New System.Drawing.Size(159, 24)
        Me.rbttnCourse.TabIndex = 56
        Me.rbttnCourse.Text = "Course/Section"
        Me.rbttnCourse.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(179, 254)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(120, 28)
        Me.bttnCancel.TabIndex = 54
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(37, 254)
        Me.bttnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(120, 28)
        Me.bttnSearch.TabIndex = 48
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'popFindFacAtt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "popFindFacAtt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
