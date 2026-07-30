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
        ShowSpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner();
    }

    public void ShowSpinner()
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
        spinnerCharacters.Add("│");
        foreach (string s in spinnerCharacters)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        

    }

    public void ShowCountDown(int seconds)
    {
        
    }
    public void AskForDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }
}