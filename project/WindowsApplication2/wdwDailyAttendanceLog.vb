Public Class wdwDailyAttendanceLog
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        wdwModFacultyDaily.Show()

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        popEncFacDaily.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        popFacSearch.Show()
    End Sub

    Private Sub wdwDailyAttendanceLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class