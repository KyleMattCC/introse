Imports MySql.Data.MySqlClient
Public Class databaseAccessor
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    'insert into "TABLENAME" ((COLUMNS)) values ((VALUES))
    Public Sub addData(query As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            MsgBox("Successfully Added!", MsgBoxStyle.OkOnly, "")

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'delete from "TABLENAME" where (CONDITION)
    Public Sub deleteData(query As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            MsgBox("Successfully Deleted!", MsgBoxStyle.OkOnly, "")

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    'update "TABLENAME" set (COLUMNS = VALUES) where (CONDITION)
    Public Sub updateData(query As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'Select Case Case_ from _ where _
    'Public Function getData(query As String, column As String) As String
    '   MysqlConn = New MySqlConnection
    '  MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
    'Dim Reader As MySqlDataReader
    'Dim Temp As String
    '   Temp = Nothing
    '
    'Try
    '      MysqlConn.Open()
    '       Command = New MySqlCommand(query, MysqlConn)
    '      Reader = Command.ExecuteReader
    'If Reader.Read() Then
    '           Temp = Reader(column).ToString
    'End If

    '       MysqlConn.Close()
    'Catch ex As MySqlException
    '       MsgBox("Error!", MsgBoxStyle.Critical, "")
    'Finally
    '       MysqlConn.Dispose()
    'End Try
    'Return Temp

    'End Function

    Public Function getData(query As String, column As String) As Object
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader
        Dim Temp As Object
        Temp = Nothing

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            If Reader.Read() Then
                Temp = Reader(column)
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try
        Return Temp

    End Function

    Public Sub fillDataGrid(query As String, dbGrid As DataGridView) 'Insert In form_load Sub
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dbGrid.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error! " & Err.Description, MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Function getMultipleData(query As String, column As String) As List(Of Object)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database=introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader
        Dim Temp As New List(Of Object)

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            While Reader.Read
                If Reader.HasRows = True Then
                    Temp.Add(Reader(column))
                End If
            End While

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

        Return Temp

    End Function
    Public Function getRowData(query As String, column1 As String, column2 As String, column3 As String, column4 As String, column5 As String, column6 As String, column7 As String, column8 As String, column9 As String, column10 As String, column11 As String) As List(Of Object)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database=introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader
        Dim Temp As New List(Of Object)

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            While Reader.Read
                If Reader.HasRows = True Then
                    Temp.Add(Reader(column1))
                    Temp.Add(Reader(column2))
                    Temp.Add(Reader(column3))
                    Temp.Add(Reader(column4))
                    Temp.Add(Reader(column5))
                    Temp.Add(Reader(column6))
                    Temp.Add(Reader(column7))
                    Temp.Add(Reader(column8))
                    Temp.Add(Reader(column9))
                    Temp.Add(Reader(column10))
                    Temp.Add(Reader(column11))
                End If
            End While

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

        Return Temp

    End Function
End Class
