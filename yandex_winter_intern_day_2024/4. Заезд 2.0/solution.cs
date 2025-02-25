using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        long t = long.Parse(input[1]);
        long s = long.Parse(input[2]);

        var speeds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        long result = CountOvertakesOptimized(n, t, s, speeds);
        Console.WriteLine(result);
    }

    public static long CountOvertakesOptimized(int n, long t, long s, int[] speeds)
    {
        long totalOvertakes = 0;

        // 1. Группируем машины по скоростям
        var speedGroups = speeds.GroupBy(x => x)
                                .Select(group => new { Speed = group.Key, Count = (long)group.Count() })
                                .OrderBy(group => group.Speed)
                                .ToList();

        int numGroups = speedGroups.Count;

        // 2. Итерируемся по группам и считаем обгоны
        for (int i = 0; i < numGroups; i++)
        {
            for (int j = i + 1; j < numGroups; j++)
            {
                long speedDiff = speedGroups[j].Speed - speedGroups[i].Speed;

                // обгоны между группами
                long overtakes = 0;

                if (speedDiff > 0)
                {
                    long distanceDiff = speedDiff * t;
                    overtakes = distanceDiff / s;
                     if ((distanceDiff )% s == 0)
                        overtakes -= 1;

                    // Для каждой машины в группе i происходит *группа_j_количество* обгонов.
                   totalOvertakes += overtakes * speedGroups[i].Count * speedGroups[j].Count;
                }
               
            }
        }
        return totalOvertakes;
    }
}