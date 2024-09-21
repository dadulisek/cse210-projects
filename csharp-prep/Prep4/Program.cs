using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string txtInput;
        int input;
        int sum = 0;
        float average = 0;
        int high = 0;

        do
        {
            Console.Write("Enter a number: ");
            txtInput = Console.ReadLine();

            input = int.Parse(txtInput);

            numbers.Add(input);
        } while (input != 0);

        foreach (int number in numbers)
        {
            sum += number;

            if (number > high)
            {
                high = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        average = ((float)sum) / (numbers.Count - 1);

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {high}");
    }
}