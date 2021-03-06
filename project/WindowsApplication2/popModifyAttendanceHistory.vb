﻿Public Class popModifyAttendanceHistory
    Dim dbAccess As New databaseAccessor
    Dim bool As Boolean = False

    Private Sub popModifyAttendanceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(rowData As List(Of String))
        Dim convertedDate As Date
        Dim day, month, year As String
        Dim info As New List(Of Object)

        info = dbAccess.Get_Multiple_Column_Data("select f.facultyid, concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename), co.college_name, d.departmentname,  c.room, c.daysched, c.timestart, c.timeend, r.remark_des, a.enc_date, a.encoder, a.checker
        from introse.attendance a, introse.courseoffering c, introse.course cl, introse.faculty f, introse.remarks r, introse.department d, introse.college co
        where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and c.facref_no = f.facref_no and c.course_id = cl.course_id and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and a.attendanceid = '" & rowData(0) & "';", "12")

        Add_Remarks(cmbbxRemarks)
        Add_SchoolYear(cmbbxSY)
        Add_Term(rowData(1), cmbbxTerm)
        Add_Course(info(0), rowData(1), rowData(2), cmbbxCourse)
        Add_Section(info(0), rowData(4), rowData(1), rowData(2), cmbbxSection)

        If rowData.Count > 0 Then

            If String.IsNullOrEmpty(rowData(3)) Then
                txtbxFacID.Text = info(0) ' fid
                Add_Faculty_Name(txtbxFacID.Text, txtbxName)
                cmbbxSY.SelectedItem = rowData(1)
                cmbbxCourse.SelectedItem = rowData(4) ' course
                If bool = False Then
                    cmbbxTerm.SelectedIndex = get_termindex(rowData(2))
                    cmbbxSection.SelectedItem = rowData(5) ' section
                    bool = True
                End If
                txtbxRoom.Text = info(4) ' room
                txtbxDay.Text = info(5)
                txtbxStart.Text = info(6) 'start
                txtbxEnd.Text = info(7) ' end
                cmbbxRemarks.SelectedItem = info(8)
                txtbxChecker.Text = info(11)
            Else
                convertedDate = Convert.ToDateTime(rowData(3))
                day = convertedDate.Day.ToString()
                month = convertedDate.Month.ToString()
                year = convertedDate.Year.ToString()

                txtbxFacID.Text = info(0) ' fid
                Add_Faculty_Name(txtbxFacID.Text, txtbxName)
                cmbbxSY.SelectedItem = rowData(1)
                cmbbxCourse.SelectedItem = rowData(4) ' course
                If bool = False Then
                    cmbbxTerm.SelectedIndex = get_termindex(rowData(2))
                    cmbbxSection.SelectedItem = rowData(5) ' section
                    bool = True
                End If
                txtbxRoom.Text = info(4) ' room
                txtbxDay.Text = info(5)
                txtbxStart.Text = info(6) 'start
                txtbxEnd.Text = info(7) ' end
                cmbbxRemarks.SelectedItem = info(8)
                txtbxChecker.Text = info(11)

                dtp.Value = New Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))

            End If
        End If

        Me.Show()

    End Sub
    Private Sub Add_Faculty_Name(facultyId As String, ByVal text As TextBox)
        Dim facName As New List(Of Object)
        Dim fname As String
        Dim MI As String
        Dim lname As String

        fname = Nothing
        MI = Nothing
        lname = Nothing
        Try

            facName = dbAccess.Get_Multiple_Column_Data("select DISTINCT f_firstname, f_middlename, f_lastname from introse.faculty where (status = 'A' or status = 'R') and facultyid = '" & facultyId & "';", 3)
            If facName.Count > 0 Then
                fname = facName(0).ToString
                MI = facName(1).ToString
                lname = facName(2).ToString
            End If

            If (Not (String.IsNullOrEmpty(fname)) Or Not (String.IsNullOrWhiteSpace(fname))) Then
                text.Text = fname + " " + MI + " " + lname
                cmbbxSY.Enabled = True

            Else
                text.Text = Nothing
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

        Try
            years = schoolYear.Split("-")
            yearId = dbAccess.Get_Data("select yearid from introse.academicyear where yearstart = '" & years(0) & "' and yearend = '" & years(1) & "';", "yearid")
            termNo = dbAccess.Get_Multiple_Row_Data("select term_no from introse.term where yearid = '" & yearId & "';")

            For ctr As Integer = 0 To termNo.Count - 1
                combo.Items.Add(termNo(ctr))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Add_SchoolYear(ByVal combo As ComboBox)

        Dim schoolYear As New List(Of Object)()
        combo.Items.Clear()

        Try
            schoolYear = dbAccess.Get_Multiple_Row_Data("select concat(yearstart, '-', yearend) from introse.academicyear;")

            For ctr As Integer = 0 To schoolYear.Count - 1
                combo.Items.Add(schoolYear(ctr))
            Next
        Catch ex As Exception
        End Try

    End Sub
    Private Function Get_TermId(schoolYear As String, termNo As String) As Object
        Dim termId As New Object()
        Dim years() As String

        Try
            years = schoolYear.Split("-")
            termId = dbAccess.Get_Data("select t.termid from introse.term t, introse.academicyear a where t.yearid = a.yearid and t.term_no = '" & termNo & "' and  a.yearstart = '" & years(0) & "' and a.yearend = '" & years(1) & "';", "termid")
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

        Try
            termId = Get_TermId(schoolYear, termNo)
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

        Try
            termId = Get_TermId(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) from introse.course c, introse.courseoffering co where (co.status = 'A' or co.status = 'R') and co.facref_no = '" & fac & "' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.termid = '" & termId & "' order by 1;")

            For ctr As Integer = 0 To section.Count - 1
                combo.Items.Add(section(ctr))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Remarks(ByVal combo As ComboBox)
        Dim remarks As New List(Of Object)()
        combo.Items.Clear()

        Try
            remarks = dbAccess.Get_Multiple_Row_Data("select remark_des from introse.remarks order by 1;")

            For ctr As Integer = 0 To remarks.Count - 1
                combo.Items.Add(remarks(ctr))
            Next

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Fill_Room(facultyId As String, course As String, section As String, schoolYear As String, termNo As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Dim termId As Object
        Try
            termId = Get_TermId(schoolYear, termNo)
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
            termId = Get_TermId(schoolYear, termNo)
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
    Private Sub cmbbxSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSY.SelectedIndexChanged
        If bool = True Then
            cmbbxTerm.Items.Clear()
            cmbbxCourse.Items.Clear()
            cmbbxSection.Items.Clear()
            txtbxEnd.Clear()
            txtbxStart.Clear()
            txtbxDay.Clear()
            txtbxRoom.Clear()
            Try
                If String.IsNullOrEmpty(cmbbxSY.SelectedItem) Then
                    cmbbxTerm.Enabled = False
                Else
                    cmbbxTerm.Enabled = True
                    Add_Term(cmbbxSY.SelectedItem.ToString, cmbbxTerm)
                End If

            Catch ex As Exception

            End Try
            Check_Element_Enable()
            cmbbxRemarks.SelectedIndex = -1
            Check_Enable()
        End If

    End Sub

    Private Sub txtbxChecker_TextChanged(sender As Object, e As EventArgs) Handles txtbxChecker.TextChanged
        Check_Enable()
    End Sub

    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        If bool = True Then

            cmbbxCourse.Items.Clear()
            cmbbxSection.Items.Clear()
            txtbxEnd.Clear()
            txtbxStart.Clear()
            txtbxDay.Clear()
            txtbxRoom.Clear()
            Try
                If (String.IsNullOrEmpty(cmbbxTerm.SelectedItem)) Then
                    cmbbxCourse.Enabled = False
                Else
                    cmbbxCourse.Enabled = True
                    Add_Course(txtbxFacID.Text, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, cmbbxCourse)

                End If

            Catch ex As Exception

            End Try
            Check_Element_Enable()
            cmbbxRemarks.SelectedIndex = -1
            Check_Enable()
        End If

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        If bool = True Then
            cmbbxSection.Items.Clear()
            txtbxEnd.Clear()
            txtbxStart.Clear()
            txtbxDay.Clear()
            txtbxRoom.Clear()
            Try
                If (String.IsNullOrEmpty(cmbbxTerm.SelectedItem)) Then
                    cmbbxSection.Enabled = False
                Else
                    cmbbxSection.Enabled = True
                    Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSY.SelectedItem.ToString, cmbbxTerm.SelectedItem.ToString, cmbbxSection)

                End If

            Catch ex As Exception

            End Try
            Check_Element_Enable()
            cmbbxRemarks.SelectedIndex = -1
            Check_Enable()
        End If

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

    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        Validate_Input("abcdefghijgklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ", e)

    End Sub

    Private Sub Validate_Input(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Function Check_Entry(absent As String, courseOfferingId As String, stat As String, remarks As String, checker As String, ref As Integer) As Boolean
        Dim att As New List(Of Object)()
        Dim b As Boolean = False
        att = dbAccess.Get_Multiple_Row_Data("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseOfferingId & "' and status = '" & stat & "';")

        If att.Count = 0 Then
            b = True

        ElseIf att.Count < 2 Then
            If att(0) = ref Then
                b = True

            Else
                MsgBox("Duplicate attendance entry!", MsgBoxStyle.Critical, "")
            End If

        Else
            MsgBox("Duplicate attendance entry!", MsgBoxStyle.Critical, "")
        End If

        Return b

    End Function

    Private Sub Check_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(txtbxName.Text) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSY.SelectedIndex = -1 Or cmbbxTerm.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or String.IsNullOrEmpty(txtbxChecker.Text) Then
            bttnModify.Enabled = False

        Else
            bttnModify.Enabled = True
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

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim absentDate, schoolYear, termNo, checker, course, section, courseOfferingId, remCode As String
        Dim ref As String = wdwAttendanceHistoryLog.Get_Ref_No()
        Dim currentDate As Date
        currentDate = DateTime.Now.Date
        Dim daySched As New List(Of String)
        Dim tempBool As Boolean = False
        Dim termId As Object
        Dim attStatus As String

        If txtbxDay.Text.Contains("M") Then
            daySched.Add("Monday")
        End If
        If txtbxDay.Text.Contains("T") Then
            daySched.Add("Tuesday")
        End If
        If txtbxDay.Text.Contains("W") Then
            daySched.Add("Wednesday")
        End If
        If txtbxDay.Text.Contains("H") Then
            daySched.Add("Thursday")
        End If
        If txtbxDay.Text.Contains("F") Then
            daySched.Add("Friday")
        End If
        If txtbxDay.Text.Contains("S") Then
            daySched.Add("Saturday")
        End If

        For ctr As Integer = 0 To daySched.Count - 1
            If (daySched(ctr) = dtp.Value.DayOfWeek.ToString) Then
                tempBool = True
            End If
        Next

        If Convert.ToInt32(ref) > 0 Then
            If (txtbxFacID.Text.Length = 0 Or String.IsNullOrEmpty(cmbbxSection.SelectedItem) Or String.IsNullOrEmpty(cmbbxSY.SelectedItem) Or String.IsNullOrEmpty(cmbbxTerm.SelectedItem) Or String.IsNullOrEmpty(dtp.Value.ToString("yyyy-MM-dd")) Or String.IsNullOrEmpty(cmbbxCourse.SelectedItem) Or String.IsNullOrEmpty(cmbbxRemarks.SelectedItem) Or String.IsNullOrEmpty(txtbxChecker.Text)) Then
                MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
            ElseIf Not (tempBool) Then
                MsgBox("Absent date does Not match class schedule!", MsgBoxStyle.Critical, "")
            Else
                absentDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                schoolYear = cmbbxSY.SelectedItem
                termNo = cmbbxTerm.SelectedItem
                course = cmbbxCourse.SelectedItem
                section = cmbbxSection.SelectedItem
                checker = txtbxChecker.Text

                remCode = dbAccess.Get_Data("select remark_cd from introse.remarks where remark_des = '" & cmbbxRemarks.SelectedItem & "';", "remark_cd")
                termId = Get_TermId(schoolYear, termNo)

                courseOfferingId = dbAccess.Get_Data("select courseoffering_id from introse.courseoffering c, introse.course cl where (c.status = 'A' or c.status = 'R') and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.termid = '" & termId & "' and c.section = '" & section & "';", "courseoffering_id")
                attStatus = dbAccess.Get_Data("select status from introse.courseoffering where courseoffering_id = '" & courseOfferingId & "';", "status")

                If (Check_Entry(absentDate, courseOfferingId, "A", remCode, checker, ref) And Check_Entry(absentDate, courseOfferingId, "R", remCode, checker, ref)) Then
                    dbAccess.Update_Data("update `attendance` set `absent_date` = '" & absentDate & "', `courseoffering_id` = '" & courseOfferingId & "', `remarks_cd` = '" & remCode & "', `enc_date` = '" & currentDate.ToString("yyyy-MM-dd") & "', `encoder` = '" & wdwLogin.Get_Encoder & "', `checker` = '" & checker & "', `report_status` = 'Pending' WHERE attendanceid = '" & ref & "' and status = '" & attStatus & "';")
                    wdwAttendanceHistoryLog.Load_Form(wdwAttendanceHistoryLog.facultyId)
                    Me.Close()

                    txtbxFacID.Clear()
                    txtbxName.Clear()
                    cmbbxSY.Items.Clear()
                    cmbbxTerm.Items.Clear()
                    cmbbxCourse.Items.Clear()
                    cmbbxSection.Items.Clear()
                    txtbxRoom.Clear()
                    txtbxDay.Clear()
                    txtbxStart.Clear()
                    txtbxEnd.Clear()
                    txtbxChecker.Clear()

                End If
            End If
        End If

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub


    Private Sub popModifyAttendanceHistory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_Only_Form()

    End Sub

    Private Function get_termindex(termno As String) As Integer
        Dim index As Integer = 0

        index = Convert.ToInt32(termno) - 1

        Return index
    End Function
End Class