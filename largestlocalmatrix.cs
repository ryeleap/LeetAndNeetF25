public class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int localLength = grid.GetLength(0) - 2;

        int[][] localGrid = new int[localLength][];
        for (int i = 0; i < localLength; i++)
        {
            localGrid[i] = new int[localLength];
        }

        for (int i = 0; i < localLength; i++)
        {
            for (int j = 0; j < localLength; j++)
            {
                localGrid[i][j] = findMax(grid, i, j);
            }
        }

        return localGrid;
    }

    private int findMax(int[][] grid, int x, int y)
    {
        int max = 0;
        for (int i = x; i < x + 3; i++)
        {
            for (int j = y; j < y + 3; j++)
            {
                max = Math.Max(max, grid[i][j]);
            }
        }
        return max;
    }
}