from typing import List, Tuple, Literal, Set

def can_capture(board: List[List[str]], pieces: List[Tuple[int, int]], opponent: Literal['white', 'black']) -> str:
    directions = [(1, 1), (1, -1), (-1, 1), (-1, -1)]  # Diagonal directions

    for row, col in pieces:
      for dr, dc in directions:
        if 0 <= row + dr < len(board) and 0 <= col + dc < len(board[0]):
          # If the adjacent square is occupied by the opponent and the next square is empty
          if board[row + dr][col + dc] == opponent and \
             0 <= row + 2*dr < len(board) and 0 <= col + 2*dc < len(board[0]) and \
             board[row + 2*dr][col + 2*dc] == '.':
              return "Yes"

    return "No"
    
def arrange_pieces(board: List[List[str]], count: int, color: Literal['white', 'black']) -> List[Tuple[int, int]]:
    pieces = []
    for _ in range(count):
        i, j = map(int, input().split())
        board[i-1][j-1] = color
        pieces.append((i-1, j-1))
    
    return pieces

def main() -> None:
    n, m = map(int, input().split())
    board: List[List[str]] = [['.' for _ in range(m)] for _ in range(n)]

    w = int(input())
    w_pieces = arrange_pieces(board, w, 'white')

    b = int(input())
    b_pieces = arrange_pieces(board, b, 'black')

    player: Literal['white', 'black'] = input()

    if player == 'white':
        print(can_capture(board, w_pieces, 'black'))
    else:
        print(can_capture(board, b_pieces, 'white'))


if __name__ == '__main__':
    main()