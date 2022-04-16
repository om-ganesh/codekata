using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020.Facebook
{
    /// <summary>
    /// Variation of LC#34. Find First and Last Position of Element in Sorted Array
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public class RightMostZeroIndex : IProblem
    {
        IList<List<int>> m_dataSet = new List<List<int>>();

        public RightMostZeroIndex()
        {
            m_dataSet.Add(new List<int> { 0, 1, 1, 1 });
            m_dataSet.Add(new List<int> { 0, 0, 0, 0, 0 });
            m_dataSet.Add(new List<int> { 0, 0, 0, 0, 1 });
            m_dataSet.Add(new List<int> { 1, 1, 1, 1, 1 });
            m_dataSet.Add(new List<int>());
        }
        public void Execute()
        {
            foreach (var data in m_dataSet)
            {
                var result = GetRightMostZeroIndex(data.ToArray());
                Console.WriteLine($"The rightmost 0 in contiguous array {string.Join(",", data)} => {result}");
            }
        }

        private int GetRightMostZeroIndex(int[] arr)
        {
            if(arr.Length == 0)
            {
                return -1;
            }
            // Non-optimal solution
            //return SearchArray(arr);
            
            // Optimal solution uses binary search
            return GetRightMostZeroIndex(arr, 0, arr.Length - 1);

        }

        private int SearchArray(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetRightMostZeroIndex(int[] arr, int left, int right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == 0)
            {
                if (mid + 1 > right || arr[mid + 1] > 0)
                {
                    return mid;
                }
                else
                {
                    return GetRightMostZeroIndex(arr, mid + 1, right);
                }
            }
            else
            {
                if(mid-1 < 0)
                {
                    return -1;
                }
                else
                {
                    return (arr[mid - 1] == 0) ? mid - 1 : GetRightMostZeroIndex(arr, left, mid - 1);
                }
                
            }
        }
    }
}
