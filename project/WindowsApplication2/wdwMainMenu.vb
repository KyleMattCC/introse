Public Class wdwMainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Form()

    End Sub

    Public Sub Load_Form()
        Close_Forms()
        If wdwLogin.Get_accountType.Equals("Regular") Then
            bttnAddAccount.Enabled = False
            bttnFeedback.Enabled = False

        Else
            bttnAddAccount.Enabled = True
            bttnFeedback.Enabled = True
        End If

        Label6.Text = "Welcome, " + wdwLogin.Get_Encoder() + "!"
        lblAY.Text = "Term " + wdwLogin.Get_AcadTerm() + ", A.Y. " + wdwLogin.Get_AcadYearstart() + " - " + wdwLogin.Get_AcadYearend
        TimerLoop.Enabled = True
        Me.Show()

    End Sub

    Public Sub Enable_Form()
        Me.Focus()

    End Sub

    Private Sub Close_Forms()
        wdwDailyAttendanceLog.Close()
        wdwFacultyMakeUp.Close()
        wdwSelectReport.Close()
        wdwNotices.Close()
        popFacSearch.Close()
        wdwAttendanceHistoryLog.Close()
        popAddAccount.Close()
        popEditAccount.Close()
        wdwFacPlantilia.Close()

    End Sub

    Private Sub bttnDailyAtt_Click_1(sender As Object, e As EventArgs) Handles bttnDailyAtt.Click
        Close_Forms()
        wdwDailyAttendanceLog.MdiParent = Me
        wdwDailyAttendanceLog.WindowState = FormWindowState.Normal
        wdwDailyAttendanceLog.Show()
    End Sub

    Private Sub bttnMakeUp_Click(sender As Object, e As EventArgs) Handles bttnMakeUp.Click
        Close_Forms()
        wdwFacultyMakeUp.MdiParent = Me
        wdwFacultyMakeUp.WindowState = FormWindowState.Normal
        wdwFacultyMakeUp.Show()

    End Sub

    Private Sub bttnReport_Click(sender As Object, e As EventArgs) Handles bttnReport.Click
        Close_Forms()
        wdwSelectReport.MdiParent = Me
        wdwSelectReport.WindowState = FormWindowState.Normal
        wdwSelectReport.Show()

    End Sub

    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        Me.Hide()

        wdwLogin.txtbxUser.Text = Nothing
        wdwLogin.txtbxPass.Text = Nothing
        wdwLogin.Show()

    End Sub

    Private Sub bttnNotice_Click(sender As Object, e As EventArgs) Handles bttnNotice.Click
        Close_Forms()
        wdwNotices.MdiParent = Me
        wdwNotices.WindowState = FormWindowState.Normal
        wdwNotices.Show()

    End Sub

    Private Sub bttnHistory_Click(sender As Object, e As EventArgs) Handles bttnHistory.Click
        Close_Forms()
        popFacSearch.Show()
        popFacSearch.Set_Path("Main")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        Close_Forms()
        popAddAccount.MdiParent = Me
        popAddAccount.WindowState = FormWindowState.Normal
        popAddAccount.Show()

    End Sub

    Private Sub bttnTermPlantilla_Click(sender As Object, e As EventArgs) Handles bttnTermPlantilla.Click
        Close_Forms()
        wdwFacPlantilia.MdiParent = Me
        wdwFacPlantilia.WindowState = FormWindowState.Normal
        wdwFacPlantilia.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close_Forms()
        popEditAccount.MdiParent = Me
        popEditAccount.WindowState = FormWindowState.Normal
        popEditAccount.Show()

    End Sub

    Private Sub bttnFeedback_Click(sender As Object, e As EventArgs) Handles bttnFeedback.Click
        Close_Forms()
        System.Diagnostics.Process.Start("https://docs.google.com/a/dlsu.edu.ph/forms/d/e/1FAIpQLSfsiV5oVaVuZJZk_e5bIZ6qjOEdrGjpenFuhPPjXrQQs54szw/viewform?c=0&w=1")

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        End

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerLoop.Tick
        lblDate.Text = Date.Now.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString

    End Sub

End Class
