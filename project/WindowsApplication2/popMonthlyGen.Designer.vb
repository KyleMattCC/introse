<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popMonthlyGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popMonthlyGen))
        Me.cmbbxYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnGenerate = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbbxMonth = New System.Windows.Forms.ComboBox()
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbbxYear
        '
        Me.cmbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxYear.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxYear.FormattingEnabled = True
        Me.cmbbxYear.Location = New System.Drawing.Point(161, 19)
        Me.cmbbxYear.Name = "cmbbxYear"
        Me.cmbbxYear.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Month:"
        '
        'bttnGenerate
        '
        Me.bttnGenerate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGenerate.Location = New System.Drawing.Point(65, 140)
        Me.bttnGenerate.Name = "bttnGenerate"
        Me.bttnGenerate.Size = New System.Drawing.Size(90, 30)
        Me.bttnGenerate.TabIndex = 4
        Me.bttnGenerate.Text = "Generate"
        Me.bttnGenerate.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(185, 140)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 30)
        Me.bttnBack.TabIndex = 5
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Academic year:"
        '
        'cmbbxMonth
        '
        Me.cmbbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxMonth.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxMonth.FormattingEnabled = True
        Me.cmbbxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbbxMonth.Location = New System.Drawing.Point(161, 90)
        Me.cmbbxMonth.MaxDropDownItems = 12
        Me.cmbbxMonth.Name = "cmbbxMonth"
        Me.cmbbxMonth.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxMonth.TabIndex = 3
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(161, 55)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxTerm.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Term:"
        '
        'popMonthlyGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 188)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.cmbbxMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbbxYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "popMonthlyGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbbxYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnGenerate As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbbxMonth As ComboBox
    Friend WithEvents cmbbxTerm As ComboBox
    Friend WithEvents Label3 As Label
End Class
