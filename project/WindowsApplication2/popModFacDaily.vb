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
            fname = dbAccess.getData("select f_firstname from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "f_firstname")
            MI = dbAccess.getData("select f_middlename from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "f_middlename")
            lname = dbAccess.getData("select f_lastname from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "f_lastname")

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
            fac = dbAccess.getData("select facref_no from faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.getMultipleData("select DISTINCT(c.course_cd) from introse.course c, introse.courseoffering co where co.status = 'A' and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;", "course_cd")

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
            fac = dbAccess.getData("select facref_no from faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.getMultipleData("select DISTINCT(co.section) from introse.course c, introse.courseoffering co where co.status = 'A' and co.facref_no = '" & fac & "' and c.course_cd = '" & course & "' order by 1;", "section")

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
            remarks = dbAccess.getMultipleData("select remark_des from introse.remarks order by 1;", "remark_des")

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
            fac = dbAccess.getData("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            room = dbAccess.getData("select co.room from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", "room")

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
            fac = dbAccess.getData("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no").ToString
            starttime = dbAccess.getData("select co.timestart from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", "timestart").ToString()
            endtime = dbAccess.getData("select co.timeend from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", "timeend").ToString()
            sched = dbAccess.getData("select co.daysched from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", "daysched")

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
        If (String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrWhiteSpace(txtbxFacID.Text)) Or (String.IsNullOrEmpty(txtbxName.Text) Or String.IsNullOrWhiteSpace(txtbxName.Text)) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or (String.IsNullOrEmpty(txtbxChecker.Text) Or String.IsNullOrWhiteSpace(txtbxChecker.Text)) Then
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
        att = dbAccess.getData("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseofferingid & "' and status = '" & stat & "';", "attendanceid")
        If String.IsNullOrEmpty(att) Then
            b = True
        Else
            MsgBox("Duplicate attendance entry!", MsgBoxStyle.Critical, "")
        End If
        Return b

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim absentDate, checker, course, section, courseOfferingId, remarks As String
        Dim ref As String = wdwDailyAttendanceLog.getRefNo()
        Dim currentDate As Date
        Dim result As Integer
        currentDate = DateTime.Now.Date
        result = DateTime.Compare(dtp.Value.Date, currentDate)
        Dim daySched As New List(Of String)
        Dim tempBool As Boolean = False

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
            If String.IsNullOrEmpty(cmbbxCourse.SelectedItem) Or String.IsNullOrEmpty(cmbbxSection.SelectedItem) Or String.IsNullOrEmpty(cmbbxRemarks.SelectedItem) Or String.IsNullOrEmpty(txtbxChecker.Text) Then
                MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
            ElseIf result > 0 Then
                MsgBox("Absent date is earlier than the current date!", MsgBoxStyle.Critical, "")
            ElseIf Not (tempBool) Then
                MsgBox("Absent date does not match class schedule!", MsgBoxStyle.Critical, "")
            Else

                absentDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                course = cmbbxCourse.SelectedItem
                section = cmbbxSection.SelectedItem
                remarks = dbAccess.getData("select remark_cd from introse.remarks where remark_des = '" & cmbbxRemarks.SelectedItem & "';", "remark_cd")
                checker = txtbxChecker.Text

                courseOfferingId = dbAccess.getData("select courseoffering_id from introse.courseoffering c, introse.course cl where c.status = 'A' and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "';", "courseoffering_id")
                If (Check_Entry(absentDate, courseOfferingId, "A") = True) Then
                    dbAccess.updateData("update `attendance` set `absent_date` = '" & absentDate & "', `courseoffering_id` = '" & courseOfferingId & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentDate.ToString("yyyy-MM-dd") & "', `encoder` = 'unknown', `checker` = '" & checker & "', `report_status` = Pending WHERE `attendanceid` = '" & ref & "' and status = 'A';")
                    Me.Close()

                    courseOfferingId = dbAccess.getData("select courseoffering_id from courseoffering c, course cl where cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "'; 
", "courseoffering_id")
                    If (Check_Entry(absentDate, courseOfferingId, "A") = True) Then
                        dbAccess.updateData("UPDATE `attendance` SET `absent_date` = '" & absentDate & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentDate.ToString("yyyy-MM-dd") & "', `encoder` = 'unknown', `checker` = '" & checker & "' WHERE `attendanceid` = '" & ref & "' and status = 'A';")
                    End If
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
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()

    End Sub
End Class