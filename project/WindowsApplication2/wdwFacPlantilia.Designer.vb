<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwFacPlantilia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbbxAcadYear = New System.Windows.Forms.ComboBox()
        Me.cmbbxTerm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnSearch = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.bttnClear = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Academic Year:"
        '
        'cmbbxAcadYear
        '
        Me.cmbbxAcadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxAcadYear.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxAcadYear.FormattingEnabled = True
        Me.cmbbxAcadYear.Location = New System.Drawing.Point(165, 46)
        Me.cmbbxAcadYear.Name = "cmbbxAcadYear"
        Me.cmbbxAcadYear.Size = New System.Drawing.Size(119, 23)
        Me.cmbbxAcadYear.TabIndex = 1
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(359, 46)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(119, 23)
        Me.cmbbxTerm.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Term:"
        '
        'bttnSearch
        '
        Me.bttnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(731, 42)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(105, 29)
        Me.bttnSearch.TabIndex = 4
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(23, 96)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(931, 339)
        Me.grid.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(218, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Data Entry"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(329, 485)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 28)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Modify"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(440, 485)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 28)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(551, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSearch.Location = New System.Drawing.Point(514, 44)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(211, 26)
        Me.txtbxSearch.TabIndex = 15
        '
        'bttnClear
        '
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(849, 42)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(105, 29)
        Me.bttnClear.TabIndex = 16
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = True
        '
        'wdwFacPlantilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 552)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bttnSearch)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbbxAcadYear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wdwFacPlantilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wdwFacPlantilia"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbbxAcadYear As ComboBox
    Friend WithEvents cmbbxTerm As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnSearch As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbxSearch As TextBox
    Friend WithEvents bttnClear As Button
End Class
