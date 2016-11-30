Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
Public Class reportGenerator
    Dim dbAccess As New databaseAccessor

    Public Function generateNotice(idnumber As String, name As String, absdate As Date) As String
        Dim filePath As String = Date.Now.ToString("MM-dd-yyyy") & name & ".pdf"

        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))

        pdfDoc.Open()
        Dim header As New Paragraph("Daily Faculty Attendance Report")
        header.Alignment = 1
        pdfDoc.Add(header)
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("For         :        " & name))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Subject   :       NOTICE OF ABSENCE"))
        pdfDoc.Add(New Paragraph("Date       :        " & Date.Now.ToLongDateString))
        pdfDoc.Add(New Paragraph("Please be informed that you have been marked with ABSENCE in the Faculty Attendance Report for the following class(es)."))
        pdfDoc.Add(New Paragraph(" "))

        Dim table As New PdfPTable(7)
        table.HorizontalAlignment = 1
        table.DefaultCell.Padding = 3
        table.WidthPercentage = 100
        table.HorizontalAlignment = Element.ALIGN_LEFT
        table.DefaultCell.BorderWidth = 1
        table.AddCell("Absent Date")
        table.AddCell("Course")
        table.AddCell("Section")
        table.AddCell("Time")
        table.AddCell("Room")
        table.AddCell("Remarks")
        table.AddCell("Checker")

        Dim attendanceid As New List(Of Object)
        Dim courses As New List(Of Object)
        Dim sections As New List(Of Object)
        Dim starttimes As New List(Of Object)
        Dim endtimes As New List(Of Object)
        Dim rooms As New List(Of Object)
        Dim remarks As New List(Of Object)
        Dim checkers As New List(Of Object)

        attendanceid = dbAccess.getMultipleData("select a.attendanceid
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "attendanceid")

        courses = dbAccess.getMultipleData("select c.course_cd
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "course_cd")

        sections = dbAccess.getMultipleData("select co.section
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "section")

        starttimes = dbAccess.getMultipleData("select co.timestart
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "timestart")

        endtimes = dbAccess.getMultipleData("select co.timeend
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "timeend")

        rooms = dbAccess.getMultipleData("select co.room
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "room")

        remarks = dbAccess.getMultipleData("select r.remark_des
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "remark_des")

        checkers = dbAccess.getMultipleData("select a.checker
                                            From introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", "checker")

        For ctr = 0 To courses.Count - 1
            table.AddCell(absdate.ToShortDateString)
            table.AddCell(courses.Item(ctr).ToString)
            table.AddCell(sections.Item(ctr))
            table.AddCell(starttimes.Item(ctr) & "-" & endtimes.Item(ctr))
            table.AddCell(rooms.Item(ctr))
            table.AddCell(remarks.Item(ctr))
            table.AddCell(checkers.Item(ctr))
        Next ctr

        pdfDoc.Add(table)

        pdfDoc.Add(New Paragraph("If correct, no reply is necessary."))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("If incorrect, please rectify this report by filling up the online feedback form."))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Thank you."))
        pdfDoc.Close()

        For ctr = 0 To attendanceid.Count - 1
            dbAccess.updateData("update introse.attendance set report_status = 'Generated' where attendanceid = '" & attendanceid(ctr) & "';")
        Next ctr
        MsgBox("Successfully Generated Notice!", MsgBoxStyle.OkOnly, "")
        Return filePath

    End Function

End Class
