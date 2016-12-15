Public Class popMonthlyGen
    Dim dbAccess As New databaseAccessor
    Dim repGen As New reportGenerator
    Dim offered As Integer
    Dim reportTo As Integer
    Dim month As Integer

    Private Sub popMonthlyGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(offeredType As Integer, reportFor As Integer)
        offered = offeredType
        reportTo = reportFor
        bttnGenerate.Enabled = False

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

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxMonth.SelectedIndexChanged
        If (cmbbxYear.SelectedIndex <> -1 And cmbbxTerm.SelectedIndex <> -1) Then
            bttnGenerate.Enabled = True

        Else
            bttnGenerate.Enabled = False

        End If

    End Sub

    Private Sub bttnGenerate_Click(sender As Object, e As EventArgs) Handles bttnGenerate.Click
        Dim reportSuccess As Boolean = False
        Dim term As Integer

        term = dbAccess.Get_Data("Select termid from term, academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxYear.SelectedItem & "' and term.yearid = academicyear.yearid and term_no = " & cmbbxTerm.SelectedItem & ";", "termid")

        If (cmbbxMonth.SelectedItem.Equals("January")) Then
            month = 1

        ElseIf (cmbbxMonth.SelectedItem.Equals("February")) Then
            month = 2

        ElseIf (cmbbxMonth.SelectedItem.Equals("March")) Then
            month = 3

        ElseIf (cmbbxMonth.SelectedItem.Equals("April")) Then
            month = 4

        ElseIf (cmbbxMonth.SelectedItem.Equals("May")) Then
            month = 5

        ElseIf (cmbbxMonth.SelectedItem.Equals("June")) Then
            month = 6

        ElseIf (cmbbxMonth.SelectedItem.Equals("July")) Then
            month = 7

        ElseIf (cmbbxMonth.SelectedItem.Equals("August")) Then
            month = 8

        ElseIf (cmbbxMonth.SelectedItem.Equals("September")) Then
            month = 9

        ElseIf (cmbbxMonth.SelectedItem.Equals("October")) Then
            month = 10

        ElseIf (cmbbxMonth.SelectedItem.Equals("November")) Then
            month = 11

        ElseIf (cmbbxMonth.SelectedItem.Equals("December")) Then
            month = 12
        End If

        If reportTo = 1 Then
            reportSuccess = repGen.Generate_Monthly_Report(term, month, offered)

        ElseIf reportTo = 4 Then
            reportSuccess = repGen.Generate_Chair_Monthly_Report(term, month, wdwSelectReport.Get_Selected_Chair(), offered)
        End If

        If reportSuccess Then
            Me.Close()
        End If

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()

    End Sub

End Class