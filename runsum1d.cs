// 8/13/25

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int currSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currSum += nums[i];
            nums[i] = currSum;
        }

        return nums;
    }
}