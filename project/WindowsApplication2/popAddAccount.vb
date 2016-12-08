Public Class popAddAccount
    Dim dbAccess As databaseAccessor = New databaseAccessor


    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        Dim UserID As String
        UserID = dbAccess.Get_Data("Select a.id from account a where a.encodername = '" & txtbxAddUser.Text & "' ", "id")

        If (txtbxAddUser.Text <> Nothing And txtbxAddPass.Text <> Nothing) Then
            If (UserID <> Nothing) Then
                MsgBox("User already exists. Try again.")
            Else
                dbAccess.Add_Data("INSERT INTO `introse`.`account` (`encodername`, `password`, `accounttype`) VALUES ('" & txtbxAddUser.Text & "', '" & txtbxAddPass.Text & "', 'Regular');")

                txtbxAddPass.Text = Nothing
                txtbxAddUser.Text = Nothing

            End If

        ElseIf (txtbxAddUser.Text = Nothing And txtbxAddPass.Text = Nothing) Then
            MsgBox("Username and Password textboxes are both empty.")

        ElseIf (txtbxAddUser.Text = Nothing) Then
            MsgBox("Username textbox is empty.")

        ElseIf (txtbxAddPass.Text = Nothing) Then
            MsgBox("Password textbox is empty.")

        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxAddPass.Text = Nothing
        txtbxAddUser.Text = Nothing
    End Sub

    Private Sub popAddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
End Class