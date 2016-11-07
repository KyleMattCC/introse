<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwSelectReport
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
        Me.rbttnUnder = New System.Windows.Forms.RadioButton()
        Me.rbttnGrad = New System.Windows.Forms.RadioButton()
        Me.rbttnBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chckDeptChair = New System.Windows.Forms.CheckBox()
        Me.chckDean = New System.Windows.Forms.CheckBox()
        Me.chckVCA = New System.Windows.Forms.CheckBox()
        Me.chckRegistrar = New System.Windows.Forms.CheckBox()
        Me.chckAllColl2 = New System.Windows.Forms.CheckBox()
        Me.chckAllColeg1 = New System.Windows.Forms.CheckBox()
        Me.cmbChair = New System.Windows.Forms.ComboBox()
        Me.cmbDean = New System.Windows.Forms.ComboBox()
        Me.rbttnTermEnd = New System.Windows.Forms.RadioButton()
        Me.rbttnMonthly = New System.Windows.Forms.RadioButton()
        Me.rbttnDaily = New System.Windows.Forms.RadioButton()
        Me.bttnGen = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbttnUnder
        '
        Me.rbttnUnder.AutoSize = True
        Me.rbttnUnder.Checked = True
        Me.rbttnUnder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnUnder.Location = New System.Drawing.Point(6, 23)
        Me.rbttnUnder.Name = "rbttnUnder"
        Me.rbttnUnder.Size = New System.Drawing.Size(117, 20)
        Me.rbttnUnder.TabIndex = 0
        Me.rbttnUnder.TabStop = True
        Me.rbttnUnder.Text = "Undergraduate"
        Me.rbttnUnder.UseVisualStyleBackColor = True
        '
        'rbttnGrad
        '
        Me.rbttnGrad.AutoSize = True
        Me.rbttnGrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnGrad.Location = New System.Drawing.Point(6, 46)
        Me.rbttnGrad.Name = "rbttnGrad"
        Me.rbttnGrad.Size = New System.Drawing.Size(82, 20)
        Me.rbttnGrad.TabIndex = 1
        Me.rbttnGrad.TabStop = True
        Me.rbttnGrad.Text = "Graduate"
        Me.rbttnGrad.UseVisualStyleBackColor = True
        '
        'rbttnBoth
        '
        Me.rbttnBoth.AutoSize = True
        Me.rbttnBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnBoth.Location = New System.Drawing.Point(6, 69)
        Me.rbttnBoth.Name = "rbttnBoth"
        Me.rbttnBoth.Size = New System.Drawing.Size(53, 20)
        Me.rbttnBoth.TabIndex = 2
        Me.rbttnBoth.TabStop = True
        Me.rbttnBoth.Text = "Both"
        Me.rbttnBoth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbttnUnder)
        Me.GroupBox1.Controls.Add(Me.rbttnBoth)
        Me.GroupBox1.Controls.Add(Me.rbttnGrad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 96)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report for"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.rbttnTermEnd)
        Me.GroupBox2.Controls.Add(Me.rbttnMonthly)
        Me.GroupBox2.Controls.Add(Me.rbttnDaily)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 270)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type of Report"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chckDeptChair)
        Me.GroupBox3.Controls.Add(Me.chckDean)
        Me.GroupBox3.Controls.Add(Me.chckVCA)
        Me.GroupBox3.Controls.Add(Me.chckRegistrar)
        Me.GroupBox3.Controls.Add(Me.chckAllColl2)
        Me.GroupBox3.Controls.Add(Me.chckAllColeg1)
        Me.GroupBox3.Controls.Add(Me.cmbChair)
        Me.GroupBox3.Controls.Add(Me.cmbDean)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(501, 212)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'chckDeptChair
        '
        Me.chckDeptChair.AutoSize = True
        Me.chckDeptChair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckDeptChair.Location = New System.Drawing.Point(12, 140)
        Me.chckDeptChair.Name = "chckDeptChair"
        Me.chckDeptChair.Size = New System.Drawing.Size(147, 20)
        Me.chckDeptChair.TabIndex = 19
        Me.chckDeptChair.Text = "Department Chair"
        Me.chckDeptChair.UseVisualStyleBackColor = True
        '
        'chckDean
        '
        Me.chckDean.AutoSize = True
        Me.chckDean.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckDean.Location = New System.Drawing.Point(12, 84)
        Me.chckDean.Name = "chckDean"
        Me.chckDean.Size = New System.Drawing.Size(122, 20)
        Me.chckDean.TabIndex = 18
        Me.chckDean.Text = "College Dean"
        Me.chckDean.UseVisualStyleBackColor = True
        '
        'chckVCA
        '
        Me.chckVCA.AutoSize = True
        Me.chckVCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckVCA.Location = New System.Drawing.Point(12, 50)
        Me.chckVCA.Name = "chckVCA"
        Me.chckVCA.Size = New System.Drawing.Size(57, 20)
        Me.chckVCA.TabIndex = 17
        Me.chckVCA.Text = "VCA"
        Me.chckVCA.UseVisualStyleBackColor = True
        '
        'chckRegistrar
        '
        Me.chckRegistrar.AutoSize = True
        Me.chckRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckRegistrar.Location = New System.Drawing.Point(12, 19)
        Me.chckRegistrar.Name = "chckRegistrar"
        Me.chckRegistrar.Size = New System.Drawing.Size(91, 20)
        Me.chckRegistrar.TabIndex = 16
        Me.chckRegistrar.Text = "Registrar"
        Me.chckRegistrar.UseVisualStyleBackColor = True
        '
        'chckAllColl2
        '
        Me.chckAllColl2.AutoSize = True
        Me.chckAllColl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAllColl2.Location = New System.Drawing.Point(162, 113)
        Me.chckAllColl2.Name = "chckAllColl2"
        Me.chckAllColl2.Size = New System.Drawing.Size(111, 20)
        Me.chckAllColl2.TabIndex = 15
        Me.chckAllColl2.Text = "All Colleges"
        Me.chckAllColl2.UseVisualStyleBackColor = True
        '
        'chckAllColeg1
        '
        Me.chckAllColeg1.AutoSize = True
        Me.chckAllColeg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAllColeg1.Location = New System.Drawing.Point(162, 171)
        Me.chckAllColeg1.Name = "chckAllColeg1"
        Me.chckAllColeg1.Size = New System.Drawing.Size(111, 20)
        Me.chckAllColeg1.TabIndex = 14
        Me.chckAllColeg1.Text = "All Colleges"
        Me.chckAllColeg1.UseVisualStyleBackColor = True
        '
        'cmbChair
        '
        Me.cmbChair.FormattingEnabled = True
        Me.cmbChair.Location = New System.Drawing.Point(162, 137)
        Me.cmbChair.Name = "cmbChair"
        Me.cmbChair.Size = New System.Drawing.Size(307, 28)
        Me.cmbChair.TabIndex = 13
        '
        'cmbDean
        '
        Me.cmbDean.FormattingEnabled = True
        Me.cmbDean.Location = New System.Drawing.Point(163, 81)
        Me.cmbDean.Name = "cmbDean"
        Me.cmbDean.Size = New System.Drawing.Size(307, 28)
        Me.cmbDean.TabIndex = 11
        '
        'rbttnTermEnd
        '
        Me.rbttnTermEnd.AutoSize = True
        Me.rbttnTermEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnTermEnd.Location = New System.Drawing.Point(148, 26)
        Me.rbttnTermEnd.Name = "rbttnTermEnd"
        Me.rbttnTermEnd.Size = New System.Drawing.Size(86, 20)
        Me.rbttnTermEnd.TabIndex = 5
        Me.rbttnTermEnd.TabStop = True
        Me.rbttnTermEnd.Text = "Term-End"
        Me.rbttnTermEnd.UseVisualStyleBackColor = True
        '
        'rbttnMonthly
        '
        Me.rbttnMonthly.AutoSize = True
        Me.rbttnMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnMonthly.Location = New System.Drawing.Point(68, 26)
        Me.rbttnMonthly.Name = "rbttnMonthly"
        Me.rbttnMonthly.Size = New System.Drawing.Size(72, 20)
        Me.rbttnMonthly.TabIndex = 4
        Me.rbttnMonthly.TabStop = True
        Me.rbttnMonthly.Text = "Monthly"
        Me.rbttnMonthly.UseVisualStyleBackColor = True
        '
        'rbttnDaily
        '
        Me.rbttnDaily.AutoSize = True
        Me.rbttnDaily.Checked = True
        Me.rbttnDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDaily.Location = New System.Drawing.Point(7, 26)
        Me.rbttnDaily.Name = "rbttnDaily"
        Me.rbttnDaily.Size = New System.Drawing.Size(57, 20)
        Me.rbttnDaily.TabIndex = 3
        Me.rbttnDaily.TabStop = True
        Me.rbttnDaily.Text = "Daily"
        Me.rbttnDaily.UseVisualStyleBackColor = True
        '
        'bttnGen
        '
        Me.bttnGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGen.Location = New System.Drawing.Point(133, 390)
        Me.bttnGen.Name = "bttnGen"
        Me.bttnGen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bttnGen.Size = New System.Drawing.Size(90, 75)
        Me.bttnGen.TabIndex = 5
        Me.bttnGen.Text = "Generate"
        Me.bttnGen.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(285, 390)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 75)
        Me.bttnBack.TabIndex = 6
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'wdwSelectReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 488)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "wdwSelectReport"
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbttnUnder As RadioButton
    Friend WithEvents rbttnGrad As RadioButton
    Friend WithEvents rbttnBoth As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbDean As ComboBox
    Friend WithEvents rbttnTermEnd As RadioButton
    Friend WithEvents rbttnMonthly As RadioButton
    Friend WithEvents rbttnDaily As RadioButton
    Friend WithEvents cmbChair As ComboBox
    Friend WithEvents chckAllColl2 As CheckBox
    Friend WithEvents chckAllColeg1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bttnGen As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents chckDeptChair As CheckBox
    Friend WithEvents chckDean As CheckBox
    Friend WithEvents chckVCA As CheckBox
    Friend WithEvents chckRegistrar As CheckBox
End Class
