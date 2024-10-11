public class Comment
{
    private string _text;
    private string _userName;

    public Comment(string text, string user)
    {
        _text = text;
        _userName = user;
    }

    public string GetDisplayText()
    {
        return $"{_userName} commented: {_text}";
    }
}