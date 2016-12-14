Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
Public Class reportGenerator
    Dim dbAccess As New databaseAccessor

    Public Function Generate_Faculty_Daily_Notice(idnumber As String, name As String, encdate As Date) As Boolean
        Try
            If Not Directory.Exists("C:\Fams Reports") Then
                Directory.CreateDirectory("C:\Fams Reports")

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Try
            Dim fileName As String = "C:\Fams Reports\" & encdate.ToString("MM-dd-yyyy") & " " & name & ".pdf"

            Dim pdfDoc As New Document(PageSize.A4, 20.0F, 20.0F, 20.0F, 20.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()
            Dim header As New Paragraph("Daily Faculty Attendance Report", fntTableFontHdr)
            header.Alignment = 1
            pdfDoc.Add(header)
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("For: ", fntTableFont))
            pdfDoc.Add(New Phrase(name, fntTableFontHdr))
            pdfDoc.Add(New Paragraph("Subject: ", fntTableFont))
            pdfDoc.Add(New Phrase("NOTICE OF ABSENCE", fntTableFontHdr))
            pdfDoc.Add(New Paragraph("Date: ", fntTableFont))
            pdfDoc.Add(New Phrase(Date.Now.ToLongDateString, fntTableFontHdr))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Please be informed that you have been marked with ABSENCE in the Faculty Attendance Report for the following class(es).", fntTableFont))

            Dim table As New PdfPTable(7)
            table.SpacingBefore = 10
            table.SpacingAfter = 10
            table.HorizontalAlignment = 1
            table.DefaultCell.Padding = 3
            table.WidthPercentage = 400.0F
            table.HorizontalAlignment = Element.ALIGN_LEFT
            table.DefaultCell.BorderWidth = 1
            Dim sglTblHdWidths(6) As Single
            sglTblHdWidths(0) = 130.0F
            sglTblHdWidths(1) = 100.0F
            sglTblHdWidths(2) = 75.0F
            sglTblHdWidths(3) = 100.0F
            sglTblHdWidths(4) = 85.0F
            sglTblHdWidths(5) = 190.0F
            sglTblHdWidths(6) = 100.0F
            table.SetWidths(sglTblHdWidths)
            table.AddCell(New Phrase("Absent Date", fntTableFontHdr))
            table.AddCell(New Phrase("Course", fntTableFontHdr))
            table.AddCell(New Phrase("Section", fntTableFontHdr))
            table.AddCell(New Phrase("Time", fntTableFontHdr))
            table.AddCell(New Phrase("Room", fntTableFontHdr))
            table.AddCell(New Phrase("Remarks", fntTableFontHdr))
            table.AddCell(New Phrase("Checker", fntTableFontHdr))

            Dim reportColumns As New List(Of Object)

            Try
                reportColumns = dbAccess.Get_Multiple_Column_Data("select a.attendanceid, a.absent_date, c.course_cd, co.section, co.timestart, co.timeend, co.room, r.remark_des, a.checker
                                            from introse.course c, introse.courseoffering co, introse.attendance a, introse.faculty f, introse.remarks r
                                            where f.facultyid = '" & idnumber & "' and f.status = 'A' and co.facref_no = f.facref_no and co.course_id = c.course_id and co.status = 'A' and a.courseoffering_id = co.courseoffering_id 
                                            and a.enc_date = '" & encdate.ToString("yyyy-MM-dd") & "' And a.remarks_cd = r.remark_cd And a.status = 'A';", 9)
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            For ctr = 0 To reportColumns.Count - 1 Step 9
                table.AddCell(New Phrase(reportColumns.Item(ctr + 1), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 2), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 3), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 4) & "-" & reportColumns.Item(ctr + 5), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 6), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 7), fntTableFont))
                table.AddCell(New Phrase(reportColumns.Item(ctr + 8), fntTableFont))
            Next

            pdfDoc.Add(table)

            pdfDoc.Add(New Paragraph("If correct, no reply is necessary."))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("If incorrect, please rectify this report by filling up the online feedback form."))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Thank you."))
            pdfDoc.Close()

            For ctr = 0 To reportColumns.Count - 9 Step 9
                Try
                    dbAccess.Update_Data("update introse.attendance set report_status = 'Generated' where attendanceid = '" & reportColumns(ctr) & "';")
                Catch ex As Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Next
            wdwReportGen.Load_Form(fileName, 1, idnumber, Date.Now)

            Return True

        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")

        End Try
        Return False
    End Function

    Public Function Generate_Registrar_Daily_Report(offeredType As Integer, encDate As Date) As Boolean
        Try
            If Not Directory.Exists("C:\Fams Reports") Then
                Directory.CreateDirectory("C:\Fams Reports")

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Try
            Dim fileName As String = "C:\Fams Reports\" & encDate.ToString("MM-dd-yyyy") & " Daily-Report.pdf"
            Dim pageNo As Integer = 1
            Dim pdfDoc As New Document(PageSize.A4, 20.0F, 20.0F, 20.0F, 20.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))
            Dim collegeGroup As String = Nothing
            Dim deptGroup As String = Nothing

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()

            Dim reportColumns As New List(Of Object)()
            Dim termAY As New List(Of Object)()
            Dim query As String
            Dim header As String
            If (offeredType = 1) Then
                query = "Select col.college_name, dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code and c.offered_to = 'U'
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Undergraduate)"

            ElseIf offeredType = 2 Then
                query = "select col.college_name, dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code and c.offered_to = 'G'
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Graduate)"

            Else
                query = "select col.college_name, dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Undergraduate and Graduate)"

            End If
            Try
                reportColumns = dbAccess.Get_Multiple_Column_Data(query, 9)
                termAY = dbAccess.Get_Multiple_Column_Data("select t.term_no, a.yearstart, a.yearend
                                                        from introse.term t, introse.academicyear a
                                                        where t.status = 'A' and a.status = 'A';", 3)
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            If reportColumns.Count = 0 Then
                MsgBox("No existing record to be generated!", MsgBoxStyle.OkOnly, "")
                Return False
            Else
                Dim ctrLines As Integer = 0
                Dim ctr As Integer = 0
                While ctr < reportColumns.Count - 1
                    Dim pageHeader As New Paragraph("Page " & pageNo, fntTableFontHdr)
                    pageHeader.Alignment = 2
                    pdfDoc.Add(pageHeader)
                    pdfDoc.Add(New Paragraph(""))
                    pdfDoc.Add(New Paragraph("To:", fntTableFontHdr))
                    pdfDoc.Add(New Paragraph(" "))
                    Dim header1 As New Paragraph(header, fntTableFontHdr)
                    header1.Alignment = 1
                    Dim header2 As New Paragraph(encDate.ToLongDateString, fntTableFontHdr)
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
                    table.WidthPercentage = 400.0F
                    table.HorizontalAlignment = Element.ALIGN_LEFT
                    table.DefaultCell.BorderWidth = 1
                    Dim sglTblHdWidths(5) As Single
                    sglTblHdWidths(0) = 200.0F
                    sglTblHdWidths(1) = 90.0F
                    sglTblHdWidths(2) = 75.0F
                    sglTblHdWidths(3) = 85.0F
                    sglTblHdWidths(4) = 100.0F
                    sglTblHdWidths(5) = 190.0F
                    table.SetWidths(sglTblHdWidths)
                    table.AddCell(New Phrase("", fntTableFontHdr))
                    table.AddCell(New Phrase("Course", fntTableFontHdr))
                    table.AddCell(New Phrase("Section", fntTableFontHdr))
                    table.AddCell(New Phrase("Room", fntTableFontHdr))
                    table.AddCell(New Phrase("Time", fntTableFontHdr))
                    table.AddCell(New Phrase("Remarks", fntTableFontHdr))

                    While ctrLines <= 30 And ctr < reportColumns.Count - 1
                        If Not (reportColumns(ctr).Equals(collegeGroup)) Then
                            Dim colCell As New PdfPCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                            colCell.Colspan = 6
                            colCell.HorizontalAlignment = 1
                            table.AddCell(colCell)
                            ctrLines += 1
                            collegeGroup = reportColumns(ctr)
                        End If
                        ctr += 1
                        If Not (reportColumns(ctr).Equals(deptGroup)) Then
                            Dim depCell As New PdfPCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                            depCell.Colspan = 6
                            depCell.HorizontalAlignment = 0
                            table.AddCell(depCell)
                            ctrLines += 1
                            deptGroup = reportColumns(ctr)
                        End If
                        ctr += 1
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
                        collegeGroup = Nothing
                        deptGroup = Nothing
                    End If
                End While
                pdfDoc.Close()
                wdwReportGen.Load_Form(fileName, 2, "Registrar", Date.Now)
                Return True
            End If

        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")
        End Try
        Return False
    End Function

    Public Function Generate_College_Daily_Report(college As String, offeredType As Integer, encDate As Date) As Boolean
        Try
            If Not Directory.Exists("C:\Fams Reports") Then
                Directory.CreateDirectory("C:\Fams Reports")

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Try
            Dim collegeGroup As String = college
            Dim fileName As String = "C:\Fams Reports\" & encDate.ToString("MM-dd-yyyy") & " " & collegeGroup & " College-Daily-Report.pdf"
            Dim pageNo As Integer = 1
            Dim pdfDoc As New Document(PageSize.A4, 20.0F, 20.0F, 20.0F, 20.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))
            Dim deptGroup As String = Nothing

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()

            Dim reportColumns As New List(Of Object)()
            Dim termAY As New List(Of Object)()
            Dim query As String
            Dim header As String
            If (offeredType = 1) Then
                query = "Select dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code and col.college_name = '" & collegeGroup & "' and c.offered_to = 'U'
                         order by 1, 2, 3;"
                header = "Daily Faculty Attendance Report (Undergraduate)"

            ElseIf offeredType = 2 Then
                query = "Select dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code and col.college_name = '" & collegeGroup & "' and c.offered_to = 'G'
                         order by 1, 2, 3;"
                header = "Daily Faculty Attendance Report (Graduate)"

            Else
                query = "select dep.departmentname, concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.college col, introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and f.departmentid = dep.departmentid and dep.college_code = col.college_code and col.college_name = '" & collegeGroup & "'
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Undergraduate and Graduate)"

            End If

            Try
                reportColumns = dbAccess.Get_Multiple_Column_Data(query, 8)
                termAY = dbAccess.Get_Multiple_Column_Data("select t.term_no, a.yearstart, a.yearend
                                                        from introse.term t, introse.academicyear a
                                                        where t.status = 'A' and a.status = 'A';", 3)
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            If reportColumns.Count = 0 Then
                MsgBox("No existing record to be generated!", MsgBoxStyle.OkOnly, "")
                Return False
            Else
                Dim ctrLines As Integer = 0
                Dim ctr As Integer = 0
                While ctr < reportColumns.Count - 1
                    Dim pageHeader As New Paragraph("Page " & pageNo, fntTableFontHdr)
                    pageHeader.Alignment = 2
                    pdfDoc.Add(pageHeader)
                    pdfDoc.Add(New Paragraph(""))
                    pdfDoc.Add(New Paragraph("To: Dean of " & collegeGroup, fntTableFontHdr))
                    pdfDoc.Add(New Paragraph(" "))
                    Dim header1 As New Paragraph(header, fntTableFontHdr)
                    header1.Alignment = 1
                    Dim header2 As New Paragraph(encDate.ToLongDateString, fntTableFontHdr)
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
                    table.WidthPercentage = 400.0F
                    table.HorizontalAlignment = Element.ALIGN_LEFT
                    table.DefaultCell.BorderWidth = 1
                    Dim sglTblHdWidths(5) As Single
                    sglTblHdWidths(0) = 200.0F
                    sglTblHdWidths(1) = 90.0F
                    sglTblHdWidths(2) = 75.0F
                    sglTblHdWidths(3) = 85.0F
                    sglTblHdWidths(4) = 100.0F
                    sglTblHdWidths(5) = 190.0F
                    table.SetWidths(sglTblHdWidths)
                    table.AddCell(New Phrase("", fntTableFontHdr))
                    table.AddCell(New Phrase("Course", fntTableFontHdr))
                    table.AddCell(New Phrase("Section", fntTableFontHdr))
                    table.AddCell(New Phrase("Room", fntTableFontHdr))
                    table.AddCell(New Phrase("Time", fntTableFontHdr))
                    table.AddCell(New Phrase("Remarks", fntTableFontHdr))

                    Dim colCell As New PdfPCell(New Phrase(collegeGroup, fntTableFontHdr))
                    colCell.Colspan = 6
                    colCell.HorizontalAlignment = 1
                    table.AddCell(colCell)
                    ctrLines += 1

                    While ctrLines <= 30 And ctr < reportColumns.Count - 1
                        If Not (reportColumns(ctr).Equals(deptGroup)) Then
                            Dim depCell As New PdfPCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                            depCell.Colspan = 6
                            depCell.HorizontalAlignment = 0
                            table.AddCell(depCell)
                            ctrLines += 1
                            deptGroup = reportColumns(ctr)
                        End If
                        ctr += 1
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
                        deptGroup = Nothing
                    End If
                End While
                pdfDoc.Close()
                wdwReportGen.Load_Form(fileName, 3, collegeGroup, Date.Now)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")
        End Try
        Return False
    End Function

    Public Function Generate_Chair_Daily_Report(department As String, offeredType As Integer, encDate As Date) As Boolean
        Try
            If Not Directory.Exists("C:\Fams Reports") Then
                Directory.CreateDirectory("C:\Fams Reports")

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Try
            Dim deptGroup As String = department
            Dim collegeGroup As String = Nothing
            Try
                collegeGroup = dbAccess.Get_Data("select c.college_name from introse.college c, introse.department d where d.departmentname = '" & deptGroup & "' and d.college_code = c.college_code;", "college_name")
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Dim fileName As String = "C:\Fams Reports\" & encDate.ToString("MM-dd-yyyy") & " " & deptGroup & " Department-Daily-Report.pdf"
            Dim pageNo As Integer = 1
            Dim pdfDoc As New Document(PageSize.A4, 20.0F, 20.0F, 20.0F, 20.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()

            Dim reportColumns As New List(Of Object)()
            Dim termAY As New List(Of Object)()
            Dim query As String
            Dim header As String

            If (offeredType = 1) Then
                query = "Select concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and dep.departmentname = '" & deptGroup & "' and f.departmentid = dep.departmentid and c.offered_to = 'U'
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Undergraduate)"

            ElseIf offeredType = 2 Then
                query = "Select concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and dep.departmentname = '" & deptGroup & "' and f.departmentid = dep.departmentid and c.offered_to = 'G'
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Graduate)"

            Else
                query = "select concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename), c.course_cd, co.section, co.room, co.timestart, co.timeend, r.remark_des
                         from introse.department dep, introse.faculty f, introse.course c, introse.courseoffering co, introse.remarks r, introse.attendance a
                         where co.status = 'A' and f.status = 'A' and a.status = 'A' and a.enc_date = '" & encDate.ToString("yyyy-MM-dd") & "' and a.courseoffering_id = co.courseoffering_id
                         and a.remarks_cd = r.remark_cd and co.facref_no = f.facref_no and co.course_id = c.course_id and dep.departmentname = '" & deptGroup & "' and f.departmentid = dep.departmentid
                         order by 1, 2, 3, c.offered_to;"
                header = "Daily Faculty Attendance Report (Undergraduate and Graduate)"

            End If

            Try
                reportColumns = dbAccess.Get_Multiple_Column_Data(query, 7)
                termAY = dbAccess.Get_Multiple_Column_Data("select t.term_no, a.yearstart, a.yearend
                                                       from introse.term t, introse.academicyear a
                                                       where t.status = 'A' and a.status = 'A';", 3)
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            If reportColumns.Count = 0 Then
                MsgBox("No existing record to be generated!", MsgBoxStyle.OkOnly, "")
                Return False
            Else
                Dim ctrLines As Integer = 0
                Dim ctr As Integer = 0
                While ctr < reportColumns.Count - 1
                    Dim pageHeader As New Paragraph("Page " & pageNo, fntTableFontHdr)
                    pageHeader.Alignment = 2
                    pdfDoc.Add(pageHeader)
                    pdfDoc.Add(New Paragraph(""))
                    pdfDoc.Add(New Paragraph("To: Department Chair of " & deptGroup, fntTableFontHdr))
                    pdfDoc.Add(New Paragraph(" "))
                    Dim header1 As New Paragraph(header, fntTableFontHdr)
                    header1.Alignment = 1
                    Dim header2 As New Paragraph(encDate.ToLongDateString, fntTableFontHdr)
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
                    table.WidthPercentage = 400.0F
                    table.HorizontalAlignment = Element.ALIGN_LEFT
                    table.DefaultCell.BorderWidth = 1
                    Dim sglTblHdWidths(5) As Single
                    sglTblHdWidths(0) = 200.0F
                    sglTblHdWidths(1) = 90.0F
                    sglTblHdWidths(2) = 75.0F
                    sglTblHdWidths(3) = 85.0F
                    sglTblHdWidths(4) = 100.0F
                    sglTblHdWidths(5) = 190.0F
                    table.SetWidths(sglTblHdWidths)
                    table.AddCell(New Phrase("", fntTableFontHdr))
                    table.AddCell(New Phrase("Course", fntTableFontHdr))
                    table.AddCell(New Phrase("Section", fntTableFontHdr))
                    table.AddCell(New Phrase("Room", fntTableFontHdr))
                    table.AddCell(New Phrase("Time", fntTableFontHdr))
                    table.AddCell(New Phrase("Remarks", fntTableFontHdr))

                    Dim colCell As New PdfPCell(New Phrase(collegeGroup, fntTableFontHdr))
                    colCell.Colspan = 6
                    colCell.HorizontalAlignment = 1
                    table.AddCell(colCell)
                    ctrLines += 1

                    Dim depCell As New PdfPCell(New Phrase(reportColumns(ctr), fntTableFontHdr))
                    depCell.Colspan = 6
                    depCell.HorizontalAlignment = 0
                    table.AddCell(depCell)
                    ctrLines += 1

                    While ctrLines <= 30 And ctr < reportColumns.Count - 1

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
                wdwReportGen.Load_Form(fileName, 4, deptGroup, Date.Now)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")

        End Try

        Return False

    End Function

    Public Function Generete_Monthly_Report(termId As Integer, month As Integer, offeredType As Integer) As Boolean
        Try
            If Not Directory.Exists("C:\Fams Reports") Then
                Directory.CreateDirectory("C:\Fams Reports")

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Try
            Dim collegeGroup As String = Nothing
            Dim deptGroup As String = Nothing
            Dim currentFaculty As String = Nothing
            Dim colleges As New List(Of Object)()
            Dim departments As New List(Of Object)()
            Dim remarks As New List(Of Object)()
            Dim reasons As New List(Of Object)()
            Dim termAY As New List(Of Object)()
            Dim absentResults As New List(Of Object)()
            Dim makeupResults As New List(Of Object)()
            Dim load As Double
            Dim absHours As Integer
            Dim lateNum As Integer
            Dim edNum As Integer
            Dim vrNum As Integer
            Dim absCtr As Integer
            Dim makeupCtr As Integer
            Dim ctrLines As Integer

            Dim fileName As String = "C:\Fams Reports\" & Date.Now.ToString("MM-dd-yyyy") & "Monthly-Report.pdf"
            Dim pageNo As Integer = 1
            Dim pdfDoc As New Document(itextsharp.text.PageSize.A4.Rotate(), 20.0F, 20.0F, 20.0F, 20.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))

            Dim fntTableFontHdr As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.BOLD, BaseColor.BLACK)
            Dim fntTableFont As itextsharp.text.Font = FontFactory.GetFont("Times New Roman", 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)

            pdfDoc.Open()

            Dim header As String

            If (offeredType = 1) Then
                header = "FACULTY ATTENDANCE REPORT (Undergraduate)"

            ElseIf offeredType = 2 Then
                header = "FACULTY ATTENDANCE REPORT (Graduate)"

            Else
                header = "FACULTY ATTENDANCE REPORT (Undergraduate and Graduate)"

            End If

            Try
                termAY = dbAccess.Get_Multiple_Column_Data("select t.term_no, a.yearstart, a.yearend
                                                       from introse.term t, introse.academicyear a
                                                       where t.termid = " & termId & " and t.yearid = a.yearid;", 3)
                remarks = dbAccess.Get_Multiple_Column_Data("select * from introse.remarks", 2)
                reasons = dbAccess.Get_Multiple_Column_Data("select * from introse.reasons", 2)
                colleges = dbAccess.Get_Multiple_Column_Data("select * from introse.college", 2)
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            For collegeCtr As Integer = 0 To colleges.Count - 1 Step 2
                departments = dbAccess.Get_Multiple_Column_Data("select departmentid, departmentname from introse.department where college_code = '" & colleges(collegeCtr) & "';", 2)

                For depCtr As Integer = 0 To departments.Count - 1 Step 2
                    If offeredType = 1 Then
                        absentResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.remark_des, SUM(co.hours)
                                                                       from introse.faculty f, introse.remarks r, introse.courseoffering co, introse.course c, introse.attendance a
                                                                       where (a.status = 'R' or a.status = 'A') and co.termid = " & termId & " and f.departmentid = " & departments(depCtr) & " and co.facref_no = f.facref_no
                                                                       and a.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and a.remarks_cd = r.remark_cd and MONTH(a.absent_date) = " & month & " and c.offered_to = 'U'
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)
                        makeupResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.reason_des, SUM(m.hours)
                                                                       from introse.faculty f, introse.makeup m, introse.reasons r, introse.courseoffering co, introse.course c
                                                                       where (m.status = 'R' or m.status = 'A') and co.termid = 1 and f.departmentid = 1001
                                                                       and co.facref_no = f.facref_no and m.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and m.reason_cd and r.reason_cd and MONTH(m.makeup_date) = " & month & " and c.offered_to = 'U'
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)

                    ElseIf offeredType = 2 Then
                        absentResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.remark_des, SUM(co.hours)
                                                                       from introse.faculty f, introse.remarks r, introse.courseoffering co, introse.course c, introse.attendance a
                                                                       where (a.status = 'R' or a.status = 'A') and co.termid = " & termId & " and f.departmentid = " & departments(depCtr) & " and co.facref_no = f.facref_no
                                                                       and a.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and a.remarks_cd = r.remark_cd and MONTH(a.absent_date) = " & month & " and c.offered_to = 'G'
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)
                        makeupResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.reason_des, SUM(m.hours)
                                                                       from introse.faculty f, introse.makeup m, introse.reasons r, introse.courseoffering co, introse.course c
                                                                       where (m.status = 'R' or m.status = 'A') and co.termid = 1 and f.departmentid = 1001
                                                                       and co.facref_no = f.facref_no and m.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and m.reason_cd and r.reason_cd and MONTH(m.makeup_date) = " & month & " and c.offered_to = 'G'
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)

                    Else
                        absentResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.remark_des, SUM(co.hours)
                                                                       from introse.faculty f, introse.remarks r, introse.courseoffering co, introse.course c, introse.attendance a
                                                                       where (a.status = 'R' or a.status = 'A') and co.termid = " & termId & " and f.departmentid = " & departments(depCtr) & " and co.facref_no = f.facref_no
                                                                       and a.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and a.remarks_cd = r.remark_cd and MONTH(a.absent_date) = " & month & "
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)
                        makeupResults = dbAccess.Get_Multiple_Column_Data("select CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename), r.reason_des, SUM(m.hours)
                                                                       from introse.faculty f, introse.makeup m, introse.reasons r, introse.courseoffering co, introse.course c
                                                                       where (m.status = 'R' or m.status = 'A') and co.termid = 1 and f.departmentid = 1001
                                                                       and co.facref_no = f.facref_no and m.courseoffering_id = co.courseoffering_id and c.course_id = co.course_id and m.reason_cd and r.reason_cd and MONTH(m.makeup_date) = " & month & "
                                                                       group by 1, 2
                                                                       order by 1, 2;", 3)

                    End If

                    absCtr = 0
                    makeupCtr = 0

                    While (absCtr < absentResults.Count - 1 Or makeupCtr < makeupResults.Count - 1)
                        Dim pageHeader As New Paragraph("Page " & pageNo, fntTableFontHdr)
                        pageHeader.Alignment = 2
                        pdfDoc.Add(pageHeader)
                        pdfDoc.Add(New Paragraph(" "))
                        Dim header1 As New Paragraph(header, fntTableFontHdr)
                        header1.Alignment = 1
                        Dim header2 As New Paragraph("TERM " & termAY(0) & ", SY " & termAY(1) & " - " & termAY(2), fntTableFontHdr)
                        header2.Alignment = 1
                        Dim header3 As New Paragraph("As of " & Date.Now.ToLongDateString, fntTableFontHdr)
                        header3.Alignment = 1
                        Dim header4 As New Paragraph(colleges(collegeCtr + 1), fntTableFontHdr)
                        header4.Alignment = 1
                        pdfDoc.Add(header1)
                        pdfDoc.Add(header2)
                        pdfDoc.Add(header3)
                        pdfDoc.Add(header4)
                        pdfDoc.Add(New Paragraph(""))

                        'Legend code

                        Dim colNum As Integer = 4 + remarks.Count / 2 + reasons.Count / 2
                        Dim table As New PdfPTable(colNum)
                        table.SpacingBefore = 10
                        table.SpacingAfter = 10
                        table.HorizontalAlignment = 1
                        table.DefaultCell.Padding = 3
                        table.WidthPercentage = 100.0F
                        table.HorizontalAlignment = Element.ALIGN_LEFT
                        table.DefaultCell.BorderWidth = 1
                        Dim sglTblHdWidths(colNum - 1) As Single
                        Dim colCnt As Integer
                        sglTblHdWidths(0) = 100.0F
                        sglTblHdWidths(1) = 40.0F
                        For colCnt = 2 To (remarks.Count / 2) - 2
                            sglTblHdWidths(colCnt) = 40.0F
                        Next

                        sglTblHdWidths(colCnt) = 45.0F

                        For colCnt = colCnt + 1 To reasons.Count / 2 + colCnt
                            sglTblHdWidths(colCnt) = 40.0F
                        Next

                        sglTblHdWidths(colCnt) = 45.0F
                        sglTblHdWidths(colCnt + 1) = 40.0F
                        sglTblHdWidths(colCnt + 2) = 40.0F
                        sglTblHdWidths(colCnt + 3) = 40.0F
                        table.SetWidths(sglTblHdWidths)

                        Dim cell As PdfPCell
                        cell = New PdfPCell(New Phrase("", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        cell.VerticalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        cell.VerticalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("ABSENCE (IN HOURS)", fntTableFontHdr))
                        cell.Colspan = remarks.Count / 2 - 2
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("MAKEUP (IN HOURS)", fntTableFontHdr))
                        cell.Colspan = reasons.Count / 2 + 1
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("IN FREQ.", fntTableFontHdr))
                        cell.Colspan = 3
                        cell.HorizontalAlignment = 1
                        cell.VerticalAlignment = 1
                        table.AddCell(cell)

                        cell = New PdfPCell(New Phrase("FACULTY NAME", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        cell.VerticalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("LOAD", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        cell.VerticalAlignment = 1
                        table.AddCell(cell)

                        For ctr = 0 To remarks.Count - 1 Step 2
                            If Not (remarks(ctr) = "LA" Or remarks(ctr) = "ED" Or remarks(ctr) = "VR") Then
                                cell = New PdfPCell(New Phrase(remarks(ctr), fntTableFontHdr))
                                cell.HorizontalAlignment = 1
                                table.AddCell(cell)
                            End If
                        Next
                        cell = New PdfPCell(New Phrase("TOTAL", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)

                        For ctr = 0 To reasons.Count - 1 Step 2
                            cell = New PdfPCell(New Phrase(reasons(ctr), fntTableFontHdr))
                            cell.HorizontalAlignment = 1
                            table.AddCell(cell)
                        Next
                        cell = New PdfPCell(New Phrase("TOTAL", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)

                        cell = New PdfPCell(New Phrase("LA", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("ED", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                        cell = New PdfPCell(New Phrase("VR", fntTableFontHdr))
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)

                        Dim depCell As New PdfPCell(New Phrase(departments(depCtr + 1), fntTableFontHdr))
                        depCell.Colspan = colNum
                        depCell.HorizontalAlignment = 0
                        table.AddCell(depCell)

                        Dim result As Integer = String.Compare(absentResults(absCtr), makeupResults(makeupCtr))
                        If (result = -1) Then
                            currentFaculty = makeupResults(makeupCtr)

                        Else
                            currentFaculty = absentResults(absCtr)

                        End If

                        ctrLines = 0
                        While ctrLines <= 30 And (absCtr < absentResults.Count - 1 Or makeupCtr < makeupResults.Count - 1)

                            absHours = 0
                            lateNum = 0
                            edNum = 0
                            vrNum = 0
                            load = dbAccess.Get_Data("select SUM(c.units)
                                                        from introse.course c, introse.courseoffering co, introse.faculty f
                                                        where CONCAT(f.f_lastname, ', ', f.f_firstname, ' ', f_middlename) = '" & currentFaculty & "' and co.facref_no = f.facref_no and co.termid = 1 and co.course_id = c.course_id;", "SUM(c.units)")

                            table.AddCell(New Phrase(currentFaculty))
                            table.AddCell(New Phrase(load.ToString))
                            lateNum = 0
                            edNum = 0
                            vrNum = 0
                            'Remarks 
                        End While

                    End While

                Next

            Next
        Catch ex As Exception
            MsgBox("Notice generation failed!", MsgBoxStyle.Critical, "")

        End Try

        Return False

    End Function

End Class
