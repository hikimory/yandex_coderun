import sys
from typing import List

def can_cover(points: List[int], k: int, length: int) -> bool:
    segments_used: int = 1
    current_segment_start: int = points[0]

    for point in points[1:]:
        if point > current_segment_start + length:
            segments_used += 1
            current_segment_start = point
    return segments_used <= k


def find_min_length(points: List[int], k: int) -> int:
    points.sort()
    left: int = 0
    right: int = points[-1] - points[0]
    result: int = right

    while left <= right:
        mid: int = left + (right - left) // 2
        if can_cover(points, k, mid):
            result = mid
            right = mid - 1
        else:
            left = mid + 1
    return result


def main() -> None:
    n, k = map(int, input().split())
    points = list(map(int, input().split()))
    print(find_min_length(points, k))

if __name__ == "__main__":
    main()