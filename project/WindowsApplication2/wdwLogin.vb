Public Class wdwLogin
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Public Function Get_Encoder() As String
        Dim encoder As String = ""

        encoder = dbAccess.Get_Data("Select a.encodername from account a where a.username = '" & txtbxUser.Text & "' and a.password = '" & txtbxPass.Text & " '", "encodername")
        Return encoder

    End Function

    Public Function Get_accountType() As String
        Dim accountType As String = ""

        accountType = dbAccess.Get_Data("Select a.accounttype from account a where a.username = '" & txtbxUser.Text & "' and a.password = '" & txtbxPass.Text & " '", "accounttype")
        Return accountType

    End Function

    Public Function Get_User() As String

        Return txtbxUser.Text

    End Function

    Public Function Get_Pass() As String

        Return txtbxPass.Text

    End Function

    Public Function Get_AcadTerm() As String
        Dim acadterm As String = ""

        acadterm = dbAccess.Get_Data("Select term_no from term t, academicyear a where a.yearid = t.yearid and t.status = 'A' ", "term_no")
        Return acadterm

    End Function

    Public Function Get_AcadYearstart() As String
        Dim acadyearstart As String = ""

        acadyearstart = dbAccess.Get_Data("Select yearstart from term t, academicyear a where a.yearid = t.yearid and t.status = 'A' ", "yearstart")
        Return acadyearstart

    End Function

    Public Function Get_AcadYearend() As String
        Dim acadyearend As String = ""

        acadyearend = dbAccess.Get_Data("Select yearend from term t, academicyear a where a.yearid = t.yearid and t.status = 'A' ", "yearend")
        Return acadyearend

    End Function

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        Dim Found As Boolean
        Dim UserID As String
        Found = False
        UserID = Nothing
        Dim User As String = txtbxUser.Text
        Dim Pass As String = txtbxPass.Text


        UserID = dbAccess.Get_Data("select id from account where BINARY username = '" & User & "' and BINARY password = '" & Pass & "'", "id")

        If (UserID <> Nothing) Then
            Me.Hide()
            wdwMainMenu.Load_Form()
        Else
            MsgBox("Incorrect Username/Password. Try Again.")

        End If





    End Sub
    Private Sub txtbxPass_TextChanged(sender As Object, e As EventArgs) Handles txtbxPass.TextChanged
        txtbxPass.PasswordChar = "*"
    End Sub

    Private Sub wdwLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class