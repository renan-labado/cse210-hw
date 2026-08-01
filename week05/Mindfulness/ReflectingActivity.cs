public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" ——— {GetRandomPrompt()} ——— \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string action = Console.ReadLine();
        Console.Clear();
        int totalTime = 0;
        if (action == "")
        {
            while (totalTime < _duration)
            {
                Console.Write($"> {GetRandomQuestion()} "); ShowSpinner(15); Console.Write("\n");
                totalTime += 15;
            }
        }
        Console.WriteLine("");


    }

    public string GetRandomPrompt()
    {
        Random randomNumberPrompt = new Random();
        int promptIndex = randomNumberPrompt.Next(_prompts.Count);
        string randomPrompt = _prompts[promptIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomNumberQuestion = new Random();
        int questionIndex = randomNumberQuestion.Next(_questions.Count());
        string randomQuestion = _questions[questionIndex];
        return randomQuestion;
    }

    public void SetTheLists()
    {
        // set the list 
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        _prompts = prompts;
        _questions = questions;
    }
}