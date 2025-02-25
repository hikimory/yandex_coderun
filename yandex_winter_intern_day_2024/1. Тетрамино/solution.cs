using System;

class Program 
{
  static char[,] board = new char[8, 8];
  static void Main()
  {
      for (int i = 0; i < 8; i++)
      {
          string line = Console.ReadLine();
          for (int j = 0; j < 8; j++)
          {
              board[i, j] = line[j];
          }
      }

      int count = 0;
      for (int i = 0; i < 8; i++)
      {
          for (int j = 0; j < 8; j++)
          {
              if (IsFree(i, j) && IsFree(i, j + 1) && IsFree(i, j + 2))
              {
                  // * * *
                  //   *
                  if (IsFree(i + 1, j + 1))
                      count++;

                  //   * 
                  // * * *
                  if (IsFree(i - 1, j + 1))
                      count++;
              }

              if (IsFree(i, j) && IsFree(i + 1, j) && IsFree(i + 2, j))
              {
                  // *
                  // * *
                  // *
                  if (IsFree(i + 1, j + 1))
                      count++;

                  //   *
                  // * *
                  //   *
                  if (IsFree(i + 1, j - 1))
                      count++;
              }
          }
      }
      Console.WriteLine(count);
  }

  static bool IsFree(int x, int y)
  {
      if (x < 0 || y < 0 || x >= 8 || y >= 8)
          return false;

      if (board[x, y] != '.')
          return false;

      return true;
  }
}