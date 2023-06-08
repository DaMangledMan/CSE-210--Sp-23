main();

void main()
{

}


// class that stores assignment data
public class Assignment
{
    // attributes
    protected string _studentName;
    protected string _topic;

    // constructor
    protected Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // methods

    public virtual string getSummary()
    {
        return $"Name: {_studentName}\nTopic: {_topic}";
    }
}


// class that stores specifically math assignment data
public class MathAssignment : Assignment
{
    // attributes
    private string _textbookSection;
    private string _problems;

    // constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // methods

    public string getHomework()
    {
        return $"";
    }

    public override string getSummary()
    {
        return $"{base.getSummary()}\nSection: {_textbookSection}\nProblems: {_problems}";

    }
}


// class that stores specifically writing assignment data
public class WritingAssignment : Assignment
{
    // attributes
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // methods

    public override string getSummary()
    {
        return $"{base.getSummary()}\nTitle: {_title}";

    }

    public string getWritingInformation()
    {
        return $"";
    }
}