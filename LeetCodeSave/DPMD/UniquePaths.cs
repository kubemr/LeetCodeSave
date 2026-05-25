namespace LeetCodeSave.DPMD;

public class UniquePaths //63
{
    public int UniquePathsA(int m, int n) {
        long result = 1;
        for (int i = 1; i < m; i++) {
            result *= n + i - 1;
            result /= i;
        }
        return (int)result;
    }
}