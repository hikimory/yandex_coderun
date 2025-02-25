using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<(long, long)> tasks = new List<(long, long)>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            tasks.Add((long.Parse(input[0]), long.Parse(input[1])));
        }

        tasks.Sort((x, y) => x.Item1.CompareTo(y.Item1)); // Sort by d_i

        PriorityQueue<long, long> stressHeap = new PriorityQueue<long, long>(); // Min-heap for stresses
        long totalStress = 0;

        foreach (var task in tasks)
        {
            long d = task.Item1, w = task.Item2;
            // If there is time to complete a task, add it to the heap
            if (stressHeap.Count < d)
            {
                stressHeap.Enqueue(w, w);
            }
            else
            {
                // If there is not enough time, we replace the task with a minimum stress if the current one is more important
                if (stressHeap.Count > 0 && w > stressHeap.Peek())
                {
                   totalStress += stressHeap.Dequeue(); // Remove minimal stress from completed tasks
                   stressHeap.Enqueue(w, w); // Add current task
                }
                else
                {
                   // If the current task cannot be included, add its stress to the total
                   totalStress += w;
                }
            }
        }

        Console.WriteLine(totalStress);
    }
}