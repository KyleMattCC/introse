<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popTermEndGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popTermEndGen))
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbbxYear = New System.Windows.Forms.ComboBox()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.bttnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(137, 49)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxTerm.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "School Year:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Term:"
        '
        'cmbbxYear
        '
        Me.cmbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxYear.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxYear.FormattingEnabled = True
        Me.cmbbxYear.Location = New System.Drawing.Point(137, 15)
        Me.cmbbxYear.Name = "cmbbxYear"
        Me.cmbbxYear.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxYear.TabIndex = 6
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(174, 89)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 4
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'bttnGenerate
        '
        Me.bttnGenerate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGenerate.Location = New System.Drawing.Point(55, 89)
        Me.bttnGenerate.Name = "bttnGenerate"
        Me.bttnGenerate.Size = New System.Drawing.Size(90, 30)
        Me.bttnGenerate.TabIndex = 3
        Me.bttnGenerate.Text = "Generate"
        Me.bttnGenerate.UseVisualStyleBackColor = True
        '
        'popTermEndGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 131)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGenerate)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbbxYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "popTermEndGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Term"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbbxTerm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbbxYear As ComboBox
    Friend WithEvents bttnBack As Button
    Friend WithEvents bttnGenerate As Button
End Class
