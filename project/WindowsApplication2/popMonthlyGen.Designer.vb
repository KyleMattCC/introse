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
        Me.cmbbxYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbbxMonth = New System.Windows.Forms.ComboBox()
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbbxYear
        '
        Me.cmbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxYear.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxYear.FormattingEnabled = True
        Me.cmbbxYear.Location = New System.Drawing.Point(157, 17)
        Me.cmbbxYear.Name = "cmbbxYear"
        Me.cmbbxYear.Size = New System.Drawing.Size(121, 23)
        Me.cmbbxYear.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Month:"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(47, 89)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(90, 30)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(167, 89)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Academic year:"
        '
        'cmbbxMonth
        '
        Me.cmbbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxMonth.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxMonth.FormattingEnabled = True
        Me.cmbbxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbbxMonth.Location = New System.Drawing.Point(157, 60)
        Me.cmbbxMonth.Name = "cmbbxMonth"
        Me.cmbbxMonth.Size = New System.Drawing.Size(121, 23)
        Me.cmbbxMonth.TabIndex = 2
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(136, 40)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(121, 23)
        Me.cmbbxTerm.TabIndex = 1
        '
        'popMonthlyGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 131)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.cmbbxMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbbxYear)
        Me.Name = "popMonthlyGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbbxYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbbxMonth As ComboBox
    Friend WithEvents cmbbxTerm As ComboBox
End Class
