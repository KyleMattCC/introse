Public Class wdwMainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttnDailyAtt_Click_1(sender As Object, e As EventArgs) Handles bttnDailyAtt.Click

        wdwDailyAttendanceLog.MdiParent = Me
        wdwDailyAttendanceLog.WindowState = FormWindowState.Normal
        wdwDailyAttendanceLog.Show()

    End Sub

    Private Sub bttnMakeUp_Click(sender As Object, e As EventArgs) Handles bttnMakeUp.Click
        wdwFacultyMakeUp.MdiParent = Me
        wdwFacultyMakeUp.WindowState = FormWindowState.Normal
        wdwFacultyMakeUp.Show()
        wdwDailyAttendanceLog.Close()
    End Sub

    Private Sub bttn_Click(sender As Object, e As EventArgs)
        wdwClassInfo.MdiParent = Me
        wdwClassInfo.WindowState = FormWindowState.Normal
        wdwClassInfo.Show()
    End Sub

    Private Sub bttnReport_Click(sender As Object, e As EventArgs) Handles bttnReport.Click
        wdwSelectReport.MdiParent = Me
        wdwSelectReport.WindowState = FormWindowState.Normal
        wdwSelectReport.Show()
    End Sub

    Private Sub bttnPlantilla_Click(sender As Object, e As EventArgs)
        wdwFacPlantilia.MdiParent = Me
        wdwFacPlantilia.WindowState = FormWindowState.Normal
        wdwFacPlantilia.Show()
    End Sub

    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        Me.Close()

        wdwLogin.txtbxUser.Text = Nothing
        wdwLogin.txtbxPass.Text = Nothing
        wdwLogin.Show()

    End Sub

    Private Sub bttnNotice_Click(sender As Object, e As EventArgs) Handles bttnNotice.Click
        wdwNotices.MdiParent = Me
        wdwNotices.WindowState = FormWindowState.Normal
        wdwNotices.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Public Sub Enable_Form()
        Me.Focus()
    End Sub

    Private Sub bttnHistory_Click(sender As Object, e As EventArgs) Handles bttnHistory.Click
        popFacSearch.Show()
        popFacSearch.Set_Path("Main")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        popAddAccount.MdiParent = Me
        popAddAccount.WindowState = FormWindowState.Normal
        popAddAccount.Show()
    End Sub

    Private Sub bttnTermPlantilla_Click(sender As Object, e As EventArgs) Handles bttnTermPlantilla.Click
        wdwFacPlantilia.MdiParent = Me
        wdwFacPlantilia.WindowState = FormWindowState.Normal
        wdwFacPlantilia.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        popEditAccount.MdiParent = Me
        popEditAccount.WindowState = FormWindowState.Normal
        popEditAccount.Show()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        End
    End Sub
End Class
