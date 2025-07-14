// Is Valid Palindrom (C# 7/14/25)

public class Solution
{
  public bool IsPalindrome(string s)
  {
    char[] punctuation = { '*', '!', '@', '#', ' ', '.', '?', ',' };
    string trimmedString = s.Trim(punctuation);
    trimmedString = trimmedString.Replace(" ", "");
    trimmedString = trimmedString.Replace("'", "");
    trimmedString = trimmedString.Replace(",", "");
    trimmedString = trimmedString.Replace(":", "");
    trimmedString = trimmedString.ToLower();

    char[] sArr = trimmedString.ToCharArray();
    char[] rsArr = trimmedString.ToCharArray();
    Array.Reverse(rsArr);
    Console.Write(sArr);
    Console.Write(rsArr);
    return sArr.SequenceEqual(rsArr);
  }
}
