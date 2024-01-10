' Program.vb

Module Program
    Sub Main()
        ' Create products
        Dim laptop As New Product(1, "Laptop", 800.0)
        Dim smartphone As New Product(2, "Smartphone", 400.0)

        ' Create orders
        Dim order1 As New Order(101)
        order1.AddProduct(laptop)
        order1.AddProduct(smartphone)

        Dim order2 As New Order(102)
        order2.AddProduct(smartphone)

        ' Create an inventory manager
        Dim inventoryManager As New InventoryManager()

        ' Add products to the inventory manager
        inventoryManager.AddProduct(laptop)
        inventoryManager.AddProduct(smartphone)

        ' Create orders and add them to the inventory manager
        inventoryManager.CreateOrder(order1)
        inventoryManager.CreateOrder(order2)

        ' Display available products and order history
        inventoryManager.DisplayProducts()
        inventoryManager.DisplayOrders()
    End Sub
End Module
