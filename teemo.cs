public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int count = 0;
        for (int i = 0; i < timeSeries.Length - 1; i++)
        {
            if (timeSeries[i] + duration > timeSeries[i + 1])
            {
                count += timeSeries[i + 1] - timeSeries[i];
            }
            else
            {
                count += duration;
            }
        }
        return count + duration;
    }
}