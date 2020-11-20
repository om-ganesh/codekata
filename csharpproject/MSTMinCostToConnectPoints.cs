using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://leetcode.com/problems/min-cost-to-connect-all-points/
    /// </summary>
    class MSTMinCostToConnectPoints : IProblem
    {
        List<int[][]> dataset = new List<int[][]>();
        public MSTMinCostToConnectPoints()
        {
            dataset.Add(new int[5][] { new int[] { 0, 0 }, new int[] { 2, 2 }, new int[] { 5, 2 }, new int[] { 7, 0 }, new int[] { 3, 10 } });
            dataset.Add(new int[3][] { new int[] { 3, 12 }, new int[] { -2, 5 }, new int[] { -4, 1 } });
            dataset.Add(new int[4][] { new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 1, 0 }, new int[] { -1, 1 } });
            dataset.Add(new int[2][] { new int[] { -1000000, -1000000 }, new int[] { 1000000, 1000000 } });
            dataset.Add(new int[1][] { new int[] { 0, 0 } });
            //TODO - Not working for this use case
            dataset.Add(new int[4][] { new int[] { 2, -3 }, new int[] { -17, -8 }, new int[] { 13, 8 }, new int[] { -17, -15 } });
        }

        public void Execute()
        {
            dataset.ForEach(data =>
            {
                int result = MinCostConnectPoints(data);
                Console.WriteLine($"The minimum cost path (MST): {result}");
            });
            
        }

        private int MinCostConnectPoints(int[][] points)
        {
            // Handle edge cases
            if(points.GetLength(0) <1)
            {
                return -1;
            }
            else if (points.GetLength(0) ==1)
            {
                return 0;
            }
            else if(points.GetLength(0) ==2)
            {
                return Math.Abs(points[0][0] - points[1][0]) + Math.Abs(points[0][1] - points[1][1]);
            }
            // create weight matrix
            var weightMatrix = CreateAdjacencyMatrix(points);
            PrintMatrix(weightMatrix);

            // First find min cost from first row and marked that cell as visited(-1)
            int minWeightColumnIndex = 1;
            int minCost = weightMatrix[0, minWeightColumnIndex];
            for (int col = 2; col < weightMatrix.GetLength(0); col++)
            {
                if(weightMatrix[0, col] < minCost)
                {
                    minWeightColumnIndex = col;
                    minCost = weightMatrix[0, col];
                }
            }
            minCost = weightMatrix[0, minWeightColumnIndex];
            weightMatrix[0, minWeightColumnIndex] = -1;

            //Now iterate through remaining columns (i<j) to pick min in each column
            for (int col = 2; col < weightMatrix.GetLength(0); col++)
            {
                int minWeightInColumn;
                int minWeightRowIndex;
                if (weightMatrix[0, col] != -1)
                {
                    minWeightInColumn = weightMatrix[0, col];
                    minWeightRowIndex = 0;
                }
                else
                {
                    minWeightInColumn = weightMatrix[1, col];
                    minWeightRowIndex = 1;
                }
                
                for (int row = 0; row < col; row++)
                {
                    if(weightMatrix[row, col] != -1 && weightMatrix[row, col] < minWeightInColumn)
                    {
                        minWeightRowIndex = row;
                        minWeightInColumn = weightMatrix[row, col];
                    }
                }
                minCost += weightMatrix[minWeightRowIndex, col];
                weightMatrix[minWeightRowIndex, col] = -1;
            }
            PrintMatrix(weightMatrix);
            return minCost;
        }

        private int[,] CreateAdjacencyMatrix(int[][] points)
        {
            var weight = new int[points.GetLength(0), points.GetLength(0)];
            for(int i = 0; i < points.GetLength(0); i++)
            {
                for(int j = 0; j< points.GetLength(0); j++)
                {
                    // Find manhattan distance |xi - xj| + |yi - yj|
                    var dist = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                    weight[i, j] = dist;
                }
            }
            return weight;
        }

        private void PrintMatrix(int[,] points)
        {
            Console.WriteLine("------------------");
            for (int i = 0; i < points.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    Console.Write(points[i, j].ToString().PadLeft(2));
                    if( j != points.GetLength(1)-1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("|");
            }
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
        }
    }
}
