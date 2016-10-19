<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwNotices
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadService = New System.Windows.Forms.RadioButton()
        Me.RadTardiness = New System.Windows.Forms.RadioButton()
        Me.RadAbsence = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadService)
        Me.GroupBox1.Controls.Add(Me.RadTardiness)
        Me.GroupBox1.Controls.Add(Me.RadAbsence)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'RadService
        '
        Me.RadService.AutoSize = True
        Me.RadService.Location = New System.Drawing.Point(6, 65)
        Me.RadService.Name = "RadService"
        Me.RadService.Size = New System.Drawing.Size(96, 17)
        Me.RadService.TabIndex = 1
        Me.RadService.TabStop = True
        Me.RadService.Text = "Service Report"
        Me.RadService.UseVisualStyleBackColor = True
        '
        'RadTardiness
        '
        Me.RadTardiness.AutoSize = True
        Me.RadTardiness.Location = New System.Drawing.Point(6, 42)
        Me.RadTardiness.Name = "RadTardiness"
        Me.RadTardiness.Size = New System.Drawing.Size(117, 17)
        Me.RadTardiness.TabIndex = 1
        Me.RadTardiness.TabStop = True
        Me.RadTardiness.Text = "Notice of Tardiness"
        Me.RadTardiness.UseVisualStyleBackColor = True
        '
        'RadAbsence
        '
        Me.RadAbsence.AutoSize = True
        Me.RadAbsence.Location = New System.Drawing.Point(6, 19)
        Me.RadAbsence.Name = "RadAbsence"
        Me.RadAbsence.Size = New System.Drawing.Size(113, 17)
        Me.RadAbsence.TabIndex = 1
        Me.RadAbsence.TabStop = True
        Me.RadAbsence.Text = "Notice of Absence"
        Me.RadAbsence.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(137, 119)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(18, 119)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'wdwNotices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 154)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "wdwNotices"
        Me.Text = "Notices"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadService As RadioButton
    Friend WithEvents RadTardiness As RadioButton
    Friend WithEvents RadAbsence As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
