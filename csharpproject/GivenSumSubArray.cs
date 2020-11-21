using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0
    /// </summary>
    class GivenSumSubArray : IProblem
    {
        List<Tuple<int, int[]>> dataSet = new List<Tuple<int, int[]>>();

        public GivenSumSubArray()
        {
            dataSet.Add(new Tuple<int, int[]>(12, new int[]{ 1,2,3,7,5}));
            dataSet.Add(new Tuple<int, int[]>(15, new int[]{ 1,2,3,4,5,6,7,8,9,10}));
        }
        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                var result = FindSumSubArray(data.Item2, data.Item1);
                Console.WriteLine($"Input: ({string.Join(",", data.Item2)}) equals to {data.Item1} from range ({result[0]},{result[1]})");
            });
        }

        private int[] FindSumSubArray(int[] arr, int N)
        {
            int left = 0;
            int right = -1;
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                while(sum < N)
                {
                    right++;
                    sum += arr[right];
                }
                while (sum > N)
                {
                    sum -= arr[left];
                    left++;
                }
                if(sum == N)
                {
                    return new int[] { left+1, right+1 };   //they expect indexing 1 results
                }
            }
            return new int[] {-1, -1 };
        }
    }
}
