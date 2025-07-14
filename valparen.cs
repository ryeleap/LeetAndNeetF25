// Contains Valid Parenthesis (C# 7/14/25)

public class Solution
{
  public bool IsValid(string s)
  {
    Stack<char> pStack = new Stack<char>();
    String delim = "({[";
    char curPop;
    for (int i = 0; i < s.Length; i++)
    {
      if (delim.IndexOf(s[i]) != -1)
      {
        pStack.Push(s[i]);
      }
      else
      {
        if (pStack.Any())
        {
          curPop = pStack.Pop();
        }
        else
        {
          return false;
        }
        if (curPop == '{' && s[i] != '}')
        {
          return false;
        }
        else if (curPop == '(' && s[i] != ')')
        {
          return false;
        }
        else if (curPop == '[' && s[i] != ']')
        {
          return false;
        }
      }
    }
    if (pStack.Any())
    {
      return false;
    }
    return true;
  }
}