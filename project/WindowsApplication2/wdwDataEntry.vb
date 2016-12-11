Public Class wdwDataEntry
    Dim dbAccess As New databaseAccessor
    Private Sub wdwDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim College As New List(Of Object)



        College = dbAccess.Get_Multiple_Row_Data("Select college_name from College")

        For i As Integer = 0 To College.Count - 1
            cmbbxFacCol.Items.Add(College(i))
            cmbbxDeptCol.Items.Add(College(i))
            cmbbxCourseCol.Items.Add(College(i))
        Next

        cmbbxFacCol.SelectedIndex = 0
        cmbbxDeptCol.SelectedIndex = 0
        cmbbxCourseCol.SelectedIndex = 0

        rbttnUndergrad.Checked = True


        If (txtbxCourseFacID.Text = Nothing) Then
            txtbxCourseCode.Enabled = False
            txtbxSection.Enabled = False
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        Else
            txtbxCourseCode.Enabled = True
        End If

        If (txtbxCourseCode.Text = Nothing) Then
            txtbxSection.Enabled = False
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        Else
            txtbxSection.Enabled = True
        End If

        If (txtbxSection.Text = Nothing) Then
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        Else
            txtbxUnit.Enabled = True
        End If

        If (txtbxUnit.Text = Nothing) Then
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        Else
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True
        End If


    End Sub



    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnCollegeAdd.Click
        Dim CollegeCode As String = Nothing
        Dim CollegeName As String = Nothing

        If (txtbxCollegeCode.Text <> Nothing And txtbxCollegeName.Text <> Nothing) Then


            CollegeCode = dbAccess.Get_Data("Select college_code from College where '" & txtbxCollegeCode.Text & "'", "college_code")
            CollegeName = dbAccess.Get_Data("Select college_Name from College where '" & txtbxCollegeName.Text & "'", "college_name")

            If (CollegeCode = Nothing And CollegeName = Nothing) Then
                dbAccess.Add_Data(" INSERT INTO `introse`.`college` (`college_code`, `college_name`) VALUES ('" & txtbxCollegeCode.Text & "', '" & txtbxCollegeName.Text & "');")

                txtbxCollegeCode.Text = Nothing
                txtbxCollegeName.Text = Nothing


            ElseIf (CollegeCode = Nothing And CollegeName <> Nothing) Then
                MsgBox("College Name already exists. Try Again!")
            ElseIf (CollegeName = Nothing And CollegeCode <> Nothing) Then
                MsgBox("College codee already exists. Try Again!")
            ElseIf (CollegeCode <> Nothing And CollegeName <> Nothing) Then
                MsgBox("College already exists. Try Again!")


            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtbxUnit.TextChanged
        If (txtbxUnit.Text = Nothing) Then
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        Else
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True
        End If
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

        Dim DepartmentID As Integer = 0
        Dim IDNum As String = Nothing
        Dim Name As String = Nothing
        Dim Email As String = Nothing




        If (txtbxIDNumber.Text <> Nothing And txtbxFirstName.Text <> Nothing And txtbxMI.Text <> Nothing And txtbxLastName.Text <> Nothing And txtbxEmail.Text <> Nothing) Then

            IDNum = dbAccess.Get_Data("Select facultyid from faculty where facultyid = '" & txtbxIDNumber.Text & "' ", "facultyid")
            Name = dbAccess.Get_Data("Select concat(f_firstname, f_middlename, f_lastname) from faculty where concat(f_firstname, f_middlename, f_lastname) = concat('" & txtbxFirstName.Text & "', '" & txtbxMI.Text & "', '" & txtbxLastName.Text & "')", "concat(f_firstname, f_middlename, f_lastname)")
            Email = dbAccess.Get_Data("Select email from faculty where email = '" & txtbxEmail.Text & "' ", "email")


            If (IDNum = Nothing And Name = Nothing And Email = Nothing) Then
                DepartmentID = dbAccess.Get_Data("Select departmentid from department where departmentname = '" & cmbbxDeptCol.SelectedItem & "'", "departmentid")
                dbAccess.Add_Data("INSERT INTO `introse`.`faculty` (`facultyid`, `f_firstname`, `f_middlename`, `f_lastname`, `email`, `departmentid`, `status`) VALUES ('" & txtbxIDNumber.Text & "', '" & txtbxFirstName.Text & "', '" & txtbxMI.Text & "', '" & txtbxLastName.Text & "', '" & txtbxEmail.Text & "', '" & DepartmentID & "', 'A');")

                txtbxIDNumber.Text = Nothing
                txtbxFirstName.Text = Nothing
                txtbxMI.Text = Nothing
                txtbxLastName.Text = Nothing
                txtbxEmail.Text = Nothing


            ElseIf (IDNum <> Nothing And Name = Nothing And Email = Nothing) Then
                MsgBox("ID Number has already been taken. Try again!")

            ElseIf (IDNum = Nothing And Name <> Nothing And Email = Nothing) Then
                MsgBox("Name already exists. Try again!")

            ElseIf (IDNum = Nothing And Name = Nothing And Email <> Nothing) Then
                MsgBox("Email has already been taken. Try again!")

            ElseIf (IDNum = Nothing And Name <> Nothing And Email <> Nothing) Then
                MsgBox("Email and Name have already been taken. Try again!")

            ElseIf (IDNum <> Nothing And Name = Nothing And Email <> Nothing) Then
                MsgBox("Email and ID Number have already been taken. Try again!")

            ElseIf (IDNum <> Nothing And Name <> Nothing And Email = Nothing) Then
                MsgBox("Name and ID Number have already been taken. Try again!")

            ElseIf (IDNum <> Nothing And Name <> Nothing And Email <> Nothing) Then
                MsgBox("Credentials already been taken. Try again!")



            End If

        Else
            MsgBox("Some textboxes are empty.")
        End If
    End Sub

    Private Sub cmbbxFacCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxFacCol.SelectedIndexChanged
        Dim Department As New List(Of Object)
        Dim CollegeCode As String

        cmbbxFacDept.Items.Clear()

        CollegeCode = dbAccess.Get_Data("Select college_code from college where college_name = '" & cmbbxFacCol.SelectedItem & "'", "college_code")

        Department = dbAccess.Get_Multiple_Row_Data("Select departmentname from Department where college_code = '" & CollegeCode & "'")
        For i As Integer = 0 To Department.Count - 1
            cmbbxFacDept.Items.Add(Department(i))
        Next

        If (Department.Count <> 0) Then
            cmbbxFacDept.SelectedIndex = 0
            cmbbxFacDept.Enabled = True
        End If



    End Sub

    Private Sub bttnDeptAdd_Click(sender As Object, e As EventArgs) Handles bttnDeptAdd.Click
        Dim College As String = Nothing
        Dim Department As String = Nothing

        If (txtbxDeptName.Text <> Nothing) Then
            College = dbAccess.Get_Data("Select college_code from college where college_name = '" & cmbbxDeptCol.SelectedItem & "'", "college_code")
            Department = dbAccess.Get_Data("Select departmentname from department where departmentname = '" & txtbxDeptName.Text & "'", "departmentname")

            If (Department = Nothing) Then
                dbAccess.Add_Data("INSERT INTO `introse`.`department` (`departmentname`, `college_code`) VALUES ('" & txtbxDeptName.Text & "', '" & College & "');")
                txtbxDeptName.Text = Nothing

            Else
                MsgBox("Department already exists. Try again!")
            End If


        Else
            MsgBox("Department textbox is empty. Try Again!")

        End If




    End Sub

    Private Sub txtbxIDNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxIDNumber.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxUnit.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxStartTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStartTime.KeyPress
        validateInput("0123456789:", e)
    End Sub

    Private Sub txtbxEndTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxStartTime.KeyPress
        validateInput("0123456789:", e)
    End Sub

    Private Sub txtbxCourseFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCourseFacID.KeyPress
        validateInput("0123456789:", e)
    End Sub

    Private Sub rbttnUndergrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnUndergrad.CheckedChanged

    End Sub

    Private Sub bttnCourseAdd_Click(sender As Object, e As EventArgs) Handles bttnCourseAdd.Click
        Dim Course As Integer = Nothing
        Dim OfferedTo As Char = "U"
        Dim StartTime As Integer = Convert.ToInt32(txtbxStartTime.Text)
        Dim EndTime As Integer = Convert.ToInt32(txtbxEndTime.Text)
        Dim Term As Integer
        Dim TempDate As Date = Date.Now
        Dim DateToday As String = TempDate.ToString("yyyy-MM-dd")
        Dim FacrefNo As String = Nothing
        Dim Hours As Double
        Dim Minutes As Double
        Dim Temp As Double
        Dim Holder As String


        If (txtbxCourseFacID.Text = Nothing Or txtbxCourseCode.Text = Nothing Or txtbxSection.Text = Nothing Or txtbxUnit.Text = Nothing Or txtbxDay.Text = Nothing Or txtbxStartTime.Text = Nothing Or txtbxRoom.Text = Nothing Or txtbxEndTime.Text = Nothing) Then
            MsgBox("Some textboxes are empty. Try Again!")
        Else

            If (StartTime > 2400 Or EndTime > 2400 Or StartTime <= 0 Or EndTime <= 0 Or StartTime >= EndTime) Then

                MsgBox("Invalid time input. Try again!")

            Else

                Course = dbAccess.Get_Data("Select course_id from course where course_cd = '" & txtbxCourseCode.Text & "'", "course_id")
                If (Course = Nothing) Then

                    If (rbttnGrad.Checked = True) Then
                        OfferedTo = "G"
                    End If

                    dbAccess.Add_Data("INSERT INTO `introse`.`course` (`course_cd`, `units`, `offered_to`) VALUES ('" & txtbxCourseCode.Text & "' , '" & txtbxUnit.Text & "', '" & OfferedTo & "');")
                End If

                FacrefNo = dbAccess.Get_Data("Select facref_no from faculty where facultyid = '" & txtbxCourseFacID.Text & "'", "facref_no")
                Term = dbAccess.Get_Data("select termid from term where '" & DateToday & "' between start and end", "termid")
                Course = dbAccess.Get_Data("Select course_id from course where course_cd = '" & txtbxCourseCode.Text & "'", "course_id")

                If (FacrefNo <> Nothing And Term <> Nothing) Then
                    Hours = EndTime / 100 - StartTime / 100
                    Minutes = EndTime Mod 100 - StartTime Mod 100

                    If (Minutes < 0) Then
                        Minutes = 60 + Minutes
                        Hours -= 1
                    End If

                    Minutes = Minutes / 60.0
                    Temp = Minutes + Hours

                    Holder = Temp.ToString("0.00")
                    Hours = Convert.ToDouble(Holder)


                    dbAccess.Add_Data("INSERT INTO `introse`.`courseoffering` (`course_id`, `termid`, `facref_no`, `section`, `room`, `daysched`, `timestart`, `timeend`, `hours`, `status`) VALUES ('" & Course & "', '" & Term & "', '" & FacrefNo & "', '" & txtbxSection.Text & "', '" & txtbxRoom.Text & "', '" & txtbxDay.Text & "', '" & txtbxStartTime.Text & "', '" & txtbxEndTime.Text & "', '" & Hours & "', 'A');")
                    Me.Close()
                Else
                    If (FacrefNo = Nothing) Then
                        MsgBox("Faculty ID does not exist. Try again!")

                    ElseIf (Term = Nothing) Then
                        MsgBox("Create a new term first.")

                    End If

                End If



            End If
        End If



    End Sub

    Private Sub txtbxCourseCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxCourseCode.TextChanged
        If (txtbxCourseCode.Text = Nothing) Then
            txtbxSection.Enabled = False
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        ElseIf (txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True
        ElseIf (txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True

        ElseIf (txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text = Nothing) Then
            txtbxSection.Enabled = True

        ElseIf (txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxSection.Enabled = True

        End If
    End Sub

    Private Sub txtbxCourseFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxCourseFacID.TextChanged
        If (txtbxCourseFacID.Text = Nothing) Then
            txtbxCourseCode.Enabled = False
            txtbxSection.Enabled = False
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True

        ElseIf (txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True


        End If

    End Sub

    Private Sub txtbxSection_TextChanged(sender As Object, e As EventArgs) Handles txtbxSection.TextChanged
        If (txtbxSection.Text = Nothing) Then
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        ElseIf (txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxUnit.Enabled = True
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True

        ElseIf (txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxUnit.Enabled = True
        End If
    End Sub

    Private Sub bttnAddClear_Click(sender As Object, e As EventArgs) Handles bttnAddClear.Click
        Dim Course As Integer = Nothing
        Dim OfferedTo As Char = "U"
        Dim StartTime As Integer = Convert.ToInt32(txtbxStartTime.Text)
        Dim EndTime As Integer = Convert.ToInt32(txtbxEndTime.Text)
        Dim Term As Integer
        Dim TempDate As Date = Date.Now
        Dim DateToday As String = TempDate.ToString("yyyy-MM-dd")
        Dim FacrefNo As String = Nothing
        Dim Hours As Double
        Dim Minutes As Double
        Dim Temp As Double
        Dim Holder As String


        If (txtbxCourseFacID.Text = Nothing Or txtbxCourseCode.Text = Nothing Or txtbxSection.Text = Nothing Or txtbxUnit.Text = Nothing Or txtbxDay.Text = Nothing Or txtbxStartTime.Text = Nothing Or txtbxRoom.Text = Nothing Or txtbxEndTime.Text = Nothing) Then
            MsgBox("Some textboxes are empty. Try Again!")
        Else

            If (StartTime > 2400 Or EndTime > 2400 Or StartTime <= 0 Or EndTime <= 0 Or StartTime >= EndTime) Then

                MsgBox("Invalid time input. Try again!")

            Else

                Course = dbAccess.Get_Data("Select course_id from course where course_cd = '" & txtbxCourseCode.Text & "'", "course_id")
                If (Course = Nothing) Then

                    If (rbttnGrad.Checked = True) Then
                        OfferedTo = "G"
                    End If

                    dbAccess.Add_Data("INSERT INTO `introse`.`course` (`course_cd`, `units`, `offered_to`) VALUES ('" & txtbxCourseCode.Text & "' , '" & txtbxUnit.Text & "', '" & OfferedTo & "');")
                End If

                FacrefNo = dbAccess.Get_Data("Select facref_no from faculty where facultyid = '" & txtbxCourseFacID.Text & "'", "facref_no")
                Term = dbAccess.Get_Data("select termid from term where '" & DateToday & "' between start and end", "termid")
                Course = dbAccess.Get_Data("Select course_id from course where course_cd = '" & txtbxCourseCode.Text & "'", "course_id")

                If (FacrefNo <> Nothing And Term <> Nothing) Then
                    Hours = EndTime / 100 - StartTime / 100
                    Minutes = EndTime Mod 100 - StartTime Mod 100

                    If (Minutes < 0) Then
                        Minutes = 60 + Minutes
                        Hours -= 1
                    End If

                    Minutes = Minutes / 60.0
                    Temp = Minutes + Hours

                    Holder = Temp.ToString("0.00")
                    Hours = Convert.ToDouble(Holder)


                    dbAccess.Add_Data("INSERT INTO `introse`.`courseoffering` (`course_id`, `termid`, `facref_no`, `section`, `room`, `daysched`, `timestart`, `timeend`, `hours`, `status`) VALUES ('" & Course & "', '" & Term & "', '" & FacrefNo & "', '" & txtbxSection.Text & "', '" & txtbxRoom.Text & "', '" & txtbxDay.Text & "', '" & txtbxStartTime.Text & "', '" & txtbxEndTime.Text & "', '" & Hours & "', 'A');")
                    txtbxCourseCode.Text = Nothing
                    txtbxCourseFacID.Text = Nothing
                    txtbxSection.Text = Nothing
                    txtbxUnit.Text = Nothing
                    txtbxDay.Text = Nothing
                    txtbxRoom.Text = Nothing
                    txtbxStartTime.Text = Nothing
                    txtbxEndTime.Text = Nothing
                    rbttnUndergrad.Checked = True
                Else
                    If (FacrefNo = Nothing) Then
                        MsgBox("Faculty ID does not exist. Try again!")

                    ElseIf (Term = Nothing) Then
                        MsgBox("Create a new term first.")

                    End If

                End If



            End If
        End If
    End Sub

    Private Sub txtbxDeptName_TextChanged(sender As Object, e As EventArgs) Handles txtbxDeptName.TextChanged

    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bttnBackTerm.Click
        Me.Close()
    End Sub

    Private Sub bttnCourseBack_Click(sender As Object, e As EventArgs) Handles bttnCourseBack.Click
        Me.Close()
    End Sub

    Private Sub bttnDeptBack_Click(sender As Object, e As EventArgs) Handles bttnDeptBack.Click
        Me.Close()
    End Sub

    Private Sub bttnCollegeBack_Click(sender As Object, e As EventArgs) Handles bttnCollegeBack.Click
        Me.Close()
    End Sub

    Private Sub bttnFacBack_Click(sender As Object, e As EventArgs) Handles bttnFacBack.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnAddTerm.Click
        MsgBox("Are you sure you want to add a new term and delete the old one?")
    End Sub
End Class