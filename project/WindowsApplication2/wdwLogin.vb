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

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        Dim Found As Boolean
        Dim UserID As String
        Found = False
        UserID = Nothing



        UserID = dbAccess.Get_Data("Select a.id from account a where a.username = '" & txtbxUser.Text & "' and a.password = '" & txtbxPass.Text & " '", "id")

        If (UserID <> Nothing) Then
            Me.Hide()
            wdwMainMenu.Show()
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