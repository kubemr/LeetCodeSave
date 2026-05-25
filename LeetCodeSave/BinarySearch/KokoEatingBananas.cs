namespace LeetCodeSave.BinarySearch;

public class KokoEatingBananas //56
{
    long FindHours(int[] piles, int speed) {
        long totalHours = 0;
        foreach (int p in piles) {
            if (p % speed == 0)
                totalHours += p / speed;
            else
                totalHours += (p / speed) + 1;
        }
        return totalHours;
    }

    int FindMax(int[] piles) {
        int maxElement = 0;
        foreach (int p in piles)
            maxElement = Math.Max(maxElement, p);
        return maxElement;
    }

    public int MinEatingSpeed(int[] piles, int h) {
        int maxPiles = FindMax(piles);
        int low = 1, high = maxPiles, minSpeed = maxPiles;

        while (low <= high) {
            int mid = (low + high) / 2;
            long checkHours = FindHours(piles, mid);
            if (checkHours <= h) {
                minSpeed = mid;
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return minSpeed;
    }
}