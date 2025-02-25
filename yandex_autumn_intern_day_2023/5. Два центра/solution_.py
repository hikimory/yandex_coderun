import sys
from typing import List, Tuple

def solve(n: int, graph: List[List[Tuple[int, int]]]) -> int:
    def dfs(node: int, current_distance: int, distances: List[int]) -> None:
        distances[node] = current_distance
        for neighbor, weight in graph[node]:
            if distances[neighbor] == -1:
                dfs(neighbor, current_distance + weight, distances)

    def calculate_radius(u: int, v: int) -> int:
        distance_from_u: List[int] = [-1] * (n + 1) 
        distance_from_v: List[int] = [-1] * (n + 1) 

        dfs(u, 0, distance_from_u)
        dfs(v, 0, distance_from_v)

        max_distance: int = 0
        for w in range(1, n + 1):
            if distance_from_u[w] != -1 and distance_from_v[w] != -1:
                max_distance = max(max_distance, min(distance_from_u[w], distance_from_v[w]))
        return max_distance

    min_radius: int = float('inf') 
    for u in range(1, n + 1):
        for v, _ in graph[u]:
            radius: int = calculate_radius(u, v)
            min_radius = min(min_radius, radius)

    return min_radius

def main():
    n: int = int(input())
    graph: List[List[Tuple[int, int]]] = [[] for _ in range(n + 1)] 
    for _ in range(n - 1):
        a, b, c = map(int, input().split())
        graph[a].append((b, c))
        graph[b].append((a, c))
    
    result: int = solve(n, graph)
    print(result)

if __name__ == '__main__':
    main()