Public Class popEncFacDaily
    Dim dbAccess As New DatabaseAccessor
    Private Sub AddRoom(facultyid As String, course As String, section As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Try
            fac = dbAccess.getData("select facref_no from faculty where status = 'A' AND facultyid = '" & facultyid & "';", "facref_no")
            room = dbAccess.getData("SELECT co.room FROM courseoffering AS co, course AS c WHERE  c.course_cd = '" & course & "' AND c.course_id = co.course_id AND co.facref_no = '" & fac & "'  AND co.section = '" & section & "' AND co.status = 'A';", "room")

            text.Text = room
        Catch ex As Exception

        End Try


    End Sub
    Private Sub AddRemarks(ByVal combo As ComboBox)
        Dim remarks As New List(Of Object)()
        Try
            remarks = dbAccess.getMultipleData("SELECT remark_des FROM remarks;", "remark_des")

            For j As Integer = 0 To remarks.Count - 1
                combo.Items.Add(remarks(j))
            Next

        Catch ex As Exception

        End Try

    End Sub
    Private Sub SetAttendance(facultyid As String, course As String, section As String, remark As String, inputdate As Date, encoder As String, checker As String, ByVal text As TextBox, ByVal combo As ComboBox, stat As String)
        Dim courseid As String = ""
        Dim courseofferingid As String = ""
        Dim fac As String = ""
        Dim currentdate As Date
        Dim result As Integer
        Dim remark_cd As String = ""
        Try
            currentdate = DateTime.Now.Date
            result = DateTime.Compare(inputdate, currentdate)


            If (text.Text.Length = 0 Or String.IsNullOrEmpty(combo.Text) Or String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(remark) Or String.IsNullOrEmpty(checker)) Then

            ElseIf result > 0 Then
                MsgBox("ERROR: Absent Date is earlier than the current date!")
            Else
                courseid = dbAccess.getData("SELECT course_id FROM course WHERE course_cd ='" & course & "';", "course_id")
                fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
                courseofferingid = dbAccess.getData("select courseoffering_id from courseoffering  where course_id = " & courseid & " and facref_no = '" & fac & "' and status = 'A' and section = '" & section & "';", "courseoffering_id")
                remark_cd = dbAccess.getData("select remark_cd from remarks where remark_des = '" & remark & "';", "remark_cd")
                If (checkEntry(inputdate.ToString("yyyy-MM-dd"), courseofferingid, "A") = True) Then
                    dbAccess.addData("INSERT INTO `attendance`(`absent_date`, `courseoffering_id`, `remarks_cd`, `enc_date`, `encoder`,`checker`,`status`,`report_status`) VALUES('" & inputdate.ToString("yyyy-MM-dd") & "'," & courseofferingid & ",'" & remark_cd & "','" & currentdate.ToString("yyyy-MM-dd") & "','" & encoder & "','" & checker & "','A','" & stat & "');")
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AddCourse(facultyid As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of Object)()
        Dim fac As Integer
        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.getMultipleData("SELECT DISTINCT(c.course_cd) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.course_id = c.course_id;", "course_cd")

            For j As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(j))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddSection(facultyid As String, course As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim fac As String
        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.getMultipleData("SELECT DISTINCT(co.section) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND c.course_cd = '" & course & "';", "section")

            For j As Integer = 0 To section.Count - 1
                combo.Items.Add(section(j))
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddSched(facultyid As String, course As String, section As String, ByVal TimeStart As TextBox, ByVal TimeEnd As TextBox, ByVal DaySched As TextBox)
        Dim starttime As String
        Dim endtime As String
        Dim fac As String
        Dim sched As String = ""
        MsgBox("Pasok")
        Try
            fac = dbAccess.getData("select facref_no from faculty where facultyid = '" & facultyid & "' and status = 'A';", "facref_no").ToString
            MsgBox("fac: " + fac)
            MsgBox("course: " + course)
            starttime = dbAccess.getData("SELECT co.timestart FROM introse.courseoffering as co, introse.course as c WHERE co.status = 'A' AND c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "';", "timestart").ToString()
            'MsgBox("starttime: " + starttime)
            MsgBox("Pasok2")
            endtime = dbAccess.getData("SELECT co.timeend FROM courseoffering as co, course as c WHERE c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "' AND co.status = 'A';", "timeend").ToString()
            'MsgBox("endtime: " + endtime)
            sched = dbAccess.getData("SELECT co.daysched FROM courseoffering as co, course as c WHERE c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "' AND co.status = 'A';", "daysched")
            'MsgBox("sched: " + sched)

            TimeStart.Text = starttime
            TimeEnd.Text = endtime
            DaySched.Text = sched
        Catch ex As Exception

        End Try

    End Sub
    Private Sub AddFacultyName(facultyid As String, ByVal text As TextBox)
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

            text.Text = fname + " " + MI + " " + lname

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        SetAttendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, "unknown", txtbxChecker.Text, txtbxFacID, cmbbxRemarks, "Pending")

        dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' , a.checker 'Checker'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)
        Me.Close()
    End Sub
    Private Function checkEntry(absent As String, courseofferingid As String, stat As String) As Boolean
        '
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
    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub popEndFacDaily_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()
    End Sub

    Private Sub popEncFacDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bttnAdd.Enabled = False
        bttnAddClear.Enabled = False
    End Sub

    Private Sub TextBox100_TextChanged(sender As Object, e As EventArgs) Handles txtbxChecker.TextChanged
        If String.IsNullOrEmpty(txtbxChecker.Text) Then
            bttnAdd.Enabled = False
            bttnAddClear.Enabled = False
        Else
            bttnAdd.Enabled = True
            bttnAddClear.Enabled = True
        End If

    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        cmbbxCourse.Items.Clear()
        cmbbxCourse.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        cmbbxRemarks.Items.Clear()
        cmbbxRemarks.ResetText()

        AddFacultyName(txtbxFacID.Text, txtbxName)
        AddCourse(txtbxFacID.Text, cmbbxCourse)

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()

        AddSection(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSection)
    End Sub

    Private Sub cmbbxSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSection.SelectedIndexChanged
        AddRoom(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem.ToString, txtbxRoom)
        AddSched(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, txtbxStart, txtbxEnd, txtbxDay)
        AddRemarks(cmbbxRemarks)
    End Sub

    Private Sub cmbbxRemarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxRemarks.SelectedIndexChanged

    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        SetAttendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, "unknown", txtbxChecker.Text, txtbxFacID, cmbbxRemarks, "Pending")

        dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' , a.checker 'Checker'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)
        txtbxFacID.Clear()
    End Sub

    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        validateInput("abcdefghijgklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", e)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class