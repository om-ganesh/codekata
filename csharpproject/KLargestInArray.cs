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
        List<Tuple<int, int[]>> dataSet = new List<Tuple<int, int[]>>();
        public KLargestInArray()
        {
            dataSet.Add(new Tuple<int, int[]>(3, new int[] { 21, 12, 20, 35, 6, 9, 9, 15 }));
            dataSet.Add(new Tuple<int, int[]>(2, new int[] { 3, 2, 1, 5, 6, 4 }));
        }

        public void Execute()
        {
            //Problem1
            dataSet.ForEach(data =>
            {
                var kthLargest = FindKthLargest(data.Item2, data.Item1);
                Console.WriteLine($"The {data.Item1}th largest element from {string.Join(",", data.Item2)} is {kthLargest}");

                //Problem2
                //var result = FindKLargestElements(data.Item2, data.Item1);
                //Console.WriteLine($"{data.Item1} largest elements from {string.Join(",", data.Item2)} => [{string.Join(",", result)}]");
            });
        }

        /// <summary>
        /// O(n)
        /// </summary>
        public int FindKthLargest(int[] nums, int k)
        {
            // Finding kth largest is (N - k)th smallest
            return search(nums, 0, nums.Length - 1, nums.Length-k);
        }

        private int search(int[] nums, int left, int right, int ksmall)
        {
            if (left == right)
                return nums[left];
            int pivotindex = new Random().Next(left, right);

            pivotindex = partition(nums, left, right, pivotindex);

            // If the pivot is on (N - k)th smallest position
            if (pivotindex == ksmall)
                return nums[pivotindex];
            //search towards left
            else if (ksmall < pivotindex)
                return search(nums, left, pivotindex - 1, ksmall); 
            //search towards right
            return search(nums, pivotindex + 1, right, ksmall);
        }

        private int partition(int[] nums, int left, int right, int pivotindex)
        {
            int pivot = nums[pivotindex];

            swap(nums, right, pivotindex);
            int sortindex = left;
            for(int i=left;i<=right;i++)
            {
                if(nums[i]<pivot)
                {
                    swap(nums, sortindex, i);
                    sortindex++;
                }
            }
            swap(nums, sortindex, right);
            return sortindex;
        }


        private void swap(int[] nums, int x, int y)
        {
            int temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        public int FindKthLargest1(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        /// <summary>
        /// This is problem2
        /// </summary>
        private int[] FindKLargestElements(int[] nums, int k)
        {
            var result = new int[k];
            Array.Sort(nums);
            for (int i = nums.Length-1,j=k-1; i >= nums.Length-k; i--)
            {
                result[j--] = nums[i];
            }

            return result;
        }
    }
}
