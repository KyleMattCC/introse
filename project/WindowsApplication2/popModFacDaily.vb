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
                Add_Faculty_Name(txtbxFacID.Text, txtbxName) ' name
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
                Add_Faculty_Name(txtbxFacID.Text, txtbxName) ' name
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
                dtp.Enabled = True
                cmbbxCourse.Enabled = True
            Else
                text.Text = fname + " " + MI + " " + lname
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Add_Course(facultyid As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of Object)()
        Dim fac As Integer
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) from introse.course c, introse.courseoffering co where co.status = 'A' and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;")

            For ctr As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(ctr))
            Next
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
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

    Private Sub Fill_Room(facultyid As String, course As String, section As String, ByVal text As TextBox)
        Dim room As String = ""
        Dim fac As String = ""
        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyid & "';", "facref_no")
            room = dbAccess.Get_Data("select co.room from introse.courseoffering co, introse.course c where co.status = 'A' and c.course_cd = '" & course & "' and c.course_id = co.course_id and co.facref_no = '" & fac & "' and co.section = '" & section & "';", "room")

            text.Text = room
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
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

    Private Sub Check_Enable()
        If (String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrWhiteSpace(txtbxFacID.Text)) Or (String.IsNullOrEmpty(txtbxName.Text) Or String.IsNullOrWhiteSpace(txtbxName.Text)) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or cmbbxRemarks.SelectedIndex = -1 Or (String.IsNullOrEmpty(txtbxChecker.Text) Or String.IsNullOrWhiteSpace(txtbxChecker.Text)) Then
            bttnModify.Enabled = False

        Else
            bttnModify.Enabled = True

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

    Private Function Check_Entry(absent As String, courseofferingid As String, stat As String, remarks As String, checker As String) As Boolean
        Dim att As New List(Of Object)()
        Dim b As Boolean = False
        att = dbAccess.Get_Multiple_Row_Data("select attendanceid from introse.attendance where absent_date = '" & absent & "'and courseoffering_id = '" & courseofferingid & "' and status = '" & stat & "';")
        If att.Count < 2 Then
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
                MsgBox("Absent date Is earlier than the current date!", MsgBoxStyle.Critical, "")
            ElseIf Not (tempBool) Then
                MsgBox("Absent date does Not match class schedule!", MsgBoxStyle.Critical, "")
            Else
                Try
                    absentDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                    course = cmbbxCourse.SelectedItem
                    section = cmbbxSection.SelectedItem
                    remarks = dbAccess.Get_Data("select remark_cd from introse.remarks where remark_des = '" & cmbbxRemarks.SelectedItem & "';", "remark_cd")
                    checker = txtbxChecker.Text

                    courseOfferingId = dbAccess.Get_Data("select courseoffering_id from introse.courseoffering c, introse.course cl where c.status = 'A' and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "';", "courseoffering_id")
                    If (Check_Entry(absentDate, courseOfferingId, "A", remarks, checker) = True) Then
                        dbAccess.Update_Data("update `attendance` set `absent_date` = '" & absentDate & "', `courseoffering_id` = '" & courseOfferingId & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentDate.ToString("yyyy-MM-dd") & "', `encoder` = '" & wdwLogin.Get_Encoder & "', `checker` = '" & checker & "', `report_status` = 'Pending' WHERE attendanceid = '" & ref & "' and status = 'A';")
                        Me.Close()

                        txtbxFacID.Clear()
                        txtbxName.Clear()
                        cmbbxCourse.Items.Clear()
                        cmbbxSection.Items.Clear()
                        txtbxRoom.Clear()
                        txtbxDay.Clear()
                        txtbxStart.Clear()
                        txtbxEnd.Clear()
                        txtbxChecker.Clear()

                    End If
                Catch Ex As Exception
                    System.Windows.Forms.MessageBox.Show(Ex.Message)
                End Try
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