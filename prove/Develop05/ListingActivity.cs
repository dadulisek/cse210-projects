public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.Write($"You listed {_count} items!\n\n");
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[i]} ---");
    }

    private List<string> GetListFromUser()
    {
        List<string> userAnwsers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            Console.Write(">");
            string userInput = Console.ReadLine();
            userAnwsers.Add(userInput);
        }

        return userAnwsers;
    }
}