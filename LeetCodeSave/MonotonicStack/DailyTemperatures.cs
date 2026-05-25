namespace LeetCodeSave.MonotonicStack;

public class DailyTemperatures //74
{
    public int[] DailyTemperaturesA(int[] temperatures) {
        int[] stack = new int[100000];
        int[] answer = new int[temperatures.Length];
        int i = 1;
        int top = 1;
        while (i < temperatures.Length) {
            if (top > 0 && temperatures[stack[top - 1]] < temperatures[i]) {
                answer[stack[top - 1]] = i - stack[--top];
            } else {
                stack[top++] = i++;
            }
        }
        return answer;
    }
}