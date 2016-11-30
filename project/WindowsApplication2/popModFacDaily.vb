Public Class wdwModFacultyDaily
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(rowData As List(Of String))
        Dim convertedDate As Date
        Dim day, month, year As String

        Add_Remarks(cmbbxRemarks)
        Add_Course(rowData(1), cmbbxCourse)
        Add_Section(rowData(1), rowData(4), cmbbxSection)

        If rowData.Count > 0 Then
            If String.IsNullOrEmpty(rowData(3)) Then
                txtbxFacID.Text = rowData(1) ' fid
                txtbxName.Text = rowData(2) ' name
                cmbbxCourse.SelectedItem = rowData(4) ' course
                cmbbxSection.SelectedItem = rowData(5) ' section
                txtbxRoom.Text = rowData(6) ' room
                txtbxDay.Text = rowData(7)
                txtbxStart.Text = rowData(8) 'start
                txtbxEnd.Text = rowData(9) ' end
                cmbbxRemarks.SelectedItem = rowData(10)
                txtbxChecker.Text = rowData(13)
            Else
                convertedDate = Convert.ToDateTime(rowData(3))
                day = convertedDate.Day.ToString()
                month = convertedDate.Month.ToString()
                year = convertedDate.Year.ToString()

                txtbxFacID.Text = rowData(1) ' fid
                txtbxName.Text = rowData(2) ' name
                cmbbxCourse.SelectedItem = rowData(4) ' course
                cmbbxSection.SelectedItem = rowData(5) ' section
                txtbxRoom.Text = rowData(6) ' room
                txtbxDay.Text = rowData(7)
                txtbxStart.Text = rowData(8) 'start
                txtbxEnd.Text = rowData(9) ' end
                cmbbxRemarks.SelectedItem = rowData(10)
                txtbxChecker.Text = rowData(13)

                dtp.Value = New Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))

            End If
        End If

        Me.Show()
    End Sub

    Private Sub Add_Faculty_Name(facultyid As String, ByVal text As TextBox)
        Dim fname As String
        Dim MI As String
        Dim lname As String
        Dim name As String

        name = ""
        fname = ""
        MI = ""
        lname = ""
        Try
            fname = dbAccess.getData("Select f_firstname from faculty where facultyid = '" & facultyid & "';", "f_firstname")
            MI = dbAccess.getData("Select f_middlename from faculty where facultyid = '" & facultyid & "';", "f_middlename")
            lname = dbAccess.getData("Select f_lastname from faculty where facultyid = '" & facultyid & "';", "f_lastname")

            If (Not (String.IsNullOrEmpty(fname)) Or Not (String.IsNullOrWhiteSpace(fname))) Then
                text.Text = fname + " " + MI + " " + lname
                dtp.Enabled = True
                cmbbxCourse.Enabled = True
            Else
                text.Text = fname + " " + MI + " " + lname
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Course(facultyid As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of Object)()
        Dim fac As Integer
        combo.Items.Clear()
        combo.ResetText()

        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.getMultipleData("SELECT DISTINCT(c.course_cd) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.course_id = c.course_id;", "course_cd")

            For j As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(j))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Section(facultyid As String, course As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()
        combo.ResetText()

        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.getMultipleData("SELECT DISTINCT(co.section) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND c.course_cd = '" & course & "';", "section")

            For j As Integer = 0 To section.Count - 1
                combo.Items.Add(section(j))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Remarks(ByVal combo As ComboBox)
        Dim remarks As New List(Of Object)()
        combo.Items.Clear()
        combo.ResetText()

        Try
            remarks = dbAccess.getMultipleData("SELECT remark_des FROM remarks;", "remark_des")

            For j As Integer = 0 To remarks.Count - 1
                combo.Items.Add(remarks(j))
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Fill_Room(facultyid As String, course As String, section As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Try
            fac = dbAccess.getData("select facref_no from faculty where status = 'A' AND facultyid = '" & facultyid & "';", "facref_no")
            room = dbAccess.getData("select co.room FROM courseoffering AS co, course AS c WHERE  c.course_cd = '" & course & "' AND c.course_id = co.course_id AND co.facref_no = '" & fac & "'  AND co.section = '" & section & "' AND co.status = 'A';", "room")

            text.Text = room
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Fill_Sched(facultyid As String, course As String, section As String, ByVal TimeStart As TextBox, ByVal TimeEnd As TextBox, ByVal DaySched As TextBox)
        Dim starttime As String
        Dim endtime As String
        Dim fac As String
        Dim sched As String = ""
        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "' and status = 'A';", "facref_no").ToString
            starttime = dbAccess.getData("SELECT co.timestart FROM introse.courseoffering as co, introse.course as c WHERE co.status = 'A' AND c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "';", "timestart").ToString()
            endtime = dbAccess.getData("SELECT co.timeend FROM courseoffering as co, course as c WHERE c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "' AND co.status = 'A';", "timeend").ToString()
            sched = dbAccess.getData("SELECT co.daysched FROM courseoffering as co, course as c WHERE c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "' AND co.status = 'A';", "daysched")

            TimeStart.Text = starttime
            TimeEnd.Text = endtime
            DaySched.Text = sched
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox100_TextChanged(sender As Object, e As EventArgs) Handles txtbxChecker.TextChanged
        Check_Enable()

    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        cmbbxCourse.Items.Clear()
        cmbbxCourse.ResetText()
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        Add_Faculty_Name(txtbxFacID.Text, txtbxName)
        Add_Course(txtbxFacID.Text, cmbbxCourse)
        Check_Enable()
        Check_Element_Enable()

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSection)
        cmbbxRemarks.SelectedIndex = -1
        Check_Enable()

    End Sub

    Private Sub cmbbxSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSection.SelectedIndexChanged
        Fill_Room(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem.ToString, txtbxRoom)
        Fill_Sched(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, txtbxStart, txtbxEnd, txtbxDay)
        cmbbxRemarks.Enabled = True
        cmbbxRemarks.SelectedIndex = -1
        Check_Enable()

    End Sub

    Private Sub cmbbxRemarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxRemarks.SelectedIndexChanged
        Check_Enable()
    End Sub

    Private Sub Check_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(txtbxName.Text) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or String.IsNullOrEmpty(txtbxChecker.Text) Then
            bttnModify.Enabled = False

        Else
            bttnModify.Enabled = True

        End If

    End Sub

    Private Sub Check_Element_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Then
            cmbbxCourse.Enabled = False
            cmbbxSection.Enabled = False
            dtp.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False

        End If
    End Sub

    Private Sub Validate_Input(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        Validate_Input("0123456789", e)

    End Sub

    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        Validate_Input("abcdefghijgklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ", e)

    End Sub

    Private Function Check_Entry(absent As String, courseofferingid As String, stat As String) As Boolean
        Dim att As String = ""
        Dim b As Boolean = False
        att = dbAccess.getData("select attendanceid from attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseofferingid & "' and status = '" & stat & "';", "attendanceid")
        If String.IsNullOrEmpty(att) Then
            b = True
        Else
            MsgBox("ERROR: Duplicate Attendance!")
        End If
        Return b

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim absentdate As String
        Dim remarks As String
        Dim checker, course, section As String
        Dim ref As String = wdwDailyAttendanceLog.getRefNo()
        Dim currentdate As Date
        Dim result As Integer
        currentdate = DateTime.Now.Date
        result = DateTime.Compare(dtp.Value.Date, currentdate)

        If Convert.ToInt32(ref) > 0 Then
            absentdate = dtp.Value.Date.ToString("yyyy-MM-dd")
            course = cmbbxCourse.SelectedItem
            section = cmbbxSection.SelectedItem
            remarks = dbAccess.getData("SELECT remark_cd FROM remarks where remark_des = '" & cmbbxRemarks.SelectedItem & "';", "remark_cd")
            checker = txtbxChecker.Text
            If String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(section) Or String.IsNullOrEmpty(remarks) Or String.IsNullOrEmpty(checker) Then
                MsgBox("Incomplete fields!")
            ElseIf result > 0 Then
                MsgBox("ERROR: Absent Date is earlier than the current date!")
            Else
                dbAccess.updateData("UPDATE `attendance` SET `absent_date` = '" & absentdate & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentdate.ToString("yyyy-MM-dd") & "', `encoder` = 'unknown', `checker` = '" & checker & "' WHERE `attendanceid` = '" & ref & "' and status = 'A';")
                dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' 
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)
                txtbxFacID.Clear()
                txtbxName.Clear()
                cmbbxCourse.Items.Clear()
                cmbbxSection.Items.Clear()
                cmbbxCourse.ResetText()
                cmbbxRemarks.ResetText()
                cmbbxSection.ResetText()
                txtbxRoom.Clear()
                txtbxDay.Clear()
                txtbxStart.Clear()
                txtbxEnd.Clear()
                txtbxChecker.Clear()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()

    End Sub
End Class