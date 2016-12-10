Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
Public Class reportGenerator
    Dim dbAccess As New databaseAccessor

    Public Function Generate_Daily_Notice(idnumber As String, name As String, absdate As Date) As String
        Try
            Dim filePath As String = absdate.ToString("MM-dd-yyyy") & name & ".pdf"

            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)


            pdfDoc.Open()
            Dim header As New Paragraph("Daily Faculty Attendance Report", fntTableFontHdr)
            header.Alignment = 1
            pdfDoc.Add(header)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("For         :       " & name, fntTableFontHdr))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Subject   :       NOTICE OF ABSENCE", fntTableFontHdr))
            pdfDoc.Add(New Paragraph("Date       :       " & Date.Now.ToLongDateString, fntTableFontHdr))
            pdfDoc.Add(New Paragraph("Please be informed that you have been marked with ABSENCE in the Faculty Attendance Report for the following class(es).", fntTableFont))
            pdfDoc.Add(New Paragraph(" "))

            Dim table As New PdfPTable(7)
            table.SpacingBefore = 10
            table.SpacingAfter = 10
            table.HorizontalAlignment = 1
            table.DefaultCell.Padding = 3
            table.WidthPercentage = 100
            table.HorizontalAlignment = Element.ALIGN_LEFT
            table.DefaultCell.BorderWidth = 1
            Dim sglTblHdWidths(6) As Single
            sglTblHdWidths(0) = 130
            sglTblHdWidths(1) = 100
            sglTblHdWidths(2) = 75
            sglTblHdWidths(3) = 100
            sglTblHdWidths(4) = 85
            sglTblHdWidths(5) = 190
            sglTblHdWidths(6) = 100
            table.SetWidths(sglTblHdWidths)
            table.AddCell(New Phrase("Absent Date", fntTableFontHdr))
            table.AddCell(New Phrase("Course", fntTableFontHdr))
            table.AddCell(New Phrase("Section", fntTableFontHdr))
            table.AddCell(New Phrase("Time", fntTableFontHdr))
            table.AddCell(New Phrase("Room", fntTableFontHdr))
            table.AddCell(New Phrase("Remarks", fntTableFontHdr))
            table.AddCell(New Phrase("Checker", fntTableFontHdr))

            Dim reportColumns As New List(Of Object)

            reportColumns = dbAccess.Get_Multiple_Column_Data("select a.attendanceid, c.course_cd, co.section, co.timestart, co.timeend, co.room, r.remark_des, a.checker
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and a.absent_date = '" & absdate.ToString("yy-MM-dd") & "' And a.remarks_cd = r.remark_cd And a.status = 'A';", 8)

            For ctr = 0 To reportColumns.Count - 1 Step 8
                table.AddCell(New Phrase(absdate.ToShortDateString, fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 1).ToString, fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 2), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 3) & "-" & reportColumns.Item(ctr + 4), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 5), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 6), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 7), fntTableFont))
            Next ctr

            pdfDoc.Add(table)

            pdfDoc.Add(New Paragraph("If correct, no reply is necessary."))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("If incorrect, please rectify this report by filling up the online feedback form."))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Thank you."))
            pdfDoc.Close()

            For ctr = 0 To reportColumns.Count - 8 Step 8
                dbAccess.Update_Data("update introse.attendance set report_status = 'Generated' where attendanceid = '" & reportColumns(ctr) & "';")
            Next
            MsgBox("Successfully Generated Notice!", MsgBoxStyle.OkOnly, "")
            Return filePath

        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")
            Return Nothing

        End Try
    End Function

    Public Function Generate_Daily_Report(absDate As Date) As String
        Try
            Dim filePath As String = absDate.ToString("MM-dd-yyyy") & "Daily-Report.pdf"
            Dim pageNo As Integer = 1
            Dim pdfDoc As New Document()
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))
            Dim collegeGroup As String = Nothing
            Dim deptGroup As String = Nothing

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()

            Dim reportColumns As New List(Of Object)()
            Dim termAY As New List(Of Object)()
            reportColumns = dbAccess.Get_Multiple_Column_Data("select col.college_name, dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                                                                from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                                                                where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.absent_date = '" & absDate.ToString("yy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                                                                and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code
                                                                order by 1, 2, 3;", 9)
            termAY = dbAccess.Get_Multiple_Column_Data("select t.term_no, a.yearstart, a.yearend
                                                        from introse.term t, introse.academicyear a
                                                        where t.status = 'A' and a.status = 'A';", 3)
            Dim ctrLines As Integer = 0
            Dim ctr As Integer = 0
            While ctr < reportColumns.Count - 1
                Dim pageHeader As New Paragraph("Page " & pageNo, fntTableFontHdr)
                pageHeader.Alignment = 2
                pdfDoc.Add(pageHeader)
                pdfDoc.Add(New Paragraph(""))
                pdfDoc.Add(New Paragraph("To:", fntTableFontHdr))
                Dim header1 As New Paragraph("Daily Faculty Attendance Report", fntTableFontHdr)
                header1.Alignment = 1
                Dim header2 As New Paragraph(absDate.ToLongDateString, fntTableFontHdr)
                header2.Alignment = 1
                Dim header3 As New Paragraph("TERM " & termAY(0) & ", SY " & termAY(1) & " - " & termAY(2), fntTableFontHdr)
                header3.Alignment = 1
                pdfDoc.Add(header1)
                pdfDoc.Add(header2)
                pdfDoc.Add(header3)
                pdfDoc.Add(New Paragraph(""))

                Dim table As New PdfPTable(6)
                table.SpacingBefore = 10
                table.SpacingAfter = 10
                table.HorizontalAlignment = 1
                table.DefaultCell.Padding = 3
                table.WidthPercentage = 100
                table.HorizontalAlignment = Element.ALIGN_LEFT
                table.DefaultCell.BorderWidth = 1
                Dim sglTblHdWidths(5) As Single
                sglTblHdWidths(0) = 200
                sglTblHdWidths(1) = 90
                sglTblHdWidths(2) = 75
                sglTblHdWidths(3) = 85
                sglTblHdWidths(4) = 100
                sglTblHdWidths(5) = 190
                table.SetWidths(sglTblHdWidths)
                table.AddCell(New Phrase("", fntTableFontHdr))
                table.AddCell(New Phrase("Course", fntTableFontHdr))
                table.AddCell(New Phrase("Section", fntTableFontHdr))
                table.AddCell(New Phrase("Room", fntTableFontHdr))
                table.AddCell(New Phrase("Time", fntTableFontHdr))
                table.AddCell(New Phrase("Remarks", fntTableFontHdr))

                While ctrLines <= 30 And ctr < reportColumns.Count - 1
                    If Not (reportColumns(ctr).Equals(collegeGroup)) Then
                        table.AddCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        ctrLines += 1
                        collegeGroup = reportColumns(ctr)
                        ctr += 1
                    End If
                    If Not (reportColumns(ctr).Equals(deptGroup)) Then
                        table.AddCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        table.AddCell(New Phrase(""))
                        ctrLines += 1
                        deptGroup = reportColumns(ctr)
                        ctr += 1
                    End If
                    table.AddCell(New Phrase(reportColumns(ctr), fntTableFont))
                    table.AddCell(New Phrase(reportColumns(ctr + 1), fntTableFont))
                    table.AddCell(New Phrase(reportColumns(ctr + 2), fntTableFont))
                    table.AddCell(New Phrase(reportColumns(ctr + 3), fntTableFont))
                    table.AddCell(New Phrase(reportColumns(ctr + 4) & "-" & reportColumns(ctr + 5), fntTableFont))
                    table.AddCell(New Phrase(reportColumns(ctr + 6), fntTableFont))
                    ctr += 7
                    ctrLines += 1

                End While
                pdfDoc.Add(table)
                ctrLines = 0
                pageNo += 1
                If ctr < reportColumns.Count - 1 Then
                    pdfDoc.NewPage()
                End If
            End While
            pdfDoc.Close()
            MsgBox("Successfully generated report!", MsgBoxStyle.OkOnly, "")
            Return filePath
        Catch ex As Exception

        End Try

        Return Nothing
    End Function

End Class
