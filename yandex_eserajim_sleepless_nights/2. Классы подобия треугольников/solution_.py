import sys
from typing import List, Set

def gcd(a: int, b: int) -> int:
    while b:
        a, b = b, a % b
    return a

def canonical_representation(a: int, b: int, c: int) -> str:
    sides: List = sorted([a, b, c])
    common_gcd = gcd(gcd(sides[0], sides[1]), sides[2])
    return f"{sides[0] // common_gcd}-{sides[1] // common_gcd}-{sides[2] // common_gcd}"

def main() -> None:
    n = int(input())
    classes: Set[str] = set()

    for _ in range(n):
        parts = input().split()
        a, b, c = int(parts[0]), int(parts[1]), int(parts[2])
        repr_str = canonical_representation(a, b, c)
        classes.add(repr_str)

    print(len(classes))

if __name__ == "__main__":
    main()