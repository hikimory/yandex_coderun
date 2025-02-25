import sys
import heapq
from typing import List, Tuple

def main():
    n: int = int(input())
    tasks: List[Tuple[int, int]] = [tuple(map(int, input().split())) for _ in range(n)]
    tasks.sort(key=lambda x: x[0])  # sort by d_i
    
    stress_heap: List[int] = []  # Heap for storing stresses of completed tasks (min-heap)
    total_stress: int = 0
    
    for d, w in tasks:
        # If there is time to complete a task, add it to the heap
        if len(stress_heap) < d:
            heapq.heappush(stress_heap, w)
        else:
            # If there is not enough time, we replace the task with a minimum stress if the current one is more important
            if stress_heap and w > stress_heap[0]:
                total_stress += heapq.heappop(stress_heap)  # Remove minimal stress from completed tasks
                heapq.heappush(stress_heap, w)  # Add current task
            else:
                # If the current task cannot be included, add its stress to the total
                total_stress += w
    
    print(total_stress)


if __name__ == '__main__':
    main()