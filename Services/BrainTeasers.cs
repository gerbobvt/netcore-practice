using System;

public static class BrainTeasers
{
    public static int Add(int a, int b)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(a, 0);
        ArgumentOutOfRangeException.ThrowIfLessThan(b, 0);

        while (b > 0)
        {
            a++;
            b--;
        }

        return a;
    }

    public static int FancyAdd(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}