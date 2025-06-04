using System;

class Program
{
    static void Main(string[] args)
    {
        Address customer1Address = new Address("324 Maple", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("George", customer1Address);
        Product customer1Product1 = new Product("Shoes", "FFAHF", 63.99, 2);
        Product customer1Product2 = new Product("Hat", "HAFH", 12.99, 1);
        Product customer1Product3 = new Product("Jacket", "JAC", 45.99, 2);
        List<Product> customer1List = new List<Product>();
        customer1List.AddRange(new List<Product> { customer1Product1, customer1Product2, customer1Product3 });

        Address customer2Address = new Address("324 Maple", "Rexburg", "Not Idaho", "Some Other Country");
        Customer customer2 = new Customer("Frank", customer2Address);
        Product customer2Product1 = new Product("Gloves", "GKYHW", 18.75, 2);
        Product customer2Product2 = new Product("Swimsuit", "PPHWC", 27.99, 1);
        Product customer2Product3 = new Product("Goggles", "GLYSB", 45.99, 2);
        List<Product> customer2List = new List<Product>();
        customer2List.AddRange(new List<Product> { customer2Product1, customer2Product2, customer2Product3 });

        Order customer1Order = new Order(customer1List, customer1);
        Console.Clear();
        Console.Write("Total Cost: $");
        Console.WriteLine(customer1Order.CalculateTotal());
        customer1Order.CreatePacking();
        customer1Order.CreateShipping();
        
        Order customer2Order = new Order(customer2List, customer2);
        Console.Write("Total Cost: $");
        Console.WriteLine(customer2Order.CalculateTotal());
        customer2Order.CreatePacking();
        customer2Order.CreateShipping();
    }
}