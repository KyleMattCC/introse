Public Class wdwSelectReport
    Dim ReportChoice As Integer

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles bttnGen.Click
        Me.Hide()
        If ReportChoice = 1 Then
            popDailyGen.Show()
        End If

        If ReportChoice = 2 Then
            popMonthlyGen.Show()
        End If

        If ReportChoice = 3 Then
            popTermEndGen.Show()
        End If

    End Sub

    Private Sub rbttnDaily_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDaily.CheckedChanged
        ReportChoice = 1
    End Sub

    Private Sub rbttnMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnMonthly.CheckedChanged
        ReportChoice = 2
    End Sub

    Private Sub rbttnTermEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnTermEnd.CheckedChanged
        ReportChoice = 3
    End Sub

    Private Sub rbttnGrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnGrad.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnRegistrar.CheckedChanged

    End Sub
End Class