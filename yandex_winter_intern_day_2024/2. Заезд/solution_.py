import sys
from typing import List

def main():
    first_line: List[str] = input().split()
    n: int = int(first_line[0])
    t: int = int(first_line[1])
    s: int = int(first_line[2])

    v: List[int] = list(map(int, input().split()))
    less_v: List[int] = [e for e in v[1:] if e < v[0]]
    l: int = len(less_v)

    if l == 0:
        return 0

    total_overtakes: int = 0

    for i in range(l):
        v_relative: int = v[0] - less_v[i]
        s1: int = v[0] * t
        s_i: int = less_v[i] * t
        overtakes: int = int((v_relative * t) / s)

        if (s1 - s_i - s) % s == 0:
            total_overtakes += overtakes - 1
        else:
            total_overtakes += overtakes

    print(total_overtakes)

if __name__ == '__main__':
    main()