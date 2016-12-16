Imports System.Net.Mail
Public Class wdwEmailReports
    Dim dbAccess As New databaseAccessor
    Dim subject As String
    Dim body As String
    Dim file As String

    Private Sub wdwEmailReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Form(filename As String, reportType As Integer, reportFor As String, reportDay As Date)
        file = filename
        Dim emailAdd As String = Nothing

        If reportType = 1 Then
            emailAdd = dbAccess.Get_Data("select email from introse.faculty where concat(f_lastname, ', ', f_fistname, ' ', f_middlename) = '" & reportFor & "';", "email")
            If String.IsNullOrEmpty(emailAdd) Then
                txtbxTo.Text = Nothing

            Else
                txtbxTo.Text = emailAdd
            End If

            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Daily Attendance Notice"
            txtbxBody.Text = "Attached is a notice of your absence. If incorrect, please rectify this report by filling up the online feedback form. https://goo.gl/forms/PoBhcMxBFkGZFh0g1"

        ElseIf reportType = 2 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Daily Faculty Attendance Report"
            txtbxBody.Text = "Attached is the daily facutly attedance report of " & reportDay.ToLongDateString()

        ElseIf reportType = 3 Or reportType = 4 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Daily Faculty Attendance Report"
            txtbxBody.Text = "Attached is the " & reportFor & " daily facutly attedance report of " & reportDay.ToLongDateString()

        ElseIf reportType = 5 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Monthly Faculty Attendance Report"
            txtbxBody.Text = "Attached is the monthly faculty attendance report as of " & reportDay.ToLongDateString()

        ElseIf reportType = 6 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Monthly Faculty Attendance Report"
            txtbxBody.Text = "Attached is the " & reportFor & " monthly faculty attendance report as of " & reportDay.ToLongDateString()

        ElseIf reportType = 7 Or reportType = 8 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Term End Faculty Attendance Report"
            txtbxBody.Text = "Attached is the term end faculty attendance report as of " & reportDay.ToLongDateString()

        ElseIf reportType = 9 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Term End Attendance Notice"
            txtbxBody.Text = "Attached is the " & reportFor & " term end faculty attendance report as of " & reportDay.ToLongDateString()

        ElseIf reportType = 10 Then
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Term End Attendance Notice"
            txtbxBody.Text = "Attached is the " & reportFor & " term end faculty attendance report as of " & reportDay.ToLongDateString()

        End If

        Me.Show()
    End Sub

    Private Sub txtbxTo_TextChanged(sender As Object, e As EventArgs) Handles txtbxTo.TextChanged
        If String.IsNullOrEmpty(txtbxTo.Text) Then
            bttnSend.Enabled = False

        Else
            bttnSend.Enabled = True
        End If

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles bttnSend.Click
        Try
            Dim SMTPcl As New SmtpClient
            Dim SendMail As New MailMessage()
            Dim Email As String = "kyle.daman19@gmail.com"
            Dim Passwordss As String = "k09225451486"
            SMTPcl.UseDefaultCredentials = False
            SMTPcl.Credentials = New Net.NetworkCredential(Email, Passwordss)
            SMTPcl.Port = 587
            SMTPcl.EnableSsl = True
            SMTPcl.Host = "smtp.gmail.com"

            SendMail = New MailMessage()
            SendMail.From = New MailAddress("kyle.daman19@gmail.com")
            SendMail.To.Add(txtbxTo.Text)
            SendMail.Subject = txtbxSubject.Text
            SendMail.IsBodyHtml = False
            SendMail.Body = txtbxBody.Text
            Dim msgAtt As New Attachment(file)
            SendMail.Attachments.Add(msgAtt)
            SMTPcl.Send(SendMail)
            MsgBox("E-mail sent!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MsgBox("E-mail failed!", MsgBoxStyle.Critical, "")

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwReportGen.Enable_Form()

    End Sub
End Class