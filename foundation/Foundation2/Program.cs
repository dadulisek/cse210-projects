using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main rd", "Rexburg", "Idaho", "USA");
        Address a2 = new Address("1234 Masarykova", "Praha", "Czech Republic");

        Customer c1 = new Customer("John", "Doe", a1);
        Customer c2 = new Customer("Jan", "Novak", a2);

        Product p1 = new Product("Beef Jerky", "F001", 24.99, 5);
        Product p2 = new Product("Sour Patch", "F002", 7.99, 4);
        Product p3 = new Product("Sox wtih Utah flag", "c001", 4.99, 3);
        Product p4 = new Product("Sox with North Carolina flag", "c002", 4.99, 2);
        Product p5 = new Product("Hoodie wtih marine's motto", "c050", 13.99, 4);

        Order o1 = new Order(c1);
        Order o2 = new Order(c2);

        o1.AddToOrder(p1);
        o1.AddToOrder(p2);
        o2.AddToOrder(p3);
        o2.AddToOrder(p4);
        o2.AddToOrder(p5);

        Console.WriteLine("Start!");

        Console.WriteLine("Packing Label: ");
        o1.GetPackLabel();
        Console.WriteLine("Shiping Label:");
        o1.GetShipLabel();
        Console.WriteLine($"Total price is: {o1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Packing Label: ");
        o2.GetPackLabel();
        Console.WriteLine("Shiping Label:");
        o2.GetShipLabel();
        Console.WriteLine($"Total price is: {o2.GetTotalCost()}");

        Console.WriteLine("End!");
    }
}