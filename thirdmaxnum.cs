public class Solution
{
    public int ThirdMax(int[] nums)
    {
        long first = -2147483649;
        long second = -2147483649;
        long third = -2147483649;

        if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > first)
            {
                third = second;
                second = first;
                first = nums[i];
            }
            else if (nums[i] < first && nums[i] > second)
            {
                third = second;
                second = nums[i];
            }
            else if (nums[i] < second && nums[i] > third)
            {
                third = nums[i];
            }
            // Console.WriteLine("First is " + first + ", Second is " + second + ", Third is " + third);
        }

        if (third == -2147483649)
        {
            return (int)first;
        }
        return (int)third;

    }
}