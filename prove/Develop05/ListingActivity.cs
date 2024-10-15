public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    ListingActivity(string name, string description, int count) : base(name, description)
    {
        
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        _prompts = new List<string>();
        return _prompts;
    }
}