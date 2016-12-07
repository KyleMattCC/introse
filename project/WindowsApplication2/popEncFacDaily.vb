Public Class popEncFacDaily
    Dim dbAccess As New databaseAccessor

    Private Sub popEncFacDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.Value = wdwDailyAttendanceLog.getDTPValue()
        Add_Remarks(cmbbxRemarks)
        Check_Enable()
        Check_Element_Enable()

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
            fname = facName(0).ToString
            MI = facName(1).ToString
            lname = facName(2).ToString

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

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) 
                                                   from introse.course c, introse.courseoffering co 
                                                   where co.status = 'A' and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;")

            For ctr As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(ctr))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_Section(facultyid As String, course As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) 
                                                from introse.course c, introse.courseoffering co 
                                                where co.status = 'A' and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "' order by 1;")

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

    Private Sub Fill_Room(facultyid As String, course As String, section As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' AND facultyid = '" & facultyid & "';", "facref_no")
            room = dbAccess.Get_Data("select co.room from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' AND c.course_id = co.course_id AND co.facref_no = '" & fac & "'  AND co.section = '" & section & "';", "room")

            text.Text = room
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Fill_Sched(facultyid As String, course As String, section As String, ByVal TimeStart As TextBox, ByVal TimeEnd As TextBox, ByVal DaySched As TextBox)
        Dim courseSched As New List(Of Object)
        Dim starttime As String
        Dim endtime As String
        Dim fac As String
        Dim sched As String = ""
        Try
            fac = dbAccess.Get_Data("select facref_no from faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            courseSched = dbAccess.Get_Multiple_Column_Data("select co.timestart, co.timeend, co.daysched from introse.courseoffering co, introse.course c where co.status = 'A' AND c.course_cd = '" & course & "' AND co.course_id = c.course_id AND co.facref_no = '" & fac & "' AND co.section = '" & section & "';", 3)
            starttime = courseSched(0)
            endtime = courseSched(1)
            sched = courseSched(2)

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

    Private Function Check_Entry(absent As String, courseofferingid As String, stat As String) As Boolean
        Dim att As String = ""
        Dim b As Boolean = False
        att = dbAccess.Get_Data("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseofferingid & "' and status = '" & stat & "';", "attendanceid")
        If String.IsNullOrEmpty(att) Then
            b = True
        Else
            MsgBox("Duplicate attendance!", MsgBoxStyle.Critical, "")
        End If
        Return b

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

    Private Function Set_Attendance(facultyid As String, course As String, section As String, remark As String, inputdate As Date, encoder As String, checker As String, ByVal text As TextBox, ByVal combo As ComboBox, days As String, stat As String) As Boolean
        Dim courseid As String = ""
        Dim courseofferingid As String = ""
        Dim fac As String = ""
        Dim currentdate As Date
        Dim result As Integer
        Dim remark_cd As String = ""
        Dim daySched As New List(Of String)
        Dim tempBool As Boolean = False
        Try
            currentdate = DateTime.Now.Date
            result = DateTime.Compare(inputdate, currentdate)
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
                If (daySched(ctr) = inputdate.DayOfWeek.ToString) Then
                    tempBool = True
                End If
            Next

            If (text.Text.Length = 0 Or String.IsNullOrEmpty(combo.Text) Or String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(remark) Or String.IsNullOrEmpty(checker)) Then
                MsgBox("Incomplete fields!", MsgBoxStyle.Critical, "")
                Return False
            ElseIf result > 0 Then
                MsgBox("Absent date is earlier than the current date!", MsgBoxStyle.Critical, "")
                Return False
            ElseIf Not (tempBool) Then
                MsgBox("Absent date does not match class schedule!", MsgBoxStyle.Critical, "")
                Return False
            Else
                courseid = dbAccess.Get_Data("select course_id from introse.course where course_cd ='" & course & "';", "course_id")
                fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
                courseofferingid = dbAccess.Get_Data("select courseoffering_id from introse.courseoffering  where status = 'A' and course_id = " & courseid & " and facref_no = '" & fac & "' and section = '" & section & "';", "courseoffering_id")
                remark_cd = dbAccess.Get_Data("select remark_cd from introse.remarks where remark_des = '" & remark & "';", "remark_cd")
                If (Check_Entry(inputdate.ToString("yyyy-MM-dd"), courseofferingid, "A") = True) Then
                    dbAccess.Add_Data("insert into `attendance`(`absent_date`, `courseoffering_id`, `remarks_cd`, `enc_date`, `encoder`,`checker`,`status`,`report_status`) values('" & inputdate.ToString("yyyy-MM-dd") & "'," & courseofferingid & ",'" & remark_cd & "','" & currentdate.ToString("yyyy-MM-dd") & "','" & encoder & "','" & checker & "','A','" & stat & "');")
                    Return True
                End If

            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, "unknown", txtbxChecker.Text, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            Me.Close()
        End If

    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        Dim tempBoolean As Boolean = Set_Attendance(txtbxFacID.Text, cmbbxCourse.SelectedItem, cmbbxSection.SelectedItem, cmbbxRemarks.SelectedItem, dtp.Value.Date, "unknown", txtbxChecker.Text, txtbxFacID, cmbbxRemarks, txtbxDay.Text, "Pending")

        If (tempBoolean) Then
            txtbxFacID.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub popEndFacDaily_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()
    End Sub
End Class