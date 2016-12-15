Public Class popTermEndGen
    Dim dbAccess As New databaseAccessor
    Dim repGen As New reportGenerator
    Dim offered As Integer
    Dim reportTo As Integer

    Private Sub popTermEndGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(offeredType As Integer, reportFor As Integer)
        offered = offeredType
        reportTo = reportFor

        Dim year As New List(Of Object)
        Dim term As New List(Of Object)
        Dim yearID As Integer
        Dim currYear As String = dbAccess.Get_Data("select concat(yearstart, ' - ', yearend) from academicyear where status = 'A';", "concat(yearstart, ' - ', yearend)")
        year = dbAccess.Get_Multiple_Row_Data("Select concat(yearstart, ' - ', yearend) from academicyear;")
        Dim currTerm As Integer

        cmbbxYear.Items.Clear()

        For ctr As Integer = 0 To year.Count - 1
            cmbbxYear.Items.Add(year(ctr))
        Next

        cmbbxYear.SelectedItem = currYear
        yearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & currYear & "' order by 1;", "yearid")
        term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & yearID & "' order by 1;")

        cmbbxTerm.Items.Clear()
        For ctr As Integer = 0 To term.Count - 1
            cmbbxTerm.Items.Add(term(ctr))
        Next

        currTerm = dbAccess.Get_Data("select term_no from term where status = 'A';", "term_no")
        cmbbxTerm.SelectedIndex = currTerm - 1

        Me.Show()

    End Sub

    Private Sub cmbbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxYear.SelectedIndexChanged
        cmbbxTerm.Items.Clear()

        Dim term As New List(Of Object)
        Dim yearID As Integer
        yearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxYear.SelectedItem & "'", "yearid")
        term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & yearID & "'")

        For ctr As Integer = 0 To term.Count - 1
            cmbbxTerm.Items.Add(term(ctr))
        Next

        cmbbxTerm.SelectedIndex = -1

        If (cmbbxTerm.SelectedIndex <> -1) Then
            bttnGenerate.Enabled = True

        Else
            bttnGenerate.Enabled = False
        End If

    End Sub

    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        If (cmbbxTerm.SelectedIndex <> -1) Then
            bttnGenerate.Enabled = True

        Else
            bttnGenerate.Enabled = False
        End If

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles bttnGenerate.Click
        Dim reportSuccess As Boolean = False
        Dim term As Integer

        term = dbAccess.Get_Data("Select termid from term, academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxYear.SelectedItem & "' and term.yearid = academicyear.yearid and term_no = " & cmbbxTerm.SelectedItem & ";", "termid")
        If reportTo = 1 Then
            reportSuccess = repGen.Generate_Term_Report(term, offered)

        ElseIf reportTo = 2 Then
            reportSuccess = repGen.Generate_VCA_Term_Report(term, offered)

        ElseIf reportTo = 3 Then
            reportSuccess = repGen.Generate_College_Term_Report(term, wdwSelectReport.Get_Selected_College, offered)

        ElseIf reportTo = 4 Then
            reportSuccess = repGen.Generate_College_Term_Report(term, wdwSelectReport.Get_Selected_Chair, offered)
        End If

        If reportSuccess Then
            Me.Close()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()

    End Sub

End Class