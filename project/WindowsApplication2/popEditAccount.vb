

Public Class popEditAccount
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnChange.Click

        Dim user As String = Nothing
        Dim name As String = Nothing
        Dim id As String

        user = dbAccess.Get_Data("select username from account where username = '" & txtbxUser.Text & "'", "username")
        id = dbAccess.Get_Data("select id from account where username = '" & wdwLogin.Get_Encoder & "'", "id")

        If (user = Nothing) Then

            dbAccess.Update_Data("UPDATE `introse`.`account` SET `encodername`= '" & txtbxName.Text & "', `password`= '" & txtbxPass.Text & "', `username`= '" & txtbxUser.Text & "' WHERE `id`='" & id & "';")
            MsgBox("Credentials Successfully Changed!")
            Me.Close()
        Else
            MsgBox("Username already taken. Try again!")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtbxUser.TextChanged

        If (txtbxUser.Text <> wdwLogin.Get_User Or txtbxName.Text <> wdwLogin.Get_Encoder Or txtbxPass.Text <> wdwLogin.Get_Pass) Then

            bttnChange.Enabled = True
        Else
            bttnChange.Enabled = False
        End If
    End Sub

    Private Sub popEditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxName.Text = wdwLogin.Get_Encoder
        txtbxUser.Text = wdwLogin.Get_User
        txtbxPass.Text = wdwLogin.Get_Pass

        bttnChange.Enabled = False
    End Sub

    Private Sub txtbxName_TextChanged(sender As Object, e As EventArgs) Handles txtbxName.TextChanged
        If (txtbxUser.Text <> wdwLogin.Get_User Or txtbxName.Text <> wdwLogin.Get_Encoder Or txtbxPass.Text <> wdwLogin.Get_Pass) Then

            bttnChange.Enabled = True
        Else
            bttnChange.Enabled = False
        End If
    End Sub

    Private Sub txtbxPass_TextChanged(sender As Object, e As EventArgs) Handles txtbxPass.TextChanged
        If (txtbxUser.Text <> wdwLogin.Get_User Or txtbxName.Text <> wdwLogin.Get_Encoder Or txtbxPass.Text <> wdwLogin.Get_Pass) Then

            bttnChange.Enabled = True
        Else
            bttnChange.Enabled = False
        End If
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()
    End Sub
End Class