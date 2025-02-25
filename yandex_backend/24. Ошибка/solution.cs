using System;
using System.Linq;

class Program 
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<(double, double)> servers = new List<(double, double)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            servers.Add((a / 100.0, b / 100.0));
        }

        double totalErrorProbability = 0.0;
        foreach (var (a, b) in servers)
        {
            totalErrorProbability += a * b;
        }

        foreach (var (a, b) in servers)
        {
            double serverErrorProbability = a * b;
            double probabilityOfErrorOnServer = serverErrorProbability / totalErrorProbability;
            Console.WriteLine($"{probabilityOfErrorOnServer:F10}");
        }
    }
}