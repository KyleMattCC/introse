Public Class wdwAttendanceHistoryLog
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer
    Public facultyID As String
    Dim AttendanceView, MakeupView As Boolean

    Private Function Check_fac(id As String) As Boolean
        Dim checkFac As Boolean = False
        Dim fac As New Object
        fac = dbAccess.Get_Data("select facref_no from introse.faculty where facultyid = '" & id & "';", "facref_no")
        If String.IsNullOrEmpty(fac) Then
            checkFac = False

            bttnAdd.Enabled = False
            bttnModify.Enabled = False
            bttnDelete.Enabled = False

            MsgBox("No Records matched!", MsgBoxStyle.Critical, "")
        Else
            bttnAdd.Enabled = True
            bttnModify.Enabled = True
            bttnDelete.Enabled = True
            checkFac = True
        End If
        Return checkFac
    End Function
    Public Sub Load_form(id As String)
        rindexValue = 0
        If Check_fac(id) Then
            txtbxFacID.Text = id
            txtbxName.Text = dbAccess.Get_Data("select concat(f_lastname, ', ', f_firstname, ' ', f_middlename) from introse.faculty where facultyid = '" & id & "';", "concat(f_lastname, ', ', f_firstname, ' ', f_middlename)")
            facultyID = txtbxFacID.Text


            If AttendanceView = True Then
                dbAccess.Fill_Data_Grid("select a.attendanceid 'Attendance Reference No', concat(ac.yearstart, '-', ac.yearend) 'Academic Year', t.term_no 'Term', a.absent_date 'Absent Date', cl.course_cd 'Course', c.section 'Section'
                                from introse.attendance a, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.course cl, introse.faculty f
                                where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and (a.status = 'A' or a.status = 'R') and c.course_id = cl.course_id and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" + id + "' and f.facref_no = c.facref_no
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)

            ElseIf makeupView = True Then
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

        If AttendanceView = True Then
            popAddAttendanceHistory.Show()
        ElseIf makeupView = True Then
            popAddMakeUpHistory.Show()
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        Try
            With grid
                Dim result As DialogResult
                Dim selectedRow As DataGridViewRow
                If .SelectedRows.Count > 0 Then
                    result = MsgBox("Are you sure you want to delete " & .SelectedRows.Count & " row/s?", MsgBoxStyle.YesNo, "")
                    If result = DialogResult.Yes Then

                        For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                            selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                            If AttendanceView = True Then
                                dbAccess.Update_Data("UPDATE `introse`.`attendance` SET `status` = 'D' WHERE `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                            ElseIf MakeupView = True Then
                                dbAccess.Update_Data("UPDATE `introse`.`makeup` SET `status` = 'D' WHERE `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                            End If
                        Next

                        Load_form(txtbxFacID.Text)
                    End If

                Else
                    MsgBox("No row/s selected!", MsgBoxStyle.Critical, "")

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

            If AttendanceView = True Then
                wdwMoreInfo.Load_Attendance_Form(rowData)
            ElseIf makeupview = True Then
                wdwMoreInfoMakeupClass.Load_Makeup_Form(rowData)
            End If

            Me.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttnAttendance.Click
        BttnAttendance.Enabled = False
        BttnMakeup.Enabled = True

        AttendanceView = True
        MakeupView = False
        Load_form(txtbxFacID.Text)
    End Sub

    Private Sub BttnMakeup_Click(sender As Object, e As EventArgs) Handles BttnMakeup.Click
        BttnAttendance.Enabled = True
        BttnMakeup.Enabled = False

        AttendanceView = False
        MakeupView = True
        Load_form(txtbxFacID.Text)
    End Sub

    Private Sub wdwAttendanceHistoryLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttendanceView = True
        MakeupView = False
    End Sub

    Private Sub bttnModify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
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
                If AttendanceView = True Then
                    popModifyAttendanceHistory.Load_Form(rowData)
                ElseIf MakeupView = True Then
                    popModifyMakeUpHistory.Load_Form(rowData)
                End If


            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
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
            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub
End Class