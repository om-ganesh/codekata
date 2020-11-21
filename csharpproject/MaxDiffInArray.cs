using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace csharpproject
{
    /// <summary>
    /// https://www.geeksforgeeks.org/maximum-difference-between-two-elements-in-an-array/
    /// </summary>
    class MaxDiffInArray : IProblem
    {
        List<int[]> dataset = new List<int[]>();

        public MaxDiffInArray()
        {
            dataset.Add(new int[]{12,30,7,0,1,88,88 });
            dataset.Add(new int[]{12,30,7,0,1,-88,88 });
            dataset.Add(new int[] { -12, -30, -7, -1, -88, -8 });
        }
        public void Execute()
        {
            dataset.ForEach(data =>
            {
                var diff = FindMaxDiff(data);
                Console.WriteLine($"The max diff in array {String.Join(",", data)} is {diff}");
            });
        }

        private int FindMaxDiff(int[] arr)
        {
            int min= arr[0];
            int max=arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min =arr[i];
                }
                if(arr[i]>max)
                {
                    max=arr[i];
                }
            }

            return max-min;
        }
    }
}
