Public Class popAddAttendanceHistory
    Dim dbAccess As New databaseAccessor
    Public Sub Load_Form(id As String)
        If Check_Fac(id) Then
            txtbxFacID.Text = id
        End If
    End Sub
    Private Function Check_Fac(id As String) As Boolean
        Dim checkFac As Boolean = False
        Dim fac As New Object
        fac = dbAccess.Get_Data("select facref_no from introse.faculty where facultyid = '" & id & "';", "facref_no")
        If String.IsNullOrEmpty(fac) Then
            checkFac = False
            MsgBox("No records matched!", MsgBoxStyle.Critical, "")
        Else
            checkFac = True
        End If
        Return checkFac
    End Function
    Private Function Check_Entry(absent As String, courseOfferingId As String, stat As String) As Boolean
        Dim attId As String = ""
        Dim bool As Boolean = False
        attId = dbAccess.Get_Data("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseOfferingId & "' and status = '" & stat & "';", "attendanceid")
        If String.IsNullOrEmpty(attId) Then
            bool = True
        Else
            MsgBox("Duplicate attendance!", MsgBoxStyle.Critical, "")
        End If
        Return bool

    End Function
    Private Sub Validate_Input(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub Add_Remarks(ByVal combo As ComboBox)
        Dim remarks As New List(Of Object)()
        combo.Items.Clear()
        combo.ResetText()

        Try
            remarks = dbAccess.Get_Multiple_Row_Data("select remark_des from introse.remarks order by 1;")

            For ctr As Integer = 0 To remarks.Count - 1
                combo.Items.Add(remarks(ctr))
            Next

        Catch ex As Exception
        End Try

    End Sub
    Private Sub Add_Faculty_Name(facultyId As String, ByVal text As TextBox)
        Dim facName As New List(Of Object)
        Dim fname As String
        Dim MI As String
        Dim lname As String

        fname = ""
        MI = ""
        lname = ""
        Try

            facName = dbAccess.Get_Multiple_Column_Data("select f_firstname, f_middlename, f_lastname from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", 3)
            If facName.Count > 0 Then
                fname = facName(0).ToString
                MI = facName(1).ToString
                lname = facName(2).ToString
            End If

            If (Not (String.IsNullOrEmpty(fname)) Or Not (String.IsNullOrWhiteSpace(fname))) Then
                text.Text = fname + " " + MI + " " + lname
                cmbbxSY.Enabled = True
            Else
                text.Text = fname + " " + MI + " " + lname
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Add_Term(schoolYear As String, ByVal combo As ComboBox)
        Dim termNo As New List(Of Object)()
        Dim yearId As New Object
        Dim years() As String
        combo.Enabled = True
        combo.Items.Clear()
        combo.ResetText()

        Try
            years = schoolYear.Split("-")
            yearId = dbAccess.Get_Data("select yearid from introse.academicyear where yearstart = '" & years(0) & "' and yearend = '" & years(1) & "';", "yearid")
            termNo = dbAccess.Get_Multiple_Row_Data("select term_no from introse.term where status = 'A' and yearid = '" & yearId & "';")

            For ctr As Integer = 0 To termNo.Count - 1
                combo.Items.Add(termNo(ctr))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Add_SchoolYear(ByVal combo As ComboBox)

        Dim schoolYear As New List(Of Object)()
        combo.Enabled = True
        combo.Items.Clear()
        combo.ResetText()

        Try

            schoolYear = dbAccess.Get_Multiple_Row_Data("select concat(yearstart, '-', yearend) from introse.academicyear;")

            For ctr As Integer = 0 To schoolYear.Count - 1
                combo.Items.Add(schoolYear(ctr))
            Next
        Catch ex As Exception
        End Try

    End Sub
    Private Function Get_TermID(schoolYear As String, termNo As String) As Object
        Dim termId As New Object()
        Dim years() As String

        Try

            years = schoolYear.Split("-")
            termId = dbAccess.Get_Data("select t.termid from introse.term t, introse.academicyear a where t.status = 'A' and t.yearid = a.yearid and t.term_no = '" & termNo & "' and  a.yearstart = '" & years(0) & "' and a.yearend = '" & years(1) & "';", "termid")
        Catch ex As Exception

        End Try

        Return termId
    End Function
    Private Sub Add_Course(facultyId As String, schoolYear As String, termNo As String, ByVal combo As ComboBox)
        Dim courseCode As New List(Of Object)()
        Dim termId As Object
        Dim fac As Integer
        combo.Enabled = True
        combo.Items.Clear()
        combo.ResetText()

        Try
            termId = Get_TermID(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            courseCode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) from introse.course c, introse.courseoffering co where (co.status = 'A' or co.status = 'R') and co.facref_no = '" & fac & "' and co.course_id = c.course_id and co.termid = '" & termId & "' order by 1;")

            For ctr As Integer = 0 To courseCode.Count - 1
                combo.Items.Add(courseCode(ctr))
            Next
            dtp.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Section(facultyId As String, course As String, schoolYear As String, termNo As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim termId As Object
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()
        combo.ResetText()

        Try
            termId = Get_TermID(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) from introse.course c, introse.courseoffering co where (co.status = 'A' or co.status = 'R') and co.facref_no = '" & fac & "' and c.course_cd = '" & course & "' and co.termid = '" & termId & "'  and co.course_id = c.course_id order by 1;")

            For j As Integer = 0 To section.Count - 1
                combo.Items.Add(section(j))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Fill_Room(facultyId As String, course As String, section As String, schoolYear As String, termNo As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Dim termId As Object
        Try
            termId = Get_TermID(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            room = dbAccess.Get_Data("select co.room from introse.courseoffering co, introse.course c where (co.status = 'A' or co.status = 'R') and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "'  and co.section = '" & section & "' and co.termid = '" & termId & "';", "room")

            text.Text = room
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Fill_Sched(facultyId As String, course As String, section As String, schoolYear As String, termNo As String, ByVal timeStart As TextBox, ByVal timeEnd As TextBox, ByVal daySched As TextBox)
        Dim courseSched As New List(Of Object)
        Dim startTime As String
        Dim endTime As String
        Dim fac As String
        Dim sched As String = ""
        Dim termId As Object
        Try
            termId = Get_TermID(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            courseSched = dbAccess.Get_Multiple_Column_Data("select co.timestart, co.timeend, co.daysched from introse.courseoffering co, introse.course c where (co.status = 'A' or co.status = 'R') and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.termid = '" & termId & "' and co.section = '" & section & "';", 3)
            startTime = courseSched(0)
            endTime = courseSched(1)
            sched = courseSched(2)

            timeStart.Text = startTime
            timeEnd.Text = endTime
            daySched.Text = sched
        Catch ex As Exception

        End Try

    End Sub
    Private Function Set_Attendance(facultyId As String, course As String, section As String, remark As String, inputDate As Date, encoder As String, checker As String, schoolYear As String, termNo As String, ByVal text As TextBox, ByVal combo As ComboBox, days As String, stat As String) As Boolean
        Dim courseId As String = ""
        Dim courseOfferingId As String = ""
        Dim fac As String = ""
        Dim currentDate As Date
        Dim remarkCd As String = ""
        Dim daySched As New List(Of String)
        Dim tempBool As Boolean = False
        Dim termId As Object
        Dim attStatus As Char = ""

        Try
            currentDate = DateTime.Now.Date

            If days.Contains("M") Then
                daySched.Add("Monday")
            End If
            If days.Contains("T") Then
                daySched.Add("Tuesday")
            End If
            If days.Contains("W") Then
                daySched.Add("Wednesday")
            End If
            If days.Contains("H") Then
                daySched.Add("Thursday")
            End If
            If days.Contains("F") Then
                daySched.Add("Friday")
            End If
            If days.Contains("S") Then
                daySched.Add("Saturday")
            End If

            For ctr As Integer = 0 To daySched.Count - 1
                If (daySched(ctr) = inputDate.DayOfWeek.ToString) Then
                    tempBool = True
                End If
            Next

            If (text.Text.Length = 0 Or String.IsNullOrEmpty(section) Or String.IsNullOrEmpty(schoolYear) Or String.IsNullOrEmpty(termNo) Or String.IsNullOrEmpty(inputDate.ToString("yyyy-MM-dd")) Or String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(remark) Or String.IsNullOrEmpty(checker)) Then
                MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
                Return False
            ElseIf Not (tempBool) Then
                MsgBox("Absent date does not match class schedule!", MsgBoxStyle.Critical, "")
                Return False
            Else

                courseId = dbAccess.Get_Data("select course_id from introse.course where course_cd ='" & course & "';", "course_id")
                fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
                termId = Get_TermID(schoolYear, termNo)
                courseOfferingId = dbAccess.Get_Data("select courseoffering_id from introse.courseoffering  where (status = 'A' or status = 'R') and course_id = " & courseId & " and facref_no = '" & fac & "' and section = '" & section & "' and termid = '" & termId & "';", "courseoffering_id")
                attStatus = dbAccess.Get_Data("select status from introse.courseoffering where courseoffering_id = '" & courseOfferingId & "';", "status")
                remarkCd = dbAccess.Get_Data("select remark_cd from introse.remarks where remark_des = '" & remark & "';", "remark_cd")
                If (Check_Entry(inputDate.ToString("yyyy-MM-dd"), courseOfferingId, "A") = True And Check_Entry(inputDate.ToString("yyyy-MM-dd"), courseOfferingId, "R") = True) Then
                    dbAccess.Add_Data("INSERT INTO `introse`.`attendance`(`absent_date`, `courseoffering_id`, `remarks_cd`, `enc_date`, `encoder`,`checker`,`status`,`report_status`) values ('" & inputDate.ToString("yyyy-MM-dd") & "'," & courseOfferingId & ",'" & remarkCd & "','" & currentDate.ToString("yyyy-MM-dd") & "','" & encoder & "','" & checker & "','" & attStatus & "','" & stat & "');")
                    Return True
                End If

            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Private Sub Check_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(txtbxName.Text) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSY.SelectedIndex = -1 Or cmbbxTerm.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or String.IsNullOrEmpty(txtbxChecker.Text) Then
            bttnAdd.Enabled = False
            bttnAddClear.Enabled = False

        Else
            bttnAdd.Enabled = True
            bttnAddClear.Enabled = True

        End If

    End Sub
    Private Sub Check_Element_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Then
            cmbbxSY.Enabled = False
            cmbbxTerm.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSection.Enabled = False
            dtp.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False

        End If

        If cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.Items.Count = 0 Then
            cmbbxSection.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False


        End If
        If cmbbxSY.SelectedIndex = -1 Or cmbbxTerm.Items.Count = 0 Then
            dtp.Enabled = False
            cmbbxTerm.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSection.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False

        End If
        If cmbbxTerm.SelectedIndex = -1 Or cmbbxCourse.Items.Count = 0 Then
            dtp.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSection.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False

        End If
        If cmbbxSection.SelectedIndex = -1 Then
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False
        End If
    End Sub
    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        cmbbxSY.Items.Clear()
        cmbbxSY.ResetText()
        cmbbxTerm.Items.Clear()
        cmbbxTerm.ResetText()
        cmbbxCourse.Items.Clear()
        cmbbxCourse.ResetText()
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        txtbxChecker.Clear()
        Add_Faculty_Name(txtbxFacID.Text, txtbxName)
        Add_SchoolYear(cmbbxSY)
        Check_Enable()
        Check_Element_Enable()

    End Sub
    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub TextBox100_TextChanged(sender As Object, e As EventArgs) Handles txtbxChecker.TextChanged
        Check_Enable()
    End Sub
    Private Sub popAddAttendanceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.Value = DateTime.Now.Date
        Add_Remarks(cmbbxRemarks)
        Load_Form(wdwAttendanceHistoryLog.facultyId)
        Check_Enable()
        Check_Element_Enable()
    End Sub

    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        cmbbxCourse.Items.Clear()
        cmbbxCourse.ResetText()
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        Try
            Add_Course(txtbxFacID.Text, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, cmbbxCourse)

        Catch ex As Exception

        End Try

        cmbbxRemarks.SelectedIndex = -1
        Check_Element_Enable()
        Check_Enable()
    End Sub

    Private Sub cmbbxSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSY.SelectedIndexChanged
        cmbbxTerm.Items.Clear()
        cmbbxTerm.ResetText()
        cmbbxCourse.Items.Clear()
        cmbbxCourse.ResetText()
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        txtbxChecker.Clear()
        Try
            Add_Term(cmbbxSY.SelectedItem.ToString, cmbbxTerm)
        Catch ex As Exception

        End Try

        cmbbxRemarks.SelectedIndex = -1
        Check_Element_Enable()
        Check_Enable()
    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        cmbbxSection.Items.Clear()
        cmbbxSection.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxDay.Clear()
        txtbxRoom.Clear()
        Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, cmbbxSection)
        cmbbxRemarks.SelectedIndex = -1
        Check_Element_Enable()
        Check_Enable()
    End Sub
    Private Sub cmbbxSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSection.SelectedIndexChanged
        Fill_Room(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem.ToString, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, txtbxRoom)
        Fill_Sched(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, txtbxStart, txtbxEnd, txtbxDay)
        cmbbxRemarks.Enabled = True
        cmbbxRemarks.SelectedIndex = -1
        Check_Element_Enable()
        Check_Enable()

    End Sub
    Private Sub cmbbxRemarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxRemarks.SelectedIndexChanged
        Check_Enable()
    End Sub
    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        Validate_Input("0123456789", e)

    End Sub

    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        Validate_Input("abcdefghijgklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ", e)

    End Sub
    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, wdwLogin.Get_Encoder, txtbxChecker.Text, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            wdwAttendanceHistoryLog.Load_Form(wdwAttendanceHistoryLog.facultyId)
            Me.Close()

        End If

    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, wdwLogin.Get_Encoder, txtbxChecker.Text, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            cmbbxSY.Items.Clear()
            cmbbxSY.ResetText()
            cmbbxTerm.Items.Clear()
            cmbbxTerm.ResetText()
            cmbbxCourse.Items.Clear()
            cmbbxCourse.ResetText()
            cmbbxSection.Items.Clear()
            cmbbxSection.ResetText()
            txtbxEnd.Clear()
            txtbxStart.Clear()
            txtbxDay.Clear()
            txtbxRoom.Clear()
            txtbxChecker.Clear()
            cmbbxRemarks.Items.Clear()
            cmbbxRemarks.ResetText()
            Add_SchoolYear(cmbbxSY)
            Add_Remarks(cmbbxRemarks)
            Check_Enable()
            Check_Element_Enable()
            wdwAttendanceHistoryLog.Load_Form(wdwAttendanceHistoryLog.facultyId)

        End If

    End Sub

    Private Sub popAddAttendanceHistory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_Only_Form()
    End Sub
End Class