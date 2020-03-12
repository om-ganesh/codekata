using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    class AmznBlock
    {
        public static int Execute(int[] inputArray)
        {
            int qty = 0;
            // Trim away the leading and trailing 0s from input array
            int[] arr = inputArray.Trim();
            int start = arr[0];
            int end = GetMyClosing(0, arr);
            for(int i =1; i< arr.Length-1; i++)
            {
                if(arr[i]==end)
                {
                    start = arr[i];
                    end = GetMyClosing(i, arr);
                }
                else
                {
                    qty += (start<end?start:end)- arr[i];
                }
                if (end == 0)
                    break;
            }

            return qty;
        }

        private static int GetMyClosing(int index, int[] arr)
        {
            int myClosing = 0;
            for(int i =index+1; i<arr.Length;i++)
            {
                if (arr[i] >= arr[index])
                    return arr[i];
                
                if (arr[i] > myClosing)
                    myClosing = arr[i];
            }
            return myClosing;
        }
    }
}
