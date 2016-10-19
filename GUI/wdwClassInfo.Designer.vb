<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwClassInfo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.bttnFind = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faculty ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Faculty Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(159, 22)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(429, 20)
        Me.txtID.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(159, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(429, 20)
        Me.txtName.TabIndex = 5
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(30, 120)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(558, 307)
        Me.grid.TabIndex = 158
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(159, 82)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(429, 20)
        Me.txtDept.TabIndex = 161
        '
        'bttnFind
        '
        Me.bttnFind.Location = New System.Drawing.Point(35, 444)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(97, 23)
        Me.bttnFind.TabIndex = 169
        Me.bttnFind.Text = "Find"
        Me.bttnFind.UseVisualStyleBackColor = True
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(153, 444)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(97, 23)
        Me.bttnAdd.TabIndex = 168
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Location = New System.Drawing.Point(267, 444)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(97, 23)
        Me.bttnModify.TabIndex = 167
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(378, 444)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(97, 23)
        Me.bttnDelete.TabIndex = 166
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Location = New System.Drawing.Point(488, 444)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(97, 23)
        Me.bttnBack.TabIndex = 165
        Me.bttnBack.Text = "Back to Menu"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'wdwClassInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 485)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wdwClassInfo"
        Me.Text = "Class Info"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtDept As TextBox
    Friend WithEvents bttnFind As Button
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
End Class
