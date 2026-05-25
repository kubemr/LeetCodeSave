namespace LeetCodeSave.BitManipulation;

public class MinimumFlipstoMakeaORbEqualtoc //69
{
    public int MinFlips(int a, int b, int c) 
    {
        int flips = 0;
        int or = a | b;
        int xor = c ^ or;
        flips = this.BitCount(xor);
        int dblcount = xor & a & b;
        flips += this.BitCount(dblcount);

        return flips;
    }
    public int BitCount(int x) 
    {
        int count = 0;
        while (x > 0){
            count++;
            x &= (x - 1);
        }
        return count;
    }
}