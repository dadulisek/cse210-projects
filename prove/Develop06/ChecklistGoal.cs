public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void SetProgress(string progress)
    {
        _amountCompleted = int.Parse(progress);
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _bonus + _points;
        }
        else
        {
            return _points;
        }
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulation! You have earned {GetPoints() + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulation! You have earned {GetPoints()} points!");
        }
    }

    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} ({GetDescription()}) -- Currently complete: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist ~ {GetName()} ~ {GetDescription()} ~ {GetPoints()} ~ {_bonus} ~ {_target} ~ {_amountCompleted}";
    }
}