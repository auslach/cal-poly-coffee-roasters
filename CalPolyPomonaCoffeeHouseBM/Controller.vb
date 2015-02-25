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
        Dim msg As String = ""
        If myOrder IsNot Nothing Then
            If isValidOrder(myOrder, msg) Then
                OrderCollection.Add(myOrder, myOrder.ID)
            Else
                If replace = True Then
                    OrderCollection.Remove(myOrder.ID)
                    OrderCollection.Add(myOrder, myOrder.ID)
                End If
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

    'Public Sub orderFormFill(ByVal ID As String)
    '    Dim myOrder As Order = getOrder(ID)

    '    ' clear the form 
    '    btnNewOrder.PerformClick()

    '    txtOrderNumber.Text = myOrder.ID
    '    txtServer.Text = myOrder.server
    '    dtpDateTime.Text = myOrder.orderDate

    '    txtFoodTotal.Text = FormatCurrency(myOrder.total, 2)
    '    txtSalesTax.Text = FormatCurrency(myOrder.tax, 2)
    '    txtOrderTotal.Text = FormatCurrency(myOrder.grandTotal, 2)

    '    For n As Integer = 0 To myOrder.countItems - 2
    '        btnAdd.PerformClick()
    '    Next

    '    ' loop through each order line
    '    ' add a new line for each order line
    '    ' fill out values for each order line

    '    For n As Integer = 0 To myOrder.countItems - 1
    '        cboLines(n).Text = myOrder.getLine(n).name
    '        txtPLines(n).Text = myOrder.getLine(n).price
    '        nudQLines(n).Text = myOrder.getLine(n).qty
    '        txtTLines(n).Text = myOrder.getLine(n).lineTotal
    '    Next
    'End Sub

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
