import sys
from typing import Set

def main() -> None:
    s: str = input()
    c: Set[str] = set(input())
    n: int = len(s)
    min_len: int = float('inf')

    for i in range(n):
        for j in range(i, n):
            sub: str = s[i:j+1]
            if set(sub) == c:
                min_len = min(min_len, len(sub))
    
    if min_len == float('inf'):
        print(0)
    else:
        print(min_len)

if __name__ == "__main__":
    main()