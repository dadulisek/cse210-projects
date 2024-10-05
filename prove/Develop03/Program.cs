// I added lines of code that hide random number of words, and it make sure the word is not already hiden. If it is it chooses another one. If there is less words to hide then it was picked by the random number, it hides the rest.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference r = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(r, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowladge him, and he shall direct thy paths.");
        
        string answer; 
        string text = scripture.GetDisplayText();
        int randomNum;

        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        answer = Console.ReadLine();

        while (answer.ToLower() != "quit" && !scripture.IsCompletlyHidden())
        {
            Console.Clear();

            Random rand = new Random();

            randomNum = rand.Next(2, 4);

            scripture.HideRandomWords(randomNum);

            text = scripture.GetDisplayText();

            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();   
        }
    }
}