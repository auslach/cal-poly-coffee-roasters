Imports CalPolyPomonaCoffeeHouseDB
Imports System.Data.SqlServerCe

Public Class Controller

    'Private OrderCollection As New Collection
    Private menu As New Menu

    ' Validations
    Public Function isInteger(ByVal input As String, ByVal title As String) As Boolean
        Try
            Dim numValue As Integer = Convert.ToInt32(input)
            Console.WriteLine(numValue)
            If numValue > 0 Then
                Return True
            Else
                MessageBox.Show(title & " must be an integer and greater than 0.", title)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(title & " must be an integer and greater than 0.", title)
            Return False
        End Try
    End Function

    Public Function isPresent(ByVal input As String, ByVal title As String) As Boolean

        If input <> "" Then
            Return True
        Else
            MessageBox.Show(title & " must not be blank.", title)
            Return False
        End If

    End Function

    Public Function addOrder(ByVal myOrder As Order, Optional replace As Boolean = False) As String
        Dim msg As String = ""

        If myOrder IsNot Nothing Then
            If isValidOrder(myOrder, msg) Then
                ' order is valid, add it to db
                DBController.open()
                DBController.addOrder(myOrder.ID, myOrder.server, myOrder.orderDate)
                DBController.close()

                ' add each order detail to db
                Dim line As OrderDetail
                For lineNo As Integer = 0 To myOrder.countItems - 1
                    line = myOrder.getLine(lineNo)
                    DBController.open()
                    With line
                        DBController.addDetail(myOrder.ID, .name, .qty, .price, lineNo + 1)
                    End With
                    DBController.close()
                Next
            Else
                If replace = True Then
                    ' if replace true, delete old order and add new one
                    DBController.open()
                    delete(myOrder.ID)
                    addOrder(myOrder)
                    DBController.close()
                End If
            End If
        End If


        Return msg
    End Function

    Public Sub delete(id As String)
        DBController.open()
        DBController.deleteOrder(id)
        DBController.close()
    End Sub

    Public Sub removeOrder(ByVal myOrder As Order)
        If myOrder IsNot Nothing Then
            delete(myOrder.ID)
        End If

    End Sub

    Public Function getMenu() As Menu
        Return menu
    End Function

    Public Function getOrder(ByVal id As String) As Order
        DBController.open()

        Dim order As New Order()
        Dim reader As SqlCeDataReader = DBController.getOrder(id)

        Dim hasMoreRows As Boolean = reader.Read()
        If hasMoreRows Then
            order.ID = reader("id")
            order.server = reader("server")
            order.orderDate = reader("datetime")
        End If

        While hasMoreRows
            Dim line As New OrderDetail
            line.name = reader("name")
            line.qty = reader("quantity")
            line.price = reader("price")
            order.addLine(line)
            Console.WriteLine("name: " & reader("name"))
            Console.WriteLine("quantity: " & reader("quantity"))
            Console.WriteLine("price: " & reader("price"))
            hasMoreRows = reader.Read()
        End While

        DBController.close()
        Return order
    End Function

    Public Function getAllOrders() As Collection
        DBController.open()

        Dim OrderCollection As New Collection
        Dim id_list As ArrayList = DBController.getAllOrders

        For Each line As Integer In id_list
            OrderCollection.Add(getOrder(line))
        Next

        DBController.close()
        Return OrderCollection
    End Function

    ' check for unique or duplicate order
    Private Function isValidOrder(myOrder As Order, ByRef msg As String) As Boolean
        Dim result As Boolean = False
        DBController.open()
        If Not DBController.isPresent(myOrder.ID) Then
            result = True
        Else
            msg += "Duplicate order found. Replace?"
        End If
        DBController.close()
        Return result
    End Function

    ' validation for existence of order
    Public Function orderExists(ByVal myOrderID As String, ByVal title As String) As Boolean
        Dim result As Boolean = False
        DBController.open()

        If DBController.isPresent(myOrderID) Then
            result = True
        Else
            MessageBox.Show(title & " must be an order that exists.", title)
        End If

        DBController.close()
        Return result
    End Function

End Class
