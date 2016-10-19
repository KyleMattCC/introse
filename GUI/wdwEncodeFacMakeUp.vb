Public Class wdwEncodeFacMakeUp
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        wdwMainMenu.Show()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Me.Hide()
        popAddMakeUp.Show()
    End Sub

    Private Sub wdwEncodeFacMakeUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class