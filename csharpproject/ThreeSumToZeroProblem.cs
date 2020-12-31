using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class ThreeSumToZeroProblem : IProblem
    {
        public void Execute()
        {
            //int[] data = new int[]{-1, 0, 1, 2, -1, -4};
            int[] data = new int[] { -2, 0, 1, 1, 2 };
            //int[] data = new int[] { -2,-1,0,1,2,3 };
            var result = ThreeSumToZero(data);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }
        }

        public IList<IList<int>> ThreeSumToZero(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;
                TwoSum(nums, i, results);
            }
            return results;
        }

        private void TwoSum(int[] nums, int indexTarget, IList<IList<int>> results)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int j = indexTarget + 1; j < nums.Length; j++)
            {
                var complement = -nums[indexTarget] - nums[j];

                if (hash.Contains(complement))
                {
                    results.Add(new List<int> { nums[indexTarget], nums[j], complement });
                    while (j != nums.Length - 1 && nums[j] == nums[j + 1])
                    {
                        j++;
                    }
                }
                hash.Add(nums[j]);
            }
        }
    }
}
