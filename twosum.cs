// Two Sum (C# 7/14/25)

public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    for (int i = 0; i < nums.Length; i++)
    {
      for (int j = 0; j < nums.Length; j++)
      {
        if ((nums[i] + nums[j] == target) && (i != j))
        {
          int[] targetIndicesArray = [i, j];
          Console.Write(targetIndicesArray);
          return targetIndicesArray;
        }
      }
    }
    return [0];
  }
}