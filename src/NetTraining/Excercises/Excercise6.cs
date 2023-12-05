namespace NetTraining.Exercises;

public class Excercise6
{
    public static int LengthOfLongestSubstring(string s)
    {

        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var list = new List<char>();
        int max = 0;
        int index = 0;

        while (index < s.Length)
        {
            var letter = s[index];

            if (!list.Contains(letter))
            {
                list.Add(letter);
                index++;
            }
            else
            {
                max = Math.Max(max, list.Count);
                list.RemoveAt(0);
            }
        }

        max = Math.Max(max, list.Count);

        return max;
    }
}