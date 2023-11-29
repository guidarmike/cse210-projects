using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Olive Garden - Cheese Grater", "P001", 10.99, 2);
        Product product2 = new Product("Italian 'Parmigiano Regiano' cheese", "P002", 24.99, 3);
        Product product3 = new Product("Cheese knife", "P003", 17.99, 1);

        // Create addresses
        Address usaAddress = new Address("123 Main St", "Provo", "Utah", "USA");
        Address nonUsaAddress = new Address("456 International St", "Toronto", "N/A", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Mark Jenkins", nonUsaAddress);

        // Create orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}