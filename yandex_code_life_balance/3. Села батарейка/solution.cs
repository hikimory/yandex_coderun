using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int totalConsumption = 0;
        for (int i = 0; i < n; i++)
            totalConsumption += int.Parse(input[i]);

        Console.WriteLine(100 / totalConsumption);
    }
}