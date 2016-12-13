Public Class popDailyGen
    Dim repGen As New reportGenerator
    Dim offered As Integer
    Dim reportTo As Integer
    Private Sub popDailyGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(offeredType As Integer, reportFor As Integer)
        offered = offeredType
        reportTo = reportFor
        Me.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim reportSuccess As Boolean = False
        If reportTo = 1 Then
            reportSuccess = repGen.Generate_Registrar_Daily_Report(offered, dtp.Value)
        ElseIf reportTo = 3 Then
            reportSuccess = repGen.Generate_College_Daily_Report(wdwSelectReport.Get_Selected_College(), offered, dtp.Value)
        ElseIf reportTo = 4 Then
            reportSuccess = repGen.Generate_Chair_Daily_Report(wdwSelectReport.Get_Selected_Chair(), offered, dtp.Value)
        End If

        If (reportSuccess) Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()
    End Sub

End Class