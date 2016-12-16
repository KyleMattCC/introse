<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwSelectReport
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
        Me.rbttnUnder.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnUnder.Location = New System.Drawing.Point(8, 28)
        Me.rbttnUnder.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnUnder.Name = "rbttnUnder"
        Me.rbttnUnder.Size = New System.Drawing.Size(169, 25)
        Me.rbttnUnder.TabIndex = 0
        Me.rbttnUnder.TabStop = True
        Me.rbttnUnder.Text = "Undergraduate"
        Me.rbttnUnder.UseVisualStyleBackColor = True
        '
        'rbttnGrad
        '
        Me.rbttnGrad.AutoSize = True
        Me.rbttnGrad.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnGrad.Location = New System.Drawing.Point(8, 57)
        Me.rbttnGrad.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnGrad.Name = "rbttnGrad"
        Me.rbttnGrad.Size = New System.Drawing.Size(115, 25)
        Me.rbttnGrad.TabIndex = 1
        Me.rbttnGrad.TabStop = True
        Me.rbttnGrad.Text = "Graduate"
        Me.rbttnGrad.UseVisualStyleBackColor = True
        '
        'rbttnBoth
        '
        Me.rbttnBoth.AutoSize = True
        Me.rbttnBoth.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnBoth.Location = New System.Drawing.Point(8, 85)
        Me.rbttnBoth.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnBoth.Name = "rbttnBoth"
        Me.rbttnBoth.Size = New System.Drawing.Size(72, 25)
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(223, 118)
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 140)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(688, 246)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(668, 162)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report to"
        '
        'rbttnChair
        '
        Me.rbttnChair.AutoSize = True
        Me.rbttnChair.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnChair.Location = New System.Drawing.Point(16, 117)
        Me.rbttnChair.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnChair.Name = "rbttnChair"
        Me.rbttnChair.Size = New System.Drawing.Size(195, 25)
        Me.rbttnChair.TabIndex = 23
        Me.rbttnChair.TabStop = True
        Me.rbttnChair.Text = "Department Chair"
        Me.rbttnChair.UseVisualStyleBackColor = True
        '
        'rbttnDean
        '
        Me.rbttnDean.AutoSize = True
        Me.rbttnDean.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDean.Location = New System.Drawing.Point(16, 86)
        Me.rbttnDean.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnDean.Name = "rbttnDean"
        Me.rbttnDean.Size = New System.Drawing.Size(155, 25)
        Me.rbttnDean.TabIndex = 22
        Me.rbttnDean.TabStop = True
        Me.rbttnDean.Text = "College Dean"
        Me.rbttnDean.UseVisualStyleBackColor = True
        '
        'rbttnVCA
        '
        Me.rbttnVCA.AutoSize = True
        Me.rbttnVCA.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnVCA.Location = New System.Drawing.Point(16, 55)
        Me.rbttnVCA.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnVCA.Name = "rbttnVCA"
        Me.rbttnVCA.Size = New System.Drawing.Size(69, 25)
        Me.rbttnVCA.TabIndex = 21
        Me.rbttnVCA.TabStop = True
        Me.rbttnVCA.Text = "VCA"
        Me.rbttnVCA.UseVisualStyleBackColor = True
        '
        'rbttnRegistrar
        '
        Me.rbttnRegistrar.AutoSize = True
        Me.rbttnRegistrar.Checked = True
        Me.rbttnRegistrar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnRegistrar.Location = New System.Drawing.Point(16, 25)
        Me.rbttnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnRegistrar.Name = "rbttnRegistrar"
        Me.rbttnRegistrar.Size = New System.Drawing.Size(115, 25)
        Me.rbttnRegistrar.TabIndex = 20
        Me.rbttnRegistrar.TabStop = True
        Me.rbttnRegistrar.Text = "Registrar"
        Me.rbttnRegistrar.UseVisualStyleBackColor = True
        '
        'cmbbxChair
        '
        Me.cmbbxChair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxChair.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxChair.FormattingEnabled = True
        Me.cmbbxChair.Location = New System.Drawing.Point(228, 117)
        Me.cmbbxChair.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbxChair.Name = "cmbbxChair"
        Me.cmbbxChair.Size = New System.Drawing.Size(408, 25)
        Me.cmbbxChair.TabIndex = 13
        '
        'cmbbxDean
        '
        Me.cmbbxDean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDean.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDean.FormattingEnabled = True
        Me.cmbbxDean.Location = New System.Drawing.Point(228, 82)
        Me.cmbbxDean.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbxDean.Name = "cmbbxDean"
        Me.cmbbxDean.Size = New System.Drawing.Size(408, 25)
        Me.cmbbxDean.TabIndex = 11
        '
        'rbttnTermEnd
        '
        Me.rbttnTermEnd.AutoSize = True
        Me.rbttnTermEnd.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnTermEnd.Location = New System.Drawing.Point(221, 32)
        Me.rbttnTermEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnTermEnd.Name = "rbttnTermEnd"
        Me.rbttnTermEnd.Size = New System.Drawing.Size(123, 25)
        Me.rbttnTermEnd.TabIndex = 5
        Me.rbttnTermEnd.TabStop = True
        Me.rbttnTermEnd.Text = "Term-End"
        Me.rbttnTermEnd.UseVisualStyleBackColor = True
        '
        'rbttnMonthly
        '
        Me.rbttnMonthly.AutoSize = True
        Me.rbttnMonthly.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnMonthly.Location = New System.Drawing.Point(101, 32)
        Me.rbttnMonthly.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnMonthly.Name = "rbttnMonthly"
        Me.rbttnMonthly.Size = New System.Drawing.Size(104, 25)
        Me.rbttnMonthly.TabIndex = 4
        Me.rbttnMonthly.TabStop = True
        Me.rbttnMonthly.Text = "Monthly"
        Me.rbttnMonthly.UseVisualStyleBackColor = True
        '
        'rbttnDaily
        '
        Me.rbttnDaily.AutoSize = True
        Me.rbttnDaily.Checked = True
        Me.rbttnDaily.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDaily.Location = New System.Drawing.Point(9, 32)
        Me.rbttnDaily.Margin = New System.Windows.Forms.Padding(4)
        Me.rbttnDaily.Name = "rbttnDaily"
        Me.rbttnDaily.Size = New System.Drawing.Size(78, 25)
        Me.rbttnDaily.TabIndex = 3
        Me.rbttnDaily.TabStop = True
        Me.rbttnDaily.Text = "Daily"
        Me.rbttnDaily.UseVisualStyleBackColor = True
        '
        'bttnGen
        '
        Me.bttnGen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnGen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGen.Location = New System.Drawing.Point(167, 400)
        Me.bttnGen.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnGen.Name = "bttnGen"
        Me.bttnGen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bttnGen.Size = New System.Drawing.Size(120, 37)
        Me.bttnGen.TabIndex = 5
        Me.bttnGen.Text = "Generate"
        Me.bttnGen.UseVisualStyleBackColor = False
        '
        'bttnBack
        '
        Me.bttnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(433, 400)
        Me.bttnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(120, 37)
        Me.bttnBack.TabIndex = 6
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = False
        '
        'wdwSelectReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
