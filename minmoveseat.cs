public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        int total = 0;
        Array.Sort(seats);
        Array.Sort(students);

        for (int i = 0; i < seats.Length; i++)
        {
            total += Math.Abs(seats[i] - students[i]);
        }

        return total;
    }
}