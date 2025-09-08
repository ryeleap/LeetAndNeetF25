// Jewels and Stones (C# 8/16/25)
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        HashSet<char> both = new HashSet<char>();
        int dupes = 0;

        for (int i = 0; i < stones.Length; i++)
        {
            if (jewels.Contains(stones[i]))
            {
                // Console.WriteLine("hit for " + stones[i]);
                if (!both.Contains(stones[i]))
                {
                    both.Add(stones[i]);
                }
                else
                {
                    dupes++;
                }
            }
        }

        return both.Count + dupes;
    }
}