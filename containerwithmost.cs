public class Solution
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left <= right)
        {
            int curr = Math.Min(height[left], height[right]) * (right - left);
            max = max > curr ? max : curr;
            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return max;
    }
}