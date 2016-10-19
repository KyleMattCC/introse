<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwFacultyMakeUp
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
        Me.components = New System.ComponentModel.Container()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bttnFind = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'bttnBack
        '
        Me.bttnBack.Location = New System.Drawing.Point(580, 343)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(117, 23)
        Me.bttnBack.TabIndex = 20
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(443, 343)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(117, 23)
        Me.bttnDelete.TabIndex = 21
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnModify
        '
        Me.bttnModify.Location = New System.Drawing.Point(297, 343)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(117, 23)
        Me.bttnModify.TabIndex = 22
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = True
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(154, 343)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(117, 23)
        Me.bttnAdd.TabIndex = 23
        Me.bttnAdd.Text = "Add"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(685, 313)
        Me.DataGridView1.TabIndex = 24
        '
        'bttnFind
        '
        Me.bttnFind.Location = New System.Drawing.Point(12, 343)
        Me.bttnFind.Name = "bttnFind"
        Me.bttnFind.Size = New System.Drawing.Size(117, 23)
        Me.bttnFind.TabIndex = 31
        Me.bttnFind.Text = "Find"
        Me.bttnFind.UseVisualStyleBackColor = True
        '
        'wdwFacultyMakeUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 381)
        Me.Controls.Add(Me.bttnFind)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnBack)
        Me.Name = "wdwFacultyMakeUp"
        Me.Text = "Faculty Makeup Schedule"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bttnFind As Button
End Class
