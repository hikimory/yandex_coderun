using System;
using System.Collections.Generic;

class Program
{
    static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static long LCM(long a, long b)
    {
        return (a / GCD(a, b)) * b; // for long
    }

    static void FindDivisors(long n, ref List<long> divisors)
    {
        for (long i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
                if (i != n / i)
                    divisors.Add(n / i);
            }
        }
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long x = long.Parse(input[0]);
        long y = long.Parse(input[1]);

        if (y % x != 0)
        {
            Console.WriteLine(0);
            return;
        }

        long z = y / x;
        var divisors = new List<long>();
        FindDivisors(z, ref divisors);

        int count = 0;

        foreach (long d in divisors)
        {
            long p = x * d;
            long q = y / d;

            // GCD(p, q) = x and LCM(p, q) = y
            if (GCD(p, q) == x && LCM(p, q) == y)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }

    //`z = y/x`, тогда `x* z = y`. `z` делится на `d`. 
    //`q = y/d`, то `p* q = x * d * y / d = x * y`, а так же `y` всегда кратно `p` (по условию).
}
    