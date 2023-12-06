namespace NetTraining.Exercises;

public class Excercise9
{
    public static bool AlmostPalindrome(string str)
    {
        var halfSize = str.Length / 2;
        var isPair = str.Length % 2 == 0;
        var secondHalfStart = isPair
            ? halfSize
            : halfSize + 1;


        var firstHalf = str[0..halfSize];
        var secondHalf = str[secondHalfStart..str.Length];

        // Old Approach to work on outdatedMono
        //var firstHalf = str.Substring(0, halfSize);
        //var secondHalf = str.Substring(secondHalfStart, str.Length-secondHalfStart);
        //secondHalf = ReverseString(secondHalf);

        secondHalf = string.Join("", secondHalf.Reverse());
        int counter = 0;

        for (int index = 0; index < halfSize; index++)
        {
            if (firstHalf[index] != secondHalf[index])
            {
                counter++;
            }
        }

        Console.WriteLine(counter);

        if (counter != 1)
        {
            return false;
        }

        return true;
    }

    // Old Approach to work on outdated Mono
    // static string ReverseString(string text)
    // {
    //     var charArray = text.ToCharArray();
    //     Array.Reverse(charArray);

    //     return new string(charArray);
    // }
}
