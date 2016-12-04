Public Class wdwMoreInfo
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Public Sub Load_Makeup_Form(rowData As List(Of String))
        Dim moreInfo As New List(Of Object)
        Label7.Text = "Makeup Date:"
        Label7.Location = New Point(63, 219)
        Label18.Text = "Reason:"
        Label18.Location = New Point(115, 429)

        moreInfo = dbAccess.get9ColumnData("Select m.makeup_date, cl.course_cd, c.section, m.timestart, m.timeend, m.room, r.reason_desc, m.enc_date, m.encoder 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and (m.status = 'A' or m.status = 'R') and m.makeupid = '" & wdwAttendanceHistoryLog.getRefNo() & "';", "makeup_date", "course_cd", "section", "timestart", "timeend", "room", "reason_desc", "enc_date", "encoder")


        If rowData.Count > 0 Then
            txtbxRef.Text = rowData(0)
            txtbxFacID.Text = rowData(1) ' fid
            txtbxName.Text = rowData(2) ' name
            txtbxDept.Text = rowData(3) ' dept
            txtbxCollege.Text = rowData(4) ' coll
            txtbxTerm.Text = rowData(5) ' term
            txtbxSY.Text = rowData(6) ' SY

            txtbxADate.Text = moreInfo(0)
            txtbxCourse.Text = moreInfo(1) ' course
            txtbxSec.Text = moreInfo(2) ' section
            txtbxStart.Text = moreInfo(3) 'start
            txtbxEnd.Text = moreInfo(4) ' end
            txtbxRoom.Text = moreInfo(5) ' room
            txtbxRemarks.Text = moreInfo(6)
            txtbxDEncoded.Text = moreInfo(7)
            txtbxEncoder.Text = moreInfo(8)
            txtbxDay.Text = "Not Applicable"
            txtbxChecker.Text = "Not Applicable"

        End If

        Me.Show()
    End Sub

    Public Sub Load_Attendance_Form(rowData As List(Of String))
        Dim moreInfo As New List(Of Object)
        Label7.Text = "Absent Date:"
        Label18.Text = "Remarks:"
        Label7.Location = New Point(70, 219)
        Label18.Location = New Point(103, 429)
        moreInfo = dbAccess.get11ColumnData("Select a.absent_date, cl.course_cd, c.section,  c.room, c.daysched, c.timestart, c.timeend, r.remark_des, a.enc_date, a.encoder, a.checker
        From introse.attendance a, introse.courseoffering c, introse.course cl, introse.remarks r
        where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and a.attendanceid = '" & wdwAttendanceHistoryLog.getRefNo() & "';", "absent_date", "course_cd", "section", "room", "daysched", "timestart", "timeend", "remark_des", "enc_date", "encoder", "checker")

        If rowData.Count > 0 Then
            txtbxRef.Text = rowData(0)
            txtbxFacID.Text = rowData(1) ' fid
            txtbxName.Text = rowData(2) ' name
            txtbxDept.Text = rowData(3) ' dept
            txtbxCollege.Text = rowData(4) ' coll
            txtbxTerm.Text = rowData(5) ' term
            txtbxSY.Text = rowData(6) ' SY

            txtbxADate.Text = moreInfo(0)
            txtbxCourse.Text = moreInfo(1) ' course
            txtbxSec.Text = moreInfo(2) ' section
            txtbxRoom.Text = moreInfo(3) ' room
            txtbxDay.Text = moreInfo(4)
            txtbxStart.Text = moreInfo(5) 'start
            txtbxEnd.Text = moreInfo(6) ' end
            txtbxRemarks.Text = moreInfo(7)
            txtbxDEncoded.Text = moreInfo(8)
            txtbxEncoder.Text = moreInfo(9)
            txtbxChecker.Text = moreInfo(10)

        End If

        Me.Show()
    End Sub
    Private Sub wdwMoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub wdwMoreInfo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_Form()
    End Sub
End Class