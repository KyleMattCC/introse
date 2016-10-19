Public Class wdwGenAbsNotice
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        wdwNotices.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        EmailNoticesAbsNotice.Show()
    End Sub
End Class