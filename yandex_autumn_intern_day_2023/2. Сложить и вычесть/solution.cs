using System;

class Program 
{
    static void Main() 
    {
        string s = Console.ReadLine();
        Console.WriteLine(Calculate(s));
    }

    private static long Calculate(string s)
    {
        long result = 0;
        long currentNumber = 0;
        char operation = '+';
        int len = s.Length - 1;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsDigit(c))
                currentNumber = currentNumber * 10 + (c - '0');

            if (!char.IsDigit(c) || i == len)
            {
                if (operation == '+')
                {
                    result += currentNumber;
                }
                else if (operation == '-')
                {
                    result -= currentNumber;
                }
                
                currentNumber = 0;
                operation = c;
            }
        }
        return result;
    }
}