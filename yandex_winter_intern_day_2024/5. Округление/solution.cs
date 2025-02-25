using System;
using System.Linq;


// 1. If the current sum is less than x, then we need to increase some c_i. 
// We choose the numbers with the largest fractional part and increase them by 1.
// 2. If the current sum is greater than x, then we need to decrease some c_i. 
// We choose the numbers with the smallest fractional part and decrease them by 1.

class Program 
{
    public static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split();
        int n = int.Parse(line1[0]);
        long x = int.Parse(line1[1]);

        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long totalA = a.Sum(e => (long)e);

        double[] b = a.Select(ai => (double)(x * ai) / totalA).ToArray();

        long[] c = b.Select(bi => (long)bi).ToArray();

        long currentSum = c.Sum();
        long diff = x - currentSum;

        if (diff == 0)
        {
            Console.WriteLine(string.Join(" ", c));
            return;
        }

        int[] indices;

        if (diff > 0)
            indices = Enumerable.Range(0, n).OrderByDescending(i => b[i] - c[i]).ToArray();
        else
            indices = Enumerable.Range(0, n).OrderBy(i => b[i] - c[i]).ToArray();

        for (long i = 0; i < Math.Abs(diff); i++)
        {
            if (diff > 0)
                c[indices[i]]++;
            else
                c[indices[i]]--;
        }

        Console.WriteLine(string.Join(" ", c));
    }
}