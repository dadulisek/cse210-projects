using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity ra = new RunningActivity(55, 8);
        CyclingActivity ca = new CyclingActivity(100, 20);
        SwimmingActivity sa = new SwimmingActivity(30, 13);

        List<Activity> activites = new List<Activity>();
        activites.Add(ra);
        activites.Add(ca);
        activites.Add(sa);

        foreach(Activity a in activites)
        {
            a.GetSummary();
        }
    }
}