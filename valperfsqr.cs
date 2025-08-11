//7/31/2025


public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        if (num == 1)
        {
            return true;
        }

        long left = 2;
        long right = Int32.MaxValue;
        while (left <= right)
        {
            long middle = (left + right) / 2;
            Console.WriteLine("middle " + middle);

            if (middle * middle > num)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }

            Console.WriteLine("left " + left);
            Console.WriteLine("right " + right);
        }

        Console.WriteLine(right);
        if (right * right == num)
        {
            return true;
        }
        return false;
    }
}