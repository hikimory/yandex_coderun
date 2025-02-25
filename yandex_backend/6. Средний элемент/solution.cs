using System;
using System.Linq;

class Program 
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();

        a.Sort();

        Console.WriteLine(a[1]);
    }
}