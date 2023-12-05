namespace NetTraining.Exercises;

public class Excercise5
{
    public static int DuplicateCount(string str)
    {
        var set = new HashSet<char>();
        var exceptionsSet = new HashSet<char>();

        foreach (var letter in str.ToUpper())
        {
            if (!set.Add(letter))
            {
                exceptionsSet.Add(letter);
            }
        }

        return exceptionsSet.Count;
    }
}