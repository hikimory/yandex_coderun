import sys
from typing import Set

def main() -> None:
    j: str = input()
    s: str = input()
    
    jewelry_set: Set[str] = set(j)
    count: int = 0
    for char in s:
        if char in jewelry_set:
            count += 1
    print(count)


if __name__ == '__main__':
    main()