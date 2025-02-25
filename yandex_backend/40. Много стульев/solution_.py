import sys
from typing import List

def main() -> None:
    n, m = map(int, input().split())
    sellers: List[int] = list(map(int, input().split()))
    buyers: List[int] = list(map(int, input().split()))

    sellers.sort()
    buyers.sort()

    profit: int = 0
    seller_idx: int = 0
    buyer_idx: int = m - 1

    while seller_idx < n and buyer_idx >= 0:
        if buyers[buyer_idx] > sellers[seller_idx]:
            profit += buyers[buyer_idx] - sellers[seller_idx]
            seller_idx += 1
            buyer_idx -= 1
        else:
            buyer_idx -= 1

    print(profit)


if __name__ == '__main__':
    main()