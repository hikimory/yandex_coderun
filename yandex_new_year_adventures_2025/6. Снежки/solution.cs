using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = nums[0];
            int b = nums[1];
            int c = nums[2];

            int xorSum = (a % 3) ^ (b % 3) ^ (c % 3);
            if (xorSum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}