// I added class UserLog, this class saves how many seconds did the user spend in each activity, and also how many times
// did the user used the activity. When you quit the program it saves to .csv file, I also added option in menu for user to
// view their personal stats.

using System;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity b = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity r = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity l = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        UserLog ul = new UserLog();

        string response;

        ul.LoadFromFile();

        do
        {
            Console.Clear();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. View personal stats");
            Console.WriteLine("5. Quit");
            response = Console.ReadLine();

            if (response == "1")
            {
                Console.Clear();
                b.DisplayStartingMessage();
                Console.Clear();
                b.Run();
                b.DisplayEndingMessage();
                ul.SetBreathing(b.GetDuration());

            }
            else if (response == "2")
            {
                Console.Clear();
                r.DisplayStartingMessage();
                r.Run();
                r.DisplayEndingMessage();
                ul.SetReflecting(r.GetDuration());
            }
            else if (response == "3")
            {
                Console.Clear();
                l.DisplayStartingMessage();
                l.Run();
                l.DisplayEndingMessage();
                ul.SetListing(l.GetDuration());
            }
            else if (response == "4")
            {
                Console.Clear();
                ul.DisplayStats();
            }
        } while (response != "5");

        ul.SaveToFile();
    }
}