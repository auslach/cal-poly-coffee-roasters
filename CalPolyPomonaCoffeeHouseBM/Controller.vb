Public Class Controller

    Private OrderCollection As New Collection
    Private menu As New Menu

    Public Function addOrder(ByVal myOrder As Order, Optional replace As Boolean = False) As String
        Dim msg As String = ""
        If isValidOrder(myOrder, msg) Then
            OrderCollection.Add(myOrder, myOrder.ID)
        Else
            If replace = True Then
                OrderCollection.Remove(myOrder.ID)
                OrderCollection.Add(myOrder, myOrder.ID)
            End If
        End If

        Return msg
    End Function

    Public Function getMenu() As Menu
        Return menu
    End Function

    Public Function getOrder(ByVal ID As String) As Order
        Return OrderCollection.Item(ID)
    End Function

    ' check for unique or duplicate order
    Private Function isValidOrder(myOrder As Order, ByRef msg As String) As Boolean
        Dim result As Boolean = False
        If Not OrderCollection.Contains(myOrder.ID) Then
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
