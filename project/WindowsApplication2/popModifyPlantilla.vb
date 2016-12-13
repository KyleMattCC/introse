Public Class popModifyPlantilla
    Private Sub TabPage4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacName.TextChanged

    End Sub

    Private Sub popModifyPlantilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxFacName.Enabled = False
    End Sub

    Public Sub Load_Form(rowData As List(Of String))

        txtbxCourseFacID.Text = rowData(1)
        txtbxCourseCode.Text = rowData(2)
    End Sub
End Class