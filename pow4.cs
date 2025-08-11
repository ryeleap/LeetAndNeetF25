//8/11/25

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if ((Math.Log(n) / Math.Log(4)) % 1 == 0)
        {
            return true;
        }
        return false;
    }
}