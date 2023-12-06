using System.Collections;
using NetTraining.Models;

namespace NetTraining.Exercises;

public class Excercise15
{
    public void RunExcercise()
    {
        var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
        var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
        var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

        var student1 = new Student();
        var student2 = new Student();

        PrintCollection(student1.TestsTaken()); // { "No tests taken" }
        student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
        PrintCollection(student1.TestsTaken()); // { "Maths: Passed! (80%)" }

        student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
        student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
        PrintCollection(student2.TestsTaken()); // { "Chemistry: Failed! (25%)", "Computing: Failed! (43%)" };
    }

    static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
