namespace LeetCodeSave.TwoPointers;

public class IsSubsequence
{
    public static string ExecuteSolution(string s, string t)
    {
        Console.WriteLine("11: Is Subsequence");
        Console.WriteLine("1st string (Substring): " + s);
        Console.WriteLine("2nd string: " + t);

        return IsSubsequenceA(s, t).ToString();
    }

    public static bool IsSubsequenceA(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) i++;
            j++;
        }
        return i == s.Length;
    }
}