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
        Me.bttnDataEntry = New System.Windows.Forms.Button()
        Me.bttnModify = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.bttnClear = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Academic Year:"
        '
        'cmbbxAcadYear
        '
        Me.cmbbxAcadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxAcadYear.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxAcadYear.FormattingEnabled = True
        Me.cmbbxAcadYear.Location = New System.Drawing.Point(170, 51)
        Me.cmbbxAcadYear.Name = "cmbbxAcadYear"
        Me.cmbbxAcadYear.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxAcadYear.TabIndex = 1
        '
        'cmbbxTerm
        '
        Me.cmbbxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxTerm.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxTerm.FormattingEnabled = True
        Me.cmbbxTerm.Location = New System.Drawing.Point(437, 51)
        Me.cmbbxTerm.Name = "cmbbxTerm"
        Me.cmbbxTerm.Size = New System.Drawing.Size(165, 28)
        Me.cmbbxTerm.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Term:"
        '
        'bttnSearch
        '
        Me.bttnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSearch.Location = New System.Drawing.Point(738, 12)
        Me.bttnSearch.Name = "bttnSearch"
        Me.bttnSearch.Size = New System.Drawing.Size(105, 29)
        Me.bttnSearch.TabIndex = 4
        Me.bttnSearch.Text = "Search"
        Me.bttnSearch.UseVisualStyleBackColor = False
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(23, 90)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(931, 339)
        Me.grid.TabIndex = 5
        '
        'bttnDataEntry
        '
        Me.bttnDataEntry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnDataEntry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDataEntry.Location = New System.Drawing.Point(23, 447)
        Me.bttnDataEntry.Name = "bttnDataEntry"
        Me.bttnDataEntry.Size = New System.Drawing.Size(204, 40)
        Me.bttnDataEntry.TabIndex = 6
        Me.bttnDataEntry.Text = "Data Entry"
        Me.bttnDataEntry.UseVisualStyleBackColor = False
        '
        'bttnModify
        '
        Me.bttnModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModify.Location = New System.Drawing.Point(274, 447)
        Me.bttnModify.Name = "bttnModify"
        Me.bttnModify.Size = New System.Drawing.Size(204, 40)
        Me.bttnModify.TabIndex = 8
        Me.bttnModify.Text = "Modify"
        Me.bttnModify.UseVisualStyleBackColor = False
        '
        'bttnDelete
        '
        Me.bttnDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDelete.Location = New System.Drawing.Point(515, 447)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(204, 40)
        Me.bttnDelete.TabIndex = 10
        Me.bttnDelete.Text = "Delete"
        Me.bttnDelete.UseVisualStyleBackColor = False
        '
        'bttnBack
        '
        Me.bttnBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBack.Location = New System.Drawing.Point(750, 447)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(204, 40)
        Me.bttnBack.TabIndex = 11
        Me.bttnBack.Text = "Back"
        Me.bttnBack.UseVisualStyleBackColor = False
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSearch.Location = New System.Drawing.Point(417, 14)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(315, 26)
        Me.txtbxSearch.TabIndex = 15
        '
        'bttnClear
        '
        Me.bttnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClear.Location = New System.Drawing.Point(849, 12)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(105, 29)
        Me.bttnClear.TabIndex = 16
        Me.bttnClear.Text = "Clear"
        Me.bttnClear.UseVisualStyleBackColor = False
        '
        'wdwFacPlantilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 500)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnDelete)
        Me.Controls.Add(Me.bttnModify)
        Me.Controls.Add(Me.bttnDataEntry)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bttnSearch)
        Me.Controls.Add(Me.cmbbxTerm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbbxAcadYear)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wdwFacPlantilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty Plantilla"
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
    Friend WithEvents bttnDataEntry As Button
    Friend WithEvents bttnModify As Button
    Friend WithEvents bttnDelete As Button
    Friend WithEvents bttnBack As Button
    Friend WithEvents txtbxSearch As TextBox
    Friend WithEvents bttnClear As Button
End Class