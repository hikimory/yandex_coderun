import sys
from typing import List

def main() -> None:
    n: int = int(input())
    a: List = list(map(int, input().split()))
    
    a.sort()

    count: int = 0
    i = 0
    while i < n:
        j = i
        while j < n and a[i] == a[j]:
            j += 1
        if j - i == 1:
            count += 1
        i = j

    print(count)

if __name__ == "__main__":
    main()