public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> chars = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (!chars.ContainsKey(magazine[i]))
            {
                chars.Add(magazine[i], 1);
            }
            else
            {
                chars[magazine[i]] = chars[magazine[i]] + 1;
            }
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (chars.ContainsKey(ransomNote[i]) && chars[ransomNote[i]] != 0)
            {
                chars[ransomNote[i]] = chars[ransomNote[i]] - 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}