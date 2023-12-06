namespace NetTraining.Models;

public class TestPaper : ITestpaper
{
    public string Subject { get; set; } = string.Empty;

    public string[] MarkScheme { get; set; } = default!;

    public string PassMark { get; set; } = string.Empty;
    

    public TestPaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}
