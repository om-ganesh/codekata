using System;
using System.Collections;
using System.Collections.Generic;

namespace interviewcodings2018
{
    /// <summary>
    /// Given an array, find if the sum of any pair is equal to N or not?
    /// </summary>
    class ArrayElementSumToN
    {

        public static void Init()
        {

            int[] arr = { 1, 32, 125, 12, 5, 10, 25 };
            int n = 3;
            Console.WriteLine($"The sum of any pair equals to {n} using O(nlogn) : {HasPairWithSum(arr,n)}");

            Console.WriteLine($"The sum of any pair equals to {n} using O(n) : {HasPairWithSumOptimized(arr, n)}");

            n = 8;
            Tuple<bool, int, int> exists = GivePairWithSum(new int[] { 1,2,4,4}, n);
            if(exists.Item1)
            {
                Console.WriteLine($"The two pairs that summed to {n} are {exists.Item2} and {exists.Item3}");
            } else
            {
                Console.WriteLine($"The two pairs equals to {n} doesn't exist in given array");
            }
            
        }

        /// <summary>
        /// Given a sorted array, find if the sum of any pair is equal to N or not?
        /// </summary>
        private static Tuple<bool, int,int> GivePairWithSum(int[] arr, int n)
        {
            Tuple<bool, int, int> defaultTuple = new Tuple<bool, int, int>(false, 0, 0);
            if (arr == null || arr.Length<2)
            {
                return defaultTuple;
            }
            int i = 0, j = arr.Length - 1;
            while(i<j)
            {
                int sum = arr[i] + arr[j];
                if(sum == n)
                {
                    return new Tuple<bool, int, int>(true, arr[i], arr[j]);
                } else if (sum >n)
                {
                    j--;
                } else
                {
                    i++;
                }
            }
            return defaultTuple;
        }

        //Complexity is O(n*logn) using the merge/quick sort
        private static bool HasPairWithSum(int[] arr, int n)
        {
            Array.Sort(arr);
            int i = 0, j = arr.Length - 1;
            while(i<j)
            {
                int sum = arr[i] + arr[j];
                if(sum == n)
                {
                    return true;
                } else if(sum > n)
                {
                    j = j - 1;
                } else
                {
                    i = i + 1;
                }

            }
            return false;
        }


        //Optimize using Dictionary which can be solved in O(n)
        private static bool HasPairWithSumOptimized(int[] arr, int n)
        {
            ICollection<int> hash = new HashSet<int>();
            for(int i=0,j=arr.Length-1;i<j;i++,j--)
            {
                int nextInt1 = n - arr[i];
                int nextInt2 = n - arr[j];

                if (hash.Contains(nextInt1)||hash.Contains(nextInt2))
                {
                    return true;
                }
                hash.Add(arr[i]);
                hash.Add(arr[j]);
            }
            return false;
        }
    }
}
