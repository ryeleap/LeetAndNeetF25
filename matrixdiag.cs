public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;


        for (int i = 0; i < mat.GetLength(0); i++)
        {
            if (i == mat.GetLength(0) - i - 1)
            {
                sum += mat[i][i];
            }
            else
            {
                sum += mat[i][i];
                sum += mat[i][mat.GetLength(0) - i - 1];
            }
        }

        return sum;
    }
}