using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "English Tutor";
        job2._company = "Engoo";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Console.WriteLine("");
        Resume myResume = new Resume();
        myResume._name = "Renz Labado";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    }
}