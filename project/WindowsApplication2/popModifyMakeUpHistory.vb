Public Class popModifyMakeUpHistory
    Dim dbAccess As New databaseAccessor
    Dim bool As Boolean = False

    Private Sub Check_Enable()
        If (String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrWhiteSpace(txtbxFacID.Text)) Or (String.IsNullOrEmpty(txtbxFacName.Text) Or String.IsNullOrWhiteSpace(txtbxFacName.Text)) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSec.SelectedIndex = -1 Or cmbbxTerm.SelectedIndex = -1 Or cmbbxSY.SelectedIndex = -1 Or (String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrWhiteSpace(txtbxRoom.Text)) Or (String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrWhiteSpace(txtbxStart.Text)) Or (String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrWhiteSpace(txtbxEnd.Text)) Or cmbbxReason.SelectedIndex = -1 Then
            bttnAdd.Enabled = False
        Else
            bttnAdd.Enabled = True
        End If

    End Sub
    Private Function Check_Entry(makeup As String, startTime As Integer, endTime As Integer, room As String, stat As String, courseOfferingId As String, reason As String) As Boolean
        Dim makeupCheck As String = ""
        Dim b As Boolean = False

        makeupCheck = dbAccess.Get_Data("select makeupid
                                         from introse.makeup
                                         where status = '" & stat & "' and courseoffering_id = " & courseOfferingId & " and makeup_date = '" & makeup & "' and timestart = " & startTime & " and timeend = " & endTime & " and room = '" & room & "' and reason_cd = '" & reason & "';", "makeupid")
        If String.IsNullOrEmpty(makeupCheck) Then
            b = True
        Else
            MsgBox("Duplicate makeup class entry!", MsgBoxStyle.Critical, "")
        End If
        Return b

    End Function
    Private Sub Check_Element_Enable()
        If String.IsNullOrEmpty(txtbxFacName.Text) Then
            cmbbxSY.Enabled = False
            cmbbxTerm.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSec.Enabled = False
            dtp.Enabled = False
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStart.Enabled = False
            txtbxEnd.Enabled = False

        End If
        If cmbbxSY.SelectedIndex = -1 Or cmbbxTerm.Items.Count = 0 Then
            cmbbxTerm.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSec.Enabled = False
            dtp.Enabled = False
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStart.Enabled = False
            txtbxEnd.Enabled = False
        End If

        If cmbbxTerm.SelectedIndex = -1 Or cmbbxCourse.Items.Count = 0 Then
            dtp.Enabled = False
            cmbbxCourse.Enabled = False
            cmbbxSec.Enabled = False
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStart.Enabled = False
            txtbxEnd.Enabled = False
        End If

        If cmbbxCourse.SelectedIndex = -1 Or cmbbxSec.Items.Count = 0 Then
            cmbbxSec.Enabled = False
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            'txtbxRoom.Enabled = False
            'txtbxStart.Enabled = False
            'txtbxEnd.Enabled = False
        End If

        If cmbbxSec.SelectedIndex = -1 Then
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            'txtbxRoom.Enabled = False
            'txtbxStart.Enabled = False
            'txtbxEnd.Enabled = False
        End If

    End Sub
    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Function get_termindex(termno As String) As Integer
        Dim index As Integer = 0

        index = Convert.ToInt32(termno) - 1

        Return index
    End Function

    Public Sub Load_Form(rowData As List(Of String))
        Dim convertedDate As Date
        Dim day, month, year As String
        Dim info As New List(Of Object)

        info = dbAccess.Get_Multiple_Column_Data("select f.facultyid, concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename), co.college_name, d.departmentname, m.timestart, m.timeend, m.room, r.reason_des, m.enc_date, m.encoder 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reasons r, introse.department d, introse.college co
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and f.departmentid = d.departmentid and d.college_code = co.college_code and (c.status = 'A' or c.status = 'R') and (m.status = 'A' or m.status = 'R') and m.makeupid = '" & wdwAttendanceHistoryLog.getRefNo & "';", "10")

        Add_Reasons(cmbbxReason)
        Add_SchoolYear(cmbbxSY)
        Add_Term(rowData(1), cmbbxTerm)
        Add_Course(info(0), rowData(1), rowData(2), cmbbxCourse)
        Add_Section(info(0), rowData(4), rowData(1), rowData(2), cmbbxSec)
        If rowData.Count > 0 Then

            If String.IsNullOrEmpty(rowData(3)) Then

                txtbxFacID.Text = info(0) ' fid
                Add_Faculty_Name(txtbxFacID.Text, txtbxFacName)
                cmbbxSY.SelectedItem = rowData(1)
                cmbbxCourse.SelectedItem = rowData(4) ' course
                If bool = False Then
                    cmbbxTerm.SelectedIndex = get_termindex(rowData(2))
                    cmbbxSec.SelectedItem = rowData(5) ' section
                    bool = True
                End If
                txtbxStart.Text = info(4) 'start
                txtbxEnd.Text = info(5) ' end
                txtbxRoom.Text = info(6) ' room
                cmbbxReason.SelectedItem = info(7)

            Else
                convertedDate = Convert.ToDateTime(rowData(3))
                day = convertedDate.Day.ToString()
                month = convertedDate.Month.ToString()
                year = convertedDate.Year.ToString()

                txtbxFacID.Text = info(0) ' fid
                Add_Faculty_Name(txtbxFacID.Text, txtbxFacName)
                cmbbxSY.SelectedItem = rowData(1)
                cmbbxCourse.SelectedItem = rowData(4) ' course
                If bool = False Then
                    cmbbxTerm.SelectedIndex = get_termindex(rowData(2))
                    cmbbxSec.SelectedItem = rowData(5) ' section
                    bool = True
                End If

                txtbxStart.Text = info(4) 'start
                txtbxEnd.Text = info(5) ' end
                txtbxRoom.Text = info(6) ' room
                cmbbxReason.SelectedItem = info(7)

                dtp.Value = New Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))

            End If
        End If

        Me.Show()
    End Sub

    Private Sub Add_Faculty_Name(facultyid As String, ByVal text As TextBox)
        Dim facName As New List(Of Object)
        Dim fname As String
        Dim MI As String
        Dim lname As String
        Dim name As String

        name = ""
        fname = ""
        MI = ""
        lname = ""
        Try

            facName = dbAccess.Get_Multiple_Column_Data("select f_firstname, f_middlename, f_lastname from faculty where status = 'A' and facultyid = '" & facultyid & "';", 3)
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
        Dim termno As New List(Of Object)()
        Dim yearid As New Object
        Dim years() As String
        combo.Enabled = True
        combo.Items.Clear()
        'combo.ResetText()
        Try
            years = schoolYear.Split("-")
            yearid = dbAccess.Get_Data("select yearid from introse.academicyear where yearstart = '" & years(0) & "' and yearend = '" & years(1) & "';", "yearid")
            termno = dbAccess.Get_Multiple_Row_Data("select term_no from introse.term where status = 'A' and yearid = '" & yearid & "';")

            For j As Integer = 0 To termno.Count - 1
                combo.Items.Add(termno(j))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Add_SchoolYear(ByVal combo As ComboBox)

        Dim schoolyear As New List(Of Object)()
        combo.Items.Clear()
        'combo.ResetText()

        Try

            schoolyear = dbAccess.Get_Multiple_Row_Data("select concat(yearstart, '-', yearend) from introse.academicyear;")

            For j As Integer = 0 To schoolyear.Count - 1
                combo.Items.Add(schoolyear(j))
            Next
        Catch ex As Exception
        End Try

    End Sub
    Private Function Get_termID(schoolYear As String, termNo As String) As Object
        Dim termid As New Object()
        Dim years() As String

        Try
            years = schoolYear.Split("-")
            termid = dbAccess.Get_Data("select t.termid from introse.term t, introse.academicyear a where t.status = 'A' and t.yearid = a.yearid and t.term_no = '" & termNo & "' and  a.yearstart = '" & years(0) & "' and a.yearend = '" & years(1) & "';", "termid")
        Catch ex As Exception

        End Try

        Return termid
    End Function
    Private Sub Add_Course(facultyid As String, schoolYear As String, termNo As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of Object)()
        Dim termid As Object
        Dim fac As Integer
        combo.Enabled = True
        combo.Items.Clear()
        'combo.ResetText()
        Try
            termid = Get_termID(schoolYear, termNo)

            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) from introse.course c, introse.courseoffering co where (co.status = 'A' or co.status = 'R') and co.facref_no = '" & fac & "' and co.course_id = c.course_id and co.termid = '" & termid & "' order by 1;")

            For j As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(j))
            Next
            dtp.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Section(facultyid As String, course As String, schoolYear As String, termNo As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim termid As Object
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()
        'combo.ResetText()
        Try
            termid = Get_termID(schoolYear, termNo)
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) from introse.course c, introse.courseoffering co WHERE (co.status = 'A' or co.status = 'R') and co.facref_no = '" & fac & "' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.termid = '" & termid & "' order by 1;")

            For j As Integer = 0 To section.Count - 1
                combo.Items.Add(section(j))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Reasons(ByVal combo As ComboBox)
        Dim reasons As New List(Of Object)()
        combo.Items.Clear()

        Try
            reasons = dbAccess.Get_Multiple_Row_Data("select reason_des from introse.reasons order by 1;")

            For ctr As Integer = 0 To reasons.Count - 1
                combo.Items.Add(reasons(ctr))
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbbxSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSY.SelectedIndexChanged
        If bool = True Then
            cmbbxTerm.Items.Clear()
            cmbbxTerm.ResetText()
            cmbbxCourse.Items.Clear()
            cmbbxCourse.ResetText()
            cmbbxSec.Items.Clear()
            cmbbxSec.ResetText()
            'txtbxEnd.Clear()
            'txtbxStart.Clear()
            'txtbxRoom.Clear()
            Try
                If (String.IsNullOrEmpty(cmbbxSY.SelectedItem)) Then
                    cmbbxTerm.Enabled = False
                Else
                    cmbbxTerm.Enabled = True
                End If

                Add_Term(cmbbxSY.SelectedItem, cmbbxTerm)
            Catch ex As Exception

            End Try
            cmbbxReason.SelectedIndex = -1
            Check_Element_Enable()
            Check_Enable()
        End If

    End Sub
    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        If bool = True Then
            cmbbxCourse.Items.Clear()
            cmbbxCourse.ResetText()
            cmbbxSec.Items.Clear()
            cmbbxSec.ResetText()
            'txtbxEnd.Clear()
            'txtbxStart.Clear()
            'txtbxRoom.Clear()
            Try
                If (String.IsNullOrEmpty(cmbbxTerm.SelectedItem)) Then
                    cmbbxCourse.Enabled = False
                Else
                    cmbbxCourse.Enabled = True
                End If
                Add_Course(txtbxFacID.Text, cmbbxSY.SelectedItem, cmbbxTerm.SelectedItem, cmbbxCourse)

            Catch ex As Exception

            End Try

            cmbbxReason.SelectedIndex = -1
            Check_Element_Enable()
            Check_Enable()
        End If

    End Sub
    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        If bool = True Then
            cmbbxSec.Items.Clear()
            cmbbxSec.ResetText()
            'txtbxEnd.Clear()
            'txtbxStart.Clear()
            'txtbxRoom.Clear()
            Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSY.SelectedItem, cmbbxTerm.SelectedItem, cmbbxSec)
            cmbbxReason.SelectedIndex = -1
            Check_Element_Enable()
            Check_Enable()

        End If

    End Sub

    Private Sub cmbbxSec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSec.SelectedIndexChanged
        txtbxRoom.Enabled = True
        txtbxStart.Enabled = True
        txtbxEnd.Enabled = True
        cmbbxReason.Enabled = True
        cmbbxReason.SelectedIndex = -1
        Check_Element_Enable()
        Check_Enable()

    End Sub
    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStart.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxEnd.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxRoom.KeyPress
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", e)
    End Sub

    Private Sub txtEncoder_KeyPress(sender As Object, e As KeyPressEventArgs)
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", e)
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub txtbxRoom_TextChanged(sender As Object, e As EventArgs) Handles txtbxRoom.TextChanged
        Check_Enable()
    End Sub

    Private Sub txtbxStart_TextChanged(sender As Object, e As EventArgs) Handles txtbxStart.TextChanged
        Check_Enable()
    End Sub

    Private Sub txtbxEnd_TextChanged(sender As Object, e As EventArgs) Handles txtbxEnd.TextChanged
        Check_Enable()
    End Sub

    Private Sub cmbReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxReason.SelectedIndexChanged
        Check_Enable()
    End Sub

    Private Sub popModifyMakeUpHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub popModifyMakeUpHistory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_After_Search_Form()
    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim makeupDate, course, section, room, reason, courseOfferingId, attstatus As String
        Dim startTime, endTime, tempStart, tempEnd As Integer
        Dim termid As Object

        Try
            termid = Get_termID(cmbbxSY.SelectedItem, cmbbxTerm.SelectedItem)

            Dim absentHours As Double = dbAccess.Get_Data("select sum(co.hours) 
                                                      from introse.attendance a, introse.courseoffering co, introse.course c
                                                      where co.termid = '" & termid & "' and (co.status = 'A' or co.status = 'R') And (a.status = 'A' or a.status = 'R') And c.course_cd = '" & cmbbxCourse.SelectedItem & "' And c.course_id = co.course_id And co.section = '" & cmbbxSec.SelectedItem & "' And a.courseoffering_id = co.courseoffering_id;", "sum(co.hours)")
            Dim ref = wdwAttendanceHistoryLog.getRefNo()

            If Convert.ToInt32(ref) > 0 Then
                If String.IsNullOrEmpty(cmbbxSY.Text) Or String.IsNullOrEmpty(cmbbxTerm.Text) Or String.IsNullOrEmpty(cmbbxReason.Text) Or String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrEmpty(dtp.Value.Date.ToString("yyyy-MM-dd")) Then
                    MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
                Else
                    Dim wholeNumber As Integer
                    startTime = Convert.ToInt32(txtbxStart.Text)
                    endTime = Convert.ToInt32(txtbxEnd.Text)
                    tempStart = startTime
                    tempEnd = endTime
                    If ((tempStart Mod 100) > tempEnd Mod 100) Then
                        Dim tempMinutes As Integer = startTime Mod 100
                        tempStart -= tempMinutes
                        tempEnd -= (tempMinutes + 40)
                    End If

                    wholeNumber = (tempEnd - tempStart) / 100

                    If ((startTime < 0 Or startTime > 2359) Or (startTime / 100 > 24 Or startTime Mod 100 > 59)) Then
                        MsgBox("Invalid start time input!", MsgBoxStyle.Critical, "")
                    ElseIf ((endTime < 0 Or endTime > 2359) Or (endTime / 100 > 24 Or endTime Mod 100 > 59)) Then
                        MsgBox("Invalid end time input!", MsgBoxStyle.Critical, "")
                    ElseIf (startTime > endTime) Then
                        MsgBox("Start Time cannot be ahead of End Time!", MsgBoxStyle.Critical, "")
                    ElseIf (startTime = endTime) Then
                        MsgBox("Start and end time cannot be at the same time!", MsgBoxStyle.Critical, "")
                    ElseIf (Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = .0) Or Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = 0.5)) Then
                        MsgBox("Makeup hours is not exact!", MsgBoxStyle.Critical, "")
                    Else
                        makeupDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                        course = cmbbxCourse.SelectedItem
                        section = cmbbxSec.SelectedItem
                        room = txtbxRoom.Text
                        reason = dbAccess.Get_Data("select reason_cd from introse.reasons where reason_des = '" & cmbbxReason.SelectedItem.ToString & "';", "reason_cd")
                        courseOfferingId = dbAccess.Get_Data("select courseoffering_id 
                                                            from introse.courseoffering c, introse.course cl 
                                                            where c.termid = '" & termid & "' and (c.status = 'A' or c.status = 'R') and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "';", "courseoffering_id")
                        attstatus = dbAccess.Get_Data("select status from introse.courseoffering where courseoffering_id = '" & courseOfferingId & "';", "status")

                        If (Check_Entry(makeupDate, startTime, endTime, room, "A", courseOfferingId, reason) And Check_Entry(makeupDate, startTime, endTime, room, "R", courseOfferingId, reason)) Then
                            dbAccess.Update_Data("update `introse`.`makeup` set `courseoffering_id` = " & courseOfferingId & ", `timestart` = " & txtbxStart.Text & ", `timeend` = " & txtbxEnd.Text & ", `hours` = " & (wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) & ", `room` = '" & room & "', `reason_cd` = '" & reason & "', `makeup_date` = '" & makeupDate & "', `enc_date` = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "', `encoder` =  '" & wdwLogin.Get_Encoder & "' WHERE makeupid = '" & ref & "' and status = '" & attstatus & "';")
                            wdwAttendanceHistoryLog.Load_form(wdwAttendanceHistoryLog.facultyID)
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class