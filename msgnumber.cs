//7/31/25
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        Console.WriteLine(nums.Length);
        for (int i = 0; i <= nums.Length; i++)
        {
            if (!nums.Contains(i))
            {
                return i;
            }
        }
        return 0;
    }
}