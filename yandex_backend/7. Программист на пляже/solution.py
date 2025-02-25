import sys
from typing import List

def find_min_xor(arr: List[int]) -> None:
    arr.sort()
    min_xor: int = float('inf')
    for i in range(1, len(arr)):
        xor_val: int = arr[i] ^ arr[i-1]
        min_xor = min(min_xor, xor_val)
    print(min_xor)

def main() -> None:
    t: int = int(input())
    for _ in range(t):
        n: int = int(input())
        a: List[int] = list(map(int, input().split()))
        find_min_xor(a)

if __name__ == "__main__":
    main()