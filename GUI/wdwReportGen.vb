Public Class wdwReportGen
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        wdwSelectReport.Show()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Me.Hide()
        EmailReportGen.Show()
    End Sub
End Class