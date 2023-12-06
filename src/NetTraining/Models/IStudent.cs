namespace NetTraining.Models;

public interface IStudent
{
    string[] TestsTaken();
    
    void TakeTest(ITestpaper paper, string[] answers);
}
