<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class popAddAccount
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
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnAddAccount = New System.Windows.Forms.Button()
        Me.txtbxAddPass = New System.Windows.Forms.TextBox()
        Me.txtbxAddUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnClear
        '
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(146, 113)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(73, 44)
        Me.bttnClear.TabIndex = 11
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = True
        '
        'bttnAddAccount
        '
        Me.bttnAddAccount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAccount.Location = New System.Drawing.Point(225, 113)
        Me.bttnAddAccount.Name = "bttnAddAccount"
        Me.bttnAddAccount.Size = New System.Drawing.Size(73, 44)
        Me.bttnAddAccount.TabIndex = 10
        Me.bttnAddAccount.Text = "Add"
        Me.bttnAddAccount.UseVisualStyleBackColor = True
        '
        'txtbxAddPass
        '
        Me.txtbxAddPass.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddPass.Location = New System.Drawing.Point(125, 70)
        Me.txtbxAddPass.Name = "txtbxAddPass"
        Me.txtbxAddPass.Size = New System.Drawing.Size(173, 26)
        Me.txtbxAddPass.TabIndex = 9
        '
        'txtbxAddUser
        '
        Me.txtbxAddUser.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddUser.Location = New System.Drawing.Point(125, 38)
        Me.txtbxAddUser.Name = "txtbxAddUser"
        Me.txtbxAddUser.Size = New System.Drawing.Size(173, 26)
        Me.txtbxAddUser.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(67, 113)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(73, 44)
        Me.bttnBack.TabIndex = 12
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'popAddAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 212)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.bttnAddAccount)
        Me.Controls.Add(Me.txtbxAddPass)
        Me.Controls.Add(Me.txtbxAddUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "popAddAccount"
        Me.Text = "Add Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnClear As Button
    Friend WithEvents bttnAddAccount As Button
    Friend WithEvents txtbxAddPass As TextBox
    Friend WithEvents txtbxAddUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnBack As Button
End Class
