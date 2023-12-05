namespace NetTraining.Exercises;

public class Excercise4
{
    public static string ToCamelCase(string str)
    {
        var words = str.Split(new char[2]{'-', '_'});

        for (int index = 0; index < words.Length; index++)
        {
            if (index == 0 )
            {
                continue;
            }

            if (words[index].Length <= 1)
            {
            words[index] = words[index].ToUpper();
            continue;
            }

            words[index] = CapitalizeText(words[index]);
        }

        return string.Join("", words);
    }

    private static string CapitalizeText(string text)
    {
        return string.Concat(
                char.ToUpper(text[0]),
                text[1..]);
    }
}
