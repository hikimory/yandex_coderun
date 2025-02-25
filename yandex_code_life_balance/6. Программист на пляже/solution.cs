// To find the minimum XOR value of two elements in an array, you can use the following efficient algorithm:
// 1. Sort the array: If the elements are sorted, the two closest numbers (in magnitude) will often have the minimum XOR value. This is because the XOR between numbers depends on their binary representation, and number pairs that are close in magnitude tend to have smaller differences in bits.
// 2. Loop through the sorted elements and calculate the XOR of adjacent elements: After sorting, it is enough to loop through the array and for each element calculate the XOR with its next neighbor to find the minimum value.


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(a);
            int minXor = int.MaxValue;

            for (int j = 1; j < n; j++)
            {
                int xorVal = a[j] ^ a[j - 1];
                minXor = Math.Min(minXor, xorVal);
            }

            Console.WriteLine(minXor);
        }

        Console.WriteLine(count);
    }
}
    