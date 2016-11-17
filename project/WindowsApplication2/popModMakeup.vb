﻿Public Class popModMakeup
    Dim dbAccess As New DatabaseAccessor
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        txtFacName.Clear()
        txtFacID.Clear()
        cmbbxCourse.Items.Clear()
        cmbbxSection.Items.Clear()
        txtbxRoom.Clear()
        txtbxStart.Clear()
        txtbxEnd.Clear()
        txtbxEncoder.Clear()
        txtbxReason.Clear()

        Me.Close()

    End Sub

    Private Sub wdwModMakeup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwFacultyMakeUp.Enable_Form()
    End Sub

    Private Sub bttnModify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        Dim reason_cd As String = ""
        If String.IsNullOrEmpty(cmbReason.Text) Or String.IsNullOrEmpty(txtbxStart.Text) Or String.IsNullOrEmpty(txtbxEnd.Text) Or String.IsNullOrEmpty(txtbxRoom.Text) Or String.IsNullOrEmpty(txtbxEncoder.Text) Or String.IsNullOrEmpty(dtpMakeUpDate.Value.Date.ToString("yyyy-MM-dd")) Then
            MsgBox("Incomplete Fields!")
        Else
            reason_cd = dbAccess.getStringData("select reason_cd from reason where reason_desc = '" & cmbReason.SelectedItem.ToString & "';", "reason_cd")
            MsgBox(wdwFacultyMakeUp.dgAttID + " " + reason_cd)
            dbAccess.updateData("UPDATE `introse`.`makeup` SET `timestart` = '" & txtbxStart.Text & "', `timeend` = '" & txtbxEnd.Text & "',`room` = '" & txtbxRoom.Text & "', `reason_cd` = '" & reason_cd & "', `makeup_date` = '" & dtpMakeUpDate.Value.Date.ToString("yyyy-MM-dd") & "', `enc_date` = '" & Date.Now.Date.ToString("yyyy-MM-dd") & "', `encoder` =  '" & txtbxEncoder.Text & "' WHERE `makeupid` = '" & wdwFacultyMakeUp.dgAttID & "';")
            dbAccess.fillDataGrid("Select m.makeupid 'Reference', m.absent_date 'Absent Date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.makeup_date 'Make-up date', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & wdwFacultyMakeUp.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 4, 12;", wdwFacultyMakeUp.grid)
        End If

    End Sub

    Private Sub cmbReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReason.SelectedIndexChanged
        txtbxReason.Text = cmbReason.SelectedItem.ToString
    End Sub

    Private Sub txtFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFacID.KeyPress
        validateInput("1234567890", e)
    End Sub

    Private Sub txtbxRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxRoom.KeyPress
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", e)
    End Sub

    Private Sub txtbxStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStart.KeyPress
        validateInput("0123456789:", e)
    End Sub
    Private Sub txtbxEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxEnd.KeyPress
        validateInput("0123456789:", e)
    End Sub

    Private Sub txtbxEncoder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxEncoder.KeyPress
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", e)
    End Sub

    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class