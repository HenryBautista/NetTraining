using System.Text;

namespace NetTraining.Exercises;

public class Excercise1
{
  public static string AlphabetPosition(string text)
  {
    var builder = new StringBuilder();
    
    foreach(char letter in text)
    {
      if (!char.IsLetter(letter))
      {
        continue;
      }
      
      int position = char.ToUpper(letter) - 64;
      
      builder.Append(position+" ");
    }
    
    return builder.ToString().Trim();
  }
}
