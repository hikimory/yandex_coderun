using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] sellers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] buyers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(sellers);
        Array.Sort(buyers);

        long profit = 0;
        int sellerIdx = 0;
        int buyerIdx = m - 1;

        while (sellerIdx < n && buyerIdx >= 0)
        {
            if (buyers[buyerIdx] > sellers[sellerIdx])
            {
                profit += (long)buyers[buyerIdx] - sellers[sellerIdx];
                sellerIdx++;
                buyerIdx--;
            }
            else
            {
                buyerIdx--;
            }
        }

        Console.WriteLine(profit);
    }
}

