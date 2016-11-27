Public Class wdwFacultyMakeUp
    Dim dbAccess As New DatabaseAccessor
    Public RData As List(Of String) = New List(Of String)
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Close()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Me.Enabled = False
        popAddMakeUp.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Load_form()
        dbAccess.fillDataGrid("Select m.makeupid 'Reference', m.makeup_date 'Make-up date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 4, 12;", grid)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick
        Dim Temp As New List(Of String)
        Dim i, j As Integer

        Try
            i = grid.CurrentRow.Index
            j = grid.ColumnCount

            For k As Integer = 0 To j - 1
                If String.IsNullOrEmpty(grid.Item(k, i).Value.ToString) Then
                    MsgBox("Missing data!")
                    Temp.Add(grid.Item(k, i).Value.ToString)
                Else
                    Temp.Add(grid.Item(k, i).Value.ToString)

                End If
            Next

            If (RData.Count = 0) Then
                For k As Integer = 0 To Temp.Count - 1
                    RData.Add(Temp(k))
                Next
            Else
                For k As Integer = 0 To Temp.Count - 1
                    RData(k) = Temp(k)
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Try
            If RData.Count > 0 Then
                Dim reason_cd As List(Of String) = dbAccess.getMultipleData("SELECT reason_desc FROM reason;", "reason_desc")

                For j As Integer = 0 To reason_cd.Count - 1
                    popModMakeup.cmbReason.Items.Add(reason_cd(j))
                Next
                popModMakeup.dtpMakeUpDate.Value = RData(1)
                popModMakeup.txtFacName.Text = RData(3)
                popModMakeup.txtFacID.Text = RData(2)
                popModMakeup.cmbbxCourse.Items.Add(RData(4))
                popModMakeup.cmbbxSection.Items.Add(RData(5))
                popModMakeup.txtbxRoom.Text = RData(8)
                popModMakeup.txtbxStart.Text = RData(6)
                popModMakeup.txtbxEnd.Text = RData(7)

            End If
        Catch ex As Exception

        End Try
        Me.Enabled = False
        popModMakeup.Show()
    End Sub

    Private Sub Find_Click(sender As Object, e As EventArgs)
        popFacSearch.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        wdwSearchByName.Show()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacultyID.TextChanged

    End Sub

    Public Sub Enable_Form()
        Me.Enabled = True
        Load_form()
        Me.Focus()
    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwMainMenu.Enable_Form()
    End Sub

    Private Sub bttnDelete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click
        Try
            If String.IsNullOrEmpty(RData(0)) Then
                MsgBox("No selected attendance")
            Else
                dbAccess.updateData("UPDATE `makeup` SET `status` = 'D' WHERE `makeupid` = '" & RData(0) & "';")
                Load_form()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub grid_MouseClick(sender As Object, e As MouseEventArgs) Handles grid.MouseClick
        Dim Temp As New List(Of String)
        Dim i, j As Integer
        Try

            i = grid.CurrentRow.Index
            j = grid.ColumnCount

            For k As Integer = 0 To j - 1
                If String.IsNullOrEmpty(grid.Item(k, i).Value.ToString) Then
                    MsgBox("Missing data!")
                    Temp.Add(grid.Item(k, i).Value.ToString)
                Else
                    Temp.Add(grid.Item(k, i).Value.ToString)

                End If
            Next

            If (RData.Count = 0) Then
                For k As Integer = 0 To Temp.Count - 1
                    RData.Add(Temp(k))
                Next
            Else
                For k As Integer = 0 To Temp.Count - 1
                    RData(k) = Temp(k)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Load_form()
    End Sub
End Class