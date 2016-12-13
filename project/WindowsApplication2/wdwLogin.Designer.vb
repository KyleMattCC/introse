<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxUser = New System.Windows.Forms.TextBox()
        Me.txtbxPass = New System.Windows.Forms.TextBox()
        Me.bttnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(190, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtbxUser
        '
        Me.txtbxUser.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUser.Location = New System.Drawing.Point(190, 197)
        Me.txtbxUser.Name = "txtbxUser"
        Me.txtbxUser.Size = New System.Drawing.Size(350, 27)
        Me.txtbxUser.TabIndex = 2
        '
        'txtbxPass
        '
        Me.txtbxPass.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPass.Location = New System.Drawing.Point(190, 258)
        Me.txtbxPass.Name = "txtbxPass"
        Me.txtbxPass.Size = New System.Drawing.Size(350, 27)
        Me.txtbxPass.TabIndex = 3
        '
        'bttnLogin
        '
        Me.bttnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.bttnLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLogin.ForeColor = System.Drawing.Color.White
        Me.bttnLogin.Location = New System.Drawing.Point(373, 301)
        Me.bttnLogin.Name = "bttnLogin"
        Me.bttnLogin.Size = New System.Drawing.Size(166, 44)
        Me.bttnLogin.TabIndex = 4
        Me.bttnLogin.Text = "login"
        Me.bttnLogin.UseVisualStyleBackColor = False
        '
        'wdwLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 418)
        Me.Controls.Add(Me.bttnLogin)
        Me.Controls.Add(Me.txtbxPass)
        Me.Controls.Add(Me.txtbxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wdwLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxUser As TextBox
    Friend WithEvents txtbxPass As TextBox
    Friend WithEvents bttnLogin As Button
End Class
