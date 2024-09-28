public class PromptGenerator
{

    Random random = new Random();

    int randomNum;

    public List<string> _prompts =  new List<string>();

    public string GetRandomPrompt()
    {
        randomNum = random.Next(0, _prompts.Count);

        return _prompts[randomNum];
    }
}