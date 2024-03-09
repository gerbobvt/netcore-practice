using System;

public static class BrainTeasers
{
    public static int Add(int a, int b)
    {
        // Neither input can be negative
        if (a < 0)
        {
            throw new ArgumentException(nameof(a));
        }
        if (b < 0)
        {
            throw new ArgumentException(nameof(b));
        }

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