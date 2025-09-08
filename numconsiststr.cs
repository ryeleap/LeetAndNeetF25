// Count Consistent Strings (C# 8/16/25)
public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        HashSet<char> chars = new HashSet<char>();
        int count = 0;
        bool flag = true;

        for (int i = 0; i < allowed.Length; i++)
        {
            if (!chars.Contains(allowed[i]))
            {
                chars.Add(allowed[i]);
            }
        }

        // foreach (char chara in chars)
        // {
        //     Console.WriteLine(chara);
        // }        

        for (int j = 0; j < words.Length; j++)
        {
            for (int k = 0; k < words[j].Length; k++)
            {
                // Console.WriteLine((words[j])[k]);
                if (!chars.Contains((words[j])[k]))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                count++;
            }
            flag = true;
        }

        return count;
    }
}