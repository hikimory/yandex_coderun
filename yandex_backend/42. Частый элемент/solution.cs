using System;
using System.Collections.Generic;
using System.Linq;

public class MostFrequentElement
{
    public static int FindMostFrequentElement(List<int> arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int maxCount = 0;
        int mostFrequent = int.MinValue;

        foreach (int num in arr)
        {
            if (!counts.ContainsKey(num))
                counts[num] = 0;

            counts[num]++;

            if (counts[num] > maxCount)
            {
                maxCount = counts[num];
                mostFrequent = num;
            }
            else if (counts[num] == maxCount && num > mostFrequent)
            {
                mostFrequent = num;
            }
        }
        return mostFrequent;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

        int result = FindMostFrequentElement(arr);
        Console.WriteLine(result);
    }
}