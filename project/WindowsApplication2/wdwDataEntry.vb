Public Class wdwDataEntry
    Dim dbAcess As New databaseAccessor
    Private Sub wdwDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim College As New List(Of Object)



        College = dbAcess.Get_Multiple_Row_Data("Select college_name from College")

        For i As Integer = 0 To College.Count - 1
            cmbbxFacCol.Items.Add(College(i))
            cmbbxDeptCol.Items.Add(College(i))
            cmbbxCourseCol.Items.Add(College(i))
        Next

        cmbbxFacCol.SelectedIndex = 0
        cmbbxDeptCol.SelectedIndex = 0
        cmbbxCourseCol.SelectedIndex = 0


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnCollegeAdd.Click
        Dim CollegeCode As String = Nothing
        Dim CollegeName As String = Nothing

        CollegeCode = dbAcess.Get_Data("Select college_code from College where '" & txtbxCollegeCode.Text & "'", "college_code")
        CollegeName = dbAcess.Get_Data("Select college_Name from College where '" & txtbxCollegeName.Text & "'", "college_name")

        If (CollegeCode = Nothing And CollegeName = Nothing) Then
            dbAcess.Add_Data(" INSERT INTO `introse`.`college` (`college_code`, `college_name`) VALUES ('" & txtbxCollegeCode.Text & "', '" & txtbxCollegeName.Text & "');")

            txtbxCollegeCode.Text = Nothing
            txtbxCollegeName.Text = Nothing


        ElseIf (CollegeCode = Nothing And CollegeName <> Nothing) Then
            MsgBox("College Name already exists. Try Again!")
        ElseIf (CollegeName = Nothing And CollegeCode <> Nothing) Then
            MsgBox("College codee already exists. Try Again!")
        ElseIf (CollegeCode <> Nothing And CollegeName <> Nothing) Then
            MsgBox("College already exists. Try Again!")


        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtbxUnit.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)




    End Sub


    Private Sub txtbxIDNumber_TextChanged(sender As Object, e As EventArgs) Handles txtbxIDNumber.TextChanged

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub cmbbxCourseDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxDeptCol.SelectedIndexChanged

    End Sub

    Private Sub bttnFacAdd_Click(sender As Object, e As EventArgs) Handles bttnFacAdd.Click


        dbAcess.Add_Data("INSERT INTO `introse`.`faculty` (`facultyid`, `f_firstname`, `f_middlename`, `f_lastname`, `email`, `mobilenumber`, `departmentid`, `status`) VALUES ('a', 'a', 'a', 'a', 'a', 'a', 'a', 'a');")

    End Sub

    Private Sub cmbbxFacCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxFacCol.SelectedIndexChanged
        Dim Department As New List(Of Object)
        Dim CollegeCode As String

        cmbbxFacDept.Items.Clear()

        CollegeCode = dbAcess.Get_Data("Select college_code from college where college_name = '" & cmbbxFacCol.SelectedItem & "'", "college_code")

        Department = dbAcess.Get_Multiple_Row_Data("Select departmentname from Department where college_code = '" & CollegeCode & "'")
        For i As Integer = 0 To Department.Count - 1
            cmbbxFacDept.Items.Add(Department(i))
        Next

        If (Department.Count <> 0) Then
            cmbbxFacDept.SelectedIndex = 0
            cmbbxFacDept.Enabled = True
        End If



    End Sub
End Class