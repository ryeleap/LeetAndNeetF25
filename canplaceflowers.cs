public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;

        if (flowerbed.Length == 0 || (flowerbed.Length == 1 && flowerbed[0] == 0))
        {
            return true;
        }
        else if (flowerbed.Length == 1 && flowerbed[0] == 1)
        {
            return false;
        }

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0)
            {
                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                    flowerbed[i] = 1;
                count++;
            }
            else if (i == flowerbed.Length - 1)
            {
                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
                    flowerbed[i] = 1;
                count++;
            }
            else
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
        }

        Console.WriteLine(count);
        return count >= n;

    }

    CanPlaceFlowers([1,0,0,0,1]);

}