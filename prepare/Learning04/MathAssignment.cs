public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public string MathAssignment(string name, string topic, string textbookSection, string problems)
        : base (name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problems{ _problems}";
    }
}