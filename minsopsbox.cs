public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int currSum = 0;
        char[] boxesArray = boxes.ToCharArray();
        int[] intArray = new int[boxesArray.Length];

        for (int i = 0; i < boxesArray.Length; i++)
        {
            intArray[i] = Convert.ToInt32(boxesArray[i].ToString());
        }

        HashSet<int> boxNumbers = new HashSet<int>();

        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == 1)
            {
                boxNumbers.Add(i);
            }
        }

        for (int j = 0; j < intArray.Length; j++)
        {
            foreach (int i in boxNumbers)
            {
                if (i != j)
                {
                    currSum += Math.Abs(j - i);
                }
            }
            intArray[j] = currSum;
            currSum = 0;
        }

        return intArray;
    }
}