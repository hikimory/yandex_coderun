using System;
using System.Linq;
using System.Collections.Generic;

class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] books = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxBooks = MaxBooksOnShelf(books);
        Console.WriteLine(maxBooks);
    }

    public static int MaxBooksOnShelf(int[] books)
    {
        int n = books.Length;
        if (n == 0) return 0;

        int[] dp = new int[n];
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;

            for (int j = 0; j < i; j++)
            {
                if (CanPlace(books, j, i))
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            max = Math.Max(max, dp[i]);
        }

        return max;
    }

    public static bool CanPlace(int[] books, int j, int i)
    {
        List<int> shelf = new List<int>();
        shelf.Add(books[j]);

        for (int k = 0; k < j; k++)
        {
            if (IsOnShelf(books, k, j))
            {
                InsertSorted(shelf, books[k]);
            }
        }

        for (int k = j + 1; k < i; k++)
        {
            if (IsOnShelf(books, j, k))
            {
                shelf.Add(books[k]);
            }
        }

        if (shelf.Count == 0) return true;

        if (books[i] >= shelf.Last()) return true;

        if (books[i] < shelf.First())
        {
            foreach (int book in shelf)
            {
                if (books[i] > book)
                {
                    return false;
                }
            }
            return true;
        }

        return false;
    }

    public static void InsertSorted(List<int> list, int value)
    {
        int index = 0;
        while (index < list.Count && list[index] < value)
        {
            index++;
        }
        list.Insert(index, value);
    }

    public static bool IsOnShelf(int[] books, int prevIndex, int currentIndex)
    {
        for (int k = prevIndex + 1; k < currentIndex; k++)
        {
            if (books[k] >= books[prevIndex] && books[k] <= books[currentIndex])
            {
                return false;
            }
        }
        return true;
    }
}