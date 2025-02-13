using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("Blk 3 Lot 4 Lily Street", "Davao City", "Davao del Sur", "Philippines");
        Address address2 = new Address("1300 Dunn Avenue", "Clinton", "Oklahoma", "USA");

        Customer customer1 = new Customer("Adrianne Dumandan", address1);
        Customer customer2 = new Customer("Elise Swope", address2);

        Product product1 = new Product("Laptop", "P001", 1200.00m, 1);
        Product product2 = new Product("Mouse", "P002", 25.00m, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00m, 1);
        Product product4 = new Product("Monitor", "P004", 300.00m, 1);
        Product product5 = new Product("Printer", "P005", 150.00m, 1);
        Product product6 = new Product("Headphones", "P006", 80.00m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    private static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine();
    }
}
