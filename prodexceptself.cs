public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prod = new int[nums.Length];
        int right = 1;

        prod[0] = 1;
        for (int i = 1; i < prod.Length; i++)
        {
            // Console.WriteLine(prod[i - 1]);
            // Console.WriteLine(nums[i - 1]);
            // Console.WriteLine(prod[i - 1] * nums[i - 1]);
            prod[i] = prod[i - 1] * nums[i - 1];
        }

        // foreach(int element in prod){
        //     Console.WriteLine(element);
        // }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            prod[i] *= right;
            right *= nums[i];
        }

        return prod;
    }
}