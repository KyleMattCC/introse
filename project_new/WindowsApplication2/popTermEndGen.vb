Public Class popTermEndGen
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click


        Me.Hide()
        wdwReportGen.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub popTermEndGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()
    End Sub
End Class