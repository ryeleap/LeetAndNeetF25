// Valid Anagram (C# 7/14/25)

public class Solution
{
  public bool IsAnagram(string s, string t)
  {
    char[] sChar = s.ToCharArray();
    char[] tChar = t.ToCharArray();
    Array.Sort(sChar);
    Array.Sort(tChar);
    Console.Write(sChar);
    Console.Write(tChar);

    if (sChar.SequenceEqual(tChar))
    {
      return true;
    }
    return false;
  }
}
