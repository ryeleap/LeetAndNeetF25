//8/7/25

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> arrNums = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (arrNums.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                arrNums.Add(nums[i], 1);
            }
        }
        return false;
    }
}