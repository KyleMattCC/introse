Public Class popMoreInfoMakeupClass
    Dim dbAccess As New databaseAccessor

    Private Sub wdwMoreInfoMakeupClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Makeup_Form(rowData As List(Of String))
        Dim moreInfo As New List(Of Object)

        moreInfo = dbAccess.Get_Multiple_Column_Data("select f.facultyid, concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename), co.college_name, d.departmentname, m.timestart, m.timeend, m.room, r.reason_des, m.enc_date, m.encoder, m.hours 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reasons r, introse.department d, introse.college co
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and f.departmentid = d.departmentid and d.college_code = co.college_code and (c.status = 'A' or c.status = 'R') and (m.status = 'A' or m.status = 'R') and m.makeupid = '" & wdwAttendanceHistoryLog.Get_Ref_No & "';", "11")


        If rowData.Count > 0 Then
            txtbxRef.Text = rowData(0)
            txtbxSY.Text = rowData(1) ' SY
            txtbxTerm.Text = rowData(2) ' term
            txtbxADate.Text = rowData(3).Split(" ")(0)
            txtbxCourse.Text = rowData(4) ' course
            txtbxSec.Text = rowData(5) ' section

            txtbxFacID.Text = moreInfo(0) ' fid
            txtbxName.Text = moreInfo(1) ' name
            txtbxCollege.Text = moreInfo(2)
            txtbxDept.Text = moreInfo(3) ' dept
            txtbxStart.Text = moreInfo(4) 'start
            txtbxEnd.Text = moreInfo(5) ' end
            txtbxRoom.Text = moreInfo(6) ' room
            txtbxRemarks.Text = moreInfo(7)
            txtbxDEncoded.Text = moreInfo(8)
            txtbxEncoder.Text = moreInfo(9)
            txtbxDay.Text = moreInfo(10)
        End If
        Me.Show()

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub wdwMoreInfoMakeupClass_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        wdwAttendanceHistoryLog.Enable_Only_Form()
    End Sub

End Class