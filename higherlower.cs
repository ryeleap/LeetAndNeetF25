//8/4/25

/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        long left = 1;
        long right = n;
        long currNum = -1;
        long middle;

        while (left <= right)
        {
            middle = (left + right) / 2;
            Console.WriteLine("middle is: " + middle);

            currNum = guess((int)middle);
            Console.WriteLine("currNum is: " + currNum);
            if (currNum == 0)
            {
                return (int)middle;
            }
            if (currNum > 0)
            {
                left = middle + 1;
            }
            else if (currNum < 0)
            {
                right = middle - 1;
            }
        }
        return -1;
    }
}