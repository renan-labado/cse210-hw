public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        int total = 0;
        while (total < _duration)
        {
            Console.WriteLine("");
            Console.WriteLine($"Breathe in.... "); ShowCountDown(4);
            total += 4;
            Console.WriteLine("Now breathe out.... "); ShowCountDown(6);
            total += 6;

        }
        Console.WriteLine("\n \n");
    }
}