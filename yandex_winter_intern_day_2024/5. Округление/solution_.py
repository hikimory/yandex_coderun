import sys

from typing import List

def main():
    n, x = map(int, input().split())
    a: List[int] = list(map(int, input().split()))

    total_a: int = sum(a)
    b: List[float] = [(x * ai) / total_a for ai in a]
    c: List[int] = [int(bi) for bi in b]
    
    current_sum: int = sum(c)
    diff: int = x - current_sum
    
    if diff == 0:
        print(*c)
        return
    
    indices: List[int] = sorted(range(n), key=lambda i: b[i] - c[i], reverse=diff > 0)

    for i in range(abs(diff)):
        if diff > 0:
            c[indices[i]] += 1
        else:
            c[indices[i]] -= 1
    
    print(*c)


if __name__ == '__main__':
    main()