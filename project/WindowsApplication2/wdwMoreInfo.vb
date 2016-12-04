Public Class wdwMoreInfo
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Public Sub Load_Form(rowData As List(Of String))
        Dim moreInfo As New List(Of Object)

        moreInfo = dbAccess.getRowData("Select a.absent_date, cl.course_cd, c.section,  c.room, c.daysched, c.timestart, c.timeend, r.remark_des, a.enc_date, a.encoder, a.checker
        From introse.attendance a, introse.courseoffering c, introse.course cl, introse.remarks r
        where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and a.attendanceid = '" & rowData(0) & "';", "absent_date", "course_cd", "section", "room", "daysched", "timestart", "timeend", "remark_des", "enc_date", "encoder", "checker")

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