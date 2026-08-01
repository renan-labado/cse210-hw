// the lines 28 to line 52 i got it from the instructor John Reading

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" ——— {GetRandomPrompt()} ——— ");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");
        DateTime now = DateTime.Now.AddSeconds(_duration);
        int lineCount = 0;
        string accum = "";
        List<string> inputs = new();
        while (DateTime.Compare(DateTime.Now, now) < 0)
        {
            Console.Write("");
            string input = Console.ReadKey().KeyChar.ToString();
            if (input == "\r")
            {
                ++lineCount;
                Console.WriteLine("");
                inputs.Add (accum);
                accum = "";
            }
            else
            {
                accum += input;
            }
        }
        int output = 1;
        foreach (var thing in inputs)
        {
            Console.WriteLine($"{output++}: {thing}");
        }
        Console.WriteLine($"You have listed {output -= 1} items!");
        Console.WriteLine("");
        Console.WriteLine("");
    }


    public string GetRandomPrompt()
    {
        Random randomNumberPrompt = new Random();
        int promptIndex = randomNumberPrompt.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];
        return randomPrompt;
    }

    public void SetTheList()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        prompts.Add("Who inspired you this week?");

        _prompts = prompts;
    }
}