namespace NetTraining.Exercises;

public class Excercise13
{
    public static string Interview(int[] arr, int tot)
    {
        const int maximumTotalTime = 120;
        const string qualified = "qualified";
        const string disqualified = "disqualified";
        var perfectScore = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };

        if (tot > maximumTotalTime)
        {
            return disqualified;
        }

        if (arr.Length < perfectScore.Length)
        {
            return disqualified;
        }

        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] > perfectScore[index])
            {
                return disqualified;
            }
        }

        return qualified;
    }
}
