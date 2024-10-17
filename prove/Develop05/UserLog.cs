using System;
using System.IO;

public class UserLog
{
    private int _breathingTotalTime;
    private int _listingTotalTime;
    private int _reflectingTotalTime;

    private int _breathingTimesTurnedOn;
    private int _listingTimesTurnedOn;
    private int _reflectingTimesTurnedOn;

    public UserLog()
    {
        _breathingTimesTurnedOn = 0;
        _breathingTotalTime = 0;

        _listingTimesTurnedOn = 0;
        _listingTotalTime = 0;

        _reflectingTimesTurnedOn = 0;
        _reflectingTotalTime = 0;
    }

    public void SetBreathing(int time)
    {
        _breathingTotalTime += time;
        _breathingTimesTurnedOn ++;
    }

    public void SetReflecting(int time)
    {
        _reflectingTotalTime += time;
        _reflectingTimesTurnedOn ++;
    }

    public void SetListing(int time)
    {
        _listingTotalTime += time;
        _listingTimesTurnedOn ++;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Breathing Activity total time spent in sec: {_breathingTotalTime}");
        Console.WriteLine($"You used Breathing Activity {_breathingTimesTurnedOn} times, with average of {_breathingTotalTime / _breathingTimesTurnedOn} per use.\n");
        Console.WriteLine($"Reflecting Activity total time spent in sec: {_reflectingTotalTime}");
        Console.WriteLine($"You used Reflecting Activity {_reflectingTimesTurnedOn} times, with average of {_reflectingTotalTime / _reflectingTimesTurnedOn} per use.\n");
        Console.WriteLine($"Listing Activity total time spent in sec: {_listingTotalTime}");
        Console.WriteLine($"You used Listing Activity {_listingTimesTurnedOn} times, with average of {_listingTotalTime / _listingTimesTurnedOn} per use.\n");
        Console.WriteLine("Press enter to return to main menu.");
        Console.ReadLine();
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter("user log.csv"))
        {
            writer.WriteLine("Name of Activity,Total time spent,How many times turned on");
            writer.WriteLine($"Breathing,{_breathingTotalTime},{_breathingTimesTurnedOn}");
            writer.WriteLine($"Reflecting,{_reflectingTotalTime},{_reflectingTimesTurnedOn}");
            writer.WriteLine($"Listing,{_listingTotalTime},{_listingTimesTurnedOn}");
        }
    }

    public void LoadFromFile()
    {
        using (var reader = new StreamReader("user log.csv"))
        {
            string line;

            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(",");

                string name = values[0];
                int totalTime = int.Parse(values[1]);
                int timesUsed = int.Parse(values[2]);

                switch (name)
                {
                    case "Breathing":
                        _breathingTotalTime = totalTime;
                        _breathingTimesTurnedOn = timesUsed;
                        break;

                    case "Reflecting":
                        _reflectingTotalTime = totalTime;
                        _reflectingTimesTurnedOn = timesUsed;
                        break;
                    
                    case "Listing":
                        _listingTotalTime = totalTime;
                        _listingTimesTurnedOn = timesUsed;
                        break;
                }
            }
        }
    }
}