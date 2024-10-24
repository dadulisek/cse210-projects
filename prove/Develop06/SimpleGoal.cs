public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetStatus(string status)
    {
        _isComplete = bool.Parse(status);
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation! You have earned {GetPoints()} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple ~ {GetName()} ~ {GetDescription()} ~ {GetPoints()} ~ {IsComplete()}";
    }
}