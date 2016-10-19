Public Class wdwClassInfo
    Private Sub Back_Click(sender As Object, e As EventArgs)
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs)
        Find.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click

    End Sub

    Private Sub bttnModify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click

    End Sub

    Private Sub bttnBack_Click_1(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub bttnFind_Click(sender As Object, e As EventArgs) Handles bttnFind.Click

        popFacSearch.Show()

    End Sub
End Class