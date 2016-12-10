Public Class popDailyGen
    Dim repGen As New reportGenerator
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Me.Hide()
        Dim filename As String
        filename = repGen.Generate_Daily_Report(dtp.Value)
        wdwReportGen.Load_Form("C:\Users\Aeinstein Villamayor\Documents\GitHub\introse\project\WindowsApplication2\bin\Debug\" & filename)
    End Sub

    Private Sub popDailyGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()
    End Sub

End Class