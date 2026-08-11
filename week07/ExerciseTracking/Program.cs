using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine("");
        Activity running = new Running("12/21/2003", 30, 4.8);

        Activity cycling = new Cycling("08/11/2026", 40, 9.7);


        Activity swimming = new Swimming("05/11/2026", 30, 5);


        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}