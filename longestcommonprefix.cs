// Longest Common Prefix (C# 7/15/25)

public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    char current;
    string prefix = "";

    int minStr = strs.Min(y => y.Length);

    for (int i = 0; i < minStr; i++)
    {
      current = (strs[0])[i];
      for (int j = 0; j < strs.Length; j++)
      {
        if ((strs[j])[i] != current)
        {
          return prefix;
        }
      }
      prefix += (strs[0])[i];
    }
    return prefix;
  }
}