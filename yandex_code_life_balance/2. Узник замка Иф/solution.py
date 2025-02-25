import sys
from typing import List

def can_fit(a: int, b: int, c: int, d: int, e: int) -> str:
    sizes = sorted([a, b, c])
    return "YES" if (sizes[0] <= d and sizes[1] <= e) or (sizes[0] <= e and sizes[1] <= d) else "NO"

def main():
    a: int = int(input())
    b: int = int(input())
    c: int = int(input())
    d: int = int(input())
    e: int = int(input())
    print(can_fit(a, b, c, d, e))

if __name__ == '__main__':
    main()