Public Class wdwFacDailyAtt
    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
        wdwDailyAttendanceLog.Show()

    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        popAddFacultyDaily.Show()
    End Sub

    Private Sub bttnModify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        wdwModFacultyDaily.Show()
    End Sub

    Private Sub bttnFind_Click(sender As Object, e As EventArgs) Handles bttnFind.Click
        popFacSearch.Show()
    End Sub

    Private Sub wdwFacDailyAtt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class