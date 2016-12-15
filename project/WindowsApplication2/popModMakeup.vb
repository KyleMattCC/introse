Public Class popModMakeup
    Dim dbAccess As New databaseAccessor

    Private Sub wdwModMakeup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(rowData As List(Of String))
        Dim convertedDate As Date
        Dim day, month, year As String

        Add_Reasons(cmbbxReason)
        Add_Course(rowData(1), cmbbxCourse)
        Add_Section(rowData(1), rowData(4), cmbbxSection)

        If rowData.Count > 0 Then
            If String.IsNullOrEmpty(rowData(3)) Then
                txtbxFacID.Text = rowData(1) ' fid
                Add_Faculty_Name(txtbxFacID.Text, txtbxName) ' name
                cmbbxCourse.SelectedItem = rowData(4) ' course
                cmbbxSection.SelectedItem = rowData(5) ' section
                txtbxRoom.Text = rowData(6) ' room
                txtbxStart.Text = rowData(7) 'start
                txtbxEnd.Text = rowData(8) ' end
                cmbbxReason.SelectedItem = rowData(10)
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
                txtbxStart.Text = rowData(7) 'start
                txtbxEnd.Text = rowData(8) ' end
                cmbbxReason.SelectedItem = rowData(10)

                dtp.Value = New Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))

            End If
        End If

        Me.Show()
    End Sub

    Private Sub Add_Faculty_Name(facultyId As String, ByVal text As TextBox)
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

            facName = dbAccess.Get_Multiple_Column_Data("select f_firstname, f_middlename, f_lastname from faculty where status = 'A' and facultyid = '" & facultyId & "';", 3)
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

    Private Sub Add_Course(facultyId As String, ByVal combo As ComboBox)
        Dim courseCode As New List(Of Object)()
        Dim fac As Integer
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            courseCode = dbAccess.Get_Multiple_Row_Data("select DISTINCT(c.course_cd) 
                                                    from introse.course c, introse.courseoffering co, introse.attendance a 
                                                    where co.status = 'A' and a.status = 'A' and co.courseoffering_id = a.courseoffering_id and co.facref_no = '" & fac & "' and co.course_id = c.course_id order by 1;")

            For ctr As Integer = 0 To courseCode.Count - 1
                combo.Items.Add(courseCode(ctr))
            Next
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Add_Section(facultyId As String, course As String, ByVal combo As ComboBox)
        Dim section As New List(Of Object)()
        Dim fac As String
        combo.Enabled = True
        combo.Items.Clear()

        Try
            fac = dbAccess.Get_Data("select facref_no from introse.faculty where status = 'A' and facultyid = '" & facultyId & "';", "facref_no")
            section = dbAccess.Get_Multiple_Row_Data("select DISTINCT(co.section) 
                                                from introse.course c, introse.courseoffering co, introse.attendance a 
                                                where co.status = 'A' and a.status = 'A' and c.course_cd = '" & course & "' and co.course_id = c.course_id and co.facref_no = '" & fac & "' and co.courseoffering_id = a.courseoffering_id order by 1;")

            For ctr As Integer = 0 To section.Count - 1
                combo.Items.Add(section(ctr))
            Next
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
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
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        txtbxName.Clear()
        cmbbxCourse.Items.Clear()
        cmbbxSection.Items.Clear()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxRoom.Clear()
        Add_Faculty_Name(txtbxFacID.Text, txtbxName)
        Add_Course(txtbxFacID.Text, cmbbxCourse)
        Check_Enable()
        Check_Element_Enable()

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        cmbbxSection.Items.Clear()
        txtbxEnd.Clear()
        txtbxStart.Clear()
        txtbxRoom.Clear()
        Add_Section(txtbxFacID.Text, cmbbxCourse.SelectedItem.ToString, cmbbxSection)
        cmbbxReason.SelectedIndex = -1
        Check_Enable()

    End Sub

    Private Sub cmbbxSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSection.SelectedIndexChanged
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
        If (String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrWhiteSpace(txtbxFacID.Text)) Or (String.IsNullOrEmpty(txtbxName.Text) Or String.IsNullOrWhiteSpace(txtbxName.Text)) Or cmbbxCourse.SelectedIndex = -1 Or cmbbxSection.SelectedIndex = -1 Or (String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrWhiteSpace(txtbxRoom.Text)) Or (String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrWhiteSpace(txtbxStart.Text)) Or (String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrWhiteSpace(txtbxEnd.Text)) Or cmbbxReason.SelectedIndex = -1 Then
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

    Private Sub txtFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        validateInput("1234567890", e)
    End Sub

    Private Sub txtbxStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStart.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxEnd.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxRoom.KeyPress
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", e)
    End Sub

    Private Sub txtbxEncoder_KeyPress(sender As Object, e As KeyPressEventArgs)
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ", e)
    End Sub

    Private Function Check_Entry(makeup As String, startTime As Integer, endTime As Integer, room As String, stat As String, courseOfferingId As String, ref As Integer) As Boolean
        Dim makeupCheck As New List(Of Object)()
        Dim b As Boolean = False

        makeupCheck = dbAccess.Get_Multiple_Row_Data("select makeupid
                                         from introse.makeup
                                         where status = '" & stat & "' and courseoffering_id = " & courseOfferingId & " and makeup_date = '" & makeup & "' and timestart = " & startTime & " and timeend = " & endTime & " and room = '" & room & "';")
        If makeupCheck.Count < 2 Then
            If makeupCheck(0) = ref Then
                b = True
            End If
        Else
            MsgBox("Duplicate makeup class entry!", MsgBoxStyle.Critical, "")
        End If
        Return b

    End Function

    Private Sub bttnModify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim makeupDate, course, section, room, reason, courseOfferingId As String
        Dim startTime, endTime, tempStart, tempEnd As Integer
        Dim absentHours As Double = dbAccess.Get_Data("Select sum(co.hours)
                                                      From introse.attendance a, introse.courseoffering co, introse.course c
                                                      where co.status = 'A' and a.status = 'A' and c.course_cd = '" & cmbbxCourse.SelectedItem & "' and c.course_id = co.course_id and co.section = '" & cmbbxSection.SelectedItem & "' and a.courseoffering_id = co.courseoffering_id;", "sum(co.hours)")
        Dim ref As Integer = wdwFacultyMakeUp.getRefNo()

        If Convert.ToInt32(ref) > 0 Then
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

                If ((startTime < 0 Or startTime > 2359) Or (startTime / 100 > 24 Or startTime Mod 100 > 59)) Then
                    MsgBox("Invalid start time input!", MsgBoxStyle.Critical, "")
                ElseIf ((endTime < 0 Or endTime > 2359) Or (endTime / 100 > 24 Or endTime Mod 100 > 59)) Then
                    MsgBox("Invalid end time input!", MsgBoxStyle.Critical, "")
                ElseIf (endTime < startTime) Then
                    MsgBox("End time cannot be less than start time!", MsgBoxStyle.Critical, "")
                ElseIf (startTime = endTime) Then
                    MsgBox("Start and end time cannot be the same!", MsgBoxStyle.Critical, "")
                ElseIf (Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = .0) And Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = 0.5)) Then
                    MsgBox("Makeup hours is not exact!", MsgBoxStyle.Critical, "")
                Else
                    Try
                        makeupDate = dtp.Value.Date.ToString("yyyy-MM-dd")
                        course = cmbbxCourse.SelectedItem
                        section = cmbbxSection.SelectedItem
                        room = txtbxRoom.Text
                        reason = dbAccess.Get_Data("select reason_cd from introse.reasons where reason_des = '" & cmbbxReason.SelectedItem.ToString & "';", "reason_cd")
                        courseOfferingId = dbAccess.Get_Data("select courseoffering_id 
                                                           from introse.courseoffering c, introse.course cl 
                                                            where c.status = 'A' and cl.course_cd = '" & course & "' and c.course_id = cl.course_id and c.section = '" & section & "';", "courseoffering_id")

                        If (Check_Entry(makeupDate, startTime, endTime, room, "A", courseOfferingId, ref)) Then
                            dbAccess.Update_Data("update `introse`.`makeup` set `courseoffering_id` = " & courseOfferingId & ", `timestart` = " & txtbxStart.Text & ", `timeend` = " & txtbxEnd.Text & ", `hours` = " & (wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) & ", `room` = '" & room & "', `reason_cd` = '" & reason & "', `makeup_date` = '" & makeupDate & "', `enc_date` = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "', `encoder` =  '" & wdwLogin.Get_Encoder & "' WHERE makeupid = '" & ref & "' and status = 'A';")
                            Me.Close()
                        End If

                    Catch Ex As Exception
                        System.Windows.Forms.MessageBox.Show(Ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwFacultyMakeUp.Enable_Form()
    End Sub

End Class