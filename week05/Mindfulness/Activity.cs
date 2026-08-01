using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(8);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerCharacters = new List<string>();
        spinnerCharacters.Add("│");
        spinnerCharacters.Add("/");
        spinnerCharacters.Add("—");
        spinnerCharacters.Add("\\");
        spinnerCharacters.Add("│");
        spinnerCharacters.Add("/");
        spinnerCharacters.Add("—");
        spinnerCharacters.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string spinner = spinnerCharacters[i];
            Console.Write(spinner);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= spinnerCharacters.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public int AskForDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }
}