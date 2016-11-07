Public Class popTermEndGen
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click


        Me.Hide()
        wdwReportGen.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        wdwSelectReport.Show()
    End Sub
End Class