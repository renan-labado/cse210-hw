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
        
    }

    public void GetRandomPrompt()
    {
        
    }

    //public List<string> GetListFromUser()
    //{
    //    return "";
    //}

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