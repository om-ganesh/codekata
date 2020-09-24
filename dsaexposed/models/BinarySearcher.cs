using System;
using System.Collections.Generic;
using System.Text;

namespace DSAExposed.models
{
    
    public class BinarySearcher
    {
        static int count;
        public static void Init()
        {

            int[] arr = new int[] { 1, 4, 8, 9, 12, 34 };
            int element = 38;
            Console.Write($"Searching {element} resulted {Exists(arr, element)} from {count} iterations");
        }

        public static bool Exists(int[] arr, int x)
        {
            return binary_search(arr, x, 0, arr.Length);
        }

        private static bool binary_search(int[] arr, int x, int min, int max)
        {
            count++;
            if(min>=max)
            {
                return false;
            }

            int midIndex = (min + max) / 2;
            int mid = arr[midIndex];
            if (mid == x)
            {
                return true;
            }
            else if (mid > x)
            {
                return binary_search(arr, x, min, midIndex);
            }
            else
            {
                return binary_search(arr, x, midIndex+1, max);   //NOTE: the midIndex for the top part is incremented by 1
            }
        }


    }
}
