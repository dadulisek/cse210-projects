public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddToOrder(Product p)
    {
        _products.Add(p);
    }

    public double GetTotalCost()
    {
        double totalPrice = 0.0;

        foreach (Product p in _products)
        {
            totalPrice += p.GetTotalPrice();
        }

        if (_customer.LivesInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public void GetPackLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetProduct()}    ID:{p.GetID()}");
        }
    }

    public void GetShipLabel()
    {
        Console.WriteLine($"{_customer.GetNameText()}\n{_customer.GetAddress()}");
    }
}