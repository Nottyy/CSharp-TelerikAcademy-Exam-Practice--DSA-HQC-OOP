using Magnum.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

public class MinimumSpanningTree
{
    static string input = @"8
12
1 2 4
2 3 3
3 4 1
7 8 44
3 5 20
3 6 3
3 7 34
4 5 7
5 7 2
5 8 1
6 7 1
1 3 50
";
    public class Node : IComparable<Node>
    {
        public Node(int vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }

        public int Vertex { get; set; }

        public int Weight { get; set; }

        public int CompareTo([AllowNull] Node other)
        {
            return this.Weight.CompareTo(other.Weight);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public Edge(int x, int y, int weight)
        {
            X = x;
            Y = y;
            Weight = weight;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Weight { get; set; }

        public int CompareTo([AllowNull] Edge other)
        {
            return this.Weight.CompareTo(other.Weight);
        }
    }

    static void Main()
    {
        FakeInput();

        List<Node>[] vertices = ReadGraph();

        int sum = CalculateMinimumSpanningTree(vertices);
        Console.WriteLine(sum);
    }

    private static int CalculateMinimumSpanningTree(List<Node>[] vertices)
    {
        int sum = 0;
        int vertex = 8;

        var tree = new HashSet<int>();
        tree.Add(vertex);

        var queue = new OrderedBag<Edge>();

        do
        {
            foreach (var next in vertices[vertex])
            {
                queue.Add(new Edge(vertex, next.Vertex, next.Weight));
            }

            Edge minWeightedEdge = null;
            while (tree.Contains(vertex))
            {
                if (queue.Count == 0)
                {
                    return sum;
                }
                minWeightedEdge = queue.RemoveFirst();
                vertex = tree.Contains(minWeightedEdge.X) ? minWeightedEdge.Y : minWeightedEdge.X;
            }

            sum += minWeightedEdge.Weight;
            tree.Add(vertex);
        } while (queue.Count > 0);


        return sum;
    }

    static void FakeInput()
    {
        Console.SetIn(new StringReader(input));
    }

    private static List<Node>[] ReadGraph()
    {

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        var vertices = new List<Node>[n + 1];

        for (int i = 0; i < m; i++)
        {
            var edges = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var node1 = edges[0];
            var node2 = edges[1];
            var weight = edges[2];
            AddEdges(vertices, node1, node2, weight);
            AddEdges(vertices, node2, node1, weight);
        }

        return vertices;
    }

    private static void AddEdges(List<Node>[] vertices, int from, int to, int weight)
    {
        if (vertices[from] == null)
        {
            vertices[from] = new List<Node>();
        }
        vertices[from].Add(new Node(to, weight));
    }
}