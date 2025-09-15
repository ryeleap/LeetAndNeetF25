// 9/11/25
public class Solution
{
    public int Compress(char[] chars)
    {
        int left = 0;
        int right = 0;
        int write = 0;

        while (right < chars.Length)
        {
            char curr = chars[right];
            left = right;

            while (right < chars.Length && chars[right] == curr)
            {
                right++;
            }

            int count = right - left;
            chars[write] = curr;
            write++;

            if (count > 1)
            {
                string num = count.ToString();
                int index = 0;
                while (index < num.Length)
                {
                    chars[write] = num[index];
                    write++;
                    index++;
                }
            }
        }

        return write;
    }
}
