Imports System.Globalization
Imports System.ComponentModel

Public Class stockcontroller
    Private stockList As New List(Of StockItem)
    Class StockItem
        Public Property itemName As String
        Public Property barcode As String
        Public Property category As String
        Public Property description As String
        Public Property sellingPrice As Decimal
    End Class

    ' Designer-safe, non-throwing add method for UI usage
    Public Function TryAddItem(itemName As String,
                               barcode As String,
                               category As String,
                               description As String,
                               priceText As String,
                               ByRef errorMessage As String) As Boolean

        errorMessage = String.Empty

        ' Prevent validation while Visual Studio designer instantiates the class
        If LicenseManager.UsageMode = LicenseUsageMode.Designtime Then
            errorMessage = "Operation unavailable in designer."
            Return False
        End If

        Dim name = If(itemName, String.Empty).Trim()
        Dim code = If(barcode, String.Empty).Trim()
        Dim cat = If(category, String.Empty).Trim()
        Dim desc = If(description, String.Empty).Trim()
        Dim priceTextTrim = If(priceText, String.Empty).Trim()

        If String.IsNullOrEmpty(name) Then
            errorMessage = "Item name is required."
            Return False
        End If
        If String.IsNullOrEmpty(code) Then
            errorMessage = "Barcode is required."
            Return False
        End If
        If String.IsNullOrEmpty(cat) Then
            errorMessage = "Category is required."
            Return False
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(priceTextTrim, NumberStyles.Number, CultureInfo.InvariantCulture, price) Then
            errorMessage = "Selling price is not a valid decimal number."
            Return False
        End If
        If price < 0D Then
            errorMessage = "Selling price must be zero or greater."
            Return False
        End If

        If stockList.Exists(Function(s) String.Equals(s.barcode, code, StringComparison.OrdinalIgnoreCase)) Then
            errorMessage = $"An item with barcode '{code}' already exists."
            Return False
        End If

        If desc.Length > 1000 Then
            desc = desc.Substring(0, 1000)
        End If

        Dim item As New StockItem With {
            .itemName = name,
            .barcode = code,
            .category = cat,
            .description = desc,
            .sellingPrice = price
        }

        stockList.Add(item)
        Return True
    End Function

    ' Backwards-compatible method that throws on error
    Public Sub AddItem(itemName As String,
                       barcode As String,
                       category As String,
                       description As String,
                       priceText As String)

        Dim err As String = Nothing
        If Not TryAddItem(itemName, barcode, category, description, priceText, err) Then
            Throw New ArgumentException(err)
        End If

    End Sub

    Public Function GetStocks() As List(Of StockItem)
        Return stockList
    End Function

End Class
