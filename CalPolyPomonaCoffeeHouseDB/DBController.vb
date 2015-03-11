Imports System.Data.SqlServerCe

Public Class DBController
    Private Shared cn As SqlCeConnection
    Private Shared cnString As String =
        "Data source = '..\..\..\CalPolyCoffeeHouseDb\Orders.sdf'"

    Private Shared command As SqlCeCommand
    Private Shared insertCommand As SqlCeCommand
    Private Shared deleteCommand As SqlCeCommand

    Public Shared Sub open()
        cn = New SqlCeConnection()
        cn.ConnectionString = cnString
        cn.Open()
    End Sub

    Public Shared Sub close()
        cn.Close()
    End Sub

    Public Shared Sub addOrder(id As String, server As String, datetime As String)
        Dim sql As String
        sql = "Insert into Orders values ('" & id & "','" & server & "','" & datetime & "')"
        insertCommand = New SqlCeCommand(sql, cn)
        insertCommand.ExecuteNonQuery()
    End Sub

    Public Shared Sub addDetail(id As String, name As String, qty As Double, price As Double, lineNo As Integer)
        Dim sql As String
        sql = ""
        sql += "Insert into OrderDetails values ('"
        sql += id & "','"
        sql += qty & "','"
        sql += price & "','"
        sql += lineNo & ")"

        insertCommand = New SqlCeCommand(sql, cn)
        insertCommand.ExecuteNonQuery()
    End Sub

    Public Shared Sub deleteOrder(id As String)
        Dim sql As String
        sql = ""
        sql += "Delete from Details where order_id = '" & id & "'"
        deleteCommand = New SqlCeCommand(sql, cn)
        deleteCommand.ExecuteNonQuery()

        sql = ""
        sql += "Delete from Orders where id = '" & id & "'"
        deleteCommand = New SqlCeCommand(sql, cn)
        deleteCommand.ExecuteNonQuery()
    End Sub

    'Public Shared Function getOrder(id As String) As SqlCeDataReader
    'End Function

    Public Shared Function isPresent(id As String) As Boolean
        Dim exists As Boolean = False
        Dim sql As String
        sql = "Select count(*) from Orders where ID = '" & id & "'"
        command = New SqlCeCommand(sql, cn)
        If command.ExecuteScalar() > 0 Then
            exists = True
        End If
        Return exists
    End Function

End Class
