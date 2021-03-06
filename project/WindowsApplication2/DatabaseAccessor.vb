﻿Imports MySql.Data.MySqlClient
Public Class databaseAccessor
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    'insert into "TABLENAME" ((COLUMNS)) values ((VALUES))
    Public Sub Add_Data(query As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            ' MsgBox("Successfully Added!", MsgBoxStyle.OkOnly, "")

            MysqlConn.Close()
        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    'delete from "TABLENAME" where (CONDITION)
    Public Sub Delete_Data(query As String)
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
    Public Sub Update_Data(query As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost; Database = introse; Uid=root; Pwd=p@ssword;"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Reader = Command.ExecuteReader
            MsgBox("Successfully Updated!", MsgBoxStyle.OkOnly, "")

            MysqlConn.Close()

        Catch ex As MySqlException
            MsgBox("Error!", MsgBoxStyle.Critical, "")
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Function Get_Data(query As String, column As String) As Object
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

    Public Sub Fill_Data_Grid(query As String, dbGrid As DataGridView) 'Insert In form_load Sub
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
    Public Function Get_Multiple_Row_Data(query As String) As List(Of Object)
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
                    Temp.Add(Reader(0))
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

    Public Function Get_Multiple_Column_Data(query As String, colNum As Integer) As List(Of Object)
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
                    For ctr As Integer = 0 To colNum - 1
                        Temp.Add(Reader(ctr))
                    Next
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

