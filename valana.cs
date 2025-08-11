//8/9/25

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        string sorteds = new string(sArr);
        string sortedt = new string(tArr);

        return (sorteds.Equals(sortedt));
    }
}