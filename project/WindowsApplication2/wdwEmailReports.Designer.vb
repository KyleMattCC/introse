<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwEmailReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwEmailReports))
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnSend = New System.Windows.Forms.Button()
        Me.txtbxSubject = New System.Windows.Forms.TextBox()
        Me.txtbxTo = New System.Windows.Forms.TextBox()
        Me.txtbxBody = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'bttnCancel
        '
        Me.bttnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(324, 470)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(120, 37)
        Me.bttnCancel.TabIndex = 36
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Subject:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "To:"
        '
        'bttnSend
        '
        Me.bttnSend.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnSend.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSend.Location = New System.Drawing.Point(135, 470)
        Me.bttnSend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnSend.Name = "bttnSend"
        Me.bttnSend.Size = New System.Drawing.Size(120, 37)
        Me.bttnSend.TabIndex = 33
        Me.bttnSend.Text = "Send"
        Me.bttnSend.UseVisualStyleBackColor = False
        '
        'txtbxSubject
        '
        Me.txtbxSubject.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSubject.Location = New System.Drawing.Point(135, 55)
        Me.txtbxSubject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxSubject.Name = "txtbxSubject"
        Me.txtbxSubject.Size = New System.Drawing.Size(419, 31)
        Me.txtbxSubject.TabIndex = 2
        '
        'txtbxTo
        '
        Me.txtbxTo.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTo.Location = New System.Drawing.Point(135, 15)
        Me.txtbxTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxTo.Name = "txtbxTo"
        Me.txtbxTo.Size = New System.Drawing.Size(419, 31)
        Me.txtbxTo.TabIndex = 1
        '
        'txtbxBody
        '
        Me.txtbxBody.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxBody.Location = New System.Drawing.Point(16, 101)
        Me.txtbxBody.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbxBody.Name = "txtbxBody"
        Me.txtbxBody.Size = New System.Drawing.Size(537, 361)
        Me.txtbxBody.TabIndex = 3
        Me.txtbxBody.Text = ""
        '
        'wdwEmailReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(571, 517)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnSend)
        Me.Controls.Add(Me.txtbxBody)
        Me.Controls.Add(Me.txtbxSubject)
        Me.Controls.Add(Me.txtbxTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wdwEmailReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnSend As Button
    Friend WithEvents txtbxSubject As TextBox
    Friend WithEvents txtbxTo As TextBox
    Friend WithEvents txtbxBody As RichTextBox
End Class
