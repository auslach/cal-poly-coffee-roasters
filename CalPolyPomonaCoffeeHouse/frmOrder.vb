Imports CalPolyPomonaCoffeeHouseBM

Public Class frmOrder

    Private ctrl As New Controller
    Public coffeeMenu As New Menu

    'Public Const taxPercent = 0.0775

    Private cboLines As New ArrayList
    Private txtPLines As New ArrayList
    Private nudQLines As New ArrayList
    Private txtTLines As New ArrayList
    Private orderSummaryLines() As Object = {cboLines, txtPLines, nudQLines, txtTLines}

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Controller and Menu vars
        ctrl = CType(MdiParent, frmMain).ctrl
        coffeeMenu = ctrl.getMenu()

        Dim coffees As Dictionary(Of String, String) = coffeeMenu.getItems()
        Dim positionFromTop As Integer = 0
        Dim grpMenuLines As New ArrayList
        For Each coffee As Object In coffees
            ' Display all coffee flavors in the menu panel
            Dim mnuItemName As New Label
            Dim mnuItemPrice As New Label
            positionFromTop += 17

            mnuItemName.AutoSize = True
            mnuItemName.Left = 10
            mnuItemName.Text = coffee.key
            mnuItemName.Top = positionFromTop
            mnuItemPrice.AutoSize = True
            mnuItemPrice.TextAlign = ContentAlignment.TopRight
            mnuItemPrice.Left = 130
            mnuItemPrice.Text = "$ " & coffee.value
            mnuItemPrice.Top = positionFromTop

            ' add control to the group box Coffee Menu
            grpMenu.Controls.Add(mnuItemName)
            grpMenu.Controls.Add(mnuItemPrice)

            ' Add coffee flavors to combo box
            cboItem.Items.Add(coffee.key)
        Next
        ' make price and total textboxes readonly
        txtPrice.ReadOnly = True
        txtTotal.ReadOnly = True
        ' text align to the right
        txtPrice.TextAlign = HorizontalAlignment.Right
        nudQuantity.TextAlign = HorizontalAlignment.Right
        txtTotal.TextAlign = HorizontalAlignment.Right

        ' make totals readonly
        txtFoodTotal.ReadOnly = True
        txtSalesTax.ReadOnly = True
        txtOrderTotal.ReadOnly = True
        txtFoodTotal.TabStop = False
        txtSalesTax.TabStop = False
        txtOrderTotal.TabStop = False


        ' add order controls to the arrays
        cboLines.Add(cboItem)
        txtPLines.Add(txtPrice)
        nudQLines.Add(nudQuantity)
        txtTLines.Add(txtTotal)
    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        ' Set the price when an Item is chosen from the combo box
        If cboItem.SelectedIndex <> -1 Then
            Dim price As Double = coffeeMenu.GetPrice(sender.Text)
            txtPrice.Text = Format(price, "0.00")
            ' set quantity to default val of 1 if empty
            If nudQuantity.Value < 1 Then
                nudQuantity.Value = 1
            End If
            Dim total As Double = txtPrice.Text * nudQuantity.Value
            txtTotal.Text = Format(total, "0.00")
        End If
    End Sub

    Private Sub cboItem_SelectedIndexChanged1(sender As Object, e As EventArgs)
        Dim index = CType(sender, ComboBox).Tag
        'index = index - 1
        Console.WriteLine("Combo box changed, index: " & index)
        Console.WriteLine("Combo box changed, index price: " & coffeeMenu.GetPrice(sender.Text))
        Dim price As Double = coffeeMenu.GetPrice(sender.Text)
        txtPLines(index).Text = Format(price, "0.00")
        If nudQLines(index).Value < 1 Then
            nudQLines(index).Value = 1
        End If
        Dim total As Double = txtPLines(index).Text * nudQLines(index).Value
        txtTLines(index).Text = Format(total, "0.00")
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        If txtPrice.Text <> "" Then
            Console.WriteLine("cbo: " & cboItem.Text)
            Console.WriteLine("price: " & txtPrice.Text)
            Console.WriteLine("quantity: " & nudQuantity.Value)

            Dim total As Double = txtPrice.Text * nudQuantity.Value
            'Console.WriteLine("Price is: " & txtPrice.Text)
            'Console.WriteLine("Quantity is: " & nudQuantity.Value)
            txtTotal.Text = Format(total, "0.00")
        End If
    End Sub

    Private Sub nudQuantity_ValueChanged1(sender As Object, e As EventArgs)
        Dim index = CType(sender, NumericUpDown).Tag
        'index = index - 1
        Console.WriteLine("Quantity changed, index: " & index)
        If Not IsNothing(cboLines(index).SelectedItem) Then
            Dim total As Double = txtPLines(index).Text * nudQLines(index).Value
            txtTLines(index).Text = Format(total, "0.00")
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim positionFromTop As Integer = 0

        Dim n As Integer = cboLines.Count - 1
        Dim nextPosition As Integer = cboLines(n).top + 25

        Dim cbo As New ComboBox
        cbo.Top = nextPosition
        cbo.Left = cboItem.Left
        cbo.Width = cboItem.Width
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.Tag = n + 1
        Dim tool As New ToolTip
        tool.SetToolTip(cbo, "Line no: " & cbo.Tag + 1)

        Dim txtP As New TextBox
        txtP.Top = nextPosition
        txtP.Left = txtPrice.Left
        txtP.Width = txtPrice.Width
        txtP.Tag = n + 1
        txtP.ReadOnly = True
        txtP.TabStop = False
        txtP.TextAlign = HorizontalAlignment.Right

        Dim nudQ As New NumericUpDown
        nudQ.Top = nextPosition
        nudQ.Left = nudQuantity.Left
        nudQ.Width = nudQuantity.Width
        nudQ.Tag = n + 1
        nudQ.TextAlign = HorizontalAlignment.Right

        Dim txtT As New TextBox
        txtT.Top = nextPosition
        txtT.Left = txtTotal.Left
        txtT.Width = txtTotal.Width
        txtT.Tag = n + 1
        txtT.ReadOnly = True
        txtT.TabStop = False
        txtT.TextAlign = HorizontalAlignment.Right


        ' add to group box
        panOrderSummary.Controls.Add(cbo)
        panOrderSummary.Controls.Add(txtP)
        panOrderSummary.Controls.Add(nudQ)
        panOrderSummary.Controls.Add(txtT)
        ' add to arraylist
        cboLines.Add(cbo)
        txtPLines.Add(txtP)
        nudQLines.Add(nudQ)
        txtTLines.Add(txtT)
        ' add each coffee flavor to the combo box
        Dim coffees As Dictionary(Of String, String) = coffeeMenu.getItems()
        For Each coffee As Object In coffees
            cbo.Items.Add(coffee.key)
        Next

        ' register as event listener to combo box and quantity
        AddHandler cbo.SelectedIndexChanged, AddressOf cboItem_SelectedIndexChanged1
        AddHandler nudQ.ValueChanged, AddressOf nudQuantity_ValueChanged1
    End Sub



    Private Sub calculateOrderTotal()
        ' declare variables
        Dim foodTotal As Double = 0
        Dim salesTax As Double = 0
        Dim orderTotal As Double = 0

        ' loop through each line, total up costs
        For Each total As Object In txtTLines
            Dim amount As Double = 0
            ' convert total to double
            Double.TryParse(total.Text, amount)
            foodTotal += amount
        Next

        ' calculate sales tax
        ' salesTax = foodTotal * taxPercent
        ' calculate order total
        orderTotal = foodTotal + salesTax

        txtFoodTotal.Text = FormatCurrency(foodTotal, 2)
        txtSalesTax.Text = FormatCurrency(salesTax, 2)
        txtOrderTotal.Text = FormatCurrency(orderTotal, 2)
    End Sub

    Private myOrder As Order

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        ' validations
        Dim validated As Boolean = False
        If ctrl.isPresent(txtOrderNumber.Text, "Order Number") AndAlso ctrl.isInteger(txtOrderNumber.Text, "Order Number") Then
            If ctrl.isPresent(txtServer.Text, "Server Name") Then
                If ctrl.isInteger(nudQuantity.Value, "Quantity") Then
                    ' loop through array of lines, get index
                    For n As Integer = 0 To cboLines.Count - 1
                        ' use index to validate presence of combo box and quantity
                        If ctrl.isInteger(nudQLines(n).Text, "Quantity") AndAlso ctrl.isPresent(cboLines(n).Text, "Coffee Flavor") Then
                            validated = True
                        Else
                            validated = False
                            Return
                        End If
                    Next
                    ' calculate order total if validation passes
                    If validated = True Then
                        Console.WriteLine("All validations passed! Calculating total")

                        myOrder = New Order()
                        myOrder.ID = txtOrderNumber.Text
                        myOrder.server = txtServer.Text
                        myOrder.orderDate = dtpDateTime.Text

                        ' loop through lines, record name, price, qty
                        For n As Integer = 0 To cboLines.Count - 1
                            Dim orderLine As New OrderLine()
                            orderLine.name = cboLines(n).Text
                            orderLine.price = txtPLines(n).Text
                            orderLine.qty = nudQLines(n).Value
                            ' add order line to order object
                            myOrder.addLine(orderLine)
                        Next

                        txtFoodTotal.Text = FormatCurrency(myOrder.total, 2)
                        txtSalesTax.Text = FormatCurrency(myOrder.tax, 2)
                        txtOrderTotal.Text = FormatCurrency(myOrder.grandTotal, 2)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        ' clear the form
        txtOrderNumber.Clear()
        txtServer.Clear()
        dtpDateTime.Value = Now

        ' clear order total values
        txtFoodTotal.Clear()
        txtSalesTax.Clear()
        txtOrderTotal.Clear()

        ' clear the first line of order summary
        cboItem.SelectedIndex = -1
        nudQuantity.Value = 0
        txtPrice.Clear()
        txtTotal.Clear()

        ' return focus to order number field
        txtOrderNumber.Focus()

        ' loop through each order summary item
        For n As Integer = 1 To cboLines.Count - 1
            ' remove summary item from gui
            For Each line As Object In orderSummaryLines
                panOrderSummary.Controls.Remove(line(n))
            Next
        Next

        For Each line As Object In cboLines
            Console.WriteLine(line)
        Next

        ' remove summary item from array
        For Each line As Object In orderSummaryLines
            line.Clear()
        Next

        For Each line As Object In nudQLines
            Console.WriteLine(line)
        Next

        ' re-add first line of orders to order summary list
        cboLines.Add(cboItem)
        txtPLines.Add(txtPrice)
        nudQLines.Add(nudQuantity)
        txtTLines.Add(txtTotal)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnTotal.PerformClick()
        Dim message As String
        message = ctrl.addOrder(myOrder)
        If message <> "" Then
            Dim result As Integer = MessageBox.Show(message, "Coffee Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = vbYes Then
                ctrl.addOrder(myOrder, True)
            End If
        End If
    End Sub

    Private Sub btnGetOrder_Click(sender As Object, e As EventArgs) Handles btnGetOrder.Click
        If ctrl.isPresent(txtOrderNumber.Text, "Order Number") AndAlso ctrl.isInteger(txtOrderNumber.Text, "Order Number") AndAlso ctrl.orderExists(txtOrderNumber.Text, "Order Number") Then
            myOrder = ctrl.getOrder(txtOrderNumber.Text)

            ' clear the form 
            btnNewOrder.PerformClick()

            txtOrderNumber.Text = myOrder.ID
            txtServer.Text = myOrder.server
            dtpDateTime.Text = myOrder.orderDate

            txtFoodTotal.Text = FormatCurrency(myOrder.total, 2)
            txtSalesTax.Text = FormatCurrency(myOrder.tax, 2)
            txtOrderTotal.Text = FormatCurrency(myOrder.grandTotal, 2)

            For n As Integer = 0 To myOrder.countItems - 2
                btnAdd.PerformClick()
            Next

            ' loop through each order line
            ' add a new line for each order line
            ' fill out values for each order line

            For n As Integer = 0 To myOrder.countItems - 1
                cboLines(n).Text = myOrder.getLine(n).name
                txtPLines(n).Text = myOrder.getLine(n).price
                nudQLines(n).Text = myOrder.getLine(n).qty
                txtTLines(n).Text = myOrder.getLine(n).lineTotal
            Next

        End If
    End Sub
End Class