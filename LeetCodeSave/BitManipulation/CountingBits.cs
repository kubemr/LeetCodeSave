namespace LeetCodeSave.BitManipulation;

public class CountingBits //67
{
    public int[] CountBits(int n) 
    {
        int[] ans = new int[n+1];
        for (int i =0; i<=n;i++){
            ans[i] = ans[i >> 1]+(i&1);
        }
        return ans;
    }
}