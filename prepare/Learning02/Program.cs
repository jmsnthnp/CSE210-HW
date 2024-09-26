using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._company = "Samsung";
        job1._startYear = 1999;
        job1._endYear = 2002;

        Job job2 = new Job();
        job2._jobTitle = "Rocketman";
        job2._company = "SpaceX";
        job2._startYear = 1500;
        job2._endYear = 1600;

        Resume myResume = new Resume();
        myResume._name = "James Nathan Pecundo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}