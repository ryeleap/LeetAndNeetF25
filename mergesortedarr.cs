public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int count = 0;
        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[count];
            count++;
        }

        Array.Sort(nums1);
        return;
    }
}