using System;
using System.Linq;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        int n = int.Parse(Console.ReadLine());
        int[] candies = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(candies);

        long[] prefixSum = new long[n];
        prefixSum[0] = candies[0];
        for (int i = 1; i < n; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + candies[i];
        }

        long[] suffixSum = new long[n];
        suffixSum[n - 1] = candies[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            suffixSum[i] = suffixSum[i + 1] + candies[i];
        }

        long minAdditions = long.MaxValue;
        int maxCandies = candies[n - 1];

        for (int i = 0; i < n; i++)
        {
            int secondCandy = candies[i];

            // Добавки для меньших значений (префикс)
            long leftAdditions = i > 0 ? (long)i * secondCandy - prefixSum[i - 1] : 0;

            // Добавки для больших значений (суффикс)
            long rightAdditions = i < n - 1 ? (long)maxCandies * (n - i - 1) - suffixSum[i + 1] : 0;

            long totalAdditions = leftAdditions + rightAdditions;
            minAdditions = Math.Min(minAdditions, totalAdditions);
        }
        Console.WriteLine(minAdditions);    
    }
}