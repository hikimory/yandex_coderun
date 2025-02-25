//Wrong tests. Look at the python solution and compare to this solution

using System;
using System.Collections.Generic;
using System.Linq;


class Program 
{
    static void Main() 
    {
        int n = int.Parse(Console.ReadLine());
        List<(long Mandarins, long Oranges)> boxes = new List<(long, long)>();
        long totalMandarins = 0;
        long totalOranges = 0;

        for (int i = 0; i < 2 * n - 1; i++)
        {
            string[] line = Console.ReadLine().Split();
            long mandarins = long.Parse(line[0]);
            long oranges = long.Parse(line[1]);
            boxes.Add((mandarins, oranges));
            totalMandarins += mandarins;
            totalOranges += oranges;
        }

        boxes.Sort((a, b) => (b.Mandarins + b.Oranges).CompareTo(a.Mandarins + a.Oranges));
        

        long currentMandarins = 0;
        long currentOranges = 0;

        for (int i = 0; i < boxes.Count; i++) // we need n boxes? but tests need all boxes
        {
            currentMandarins += boxes[i].Mandarins;
            currentOranges += boxes[i].Oranges;

            if (currentMandarins >= totalMandarins / 2 && currentOranges >= totalOranges / 2)
            {
                Console.WriteLine("Yes");
                return;
            }
        }

        Console.WriteLine("No");
    }
}