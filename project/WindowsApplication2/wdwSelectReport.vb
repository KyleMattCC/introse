Public Class wdwSelectReport
    Dim reportType As Integer
    Dim reportFor As Integer
    Dim offeredType As Integer
    Dim dbAccessor As New databaseAccessor

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colleges As New List(Of Object)()
        Dim departments As New List(Of Object)()

        cmbbxDean.Items.Clear()
        cmbbxChair.Items.Clear()
        cmbbxChair.Enabled = False
        cmbbxDean.Enabled = False

        Try
            colleges = dbAccessor.Get_Multiple_Row_Data("select college_name from introse.college order by 1")
            departments = dbAccessor.Get_Multiple_Row_Data("select departmentname from introse.department order by 1")
            For ctr As Integer = 0 To colleges.Count - 1
                cmbbxDean.Items.Add(colleges(ctr))
            Next

            For ctr = 0 To departments.Count - 1
                cmbbxChair.Items.Add(departments(ctr))
            Next

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Me.Focus()

    End Sub

    Private Sub rbttnUnder_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnUnder.CheckedChanged
        offeredType = 1

    End Sub

    Private Sub rbttnGrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnGrad.CheckedChanged
        offeredType = 2

    End Sub

    Private Sub rbttnBoth_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnBoth.CheckedChanged
        offeredType = 3

    End Sub

    Private Sub rbttnDaily_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDaily.CheckedChanged
        reportType = 1
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = False
        rbttnDean.Enabled = True
        rbttnChair.Enabled = True
        rbttnRegistrar.Select()
        cmbbxChair.SelectedIndex = -1
        cmbbxDean.SelectedIndex = -1

    End Sub

    Private Sub rbttnMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnMonthly.CheckedChanged
        reportType = 2
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = False
        rbttnDean.Enabled = False
        rbttnChair.Enabled = True
        rbttnRegistrar.Select()
        cmbbxChair.SelectedIndex = -1
        cmbbxDean.SelectedIndex = -1

    End Sub

    Private Sub rbttnTermEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnTermEnd.CheckedChanged
        reportType = 3
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = True
        rbttnDean.Enabled = True
        rbttnChair.Enabled = True
        rbttnRegistrar.Select()
        cmbbxChair.SelectedIndex = -1
        cmbbxDean.SelectedIndex = -1

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnRegistrar.CheckedChanged
        cmbbxChair.Enabled = False
        cmbbxDean.Enabled = False
        cmbbxChair.SelectedIndex = -1
        cmbbxDean.SelectedIndex = -1
        reportFor = 1

    End Sub

    Private Sub rbttnVCA_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnVCA.CheckedChanged
        cmbbxChair.Enabled = False
        cmbbxDean.Enabled = False
        cmbbxChair.SelectedIndex = -1
        cmbbxDean.SelectedIndex = -1
        reportFor = 2

    End Sub

    Private Sub rbttnDean_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDean.CheckedChanged
        cmbbxDean.Enabled = True
        cmbbxChair.Enabled = False
        cmbbxChair.SelectedIndex = -1
        reportFor = 3

    End Sub

    Private Sub rbttnChair_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnChair.CheckedChanged
        cmbbxChair.Enabled = True
        cmbbxDean.Enabled = False
        cmbbxDean.SelectedIndex = -1
        reportFor = 4

    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles bttnGen.Click
        Me.Enabled = False

        If reportType = 1 Then
            popDailyGen.Load_Form(offeredType, reportFor)

        ElseIf reportType = 2 Then
            popMonthlyGen.Load_Form(offeredType, reportFor)

        ElseIf reportType = 3 Then
            popTermEndGen.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
        wdwMainMenu.Show()

    End Sub

    Public Function Get_Selected_College() As String
        Return cmbbxDean.SelectedItem.ToString

    End Function

    Public Function Get_Selected_Chair() As String
        Return cmbbxChair.SelectedItem.ToString

    End Function

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
        popDailyGen.Close()
        popMonthlyGen.Close()
        popTermEndGen.Close()

    End Sub

End Class