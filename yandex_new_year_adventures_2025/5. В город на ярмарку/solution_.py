import sys
from typing import List, Tuple, Dict

def main() -> None:
    l: List[str] = input().split()
    n: int = int(l[0])
    m: int = int(l[1])

    if m == 0:
        print(0)
        return

    graph: Dict[int, List[int]] = {i: [] for i in range(1, n + 1)}

    for _ in range(m):
        line: List[str] = input().split()
        a: int = int(line[0])
        b: int = int(line[1])
        graph[a].append(b)
        graph[b].append(a)

    visited: List[bool] = [False] * (n + 1)
    total_edges_to_remove: int = 0

    for i in range(1, n + 1):
        if not visited[i]:
            vertices_count, edges_count = dfs(i, graph, visited, 0, 0)
            total_edges_to_remove += edges_count // 2 - (vertices_count - 1)

    print(total_edges_to_remove)


def dfs(node: int, graph: Dict[int, List[int]], visited: List[bool], vertices_count: int, edges_count: int) -> Tuple[int, int]:
    visited[node] = True
    vertices_count += 1

    for neighbor in graph[node]:
        edges_count += 1
        if not visited[neighbor]:
           vertices_count, edges_count = dfs(neighbor, graph, visited, vertices_count, edges_count)

    return vertices_count, edges_count

if __name__ == "__main__":
    main()