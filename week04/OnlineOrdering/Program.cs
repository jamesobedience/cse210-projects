using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "KB101", 29.99, 1));
        order1.AddProduct(new Product("Mouse", "MS202", 19.99, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine("------------------------------------------");

        
        Address address2 = new Address("7 Iwebo lane", "Benin City", "BC", "Nigeria");
        Customer customer2 = new Customer("Emily Johnson", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Webcam", "WC303", 49.99, 1));
        order2.AddProduct(new Product("Headset", "HS404", 39.99, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
