Public Class frmOrder

    Private coffeeMenu As New Dictionary(Of String, String)
    Private cboLines As New ArrayList
    Private txtPLines As New ArrayList
    Private nudQLines As New ArrayList
    Private txtTLines As New ArrayList

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' add coffees and prices to collection
        coffeeMenu.Add("Antigua", "5.95")
        coffeeMenu.Add("Apanas", "11.95")
        coffeeMenu.Add("Bantu", "9.92")
        coffeeMenu.Add("Colombia", "11.52")
        coffeeMenu.Add("Costa Rica", "13.60")
        coffeeMenu.Add("Ethiopia", "9.51")
        coffeeMenu.Add("French Roast", "10.72")
        coffeeMenu.Add("Huehuetenango", "10.95")
        coffeeMenu.Add("Kenya", "13.60")
        coffeeMenu.Add("Mexico", "11.52")
        coffeeMenu.Add("Morning Ed.", "9.92")
        coffeeMenu.Add("Nepenthe", "11.52")
        coffeeMenu.Add("Sumatra", "9.92")
        coffeeMenu.Add("Yemen", "8.96")
        coffeeMenu.Add("Yemen Mocha", "18.52")
        coffeeMenu.Add("Zimbabwe", "11.52")

        Dim positionFromTop As Integer = 0
        Dim grpMenuLines As New ArrayList
        For Each coffee As Object In coffeeMenu
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
        ' add order controls to the arrays
        cboLines.Add(cboItem)
        txtPLines.Add(txtPrice)
        nudQLines.Add(nudQuantity)
        txtTLines.Add(txtTotal)
    End Sub

    Public Sub calculateItemTotal()

    End Sub

    Public Sub calculateOrderTotal()

    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        ' Set the price when an Item is chosen from the combo box
        txtPrice.Text = coffeeMenu.Item(sender.Text)
        ' set quantity to default val of 1 if empty
        If nudQuantity.Value < 1 Then
            nudQuantity.Value = 1
        End If
        Dim total As Double = txtPrice.Text * nudQuantity.Value
        txtTotal.Text = total
    End Sub

    Private Sub cboItem_SelectedIndexChanged1(sender As Object, e As EventArgs)
        Dim index = CType(sender, ComboBox).Tag
        'index = index - 1
        Console.WriteLine("Combo box changed, index: " & index)
        Console.WriteLine("Combo box changed, index price: " & coffeeMenu.Item(sender.Text))
        txtPLines(index).Text = coffeeMenu.Item(sender.Text)
        If nudQLines(index).Value < 1 Then
            nudQLines(index).Value = 1
        End If
        Dim total As Double = txtPLines(index).Text * nudQLines(index).Value
        txtTLines(index).Text = total
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        If Not IsNothing(cboItem.SelectedItem) Then
            Dim total As Double = txtPrice.Text * nudQuantity.Value
            'Console.WriteLine("Price is: " & txtPrice.Text)
            'Console.WriteLine("Quantity is: " & nudQuantity.Value)
            txtTotal.Text = total
        End If
    End Sub

    Private Sub nudQuantity_ValueChanged1(sender As Object, e As EventArgs)
        Dim index = CType(sender, NumericUpDown).Tag
        'index = index - 1
        Console.WriteLine("Quantity changed, index: " & index)
        'Console.WriteLine("Quantity changed, price index: " & cboLines(index))
        'Console.WriteLine("Quantity changed, price index: " & txtPLines(index))
        'Console.WriteLine("Quantity changed, price index: " & nudQLines(index))
        If Not IsNothing(cboLines(index).SelectedItem) Then
            Dim total As Double = txtPLines(index).Text * nudQLines(index).Value
            txtTLines(index).Text = total
        End If
        'Console.WriteLine(txtPLines(index).Text)
        'Console.WriteLine(coffeeMenu.Item(sender.Text))
        'txtPLines(index).Text = coffeeMenu.Item(sender.Text)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim positionFromTop As Integer = 0

        Dim n As Integer = cboLines.Count - 1
        Dim nextPosition As Integer = cboLines(n).top + 25

        Dim cbo As New ComboBox
        cbo.Top = nextPosition
        cbo.Left = cboItem.Left
        cbo.Width = cboItem.Width
        cbo.Tag = n + 1
        Dim tool As New ToolTip
        tool.SetToolTip(cbo, "Line no: " & cbo.Tag + 1)

        Dim txtP As New TextBox
        txtP.Top = nextPosition
        txtP.Left = txtPrice.Left
        txtP.Width = txtPrice.Width
        txtP.Tag = n + 1

        Dim nudQ As New NumericUpDown
        nudQ.Top = nextPosition
        nudQ.Left = nudQuantity.Left
        nudQ.Width = nudQuantity.Width
        nudQ.Tag = n + 1

        Dim txtT As New TextBox
        txtT.Top = nextPosition
        txtT.Left = txtTotal.Left
        txtT.Width = txtTotal.Width
        txtT.Tag = n + 1


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
        Console.WriteLine("Adding..." & cbo.Tag & txtP.Tag & nudQ.Tag & txtT.Tag)
        ' add each coffee flavor to the combo box
        For Each coffee As Object In coffeeMenu
            cbo.Items.Add(coffee.key)
        Next

        ' register as event listener to combo box and quantity
        AddHandler cbo.SelectedIndexChanged, AddressOf cboItem_SelectedIndexChanged1
        AddHandler nudQ.ValueChanged, AddressOf nudQuantity_ValueChanged1
    End Sub

    Public Sub validateInput()

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class