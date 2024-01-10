' Order.vb

Public Class Order
    Private _orderId As Integer
    Private _products As List(Of Product)

    Public Sub New(orderId As Integer)
        _orderId = orderId
        _products = New List(Of Product)()
    End Sub

    Public Sub AddProduct(product As Product)
        _products.Add(product)
    End Sub

    Public Sub Display()
        Console.WriteLine($"Order ID: {_orderId}")
        For Each product In _products
            product.Display()
        Next
    End Sub
End Class
