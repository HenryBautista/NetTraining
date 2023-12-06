namespace NetTraining.Exercises;

public class Excercise12
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var sortedSet = new SortedSet<string>(strs);
        var smallestText = sortedSet.First();
        var prefix = string.Empty;

        for (int index = 0; index < smallestText.Length; index++)
        {
            prefix = smallestText[..(index + 1)];
            var findings = sortedSet.Where(text => text.Contains(prefix));

            if (findings.Count() != sortedSet.Count)
            {
                prefix = prefix.Length == 1 ? string.Empty : prefix[..^1];
                break;
            }
        }

        return prefix;
    }
}
