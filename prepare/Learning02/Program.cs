using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2018;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Google";
        job2._startYear = 2018;
        job2._endYear = 2021;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Alex Okhitoya";
        resume._jobs.Add(job1);
        resume.Display();

    }
}