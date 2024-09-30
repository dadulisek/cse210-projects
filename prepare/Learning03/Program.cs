using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        string input;
        int setNum;

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Fraction f4 = new Fraction();

        input = Console.ReadLine();
        setNum = int.Parse(input);
        f4.SetNumerator(setNum);

        input = Console.ReadLine();
        setNum = int.Parse(input);
        f4.SetDenominator(setNum);

        Console.WriteLine($"{f1.GetFractionString()} {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()} {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()} {f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()} {f4.GetDecimalValue()}");
    }
}