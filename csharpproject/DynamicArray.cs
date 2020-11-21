using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpproject
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/dynamic-array/problem
    /// </summary>
    class DynamicArray : IProblem
    {
        int inputSize;
        List<int>[] seqList;
        List<List<int>> queries;

        public DynamicArray()
        {
            Console.WriteLine("How many input you want?");
            inputSize = Convert.ToInt32(Console.ReadLine());
            seqList = new List<int>[inputSize];

            Console.WriteLine("Input (QueryType) (Number X) (Number Y)");
            queries = new List<List<int>>();
            for (int i = 0; i < inputSize; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

        }

        //Query1: 1 0 5 => Apply Query1 with logic: Append y/5 to sequence (x/0 xor lastAnswer/0) % N/2
        //Query1: 1 1 7 =>  Apply Query1 with logic: Append 7 to sequence (1 xor 0)%2
        public void Execute()
        {
            var result = new List<int>();
            int lastAnswer = 0;

            foreach (List<int> line in queries)
            {
                int sequence = (line[1] ^ lastAnswer) % 2;
                switch (line[0])
                {
                    case 1:
                        if (seqList[sequence] == null)
                        {
                            seqList[sequence] = new List<int>();
                        }
                        seqList[sequence].Add(line[2]);
                        break;
                    case 2:
                        var sequenceSize = seqList[sequence].Count;
                        lastAnswer = seqList[sequence][line[2] % sequenceSize];
                        result.Add(lastAnswer);
                        break;
                }
            }
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
