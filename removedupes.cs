public class Solution
{

    //bad solution 

    int count = 0;
    public int RemoveDuplicates(int[] nums)
    {
        HashSet<int> found = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!found.Contains(nums[i]))
            {
                found.Add(nums[i]);
            }
        }

        foreach (int i in found)
        {
            nums[count] = i;
            count++;
        }

        return found.Count;
    }
}