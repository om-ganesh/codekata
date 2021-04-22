using System;
using System.Collections.Generic;

using core;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //WIP: throwing error 
            string source= @"data\graphdata.txt";
            List<string> data = FileReader.GetAllLines(source);
            int numberOfVertices = Convert.ToInt32(data[0]);
            int numberOfEdges = Convert.ToInt32(data[1]);
            Graph graphObject = new Graph(numberOfVertices);
            for (int i = 2; i < data.Count; i++)
            {
                string[] item = data[i].Split(' ');
                int fromVertex = Convert.ToInt32(item[0]);
                int toVertex = Convert.ToInt32(item[1]);
                graphObject.AddEdge(fromVertex, toVertex);
            }

            // Print all the edges
            graphObject.DisplayEdges();
        }
    }
}
