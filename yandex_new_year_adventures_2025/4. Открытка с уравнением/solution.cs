using System;

class Program 
{
    static void Main() 
    {
        long n = long.Parse(Console.ReadLine());
        long solutionCount = 0;
        
        // Поскольку p(x) >= 0, то x <= n. Мы можем итерироваться от 1 до n и проверять.
        // Но так как x + p(x) = n, x = n - p(x),  где p(x) <= count_prime_divisors_max(n).
        // Значит, можно итерироваться от max(1, n-max_p) до n, где max_p - максимум кол-ва простых делителей для n.
        // Максимальное кол-во простых делителей достигается, когда n - произведение минимальных простых чисел 2*3*5*7*...
        // 2 * 3 * 5 * 7 * 11 * 13 * 17 * 19 * 23 * 29 * 31 * 37 = 200560490130 < 10^12. Далее будет больше.
        // т.е. максимум 12.
        // Можно оптимизировать этот поиск, начав с n и уменьшая x. Фактически мы перебираем x в возрастающем порядке, начиная с более “умного” начала, чем 1

        long max_p = 12;
        long start_x = Math.Max(1, n - max_p);
        
        for (long x = start_x; x <= n; ++x)
        {
            if (x + CountPrimeDivisors(x) == n)
            {
                solutionCount++;
            }
        }
        Console.WriteLine(solutionCount);
    }

    static long CountPrimeDivisors(long x)
    {
        if (x <= 1) return 0;

        long count = 0;
        for (long d = 2; d * d <= x; ++d)
        {
            if (x % d == 0)
            {
                count++;
                while (x % d == 0)
                {
                    x /= d;
                }
            }
        }

        if (x > 1)
            count++;

        return count;
    }
}