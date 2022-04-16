using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020.Facebook
{
    public class FirstAndLastElementInArray : IProblem
    {
        public void Execute()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10, 12 };
            int target = 11;
            var result = SearchRange(nums, target);
            Console.WriteLine($"The first, last occurence of {target} is ({result[0]},{result[1]})");
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int start = -1;
            int end = -1;

            if (nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }
            start = SearchFirstOccurence(nums, target, 0, nums.Length - 1);
            end = SearchLastOccurence(nums, target, 0, nums.Length - 1);

            return new int[] { start, end };
        }

        private int SearchFirstOccurence(int[] nums, int target, int left, int right)
        {
            if (left >= right)
            {
                return nums[left] == target ? left : -1;
            }
            int mid = left + (right - left) / 2;
            Console.WriteLine($"mid={mid},left={left},right={right}");

            if (nums[mid] == target)
            {
                if (mid == left || nums[mid - 1] < target)
                {
                    return mid;
                }
                else
                {
                    return SearchFirstOccurence(nums, target, left, mid - 1);
                }
            }
            else
            {
                if (nums[mid] < target)
                {
                    return SearchFirstOccurence(nums, target, mid + 1, right);
                }
                else
                {
                    return SearchFirstOccurence(nums, target, left, mid - 1);
                }
            }
        }

        private int SearchLastOccurence(int[] nums, int target, int left, int right)
        {
            if (left >= right)
            {
                return nums[left] == target ? left : -1;
            }

            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                if (mid == right || nums[mid + 1] > target)
                {
                    return mid;
                }
                else
                {
                    return SearchLastOccurence(nums, target, mid + 1, right);
                }
            }
            else
            {
                if (nums[mid] < target)
                {
                    return SearchLastOccurence(nums, target, mid + 1, right);
                }
                else
                {
                    return SearchLastOccurence(nums, target, left, mid - 1);
                }
            }
        }
    }
}
