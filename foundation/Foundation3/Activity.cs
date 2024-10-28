public abstract class Activity
{
    protected int _timeMinutes;
    protected DateTime _date;

    public Activity( int minutes)
    {
        _date = DateTime.Now;
        _timeMinutes = minutes;
    }

    public abstract void GetSummary();

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public abstract double GetSpeed();

    public abstract double GetPace();
}