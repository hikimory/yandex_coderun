import sys
from typing import List

def gcd(a: int, b: int) -> int:
    while b:
        a, b = b, a % b
    return a

def lcm(a: int, b: int) -> int:
    return (a // gcd(a, b)) * b

def find_divisors(n: int) -> List[int]:
    divisors: List[int] = []
    i: int = 1
    while i * i <= n:
        if n % i == 0:
            divisors.append(i)
            if i != n // i:
                divisors.append(n // i)
        i += 1
    return divisors

def main() -> int:
    x, y = map(int, input().split())

    if y % x != 0:
        print(0)
        return

    z: int = y // x
    divisors: List[int] = find_divisors(z)

    count: int = 0
    for d in divisors:
        p: int = x * d
        q: int = y // d
        if gcd(p, q) == x and lcm(p, q) == y:
            count += 1

    print(count)

if __name__ == "__main__":
    main()