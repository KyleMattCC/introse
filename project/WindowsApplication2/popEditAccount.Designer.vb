<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popEditAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popEditAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxUser = New System.Windows.Forms.TextBox()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.bttnChange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username:"
        '
        'txtbxName
        '
        Me.txtbxName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxName.Location = New System.Drawing.Point(133, 59)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(315, 26)
        Me.txtbxName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password:"
        '
        'txtbxPass
        '
        Me.txtbxPass.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPass.Location = New System.Drawing.Point(133, 133)
        Me.txtbxPass.Name = "txtbxPass"
        Me.txtbxPass.Size = New System.Drawing.Size(315, 26)
        Me.txtbxPass.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Name:"
        '
        'txtbxUser
        '
        Me.txtbxUser.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUser.Location = New System.Drawing.Point(133, 94)
        Me.txtbxUser.Name = "txtbxUser"
        Me.txtbxUser.Size = New System.Drawing.Size(315, 26)
        Me.txtbxUser.TabIndex = 2
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(260, 220)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 17
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'bttnChange
        '
        Me.bttnChange.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnChange.Location = New System.Drawing.Point(133, 220)
        Me.bttnChange.Name = "bttnChange"
        Me.bttnChange.Size = New System.Drawing.Size(90, 30)
        Me.bttnChange.TabIndex = 18
        Me.bttnChange.Text = "Change"
        Me.bttnChange.UseVisualStyleBackColor = True
        '
        'popEditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 306)
        Me.Controls.Add(Me.bttnChange)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.txtbxUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "popEditAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxUser As TextBox
    Friend WithEvents bttnBack As Button
    Friend WithEvents bttnChange As Button
End Class
