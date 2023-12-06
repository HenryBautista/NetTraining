namespace NetTraining.Exercises;

public class Excercise11
{
    public static int MaxSequence(int[] arr)
    {
        int index = 0;
        int maximunSum = 0;

        int currentSum = 0;
        int pointer = 0;

        while (index < arr.Length)
        {
            pointer++;

            if (pointer >= arr.Length)
            {
                break;
            }

            if (currentSum > arr[index] + arr[pointer])
            {
                maximunSum = Math.Max(maximunSum, currentSum);
                index++;
                pointer = index;
            }
            else
            {
                currentSum = arr[index] + arr[pointer];
            }
        }

        return maximunSum;
    }
}
