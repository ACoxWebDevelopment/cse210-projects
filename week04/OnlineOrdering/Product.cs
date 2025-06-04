class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;


    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public string GetProductID()
    {
        return _id;
    }

    public string GetProductName()
    {
        return _name;
    }
}