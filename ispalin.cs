public class Solution
{
  public bool IsPalindrome(string s)
  {
    string trimmedString = s.Trim();
    for (int i = 0; i < s.Length; i++)
    {
      if (!Char.IsLetter(s[i]) && !Char.IsNumber(s[i]))
      {
        trimmedString = trimmedString.Replace(s[i].ToString(), "");
      }
    }

    trimmedString = trimmedString.ToLower();

    char[] sArr = trimmedString.ToCharArray();
    char[] rsArr = trimmedString.ToCharArray();
    Array.Reverse(rsArr);
    Console.Write(sArr);
    Console.Write(rsArr);
    return sArr.SequenceEqual(rsArr);
  }
}
