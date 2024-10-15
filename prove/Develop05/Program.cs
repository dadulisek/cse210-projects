using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity b = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        string response;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            response = Console.ReadLine();

            if (response == "1")
            {
                Console.Clear();
                b.DisplayStartingMessage();
                Console.Clear();
                b.Run();
                b.DisplayEndingMessage();

            }
        } while (response != "4");
    }
}