﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popAddAccount))
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnAddAccount = New System.Windows.Forms.Button()
        Me.txtbxAddPass = New System.Windows.Forms.TextBox()
        Me.txtbxAddUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxAddName = New System.Windows.Forms.TextBox()
        Me.rbttnLeadStaff = New System.Windows.Forms.RadioButton()
        Me.rbttnRegStaff = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnClear
        '
        Me.bttnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(171, 306)
        Me.bttnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(120, 37)
        Me.bttnClear.TabIndex = 11
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = False
        '
        'bttnAddAccount
        '
        Me.bttnAddAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnAddAccount.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAddAccount.Location = New System.Drawing.Point(43, 306)
        Me.bttnAddAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnAddAccount.Name = "bttnAddAccount"
        Me.bttnAddAccount.Size = New System.Drawing.Size(120, 37)
        Me.bttnAddAccount.TabIndex = 10
        Me.bttnAddAccount.Text = "Add"
        Me.bttnAddAccount.UseVisualStyleBackColor = False
        '
        'txtbxAddPass
        '
        Me.txtbxAddPass.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddPass.Location = New System.Drawing.Point(188, 126)
        Me.txtbxAddPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAddPass.Name = "txtbxAddPass"
        Me.txtbxAddPass.Size = New System.Drawing.Size(229, 31)
        Me.txtbxAddPass.TabIndex = 3
        '
        'txtbxAddUser
        '
        Me.txtbxAddUser.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddUser.Location = New System.Drawing.Point(188, 86)
        Me.txtbxAddUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAddUser.Name = "txtbxAddUser"
        Me.txtbxAddUser.Size = New System.Drawing.Size(229, 31)
        Me.txtbxAddUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        '
        'bttnBack
        '
        Me.bttnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(299, 306)
        Me.bttnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(120, 37)
        Me.bttnBack.TabIndex = 12
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Name:"
        '
        'txtbxAddName
        '
        Me.txtbxAddName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddName.Location = New System.Drawing.Point(188, 47)
        Me.txtbxAddName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAddName.Name = "txtbxAddName"
        Me.txtbxAddName.Size = New System.Drawing.Size(229, 31)
        Me.txtbxAddName.TabIndex = 1
        '
        'rbttnLeadStaff
        '
        Me.rbttnLeadStaff.AutoSize = True
        Me.rbttnLeadStaff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnLeadStaff.Location = New System.Drawing.Point(205, 46)
        Me.rbttnLeadStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnLeadStaff.Name = "rbttnLeadStaff"
        Me.rbttnLeadStaff.Size = New System.Drawing.Size(126, 24)
        Me.rbttnLeadStaff.TabIndex = 15
        Me.rbttnLeadStaff.TabStop = True
        Me.rbttnLeadStaff.Text = "Lead Staff"
        Me.rbttnLeadStaff.UseVisualStyleBackColor = True
        '
        'rbttnRegStaff
        '
        Me.rbttnRegStaff.AutoSize = True
        Me.rbttnRegStaff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnRegStaff.Location = New System.Drawing.Point(25, 46)
        Me.rbttnRegStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnRegStaff.Name = "rbttnRegStaff"
        Me.rbttnRegStaff.Size = New System.Drawing.Size(154, 24)
        Me.rbttnRegStaff.TabIndex = 16
        Me.rbttnRegStaff.TabStop = True
        Me.rbttnRegStaff.Text = "Regular Staff"
        Me.rbttnRegStaff.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbttnRegStaff)
        Me.GroupBox1.Controls.Add(Me.rbttnLeadStaff)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 186)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(363, 94)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of User"
        '
        'popAddAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 370)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbxAddName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.bttnAddAccount)
        Me.Controls.Add(Me.txtbxAddPass)
        Me.Controls.Add(Me.txtbxAddUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "popAddAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxAddName As TextBox
    Friend WithEvents rbttnLeadStaff As RadioButton
    Friend WithEvents rbttnRegStaff As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
