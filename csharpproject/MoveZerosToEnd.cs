using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class MoveZerosToEnd : IProblem
    {
        public void Execute()
        {
            int[] arr = new int[] { 5,0, 1, 0, 3, 12 };
            Console.WriteLine($"Before Moving: {string.Join(",", arr)}");
            MoveZeroes(arr);
            Console.WriteLine($"After Moving: {string.Join(",", arr)}");
        }


        public void MoveZeroes(int[] nums)
        {
            int cnt = 0;
            int i = 0;
            while (i + cnt < nums.Length)
            {
                while (i + cnt < nums.Length && nums[i + cnt] == 0)
                {
                    cnt++;
                }
                if (i + cnt >= nums.Length)
                {
                    break;
                }
                nums[i] = nums[i + cnt];
                i++;
            }
            while (i < nums.Length)
            {
                nums[i] = 0;
                i++;
            }
        }
    }
}
