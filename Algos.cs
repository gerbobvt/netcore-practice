using System;
using System.Collections;
using System.Linq;

namespace Gerbob.Training;

public interface IAlgos
{
    public int MaxOf3(int a, int b, int c);

    public ICollection<int> GetPrimesLessThan(int size);
}

public class Algos : IAlgos
{
    public int MaxOf3(int a, int b, int c)  
    {
        int abMax = MaxOf2(ref a , ref b);
        return MaxOf2(ref abMax, ref c);
    }

    public ICollection<int> GetPrimesLessThan(int size)
    {
        var bits = new BitArray(size + 1, true);
        bits[0] = false;
        bits[1] = false;

        foreach(var test in Enumerable.Range(2, size / 2))
        {
            if (bits[test]) {
                for (int index = test + test; index <= size; index += test)
                {
                    bits[index] = false;
                }
            }
        }

        var primes = new List<int>();
        for(int primeIndex = 2; primeIndex < size + 1; primeIndex++)
        {
            if (bits[primeIndex]) primes.Add(primeIndex);
        }
        return primes;
    }

    private int MaxOf2(ref int a, ref int b) => a >= b ?  a : b;
    
}