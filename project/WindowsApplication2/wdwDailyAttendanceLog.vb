Public Class wdwDailyAttendanceLog
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer

    Private Sub wdwDailyAttendanceLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Load_form()
        Dim DeptValue As String
        bttnSearch.Enabled = False

        dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder' , a.checker 'Checker'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.status = 'A' and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 3, 12;", grid)
        If grid.Rows.Count < 1 Then
            txtbxFacID.Text = Nothing
            txtbxName.Text = Nothing
            txtbxDept.Text = Nothing
        ElseIf grid.RowCount >= 1 Then
            txtbxFacID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
            txtbxName.Text = grid.Rows(0).Cells("Name").Value.ToString
            DeptValue = dbAccess.getData("Select departmentname from department, faculty where facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
            txtbxDept.Text = DeptValue.ToString
        End If

    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Load_form()
        Me.Focus()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If txtbxSearch.Text = Nothing Then
            Load_form()
        Else
            Search_Click(sender, e)
        End If

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click

        Dim DeptValue As String
        Dim FacultyID As String
        Dim Search As String = Nothing
        Dim Course As String


        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"

        FacultyID = dbAccess.getData("Select facultyid From faculty f, department d 
                                    Where f.status = 'A' and f.departmentid = d.departmentid And ((facultyid Like '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "'))", "facultyid")
        Course = dbAccess.getData("Select course_cd from course c, courseoffering o
                                    where o.status = 'A' and c.course_id = o.course_id and ((course_cd LIKE '" + Search.ToString + "') or (course_name LIKE '" + Search.ToString + "') or (section LIKE '" + Search.ToString + "') or (room LIKE '" + Search.ToString + "'))", "course_cd")

        If FacultyID <> Nothing Then
            dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder', a.checker 'Checker'
                                    from faculty f, department d , attendance a, courseoffering c, remarks r, course cl
                                    where a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'and c.courseoffering_id = a.courseoffering_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and c.course_id = cl.course_id and a.status = 'A' and f.departmentid = d.departmentid and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "'))", grid)

            If grid.Rows.Count < 1 Then
                txtbxFacID.Text = Nothing
                txtbxName.Text = Nothing
                txtbxDept.Text = Nothing
            ElseIf grid.RowCount >= 1 Then
                txtbxFacID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
                txtbxName.Text = grid.Rows(0).Cells("Name").Value.ToString
                DeptValue = dbAccess.getData("Select departmentname from department, faculty where facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
                txtbxDept.Text = DeptValue.ToString
            End If


        Else
            dbAccess.fillDataGrid("Select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder', a.checker 'Checker'
                                    from faculty f, department d , attendance a, courseoffering c, remarks r, course cl
                                    where a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'and c.courseoffering_id = a.courseoffering_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and c.course_id = cl.course_id and a.status = 'A' and f.departmentid = d.departmentid and ((cl.course_cd LIKE '" + Search.ToString + "') or (cl.course_name LIKE '" + Search.ToString + "') or (c.section LIKE '" + Search.ToString + "'))", grid)
            If grid.Rows.Count < 1 Then
                txtbxFacID.Text =
                txtbxName.Text = Nothing
                txtbxDept.Text = Nothing
            ElseIf grid.RowCount >= 1 Then
                txtbxFacID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
                txtbxName.Text = grid.Rows(0).Cells("Name").Value.ToString
                DeptValue = dbAccess.getData("Select departmentname from department, faculty where facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
                txtbxDept.Text = DeptValue.ToString
            End If
        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxSearch.Text = Nothing
        Load_form()
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        popEncFacDaily.Show()
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        With grid
            rowData.Clear()
            Dim selectedRow As DataGridViewRow = grid.Rows(rindexValue)
            Dim colCount As Integer
            colCount = grid.ColumnCount
            MsgBox(colCount)
            If .SelectedRows.Count = 1 Then

                For ctr As Integer = 0 To colCount - 1
                    If String.IsNullOrEmpty(selectedRow.Cells(ctr).Value.ToString) Then
                        MsgBox("Missing data!")
                        rowData.Add(selectedRow.Cells(ctr).Value.ToString)
                    Else
                        rowData.Add(selectedRow.Cells(ctr).Value.ToString)

                    End If
                Next

                Me.Enabled = False
                wdwModFacultyDaily.Load_Form(rowData)

            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")
            End If
        End With
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        With grid
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count > 0 Then
                For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                    selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                    dbAccess.updateData("UPDATE `attendance` SET `status` = 'D' WHERE `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
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

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick
        rindexValue = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim DeptValue As String

        If (rindexValue <> -1) Then
            selectedRow = grid.Rows(rindexValue)
            If IsDBNull(rindexValue) Then
                txtbxFacID.Text = Nothing
                txtbxName.Text = Nothing
                txtbxDept.Text = Nothing

            Else
                txtbxFacID.Text = selectedRow.Cells("Faculty ID").Value.ToString
                txtbxName.Text = selectedRow.Cells("Name").Value.ToString
                DeptValue = dbAccess.getData("Select departmentname from department, faculty where facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid and faculty.status = 'A';", "departmentname")
                txtbxDept.Text = DeptValue.ToString

            End If
        End If
    End Sub

    Private Sub grid_MouseClick(sender As Object, e As MouseEventArgs) Handles grid.MouseClick

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
    End Sub

    Public Function getRefNo() As Integer
        Return rowData(0)
    End Function

    Public Function getDTPValue() As Date
        Return dtp.Value
    End Function

    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        If (String.IsNullOrEmpty(txtbxSearch.Text) Or String.IsNullOrWhiteSpace(txtbxSearch.Text)) Then
            bttnSearch.Enabled = False
        Else
            bttnSearch.Enabled = True
        End If
    End Sub
End Class