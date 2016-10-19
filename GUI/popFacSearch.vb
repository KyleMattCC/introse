Public Class popFacSearch
    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Hide()
        wdwClassInfo.Show()
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Me.Hide()
        wdwDailyAttendanceLog.Show()
        'update data grid
        'iupdate ng conditional statements na nag sspecify kung ano yung window na naka open- (ged janz)
    End Sub
End Class