Imports CalPolyPomonaCoffeeHouseDB
Imports System.Data.SqlServerCe

Public Class Controller

    Private OrderCollection As New Collection
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
        'Dim msg As String = ""
        'If myOrder IsNot Nothing Then
        '    If isValidOrder(myOrder, msg) Then
        '        OrderCollection.Add(myOrder, myOrder.ID)
        '    Else
        '        If replace = True Then
        '            OrderCollection.Remove(myOrder.ID)
        '            OrderCollection.Add(myOrder, myOrder.ID)
        '        End If
        '    End If
        'End If
        'Return msg
        Dim msg As String = ""
        DBController.Open()
        If myOrder IsNot Nothing Then
            If isValidOrder(myOrder, msg) Then
                'OrderCollection.Add(myOrder, myOrder.ID)
                ' order is valid, add it to db
                DBController.addOrder(myOrder.ID, myOrder.server, myOrder.orderDate)

                Dim line As OrderDetail
                For lineNo As Integer = 0 To myOrder.countItems - 1
                    line = myOrder.getLine(lineNo)
                    With line
                        DBController.addDetail(myOrder.ID, .name, .qty, .price, lineNo + 1)
                    End With
                Next
            Else
                If replace = True Then
                    'OrderCollection.Remove(myOrder.ID)
                    'OrderCollection.Add(myOrder, myOrder.ID)
                    delete(myOrder.ID)
                    addOrder(myOrder)
                End If
            End If
        End If

        DBController.close()
        Return msg
    End Function

    Public Sub delete(id As String)
        DBController.open()
        DBController.deleteOrder(id)
        DBController.close()
    End Sub

    Public Sub removeOrder(ByVal myOrder As Order)
        If myOrder IsNot Nothing Then
            OrderCollection.Remove(myOrder.ID)
        End If
    End Sub

    Public Function getMenu() As Menu
        Return menu
    End Function

    Public Function getOrder(ByVal id As String) As Order
        'Return OrderCollection.Item(ID)
    End Function

    Public Function getAllOrders() As Collection
        Return OrderCollection
    End Function

    ' check for unique or duplicate order
    Private Function isValidOrder(myOrder As Order, ByRef msg As String) As Boolean
        Dim result As Boolean = False

        If Not DBController.isPresent(myOrder.ID) Then
            result = True
        Else
            msg += "Duplicate order found. Replace?"
        End If
        Return result
    End Function

    ' validation for existence of order
    Public Function orderExists(ByVal myOrderID As String, ByVal title As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim myOrder As Order
            myOrder = getOrder(myOrderID)
            If OrderCollection.Contains(myOrder.ID) Then
                result = True
            End If
        Catch ex As Exception
            MessageBox.Show(title & " must be an order that exists.", title)
            result = False
        End Try

        Return result

    End Function

End Class
