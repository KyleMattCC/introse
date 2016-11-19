Public Class wdwModFacultyDaily
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        txtbxFacID.Clear()
        txtbxName.Clear()
        cmbbxCourse.Items.Clear()
        cmbbxRemarks.Items.Clear()
        cmbbxSection.Items.Clear()
        cmbbxCourse.ResetText()
        cmbbxRemarks.ResetText()
        cmbbxSection.ResetText()
        txtbxRoom.Clear()
        txtbxDay.Clear()
        txtbxStart.Clear()
        txtbxEnd.Clear()
        txtbxEncoder.Clear()
        txtbxChecker.Clear()
        Me.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxRemarks.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim absentdate As String
        Dim remarks As String
        Dim encoder As String
        Dim checker, course, section As String
        Dim ref As String = wdwDailyAttendanceLog.RData(0)
        Dim currentdate As Date
        Dim result As Integer
        currentdate = DateTime.Now.Date
        result = DateTime.Compare(dtp.Value.Date, currentdate)

        If Convert.ToInt32(ref) > 0 Then
            absentdate = dtp.Value.Date.ToString("yyyy-MM-dd")
            course = cmbbxCourse.SelectedItem
            section = cmbbxSection.SelectedItem
            remarks = cmbbxRemarks.SelectedItem
            encoder = txtbxEncoder.Text
            checker = txtbxChecker.Text
            If String.IsNullOrEmpty(course) Or String.IsNullOrEmpty(section) Or String.IsNullOrEmpty(remarks) Or String.IsNullOrEmpty(encoder) Or String.IsNullOrEmpty(checker) Then
                MsgBox("Incomplete fields!")
            ElseIf result > 0 Then
                MsgBox("ERROR: Absent Date is earlier than the current date!")
            Else
                dbAccess.updateData("UPDATE `attendance` SET `absent_date` = '" & absentdate & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentdate.ToString("yyyy-MM-dd") & "', `encoder` = '" & encoder & "', `checker` = '" & checker & "' WHERE `attendanceid` = '" & ref & "' and status = 'A';")
                dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' 
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)
                    txtbxFacID.Clear()
                    txtbxName.Clear()
                    cmbbxCourse.Items.Clear()
                    cmbbxRemarks.Items.Clear()
                    cmbbxSection.Items.Clear()
                    cmbbxCourse.ResetText()
                    cmbbxRemarks.ResetText()
                    cmbbxSection.ResetText()
                    txtbxRoom.Clear()
                    txtbxDay.Clear()
                    txtbxStart.Clear()
                    txtbxEnd.Clear()
                    txtbxEncoder.Clear()
                    txtbxChecker.Clear()
                    Me.Close()
                End If

            End If


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()
    End Sub
    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        validateInput("0123456789", e)
    End Sub
    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtbxChecker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxChecker.KeyPress
        validateInput("abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", e)
    End Sub

    Private Sub txtbxEncoder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxEncoder.KeyPress
        validateInput("abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", e)
    End Sub

End Class