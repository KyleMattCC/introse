Public Class popMonthlyGen
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Private Sub bttnGenerate_Click(sender As Object, e As EventArgs) Handles bttnGenerate.Click
        Me.Hide()
        wdwReportGen.Show()
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxMonth.SelectedIndexChanged

    End Sub

    Private Sub popMonthlyGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbbxTerm.Enabled = False
        cmbbxMonth.Enabled = False
        bttnGenerate.Enabled = False

        Dim year As New List(Of Object)

        year = dbAccess.Get_Multiple_Row_Data("Select concat(yearstart, ' - ', yearend) from academicyear")

        For i As Integer = 0 To year.Count - 1
            cmbbxYear.Items.Add(year(i))
        Next

        If (cmbbxYear.Items.Count <> 0) Then
            cmbbxYear.SelectedIndex = -1
        End If

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()
    End Sub

    Private Sub cmbbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxYear.SelectedIndexChanged
        cmbbxTerm.Enabled = True
        cmbbxMonth.Enabled = True
        Dim term As New List(Of Object)
        Dim yearID As Integer

        yearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxYear.SelectedItem & "'", "yearid")
        term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & yearID & "'")

        For i As Integer = 0 To term.Count - 1
            cmbbxTerm.Items.Add(term(i))
        Next

        If (cmbbxTerm.Items.Count <> 0) Then
            cmbbxTerm.SelectedIndex = -1

        End If

    End Sub

End Class