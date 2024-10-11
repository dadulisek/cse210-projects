public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSec;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, Comment one, Comment two, Comment three)
    {
        _title = title;
        _author = author;
        _lengthInSec = length;

        _comments.Add(one);
        _comments.Add(two);
        _comments.Add(three);
    }

    public Video(string title, string author, int length, Comment one, Comment two, Comment three, Comment four)
    {
        _title = title;
        _author = author;
        _lengthInSec = length;

        _comments.Add(one);
        _comments.Add(two);
        _comments.Add(three);
        _comments.Add(four);
    }

    public int NumOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetVideo()
    {
        string videoInfo;

        videoInfo = $"Title: {_title}   Author: {_author}   Length: {_lengthInSec}";

        return videoInfo;
    }

    public void GetComment()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine(c.GetDisplayText());
        }
    }
}