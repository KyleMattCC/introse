﻿Public Class wdwFacultyMakeUp
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor
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
        dbAccess.fillDataGrid("Select m.makeupid 'Reference', m.absent_date 'Absent Date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.makeup_date 'Make-up date', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & dtp.Value.Date & "' 
                                order by 4, 12;", grid)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick
        Dim value As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim DeptValue As String


        selectedRow = grid.Rows(value)
        If IsDBNull(value) Then
            txtbxFacultyID.Text = Nothing

        Else
            txtbxFacultyID.Text = selectedRow.Cells("Faculty ID").Value.ToString
            txtbxFacultyName.Text = selectedRow.Cells("Name").Value.ToString
            DeptValue = dbAccess.getStringData("Select departmentname from department, faculty where facultyid = '" + txtbxFacultyID.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")
            txtbxDepartment.Text = DeptValue.ToString

        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
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

End Class