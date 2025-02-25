using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string c_str = Console.ReadLine();
        HashSet<char> c = new HashSet<char>(c_str.ToCharArray());
        int n = s.Length;
        int minLen = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                string sub = s.Substring(i, j - i + 1);
                HashSet<char> subSet = new HashSet<char>(sub.ToCharArray());
                if (subSet.SetEquals(c))
                {
                    minLen = Math.Min(minLen, sub.Length);
                }
            }
        }

        if (minLen == int.MaxValue)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(minLen);
        }
    }
}