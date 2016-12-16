Public Class wdwAttendanceHistoryLog
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Public dgAttID As String
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer
    Public facultyId As String
    Dim attendanceView, makeupView As Boolean

    Private Function Check_Fac(id As String) As Boolean
        Dim checkFac As Boolean = False
        Dim fac As New Object
        fac = dbAccess.Get_Data("select facref_no from introse.faculty where facultyid = '" & id & "';", "facref_no")
        If String.IsNullOrEmpty(fac) Then
            checkFac = False
            bttnAdd.Enabled = False
            bttnModify.Enabled = False
            bttnDelete.Enabled = False

            MsgBox("No records matched!", MsgBoxStyle.Critical, "")

        Else
            bttnAdd.Enabled = True
            bttnModify.Enabled = True
            bttnDelete.Enabled = True
            checkFac = True
        End If

        Return checkFac

    End Function

    Private Sub wdwAttendanceHistoryLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attendanceView = True
        makeupView = False
    End Sub

    Public Sub Load_Form(id As String)
        rindexValue = 0
        If Check_Fac(id) Then
            txtbxFacID.Text = id
            txtbxName.Text = dbAccess.Get_Data("select concat(f_lastname, ', ', f_firstname, ' ', f_middlename) from introse.faculty where facultyid = '" & id & "';", "concat(f_lastname, ', ', f_firstname, ' ', f_middlename)")
            facultyID = txtbxFacID.Text

            If wdwLogin.Get_accountType.Equals("Regular") Then
                bttnAdd.Enabled = True
                bttnDelete.Enabled = False
                bttnModify.Enabled = False

            Else
                bttnAdd.Enabled = True
                bttnDelete.Enabled = True
                bttnModify.Enabled = True
            End If

            If attendanceView = True Then
                dbAccess.Fill_Data_Grid("select a.attendanceid 'Attendance reference no.', concat(ac.yearstart, '-', ac.yearend) 'Academic year', t.term_no 'Term', a.absent_date 'Absent date', cl.course_cd 'Course', c.section 'Section', r.remark_des 'Remark'
                                from introse.attendance a, introse.courseoffering c, introse.term t, introse.academicyear ac, introse.course cl, introse.faculty f, introse.remarks r
                                where a.courseoffering_id = c.courseoffering_id and (c.status = 'A' or c.status = 'R') and (a.status = 'A' or a.status = 'R') and c.course_id = cl.course_id and c.termid = t.termid and t.yearid = ac.yearid and f.facultyid = '" + id + "' and f.facref_no = c.facref_no and a.remarks_cd = r.remark_cd
                                order by concat(ac.yearstart, '-', ac.yearend) and t.term_no asc LIMIT 1000 ;", grid)

            ElseIf makeupView = True Then
                dbAccess.Fill_Data_Grid("select m.makeupid 'Makeup reference no.', concat(ac.yearstart, '-', ac.yearend) 'Academic year', t.term_no 'Term', m.makeup_date 'Makeup date', cl.course_cd 'Course', c.section 'Section', r.reason_des 'Reasons'
                                from introse.makeup m, introse.faculty f, introse.courseoffering c , introse.term t, introse.academicyear ac, introse.course cl, introse.reasons r
                                where m.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and (c.status = 'A' or c.status = 'R') and (m.status = 'A' or m.status = 'R') and cl.course_id = c.course_id and c.termid = t.termid and t.yearid = ac.yearid  and m.reason_cd = r.reason_cd and f.facultyid = '" + id + "'
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
        Load_Form(popFacSearch.get_Faculty_Id)
        Me.Focus()

    End Sub

    Public Sub Enable_Only_Form()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttnAttendance.Click
        BttnAttendance.Enabled = False
        BttnMakeup.Enabled = True

        attendanceView = True
        makeupView = False
        Load_Form(txtbxFacID.Text)

    End Sub

    Private Sub BttnMakeup_Click(sender As Object, e As EventArgs) Handles BttnMakeup.Click
        BttnAttendance.Enabled = True
        BttnMakeup.Enabled = False

        attendanceView = False
        makeupView = True
        Load_Form(txtbxFacID.Text)

    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False

        If attendanceView = True Then
            popAddAttendanceHistory.Show()

        ElseIf makeupView = True Then
            popAddMakeUpHistory.Show()
        End If

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
                If attendanceView = True Then
                    popModifyAttendanceHistory.Load_Form(rowData)
                ElseIf makeupView = True Then
                    popModifyMakeUpHistory.Load_Form(rowData)
                End If

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
                        If attendanceView = True Then
                            dbAccess.Update_Data("update `introse`.`attendance` set `status` = 'D' where `attendanceid` = '" & selectedRow.Cells(0).Value & "';")
                        ElseIf makeupView = True Then
                            dbAccess.Update_Data("update `introse`.`makeup` set `status` = 'D' where `makeupid` = '" & selectedRow.Cells(0).Value & "';")
                        End If
                    Next

                    Load_Form(txtbxFacID.Text)
                End If

            Else
                MsgBox("No row/s selected!", MsgBoxStyle.Critical, "")

            End If
        End With

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Show()

    End Sub

    Public Function Get_Ref_No() As Integer
        Return rowData(0)
    End Function

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        With grid
            rindexValue = e.RowIndex

            rowData.Clear()
            Dim selectedRow As DataGridViewRow
            Dim colCount As Integer
            colCount = grid.ColumnCount

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
            If attendanceView = True Then
                popMoreInfo.Load_Attendance_Form(rowData)
            ElseIf makeupView = True Then
                popMoreInfoMakeupClass.Load_Makeup_Form(rowData)
            End If

        End With

    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        rindexValue = e.RowIndex

    End Sub

End Class