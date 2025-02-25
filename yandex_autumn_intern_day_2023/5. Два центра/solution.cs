// Логика кода для тех кто не сообразил суть задачи как и я сразу)):
// Инициализация:
// Создается массив graph для представления графа в виде списка смежности. Каждый элемент массива - список пар, где первая компонента - номер соседней вершины, а вторая - вес ребра.
// Считывается количество вершин n из входных данных.
// Построение графа:

// Считываются ребра из входных данных.
// Для каждого ребра (a, b, c) добавляются ребра (a, b) и (b, a) с весом c в список смежности соответствующих вершин.
// Поиск 2-радиуса:

// Инициализируется переменная minRadius с максимальным значением.
// Перебираются все пары соседних вершин (u, v):
// Вызывается функция CalculateRadius(u, v), которая определяет 2-радиус для данной пары вершин.
// Обновляется значение minRadius, если найден меньший радиус.
// Вычисление 2-радиуса для пары вершин (CalculateRadius)

// Создаются массивы distanceFromU и distanceFromV для хранения расстояний от вершин u и v до всех остальных вершин.
// Выполняется DFS от вершины u, заполняя массив distanceFromU.
// Выполняется DFS от вершины v, заполняя массив distanceFromV.
// Находится максимальное значение min(distanceFromU[w], distanceFromV[w]) для всех вершин w, где оба расстояния определены. Это и есть 2-радиус для данной пары вершин.
// DFS (Depth-First Search):

// Рекурсивная функция для обхода графа в глубину.
// Принимает на вход текущую вершину node, текущее расстояние currentDistance и массив расстояний distances.
// Записывает текущее расстояние в массив distances[node].
// Рекурсивно вызывает DFS для всех непосещенных соседей текущей вершины, увеличивая расстояние на вес ребра.
// Суть алгоритма:

// 2-радиус - это минимальное расстояние, такое что для любой вершины в дереве расстояние до одной из двух выбранных соседних вершин не превышает этого расстояния.
// Алгоритм перебирает все пары соседних вершин и для каждой пары вычисляет 2-радиус.
// Вычисление 2-радиуса для пары вершин основано на двух DFS, которые определяют расстояния от каждой из вершин до всех остальных вершин в дереве.
// Затем выбирается максимальное расстояние до любой вершины, учитывая минимальное расстояние от этой вершины до каждой из двух выбранных соседних вершин.

using System;
using System.Collections.Generic;

class Program 
{
    static List<(int, int)>[] graph;
    static int n;

    static void Main() 
    {
        n = int.Parse(Console.ReadLine());
        graph = new List<(int, int)>[n + 1];
        for (int i = 1; i <= n; i++)
            graph[i] = new List<(int, int)>();

        for (int i = 0; i < n - 1; i++)
        {
            var edge = Console.ReadLine().Split();
            int a = int.Parse(edge[0]);
            int b = int.Parse(edge[1]);
            int c = int.Parse(edge[2]);
            graph[a].Add((b, c));
            graph[b].Add((a, c));
        }

        int minRadius = int.MaxValue;

        // check all pairs of adjacent vertices
        for (int u = 1; u <= n; u++)
        {
            foreach (var (v, weight) in graph[u])
            {
                // DFS from u and v
                int radius = CalculateRadius(u, v);
                minRadius = Math.Min(minRadius, radius);
            }
        }

        Console.WriteLine(minRadius);
    }

    static int CalculateRadius(int u, int v)
    {
        int[] distanceFromU = new int[n + 1];
        int[] distanceFromV = new int[n + 1];
        Array.Fill(distanceFromU, -1);
        Array.Fill(distanceFromV, -1);

        DFS(u, 0, distanceFromU);
        DFS(v, 0, distanceFromV);

        // find the maximum distance to all vertices
        int maxDistance = 0;
        for (int w = 1; w <= n; w++)
        {
            if (distanceFromU[w] != -1 && distanceFromV[w] != -1)
            {
                maxDistance = Math.Max(maxDistance, Math.Min(distanceFromU[w], distanceFromV[w]));
            }
        }
        return maxDistance;
    }

    static void DFS(int node, int currentDistance, int[] distances)
    {
        distances[node] = currentDistance;
        foreach (var (neighbor, weight) in graph[node])
        {
            if (distances[neighbor] == -1) // not visited
            {
                DFS(neighbor, currentDistance + weight, distances);
            }
        }
    }
}