Public Class wdwSelectReport
    Dim ReportChoice As Integer

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbChair.Enabled = False
        cmbDean.Enabled = False
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

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
    End Sub

    Private Sub rbttnMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnMonthly.CheckedChanged
        ReportChoice = 2
    End Sub

    Private Sub rbttnTermEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnTermEnd.CheckedChanged
        ReportChoice = 3
    End Sub

    Private Sub rbttnGrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnGrad.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnRegistrar.CheckedChanged
        cmbChair.Enabled = False
        cmbDean.Enabled = False
    End Sub

    Private Sub rbttnDean_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnDean.CheckedChanged
        cmbDean.Enabled = True
        cmbChair.Enabled = False
    End Sub

    Private Sub rbttnChair_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnChair.CheckedChanged
        cmbChair.Enabled = True
        cmbDean.Enabled = False
    End Sub

    Private Sub rbttnVCA_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnVCA.CheckedChanged
        cmbChair.Enabled = False
        cmbDean.Enabled = False
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
End Class