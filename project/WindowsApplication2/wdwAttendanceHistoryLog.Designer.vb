<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwAttendanceHistoryLog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwAttendanceHistoryLog))
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.BttnAttendance = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtbxFacID = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BttnMakeup = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(29, 612)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(204, 40)
        Me.bttnSearch.TabIndex = 175
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.grid.Location = New System.Drawing.Point(29, 192)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 45
        Me.grid.RowTemplate.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1266, 404)
        Me.grid.TabIndex = 177
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(283, 612)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(204, 40)
        Me.bttnAdd.TabIndex = 178
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(551, 612)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(204, 40)
        Me.bttnModify.TabIndex = 179
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(823, 612)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(204, 40)
        Me.bttnDelete.TabIndex = 180
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(1091, 612)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(204, 40)
        Me.bttnBack.TabIndex = 181
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'BttnAttendance
        '
        Me.BttnAttendance.Enabled = False
        Me.BttnAttendance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnAttendance.Location = New System.Drawing.Point(391, 142)
        Me.BttnAttendance.Name = "BttnAttendance"
        Me.BttnAttendance.Size = New System.Drawing.Size(204, 40)
        Me.BttnAttendance.TabIndex = 182
        Me.BttnAttendance.Text = "Attendance"
        Me.BttnAttendance.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtbxFacID)
        Me.GroupBox4.Controls.Add(Me.txtbxName)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(29, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(653, 127)
        Me.GroupBox4.TabIndex = 183
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Faculty Information:"
        '
        'txtbxFacID
        '
        Me.txtbxFacID.Enabled = False
        Me.txtbxFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacID.Location = New System.Drawing.Point(216, 36)
        Me.txtbxFacID.Name = "txtbxFacID"
        Me.txtbxFacID.Size = New System.Drawing.Size(350, 26)
        Me.txtbxFacID.TabIndex = 175
        '
        'txtbxName
        '
        Me.txtbxName.Enabled = False
        Me.txtbxName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxName.Location = New System.Drawing.Point(216, 82)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(350, 26)
        Me.txtbxName.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Faculty Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(108, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "Faculty ID:"
        '
        'BttnMakeup
        '
        Me.BttnMakeup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnMakeup.Location = New System.Drawing.Point(776, 142)
        Me.BttnMakeup.Name = "BttnMakeup"
        Me.BttnMakeup.Size = New System.Drawing.Size(204, 40)
        Me.BttnMakeup.TabIndex = 184
        Me.BttnMakeup.Text = "Make-Up Class"
        Me.BttnMakeup.UseVisualStyleBackColor = True
        '
        'wdwAttendanceHistoryLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 668)
        Me.Controls.Add(Me.BttnMakeup)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BttnAttendance)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bttnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wdwAttendanceHistoryLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance History Log"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnSearch As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents BttnAttendance As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtbxFacID As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BttnMakeup As Button
End Class
