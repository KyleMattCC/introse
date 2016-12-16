Public Class wdwReportGen
    Dim file As String
    Dim type As Integer
    Dim recipient As String
    Dim day As Date

    Private Sub wdwReportGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(filename As String, reportType As Integer, reportFor As String, reportDay As Date)
        Me.Show()
        file = filename
        type = reportType
        recipient = reportFor
        day = reportDay
        pdfViewer.src = filename

    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Me.Focus()

    End Sub

    Private Sub EmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem.Click
        wdwEmailReports.Load_Form(file, type, recipient, day)
        Me.Enabled = False

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()

    End Sub

End Class
