Public Class popFacSearch
    Public Faculty_id As String
    Dim tempPath As String

    Public Sub Set_Path(path As String)
        tempPath = path
    End Sub

    Private Sub load_form()
        Me.Show()
        bttnSearch.Enabled = False
    End Sub
    Public Function get_Faculty_id() As String
        Return Faculty_id
    End Function
    Private Sub Validate_Input(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFacID.KeyPress
        Validate_Input("0123456789", e)

    End Sub
    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        load_form()
        Me.Focus()
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        wdwAttendanceHistoryLog.MdiParent = wdwMainMenu
        wdwAttendanceHistoryLog.WindowState = FormWindowState.Normal
        wdwAttendanceHistoryLog.Enable_Form()
        txtFacID.Clear()
        Me.Close()

    End Sub
    Private Sub txtFacID_TextChanged(sender As Object, e As EventArgs) Handles txtFacID.TextChanged
        If String.IsNullOrEmpty(txtFacID.Text) = False Then
            bttnSearch.Enabled = True
            Faculty_id = txtFacID.Text
        Else
            bttnSearch.Enabled = False
        End If
    End Sub

    Private Sub popFacSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_form()
    End Sub

    Private Sub popFacSearch_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If tempPath.Equals("Main") Then
            wdwMainMenu.Enable_Form()
        ElseIf tempPath.Equals("History") Then
            wdwAttendanceHistoryLog.Enable_After_Search_Form()
        End If

    End Sub
End Class