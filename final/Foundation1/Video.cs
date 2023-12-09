// class for tracking title, author, length in seconds, and a list of comments of all videos

using System.Net;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    public void DisplayDetails(Video v)
    {
        Console.WriteLine($"{v._title}: {v._author}, {v._length} seconds, {v._comments.Count} comments");
    }
    public List<Comment> Comments
    {
        get { return _comments; }
    }
}