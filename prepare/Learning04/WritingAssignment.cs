using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} \n{_title}";
    }
}