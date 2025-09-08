public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int currIndex = word.IndexOf(ch);

        // Console.WriteLine(currIndex);
        char[] charArray = word.ToCharArray();
        char temp;

        for (int i = 0; i < (currIndex + 1) / 2; i++)
        {
            temp = charArray[currIndex - i];
            charArray[currIndex - i] = charArray[i];
            charArray[i] = temp;
        }

        string finStr = new string(charArray);
        return finStr;
    }
}