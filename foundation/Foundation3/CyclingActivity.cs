public class CyclingActivity : Activity
{
    private double _distance;

    public CyclingActivity(int minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }

     public override double GetSpeed()
    {
        return (_distance / _timeMinutes) * 60;
    }

    public override double GetPace()
    {
        return _timeMinutes / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyy")} Cycling ({_timeMinutes} min): Distance {_distance}km, Speed {Math.Round(GetSpeed(), 5)}kph. Pace: {Math.Round(GetPace(), 2)} min per km");
    }
}