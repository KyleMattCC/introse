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
        Dim emailAdd As String

        If reportType = 1 Then
            'emailAdd = dbAccess.Get_Data("select email from introse.faculty where ")
            txtbxSubject.Text = "[OUR] (" & reportFor & " Copy) Daily Attendance Notice"
            txtbxBody.Text = "Attached is a notice of your absence."

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

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim SMTPcl As New SmtpClient
            Dim SendMail As New MailMessage()
            Dim Email As String = "harison@gmail.com"
            Dim Passwordss As String = "allahuakbar"
            SMTPcl.UseDefaultCredentials = False
            SMTPcl.Credentials = New Net.NetworkCredential(Email, Passwordss)
            SMTPcl.Port = 587
            SMTPcl.EnableSsl = True
            SMTPcl.Host = "smtp.gmail.com"

            SendMail = New MailMessage()
            SendMail.From = New MailAddress("harison@gmail.com")
            SendMail.To.Add(txtbxTo.Text)
            SendMail.Subject = txtbxSubject.Text
            SendMail.IsBodyHtml = False
            SendMail.Body = txtbxBody.Text
            SMTPcl.Send(SendMail)
            MsgBox("E-mail sent!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MsgBox("E-mail sending failed!", MsgBoxStyle.Critical, "")

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        wdwReportGen.Enable_Form()

    End Sub

End Class