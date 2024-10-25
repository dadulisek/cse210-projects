using System.IO;

public class GoalManager
{
    private int _score;
    private int _level;
    private List<Goal> _goals;

    public GoalManager()
    {
        _score = 0;
        _level = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        string userInput;

        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                ListGoalDetails();
            }
            else if (userInput == "3")
            {
                SaveGoals();
            }
            else if (userInput == "4")
            {
                LoadGoals();
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }

        } while (userInput != "6");
    }

    public void DisplayPlayerInfo()
    {
        _level = _score / 100;
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"You are level: {_level}");
        if (_score == 0 && _level == 0)
        {
            Console.WriteLine($"You have to reach 100 points until level {_level + 1}");
        }
        else
        {
            Console.WriteLine($"You have to reach {(_level + 1) * 100} points until level {_level + 1}");
        }
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetName()}");
            i ++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal g in _goals)
        {
            if (g.IsComplete())
            {
                Console.WriteLine($"[X] {g.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"[ ] {g.GetDetailsString()}");
            }
        }
    }

    public void CreateGoal()
    {
        string userInput;
        string name;
        string description;
        string strNum;
        int points;
        int timesComplete;
        int bonus;

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("How many points do you want to have associated with this goal? ");
            strNum = Console.ReadLine();
            points = int.Parse(strNum);

            SimpleGoal sg = new SimpleGoal(name, description, points);

            _goals.Add(sg);
        }
        else if (userInput == "2")
        {
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("How many points do you want to have associated with this goal? ");
            strNum = Console.ReadLine();
            points = int.Parse(strNum);

            EternalGoal eg = new EternalGoal(name, description, points);

            _goals.Add(eg);   
        }
        else if (userInput == "3")
        {
            Console.WriteLine("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("How many points do you want to have associated with this goal? ");
            strNum = Console.ReadLine();
            points = int.Parse(strNum);
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            strNum = Console.ReadLine();
            timesComplete = int.Parse(strNum);
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            strNum = Console.ReadLine();
            bonus = int.Parse(strNum);

            ChecklistGoal cg = new ChecklistGoal(name, description, points, timesComplete, bonus);

            _goals.Add(cg);
        }
    }
    public void RecordEvent()
    {
        string userInput;
        Goal goal;
        Console.WriteLine();
        
        ListGoalNames();

        userInput = Console.ReadLine();

        goal = _goals[int.Parse(userInput) - 1];

        goal.RecordEvent();

        // probably not needed
        // if (goal is ChecklistGoal checklistGoal)
        // {
        //     if (goal.IsComplete())
        //     {
        //         Console.WriteLine("Test if it work");
        //     }
        // }

        _score += goal.GetPoints();
        Console.WriteLine($"You have now {_score} points");
    }

    public void SaveGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter(fileName))
        {
            saveFile.WriteLine($"{_score}");

            foreach (Goal g in _goals)
            {
                saveFile.WriteLine($"{g.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split(" ~ ");

            string type = parts[0];

            switch (type)
            {
                case "Simple":
                    SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    sg.SetStatus(parts[4]);
                    _goals.Add(sg);
                    break;
                case "Eternal":
                    EternalGoal eg = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eg);
                    break;
                case "Checklist":
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                    cg.SetProgress(parts[6]);
                    _goals.Add(cg);
                    break;
            }
        }

    }
}