// Check If Two String Arrays are Equivalent (C# 8/14/25)

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string word1str = "";
        string word2str = "";

        for (int i = 0; i < word1.Length; i++)
        {
            word1str += word1[i]; ;
        }

        for (int i = 0; i < word2.Length; i++)
        {
            word2str += word2[i];
        }

        return word1str.Equals(word2str);
    }
}