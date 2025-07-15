// Valid Word (C# 7/14/25)


public class Solution
{
  public bool IsValid(string word)
  {
    int count = 0;
    bool cons = false;
    bool vow = false;
    string vowels = "aeiouAEIOU";

    for (int i = 0; i < word.Length; i++)
    {
      if (!Char.IsLetter(word[i]) && !Char.IsNumber(word[i]))
      {
        return false;
      }
      else if (Char.IsLetter(word[i]))
      {
        if (vowels.IndexOf(word[i]) == -1)
        {
          Console.WriteLine("(cons) Hit on " + word[i]);
          cons = true;
        }
        else
        {
          Console.WriteLine("(vow) Hit on " + word[i]);
          vow = true;
        }
      }
      count++;
    }

    if ((cons && vow) && count >= 3)
    {
      return true;
    }
    return false;
  }
}