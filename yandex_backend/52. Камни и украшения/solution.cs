using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        string j = Console.ReadLine();
        string s = Console.ReadLine();

        HashSet<char> jewelrySet = new HashSet<char>(j);
        int count = 0;

        foreach (char c in s)
        {
            if (jewelrySet.Contains(c))
                count++;
        }

        Console.WriteLine(count);
    }
}