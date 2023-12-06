
using System.Numerics;

namespace NetTraining.Models;

public class Student : IStudent
{

    private const string NoTestsTakenMessage = "No tests taken";
    
    private List<string> _testResults = new List<string>() { NoTestsTakenMessage };

    public void TakeTest(ITestpaper paper, string[] answers)
    {
        var testResult = GetTestResult(paper.MarkScheme, answers);
        var passMark = int.Parse(paper.PassMark.Replace('%',' ').Trim());
        var hasStudentPassed = testResult >= passMark;

        var resultMessage = BuildResultMessage(paper.Subject, hasStudentPassed, testResult);
        
        AddResult(resultMessage);
    }

    private void AddResult(string resultMessage)
    {
        if (_testResults.First().Equals(NoTestsTakenMessage) && _testResults.Count == 1)
        {
            _testResults[0] = resultMessage;
            return;
        }

        _testResults.Add(resultMessage);
    }

    private static string BuildResultMessage(string subject, bool hasStudentPassed, int testResult)
    {
        var resultMessage = hasStudentPassed ? "Passed!" : "Failed!";

        return $"{subject}: {resultMessage} ({testResult}%)";
    }

    private static int GetTestResult(string[] markScheme, string[] answers)
    {
        int correctAnswersCount = 0;

        for (int index = 0; index < answers.Length; index++)
        {
            if (markScheme[index] == answers[index])
            {
                correctAnswersCount++;
            }
        }

        decimal percent = (correctAnswersCount * 100) / markScheme.Length;
        var result = (int)Math.Round(percent, MidpointRounding.ToEven);

        return result;
    }

    public string[] TestsTaken()
    {
        return _testResults.ToArray();
    }
}
