Public Class popAddAccount
    Dim dbAccess As databaseAccessor = New databaseAccessor


    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnAddAccount.Click
        Dim userID As String = Nothing
        Dim accType As String = ""
        userID = dbAccess.Get_Data("Select a.id from account a where a.username = '" & txtbxAddUser.Text & "' ", "id")


        If (rbttnLeadStaff.Checked = True) Then
            accType = "Lead"
        ElseIf (rbttnRegStaff.Checked = True) Then
            accType = "Regular"

        End If

        If (txtbxAddUser.Text <> Nothing And txtbxAddPass.Text <> Nothing And txtbxAddName.Text <> Nothing) Then
            If (userID <> Nothing) Then
                MsgBox("User already exists. Try again.")
            Else
                dbAccess.Add_Data("INSERT INTO `introse`.`account` (`encodername`,  `username`, `password`, `accounttype`) VALUES ('" & txtbxAddName.Text & "','" & txtbxAddUser.Text & "', '" & txtbxAddPass.Text & "', '" & accType & "');")

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

    Private Sub txtbxAddName_TextChanged(sender As Object, e As EventArgs) Handles txtbxAddName.TextChanged

    End Sub
End Class