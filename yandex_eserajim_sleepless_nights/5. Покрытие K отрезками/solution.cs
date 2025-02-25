using System;
using System.Linq;

class Program 
{
    static void Main() 
    {
        string[] inputLine = Console.ReadLine().Split();
        int n = int.Parse(inputLine[0]);
        int k = int.Parse(inputLine[1]);

        int[] points = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();

        int left = 0;
        int right = points[n - 1] - points[0];
        int result = right;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Избегаем переполнения
            if (CanCover(points, k, mid))
            {
                result = mid;
                right = mid - 1; // Пытаемся найти еще меньший отрезок
            }
            else
            {
                left = mid + 1; // Увеличиваем длину отрезка
            }
        }

        Console.WriteLine(result);
    }

    private static bool CanCover(int[] points, int k, int length)
    {
        int segmentsUsed = 1;
        int currentSegmentStart = points[0];
        
        for(int i = 1; i < points.Length; i++)
        {
            if(points[i] > currentSegmentStart + length)
            {
                segmentsUsed++;
                currentSegmentStart = points[i];
            }
        }

        return segmentsUsed <= k;
    }
}