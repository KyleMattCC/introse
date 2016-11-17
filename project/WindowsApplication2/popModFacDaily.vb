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
        Dim checker As String
        Dim ref As String = wdwDailyAttendanceLog.dgAttID
        Dim currentdate As Date
        currentdate = DateTime.Now.Date

        If Convert.ToInt32(ref) > 0 Then
            'ref = wdwDailyAttendanceLog.dgAttID
            absentdate = dtp.Value.Date.ToString("yyyy-MM-dd")
            remarks = cmbbxRemarks.SelectedItem
            encoder = txtbxEncoder.Text
            checker = txtbxChecker.Text

            dbAccess.updateData("UPDATE `attendance` SET `absent_date` = '" & absentdate & "', `remarks_cd` = '" & remarks & "', `enc_date` = '" & currentdate.ToString("yyyy-MM-dd") & "', `encoder` = '" & encoder & "', `checker` = '" & checker & "' WHERE `attendanceid` = '" & ref & "';")
            dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' 
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)

            txtbxFacID.Clear()
            txtbxName.Clear()
            cmbbxCourse.Items.Clear()
            cmbbxRemarks.Items.Clear()
            cmbbxSection.Items.Clear()
            txtbxRoom.Clear()
            txtbxDay.Clear()
            txtbxStart.Clear()
            txtbxEnd.Clear()
            txtbxEncoder.Clear()
            txtbxChecker.Clear()

        End If


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()
    End Sub

    Private Sub txtbxName_TextChanged(sender As Object, e As EventArgs) Handles txtbxName.TextChanged

    End Sub
End Class