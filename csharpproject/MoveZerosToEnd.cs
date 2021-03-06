﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class MoveZerosToEnd : IProblem
    {
        public void Execute()
        {
            // int[] arr = new int[] { 5,0, 1, 0, 3, 12 };
            int[] arr = new int[] { 2,1,2,2,2,3,4,2 };
            Console.WriteLine($"Before Moving: {string.Join(",", arr)}");
            MoveZeroes1(arr);
            Console.WriteLine($"After Moving: {string.Join(",", arr)}");
        }

        // This algorithm does n writes (so doesn't address another issue of less writes)
        // eg. {2,3,4,5,6,-2,0} it will perform n writes for this example
        public void MoveZeroesNonOptimal(int[] nums)
        {
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[cnt++] = nums[i];
                }
            }
            for (int i = cnt; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public void MoveZeroes1(int[] arr)
        {
            int offset = -1;
            int count = 0;
            int toMove = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                // Keep i pointer on the tomove element
                if (arr[i] != toMove)
                {
                    offset++;
                    if (offset < i)
                    {
                        arr[offset] = arr[i];
                    }
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(offset + "--" + string.Join(",", arr));
            offset++;
            while (offset < arr.Length)
            {
                arr[offset++] = toMove;
            }
        }

        public void MoveZeroes(int[] nums)
        {
            int cnt = 0;
            int i = 0;
            while (i + cnt < nums.Length)
            {
                while (i + cnt < nums.Length && nums[i + cnt] == 0)
                {
                    cnt++;
                }
                if (i + cnt >= nums.Length)
                {
                    break;
                }
                nums[i] = nums[i + cnt];
                i++;
            }
            while (i < nums.Length)
            {
                nums[i] = 0;
                i++;
            }
        }

        // Take the solution reference from leetcode (Pointer concept)
        //public void MoveZeroesShortAndOptimal(int[] nums)
        //{
        //    int cnt = 0;
        //    int lastFoundNonZero = -1;
        //    for(int i=0; lastFoundNonZero +cnt< nums.Length;i++)
        //    {
        //        if (nums[i] != 0)
        //        {
        //            lastFoundNonZero++;
        //            if (lastFoundNonZero < i)
        //            {
        //                nums[lastFoundNonZero] = nums[i];
        //            }
        //        }
        //        else
        //        {
        //            cnt++;
        //        }
        //    }
        //    while (lastFoundNonZero < nums.Length)
        //    {
        //        nums[lastFoundNonZero++] = 0;
        //    }
        //}

    }
}
