using System;
using System.Collections.Generic;
using System.Linq;

public class DiversityCalculator
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> productCategory = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            productCategory[input[0]] = input[1];
        }

        int[] productOrder = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Dictionary<int, List<int>> categoryPositions = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            int category = productCategory[productOrder[i]];
            if (!categoryPositions.ContainsKey(category))
            {
                categoryPositions[category] = new List<int>();
            }
            categoryPositions[category].Add(i);
        }

        if (categoryPositions.Count == n)
        {
            Console.WriteLine(n);
            return;
        }

        int minDiff = int.MaxValue;
        foreach (var kvp in categoryPositions)
        {
            List<int> positions = kvp.Value;
            for (int i = 0; i < positions.Count - 1; i++)
            {
                minDiff = Math.Min(minDiff, positions[i + 1] - positions[i]);
            }
        }

        Console.WriteLine(minDiff == int.MaxValue ? n : minDiff);
    }
}