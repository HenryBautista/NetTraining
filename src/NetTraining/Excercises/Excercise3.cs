namespace NetTraining.Exercises;

public class Excercise3
{
    public static int Solution(int value)
    {

        int result = 0;

        if (value < 0)
        {
            return 0;
        }

        for (int index = 3; index < value; index++)
        {
            if (index % 3 == 0)
            {
                result += index;
                continue;
            }

            if (index % 5 == 0)
            {
                result += index;
            }
        }

        return result;
    }
}