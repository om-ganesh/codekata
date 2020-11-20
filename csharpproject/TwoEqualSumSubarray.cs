using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://www.geeksforgeeks.org/split-array-two-equal-sum-subarrays/
    /// </summary>
    class TwoEqualSumSubarray : IProblem
    {
        List<int[]> dataset;
        public TwoEqualSumSubarray()
        {
            dataset = new List<int[]>();
            dataset.Add(new[] {1, 2, 3});
            dataset.Add(new[] {1, 2, 3, 3});
            dataset.Add(new[] { 1, 2, 3, 4, 5, 5 });
            dataset.Add(new[] { 4, 1, 2, 3 });
            dataset.Add(new[] { 4, 3, 2, 1 });
            dataset.Add(new[] { 1, 2, 1, 1, 3 });
            dataset.Add(new[] { 1, 1, 1, 1, 1, 5 });
            dataset.Add(new[] { 5, 2, 3 });
            dataset.Add(new[] {1, -2, 0, 2, 1 });

        }
        public void Execute()
        {
            dataset.ForEach(data =>
            {
                Console.WriteLine($"\nRunning Dataset: {string.Join(",", data)}");

               var index = GetSplitIndex(data);
                if (index == -1)
                {
                    Console.WriteLine($"Output: Array can not be equally splitted"); 
                    
                }
                else
                {
                    Console.WriteLine($"Output: Array can be splitted into two halves at {index}");
                }
            });
        }

        int GetSplitIndex(int[] arr)
        {
            // initial start and end pointers with sums           
            int i = 0;
            int j = arr.Length - 1;
            int sumi = arr[i];
            int sumj = arr[j];

            while (j-i >1)
            {
                if(sumi < sumj)
                {
                    i++;
                    sumi += arr[i];
                }
                else if(sumi > sumj)
                {
                    j--;
                    sumj += arr[j];
                }
                else
                {
                    Console.WriteLine($"Processing: Array splitted into sum {sumi}, at i={i} and j={j}");
                    i++;
                    sumi += arr[i];
                }
            }

            if(sumi == sumj)
            {
                return i;
            }
            return -1;
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            throw new NotImplementedException();
        }
    }
}
