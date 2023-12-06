namespace NetTraining.Models;

public class Testpaper : ITestpaper
{
    public string Subject { get; set; } = string.Empty;

    public string[] MarkScheme { get; set; } = default!;

    public string PassMark { get; set; } = string.Empty;


    public Testpaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}
