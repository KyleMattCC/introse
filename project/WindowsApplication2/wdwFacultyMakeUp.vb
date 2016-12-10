Public Class wdwFacultyMakeUp
    Dim dbAccess As New databaseAccessor
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Load_form()
        Dim DeptValue As String
        rindexValue = 0
        bttnSearch.Enabled = False
        dbAccess.Fill_Data_Grid("select m.makeupid 'Reference no.', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', m.makeup_date 'Makeup date', cl.course_cd 'Course', c.section 'Section', m.room 'Room', m.timestart 'Start time', m.timeend 'End time', m.hours 'Hours', r.reason_des 'Reason', m.enc_date 'Date encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reasons r 
                                where f.status = 'A' and c.status = 'A' and m.status = 'A' and  m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 1, 3, 12;", grid)
        If grid.Rows.Count < 1 Then
            txtbxFacultyID.Text = Nothing
            txtbxFacultyName.Text = Nothing
            txtbxDepartment.Text = Nothing
        ElseIf grid.RowCount >= 1 Then
            txtbxFacultyID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
            txtbxFacultyName.Text = grid.Rows(0).Cells("Name").Value.ToString
            DeptValue = dbAccess.Get_Data("select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacultyID.Text + "' and department.departmentid = faculty.departmentid and faculty.status = 'A';", "departmentname")
            txtbxDepartment.Text = DeptValue.ToString
        End If
    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Load_form()
        Me.Focus()

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If txtbxSearch.Text = Nothing Then
            Load_form()
            'Else
            'Search_Click(sender, e)
        End If
    End Sub

    'Private Sub Search_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click

    'Dim DeptValue As String

    'Dim Search As String = Nothing



    '   Search += "%"
    '   Search += txtbxSearch.Text
    '   Search += "%"

    '   dbAccess.Fill_Data_Grid("select a.attendanceid 'Reference No', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date Encoded', a.encoder 'Encoder'
    'from introse.faculty f, introse.department d , introse.attendance a, introse.courseoffering c, introse.remarks r, introse.course cl
    'where f.status = 'A' and c.status = 'A' and a.status = 'A' and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'and c.courseoffering_id = a.courseoffering_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and c.course_id = cl.course_id and f.departmentid = d.departmentid and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "') or (cl.course_cd LIKE '" + Search.ToString + "') or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "'))", grid)


    '    If grid.Rows.Count < 1 Then
    '      txtbxFacultyID.Text = Nothing
    '     txtbxFacultyName.Text = Nothing
    '      txtbxDepartment.Text = Nothing
    '   ElseIf grid.RowCount >= 1 Then
    '       txtbxFacultyID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
    '      txtbxFacultyName.Text = grid.Rows(0).Cells("Name").Value.ToString
    '     DeptValue = dbAccess.Get_Data("select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacultyID.Text + "' and department.departmentid = faculty.departmentid and faculty.status = 'A';", "departmentname")
    '    txtbxDepartment.Text = DeptValue.ToString
    'End If


    '    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxSearch.Text = Nothing
        Load_form()
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        popAddMakeUp.Show()

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        With grid
            rowData.Clear()
            Dim selectedRow As DataGridViewRow
            Dim colCount As Integer
            colCount = grid.ColumnCount
            If .SelectedRows.Count = 0 Then
                MsgBox("No row selected!", MsgBoxStyle.Critical, "")

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
                popModMakeup.Load_Form(rowData)

            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub bttnDelete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        With grid
            Dim result As DialogResult
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count > 0 Then
                result = MsgBox("Are you sure you want to delete " & .SelectedRows.Count & " row/s?", MsgBoxStyle.YesNo, "")
                If result = DialogResult.Yes Then

                    For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                        selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                        dbAccess.Update_Data("update `makeup` set `status` = 'D' where `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                    Next

                    Load_form()
                End If

            Else
                MsgBox("No row/s selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

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

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        If (String.IsNullOrEmpty(txtbxSearch.Text) Or String.IsNullOrWhiteSpace(txtbxSearch.Text)) Then

            bttnSearch.Enabled = False
        Else
            bttnSearch.Enabled = True
        End If

        If (txtbxSearch.Text = Nothing) Then
            Load_form()
        End If
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        rindexValue = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim DeptValue As String

        If (rindexValue <> -1) Then
            selectedRow = grid.Rows(rindexValue)
            If IsDBNull(rindexValue) Then
                txtbxFacultyID.Text = Nothing
                txtbxFacultyName.Text = Nothing
                txtbxDepartment.Text = Nothing

            Else
                txtbxFacultyID.Text = selectedRow.Cells("Faculty ID").Value.ToString
                txtbxFacultyName.Text = selectedRow.Cells("Name").Value.ToString
                DeptValue = dbAccess.Get_Data("select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacultyID.Text + "' and department.departmentid = faculty.departmentid and faculty.status = 'A';", "departmentname")
                txtbxDepartment.Text = DeptValue.ToString

            End If
        End If
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Dim Search As String = Nothing
        Dim DeptValue As String


        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"


        dbAccess.Fill_Data_Grid("Select distinct m.makeupid 'Reference', m.makeup_date 'Make-up date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                    from faculty f, department d , makeup m, courseoffering c, reason r, course cl
                                    where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' and c.facref_no = f.facref_no and c.course_id = cl.course_id and m.status = 'A' and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename like '" + Search.ToString + "') or (f_lastname like '" + Search.ToString + "') or (cl.course_cd like '" + Search.ToString + "') or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname,' ', ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' ,f_firstname) like '" + Search.ToString + "'))
                                    order by 1, 3, 12;", grid)

        If grid.Rows.Count < 1 Then
            txtbxFacultyID.Text = Nothing
            txtbxFacultyName.Text = Nothing
            txtbxDepartment.Text = Nothing
        ElseIf grid.RowCount >= 1 Then
            txtbxFacultyID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
            txtbxFacultyName.Text = grid.Rows(0).Cells("Name").Value.ToString
            DeptValue = dbAccess.Get_Data("Select departmentname from department, faculty where facultyid = '" + txtbxFacultyID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
            txtbxDepartment.Text = DeptValue.ToString
        End If

    End Sub


    'Private Sub grid_Click(sender As Object, e As EventArgs) Handles grid.Click

    'End Sub

    '   Private Sub grid_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles grid.RowStateChanged
    '
    '  End Sub
End Class