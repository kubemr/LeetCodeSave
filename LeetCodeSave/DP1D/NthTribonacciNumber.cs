namespace LeetCodeSave.DP1D;

public class NthTribonacciNumber //59
{
    public int Tribonacci(int n) {
        return (int)(0.5+0.336228117*Math.Pow(1.83928675521,n));
    }
}