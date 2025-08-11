//8/11/25

public class Solution
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        int max = 0;
        int maxIndex = 0;
        int temp;

        for (int i = 0; i < score.Length; i++)
        {
            for (int j = i; j < score.Length; j++)
            {
                if (score[j][k] > max)
                {
                    max = score[j][k];
                    maxIndex = j;
                }
            }

            for (int j = 0; j < score[i].Length; j++)
            {
                temp = score[i][j];
                score[i][j] = score[maxIndex][j];
                score[maxIndex][j] = temp;
            }

            max = 0;
            maxIndex = 0;
        }

        return score;
    }
}