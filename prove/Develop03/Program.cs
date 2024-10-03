using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(r, "Trust in the Lord with all thine heart, and lean not unto thien own understanding.");

        Console.WriteLine("Hello Develop03 World!");
        
        string answer; 
        string text = scripture.GetDisplayText();

        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        answer = Console.ReadLine();

        while (answer.ToLower() != "quit" && !scripture.IsCompletlyHidden())
        {
            scripture.HideRandomWords(3);

            text = scripture.GetDisplayText();

            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();   
        }
    }
}