Public Class popModifyPlantilla
    Dim dbAccess As databaseAccessor = New databaseAccessor
    Private Sub TabPage4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacName.TextChanged

    End Sub

    Private Sub popModifyPlantilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxFacName.Enabled = False

    End Sub

    Public Sub Load_Form(rowData As List(Of String))
        Dim FacultyID As String
        Dim Units As Integer
        Dim College As New List(Of Object)
        Dim Offer As String


        FacultyID = dbAccess.Get_Data("Select facultyid from faculty where concat(f_lastname, ', ', f_firstname, ' ', f_middlename) = '" & rowData(2).ToString & "'", "facultyid")
        Units = dbAccess.Get_Data("Select units from course where course_cd = '" & rowData(1) & "'", "units")
        College = dbAccess.Get_Multiple_Row_Data("Select college_name from College")
        Offer = dbAccess.Get_Data("Select offered_to from course where course_cd = '" & rowData(1) & "'", "offered_to")


        txtbxCourseFacID.Text = FacultyID
        txtbxFacName.Text = rowData(2)
        txtbxCourseCode.Text = rowData(1)
        txtbxSection.Text = rowData(3)
        txtbxUnit.Text = Units
        txtbxDay.Text = rowData(5)
        txtbxRoom.Text = rowData(4)
        txtbxStartTime.Text = rowData(6)
        txtbxEndTime.Text = rowData(7)





        Me.Show()






    End Sub



    Private Sub bttnCourseModify_Click(sender As Object, e As EventArgs) Handles bttnCourseModify.Click

        Dim courseID As Integer
        Dim termID As Integer
        Dim facrefNo As Integer
        Dim startTime As Integer
        Dim endTime As Integer
        Dim tempStart As Integer
        Dim tempEnd As Integer
        Dim courseOfferingID As Integer = wdwFacPlantilia.get_CourseOfferingID

        If (txtbxCourseFacID.Text = Nothing Or txtbxCourseCode.Text = Nothing Or txtbxSection.Text = Nothing Or txtbxUnit.Text = Nothing Or txtbxDay.Text = Nothing Or txtbxStartTime.Text = Nothing Or txtbxRoom.Text = Nothing Or txtbxEndTime.Text = Nothing) Then

            MsgBox("Some textboxes are empty. Try again.")

        Else
            termID = wdwFacPlantilia.getTermID
            courseID = dbAccess.Get_Data("Select course_id from course where course_cd = '" & txtbxCourseCode.Text & "' ", "course_id")
            facrefNo = dbAccess.Get_Data("Select Facref_No from faculty where facultyid = '" & txtbxCourseFacID.Text & "'", "facref_no")

            Dim wholeNumber As Integer
            startTime = Convert.ToInt32(txtbxStartTime.Text)
            EndTime = Convert.ToInt32(txtbxEndTime.Text)
            tempStart = StartTime
            tempEnd = EndTime
            If ((tempStart Mod 100) > tempEnd Mod 100) Then
                Dim tempMinutes As Integer = StartTime Mod 100
                tempStart -= tempMinutes
                tempEnd -= (tempMinutes + 40)
            End If
            wholeNumber = (tempEnd - tempStart) / 100

            If ((StartTime < 0 Or StartTime > 2359) Or (StartTime / 100 > 24 Or StartTime Mod 100 > 59)) Then
                MsgBox("Invalid start time input!", MsgBoxStyle.Critical, "")

            ElseIf ((EndTime < 0 Or EndTime > 2359) Or (EndTime / 100 > 24 Or EndTime Mod 100 > 59)) Then
                MsgBox("Invalid end time input!", MsgBoxStyle.Critical, "")

            ElseIf (EndTime < StartTime) Then
                MsgBox("End time cannot be less than start time!", MsgBoxStyle.Critical, "")

            ElseIf (StartTime = EndTime) Then
                MsgBox("Start and end time cannot be the same!", MsgBoxStyle.Critical, "")

            ElseIf (Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = .0) And Not (((wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) Mod 1) = 0.5)) Then
                MsgBox("Makeup hours is not exact!", MsgBoxStyle.Critical, "")

            Else

                If (courseID = Nothing) Then
                    MsgBox("Course does not exist yet. Try again")
                Else
                    If (facrefNo = Nothing) Then
                        MsgBox("Faculty ID does not exist. Try again")
                    Else
                        dbAccess.Update_Data("UPDATE `introse`.`courseoffering` SET `course_id`='" & courseID & "', `facref_no`='" & facrefNo & "', `section`='" & txtbxSection.Text & "', `room`='" & txtbxRoom.Text & "', `daysched`='" & txtbxDay.Text & "', `timestart`='" & txtbxStartTime.Text & "', `timeend`='" & txtbxEndTime.Text & "', `hours`='" & (wholeNumber + ((tempEnd - tempStart) Mod 100) / 60) & "' WHERE `courseoffering_id`='" & courseOfferingID & "';")
                        MsgBox("Successfully Modified!")
                    End If
                End If

            End If


        End If


    End Sub

    Private Sub popModifyPlantilla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        wdwFacPlantilia.Enable_Form()

    End Sub

    Private Sub bttnCourseBack_Click(sender As Object, e As EventArgs) Handles bttnCourseBack.Click

        wdwFacPlantilia.Enable_Form()
        Me.Close()
    End Sub

    Private Sub txtbxCourseFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxCourseFacID.TextChanged
        txtbxFacName.Text = dbAccess.Get_Data("Select concat(f_lastname, ', ', f_firstname, ' ', f_middlename) from faculty where facultyid = '" & txtbxCourseFacID.Text & "'", "concat(f_lastname, ', ', f_firstname, ' ', f_middlename)")
    End Sub

    Private Sub txtbxCourseCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxCourseCode.TextChanged

    End Sub
End Class