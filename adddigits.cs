// Add Digits (C# 7/31/25)

public class Solution
{
    public int AddDigits(int num)
    {
        int currNum = num;
        int currResult = 0;
        int length = (num.ToString()).Length;


        for (int i = length - 1; i >= 0; i--)
        {
            currResult += currNum % 10;
            currNum = currNum / 10;
            // Console.WriteLine("currNum = " + currNum);
            // Console.WriteLine("currResult = " + currResult);
        }

        if (currResult >= 0 && currResult < 10)
        {
            return currResult;
        }
        else
        {
            // Console.WriteLine("Recursing with " + currResult);
            return AddDigits(currResult);
        }
    }
}