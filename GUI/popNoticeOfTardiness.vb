Public Class popNoticeOfTardiness
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadID.CheckedChanged
        txtID.ReadOnly = False
        txtID.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadNoEmail.CheckedChanged
        txtID.ReadOnly = True
        txtID.Clear()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadAll.CheckedChanged
        txtID.ReadOnly = True
        txtID.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        wdwNotices.Show()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Me.Hide()
        wdwGenTardiness.Show()
    End Sub
End Class