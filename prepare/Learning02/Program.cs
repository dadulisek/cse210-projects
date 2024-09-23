using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        Job job2 = new Job();

        job1._jobTitle = "Intern";
        job1._startYear = 2022;
        job1._endYear = 2023;
        job1._company = "Apple";

        job2._jobTitle = "Janitor";
        job2._startYear = 2015;
        job2._endYear = 2020;
        job2._company = "Mikerowesoft";

        Resume resume1 = new Resume();
        resume1._name = "Lee Gump";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}