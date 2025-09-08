public class Solution
{
    public bool CheckRecord(string s)
    {
        int lates = 0;
        int absents = 0;
        int curr = 0;
        bool prev = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'P')
            {
                curr = 0;
            }
            if (s[i] == 'A')
            {
                // Console.WriteLine("Hit A statement at " + s[i]);
                absents++;
                curr = 0;
            }
            else if (s[i] == 'L')
            {
                // Console.WriteLine("Hit L statement at " + s[i]);
                if (prev)
                {
                    // Console.WriteLine("In if at " + s[i]);
                    curr++;
                }
                else if (!prev)
                {
                    // Console.WriteLine("In elif at " + s[i]);
                    curr++;
                    prev = true;
                }
            }
            if (curr > lates)
            {
                lates = curr;
            }
        }

        // Console.WriteLine(absents);
        // Console.WriteLine(lates);
        return (absents < 2 && lates < 3);


    }
}