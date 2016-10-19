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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEncoder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnFind = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(31, 73)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(558, 342)
        Me.grid.TabIndex = 47
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(146, 436)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(97, 23)
        Me.bttnAdd.TabIndex = 46
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Location = New System.Drawing.Point(266, 436)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(97, 23)
        Me.bttnModify.TabIndex = 45
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(380, 436)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(97, 23)
        Me.bttnDelete.TabIndex = 44
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Location = New System.Drawing.Point(492, 436)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(97, 23)
        Me.bttnBack.TabIndex = 43
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Encoder:"
        '
        'txtEncoder
        '
        Me.txtEncoder.Location = New System.Drawing.Point(392, 36)
        Me.txtEncoder.Name = "txtEncoder"
        Me.txtEncoder.Size = New System.Drawing.Size(197, 20)
        Me.txtEncoder.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Date:"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(83, 36)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(197, 20)
        Me.dtp.TabIndex = 161
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 162
        '
        'bttnFind
        '
        Me.bttnFind.Location = New System.Drawing.Point(31, 436)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(97, 23)
        Me.bttnFind.TabIndex = 164
        Me.bttnFind.Text = "Find"
        Me.bttnFind.UseVisualStyleBackColor = True
        '
        'wdwDailyAttendanceLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 471)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEncoder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Name = "wdwDailyAttendanceLog"
        Me.Text = "Daily Attendance Log"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEncoder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents bttnFind As Button
End Class
