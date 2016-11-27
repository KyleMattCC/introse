Public Class wdwNotices
    Dim choice As Integer
    Dim repGen As New ReportGenerator
    Dim dbAccess As New DatabaseAccessor
    Dim index As Integer
    Dim selectedRow As DataGridViewRow

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        selectedRow = grid.Rows(index)
        Dim fileName As String
        fileName = repGen.generateNotice(selectedRow.Cells(0).Value.ToString(), selectedRow.Cells(1).Value.ToString(), selectedRow.Cells(2).Value)
        Me.Close()
    End Sub

    Private Sub RadAbsence_CheckedChanged(sender As Object, e As EventArgs)
        choice = 1
    End Sub

    Private Sub RadTardiness_CheckedChanged(sender As Object, e As EventArgs)
        choice = 2
    End Sub

    Private Sub RadService_CheckedChanged(sender As Object, e As EventArgs)
        choice = 3
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        wdwMainMenu.Show()

    End Sub

    Private Sub wdwNotices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Load_form()
        dbAccess.fillDataGrid("Select distinct f.facultyid 'Faculty ID', concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename) 'Name', a.absent_date 'Absent date', a.report_status 'Report status'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c
                                where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and a.status = 'A' and a.absent_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'
                                order by 3, 2;", grid)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles bttnClear.Click

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Load_form()
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick
        index = e.RowIndex
    End Sub
End Class