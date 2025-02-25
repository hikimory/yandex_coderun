import sys
from typing import List

def find_closest_colors(shirts: List[int], pants: List[int]) -> tuple[int, int]:
    i, j = 0, 0
    min_diff: int = float('inf')
    shirt_color, pant_color = 0, 0

    while i < len(shirts) and j < len(pants):
        diff: int = abs(shirts[i] - pants[j])

        if diff == 0:
            return shirts[i], pants[j]

        if diff < min_diff:
            min_diff = diff
            shirt_color = shirts[i]
            pant_color = pants[j]

        if shirts[i] < pants[j]:
            i += 1
        else:
            j += 1

    return shirt_color, pant_color

def main() -> None:
    N: int = int(input())
    shirts: List[int] = list(map(int, input().split()))
    M: int = int(input())
    pants: List[int] = list(map(int, input().split()))

    shirt_color, pant_color = find_closest_colors(shirts, pants)
    print(f"{shirt_color} {pant_color}")

if __name__ == "__main__":
    main()