Public Class wdwAttendanceHistoryLog
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer
    Public facultyID As String

    Private Function Check_Button(ByVal bttn As Button) As Boolean
        Dim checkButton As Boolean = False
        If (bttn.Enabled = False) Then
            checkButton = False

        Else
            checkButton = True
        End If
        Return checkButton
    End Function

    Private Function Check_fac(id As String) As Boolean
        Dim checkFac As Boolean = False
        Dim fac As New Object
        fac = dbAccess.Get_Data("select facref_no from introse.faculty where facultyid = '" & id & "';", "facref_no")
        If String.IsNullOrEmpty(fac) Then
            checkFac = False

            BttnAttendance.Enabled = False
            BttnMakeup.Enabled = False
            bttnAdd.Enabled = False
            bttnModify.Enabled = False
            bttnDelete.Enabled = False

            MsgBox("No Records matched!", MsgBoxStyle.Critical, "")
        Else
            BttnAttendance.Enabled = True
            BttnMakeup.Enabled = True
            bttnAdd.Enabled = True
            bttnModify.Enabled = True
            bttnDelete.Enabled = True
            checkFac = True
        End If
        Return checkFac
    End Function

    'Public Sub back_form(id As String)

    '    If BttnAttendance.Enabled = True Then
    '        MsgBox("back_attendance")
    '        dbAccess.Fill_Data_Grid("Select a.attendanceid 'Attendance Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
    '                            from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.department d, introse.college co
    '                            where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" + id + "'
    '                            order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

    '    ElseIf BttnMakeup.Enabled = True Then
    '        MsgBox("back_makeup")
    '        dbAccess.Fill_Data_Grid("Select m.makeupid 'Makeup Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
    '                            from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.department d, introse.college co
    '                            where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (m.status = 'A' or m.status = 'R')  and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid  and f.facultyid = '" + id + "'
    '                            order by m.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)


    '    End If
    'End Sub
    Public Sub Load_form(id As String)

        '  If BttnAttendance.Enabled = True Then

        'MsgBox("Load_attendance")
        '    dbAccess.Fill_Data_Grid("Select a.attendanceid 'Attendance Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
        '                        from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.department d, introse.college co
        '                        where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (a.status = 'A' or a.status = 'R') and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" + id + "'
        '                        order by a.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        ' BttnMakeup.Enabled = True

        ' ElseIf BttnMakeup.Enabled = True Then
        'MsgBox("Load_makeup")
        '    dbAccess.Fill_Data_Grid("Select m.makeupid 'Makeup Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', d.departmentname 'Department', co.college_name 'College', t.term_no 'Term', concat(ac.yearstart, '-', ac.yearend) 'Academic Year'
        '                        from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.department d, introse.college co
        '                        where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (m.status = 'A' or m.status = 'R')  and f.departmentid = d.departmentid and d.college_code = co.college_code and c.termid = t.termid and t.yearid = ac.yearid  and f.facultyid = '" + id + "'
        '                        order by m.enc_date and concat(ac.yearstart, '-', ac.yearend) and t.term_no LIMIT 1000 ;", grid)

        '    BttnAttendance.Enabled = True

        ' End If
        ' MsgBox("Inside load: " + BttnAttendance.Text)
        If Check_fac(id) Then
            txtbxFacID.Text = id
            txtbxName.Text = dbAccess.Get_Data("select concat(f_lastname, ', ', f_firstname, ' ', f_middlename) from introse.faculty where facultyid = '" & id & "';", "concat(f_lastname, ', ', f_firstname, ' ', f_middlename)")
            facultyID = txtbxFacID.Text

            If BttnAttendance.Text = "Attendance" Then
                '  MsgBox("Load_attendance")
                dbAccess.Fill_Data_Grid("select a.attendanceid 'Attendance Reference No', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', t.term_no 'Term', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section'
                                from introse.attendance a, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.course cl, introse.faculty f
                                where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and (a.status = 'A' or a.status = 'R') and c.course_id = cl.course_id and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" + id + "' and f.facref_no = c.facref_no
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)

            ElseIf BttnAttendance.Text = "Make-up Class" Then
                ' MsgBox("Load_makeup")
                dbAccess.Fill_Data_Grid("select m.makeupid 'Makeup Reference No', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', t.term_no 'Term', m.makeup_date 'Make-Up Date', cl.course_cd 'Course', c.section 'Section'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.course cl
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (c.status = 'A' or c.status = 'R') and (m.status = 'A' or m.status = 'R') and cl.course_id = c.course_id and c.termid = t.termid and t.yearid = ac.yearid  and f.facultyid = '" + id + "'
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)

            End If
        Else
            txtbxFacID.Clear()
            txtbxName.Clear()
            grid.DataSource = Nothing
            grid.Rows.Clear()

        End If

    End Sub

    Public Sub Enable_Form()
        Me.Show()
        Me.Enabled = True
        ' back_form(popFacSearch.get_Faculty_id)
        Load_form(popFacSearch.get_Faculty_id)
        Me.Focus()
    End Sub

    Public Sub Enable_After_Search_Form()
        Me.Show()
        Me.Enabled = True
        Me.Focus()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        popFacSearch.Show()
        popFacSearch.Enable_Form()
        popFacSearch.Set_Path("History")
        Me.Enabled = False
    End Sub
    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        'If BttnAttendance.Enabled = True Then
        'popAddAttendanceHistory.Show()
        'ElseIf BttnMakeup.Enabled = True Then
        'MsgBox("add makeup")
        '  Enable_Form()

        'End If


        If BttnAttendance.Text = "Attendance" Then
            popAddAttendanceHistory.Show()
        ElseIf BttnAttendance.Text = "Make-up Class" Then
            popAddMakeUpHistory.Show()
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        Try
            With grid
                Dim selectedRow As DataGridViewRow
                If .SelectedRows.Count > 0 Then
                    For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                        selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                        '               If BttnAttendance.Enabled = False Then
                        'dbAccess.Update_Data("UPDATE `introse`.`attendance` SET `status` = 'D' WHERE `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                        '              ElseIf BttnMakeup.Enabled = False Then
                        'dbAccess.Update_Data("UPDATE `introse`.`makeup` SET `status` = 'D' WHERE `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                        '             End If
                        If BttnAttendance.Text = "Attendance" Then
                            dbAccess.Update_Data("UPDATE `introse`.`attendance` SET `status` = 'D' WHERE `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                        ElseIf BttnAttendance.Text = "Make-up Class" Then
                            dbAccess.Update_Data("UPDATE `introse`.`makeup` SET `status` = 'D' WHERE `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                        End If
                    Next

                    'back_form(popFacSearch.get_Faculty_id)
                    Load_form(txtbxFacID.Text)

                Else
                    MsgBox("No selected attendance", MsgBoxStyle.Critical, "")

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        popFacSearch.Set_Path("Main")
        popFacSearch.Enable_Form()
    End Sub

    Public Function getRefNo() As Integer
        Return rowData(0)
    End Function
    Private Sub grid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grid.CellMouseDoubleClick
        Try
            rindexValue = e.RowIndex
            With grid
                rowData.Clear()
                Dim selectedRow As DataGridViewRow
                Dim colCount As Integer
                colCount = grid.ColumnCount
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

                    '   If BttnAttendance.Enabled = False Then
                    'MsgBox("attendance")
                    '    wdwMoreInfo.Load_Attendance_Form(rowData)

                    '  ElseIf BttnMakeup.Enabled = False Then
                    'MsgBox("makeup")
                    '    wdwMoreInfo.Load_Makeup_Form(rowData)
                    ' End If
                    If BttnAttendance.Text = "Attendance" Then
                        wdwMoreInfo.Load_Attendance_Form(rowData)
                    ElseIf BttnAttendance.Text = "Make-up Class" Then
                        wdwMoreInfo.Load_Makeup_Form(rowData)
                    End If
                    wdwMoreInfo.Show()
                    Me.Enabled = False

                Else
                    MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

                End If
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttnAttendance.Click
        'Load_form(popFacSearch.get_Faculty_id())
        'If Check_Button(BttnAttendance) = True Then
        '    BttnAttendance.Enabled = False
        '    BttnMakeup.Enabled = True
        'Else
        '    BttnAttendance.Enabled = True
        'End If
        If BttnAttendance.Text = "Attendance" Then
            BttnAttendance.Text = "Make-up Class"
            dbAccess.Fill_Data_Grid("select m.makeupid 'Makeup Reference No', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', t.term_no 'Term', m.makeup_date 'Make-Up Date', cl.course_cd 'Course', c.section 'Section'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.course cl
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (c.status = 'A' or c.status = 'R') and (m.status = 'A' or m.status = 'R') and cl.course_id = c.course_id and c.termid = t.termid and t.yearid = ac.yearid  and f.facultyid = '" & txtbxFacID.Text & "'
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)

        ElseIf BttnAttendance.Text = "Make-up Class" Then
            BttnAttendance.Text = "Attendance"
            dbAccess.Fill_Data_Grid("select a.attendanceid 'Attendance Reference No', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', t.term_no 'Term', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section'
                                from introse.attendance a, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.course cl, introse.faculty f
                                where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and (a.status = 'A' or a.status = 'R') and c.course_id = cl.course_id and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" & txtbxFacID.Text & "' and f.facref_no = c.facref_no
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)
        End If


    End Sub

    Private Sub BttnMakeup_Click(sender As Object, e As EventArgs) Handles BttnMakeup.Click
        'Load_form(popFacSearch.get_Faculty_id())
        ' BttnMakeup.Enabled = False

    End Sub

    Private Sub wdwAttendanceHistoryLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' BttnAttendance.Enabled = False
        ' BttnMakeup.Enabled = True
        'Load_form(popFacSearch.get_Faculty_id)

    End Sub

End Class