<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wdwMainMenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bttnPlantilla = New System.Windows.Forms.Button()
        Me.bttnDailyAtt = New System.Windows.Forms.Button()
        Me.bttnMakeUp = New System.Windows.Forms.Button()
        Me.bttnCourse = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bttnNotice = New System.Windows.Forms.Button()
        Me.bttnReport = New System.Windows.Forms.Button()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bttnPlantilla)
        Me.GroupBox1.Controls.Add(Me.bttnDailyAtt)
        Me.GroupBox1.Controls.Add(Me.bttnMakeUp)
        Me.GroupBox1.Controls.Add(Me.bttnCourse)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 120)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'bttnPlantilla
        '
        Me.bttnPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPlantilla.Location = New System.Drawing.Point(381, 19)
        Me.bttnPlantilla.Name = "bttnPlantilla"
        Me.bttnPlantilla.Size = New System.Drawing.Size(120, 90)
        Me.bttnPlantilla.TabIndex = 15
        Me.bttnPlantilla.Text = "Faculty Plantilla"
        Me.bttnPlantilla.UseVisualStyleBackColor = True
        '
        'bttnDailyAtt
        '
        Me.bttnDailyAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnDailyAtt.Location = New System.Drawing.Point(8, 19)
        Me.bttnDailyAtt.Name = "bttnDailyAtt"
        Me.bttnDailyAtt.Size = New System.Drawing.Size(112, 90)
        Me.bttnDailyAtt.TabIndex = 10
        Me.bttnDailyAtt.Text = " Daily Attendance"
        Me.bttnDailyAtt.UseVisualStyleBackColor = True
        '
        'bttnMakeUp
        '
        Me.bttnMakeUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMakeUp.Location = New System.Drawing.Point(126, 19)
        Me.bttnMakeUp.Name = "bttnMakeUp"
        Me.bttnMakeUp.Size = New System.Drawing.Size(115, 90)
        Me.bttnMakeUp.TabIndex = 12
        Me.bttnMakeUp.Text = "Make-up Schedule"
        Me.bttnMakeUp.UseVisualStyleBackColor = True
        '
        'bttnCourse
        '
        Me.bttnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCourse.Location = New System.Drawing.Point(249, 19)
        Me.bttnCourse.Name = "bttnCourse"
        Me.bttnCourse.Size = New System.Drawing.Size(124, 90)
        Me.bttnCourse.TabIndex = 14
        Me.bttnCourse.Text = "Course/Section"
        Me.bttnCourse.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.bttnNotice)
        Me.GroupBox3.Controls.Add(Me.bttnReport)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 120)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Generate"
        '
        'bttnNotice
        '
        Me.bttnNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnNotice.Location = New System.Drawing.Point(258, 19)
        Me.bttnNotice.Name = "bttnNotice"
        Me.bttnNotice.Size = New System.Drawing.Size(120, 90)
        Me.bttnNotice.TabIndex = 17
        Me.bttnNotice.Text = "Notices"
        Me.bttnNotice.UseVisualStyleBackColor = True
        '
        'bttnReport
        '
        Me.bttnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnReport.Location = New System.Drawing.Point(132, 19)
        Me.bttnReport.Name = "bttnReport"
        Me.bttnReport.Size = New System.Drawing.Size(120, 90)
        Me.bttnReport.TabIndex = 15
        Me.bttnReport.Text = "Reports"
        Me.bttnReport.UseVisualStyleBackColor = True
        '
        'bttnExit
        '
        Me.bttnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnExit.Location = New System.Drawing.Point(229, 296)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(75, 25)
        Me.bttnExit.TabIndex = 18
        Me.bttnExit.Text = "Exit"
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'wdwMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 328)
        Me.Controls.Add(Me.bttnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "wdwMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bttnDailyAtt As Button
    Friend WithEvents bttnPlantilla As Button
    Friend WithEvents bttnCourse As Button
    Friend WithEvents bttnMakeUp As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bttnNotice As Button
    Friend WithEvents bttnReport As Button
    Friend WithEvents bttnExit As Button
End Class
