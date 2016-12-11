Public Class wdwMainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub bttnDailyAtt_Click_1(sender As Object, e As EventArgs) Handles bttnDailyAtt.Click
        wdwDailyAttendanceLog.Show()
    End Sub

    Private Sub bttnMakeUp_Click(sender As Object, e As EventArgs) Handles bttnMakeUp.Click
        wdwFacultyMakeUp.Show()
    End Sub

    Private Sub bttn_Click(sender As Object, e As EventArgs)
        wdwClassInfo.Show()
    End Sub

    Private Sub bttnReport_Click(sender As Object, e As EventArgs) Handles bttnReport.Click
        wdwSelectReport.Show()
    End Sub

    Private Sub bttnPlantilla_Click(sender As Object, e As EventArgs)
        wdwFacPlantilia.Show()
    End Sub

    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        Me.Close()

    End Sub

    Private Sub bttnNotice_Click(sender As Object, e As EventArgs) Handles bttnNotice.Click
        wdwNotices.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Public Sub Enable_Form()
        Me.Focus()
    End Sub

    Private Sub bttnHistory_Click(sender As Object, e As EventArgs) Handles bttnHistory.Click
        popFacSearch.Show()
        popFacSearch.Set_Path("Main")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        popAddAccount.Show()
    End Sub

    Private Sub bttnTermPlantilla_Click(sender As Object, e As EventArgs) Handles bttnTermPlantilla.Click
        wdwFacPlantilia.show()
    End Sub
End Class
