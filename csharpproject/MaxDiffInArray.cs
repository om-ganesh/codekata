using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace csharpproject
{
    class MaxDiffInArray : IProblem
    {
        int[] data;
        int diff;
        public void Execute()
        {
            diff = FindMaxDiff(data);
        }

        private int FindMaxDiff(int[] arr)
        {
            int min= arr[0];
            int max=arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min =arr[i];
                }
                if(arr[i]>max)
                {
                    max=arr[i];
                }
            }

            return max-min;
        }

        public void ReadInput()
        {
            //data = new int[]{12,30,7,0,1,88,88 };
            //data = new int[]{12,30,7,0,1,-88,88 };
            data = new int[]{-12,-30,-7,-1,-88,-8 };
        }

        public void ShowResult()
        {
            Console.WriteLine($"The max diff in array {String.Join(",", data)} is {diff}");
        }
    }
}
