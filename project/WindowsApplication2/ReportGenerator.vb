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
        Dim reportColumns As New List(Of Object)

        reportColumns = dbAccess.Get_Multiple_Column_Data("select a.attendanceid, c.course_cd, co.section, co.timestart, co.timeend, co.room, r.remark_des, a.checker
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and Year(a.absent_date) = '" & absdate.Year & "' and Month(a.absent_date) = '" & absdate.Month & "' 
                                            and Day(a.absent_date) = '" & absdate.Day & "' and a.remarks_cd = r.remark_cd And a.status = 'A';", 8)

        For ctr = 0 To courses.Count - 1 Step 8
            table.AddCell(absdate.ToShortDateString)
            table.AddCell(reportColumns.Item(ctr + 1).ToString)
            table.AddCell(reportColumns.Item(ctr + 2))
            table.AddCell(reportColumns.Item(ctr + 3) & "-" & endtimes.Item(ctr + 4))
            table.AddCell(reportColumns.Item(ctr + 5))
            table.AddCell(reportColumns.Item(ctr + 6))
            table.AddCell(reportColumns.Item(ctr + 7))
        Next ctr

        pdfDoc.Add(table)

        pdfDoc.Add(New Paragraph("If correct, no reply is necessary."))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("If incorrect, please rectify this report by filling up the online feedback form."))
        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph("Thank you."))
        pdfDoc.Close()

        For ctr = 0 To attendanceid.Count - 8 Step 8
            dbAccess.Update_Data("update introse.attendance set report_status = 'Generated' where attendanceid = '" & attendanceid(ctr) & "';")
        Next
        MsgBox("Successfully Generated Notice!", MsgBoxStyle.OkOnly, "")
        Return filePath

    End Function

End Class
