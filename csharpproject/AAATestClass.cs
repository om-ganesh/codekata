using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class AAATestClass : IProblem
    {
        public void Execute()
        {
            //int[] data = new int[] {3,3 };
            //var result = TwoSum(data,6);
            //Console.WriteLine(string.Join(",", result));

            int[] data = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            var result = Trap(data);
            Console.WriteLine(string.Join(",", result));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2];
            // Gives the numbers itself
            //HashSet<int> hash = new HashSet<int>(nums);
            //for(int i=0;i< nums.Length;i++)
            //{
            //   if(hash.Contains(target-nums[i]))
            // {
            //    results[0] = nums[i];
            //   results[1] = target-nums[i];
            //  break;
            //}
            //}

            // Gives the indexes
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    results[0] = i;
                    results[1] = dict[target-nums[i]];
                    break;
                }
                dict.Add(nums[i], i);
            }
            return results;
        }
    }
}
