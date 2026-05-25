namespace LeetCodeSave.TwoPointers;

public class MoveZeroes
{ 
    //10: Move Zeroes
    public static void MoveZeroesA(int[] nums)
    {
        int nonZeroIndex = 0;
        int finalIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nonZeroIndex] = nums[i];
                nonZeroIndex++;
            }
            finalIndex = i;
        }
        for (int i = finalIndex; i >= nonZeroIndex; i--)
        {
            nums[i] = 0;
        }
        
        Console.Write("[");
        foreach (var num in nums)
        {
            Console.Write(num + "; ");
        }
        Console.WriteLine("]");
    }
}