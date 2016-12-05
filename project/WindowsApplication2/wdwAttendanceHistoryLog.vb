Public Class wdwAttendanceHistoryLog
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer

    Private Sub wdwAttendanceHistoryLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub
    Private Sub Load_form()
        bttnSearch.Enabled = False

        'dbAccess.Fill_Data_Grid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' , a.checker 'Checker'
        'From introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r, term t, academicyear ac, department d, college co
        'where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid
        'order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        If BttnToggle.Text = "Attendance" Then
            dbAccess.Fill_Data_Grid("Select a.attendanceid 'Attendance Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid
                                order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        ElseIf BttnToggle.Text = "Makeup" Then
            dbAccess.Fill_Data_Grid("Select m.makeupid 'Makeup Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (m.status = 'A' or m.status = 'R')  and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid
                                order by m.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        End If


    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Load_form()
        Me.Focus()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click

        Dim Search As String = Nothing

        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"

        ' dbAccess.Fill_Data_Grid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' , a.checker 'Checker'
        ' From introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r, term t, academicyear ac, department d, college co
        'where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid and (f.facultyid like '" + Search.ToString + "' or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_middlename, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname, ' ', f_middlename) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or ((f.f_firstname LIKE '" + Search.ToString + "') or (f.f_middlename LIKE '" + Search.ToString + "') or (f.f_lastname LIKE '" + Search.ToString + "')))
        '                         order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        If BttnToggle.Text = "Attendance" Then
            dbAccess.Fill_Data_Grid("Select a.attendanceid 'Attendance Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid and (f.facultyid like '" + Search.ToString + "' or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_middlename, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname, ' ', f_middlename) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or ((f.f_firstname LIKE '" + Search.ToString + "') or (f.f_middlename LIKE '" + Search.ToString + "') or (f.f_lastname LIKE '" + Search.ToString + "')))
                                order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        ElseIf BttnToggle.Text = "Makeup" Then
            dbAccess.Fill_Data_Grid("Select m.makeupid 'Makeup Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (m.status = 'A' or m.status = 'R')  and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid  and (f.facultyid like '" + Search.ToString + "' or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_middlename, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ', ', f_firstname, ' ', f_middlename) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or ((f.f_firstname LIKE '" + Search.ToString + "') or (f.f_middlename LIKE '" + Search.ToString + "') or (f.f_lastname LIKE '" + Search.ToString + "')))
                                order by m.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        End If

    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxSearch.Text = Nothing
        Load_form()
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        If BttnToggle.Text = "Attendance" Then
            popAddAttendanceHistory.Show()
        ElseIf BttnToggle.Text = "Makeup" Then
            MsgBox("add makeup")
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        With grid
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count > 0 Then
                For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                    selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                    If BttnToggle.Text = "Attendance" Then
                        dbAccess.Update_Data("UPDATE `attendance` SET `status` = 'D' WHERE `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                    ElseIf BttnToggle.Text = "Makeup" Then
                        dbAccess.Update_Data("UPDATE `makeup` SET `status` = 'D' WHERE `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                    End If
                Next

                Load_form()

            Else
                MsgBox("No selected attendance", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
    End Sub

    Public Function getRefNo() As Integer
        Return rowData(0)
    End Function

    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        If (String.IsNullOrEmpty(txtbxSearch.Text) Or String.IsNullOrWhiteSpace(txtbxSearch.Text)) Then
            bttnSearch.Enabled = False
        Else
            bttnSearch.Enabled = True
        End If
    End Sub
    Private Sub grid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid.CellMouseDoubleClick
        rindexValue = e.RowIndex
        With grid
            rowData.Clear()
            Dim selectedRow As DataGridViewRow
            Dim colCount As Integer
            colCount = grid.ColumnCount
            'MsgBox(colCount)
            If .SelectedRows.Count = 0 Then
                MsgBox("No rows selected!", MsgBoxStyle.Critical, "")

            ElseIf .SelectedRows.Count = 1 Then
                selectedRow = grid.Rows(rindexValue)
                For ctr As Integer = 0 To colCount - 1
                    If String.IsNullOrEmpty(selectedRow.Cells(ctr).Value.ToString) Then
                        MsgBox("Missing data!", MsgBoxStyle.Critical, "")
                        rowData.Add(selectedRow.Cells(ctr).Value.ToString)
                    Else
                        rowData.Add(selectedRow.Cells(ctr).Value.ToString)

                    End If
                Next

                Me.Enabled = False
                If BttnToggle.Text = "Attendance" Then
                    wdwMoreInfo.Load_Attendance_Form(rowData)
                ElseIf BttnToggle.text = "Makeup" Then
                    wdwMoreInfo.Load_Makeup_Form(rowData)
                    'MsgBox("moreinfo")
                    'Enable_Form()
                End If

            Else
                    MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttnToggle.Click
        If BttnToggle.Text.Equals("Attendance") Then
            BttnToggle.Text = "Makeup"
            dbAccess.Fill_Data_Grid("Select m.makeupid 'Makeup Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (m.status = 'A' or m.status = 'R')  and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid
                                order by m.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)
        ElseIf BttnToggle.Text.Equals("Makeup") Then
            BttnToggle.Text = "Attendance"
            dbAccess.Fill_Data_Grid("Select a.attendanceid 'Attendance Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.department d, introse.college co
                                where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid
                                order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)
        End If
    End Sub
End Class