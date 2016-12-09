Public Class wdwLogin
    Dim dbAccess As databaseAccessor = New databaseAccessor

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

    Private Sub bttnClear_Click(sender As Object, e As EventArgs)
        txtbxPass.Text = Nothing
        txtbxUser.Text = Nothing
    End Sub

    Private Sub txtbxPass_TextChanged(sender As Object, e As EventArgs) Handles txtbxPass.TextChanged
        txtbxPass.PasswordChar = "*"
    End Sub

    Private Sub wdwLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class