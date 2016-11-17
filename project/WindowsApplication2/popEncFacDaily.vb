Public Class popEncFacDaily
    Dim dbAccess As New DatabaseAccessor
    Private Sub AddRoom(facultyid As String, ByVal combo As ComboBox)
        Dim room As New List(Of String)()
        Dim fac As String = ""
        fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
        room = dbAccess.getMultipleData("SELECT DISTINCT(room) FROM courseoffering Where facref_no = '" & fac & "' AND status = 'A';", "room")

        For j As Integer = 0 To room.Count - 1
            combo.Items.Add(room(j))
        Next

    End Sub
    Private Sub AddRemarks(ByVal combo As ComboBox)
        Dim remarks As New List(Of String)()
        remarks = dbAccess.getMultipleData("SELECT remark_cd FROM remarks;", "remark_cd")

        For j As Integer = 0 To remarks.Count - 1
            combo.Items.Add(remarks(j))
        Next

    End Sub
    Private Sub SetAttendance(facultyid As String, course As String, remark As String, inputdate As Date, encoder As String, checker As String, ByVal text As TextBox, ByVal combo As ComboBox, row As String, stat As String)
        Dim courseid As String
        Dim courseofferingid As String
        Dim coursecode As String
        Dim section As String
        Dim arrayCourse As String() = Array.CreateInstance(GetType(String), 0)
        Dim fac As String = ""
        Dim currentdate As Date
        currentdate = DateTime.Now.Date

        courseid = ""
        courseofferingid = ""
        coursecode = ""
        section = ""
        If (String.IsNullOrEmpty(course)) Then
        Else
            arrayCourse = course.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            coursecode = arrayCourse(0)
            section = arrayCourse(1)
        End If

        If (text.Text.Length = 0 Or String.IsNullOrEmpty(combo.Text) Or String.IsNullOrEmpty(course)) Then
            MsgBox("Incomplete Information on row " + row + "!")
        Else
            courseid = dbAccess.getStringData("SELECT course_id FROM course WHERE course_cd ='" & coursecode & "';", "course_id")
            fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            courseofferingid = dbAccess.getStringData("select courseoffering_id from courseoffering  where course_id = " & courseid & " and facref_no = '" & fac & "' and status = 'A' and section = '" & section & "';", "courseoffering_id")
            dbAccess.addData("INSERT INTO `attendance`(`absent_date`, `courseoffering_id`, `remarks_cd`, `enc_date`, `encoder`,`checker`,`status`,`report_status`) VALUES('" & inputdate.ToString("yyyy-MM-dd") & "'," & courseofferingid & ",'" & remark & "','" & currentdate.ToString("yyyy-MM-dd") & "','" & encoder & "','" & checker & "','A','" & stat & "');")
        End If
        text.Clear()

    End Sub
    Private Sub AddCourse(facultyid As String, room As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of String)()
        Dim section As New List(Of String)()
        Dim fac As String = ""
        fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
        coursecode = dbAccess.getMultipleData("SELECT c.course_cd FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.room = '" & room & "' AND co.course_id = c.course_id;", "course_cd")
        section = dbAccess.getMultipleData("SELECT co.section FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.room = '" & room & "' AND co.course_id = c.course_id;", "section")

        For j As Integer = 0 To coursecode.Count - 1
            combo.Items.Add(coursecode(j) & " " & section(j))
        Next

    End Sub
    Private Sub AddTime(facultyid As String, room As String, course As String, ByVal TimeStart As TextBox, ByVal TimeEnd As TextBox)
        Dim courseid As Integer
        Dim starttime As String
        Dim endtime As String
        Dim coursecode As String
        Dim section As String
        Dim fac As String = ""

        courseid = 0
        starttime = ""
        endtime = ""
        coursecode = ""
        section = ""

        Dim arrayCourse As String() = Array.CreateInstance(GetType(String), 0)
        If (String.IsNullOrEmpty(course)) Then
        Else
            arrayCourse = course.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            coursecode = arrayCourse(0)
            section = arrayCourse(1)
        End If

        fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
        courseid = Convert.ToInt32(dbAccess.getStringData("SELECT course_id FROM course WHERE course_cd ='" & coursecode & "';", "course_id"))
        starttime = dbAccess.getStringData("SELECT timestart FROM courseoffering WHERE course_id = '" & courseid & "' AND room = '" & room & "' AND facref_no = '" & fac & "' AND section = '" & section & "' AND status = 'A';", "timestart")
        endtime = dbAccess.getStringData("SELECT timeend FROM courseoffering WHERE course_id = '" & courseid & "' AND room = '" & room & "' AND facref_no = '" & fac & "' AND section = '" & section & "' AND status = 'A';", "timeend")
        TimeStart.Text = starttime
        TimeEnd.Text = endtime

    End Sub
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        SetAttendance(TextBox2.Text, ComboBox16.SelectedItem, ComboBox1.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox2, ComboBox1, "1", "pending")
        SetAttendance(TextBox3.Text, ComboBox17.SelectedItem, ComboBox2.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox3, ComboBox2, "2", "pending")
        SetAttendance(TextBox5.Text, ComboBox19.SelectedItem, ComboBox3.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox5, ComboBox3, "3", "pending")
        SetAttendance(TextBox4.Text, ComboBox18.SelectedItem, ComboBox4.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox4, ComboBox4, "4", "pending")
        SetAttendance(TextBox7.Text, ComboBox21.SelectedItem, ComboBox6.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox7, ComboBox6, "5", "pending")
        SetAttendance(TextBox6.Text, ComboBox20.SelectedItem, ComboBox5.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox6, ComboBox5, "6", "pending")
        SetAttendance(TextBox9.Text, ComboBox23.SelectedItem, ComboBox8.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox9, ComboBox8, "7", "pending")
        SetAttendance(TextBox8.Text, ComboBox22.SelectedItem, ComboBox7.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox8, ComboBox7, "8", "pending")
        SetAttendance(TextBox11.Text, ComboBox25.SelectedItem, ComboBox10.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox11, ComboBox10, "9", "pending")
        SetAttendance(TextBox10.Text, ComboBox24.SelectedItem, ComboBox9.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox10, ComboBox9, "10", "pending")
        SetAttendance(TextBox13.Text, ComboBox27.SelectedItem, ComboBox12.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox13, ComboBox12, "11", "pending")
        SetAttendance(TextBox12.Text, ComboBox26.SelectedItem, ComboBox11.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox12, ComboBox11, "12", "pending")
        SetAttendance(TextBox15.Text, ComboBox29.SelectedItem, ComboBox14.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox15, ComboBox14, "13", "pending")
        SetAttendance(TextBox14.Text, ComboBox28.SelectedItem, ComboBox13.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox14, ComboBox13, "14", "pending")
        SetAttendance(TextBox16.Text, ComboBox30.SelectedItem, ComboBox15.SelectedItem, DateTimePicker1.Value.Date, "unknown", TextBox100.Text, TextBox16, ComboBox15, "15", "pending")

        dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' 
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & wdwDailyAttendanceLog.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", wdwDailyAttendanceLog.grid)
    End Sub
    Private Sub popEndFacDaily_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwDailyAttendanceLog.Enable_Form()
    End Sub

    Private Sub popEncFacDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        TextBox83.Clear()
        TextBox57.Clear()

        AddTime(TextBox3.Text, ComboBox32.SelectedItem, ComboBox17.SelectedItem, TextBox83, TextBox57)
    End Sub
    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ComboBox31.Items.Clear()
        ComboBox16.Items.Clear()
        TextBox82.Clear()
        TextBox58.Clear()
        ComboBox1.Items.Clear()

        AddFacultyName(TextBox2.Text, TextBox46)
        AddRoom(TextBox2.Text, ComboBox31)

    End Sub
    Private Sub ComboBox31_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox31.SelectedIndexChanged
        ComboBox16.Items.Clear()
        AddCourse(TextBox2.Text, ComboBox31.SelectedItem, ComboBox16)
        AddRemarks(ComboBox1)
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        TextBox82.Clear()
        TextBox58.Clear()

        AddTime(TextBox2.Text, ComboBox31.SelectedItem, ComboBox16.SelectedItem, TextBox82, TextBox58)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ComboBox32.Items.Clear()
        ComboBox17.Items.Clear()
        TextBox83.Clear()
        TextBox57.Clear()
        ComboBox2.Items.Clear()

        AddFacultyName(TextBox3.Text, TextBox45)
        AddRoom(TextBox3.Text, ComboBox32)
    End Sub

    Private Sub ComboBox32_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox32.SelectedIndexChanged
        ComboBox17.Items.Clear()
        AddCourse(TextBox3.Text, ComboBox32.SelectedItem, ComboBox17)
        AddRemarks(ComboBox2)
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ComboBox34.Items.Clear()
        ComboBox19.Items.Clear()
        TextBox19.Clear()
        TextBox56.Clear()
        ComboBox3.Items.Clear()

        AddFacultyName(TextBox5.Text, TextBox44)
        AddRoom(TextBox5.Text, ComboBox34)
    End Sub
    Private Sub ComboBox34_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox34.SelectedIndexChanged
        ComboBox19.Items.Clear()
        AddCourse(TextBox5.Text, ComboBox34.SelectedItem, ComboBox19)
        AddRemarks(ComboBox3)
    End Sub
    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox19.SelectedIndexChanged
        TextBox19.Clear()
        TextBox56.Clear()

        AddTime(TextBox5.Text, ComboBox34.SelectedItem, ComboBox19.SelectedItem, TextBox19, TextBox56)
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ComboBox33.Items.Clear()
        ComboBox18.Items.Clear()
        TextBox18.Clear()
        TextBox55.Clear()
        ComboBox4.Items.Clear()

        AddFacultyName(TextBox4.Text, TextBox43)
        AddRoom(TextBox4.Text, ComboBox33)
    End Sub
    Private Sub ComboBox33_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox33.SelectedIndexChanged
        ComboBox18.Items.Clear()
        AddCourse(TextBox4.Text, ComboBox33.SelectedItem, ComboBox18)
        AddRemarks(ComboBox4)
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox18.SelectedIndexChanged
        TextBox18.Clear()
        TextBox55.Clear()

        AddTime(TextBox4.Text, ComboBox33.SelectedItem, ComboBox18.SelectedItem, TextBox18, TextBox55)
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        ComboBox36.Items.Clear()
        ComboBox21.Items.Clear()
        TextBox21.Clear()
        TextBox54.Clear()
        ComboBox6.Items.Clear()

        AddFacultyName(TextBox7.Text, TextBox42)
        AddRoom(TextBox7.Text, ComboBox36)
    End Sub

    Private Sub ComboBox36_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox36.SelectedIndexChanged
        ComboBox21.Items.Clear()
        AddCourse(TextBox7.Text, ComboBox36.SelectedItem, ComboBox21)
        AddRemarks(ComboBox6)

    End Sub
    Private Sub ComboBox21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox21.SelectedIndexChanged
        TextBox21.Clear()
        TextBox54.Clear()

        AddTime(TextBox7.Text, ComboBox36.SelectedItem, ComboBox21.SelectedItem, TextBox21, TextBox54)
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ComboBox35.Items.Clear()
        ComboBox20.Items.Clear()
        TextBox20.Clear()
        TextBox53.Clear()
        ComboBox5.Items.Clear()

        AddFacultyName(TextBox6.Text, TextBox41)
        AddRoom(TextBox6.Text, ComboBox35)
    End Sub
    Private Sub ComboBox35_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox35.SelectedIndexChanged
        ComboBox20.Items.Clear()
        AddCourse(TextBox6.Text, ComboBox35.SelectedItem, ComboBox20)
        AddRemarks(ComboBox5)

    End Sub
    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged
        TextBox20.Clear()
        TextBox53.Clear()

        AddTime(TextBox6.Text, ComboBox35.SelectedItem, ComboBox20.SelectedItem, TextBox20, TextBox53)
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        ComboBox38.Items.Clear()
        ComboBox23.Items.Clear()
        TextBox23.Clear()
        TextBox52.Clear()
        ComboBox8.Items.Clear()

        AddFacultyName(TextBox9.Text, TextBox40)
        AddRoom(TextBox9.Text, ComboBox38)
    End Sub
    Private Sub ComboBox38_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox38.SelectedIndexChanged
        ComboBox23.Items.Clear()
        AddCourse(TextBox9.Text, ComboBox38.SelectedItem, ComboBox23)
        AddRemarks(ComboBox8)

    End Sub

    Private Sub ComboBox23_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox23.SelectedIndexChanged
        TextBox23.Clear()
        TextBox52.Clear()
        AddTime(TextBox9.Text, ComboBox38.SelectedItem, ComboBox23.SelectedItem, TextBox23, TextBox52)
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ComboBox37.Items.Clear()
        ComboBox22.Items.Clear()
        TextBox22.Clear()
        TextBox51.Clear()
        ComboBox7.Items.Clear()

        AddFacultyName(TextBox8.Text, TextBox39)
        AddRoom(TextBox8.Text, ComboBox37)
    End Sub

    Private Sub ComboBox37_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox37.SelectedIndexChanged
        ComboBox22.Items.Clear()
        AddCourse(TextBox8.Text, ComboBox37.SelectedItem, ComboBox22)
        AddRemarks(ComboBox7)

    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox22.SelectedIndexChanged
        TextBox22.Clear()
        TextBox51.Clear()
        AddTime(TextBox8.Text, ComboBox37.SelectedItem, ComboBox22.SelectedItem, TextBox22, TextBox51)

    End Sub
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        ComboBox40.Items.Clear()
        ComboBox25.Items.Clear()
        TextBox25.Clear()
        TextBox50.Clear()
        ComboBox10.Items.Clear()

        AddFacultyName(TextBox11.Text, TextBox38)
        AddRoom(TextBox11.Text, ComboBox40)
    End Sub
    Private Sub ComboBox40_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox40.SelectedIndexChanged
        ComboBox25.Items.Clear()
        AddCourse(TextBox11.Text, ComboBox40.SelectedItem, ComboBox25)
        AddRemarks(ComboBox10)
    End Sub

    Private Sub ComboBox25_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox25.SelectedIndexChanged
        TextBox25.Clear()
        TextBox50.Clear()
        AddTime(TextBox11.Text, ComboBox40.SelectedItem, ComboBox25.SelectedItem, TextBox25, TextBox50)
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        ComboBox39.Items.Clear()
        ComboBox24.Items.Clear()
        TextBox24.Clear()
        TextBox49.Clear()
        ComboBox9.Items.Clear()

        AddFacultyName(TextBox10.Text, TextBox37)
        AddRoom(TextBox10.Text, ComboBox39)
    End Sub
    Private Sub ComboBox39_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox39.SelectedIndexChanged
        ComboBox24.Items.Clear()
        AddCourse(TextBox10.Text, ComboBox39.SelectedItem, ComboBox24)
        AddRemarks(ComboBox9)

    End Sub

    Private Sub ComboBox24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox24.SelectedIndexChanged
        TextBox24.Clear()
        TextBox49.Clear()
        AddTime(TextBox10.Text, ComboBox39.SelectedItem, ComboBox24.SelectedItem, TextBox24, TextBox49)
    End Sub
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        ComboBox42.Items.Clear()
        ComboBox27.Items.Clear()
        TextBox27.Clear()
        TextBox48.Clear()
        ComboBox12.Items.Clear()

        AddFacultyName(TextBox13.Text, TextBox36)
        AddRoom(TextBox13.Text, ComboBox42)
    End Sub
    Private Sub ComboBox42_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox42.SelectedIndexChanged
        ComboBox27.Items.Clear()
        AddCourse(TextBox13.Text, ComboBox42.SelectedItem, ComboBox27)
        AddRemarks(ComboBox12)

    End Sub

    Private Sub ComboBox27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox27.SelectedIndexChanged
        TextBox27.Clear()
        TextBox48.Clear()
        AddTime(TextBox13.Text, ComboBox42.SelectedItem, ComboBox27.SelectedItem, TextBox27, TextBox48)
    End Sub
    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        ComboBox41.Items.Clear()
        ComboBox26.Items.Clear()
        TextBox26.Clear()
        TextBox47.Clear()
        ComboBox11.Items.Clear()

        AddFacultyName(TextBox12.Text, TextBox35)
        AddRoom(TextBox12.Text, ComboBox41)
    End Sub
    Private Sub ComboBox41_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox41.SelectedIndexChanged
        ComboBox26.Items.Clear()
        AddCourse(TextBox12.Text, ComboBox41.SelectedItem, ComboBox26)
        AddRemarks(ComboBox11)

    End Sub

    Private Sub ComboBox26_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox26.SelectedIndexChanged
        TextBox26.Clear()
        TextBox47.Clear()
        AddTime(TextBox12.Text, ComboBox41.SelectedItem, ComboBox26.SelectedItem, TextBox26, TextBox47)
    End Sub
    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        ComboBox44.Items.Clear()
        ComboBox29.Items.Clear()
        TextBox29.Clear()
        TextBox33.Clear()
        ComboBox14.Items.Clear()

        AddFacultyName(TextBox15.Text, TextBox34)
        AddRoom(TextBox15.Text, ComboBox44)
    End Sub
    Private Sub ComboBox44_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox44.SelectedIndexChanged
        ComboBox29.Items.Clear()
        AddCourse(TextBox15.Text, ComboBox44.SelectedItem, ComboBox29)
        AddRemarks(ComboBox14)

    End Sub
    Private Sub ComboBox29_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox29.SelectedIndexChanged
        TextBox29.Clear()
        TextBox33.Clear()
        AddTime(TextBox15.Text, ComboBox44.SelectedItem, ComboBox29.SelectedItem, TextBox29, TextBox33)
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        ComboBox43.Items.Clear()
        ComboBox28.Items.Clear()
        TextBox28.Clear()
        TextBox17.Clear()
        ComboBox13.Items.Clear()

        AddFacultyName(TextBox14.Text, TextBox32)
        AddRoom(TextBox14.Text, ComboBox43)
    End Sub
    Private Sub ComboBox43_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox43.SelectedIndexChanged
        ComboBox28.Items.Clear()
        AddCourse(TextBox14.Text, ComboBox43.SelectedItem, ComboBox28)
        AddRemarks(ComboBox13)

    End Sub

    Private Sub ComboBox28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox28.SelectedIndexChanged
        TextBox28.Clear()
        TextBox17.Clear()
        AddTime(TextBox14.Text, ComboBox43.SelectedItem, ComboBox28.SelectedItem, TextBox28, TextBox17)
    End Sub
    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        ComboBox45.Items.Clear()
        ComboBox30.Items.Clear()
        TextBox30.Clear()
        TextBox1.Clear()
        ComboBox15.Items.Clear()

        AddFacultyName(TextBox16.Text, TextBox31)
        AddRoom(TextBox16.Text, ComboBox43)
    End Sub
    Private Sub ComboBox45_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox45.SelectedIndexChanged
        ComboBox30.Items.Clear()
        AddCourse(TextBox16.Text, ComboBox45.SelectedItem, ComboBox30)
        AddRemarks(ComboBox15)
    End Sub

    Private Sub ComboBox30_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox30.SelectedIndexChanged
        TextBox30.Clear()
        TextBox1.Clear()
        AddTime(TextBox16.Text, ComboBox45.SelectedItem, ComboBox30.SelectedItem, TextBox30, TextBox1)
    End Sub
End Class