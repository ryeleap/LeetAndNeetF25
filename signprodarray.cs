//8/10/25

public class Solution
{
    public int ArraySign(int[] nums)
    {
        int result = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
            }
            else if (nums[i] < 0)
            {
                result *= -1;
            }
            else
            {
                return 0;
            }

        }


        return result;
    }
}