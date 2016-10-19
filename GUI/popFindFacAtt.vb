Public Class popFindFacAtt
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Me.Hide()
        wdwDailyAttendanceLog.Show()

    End Sub
End Class