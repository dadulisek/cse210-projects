using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string txtUserAnwser;
        int userAnwser;

        do
        {
            Console.Write("What is your guess? ");
            txtUserAnwser = Console.ReadLine();

            userAnwser = int.Parse(txtUserAnwser);

            if(userAnwser > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userAnwser < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userAnwser == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userAnwser != magicNumber);
    }
}