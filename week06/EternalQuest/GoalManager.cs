public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                ListGoalNames();
                CreateGoal();
            }
            else if (choice == 2)
            {
                int number = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{number}. {goal.GetDetailsString()}");
                    number ++;
                }
                
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("");
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
    
    public void CreateGoal()
    {
        Console.Write("What type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            string name = AskForName();
            string description = AskForDescription();
            int points = AskForPoints();
            Goal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
        }
        else if (goalType == 2)
        {
            string name = AskForName();
            string description = AskForDescription();
            int points = AskForPoints();
            Goal newEternalGoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalGoal);
        }
        else if (goalType == 3)
        {
            string name = AskForName();
            string description = AskForDescription();
            int points = AskForPoints();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Goal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newChecklistGoal);
        }
    }

    public string AskForName()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        return name;
    }

    public string AskForDescription()
    {
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        return description;        
    }

    public int AskForPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        return points;
    }
}