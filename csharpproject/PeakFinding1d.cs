using System;
using System.Linq;

namespace csharpproject
{
    /// <summary>
    /// For a array of numbers, find the peak, if it exists
    /// Example [a,b,c,d,e,f,g,h,i]
    /// Position 2 is peak iff b>=a and b>=c, in edge, only look on one side
    /// </summary>
    class PeakFinding1d : IProblem
    {
        int[] data;
        int peak;
        public void Execute()
        {
            peak = FindPeak(0, data.Length-1, data);
        }

        private int FindPeak(int l, int r, int[] arr)
        {
            int result = -1;
            int m = l + (r-l)/2;
            if (m!=0 && arr[m] < arr[m - 1])
            { 
                result = FindPeak(l, m-1, arr);
            }
            else if (m!=arr.Length-1 && arr[m]< arr[m+1])
            {
                result = FindPeak(m+1, r, arr);
            }
            else
                return m;
            return result; //Not found
        }

        public void ReadInput()
        {
            //data = new int[]{1,2,33,30,22,20,19,13,4,4 };
            //data = new int[]{4,9,8,7,6,5,4 };
            //data = new int[]{1,2,6,7,8,9,2};
            //data = new int[]{1,2,3,4,3,2,1};
            //data = new int[]{1,2,3,4 };
            data = new int[]{4,3,2 };
        }

        public void ShowResult()
        {
            string result = peak == -1 ? "Not Found": data[peak].ToString();
            System.Console.WriteLine($"The peak for {string.Join(",", data)} is {result}");
        }
    }
}