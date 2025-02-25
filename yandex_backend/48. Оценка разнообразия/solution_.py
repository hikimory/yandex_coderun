import sys
from typing import Dict, List

def main() -> None:
    n: int = int(input())
    product_category: Dict[int, int] = {}
    for _ in range(n):
        product, category = map(int, input().split())
        product_category[product] = category
    
    product_order: List[int] = list(map(int, input().split()))
    
    category_positions: Dict[int, List[int]] = {}
    for i, product in enumerate(product_order):
      category: int = product_category[product]
      if category not in category_positions:
        category_positions[category] = []
      category_positions[category].append(i)
    
    if len(category_positions) == n:
       print(n)
       return

    min_diff: float = float('inf')
    for category, positions in category_positions.items():
      if len(positions) > 1:
        for i in range(len(positions) - 1):
          diff: int = positions[i+1] - positions[i]
          min_diff = min(min_diff, diff)
    
    if min_diff == float('inf'):
        print(n)
    else:
        print(min_diff)

if __name__ == '__main__':
    main()