Public Class popAddAccount
    Dim dbAccess As databaseAccessor = New databaseAccessor


    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        Dim UserID As String = Nothing
        Dim AccType As String = ""
        UserID = dbAccess.Get_Data("Select a.id from account a where a.username = '" & txtbxAddUser.Text & "' ", "id")


        If (rbttnLeadStaff.Checked = True) Then
            AccType = "Lead"
        ElseIf (rbttnRegStaff.Checked = True) Then
            AccType = "Regular"

        End If

        If (txtbxAddUser.Text <> Nothing And txtbxAddPass.Text <> Nothing And txtbxAddName.Text <> Nothing) Then
            If (UserID <> Nothing) Then
                MsgBox("User already exists. Try again.")
            Else
                dbAccess.Add_Data("INSERT INTO `introse`.`account` (`encodername`,  `username`, `password`, `accounttype`) VALUES ('" & txtbxAddName.Text & "','" & txtbxAddUser.Text & "', '" & txtbxAddPass.Text & "', '" & AccType & "');")

                txtbxAddPass.Text = Nothing
                txtbxAddName.Text = Nothing
                txtbxAddUser.Text = Nothing

            End If

        ElseIf (txtbxAddUser.Text = Nothing And txtbxAddPass.Text = Nothing And txtbxAddName.Text = Nothing) Then
            MsgBox("Some textboxes are both empty. Try again.")

        ElseIf (txtbxAddUser.Text = Nothing) Then
            MsgBox("Username textbox is empty. Try again.")

        ElseIf (txtbxAddPass.Text = Nothing) Then
            MsgBox("Password textbox is empty. Try again.")

        ElseIf (txtbxAddName.Text = Nothing) Then
            MsgBox("Name textbox is empty. Try again.")

        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxAddPass.Text = Nothing
        txtbxAddUser.Text = Nothing
    End Sub

    Private Sub popAddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        rbttnRegStaff.Checked = True
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub

    Private Sub txtbxAddPass_TextChanged(sender As Object, e As EventArgs) Handles txtbxAddPass.TextChanged
        txtbxAddPass.PasswordChar = "*"
    End Sub
End Class