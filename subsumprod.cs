// 8/13/25

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        string sN = n.ToString();
        int sum = 0;
        int product = 1;

        for (int i = 0; i < sN.Length; i++)
        {
            // Console.WriteLine("Curr value is " + sN[i]);
            sum += (int)Char.GetNumericValue(sN[i]);
            product *= (int)Char.GetNumericValue(sN[i]);

            // Console.WriteLine("Sum is " + sum);
            // Console.WriteLine("Product is " + product);
        }

        return product - sum;
    }
}