using System;
using System.Linq;

class Program 
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int t = int.Parse(firstLine[1]);
        int s = int.Parse(firstLine[2]);

        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] less_v = v.Skip(1).Where(e => e < v[0]).ToArray();
        int l = less_v.Length;

        if (l == 0)
        {
            Console.WriteLine(0);
            return;
        }

        long total_overtakes = 0;

        for (int i = 0; i < l; i++)
        {
            long v_relative = (long)v[0] - less_v[i]; 
            long s1 = (long)v[0] * t;
            long s_i = (long)less_v[i] * t;
            long overtakes = (long)((double)v_relative * t / s);

            if ((s1 - s_i - s) % s == 0)
               total_overtakes += overtakes - 1;
            else
               total_overtakes += overtakes;
        }
        Console.WriteLine(total_overtakes);
    }
}