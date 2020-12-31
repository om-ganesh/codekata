using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020.Amazon
{
    /// <summary>
    /// https://aonecode.com/amazon-online-assessment-five-star-sellers
    /// </summary>
    class FiveStarSeller : IProblem
    {
        public void Execute()
        {
            int threshold = 77;
            int[][] data = new int[][]
            {
                new int[] {4, 4},
                new int[] {1, 2},
                new int[] {3, 6},
            };
            int result = GetRequiredFiveStars(data, threshold);
            Console.WriteLine($"The result are {result}");
        }

        private int GetRequiredFiveStars(int[][] data, int threshold)
        {
            int result = 0;
            int totalProducts = data.Length;
            //Just converting the given threshold to the sum value (Just for convenience of checking sum, instead of % everytime in loop)
            var reqdSum = threshold * totalProducts * 1.0 / 100;

            double currentSum = 0;
            while (currentSum < reqdSum)
            {
                currentSum = 0;
                double maxContribution = 0;
                int productItem = -1;

                //Loop between given products and try to find adding product in which item will result in max value
                for (int i = 0; i < data.Length; i++)
                {
                    // find difference of adding 1 new 5 start against existing stars
                    var contribution = (data[i][0] + 1) * 1.0 / (data[i][1] + 1) - data[i][0] * 1.0 / data[i][1];
                    if (maxContribution < contribution)
                    {
                        maxContribution = contribution;
                        productItem = i;
                    }
                    currentSum += data[i][0] * 1.0 / data[i][1];
                }

                //Increase sum by adding new sum from the max contribution item (first remove old, and add after added star)
                currentSum = currentSum - data[productItem][0] * 1.0 / data[productItem][1];
                data[productItem][0] = data[productItem][0] + 1;
                data[productItem][1] = data[productItem][1] + 1;
                currentSum = currentSum + data[productItem][0] * 1.0 / data[productItem][1];
                result++;
            }

            return result;
        }
    }
}
