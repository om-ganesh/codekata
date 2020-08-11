using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpproject
{

    /// <summary>
    /// Q1. Can we have duplicate entries?
    /// Q2. If we have single entry {2}, do we consider it as range 1 or 0?
    /// Q3. What result we want if the array input is empty?
    /// </summary>
    class ArrayRangeFind : IProblem
    {
        int[] input;
        int maxRange = 0;
        public ArrayRangeFind()
        {
            input =  new int[] { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6 };
        }

        public void Execute()
        {
            List<int[]> data = new List<int[]>();
            data.Add(new []{1});
            data.Add(new []{2, 3});
            data.Add(new []{ 1, 11, 3, 13 });
            data.Add(new []{ 1, 11, 3, 0, 15, 9, 2, 4, 10, 7, 12, 8 });
            data.Add(new []{ 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 13, 6, 12, 14, 16, 18, 19, 17 });
            data.Add(new []{ -1, 11, 3, 0, 15, 5, -2, 4, 10, 7, 13, 6 });

            data.ForEach(dt =>
            {
                maxRange = GetRange(dt);
                Console.WriteLine($"The range for array [{string.Join(",", dt)}] = {maxRange}");
            });
            
        }

        private int GetRange(int[] inArray)
        {
            // Clone input array and sort it
            int result = 0;
            int[] arr = new int[inArray.Length];
            Array.Copy(inArray, arr, inArray.Length);
            Array.Sort(arr);

            int currentRange = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentRange = (arr[i + 1] - arr[i] == 1) ? currentRange + 1 : 0;
                if (currentRange > result)
                {
                    result = currentRange;
                }
            }
            return result;
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            Console.WriteLine($"The highest range is {maxRange}");
        }
    }
}
