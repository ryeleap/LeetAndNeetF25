public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int count = 0;
        double curr = 0;
        double avg = 0;

        for (int i = 0; i < k; i++)
        {
            curr += nums[i];
        }
        avg = curr / k;

        while (k + count < nums.Length)
        {
            curr += nums[k + count] - nums[count];
            count++;
            avg = curr / k > avg ? curr / k : avg;
        }

        return avg;

    }
}