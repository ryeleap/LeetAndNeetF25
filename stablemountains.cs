public class Solution
{
    public IList<int> StableMountains(int[] height, int threshold)
    {
        List<int> final = new List<int>();
        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
            {
                final.Add(i);
            }
        }

        return final.ToArray();
    }
}