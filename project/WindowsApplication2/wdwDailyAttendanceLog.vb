Public Class wdwDailyAttendanceLog
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Me.Enabled = False
        wdwModFacultyDaily.Show()

    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        popEncFacDaily.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Enabled = False
        popFacSearch.Show()
    End Sub

    Private Sub wdwDailyAttendanceLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Load_form()
    End Sub

    Private Sub Load_form()
        dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' 
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & dtp.Value.Date & "' 
                                order by 3, 12;", grid)
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        'Dim FirstName As String
        'Dim MiddleName As String
        'Dim LastName As String
        'Dim DepartmentName As String
        'Dim FacultyID As String


        'If FacultyIDButton.Checked = True Then

        'FirstName = dbAccess.getStringData("Select f_firstname from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_firstname")
        'MiddleName = dbAccess.getStringData("Select f_middlename from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_middlename")
        'LastName = dbAccess.getStringData("Select f_lastname from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_lastname")
        'FacultyID = dbAccess.getStringData("Select facultyid from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "facultyid")


        'DepartmentName = dbAccess.getStringData("Select departmentname from department, faculty where facultyid = '" + FacultyIDSearchText.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")

        'FacultyIDText.Text = FacultyID
        'FacultyNameText.Text = FirstName + " " + MiddleName + " " + LastName
        'DepartmentNameText.Text = DepartmentName

        'Else


        'End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        'If FacultyIDButton.Checked = True And CourseSectionButton.Checked = False Then
        'CourseSearchText.Enabled = False
        'SectionSearchText.Enabled = False
        'FacultyIDSearchText.Enabled = True

        'Else
        '    FacultyIDSearchText.Enabled = False
        'CourseSearchText.Enabled = True
        'SectionSearchText.Enabled = True
        ' End If
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Load_form()
        Me.Focus()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
    End Sub
End Class