using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static string CanCapture(char[][] board, List<(int, int)> pieces, char opponent)
    {
        int rows = board.Length;
        int cols = board[0].Length;
        int[,] directions = { { 1, 1 }, { 1, -1 }, { -1, 1 }, { -1, -1 } };

        foreach (var piece in pieces)
        {
            int row = piece.Item1;
            int col = piece.Item2;

            for (int i = 0; i < 4; ++i)
            {
                int dr = directions[i, 0];
                int dc = directions[i, 1];

                if (row + dr >= 0 && row + dr < rows && col + dc >= 0 && col + dc < cols)
                {
                    if (board[row + dr][col + dc] == opponent &&
                        row + 2 * dr >= 0 && row + 2 * dr < rows &&
                        col + 2 * dc >= 0 && col + 2 * dc < cols &&
                        board[row + 2 * dr][col + 2 * dc] == '.')
                    {
                        return "Yes";
                    }
                }
            }
        }
        return "No";
    }

    static List<(int, int)> ArrangePieces(char[][] board, int count, char color)
    {
        List<(int, int)> pieces = new List<(int, int)>();
        for (int _ = 0; _ < count; ++_)
        {
            string[] line = Console.ReadLine().Split();
            int i = int.Parse(line[0]);
            int j = int.Parse(line[1]);
            board[i - 1][j - 1] = color;
            pieces.Add((i - 1, j - 1));
        }
        return pieces;
    }

    public static void Main(string[] args)
    {
        string[] dimensions = Console.ReadLine().Split();
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);
        char[][] board = new char[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = new char[m];
            for (int j = 0; j < m; j++)
            {
                board[i][j] = '.';
            }
        }

        int w = int.Parse(Console.ReadLine());
        List<(int, int)> w_pieces = ArrangePieces(board, w, 'w');

        int b = int.Parse(Console.ReadLine());
        List<(int, int)> b_pieces = ArrangePieces(board, b, 'b');

        string player = Console.ReadLine();

        if (player == "white")
        {
            Console.WriteLine(CanCapture(board, w_pieces, 'b'));
        }
        else
        {
            Console.WriteLine(CanCapture(board, b_pieces, 'w'));
        }
    }
}