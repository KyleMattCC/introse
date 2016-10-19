<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwFacDailyAtt
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
        Me.txtFacID = New System.Windows.Forms.TextBox()
        Me.txtFacName = New System.Windows.Forms.TextBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bttnFind = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFacID
        '
        Me.txtFacID.Location = New System.Drawing.Point(205, 11)
        Me.txtFacID.Name = "txtFacID"
        Me.txtFacID.ReadOnly = True
        Me.txtFacID.Size = New System.Drawing.Size(282, 20)
        Me.txtFacID.TabIndex = 41
        '
        'txtFacName
        '
        Me.txtFacName.Location = New System.Drawing.Point(205, 34)
        Me.txtFacName.Name = "txtFacName"
        Me.txtFacName.ReadOnly = True
        Me.txtFacName.Size = New System.Drawing.Size(282, 20)
        Me.txtFacName.TabIndex = 40
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(205, 56)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(282, 20)
        Me.txtDept.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Faculty Name"
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(15, 89)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(558, 307)
        Me.grid.TabIndex = 36
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(129, 404)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(97, 23)
        Me.bttnAdd.TabIndex = 35
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Location = New System.Drawing.Point(243, 404)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(97, 23)
        Me.bttnModify.TabIndex = 34
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(361, 404)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(97, 23)
        Me.bttnDelete.TabIndex = 33
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Location = New System.Drawing.Point(476, 404)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(97, 23)
        Me.bttnBack.TabIndex = 32
        Me.bttnBack.Text = "Back To Menu"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Faculty ID   "
        '
        'bttnFind
        '
        Me.bttnFind.Location = New System.Drawing.Point(15, 404)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(97, 23)
        Me.bttnFind.TabIndex = 169
        Me.bttnFind.Text = "Find"
        Me.bttnFind.UseVisualStyleBackColor = True
        '
        'wdwFacDailyAtt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 439)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.txtFacID)
        Me.Controls.Add(Me.txtFacName)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.Label6)
        Me.Name = "wdwFacDailyAtt"
        Me.Text = "Faculty Daily Attendance"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFacID As TextBox
    Friend WithEvents txtFacName As TextBox
    Friend WithEvents txtDept As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents bttnFind As Button
End Class
