// In the save part I added option that you can save your journal to the same file which you loaded it from. It is automatic so you don't need to write the filename again.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        DateTime theCurrentTime = DateTime.Now;

        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptGenerator._prompts.Add("What good did I do today?");

        Journal journal = new Journal();

        string fileName = "";
        string answer;
        string promptNow = "";

        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");


            answer = Console.ReadLine();

            if (answer == "1")
            {
                Entry entry = new Entry();

                promptNow = promptGenerator.GetRandomPrompt();

                Console.WriteLine(promptNow);
                entry._entryText = Console.ReadLine();
                entry._date = theCurrentTime.ToShortDateString();
                entry._promptText = promptNow;

                journal.AddEntry(entry);
            }
            else if (answer == "2")
            {
                journal.DisplayAll();
            }
            else if (answer == "3")
            {
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (answer == "4")
            {
                Console.WriteLine("Do you want to save the Journal to the same file which you loaded it from? YES/NO");
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    journal.SaveToFile(fileName);
                }
                else
                {
                    Console.WriteLine("What is the filename?");
                    fileName = Console.ReadLine();

                    journal.SaveToFile(fileName);
                }
                Console.WriteLine($"Journal saved to {fileName}");
            }
        } while (answer != "5");
    }
}