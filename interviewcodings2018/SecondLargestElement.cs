using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    public class SecondLargestElement
    {
        public static void Init()
        {
            int[] arr = { 1, 3, 4, 5, 0, 2 };
            Console.WriteLine($"The 2nd largest element is {FindSecondLargest(arr)}");
        
        }

        public static int? FindSecondLargest(int[] arr)
        {
            if (arr.Length<2)
            {
                return null;
            }
            int? max = null;
            int? maxx = null;

            for(int i=0;i<arr.Length;i++)
            {
                if(max == null)
                {
                    max = arr[i];
                }else if (arr[i]>max)
                {
                    maxx = max;
                    max = arr[i];
                }else if (maxx==null)
                {
                    maxx = arr[i];
                }else if(maxx<arr[i])
                {
                    maxx = arr[i];
                }
            }
            return maxx;
        }
    }
}
