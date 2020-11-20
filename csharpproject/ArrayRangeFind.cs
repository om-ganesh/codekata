using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpproject
{

    /// <summary>
    /// Q1. Can we have duplicate entries?
    /// Q2. If we have single entry {2}, do we consider it as range 1 or 0?
    /// Q3. What result we want if the array input is empty?
    /// </summary>
    class ArrayRangeFind : IProblem
    {
        List<int[]> dataset = new List<int[]>();
        public ArrayRangeFind()
        {
            dataset.Add(new[] { 1 });
            dataset.Add(new[] { 2, 3 });
            dataset.Add(new[] { 1, 11, 3, 13 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 9, 2, 4, 10, 7, 12, 8 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6, 12, 14, 16, 18, 19, 17 });
            dataset.Add(new[] { -1, 11, 3, 0, 15, 5, -2, 4, 10, 7, 13, 6 });
        }

        public void Execute()
        {
            dataset.ForEach(dt =>
            {
                var maxRange = GetRange(dt);
                Console.WriteLine($"The range for array [{string.Join(",", dt)}] = {maxRange}");
            });
            
        }

        private int GetRange(int[] inArray)
        {
            // Clone input array and sort it
            int result = 0;
            int[] arr = new int[inArray.Length];
            Array.Copy(inArray, arr, inArray.Length);
            Array.Sort(arr);

            int currentRange = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentRange = (arr[i + 1] - arr[i] == 1) ? currentRange + 1 : 0;
                if (currentRange > result)
                {
                    result = currentRange;
                }
            }
            return result;
        }

        public void ShowResult()
        {
            
        }
    }
}
