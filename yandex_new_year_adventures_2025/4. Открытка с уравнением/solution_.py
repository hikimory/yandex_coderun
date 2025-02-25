import sys

def count_prime_divisors(x: int) -> int:
    if x <= 1:
      return 0
    
    count: int = 0
    d: int = 2
    while d * d <= x:
        if x % d == 0:
            count += 1
            while x % d == 0:
                x //= d
        d += 1

    if x > 1:
        count += 1

    return count

def main()-> None:
    n: int = int(input())
    solution_count: int = 0

    max_p: int = 12
    start_x: int = max(1, n - max_p)
    
    for x in range(start_x, n + 1):
        if x + count_prime_divisors(x) == n:
            solution_count += 1
    
    print(solution_count)

if __name__ == '__main__':
    main()