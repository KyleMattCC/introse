Public Class popServiceRecord
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) 
        txtID.ReadOnly = True
        txtID.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) 
        txtID.ReadOnly = True
        txtID.Clear()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) 
        txtID.ReadOnly = False
        txtID.Clear()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        wdwGenServiceReport.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        wdwNotices.Show()

    End Sub
End Class