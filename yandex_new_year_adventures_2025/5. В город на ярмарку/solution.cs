using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        var l = Console.ReadLine().Split();
        int n = int.Parse(l[0]);
        int m = int.Parse(l[1]);

        if (m == 0)
        {
            Console.WriteLine(0);
            return;
        }

        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
            graph[i] = new List<int>();


        for (int i = 0; i < m; i++)
        {
            var line = Console.ReadLine().Split();
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            graph[a].Add(b);
            graph[b].Add(a);
        }

        bool[] visited = new bool[n + 1];
        int totalEdgesToRemove = 0;

        // Поиск компонент связности
        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                int verticesCount = 0;
                int edgesCount = 0;
                DFS(i, graph, visited, ref verticesCount, ref edgesCount);

                // Для каждой компоненты считаем количество рёбер, которые можно удалить
                // edgesCount / 2, так как каждое ребро считается дважды
                //удаляемые рёбра = количество рёбер в компоненте - (количество вершин в компоненте - 1) 
                //Это означает, что для каждой компоненты мы можем оставить только V -1 рёбер, где V — количество вершин в данной компоненте.
                totalEdgesToRemove += edgesCount / 2 - (verticesCount - 1);
            }
        }

        Console.WriteLine(totalEdgesToRemove);
    }

    static void DFS(int node, List<int>[] graph, bool[] visited, ref int verticesCount, ref int edgesCount)
    {
        visited[node] = true;
        verticesCount++;

        foreach (var neighbor in graph[node])
        {
            edgesCount++;
            if (!visited[neighbor])
                DFS(neighbor, graph, visited, ref verticesCount, ref edgesCount);
        }
    }
}