﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wdwSelectReport))
        Me.rbttnUnder = New System.Windows.Forms.RadioButton()
        Me.rbttnGrad = New System.Windows.Forms.RadioButton()
        Me.rbttnBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbttnChair = New System.Windows.Forms.RadioButton()
        Me.rbttnDean = New System.Windows.Forms.RadioButton()
        Me.rbttnVCA = New System.Windows.Forms.RadioButton()
        Me.rbttnRegistrar = New System.Windows.Forms.RadioButton()
        Me.cmbbxChair = New System.Windows.Forms.ComboBox()
        Me.cmbbxDean = New System.Windows.Forms.ComboBox()
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
        Me.rbttnUnder.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnUnder.Location = New System.Drawing.Point(6, 16)
        Me.rbttnUnder.Name = "rbttnUnder"
        Me.rbttnUnder.Size = New System.Drawing.Size(159, 24)
        Me.rbttnUnder.TabIndex = 0
        Me.rbttnUnder.TabStop = True
        Me.rbttnUnder.Text = "Undergraduate"
        Me.rbttnUnder.UseVisualStyleBackColor = True
        '
        'rbttnGrad
        '
        Me.rbttnGrad.AutoSize = True
        Me.rbttnGrad.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnGrad.Location = New System.Drawing.Point(6, 39)
        Me.rbttnGrad.Name = "rbttnGrad"
        Me.rbttnGrad.Size = New System.Drawing.Size(108, 24)
        Me.rbttnGrad.TabIndex = 1
        Me.rbttnGrad.TabStop = True
        Me.rbttnGrad.Text = "Graduate"
        Me.rbttnGrad.UseVisualStyleBackColor = True
        '
        'rbttnBoth
        '
        Me.rbttnBoth.AutoSize = True
        Me.rbttnBoth.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnBoth.Location = New System.Drawing.Point(6, 62)
        Me.rbttnBoth.Name = "rbttnBoth"
        Me.rbttnBoth.Size = New System.Drawing.Size(66, 24)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 96)
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
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 205)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type of Report"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbttnChair)
        Me.GroupBox3.Controls.Add(Me.rbttnDean)
        Me.GroupBox3.Controls.Add(Me.rbttnVCA)
        Me.GroupBox3.Controls.Add(Me.rbttnRegistrar)
        Me.GroupBox3.Controls.Add(Me.cmbbxChair)
        Me.GroupBox3.Controls.Add(Me.cmbbxDean)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(532, 145)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report to"
        '
        'rbttnChair
        '
        Me.rbttnChair.AutoSize = True
        Me.rbttnChair.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnChair.Location = New System.Drawing.Point(12, 104)
        Me.rbttnChair.Name = "rbttnChair"
        Me.rbttnChair.Size = New System.Drawing.Size(185, 24)
        Me.rbttnChair.TabIndex = 23
        Me.rbttnChair.TabStop = True
        Me.rbttnChair.Text = "Department Chair"
        Me.rbttnChair.UseVisualStyleBackColor = True
        '
        'rbttnDean
        '
        Me.rbttnDean.AutoSize = True
        Me.rbttnDean.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDean.Location = New System.Drawing.Point(12, 70)
        Me.rbttnDean.Name = "rbttnDean"
        Me.rbttnDean.Size = New System.Drawing.Size(146, 24)
        Me.rbttnDean.TabIndex = 22
        Me.rbttnDean.TabStop = True
        Me.rbttnDean.Text = "College Dean"
        Me.rbttnDean.UseVisualStyleBackColor = True
        '
        'rbttnVCA
        '
        Me.rbttnVCA.AutoSize = True
        Me.rbttnVCA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnVCA.Location = New System.Drawing.Point(12, 45)
        Me.rbttnVCA.Name = "rbttnVCA"
        Me.rbttnVCA.Size = New System.Drawing.Size(62, 24)
        Me.rbttnVCA.TabIndex = 21
        Me.rbttnVCA.TabStop = True
        Me.rbttnVCA.Text = "VCA"
        Me.rbttnVCA.UseVisualStyleBackColor = True
        '
        'rbttnRegistrar
        '
        Me.rbttnRegistrar.AutoSize = True
        Me.rbttnRegistrar.Checked = True
        Me.rbttnRegistrar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnRegistrar.Location = New System.Drawing.Point(12, 20)
        Me.rbttnRegistrar.Name = "rbttnRegistrar"
        Me.rbttnRegistrar.Size = New System.Drawing.Size(108, 24)
        Me.rbttnRegistrar.TabIndex = 20
        Me.rbttnRegistrar.TabStop = True
        Me.rbttnRegistrar.Text = "Registrar"
        Me.rbttnRegistrar.UseVisualStyleBackColor = True
        '
        'cmbbxChair
        '
        Me.cmbbxChair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxChair.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxChair.FormattingEnabled = True
        Me.cmbbxChair.Location = New System.Drawing.Point(208, 104)
        Me.cmbbxChair.Name = "cmbbxChair"
        Me.cmbbxChair.Size = New System.Drawing.Size(307, 28)
        Me.cmbbxChair.TabIndex = 13
        '
        'cmbbxDean
        '
        Me.cmbbxDean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDean.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDean.FormattingEnabled = True
        Me.cmbbxDean.Location = New System.Drawing.Point(208, 70)
        Me.cmbbxDean.Name = "cmbbxDean"
        Me.cmbbxDean.Size = New System.Drawing.Size(307, 28)
        Me.cmbbxDean.TabIndex = 11
        '
        'rbttnTermEnd
        '
        Me.rbttnTermEnd.AutoSize = True
        Me.rbttnTermEnd.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnTermEnd.Location = New System.Drawing.Point(190, 19)
        Me.rbttnTermEnd.Name = "rbttnTermEnd"
        Me.rbttnTermEnd.Size = New System.Drawing.Size(115, 24)
        Me.rbttnTermEnd.TabIndex = 5
        Me.rbttnTermEnd.TabStop = True
        Me.rbttnTermEnd.Text = "Term-End"
        Me.rbttnTermEnd.UseVisualStyleBackColor = True
        '
        'rbttnMonthly
        '
        Me.rbttnMonthly.AutoSize = True
        Me.rbttnMonthly.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnMonthly.Location = New System.Drawing.Point(86, 19)
        Me.rbttnMonthly.Name = "rbttnMonthly"
        Me.rbttnMonthly.Size = New System.Drawing.Size(97, 24)
        Me.rbttnMonthly.TabIndex = 4
        Me.rbttnMonthly.TabStop = True
        Me.rbttnMonthly.Text = "Monthly"
        Me.rbttnMonthly.UseVisualStyleBackColor = True
        '
        'rbttnDaily
        '
        Me.rbttnDaily.AutoSize = True
        Me.rbttnDaily.Checked = True
        Me.rbttnDaily.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDaily.Location = New System.Drawing.Point(6, 19)
        Me.rbttnDaily.Name = "rbttnDaily"
        Me.rbttnDaily.Size = New System.Drawing.Size(71, 24)
        Me.rbttnDaily.TabIndex = 3
        Me.rbttnDaily.TabStop = True
        Me.rbttnDaily.Text = "Daily"
        Me.rbttnDaily.UseVisualStyleBackColor = True
        '
        'bttnGen
        '
        Me.bttnGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGen.Location = New System.Drawing.Point(146, 324)
        Me.bttnGen.Name = "bttnGen"
        Me.bttnGen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bttnGen.Size = New System.Drawing.Size(90, 30)
        Me.bttnGen.TabIndex = 5
        Me.bttnGen.Text = "Generate"
        Me.bttnGen.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(327, 325)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 6
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'wdwSelectReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 366)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "wdwSelectReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Report"
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
    Friend WithEvents cmbbxDean As ComboBox
    Friend WithEvents rbttnTermEnd As RadioButton
    Friend WithEvents rbttnMonthly As RadioButton
    Friend WithEvents rbttnDaily As RadioButton
    Friend WithEvents cmbbxChair As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bttnGen As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents rbttnRegistrar As RadioButton
    Friend WithEvents rbttnChair As RadioButton
    Friend WithEvents rbttnDean As RadioButton
    Friend WithEvents rbttnVCA As RadioButton
End Class
