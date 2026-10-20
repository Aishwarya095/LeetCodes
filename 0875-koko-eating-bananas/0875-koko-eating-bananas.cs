public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1;
        int high = piles.Max();

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            long hours = 0;

            foreach (int pile in piles)
            {
                hours += (pile + (long)mid - 1) / mid;
            }

            if (hours <= h)
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}