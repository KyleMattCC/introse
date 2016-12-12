Public Class wdwMoreInfo
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Public Sub Load_Attendance_Form(rowData As List(Of String))
        Dim moreInfo As New List(Of Object)
        Label7.Text = "Absent Date:"
        Label18.Text = "Remarks:"
        Label7.Location = New Point(70, 219)
        Label18.Location = New Point(103, 429)
        moreInfo = dbAccess.Get_Multiple_Column_Data("select f.facultyid, concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename), co.college_name, d.departmentname,  c.room, c.daysched, c.timestart, c.timeend, r.remark_des, a.enc_date, a.encoder, a.checker
        from introse.attendance a, introse.courseoffering c, introse.course cl, introse.faculty f, introse.remarks r, introse.department d, introse.college co
        where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and c.facref_no = f.facref_no and c.course_id = cl.course_id and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and a.attendanceid = '" & wdwAttendanceHistoryLog.getRefNo & "';", "12")

        If rowData.Count > 0 Then
            txtbxRef.Text = rowData(0)
            txtbxSY.Text = rowData(1) ' SY
            txtbxTerm.Text = rowData(2) ' term
            txtbxADate.Text = rowData(3).Split(" ")(0)
            txtbxCourse.Text = rowData(4) ' course
            txtbxSec.Text = rowData(5) ' section

            txtbxFacID.Text = moreInfo(0) ' fid
            txtbxName.Text = moreInfo(1) ' name
            txtbxCollege.Text = moreInfo(2) ' coll
            txtbxDept.Text = moreInfo(3) ' dept

            txtbxRoom.Text = moreInfo(4) ' room
            txtbxDay.Text = moreInfo(5)
            txtbxStart.Text = moreInfo(6) 'start
            txtbxEnd.Text = moreInfo(7) ' end
            txtbxRemarks.Text = moreInfo(8)
            txtbxDEncoded.Text = moreInfo(9)
            txtbxEncoder.Text = moreInfo(10)
            txtbxChecker.Text = moreInfo(11)

        End If
        Me.Show()
    End Sub
    Private Sub wdwMoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub wdwMoreInfo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_After_Search_Form()
    End Sub
End Class