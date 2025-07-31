// Is Majority (C# 7/31/25)

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> numCountMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numCountMap.ContainsKey(nums[i]))
            {
                numCountMap[nums[i]]++;
                Console.WriteLine("curr value for " + nums[i] + " is " + numCountMap[nums[i]]);
            }
            else
            {
                numCountMap[nums[i]] = 1;
            }

            if (numCountMap[nums[i]] > nums.Length / 2)
            {
                return nums[i];
            }
        }
        return 0;
    }
}