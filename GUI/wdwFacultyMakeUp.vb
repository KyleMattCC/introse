Public Class wdwFacultyMakeUp
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Hide()
        popAddMakeUp.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        popModMakeup.Show()
    End Sub

    Private Sub Find_Click(sender As Object, e As EventArgs) Handles bttnFind.Click
        popFacSearch.Show()

    End Sub
End Class