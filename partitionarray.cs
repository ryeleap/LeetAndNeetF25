//8/4/25

public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {

        //Awful solution, come back
        ArrayList arrList = new ArrayList();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                arrList.Add(nums[i]);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == pivot)
            {
                arrList.Add(nums[i]);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > pivot)
            {
                arrList.Add(nums[i]);
            }
        }

        int[] finalArray = arrList.Cast<int>().ToArray();
        return finalArray;
    }
}