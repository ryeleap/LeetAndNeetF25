public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] ansArr = new int[nums.Length];
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] > nums[j])
                {
                    count++;
                }
            }
            ansArr[i] = count;
            count = 0;
        }

        return ansArr;
    }
}