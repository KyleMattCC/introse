Imports MySql.Data.MySqlClient
Public Class wdwDailyAttendanceLog
    Dim dbAccess As DatabaseAccessor = New DatabaseAccessor

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        wdwMainMenu.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles bttnDelete.Click

    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles bttnModify.Click
        wdwModFacultyDaily.Show()

    End Sub

    Private Sub Encode_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        popEncFacDaily.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        popFacSearch.Show()
    End Sub

    Private Sub wdwDailyAttendanceLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbAccess.fillDataGrid("select * from attendance", grid)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim FirstName As String
        Dim MiddleName As String
        Dim LastName As String
        Dim DepartmentName As String
        Dim FacultyID As String


        If FacultyIDButton.Checked = True Then

            FirstName = dbAccess.getStringData("Select f_firstname from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_firstname")
            MiddleName = dbAccess.getStringData("Select f_middlename from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_middlename")
            LastName = dbAccess.getStringData("Select f_lastname from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "f_lastname")
            FacultyID = dbAccess.getStringData("Select facultyid from faculty where facultyid = '" & FacultyIDSearchText.Text & "';", "facultyid")


            DepartmentName = dbAccess.getStringData("Select departmentname from department, faculty where facultyid = '" + FacultyIDSearchText.Text + "' and department.departmentid = faculty.departmentid;", "departmentname")

            FacultyIDText.Text = FacultyID
            FacultyNameText.Text = FirstName + " " + MiddleName + " " + LastName
            DepartmentNameText.Text = DepartmentName

        Else


        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles FacultyIDButton.CheckedChanged
        If FacultyIDButton.Checked = True And CourseSectionButton.Checked = False Then
            CourseSearchText.Enabled = False
            SectionSearchText.Enabled = False
            FacultyIDSearchText.Enabled = True

        Else
            FacultyIDSearchText.Enabled = False
            CourseSearchText.Enabled = True
            SectionSearchText.Enabled = True
        End If
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class