public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {

        int[] firstRow = new int[points.Length];
        int currMax = 0;

        for (int i = 0; i < points.Length; i++)
        {
            // Console.WriteLine("points at i is: " + points[i][0]);
            firstRow[i] = points[i][0];
        }
        Array.Sort(firstRow);

        for (int i = 0; i < firstRow.Length - 1; i++)
        {
            if (currMax < firstRow[i + 1] - firstRow[i])
            {
                currMax = firstRow[i + 1] - firstRow[i];
            }
        }

        return currMax;
    }
}