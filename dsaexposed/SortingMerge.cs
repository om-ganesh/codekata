using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dsaexposed
{
    class SortingMerge
    {
        static int[] input;
        public static void Init()
        {
            //Give input array separated by space
            input = new int[] { 8, -5, 3, 0, 1, 4, -2 };
            //input = new int[] { 8, 5, 3, 6, 1, 4, 2 };
            //input = new int[] { 5,4,3,2,1 };
            Console.WriteLine($"The input array is: [{string.Join(",", input)}]");
            var output = Sort(input);
            Console.WriteLine($"The sorted array is: [{string.Join(",", output)}]");
        }

        private static int[] Sort(int[] x)
        {
            if(x.Length<=2)
            {
                if (x.Length == 1)
                {
                    return new int[] { x[0] };
                }
                else
                {
                    var small = x[0];
                    var large = x[1];
                    if(x[0]>x[1])
                    {
                        small = x[1];
                        large = x[0];
                    }
                    return new int[] { small, large};

                }
            }

            int[] left = new int[x.Length/2];
            int[] right = new int[x.Length-x.Length/2];
            Array.Copy(x,left, x.Length/2);
            Array.Copy(x, x.Length/2, right,0,x.Length-x.Length/2);
            var leftSort = Sort(left);
            var rightSort = Sort(right);
            var result = Merge(leftSort, rightSort);
            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] c = new int[left.Length+right.Length];
            int i = 0, j=0;
            for (int k = 0; k<c.Length ; k++)
            {
                if(j>=right.Length)
                {
                    c[k] = left[i];
                    i++;
                }
                else if (i >= left.Length)
                {
                    c[k] = right[j];
                    j++;
                }
                else if(left[i]<right[j])
                {
                    c[k] = left[i];
                    i++;
                }
                else if(right[j]<left[i])
                {
                    c[k] = right[j];
                    j++;
                }
            }
            return c;
        }
    }
}
