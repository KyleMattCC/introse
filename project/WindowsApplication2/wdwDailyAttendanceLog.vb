Public Class wdwDailyAttendanceLog
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor
    Public dgAttID As String
    Dim RData As List(Of String) = New List(Of String)

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        If String.IsNullOrEmpty(dgAttID) Then
            MsgBox("No selected attendance")
        Else

            dbAccess.updateData("UPDATE `attendance` SET `status` = 'D' WHERE `attendanceid` = '" & dgAttID & "';")
            Load_form()


        End If
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim convertedDate As Date
        Dim day, month, year As String
        Dim remarks As List(Of String)
        Dim arrayCourse As String() = Array.CreateInstance(GetType(String), 0)

        remarks = dbAccess.getMultipleData("SELECT remark_cd FROM remarks;", "remark_cd")

        If RData.Count > 0 Then
            If String.IsNullOrEmpty(RData(3)) Then
                wdwModFacultyDaily.txtbxFacID.Text = RData(1) ' fid
                wdwModFacultyDaily.txtbxName.Text = RData(2) ' name
                wdwModFacultyDaily.cmbbxCourse.Items.Add(RData(4)) ' course
                For i As Integer = 0 To remarks.Count - 1
                    wdwModFacultyDaily.cmbbxRemarks.Items.Add(remarks(i))
                Next
                wdwModFacultyDaily.cmbbxSection.Items.Add(RData(5)) ' section

                wdwModFacultyDaily.txtbxRoom.Text = RData(6) ' room
                wdwModFacultyDaily.txtbxDay.Text = RData(7)
                wdwModFacultyDaily.txtbxStart.Text = RData(8) 'start
                wdwModFacultyDaily.txtbxEnd.Text = RData(9) ' end
                wdwModFacultyDaily.txtbxEncoder.Text = RData(12) ' encoder
            Else
                MsgBox(RData(3))
                convertedDate = Convert.ToDateTime(RData(3))
                day = convertedDate.Day.ToString()
                month = convertedDate.Month.ToString()
                year = convertedDate.Year.ToString()


                wdwModFacultyDaily.txtbxFacID.Text = RData(1) ' fid
                wdwModFacultyDaily.txtbxName.Text = RData(2) ' name
                wdwModFacultyDaily.cmbbxCourse.Items.Add(RData(4)) ' course
                For i As Integer = 0 To remarks.Count - 1
                    wdwModFacultyDaily.cmbbxRemarks.Items.Add(remarks(i))
                Next
                wdwModFacultyDaily.cmbbxSection.Items.Add(RData(5)) ' section

                wdwModFacultyDaily.txtbxRoom.Text = RData(6) ' room
                wdwModFacultyDaily.txtbxDay.Text = RData(7)
                wdwModFacultyDaily.txtbxStart.Text = RData(8) 'start
                wdwModFacultyDaily.txtbxEnd.Text = RData(9) ' end
                wdwModFacultyDaily.txtbxEncoder.Text = RData(12) ' encoder
                wdwModFacultyDaily.dtp.Value = New Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))

            End If
        End If
        ' wdwModFacultyDaily.Show()
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
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
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
        Dim value As Object = grid.Rows(e.RowIndex).Cells(0).Value
        Dim Temp As New List(Of String)
        Dim i, j As Integer

        If IsDBNull(value) Then
            dgAttID = ""
        Else
            dgAttID = CType(value, String)
        End If

        i = grid.CurrentRow.Index
        j = grid.ColumnCount

        For k As Integer = 0 To j - 1
            If String.IsNullOrEmpty(grid.Item(k, i).Value.ToString) Then
                MsgBox("Missing data!")
                Temp.Add(grid.Item(k, i).Value.ToString)
            Else
                Temp.Add(grid.Item(k, i).Value.ToString)

            End If
        Next

        If (RData.Count = 0) Then
            For k As Integer = 0 To Temp.Count - 1
                RData.Add(Temp(k))
            Next
        Else
            For k As Integer = 0 To Temp.Count - 1
                RData(k) = Temp(k)
            Next
        End If
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