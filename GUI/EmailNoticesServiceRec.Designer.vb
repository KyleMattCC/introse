<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailNoticesServiceRec
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.btnCancer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "To "
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(37, 369)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(37, 69)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(380, 294)
        Me.RichTextBox1.TabIndex = 25
        Me.RichTextBox1.Text = ""
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(112, 43)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(295, 20)
        Me.txtSubject.TabIndex = 24
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(112, 4)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(295, 20)
        Me.txtTo.TabIndex = 23
        '
        'btnCancer
        '
        Me.btnCancer.Location = New System.Drawing.Point(342, 369)
        Me.btnCancer.Name = "btnCancer"
        Me.btnCancer.Size = New System.Drawing.Size(75, 23)
        Me.btnCancer.TabIndex = 29
        Me.btnCancer.Text = "Cancel"
        Me.btnCancer.UseVisualStyleBackColor = True
        '
        'EmailNoticesServiceRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 410)
        Me.Controls.Add(Me.btnCancer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Name = "EmailNoticesServiceRec"
        Me.Text = "EmailNotices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents btnCancer As Button
End Class
