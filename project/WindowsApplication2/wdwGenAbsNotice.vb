Public Class wdwGenAbsNotice
    Private Sub btnBack_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        wdwNotices.Show()

    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        wdwEmailNotice.Show()



    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) 

    End Sub
End Class