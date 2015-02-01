Public Class frmOrder

    Private coffeeMenu As New Dictionary(Of String, Double)
    Private cboDetailLines As New ArrayList

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' add coffees and prices to collection
        coffeeMenu.Add("Antigua", 5.95)
        coffeeMenu.Add("Apanas", 11.95)
        coffeeMenu.Add("Bantu", 9.92)
        coffeeMenu.Add("Colombia", 11.52)
        coffeeMenu.Add("Costa Rica", 13.6)
        coffeeMenu.Add("Ethiopia", 9.51)
        coffeeMenu.Add("French Roast", 10.72)
        coffeeMenu.Add("Huehuetenango", 10.95)
        coffeeMenu.Add("Kenya", 13.6)
        coffeeMenu.Add("Mexico", 11.52)
        coffeeMenu.Add("Morning Ed.", 9.92)
        coffeeMenu.Add("Nepenthe", 11.52)
        coffeeMenu.Add("Sumatra", 9.92)
        coffeeMenu.Add("Yemen", 8.96)
        coffeeMenu.Add("Yemen Mocha", 18.52)
        coffeeMenu.Add("Zimbabwe", 11.52)

        Dim positionFromTop As Integer = 0

        Dim grpMenuLines As New ArrayList
        For Each coffee As Object In coffeeMenu
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


            Console.WriteLine(coffee.key)
            Console.WriteLine(coffee.value.ToString)

            ' add control to the group box Coffee Menu
            grpMenu.Controls.Add(mnuItemName)
            grpMenu.Controls.Add(mnuItemPrice)

        Next



    End Sub

End Class