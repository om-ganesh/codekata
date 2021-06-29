using System;
using System.Collections.Generic;

using core;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = FileReader.GetAllLines("tinygraph.txt");
            int numberOfVertices = Convert.ToInt32(data[0]);
            int numberOfEdges = Convert.ToInt32(data[1]);

            // Method1
            Graph graphObject = new Graph(numberOfVertices);
            for (int i = 2; i < data.Count; i++)
            {
                string[] item = data[i].Split(' ');
                int u = Convert.ToInt32(item[0]);
                int v = Convert.ToInt32(item[1]);
                graphObject.AddEdge(u, v);
            }
             
            // Method2
            //int[][] edges = new int[numberOfEdges][];
            //for (int i = 2; i < data.Count; i++)
            //{
            //    string[] item = data[i].Split(' ');
            //    edges[i-2] = new int[]{ Convert.ToInt32(item[0]), Convert.ToInt32(item[1]) };
            //}
            //graphObject = new Graph(numberOfVertices, edges);
            
            // Print all the edges
            graphObject.DisplayEdges();
        }
    }
}
