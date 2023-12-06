namespace NetTraining.Models;

public interface ITestpaper
{
    string Subject { get; set; }

    string[] MarkScheme { get; set; }

    string PassMark { get; set; }
}
