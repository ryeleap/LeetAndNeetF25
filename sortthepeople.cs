public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        for (int i = 0; i < names.Length; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < names.Length; j++)
            {
                if (heights[j] > heights[maxIndex])
                {
                    maxIndex = j;
                }
            }
            int tempHeight = heights[i];
            heights[i] = heights[maxIndex];
            heights[maxIndex] = tempHeight;

            string tempName = names[i];
            names[i] = names[maxIndex];
            names[maxIndex] = tempName;
        }
        return names;
    }
}