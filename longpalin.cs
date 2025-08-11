//8/8/25

public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> inv = new Dictionary<char, int>();
        int maxLength = 0;
        int longestOdd = 0;
        bool oddFlag = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (inv.ContainsKey(s[i]))
            {
                // Console.WriteLine("Value incremented for " + s[i]);
                inv[s[i]]++;
            }
            else
            {
                // Console.WriteLine("Value instantiated for " + s[i]);
                inv.Add(s[i], 1);
            }
        }

        foreach (KeyValuePair<char, int> kvp in inv)
        {
            // Console.WriteLine("What the freak");
            if (kvp.Value % 2 == 0)
            {
                maxLength += kvp.Value;
            }
            else
            {
                oddFlag = true;
                maxLength += kvp.Value - 1;
                // if(kvp.Value > longestOdd){
                //     longestOdd = kvp.Value;
                // }
            }
        }

        // Console.WriteLine("Max length before odd is " + maxLength);
        // Console.WriteLine("Longest odd is " + longestOdd);
        if (oddFlag)
        {
            return maxLength + 1;
        }
        return maxLength;
    }
}