Public Class wdwSelectReport
    Dim ReportChoice As Integer
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

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
        wdwMainMenu.Show()

    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles bttnGen.Click
        Me.Enabled = False

        If ReportChoice = 1 Then
            popDailyGen.Show()
        End If

        If ReportChoice = 2 Then
            popMonthlyGen.Show()
        End If

        If ReportChoice = 3 Then
            popTermEndGen.Show()
        End If

    End Sub

    Private Sub rbttnDaily_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDaily.CheckedChanged
        ReportChoice = 1
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = False
        rbttnDean.Enabled = True
        rbttnChair.Enabled = True
    End Sub

    Private Sub rbttnMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnMonthly.CheckedChanged
        ReportChoice = 2
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = False
        rbttnDean.Enabled = False
        rbttnChair.Enabled = True
    End Sub

    Private Sub rbttnTermEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnTermEnd.CheckedChanged
        ReportChoice = 3
        rbttnRegistrar.Enabled = True
        rbttnVCA.Enabled = True
        rbttnDean.Enabled = True
        rbttnChair.Enabled = True
    End Sub

    Private Sub rbttnGrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnGrad.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnRegistrar.CheckedChanged
        cmbbxChair.Enabled = False
        cmbbxDean.Enabled = False
    End Sub

    Private Sub rbttnDean_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDean.CheckedChanged
        cmbbxDean.Enabled = True
        cmbbxChair.Enabled = False
    End Sub

    Private Sub rbttnChair_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnChair.CheckedChanged
        cmbbxChair.Enabled = True
        cmbbxDean.Enabled = False
    End Sub

    Private Sub rbttnVCA_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnVCA.CheckedChanged
        cmbbxChair.Enabled = False
        cmbbxDean.Enabled = False
    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Me.Focus()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class