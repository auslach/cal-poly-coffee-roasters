Public Class Menu

    Private coffeeMenu As New Dictionary(Of String, String)

    ' constructor
    Public Sub New()
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
    End Sub

    ' get price of an item
    Public Function GetPrice(name As String) As Double
        Return coffeeMenu.Item(name)
    End Function

    Public Function getItems() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String)(coffeeMenu)
    End Function

End Class
