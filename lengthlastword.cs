// Length Last Word (C# 7/15/25)

public class Solution
{
  public int LengthOfLastWord(string s)
  {
    int count = 0;
    bool flag = false;


    for (int i = s.Length - 1; i >= 0; i--)
    {
      if (!flag && Char.IsLetter(s[i]))
      {
        flag = true;
        count++;
      }
      else if (flag && !Char.IsLetter(s[i]))
      {
        return count;
      }
      else if (flag)
      {
        count++;
      }
    }
    return count;
  }
}