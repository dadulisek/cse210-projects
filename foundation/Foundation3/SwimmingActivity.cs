public class SwimmingActivity : Activity
{
    private double _lapsCount;

    public SwimmingActivity(int minutes, int laps) : base(minutes)
    {
        _lapsCount = laps;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyy")} Swimming ({_timeMinutes} min): Distance {GetDistance()}km, Speed {Math.Round(GetSpeed(), 1)}kph. Pace: {Math.Round(GetPace(), 2)} min per km");
    }

    public override double GetDistance()
    {
        return _lapsCount * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _timeMinutes * 60;
    }

    public override double GetPace()
    {
        return _timeMinutes / GetDistance();
    }
}