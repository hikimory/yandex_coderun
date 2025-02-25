using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        int N = int.Parse(Console.ReadLine());
        int[] shirts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int M = int.Parse(Console.ReadLine());
        int[] pants = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int i = 0, j = 0;
        int minDiff = int.MaxValue;
        int shirtColor = 0, pantColor = 0;

        while (i < N && j < M)
        {
            int diff = Math.Abs(shirts[i] - pants[j]);
            
            if (diff == 0)
            {
                shirtColor = shirts[i];
                pantColor = pants[j];
                break;
            }
            
            if (diff < minDiff)
            {
                minDiff = diff;
                shirtColor = shirts[i];
                pantColor = pants[j];
            }

            if (shirts[i] < pants[j])
                i++;
            else
                j++;
        }

        Console.WriteLine($"{shirtColor} {pantColor}"); 
    }
}