Public Class wdwDailyAttendanceLog
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer

    Private Sub wdwDailyAttendanceLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Load_form()
        If wdwLogin.Get_accountType.Equals("Regular") Then
            bttnAdd.Enabled = True
            bttnDelete.Enabled = False
            bttnModify.Enabled = False
        Else
            bttnAdd.Enabled = True
            bttnDelete.Enabled = True
            bttnModify.Enabled = True
        End If

        Dim DeptValue As String
        rindexValue = 0
        bttnSearch.Enabled = False

        dbAccess.Fill_Data_Grid("select a.attendanceid 'Reference no.', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date encoded', a.encoder 'Encoder' , a.checker 'Checker'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c, introse.course cl, introse.remarks r 
                                where f.status = 'A' and c.status = 'A' and a.status = 'A' and a.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 1, 3, 12;", grid)
        If grid.Rows.Count < 1 Then
            txtbxFacID.Text = Nothing
            txtbxName.Text = Nothing
            txtbxDept.Text = Nothing
        ElseIf grid.RowCount >= 1 Then
            txtbxFacID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
            txtbxName.Text = grid.Rows(0).Cells("Name").Value.ToString
            DeptValue = dbAccess.Get_Data("select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
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

        Dim Search As String = Nothing
        Dim Comma As Char = ","



        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"

        dbAccess.Fill_Data_Grid("select a.attendanceid 'Reference no.', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', a.absent_date 'Absent date', cl.course_cd 'Course', c.section 'Section',  c.room 'Room', c.daysched 'Day', c.timestart 'Start time', c.timeend 'End time', r.remark_des 'Remarks', a.enc_date 'Date encoded', a.encoder 'Encoder' , a.checker 'Checker'
                                    from introse.faculty f, introse.department d , introse.attendance a, introse.courseoffering c, introse.remarks r, introse.course cl
                                    where f.status = 'A' and c.status = 'A' and a.status = 'A' and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'and c.courseoffering_id = a.courseoffering_id and c.facref_no = f.facref_no and a.remarks_cd = r.remark_cd and c.course_id = cl.course_id and f.departmentid = d.departmentid and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "') or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname,' ', ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' ,f_firstname) like '" + Search.ToString + "'))
                                    order by 1, 3, 12;", grid)


        If grid.Rows.Count < 1 Then
            txtbxFacID.Text = Nothing
            txtbxName.Text = Nothing
            txtbxDept.Text = Nothing
        ElseIf grid.RowCount >= 1 Then
            txtbxFacID.Text = grid.Rows(0).Cells("Faculty ID").Value.ToString
            txtbxName.Text = grid.Rows(0).Cells("Name").Value.ToString
            DeptValue = dbAccess.Get_Data("Select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
            txtbxDept.Text = DeptValue.ToString
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
                wdwModFacultyDaily.Load_Form(rowData)

            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        With grid
            Dim result As DialogResult
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count > 0 Then
                result = MsgBox("Are you sure you want to delete " & .SelectedRows.Count & " row/s?", MsgBoxStyle.YesNo, "")
                If result = DialogResult.Yes Then

                    For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                        selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                        dbAccess.Update_Data("update `attendance` set `status` = 'D' where `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                    Next

                    Load_form()
                End If

            Else
                MsgBox("No row/s selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
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

    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
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
                txtbxFacID.Text = Nothing
                txtbxName.Text = Nothing
                txtbxDept.Text = Nothing

            Else
                txtbxFacID.Text = selectedRow.Cells("Faculty ID").Value.ToString
                txtbxName.Text = selectedRow.Cells("Name").Value.ToString
                DeptValue = dbAccess.Get_Data("select departmentname from introse.department, introse.faculty where status = 'A' and facultyid = '" + txtbxFacID.Text + "' and department.departmentid = faculty.departmentid and faculty.status = 'A';", "departmentname")
                txtbxDept.Text = DeptValue.ToString

            End If
        End If
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class