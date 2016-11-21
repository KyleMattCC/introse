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

    Private Sub wdwGenAbsNotice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class