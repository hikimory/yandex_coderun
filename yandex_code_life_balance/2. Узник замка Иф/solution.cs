using System;

class Program 
{
    static string CanFit(int a, int b, int c, int d, int e)
    {
        int[] sizes = new int[3]{ a, b, c };
        Array.Sort(sizes);
        if ((sizes[0] <= d && sizes[1] <= e) ||  (sizes[0] <= e && sizes[1] <= d))
            return "YES";
        else
            return "NO";
    }

    static void Main() 
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine(CanFit(a, b, c, d, e));
    }
}