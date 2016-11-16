Public Class popEncFacDaily
    Dim dbAccess As New DatabaseAccessor

    Private Sub TextBox44_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
    End Sub

    Private Sub TextBox82_TextChanged(sender As Object, e As EventArgs) Handles TextBox82.TextChanged



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged

    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub bttnEncode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        ' dbAccess.addData("INSERT INTO `introse`.`attendance` (`attendanceid`, `courseoffering_id`, `statusid`, `remarks`, `date`, `timeset`, `encoder`, `checker`) VALUES ('" + AttendanceID.ToString + "', '" + CourseOfferingID.ToString + "', 'A', '" + RemarksText1.Text + "', '" + DateTimePicker1.Text + "', '" + StartText1.Text + "', 'a', '" + CheckerText.Text + "');")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class