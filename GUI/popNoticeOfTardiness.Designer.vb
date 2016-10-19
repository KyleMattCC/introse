<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popNoticeOfTardiness
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.RadID = New System.Windows.Forms.RadioButton()
        Me.RadNoEmail = New System.Windows.Forms.RadioButton()
        Me.RadAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 118)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(137, 118)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.RadID)
        Me.GroupBox1.Controls.Add(Me.RadNoEmail)
        Me.GroupBox1.Controls.Add(Me.RadAll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report by"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(85, 62)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'RadID
        '
        Me.RadID.AutoSize = True
        Me.RadID.Location = New System.Drawing.Point(6, 65)
        Me.RadID.Name = "RadID"
        Me.RadID.Size = New System.Drawing.Size(73, 17)
        Me.RadID.TabIndex = 1
        Me.RadID.TabStop = True
        Me.RadID.Text = "Faculty ID"
        Me.RadID.UseVisualStyleBackColor = True
        '
        'RadNoEmail
        '
        Me.RadNoEmail.AutoSize = True
        Me.RadNoEmail.Location = New System.Drawing.Point(6, 42)
        Me.RadNoEmail.Name = "RadNoEmail"
        Me.RadNoEmail.Size = New System.Drawing.Size(174, 17)
        Me.RadNoEmail.TabIndex = 1
        Me.RadNoEmail.TabStop = True
        Me.RadNoEmail.Text = "Faculty with no email addresses"
        Me.RadNoEmail.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Location = New System.Drawing.Point(6, 19)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(36, 17)
        Me.RadAll.TabIndex = 1
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'popNoticeOfTardiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 156)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "popNoticeOfTardiness"
        Me.Text = "popNoticeOfTardiness"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents RadID As RadioButton
    Friend WithEvents RadNoEmail As RadioButton
    Friend WithEvents RadAll As RadioButton
End Class
