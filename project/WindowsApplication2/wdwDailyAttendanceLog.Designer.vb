﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwDailyAttendanceLog))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtbxDept = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxFacID = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
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
        Me.grid.TabIndex = 47
        '
        'bttnAdd
        '
        Me.bttnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAdd.Location = New System.Drawing.Point(52, 612)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(204, 40)
        Me.bttnAdd.TabIndex = 46
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = False
        '
        'bttnModify
        '
        Me.bttnModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(391, 612)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(204, 40)
        Me.bttnModify.TabIndex = 45
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = False
        '
        'bttnDelete
        '
        Me.bttnDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(729, 612)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(204, 40)
        Me.bttnDelete.TabIndex = 44
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = False
        '
        'bttnBack
        '
        Me.bttnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(1067, 612)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(204, 40)
        Me.bttnBack.TabIndex = 43
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Date:"
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Location = New System.Drawing.Point(86, 17)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(300, 26)
        Me.dtp.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, -9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 162
        '
        'bttnClear
        '
        Me.bttnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(1189, 16)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(105, 29)
        Me.bttnClear.TabIndex = 11
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = False
        '
        'bttnSearch
        '
        Me.bttnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(1078, 16)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(105, 29)
        Me.bttnSearch.TabIndex = 1
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = False
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSearch.Location = New System.Drawing.Point(722, 17)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(350, 26)
        Me.txtbxSearch.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtbxDept)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtbxFacID)
        Me.GroupBox4.Controls.Add(Me.txtbxName)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(29, 50)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(653, 127)
        Me.GroupBox4.TabIndex = 172
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Faculty Information:"
        '
        'txtbxDept
        '
        Me.txtbxDept.AcceptsTab = True
        Me.txtbxDept.Enabled = False
        Me.txtbxDept.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDept.Location = New System.Drawing.Point(216, 85)
        Me.txtbxDept.Name = "txtbxDept"
        Me.txtbxDept.Size = New System.Drawing.Size(350, 26)
        Me.txtbxDept.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Department:"
        '
        'txtbxFacID
        '
        Me.txtbxFacID.Enabled = False
        Me.txtbxFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacID.Location = New System.Drawing.Point(216, 25)
        Me.txtbxFacID.Name = "txtbxFacID"
        Me.txtbxFacID.Size = New System.Drawing.Size(350, 26)
        Me.txtbxFacID.TabIndex = 3
        '
        'txtbxName
        '
        Me.txtbxName.Enabled = False
        Me.txtbxName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxName.Location = New System.Drawing.Point(216, 55)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(350, 26)
        Me.txtbxName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Faculty Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(108, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "Faculty ID:"
        '
        'wdwDailyAttendanceLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1323, 670)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.bttnSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(189, 25)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wdwDailyAttendanceLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
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
    Friend WithEvents bttnClear As Button
    Friend WithEvents bttnSearch As Button
    Friend WithEvents txtbxSearch As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtbxDept As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxFacID As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
