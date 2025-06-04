using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Order
{
    List<Product> _products;
    Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotal()
    {
        double subTotal = 0;
        int shipping = 0;
        if (_customer.GetAddress().IsUsa())
        {
            shipping = 5;
        }
        else shipping = 35;

        foreach (var item in _products)

        {
            subTotal = subTotal + item.GetProductPrice() * item.GetProductQuantity();
        }
        
        double totalCost = subTotal + shipping;
        return totalCost;
    }

    public void CreatePacking()
    {
        Console.WriteLine("Packing label");
        foreach (var item in _products)
        {
            Console.WriteLine($"Product ID: {item.GetProductID()} Product Name: {item.GetProductName()} Product QTY: {item.GetProductQuantity()}");
        }
        Console.WriteLine();
    }
    public void CreateShipping()

    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetAddress());
        Console.WriteLine();
    }
}