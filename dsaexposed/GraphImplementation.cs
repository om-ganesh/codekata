using dsaexposed.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace dsaexposed.models
{
    public class GraphImplementation
    {
        public static Graph CreateGraph(string source)
        {
            List<string> data = FileReader.GetAllLines(source);
            int numberOfVertices = Convert.ToInt32(data[0]);
            int numberOfEdges = Convert.ToInt32(data[1]);
            Graph g = new Graph(numberOfVertices);
            for(int i=2;i<data.Count;i++)
            {
                string[] item = data[i].Split(' ');
                int fromVertex = Convert.ToInt32(item[0]);
                int toVertex = Convert.ToInt32(item[1]);
                g.AddEdge(fromVertex, toVertex);
            }

            // Print all the edges

            return g;
        }

        public static void DisplayEdges(Graph graph)
        {
            for(int vertex=0; vertex<graph.Vertices;vertex++)
            {
                foreach(int edge in graph.Edges(vertex))
                {
                    Console.WriteLine($"{vertex} - {edge}");
                }
            }
        }
    }
}
