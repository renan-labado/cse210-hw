public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
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
}