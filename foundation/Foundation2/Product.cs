public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private double _totalPrice;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id; 
        _price = price;
        _quantity = quantity;
        _totalPrice = quantity * price;
    }

    public string GetProduct()
    {
        return _name;
    }

    public string GetID()
    {
        return _id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}