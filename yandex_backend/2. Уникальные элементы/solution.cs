using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        a.Sort();

        int count = 0;
        int i = 0;
        while (i < n)
        {
            int j = i;
            while (j < n && a[i] == a[j])
            {
                j++;
            }
            if (j - i == 1)
            {
                count++;
            }
            i = j;
        }
        
        Console.WriteLine(count);
    }
}