Public Class popAddMakeUp
    Dim dbAccess As New DatabaseAccessor
    Private Sub AddFacultyName(facultyid As String, ByVal text As TextBox)
        Dim fname As String
        Dim MI As String
        Dim lname As String
        Dim name As String

        name = ""
        fname = ""
        MI = ""
        lname = ""

        fname = dbAccess.getStringData("Select f_firstname from faculty where facultyid = '" & facultyid & "';", "f_firstname")
        MI = dbAccess.getStringData("Select f_middlename from faculty where facultyid = '" & facultyid & "';", "f_middlename")
        lname = dbAccess.getStringData("Select f_lastname from faculty where facultyid = '" & facultyid & "';", "f_lastname")

        text.Text = fname + " " + MI + " " + lname

    End Sub
    Private Sub AddCourse(facultyid As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of String)()
        Dim fac As String = ""
        fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
        coursecode = dbAccess.getMultipleData("SELECT c.course_cd FROM introse.attendance as a, introse.courseoffering as co, introse.course as c where co.course_id = c.course_id and a.courseoffering_id = co.courseoffering_id and a.remarks_cd = 'AB' and co.facref_no = '" & fac & "' and absent_date != '0000-00-00';
", "course_cd")

        For j As Integer = 0 To coursecode.Count - 1
            combo.Items.Add(coursecode(j))
        Next

    End Sub
    Private Sub AddSection(facultyid As String, ByVal combo As ComboBox)
        Dim section As New List(Of String)()
        Dim fac As String = ""
        fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
        section = dbAccess.getMultipleData("SELECT co.section FROM introse.attendance as a, introse.courseoffering as co, introse.course as c where co.course_id = c.course_id and a.courseoffering_id = co.courseoffering_id and a.remarks_cd = 'AB' and co.facref_no = '" & fac & "' and absent_date != '0000-00-00';
", "section")

        For j As Integer = 0 To section.Count - 1

            combo.Items.Add(section(j))
        Next

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        txtbxFacID.Clear()
        cmbbxReason.Items.Clear()
        Me.Close()
    End Sub

    Private Sub txtEncoder_TextChanged(sender As Object, e As EventArgs) Handles txtEncoder.TextChanged

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwFacultyMakeUp.Enable_Form()
    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim dateFiled, makeupdate, absentdate, curDate As Date
        Dim room, startTime, endTime, reason_cd, fac, course, encoder As String

        dateFiled = dtpFiled.Value.Date
        makeupdate = dtpMakeUpDate.Value.Date
        room = txtRoom.Text
        startTime = txtStart.Text
        endTime = txtEnd.Text
        reason_cd = dbAccess.getStringData("SELECT reason_cd FROM reason where reason_desc = '" & txtReason.Text & "'", "reason_cd")
        fac = dbAccess.getStringData("SELECT facref_no FROM faculty where facultyid = '" & txtbxFacID.Text & "'", "facref_no")

        course = cmbbxCourse.SelectedItem.ToString
        encoder = txtEncoder.Text
        absentdate = dtpAbsent.Value.Date
        curDate = Date.Now.Date

        dbAccess.addData("INSERT INTO `introse`.`makeup` (`courseoffering_id`, `absent_date`, `timestart`, `timeend`, `room`, `reason_cd`, `makeup_date`, `enc_date`, `encoder`, `status`, `date_filed`)
VALUES ('" & fac & "', '" & absentdate.ToString("yyyy-MM-dd") & "', '" & startTime & "', '" & endTime & "', '" & room & "', '" & reason_cd & "', '" & makeupdate.ToString("yyyy-MM-dd") & "', '" & curDate.ToString("yyyy-MM-dd") & "', '" & encoder & "', 'A', '" & dateFiled.ToString("yyyy-MM-dd") & "');")

        dbAccess.fillDataGrid("Select m.makeupid 'Reference', m.absent_date 'Absent Date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.makeup_date 'Make-up date', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & wdwFacultyMakeUp.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 4, 12;", wdwFacultyMakeUp.grid)
    End Sub

    Private Sub popAddMakeUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reason As New List(Of String)
        reason = dbAccess.getMultipleData("SELECT reason_desc FROM reason", "reason_desc")
        For j As Integer = 0 To reason.Count - 1
            'MsgBox(reason(j))
            cmbbxReason.Items.Add(reason(j))
        Next
    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        cmbbxCourse.Items.Clear()
        cmbbxSec.Items.Clear()
        AddFacultyName(txtbxFacID.Text, txtbxFacName)
        AddCourse(txtbxFacID.Text, cmbbxCourse)
    End Sub

    Private Sub cmbbxReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxReason.SelectedIndexChanged
        txtReason.Text = cmbbxReason.SelectedItem.ToString
    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        AddSection(txtbxFacID.Text, cmbbxSec)
    End Sub
End Class