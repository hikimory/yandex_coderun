using System;
using System.Collections.Generic;
using System.Linq;

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

    static string CanonicalRepresentation(long a, long b, long c)
    {
        long[] sides = { a, b, c };
        Array.Sort(sides);
        long commonGCD = GCD(GCD(sides[0], sides[1]), sides[2]);
        return $"{sides[0]/commonGCD}-{sides[1]/commonGCD}-{sides[2]/commonGCD}";
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> classes = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {   
            string[] parts = Console.ReadLine().Split();
            long a = long.Parse(parts[0]);
            long b = long.Parse(parts[1]);
            long c = long.Parse(parts[2]);
            
            string repr = CanonicalRepresentation(a, b, c);
            classes.Add(repr);
        }
        Console.WriteLine(classes.Count);
    }
}