﻿Public Class popEncFacDaily
    Dim dbAccess As New databaseAccessor

    Private Sub popEncFacDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.Value = wdwDailyAttendanceLog.getDTPValue()
        Add_Remarks(cmbbxRemarks)
        Check_Enable()
        Check_Element_Enable()

    End Sub

    Private Sub Add_Faculty_Name(facultyId As String, ByVal text As TextBox)
        Dim facName As New List(Of Object)
        Dim fname As String
        Dim MI As String
        Dim lname As String
        Dim name As String

        name = Nothing
        fname = Nothing
        MI = Nothing
        lname = Nothing
        Try
            facName = dbAccess.Get_Multiple_Column_Data("select f_firstname, f_middlename, f_lastname from faculty where status = 'A' and facultyid = '" & facultyId & "';", 3)

            If facName.Count > 0 Then
                fname = facName(0).ToString
                MI = facName(1).ToString
                lname = facName(2).ToString
            End If

            If (Not (String.IsNullOrEmpty(fname)) Or Not (String.IsNullOrWhiteSpace(fname))) Then
                text.Text = fname + " " + MI + " " + lname
                dtp.Enabled = True
                cmbbxCourse.Enabled = True

            Else
                text.Text = Nothing
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Add_Course(facultyId As String, ByVal combo As ComboBox)
        Dim courseCode As New List(Of Object)()
        Dim fac As Integer
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            courseCode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) 
                                                   from introse.course c, introse.courseoffering co 
                                                   where co.status = 'A' and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;")

            For ctr As Integer = 0 To courseCode.Count - 1
                combo.Items.Add(courseCode(ctr))
            Next

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Add_Section(facultyId As String, course As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) 
                                                from introse.course c, introse.courseoffering co 
                                                where co.status = 'A' and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "' order by 1;")

            For ctr As Integer = 0 To section.Count - 1
                combo.Items.Add(section(ctr))
            Next

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

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
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Fill_Room(facultyId As String, course As String, section As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            room = dbAccess.Get_Data("select co.room from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "'  and co.section = '" & section & "';", "room")
            text.Text = room

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Fill_Sched(facultyId As String, course As String, section As String, ByVal timeStart As TextBox, ByVal timeEnd As TextBox, ByVal daySched As TextBox)
        Dim courseSched As New List(Of Object)
        Dim startTime As String
        Dim endTime As String
        Dim fac As String
        Dim sched As String = ""

        Try
            fac = dbAccess.Get_Data("select facref_no from faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            courseSched = dbAccess.Get_Multiple_Column_Data("select co.timestart, co.timeend, co.daysched from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", 3)
            startTime = courseSched(0)
            endTime = courseSched(1)
            sched = courseSched(2)

            timeStart.Text = starttime
            timeEnd.Text = endTime
            daySched.Text = sched

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub TextBox100_TextChanged(sender As Object, e As EventArgs) Handles txtbxChecker.TextChanged
        Check_Enable()

    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        txtbxName.Clear()
        cmbbxCourse.Items.Clear()
        cmbbxSection.Items.Clear()
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

    Private Function Check_Entry(absent As String, courseOfferingId As String, stat As String) As Boolean
        Dim att As String = ""
        Dim bool As Boolean = False
        att = dbAccess.Get_Data("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseOfferingId & "' and status = '" & stat & "';", "attendanceid")

        If String.IsNullOrEmpty(att) Then
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

    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        Validate_Input("0123456789", e)

    End Sub

    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        Validate_Input("abcdefghijgklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ", e)

    End Sub

    Private Sub Check_Enable()
        If String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(txtbxName.Text) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or String.IsNullOrEmpty(txtbxChecker.Text) Then
            bttnAdd.Enabled = False
            bttnAddClear.Enabled = False

        Else
            bttnAdd.Enabled = True
            bttnAddClear.Enabled = True

        End If

    End Sub

    Private Sub Check_Element_Enable()
        If String.IsNullOrEmpty(txtbxName.Text) Then
            cmbbxCourse.Enabled = False
            cmbbxSection.Enabled = False
            dtp.Enabled = False
            cmbbxRemarks.SelectedIndex = -1
            cmbbxRemarks.Enabled = False

        End If

    End Sub

    Private Function Set_Attendance(facultyId As String, course As String, section As String, remark As String, inputDate As Date, encoder As String, checker As String, ByVal text As TextBox, ByVal combo As ComboBox, days As String, stat As String) As Boolean
        Dim courseId As String = ""
        Dim courseOfferingId As String = ""
        Dim fac As String = ""
        Dim currentDate As Date
        Dim remarkCd As String = ""
        Dim daySched As New List(Of String)
        Dim tempBool As Boolean = False
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

        If (text.Text.Length = 0 Or String.IsNullOrEmpty(combo.Text) Or String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(remark) Or String.IsNullOrEmpty(checker)) Then
            MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
            Return False

        ElseIf Not (tempBool) Then
            MsgBox("Absent date does not match class schedule!", MsgBoxStyle.Critical, "")
            Return False

        Else
            Try
                courseId = dbAccess.Get_Data("select course_id from introse.course where course_cd ='" & course & "';", "course_id")
                fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
                courseOfferingId = dbAccess.Get_Data("select courseoffering_id from introse.courseoffering  where status = 'A' and course_id = " & courseId & " and facref_no = '" & fac & "' and section = '" & section & "';", "courseoffering_id")
                remarkCd = dbAccess.Get_Data("select remark_cd from introse.remarks where remark_des = '" & remark & "';", "remark_cd")
                If (Check_Entry(inputDate.ToString("yyyy-MM-dd"), courseofferingid, "A") = True) Then
                    dbAccess.Add_Data("insert into `attendance`(`absent_date`, `courseoffering_id`, `remarks_cd`, `enc_date`, `encoder`,`checker`,`status`,`report_status`) values('" & inputDate.ToString("yyyy-MM-dd") & "'," & courseOfferingId & ",'" & remarkCd & "','" & currentDate.ToString("yyyy-MM-dd") & "','" & encoder & "','" & checker & "','A','" & stat & "');")
                    Return True
                End If

            Catch ex As Exception
                Return False

            End Try

        End If

        Return False

    End Function

    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, wdwLogin.Get_Encoder, txtbxChecker.Text, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            Me.Close()
        End If

    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, wdwLogin.Get_Encoder, txtbxChecker.Text, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            txtbxFacID.Clear()
            cmbbxRemarks.SelectedIndex = -1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub popEndFacDaily_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()

    End Sub

End Class