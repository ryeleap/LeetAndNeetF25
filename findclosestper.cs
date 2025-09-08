public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        if (Math.Abs(x - z) == Math.Abs(y - z))
        {
            return 0;
        }
        else
        {
            return Math.Abs(y - z) > Math.Abs(x - z) ? 1 : 2;
        }
    }
}