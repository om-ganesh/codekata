using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.Text;


namespace csharpproject
{
    class KLargestInArray : IProblem
    {
        int k;
        int[] arr;
        int[] result;
        public KLargestInArray()
        {
            this.arr = new int[] { 1, 1, 2, 3, 6, 9, 9, 15 };
            this.k = 3;
        }

        public void Execute()
        {
            result = new int[k];
            //copy first 3 to result
            Array.Copy(arr, result, k);

            for(int i = k; i<arr.Length;i++)
            {
                if(arr[i]>smallest(result,out int index))
                {
                    result[index] = arr[i];
                }
            }
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            Console.WriteLine($"Showing {k} largest element from input array {string.Join(",", arr)}");
            Console.Write(String.Join("\n", result));
        }

        private int smallest(int[] arr, out int index)
        {
            index = 0; 
            int small = arr[index];
            for(int i=1;i<arr.Length;i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                    index = i;
                }
            }
            return small;
        }

    }
}
