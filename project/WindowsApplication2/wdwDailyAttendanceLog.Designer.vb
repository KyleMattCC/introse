<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwDailyAttendanceLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.FacultyIDSearchText = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DepartmentNameText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FacultyIDText = New System.Windows.Forms.TextBox()
        Me.FacultyNameText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(25, 170)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1085, 350)
        Me.grid.TabIndex = 47
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(45, 530)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(175, 35)
        Me.bttnAdd.TabIndex = 46
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(335, 530)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(175, 35)
        Me.bttnModify.TabIndex = 45
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(625, 530)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(175, 35)
        Me.bttnDelete.TabIndex = 44
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(915, 530)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(175, 35)
        Me.bttnBack.TabIndex = 43
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Date:"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(79, 17)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 20)
        Me.dtp.TabIndex = 161
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, -8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 162
        '
        'bttnCancel
        '
        Me.bttnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(1020, 12)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(90, 25)
        Me.bttnCancel.TabIndex = 11
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(924, 12)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(90, 25)
        Me.bttnSearch.TabIndex = 1
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'FacultyIDSearchText
        '
        Me.FacultyIDSearchText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyIDSearchText.Location = New System.Drawing.Point(658, 15)
        Me.FacultyIDSearchText.Name = "FacultyIDSearchText"
        Me.FacultyIDSearchText.Size = New System.Drawing.Size(260, 20)
        Me.FacultyIDSearchText.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DepartmentNameText)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.FacultyIDText)
        Me.GroupBox4.Controls.Add(Me.FacultyNameText)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 110)
        Me.GroupBox4.TabIndex = 172
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Faculty Information:"
        '
        'DepartmentNameText
        '
        Me.DepartmentNameText.Enabled = False
        Me.DepartmentNameText.Location = New System.Drawing.Point(185, 66)
        Me.DepartmentNameText.Name = "DepartmentNameText"
        Me.DepartmentNameText.Size = New System.Drawing.Size(300, 21)
        Me.DepartmentNameText.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Department:"
        '
        'FacultyIDText
        '
        Me.FacultyIDText.Enabled = False
        Me.FacultyIDText.Location = New System.Drawing.Point(185, 20)
        Me.FacultyIDText.Name = "FacultyIDText"
        Me.FacultyIDText.Size = New System.Drawing.Size(300, 21)
        Me.FacultyIDText.TabIndex = 175
        '
        'FacultyNameText
        '
        Me.FacultyNameText.Enabled = False
        Me.FacultyNameText.Location = New System.Drawing.Point(185, 43)
        Me.FacultyNameText.Name = "FacultyNameText"
        Me.FacultyNameText.Size = New System.Drawing.Size(300, 21)
        Me.FacultyNameText.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Faculty Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "Faculty ID:"
        '
        'wdwDailyAttendanceLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 581)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.bttnSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.FacultyIDSearchText)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Name = "wdwDailyAttendanceLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Attendance Log"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnSearch As Button
    Friend WithEvents FacultyIDSearchText As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DepartmentNameText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FacultyIDText As TextBox
    Friend WithEvents FacultyNameText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
