using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates two addresses for the customers
        Address address1 = new Address("123 South St", "Springfield", "NY", "USA");

        Address address2 = new Address("321 Oak Ave", "Toronto", "ON", "Canada");

        // Creates two customers
        Customer customer1 = new Customer("Bruce Wayne", address1);

        Customer customer2 = new Customer("Clark Kent", address2);

        // Creates the products for the orders products
        Product product1 = new Product("Kyptonite", "A123", 799.99, 1);

        Product product2 = new Product("Lead Box", "B456", 25.99, 2);

        Product product3 = new Product("Energy Drink 60 Pack", "C789", 49.99, 1);

        Product product4 = new Product("Ultra Durable Spandex Cloth - Blue", "D012", 199.99, 1);

        Product product5 = new Product("Pit Viper Sunglasses", "E345", 129.99, 1);

        // Creates Both of the orders
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);

        order1.AddProduct(product2);

        order1.AddProduct(product3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);

        order2.AddProduct(product5);

        // Displays the results
        Console.WriteLine("Order 1:");

        Console.WriteLine("Packing Label:");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2:");

        Console.WriteLine("Packing Label:");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}