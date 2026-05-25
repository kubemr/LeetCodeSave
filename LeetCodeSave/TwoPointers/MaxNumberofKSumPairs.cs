namespace LeetCodeSave.TwoPointers;

public class MaxNumberofKSumPairs
{
    public static string ExecuteSolution(int[] nums, int k)
    {
        Console.WriteLine("13: Max Number of K-Sum Pairs");
        Console.Write("Array: [");
        foreach (var num in nums)
        {
            Console.Write(num + "; ");
        }
        Console.WriteLine("]");
        Console.WriteLine($"Integer: {k}");

        int result = MaxOperations(nums, k);
        return result.ToString();
    }

    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int ans = 0;
        int i = 0, j = nums.Length - 1;
        while (i < j) {
            int temp = nums[i] + nums[j];
            if (temp == k) {
                i++;
                j--;
                ans++;
                continue;
            } 
            if (temp > k) 
            {
                j--;
            } 
            else 
            {
                i++;
            }
        }
        return ans;
    }
}