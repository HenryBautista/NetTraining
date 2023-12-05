using System.Text;

namespace NetTraining.Exercises;

public class Excercise7
{
    public static string Uncensor(string txt, string vowels)
    {
        StringBuilder builder;

        foreach (var vowel in vowels)
        {
            builder = new StringBuilder(txt);
            var position = txt.IndexOf('*');
            builder[position] = vowel;
            txt = builder.ToString();
        }

        return txt;
    }
}
