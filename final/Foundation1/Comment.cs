// class to track name of person commenting and the text(string) of the comment

class Comment
{
    private string _name;
    private string _text;
    
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment(Comment com)
    {
        Console.WriteLine($"{com._name}: {com._text}");
    }        
}