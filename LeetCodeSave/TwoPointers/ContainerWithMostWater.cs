namespace LeetCodeSave.TwoPointers;

public class ContainerWithMostWater
{
    public static string ExecuteSolution(int[] nums)
    {
        Console.WriteLine("12: Container With Most Water");
        Console.Write("Array: [");
        foreach (var num in nums)
        {
            Console.Write(num + "; ");
        }
        Console.WriteLine("]");


        int result = MaxArea(nums);
        return result.ToString();
    }

    public static int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, maxArea = 0;
        while (left < right) {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));
            if (height[left] < height[right]) left++;
            else right--;
        }
        return maxArea;
    }
}