Public Class popAddMakeUp
    Dim dbAccess As New databaseAccessor

    Private Sub popAddMakeUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp.Value = wdwDailyAttendanceLog.getDTPValue()
        Add_Reasons(cmbbxReason)
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
                                                    from introse.course c, introse.courseoffering co, introse.attendance a 
                                                    where co.status = 'A' and a.status = 'A' and co.courseoffering_id = a.courseoffering_id and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;")

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
                                                from introse.course c, introse.courseoffering co, introse.attendance a 
                                                where co.status = 'A' and a.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.courseoffering_id = a.courseoffering_id order by 1;")

            For ctr As Integer = 0 To section.Count - 1
                combo.Items.Add(section(ctr))
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

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        txtbxFacName.Clear()
        cmbbxCourse.Items.Clear()
        cmbbxSec.Items.Clear()
        cmbbxSec.ResetText()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxRoom.Clear()
        Add_Faculty_Name(txtbxFacID.Text, txtbxFacName)
        Add_Course(txtbxFacID.Text, cmbbxCourse)
        Check_Enable()
        Check_Element_Enable()

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        cmbbxSec.Items.Clear()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxRoom.Clear()
        Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSec)
        cmbbxReason.SelectedIndex = -1
        Check_Enable()

    End Sub

    Private Sub cmbbxSec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSec.SelectedIndexChanged
        txtbxRoom.Enabled = True
        txtbxStart.Enabled = True
        txtbxEnd.Enabled = True
        cmbbxReason.Enabled = True
        cmbbxReason.SelectedIndex = -1
        Check_Enable()

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

    Private Sub Check_Enable()
        If (String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrWhiteSpace(txtbxFacID.Text)) Or (String.IsNullOrEmpty(txtbxFacName.Text) Or String.IsNullOrWhiteSpace(txtbxFacName.Text)) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSec.SelectedIndex = -1 Or (String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrWhiteSpace(txtbxRoom.Text)) Or (String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrWhiteSpace(txtbxStart.Text)) Or (String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrWhiteSpace(txtbxEnd.Text)) Or cmbbxReason.SelectedIndex = -1 Then
            bttnAdd.Enabled = False
            bttnAddClear.Enabled = False

        Else
            bttnAdd.Enabled = True
            bttnAddClear.Enabled = True

        End If

    End Sub

    Private Sub Check_Element_Enable()
        If String.IsNullOrEmpty(txtbxFacName.Text) Then
            cmbbxCourse.Enabled = False
            cmbbxSec.Enabled = False
            dtp.Enabled = False
            cmbbxReason.SelectedIndex = -1
            cmbbxReason.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStart.Enabled = False
            txtbxEnd.Enabled = False

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

    Private Function Set_Attendance() As Boolean
        Dim makeupDate, course, section, room, reason, courseOfferingId As String
        Dim startTime, endTime, tempStart, tempEnd As Integer
        Dim absentHours As Double = dbAccess.Get_Data("Select sum(co.hours)
                From introse.attendance a, introse.courseoffering co, introse.course c
                                                      where co.status = 'A' And a.status = 'A' And c.course_cd = '" & cmbbxCourse.SelectedItem & "' And c.course_id = co.course_id And co.section = '" & cmbbxSec.SelectedItem & "' And a.courseoffering_id = co.courseoffering_id;", "sum(co.hours)")

        If String.IsNullOrEmpty(cmbbxReason.Text) Or String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrEmpty(dtp.Value.Date.ToString("yyyy-MM-dd")) Then
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

            MsgBox(wholeNumber)
            If ((startTime < 0 Or startTime > 2359) Or (startTime / 100 > 24 Or startTime Mod 100 > 59)) Then
                MsgBox("Invalid start time input!", MsgBoxStyle.Critical, "")
                Return False
            ElseIf ((endTime < 0 Or endTime > 2359) Or (endTime / 100 > 24 Or endTime Mod 100 > 59)) Then
                MsgBox("Invalid end time input!", MsgBoxStyle.Critical, "")
                Return False
            ElseIf ((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) > absentHours) Then
                MsgBox("Makeup hours exceed absent hours!", MsgBoxStyle.Critical, "")
                Return False
            Else
                makeupDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                course = cmbbxCourse.SelectedItem
                section = cmbbxSec.SelectedItem
                room = txtbxRoom.Text
                reason = dbAccess.Get_Data("select reason_cd from introse.reasons where reason_des = '" & cmbbxReason.SelectedItem.ToString & "';", "reason_cd")
                courseOfferingId = dbAccess.Get_Data("select courseoffering_id 
                                                           from introse.courseoffering c, introse.course cl 
                                                            where c.status = 'A' and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "';", "courseoffering_id")

                If (Check_Entry(makeupDate, startTime, endTime, room, "A", courseOfferingId, reason)) Then
                    dbAccess.Add_Data("insert into `introse`.`makeup` (`courseoffering_id`, `timestart`, `timeend`, `hours`, `room`, `reason_cd`, `makeup_date`, `enc_date`, `encoder`, `status`) values (" & courseOfferingId & ", " & startTime & ", " & endTime & ", " & (wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) & ",'" & room & "', '" & reason & "', '" & makeupDate & "', '" & Date.Now.Date.ToString("yyyy-MM-dd") & "', 'unknown', 'A');")
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim tempBoolean As Boolean = Set_Attendance()

        If (tempBoolean) Then
            Me.Close()
        End If

    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        Dim tempBoolean As Boolean = Set_Attendance()

        If (tempBoolean) Then
            txtbxFacID.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        txtbxFacID.Clear()
        Me.Close()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwFacultyMakeUp.Enable_Form()
    End Sub

End Class