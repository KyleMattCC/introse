Public Class wdwReportGen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub wdwReportGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(filename As String, reportType As Integer, reportFor As String, reportDay As Date)
        Me.Show()
        pdfViewer.src = filename
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwSelectReport.Enable_Form()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub pdfViewer_Enter(sender As Object, e As EventArgs) Handles pdfViewer.Enter

    End Sub
End Class