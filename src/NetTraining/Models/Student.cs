
namespace NetTraining.Models;

public class Student : IStudent
{

    private const string NoTestsTakenMessage = "No tests taken";
    
    private ICollection<string> _testResults = new List<string>() { NoTestsTakenMessage };

    public void TakeTest(ITestpaper paper, string[] answers)
    {
        var testResult = GetTestResult(paper.MarkScheme, answers);
        var passMark = int.Parse(paper.PassMark.Replace('%',' ').Trim());
        var hasStudentPassed = testResult >= passMark;

        var resultMessage = BuildResultMessage(paper.Subject, hasStudentPassed, testResult);
            
    }

    private object BuildResultMessage(string subject, bool hasStudentPassed, int testResult)
    {
        throw new NotImplementedException();
    }

    private int GetTestResult(string[] markScheme, string[] answers)
    {
        throw new NotImplementedException();
    }

    public string[] TestsTaken()
    {
        return _testResults.ToArray();
    }
}
