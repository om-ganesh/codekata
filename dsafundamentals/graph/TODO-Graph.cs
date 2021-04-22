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
        }

        public Graph(int[] points)
        {
            data = new Dictionary<int, List<int>>(points.Length);
            for (int i = 0; i < points.Length; i++)
            {
                data.Add(points[i], new List<int>());
            }
        }

        public int Vertices { get { return data.Count; } }

        public List<int> Edges(int v)
        {
            return data.TryGetValue(v, out List<int> edges) ? edges : null;
        }

        public void AddEdge(int v, int w)
        {
            if(data.TryGetValue(v, out List<int> edges))
            {
                if(!edges.Contains(w))
                {
                    edges.Add(w);
                }
                else
                {
                    Console.WriteLine($"Warning: The given edge {v}-{w} already exists");
                }
            }
            else
            {
                data.Add(v, new List<int>() { w });
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
