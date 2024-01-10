' InventoryManager.vb

Public Class InventoryManager
    Private _products As List(Of Product)
    Private _orders As List(Of Order)

    Public Sub New()
        _products = New List(Of Product)()
        _orders = New List(Of Order)()
    End Sub

    Public Sub AddProduct(product As Product)
        _products.Add(product)
    End Sub

    Public Sub CreateOrder(order As Order)
        _orders.Add(order)
    End Sub

    Public Sub DisplayProducts()
        Console.WriteLine("Available Products:")
        For Each product In _products
            product.Display()
        Next
    End Sub

    Public Sub DisplayOrders()
        Console.WriteLine("Order History:")
        For Each order In _orders
            order.Display()
        Next
    End Sub
End Class
