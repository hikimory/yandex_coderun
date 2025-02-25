import sys
from typing import List, Tuple

def main() -> None:
    n: int = int(input())
    servers: List[Tuple[float, float]] = []
    for _ in range(n):
        a, b = map(int, input().split())
        servers.append((a / 100.0, b / 100.0))

    total_error_probability: float = 0.0
    for a, b in servers:
        total_error_probability += a * b

    for a, b in servers:
        server_error_probability: float = a * b
        probability_of_error_on_server: float = server_error_probability / total_error_probability
        print(probability_of_error_on_server)

if __name__ == "__main__":
    main()