import sys
from typing import List, Tuple, Dict

def main() -> None:
    t: int = int(input())
    for _ in range(t):
        a, b, c = map(int, input().split())
        xor_sum: int = (a % 3) ^ (b % 3) ^ (c % 3)
        if xor_sum == 0:
            print(0)
        else:
            print(1)

if __name__ == "__main__":
    main()