using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    static class ArrayExtensions
    {
        public static int[] Trim(this int[] arr)
        {
            int startIndex = 0;
            int endIndex = arr.Length-1;
            bool foundstart = false;
            bool foundend = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (foundstart && foundend)
                    break;
                if (!foundstart && arr[i] != 0)
                {
                    startIndex = i;
                    foundstart = true;
                }
                    
                if (!foundend && arr[arr.Length - i - 1] != 0)
                {
                    endIndex = arr.Length - i - 1;
                    foundend = true;
                }
            }
            List<int> result = new List<int>();
            for(int i=startIndex;i<=endIndex;i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }
    }
}
