using System;

public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    public Assignment(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }

    public string getSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}