public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int low = weights.Max();
        int high = weights.Sum();

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            int currentWeight = 0;
            int requiredDays = 1;

            foreach (int weight in weights)
            {
                if (currentWeight + weight <= mid)
                {
                    currentWeight += weight;
                }
                else
                {
                    requiredDays++;
                    currentWeight = weight;
                }
            }

            if (requiredDays <= days)
                high = mid;
            else
                low = mid + 1;
        }

        return low;
    }
}