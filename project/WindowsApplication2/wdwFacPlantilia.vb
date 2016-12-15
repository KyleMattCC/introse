Public Class wdwFacPlantilia
    Public rowData As List(Of String) = New List(Of String)
    Dim rindexValue As Integer
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnDataEntry.Click
        wdwDataEntry.Show()
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Public Sub Enable_Form()
        Me.Load_form()
        Me.Enabled = True

        Me.Focus()
    End Sub

    Private Sub wdwFacPlantilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()

        Dim Year As New List(Of Object)
        Dim Term As New List(Of Object)
        Dim YearID As Integer
        Dim Active As String
        Dim Index As Integer


        Year = dbAccess.Get_Multiple_Row_Data("Select concat(yearstart, ' - ', yearend) from academicyear")
        Active = dbAccess.Get_Data("select concat(yearstart, ' - ', yearend) from academicyear where status = 'A'", "concat(yearstart, ' - ', yearend)")

        For i As Integer = 0 To Year.Count - 1
            cmbbxAcadYear.Items.Add(Year(i))
            If (Active = Year(i)) Then
                Index = i
            End If
        Next

        If (cmbbxAcadYear.Items.Count <> 0) Then
            cmbbxAcadYear.SelectedIndex = Index

        End If

        YearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "';", "yearid")
        Term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & YearID & "';")
        cmbbxTerm.Items.Clear()

        For i As Integer = 0 To Term.Count - 1
            cmbbxTerm.Items.Add(Term(i))
        Next

        If (cmbbxTerm.Items.Count <> 0) Then
            cmbbxTerm.SelectedIndex = 0
        End If

        If (txtbxSearch.Text = Nothing) Then

            bttnSearch.Enabled = False
            Load_form()

        Else
            bttnSearch.Enabled = True
        End If




    End Sub

    Public Sub Load_form()


        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course', concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours', co.status 'Status' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = co.course_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'
                                order by 10, 1, 3", grid)

        If (wdwLogin.Get_accountType = "Regular") Then
            bttnDataEntry.Enabled = False
            bttnModify.Enabled = False
            bttnDelete.Enabled = False
        End If



    End Sub

    Public Function getTermID() As String

        Dim TermID As String = dbAccess.Get_Data("Select termid from academicyear a, term t where  concat(a.yearstart, ' - ', a.yearend) = '" & cmbbxAcadYear.SelectedItem & "' and t.term_no = '" & cmbbxTerm.SelectedItem & "' and a.yearid = t.yearid", "termid")

        Return TermID

    End Function

    Private Sub cmbbxAcadYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxAcadYear.SelectedIndexChanged
        Dim YearID As Integer
        Dim Term As New List(Of Object)




        YearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", "yearid")

        Term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & YearID & "'")
        For i As Integer = 0 To Term.Count - 1
            cmbbxTerm.Items.Add(Term(i))
        Next
        If (cmbbxTerm.Items.Count <> 0) Then
            cmbbxTerm.SelectedIndex = 0

        End If



        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course',  concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours', co.status 'Status' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = co.course_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'
                                order by 10, 1, 3", grid)

    End Sub

    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course',  concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours', co.status 'Status'
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = co.course_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'
                                order by 10, 1, 3", grid)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bttnModify.Click

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
                popModifyPlantilla.Load_Form(rowData)


            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With


    End Sub

    Public Function get_CourseOfferingID() As Object
        Return rowData(0)
    End Function

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Dim Search As String = Nothing

        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"

        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course', concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours', co.status 'Status' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = co.course_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "' and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "')  or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname,' ', ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' ,f_firstname) like '" + Search.ToString + "'))
                                order by 10, 1, 3", grid)


    End Sub

    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        If (txtbxSearch.Text = Nothing) Then

            bttnSearch.Enabled = False
            Load_form()

        Else
            bttnSearch.Enabled = True
        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxSearch.Text = Nothing
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        With grid
            Dim result As DialogResult
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count > 0 Then
                result = MsgBox("Are you sure you want to delete " & .SelectedRows.Count & " row/s?", MsgBoxStyle.YesNo, "")
                If result = DialogResult.Yes Then

                    For ctr As Integer = .SelectedRows.Count - 1 To 0 Step -1
                        selectedRow = grid.Rows(.SelectedRows(ctr).Index)
                        dbAccess.Update_Data("update `courseoffering` set `status` = 'D' where `courseoffering_id` = '" & selectedRow.Cells(0).Value & "';")
                    Next

                    Load_form()
                End If

            Else
                MsgBox("No row/s selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        rindexValue = e.RowIndex
        Dim selectedRow As DataGridViewRow


        If (rindexValue <> -1) Then
            selectedRow = grid.Rows(rindexValue)
        End If
    End Sub


End Class