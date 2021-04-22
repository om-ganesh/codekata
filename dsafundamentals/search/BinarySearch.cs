using System;
using System.Collections.Generic;
using System.Text;

namespace search
{
    public class BinarySearch
    {
        int[] arr;
        public BinarySearch(int[] a)
        {
            arr = a;
        }
        public bool Search(int x)
        {
            return binary_search(x, 0, arr.Length);
        }

        private bool binary_search(int x, int min, int max)
        {
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
                return binary_search(x, min, midIndex);
            }
            else
            {
                return binary_search(x, midIndex+1, max);   //NOTE: the midIndex for the top part is incremented by 1
            }
        }


    }
}
