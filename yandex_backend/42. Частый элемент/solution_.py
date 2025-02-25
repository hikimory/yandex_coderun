import sys
from collections import defaultdict
from typing import List, Dict

def most_frequent_element(arr: List[int]) -> int:
    counts: Dict[int, int] = defaultdict(int)
    max_count: int = 0
    most_frequent: int = float('-inf')

    for num in arr:
        counts[num] += 1
        if counts[num] > max_count:
            max_count = counts[num]
            most_frequent = num
        elif counts[num] == max_count and num > most_frequent:
            most_frequent = num

    return most_frequent


def main():
    n: int = int(input())
    a: List[int] = list(map(int, input().split()))
    result: int = most_frequent_element(a)
    print(result)


if __name__ == '__main__':
    main()