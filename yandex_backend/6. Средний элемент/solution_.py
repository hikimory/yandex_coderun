from typing import List

def main() -> None:
    n: int = int(input())
    a: List[int] = list(map(int, input().split()))
    
    a.sort()
    return print(a[1])

if __name__ == "__main__":
    main()