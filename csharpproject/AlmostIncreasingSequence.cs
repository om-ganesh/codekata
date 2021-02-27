using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence 
    /// by removing no more than one element from the array.
    /// Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0<a1< ... < an.
    /// Sequence containing only one element is also considered to be strictly increasing.
    /// For sequence = [1, 3, 2, 1], the output should be almostIncreasingSequence(sequence) = false.
    /// There is no one element in this array that can be removed in order to get a strictly increasing sequence.
    /// For sequence = [1, 3, 2], the output should be almostIncreasingSequence(sequence) = true.
    /// </summary>
    class AlmostIncreasingSequence: IProblem
    {
        List<(int[], bool)> dataSet;
        public AlmostIncreasingSequence()
        {
            dataSet = new List<(int[], bool)>();
            dataSet.Add((new int[] { 1, 3, 2, 1 }, false));
            dataSet.Add((new int[] { 1, 3, 2 }, true));
            dataSet.Add((new int[] { 1, 2, 3, 4, 5, 3, 5, 6 },false)); //FALSE
            dataSet.Add((new int[] { 1, 2, 1, 2 },false)); //FALSE
            dataSet.Add((new int[] { 40, 50, 60, 10, 20, 30 },false)); //FALSE
            dataSet.Add((new int[] { 10, 1, 2, 3, 4, },false)); //FALSE
            dataSet.Add((new int[] { 1, 2, 3, 4, 99, 5, 6 },false)); //FALSE
        }

        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                Console.WriteLine($"Is {string.Join(",", data)} strictly increasing? " +
                    $"Expected: {data.Item2}; Observed: {IsAlmostIncreasing(data.Item1)}");
            });
        }

        private bool IsAlmostIncreasing(int[] arr)
        {
            if(arr.Length<2)
            {
                return true;
            }
            int count = 0;
            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i] <= arr[i-1])
                {
                    count++;
                }
                //Verify if the two numbers in sequence are also validating the increasing scenario
                bool preNeighbour = (i - 2 >= 0) ? arr[i] <= arr[i - 2] : false;
                bool nextNeighbour = (i + 2 < arr.Length) ? arr[i + 1] <= arr[i - 1] : false;
                if (preNeighbour || nextNeighbour)
                {
                    count++;
                }
            }
            return count < 2;
        }
    }
}
