public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(int minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return _distance / _timeMinutes * 60;
    }

    public override double GetPace()
    {
        return _timeMinutes / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyy")} Running ({_timeMinutes} min): Distance {_distance}km, Speed {Math.Round(GetSpeed(), 1)}kph. Pace: {Math.Round(GetPace(), 2)} min per km");
    }
}