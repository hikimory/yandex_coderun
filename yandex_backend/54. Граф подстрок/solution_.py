import sys
from typing import List, Set, Dict, Tuple

def main() -> None:
    t: int = int(input())
    words: List[str] = [input() for _ in range(t)]

    nodes: Set[str] = set()
    edges: Dict[Tuple[str, str], int] = {}

    for word in words:
        for i in range(len(word) - 2):
            sub1: str = word[i:i+3]
            nodes.add(sub1)
            if i < len(word) - 3:
                sub2: str = word[i+1:i+4]
                edge: Tuple[str, str] = (sub1, sub2)
                if edge in edges:
                    edges[edge] += 1
                else:
                    edges[edge] = 1

    print(len(nodes))
    print(len(edges))
    for (start, end), weight in edges.items():
        print(start, end, weight)

if __name__ == '__main__':
    main()