using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/finding-the-numbers/0
    /// Expected Time Complexity: O(n)
    /// Expected Space Complexity: O(1)
    /// </summary>
    class FindDistinctNumbers : IProblem
    {
        List<int[]> dataSet = new List<int[]>();
        
        public FindDistinctNumbers()
        {
            dataSet.Add(new int[] { 2, 1, 3, 2 });//expected 1,3
            dataSet.Add(new int[] { 1, 2, 3, 2, 1,4 }); //expected 3,4
        }
        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                var result = singleNumber(data);
                Console.WriteLine($"The distinct nums from {string.Join(",", data)} => {string.Join(",", result)}");
            });
        }

        public int[] singleNumber(int[] nums)
        {
            SortedSet<int> hash = new SortedSet<int>();
            foreach(int x in nums)
            {
                if(!hash.Contains(x))
                {
                    hash.Add(x);
                }
                else
                {
                    hash.Remove(x);
                }
            }
            return hash.ToArray<int>();
        }
    }
}
