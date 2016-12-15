Imports System.Data.Odbc
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb


Public Class wdwDataEntry
    Dim dbAccess As New databaseAccessor
    Private Sub wdwDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim College As New List(Of Object)
        Dim year As New List(Of Object)



        College = dbAccess.Get_Multiple_Row_Data("Select college_name from College")

        cmbbxDeptCol.Items.Clear()
        cmbbxFacCol.Items.Clear()

        For i As Integer = 0 To College.Count - 1
            cmbbxFacCol.Items.Add(College(i))
            cmbbxDeptCol.Items.Add(College(i))

        Next

        txtbxFacName.Enabled = False

        year = dbAccess.Get_Multiple_Row_Data("Select concat(yearstart, ' - ', yearend) from academicyear")
        For i As Integer = 0 To year.Count - 1
            cmbbxAcadYear.Items.Add(year(i))
        Next



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


        cmbbxTerm.Items.Add(1)
        cmbbxTerm.Items.Add(2)
        cmbbxTerm.Items.Add(3)
        dtpStart.Enabled = False
        dtpEnd.Enabled = False


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


            CollegeCode = dbAccess.Get_Data("Select college_code from College where college_code = '" & txtbxCollegeCode.Text & "'", "college_code")
            CollegeName = dbAccess.Get_Data("Select college_Name from College where college_name = '" & txtbxCollegeName.Text & "'", "college_name")

            If (CollegeCode = Nothing And CollegeName = Nothing) Then
                dbAccess.Add_Data(" INSERT INTO `introse`.`college` (`college_code`, `college_name`) VALUES ('" & txtbxCollegeCode.Text & "', '" & txtbxCollegeName.Text & "');")

                txtbxCollegeCode.Text = Nothing
                txtbxCollegeName.Text = Nothing


            ElseIf (CollegeCode = Nothing And CollegeName <> Nothing) Then
                MsgBox("College Name already exists. Try Again!")
            ElseIf (CollegeName = Nothing And CollegeCode <> Nothing) Then
                MsgBox(CollegeCode)
                MsgBox("College code already exists. Try Again!")
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
                cmbbxFacCol.SelectedIndex = 1
                cmbbxFacCol.SelectedIndex = 0

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
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxCourseFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCourseFacID.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub rbttnUndergrad_CheckedChanged(sender As Object, e As EventArgs) Handles rbttnUndergrad.CheckedChanged

    End Sub

    Private Sub bttnCourseAdd_Click(sender As Object, e As EventArgs) Handles bttnCourseAdd.Click

        If (txtbxCourseFacID.Text = Nothing Or txtbxCourseCode.Text = Nothing Or txtbxSection.Text = Nothing Or txtbxUnit.Text = Nothing Or txtbxDay.Text = Nothing Or txtbxStartTime.Text = Nothing Or txtbxRoom.Text = Nothing Or txtbxEndTime.Text = Nothing) Then
            MsgBox("Some textboxes are empty. Try Again!")
        Else

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
                    wdwFacPlantilia.Load_form()
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

        Dim FacName As String = Nothing

        FacName = dbAccess.Get_Data("Select concat(f_lastname, ', ', f_firstname, ' ', f_middlename) from faculty where facultyid = '" & txtbxCourseFacID.Text & "'", "concat(f_lastname, ', ', f_firstname, ' ', f_middlename)")

        If (FacName <> Nothing) Then
            txtbxFacName.Text = FacName
        Else
            txtbxFacName.Text = Nothing
        End If

        If (txtbxCourseFacID.Text = Nothing Or FacName = Nothing) Then
            txtbxCourseCode.Enabled = False
            txtbxSection.Enabled = False
            txtbxUnit.Enabled = False
            txtbxDay.Enabled = False
            txtbxRoom.Enabled = False
            txtbxStartTime.Enabled = False
            txtbxEndTime.Enabled = False
        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True
            txtbxDay.Enabled = True
            txtbxRoom.Enabled = True
            txtbxStartTime.Enabled = True
            txtbxEndTime.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True
            txtbxUnit.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text = Nothing And txtbxSection.Text <> Nothing And txtbxUnit.Text <> Nothing) Then
            txtbxCourseCode.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text = Nothing) Then
            txtbxCourseCode.Enabled = True
            txtbxSection.Enabled = True

        ElseIf (FacName <> Nothing And txtbxCourseFacID.Text <> Nothing And txtbxCourseCode.Text <> Nothing And txtbxSection.Text = Nothing And txtbxUnit.Text <> Nothing) Then
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

        If (txtbxCourseFacID.Text = Nothing Or txtbxCourseCode.Text = Nothing Or txtbxSection.Text = Nothing Or txtbxUnit.Text = Nothing Or txtbxDay.Text = Nothing Or txtbxStartTime.Text = Nothing Or txtbxRoom.Text = Nothing Or txtbxEndTime.Text = Nothing) Then
            MsgBox("Some textboxes are empty. Try Again!")
        Else

            Dim Course As Integer = Nothing
            Dim OfferedTo As Char = "U"
            Dim startTime As Integer = Convert.ToInt32(txtbxStartTime.Text)
            Dim endTime As Integer = Convert.ToInt32(txtbxEndTime.Text)
            Dim Term As Integer
            Dim TempDate As Date = Date.Now
            Dim DateToday As String = TempDate.ToString("yyyy-MM-dd")
            Dim FacrefNo As String = Nothing
            Dim wholeNumber As Integer
            Dim tempStart As Double
            Dim tempEnd As String

            If (startTime > 2400 Or endTime > 2400 Or startTime <= 0 Or endTime <= 0 Or startTime >= endTime) Then

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

                    startTime = Convert.ToInt32(txtbxStartTime.Text)
                    endTime = Convert.ToInt32(txtbxEndTime.Text)
                    tempStart = startTime
                    tempEnd = endTime
                    If ((tempStart Mod 100) > tempEnd Mod 100) Then
                        Dim tempMinutes As Integer = startTime Mod 100
                        tempStart -= tempMinutes
                        tempEnd -= (tempMinutes + 40)
                    End If
                    wholeNumber = (tempEnd - tempStart) / 100

                    If ((startTime < 0 Or startTime > 2359) Or (startTime / 100 > 24 Or startTime Mod 100 > 59)) Then
                        MsgBox("Invalid start time input!", MsgBoxStyle.Critical, "")

                    ElseIf ((endTime < 0 Or endTime > 2359) Or (endTime / 100 > 24 Or endTime Mod 100 > 59)) Then
                        MsgBox("Invalid end time input!", MsgBoxStyle.Critical, "")

                    ElseIf (endTime < startTime) Then
                        MsgBox("End time cannot be less than start time!", MsgBoxStyle.Critical, "")

                    ElseIf (startTime = endTime) Then
                        MsgBox("Start and end time cannot be the same!", MsgBoxStyle.Critical, "")

                    ElseIf (Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = .0) And Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = 0.5)) Then
                        MsgBox("Makeup hours is not exact!", MsgBoxStyle.Critical, "")

                    Else


                        dbAccess.Add_Data("INSERT INTO `introse`.`courseoffering` (`course_id`, `termid`, `facref_no`, `section`, `room`, `daysched`, `timestart`, `timeend`, `hours`, `status`) VALUES ('" & Course & "', '" & Term & "', '" & FacrefNo & "', '" & txtbxSection.Text & "', '" & txtbxRoom.Text & "', '" & txtbxDay.Text & "', '" & txtbxStartTime.Text & "', '" & txtbxEndTime.Text & "', " & (wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) & ", 'A');")
                        txtbxCourseCode.Text = Nothing
                        txtbxCourseFacID.Text = Nothing
                        txtbxSection.Text = Nothing
                        txtbxUnit.Text = Nothing
                        txtbxDay.Text = Nothing
                        txtbxRoom.Text = Nothing
                        txtbxStartTime.Text = Nothing
                        txtbxEndTime.Text = Nothing
                        rbttnUndergrad.Checked = True

                        wdwFacPlantilia.Load_form()
                    End If


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




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bttnBackTerm.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub bttnCourseBack_Click(sender As Object, e As EventArgs) Handles bttnCourseBack.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub bttnDeptBack_Click(sender As Object, e As EventArgs) Handles bttnDeptBack.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub bttnCollegeBack_Click(sender As Object, e As EventArgs) Handles bttnCollegeBack.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub bttnFacBack_Click(sender As Object, e As EventArgs) Handles bttnFacBack.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnAddTerm.Click


        Dim Term As Integer = Nothing
        Dim YearID As Integer = Nothing
        Dim TermDate As Integer = Nothing
        Dim TermStatus As New List(Of Object)
        Dim YearStatus As String = Nothing
        Dim FacStatus As New List(Of Object)
        Dim result As DialogResult

        If (cmbbxTerm.SelectedIndex = -1) Then

            YearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", "yearid")
            Term = dbAccess.Get_Data("Select term_no from term where Term_no = '" & cmbbxTerm.SelectedItem & "' and yearid = '" & YearID & "'", "term_no")
            TermDate = dbAccess.Get_Data("Select termid from term where '" & dtpStart.Value.Date.ToString("yyyy-MM-dd") & "' between start and end and '" & dtpEnd.Value.Date.ToString("yyyy-MM-dd") & "' between start and end", "termid")
            YearStatus = dbAccess.Get_Data("Select status from academicyear where yearid = '" & YearID & "'", "status")


            MsgBox(YearStatus)
            If (dtpStart.Value.Date.ToString("yyyy-MM-dd") >= dtpEnd.Value.Date.ToString("yyyy-MM-dd")) Then
                TermDate = 1
            End If

            If (Term = Nothing) Then
                If (TermDate = Nothing) Then

                    If (YearStatus = "A") Then

                        result = MsgBox("Are you sure you want to start a new term? ", MsgBoxStyle.YesNo, "")
                        If result = DialogResult.Yes Then


                            TermStatus = dbAccess.Get_Multiple_Row_Data("Select termid from term where status = 'A'")
                            FacStatus = dbAccess.Get_Multiple_Row_Data("Select courseoffering_id from courseoffering where status = 'A'")

                            For i As Integer = 0 To TermStatus.Count - 1
                                dbAccess.Update_Data("UPDATE `introse`.`term` SET `status`='R' WHERE `termid`='" & TermStatus(i) & "';")
                            Next

                            For i As Integer = 0 To FacStatus.Count - 1
                                dbAccess.Update_Data("UPDATE `introse`.`courseoffering` SET `status` = 'R' WHERE `courseoffering_id` = '" & FacStatus(i) & "'")
                            Next

                            dbAccess.Add_Data("INSERT INTO `introse`.`term` (`yearid`, `term_no`, `start`, `end`, `status`) VALUES ('" & YearID & "', '" & cmbbxTerm.SelectedItem & "', '" & dtpStart.Value.Date.ToString("yyyy-MM-dd") & "', '" & dtpEnd.Value.Date.ToString("yyyy-MM-dd") & "', 'A');")
                            cmbbxTerm.SelectedIndex = -1

                            wdwFacPlantilia.Load_form()

                        End If

                    Else

                        MsgBox("Academic Year chosen is already finished. Try again.")

                    End If
                Else
                    MsgBox("Invalid Date inputs. Try again.")
                End If

            Else
                MsgBox("Term already exists in this Academic Year. Try again.")

            End If

        Else
            MsgBox("Term textbox is empty. Try again.")
        End If




    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles filediaSearch.Click
        Dim dialog As New OpenFileDialog
        dialog.Title = "Open Excel File"
        dialog.Filter = "Microsoft Excel|*.xl*"
        If (dialog.ShowDialog() = DialogResult.OK) Then


            Try

                Dim MyConnection As System.Data.OleDb.OleDbConnection
                Dim dataSet As System.Data.DataSet
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                Dim path As String = dialog.FileName

                MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
                MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

                dataSet = New System.Data.DataSet
                MyCommand.Fill(dataSet)
                grid.DataSource = dataSet.Tables(0)


                MyConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim YearStart As Integer = Convert.ToInt32(txtbxYearStart.Text)
        Dim YearEnd As Integer = Convert.ToInt32(txtbxYearEnd.Text)
        Dim YearID As New List(Of Object)

        If (txtbxYearStart.Text <> Nothing And txtbxYearEnd.Text <> Nothing) Then

            If (YearStart >= YearEnd) Then
                MsgBox("Invalid Year Inputs. Try again.")

            Else

                YearID = dbAccess.Get_Multiple_Row_Data("select yearid from academicyear where status = 'A'")

                If (YearID.Count <> 0) Then

                    For i As Integer = 0 To YearID.Count - 1
                        dbAccess.Update_Data("UPDATE `introse`.`academicyear` SET `status`='R' WHERE `yearid`='" & YearID(i) & "';")
                    Next
                End If
                dbAccess.Add_Data("INSERT INTO `introse`.`academicyear` (`yearstart`, `yearend`, `status`) VALUES ('" & YearStart & "', '" & YearEnd & "', 'A');")
                txtbxYearStart.Text = Nothing
                txtbxYearEnd.Text = Nothing

            End If

        Else
            MsgBox("Some Textboxes are empty. Try again.")

        End If

    End Sub

    Private Sub txtbxYearStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxYearStart.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxYearEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxYearEnd.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxTerm_KeyPress(sender As Object, e As KeyPressEventArgs)
        validateInput("0123456789", e)
    End Sub



    Private Sub txtbxEndTime_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtbxEndTime.KeyPress
        validateInput("0123456789", e)
    End Sub

    Private Sub txtbxCollegeCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCollegeCode.KeyPress
        validateInput("ABCDEFGHIJKLMNOPQRST", e)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub bttnUpload_Click(sender As Object, e As EventArgs) Handles bttnUpload.Click


        Dim courseID As Integer
        Dim termID As Integer
        Dim facrefNo As Integer
        Dim section As String
        Dim room As String
        Dim daySched As String
        Dim startTime As Integer
        Dim endTime As Integer


        Dim facultyName As String
        Dim courseCode As String
        Dim temp1() As String
        Dim temp As String
        Dim time1 As String = Nothing
        Dim time2 As String = Nothing
        Dim wholeNumber As Integer







        For i As Integer = 0 To grid.RowCount - 1

            If (IsDBNull(grid.Rows(i).Cells(0).Value)) Then
            Else
                facultyName = grid.Rows(i).Cells(0).Value
                courseCode = grid.Rows(i).Cells(2).Value
                section = grid.Rows(i).Cells(3).Value
                daySched = grid.Rows(i).Cells(4).Value



                temp = grid.Rows(i).Cells(5).Value

                time1 = temp.Chars(0) + temp.Chars(1) + temp.Chars(2) + temp.Chars(3)
                time2 = temp.Chars(5) + temp.Chars(6) + temp.Chars(7) + temp.Chars(8)


                startTime = Convert.ToInt32(time1)
                endTime = Convert.ToInt32(time2)
                time1 = startTime
                time2 = endTime
                If ((time1 Mod 100) > time2 Mod 100) Then
                    Dim tempMinutes As Integer = startTime Mod 100
                    time1 -= tempMinutes
                    time2 -= (tempMinutes + 40)
                End If
                wholeNumber = (time2 - time1) / 100


                room = grid.Rows(i).Cells(6).Value

                MsgBox(facultyName)
                MsgBox(courseCode)
                MsgBox(section)

                courseID = dbAccess.Get_Data("Select course_id from course where course_cd = '" & courseCode & "';", "course_id")
                facrefNo = dbAccess.Get_Data("Select facref_no from faculty where concat(f_lastname, ', ', f_firstname, ' ', f_middlename) = '" & facultyName & "';", "facref_no")
                termID = dbAccess.Get_Data("Select termid from term where status = 'A';", "termid")


                dbAccess.Add_Data("INSERT INTO `introse`.`courseoffering` (`course_id`, `termid`, `facref_no`, `section`, `room`, `daysched`, `timestart`, `timeend`, `hours`, `status`) VALUES ('" & courseID & "', '" & termID & "', '" & facrefNo & "', '" & section & "', '" & room & "', '" & daySched & "', '" & startTime & "', '" & endTime & "', '" & (wholeNumber + ((time2 - time1) Mod 100) / 60) & "', 'A');")
            End If

        Next





    End Sub

    Private Sub txtbxTerm_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        If (cmbbxTerm.SelectedIndex <> -1 And cmbbxAcadYear.SelectedIndex <> -1) Then
            dtpStart.Enabled = True
            dtpEnd.Enabled = True
        End If
    End Sub

    Private Sub cmbbxAcadYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxAcadYear.SelectedIndexChanged
        If (cmbbxTerm.SelectedIndex <> -1 And cmbbxAcadYear.SelectedIndex <> -1) Then
            dtpStart.Enabled = True
            dtpEnd.Enabled = True
        End If
    End Sub
End Class