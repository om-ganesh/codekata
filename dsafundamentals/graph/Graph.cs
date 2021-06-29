using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    public class Graph
    {
        Dictionary<int, List<int>> data;

        public Graph(int n)
        {
            data = new Dictionary<int, List<int>>(n);
            for (int i = 0; i < n; i++)
            {
                data.Add(i, new List<int>());
            }
        }

        public Graph(int[] points)
        {
            data = new Dictionary<int, List<int>>(points.Length);
            for (int i = 0; i < points.Length; i++)
            {
                data.Add(points[i], new List<int>());
            }
        }

        // Create Graph from given number of nodes ranging from (0 to n-1) and the edges array
        public Graph(int n, int[][] edges)
        {
            // construct the dictionary of each nodes with empty edges
            data = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                data.Add(i, new List<int>());
            }
            foreach (var edge in edges)
            {
                data[edge[0]].Add(edge[1]);
                //data[edge[1]].Add(edge[0]);
            }
        }

        public int Vertices { get { return data.Count; } }

        public List<int> Edges(int v)
        {
            return data.TryGetValue(v, out List<int> edges) ? edges : null;
        }

        public void AddEdge(int v, int w)
        {
            if (data.TryGetValue(v, out List<int> edges))
            {
                if (!edges.Contains(w))
                {
                    edges.Add(w);
                    Console.WriteLine($"Edge {v}-{w} added");
                }
                else
                {
                    Console.WriteLine($"Warning: The given edge {v}-{w} already exists");
                }
            }
            else
            {
                data.Add(v, new List<int>() { w });
                Console.WriteLine($"Edge {v}-{w} created");
            }
        }

        public void DisplayEdges()
        {
            for (int vertex = 0; vertex < Vertices; vertex++)
            {
                foreach (int edge in Edges(vertex))
                {
                    Console.WriteLine($"{vertex} - {edge}");
                }
            }
        }
    }
}
