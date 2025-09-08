public class Solution
{
    public int SumOfMultiples(int n)
    {
        int currNum = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
            {
                currNum += i;
            }
        }

        return currNum;
    }
}