using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < t; i++)
            words.Add(Console.ReadLine());

        HashSet<string> nodes = new HashSet<string>();
        Dictionary<(string, string), int> edges = new Dictionary<(string, string), int>();

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length - 2; i++)
            {
                string sub1 = word.Substring(i, 3);
                nodes.Add(sub1);
                if (i < word.Length - 3)
                {
                    string sub2 = word.Substring(i + 1, 3);
                    (string, string) edge = (sub1, sub2);
                    if (edges.ContainsKey(edge))
                        edges[edge]++;
                    else
                        edges[edge] = 1;
                }
            }
        }

        Console.WriteLine(nodes.Count);
        Console.WriteLine(edges.Count);
        foreach (var pair in edges)
            Console.WriteLine($"{pair.Key.Item1} {pair.Key.Item2} {pair.Value}");
    }
}