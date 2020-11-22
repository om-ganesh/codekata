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
    class LargestConsecutiveRange : IProblem
    {
        List<int[]> dataset = new List<int[]>(); 
        public LargestConsecutiveRange()
        {
            dataset.Add(new int[] { });//expected 0
            dataset.Add(new[] { 0 });//expected 1
            dataset.Add(new[] { 2, 3 });
            dataset.Add(new[] { 1, 2, 0, 1 }); //expected 3
            dataset.Add(new[] { 1, 11, 3, 13 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 9, 2, 4, 10, 7, 12, 8 });
            dataset.Add(new[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6, 12, 14, 16, 18, 19, 17 });
            dataset.Add(new[] { -1, 11, 3, 0, 15, 5, -2, 4, 10, 7, 13, 6 });
            dataset.Add(new int[] { 100, 4, 200, 1, 3, 2 });
            dataset.Add(new int[] { 1, 2, 3, 4, 6, 7, 8, 9 });
            dataset.Add(new int[] { 0, 2, 3, 5, 7, 9, -1 });
        }

        public void Execute()
        {
            dataset.ForEach(dt =>
            {
                var maxRange = LongestConsecutive(dt);
                Console.WriteLine($"The range for array [{string.Join(",", dt)}] = {maxRange}");
            });
            
        }

        // Even better in O(n)
        private int LongestConsecutive(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>(nums);
            int result = 0;

            foreach (int x in nums)
            {
                if (!hash.Contains(x - 1))
                {
                    int num = x;
                    int cnt = 1;
                    while (hash.Contains(++num))
                    {
                        cnt++;
                    }
                    result = cnt > result ? cnt : result;
                }
            }
            return result;
        }

        private int LongestConsecutive1(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            // Clone input array and sort it
            int result = 1;
            int[] arr = new int[nums.Length];
            Array.Copy(nums, arr, nums.Length);
            Array.Sort(arr);
            int currentRange = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var seq = arr[i + 1] - arr[i];
                if (seq > 1)
                {
                    currentRange = 1;
                }
                else if (seq == 1)
                {
                    currentRange++;
                }
                if (currentRange > result)
                {
                    result = currentRange;
                }
            }
            return result;
        }
    }
}
