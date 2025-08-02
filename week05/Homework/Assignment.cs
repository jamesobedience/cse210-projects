public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Public getter so derived classes can access the name safely
    public string GetStudentName()
    {
        return _studentName;
    }
}
// This class represents a general assignment with a student's name and topic.