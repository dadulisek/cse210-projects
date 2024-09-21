using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");

            string txtNumber = Console.ReadLine();

            int number = int.Parse(txtNumber);

            return number;
        }

        static int SquareNumber(int number)
        {
            int squaredNum = number * number;

            return squaredNum;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }
    }
}