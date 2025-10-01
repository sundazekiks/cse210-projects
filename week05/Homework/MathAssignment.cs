using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string textBookSection, string problems, string topic) : base(topic, studentName)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textBookSection}, Problems {_problems}";
    }
}