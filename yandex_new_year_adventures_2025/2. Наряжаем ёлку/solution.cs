using System;

class Program 
{
    static void Main() 
    {
        int k = int.Parse(Console.ReadLine());
        long totalBalls = (long)Math.Pow(2, k) - 1;
        Console.WriteLine(totalBalls);
    }
}