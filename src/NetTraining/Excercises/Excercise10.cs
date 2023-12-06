namespace NetTraining.Exercises;

public class Excercise10
{
    public static double[] Tribonacci(double[] signature, int n)
    {
        var positionA = signature[0];
        var positionB = signature[1];
        var positionC = signature[2];

        var result = new double[n];

        result[0] = positionA;
        result[1] = positionB;
        result[2] = positionC;

        for (int index = 3; index < n; index++)
        {
            result[index] = positionA + positionB + positionC;
            positionA = positionB;
            positionB = positionC;
            positionC = result[index];
        }

        return result;
    }
}
