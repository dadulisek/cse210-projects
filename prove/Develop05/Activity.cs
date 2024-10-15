public class Activity
{
    private string _name;
    private string _description;
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string durStr = Console.ReadLine();
        _duration = int.Parse(durStr);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string>{"|", "/", "-", "\\"};

        DateTime startTimer = DateTime.Now;
        DateTime endTimer = startTimer.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTimer)
        {
            string f = frames[i];
            Console.Write(f);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= frames.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}