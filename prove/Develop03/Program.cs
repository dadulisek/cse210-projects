using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Nephi", 3, 7);

        Scripture scripture = new Scripture(r, "I wil go and do as the lord commands.");

        Console.WriteLine("Hello Develop03 World!");
    }
}