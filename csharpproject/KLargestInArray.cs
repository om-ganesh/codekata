using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.Text;


namespace csharpproject
{
    /// <summary>
    /// https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// </summary>
    class KLargestInArray : IProblem
    {
        int k;
        int kthLargest;
        int[] arr;
        int[] result;
        public KLargestInArray()
        {
            this.arr = new int[] { 21, 12, 20, 35, 6, 9, 9, 15 };
            this.k = 3;
        }

        public void Execute()
        {
            //FindKLargestElements();
            kthLargest = FindKthLargest(arr, k);
            Console.WriteLine($"The {k}th largest element from {string.Join(",", arr)} is {kthLargest}");

        }

        // TODO Implement in O(n) as asked for multiple people in interview
        public int FindKthLargest(int[] nums, int k)
        {
            return -1;
            //for (int i = 0; i < nums.size(); i++)
            //{
            //    m.push(nums[i]);
            //    if (m.size() > k)
            //    {
            //        m.pop();
            //    }
            //}
            //return m.top();
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        public int FindKthLargest1(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        private void FindKLargestElements()
        {
            result = new int[k];
            Array.Sort(arr);
            for (int i = arr.Length-1,j=k-1; i >= arr.Length-k; i--)
            {
                result[j--] = arr[i];
            }
        }

        public void ShowResult()
        {
            Console.WriteLine($"Showing {k} largest element from input array {string.Join(",", arr)}");
            Console.Write(String.Join("\n", result));
        }
    }
}
