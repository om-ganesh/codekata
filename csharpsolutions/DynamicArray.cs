using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpsolutions
{
    /// <summary>
    /// Source:
    /// https://www.hackerrank.com/challenges/dynamic-array/problem
    /// </summary>
    class DynamicArray : IProblem
    {
        int inputSize;
        List<int>[] seqList;
        List<List<int>> queries;
        List<int> result;

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
            result = new List<int>();
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
        }

        public void ShowResult()
        {
            Console.WriteLine("Solution for https://www.hackerrank.com/challenges/dynamic-array/problem");
            Console.WriteLine(String.Join("\n", result));
        }


        //Old methods
        //static void RunDynamicArray()
        //{
        //    int n = 2;

        //    DynamicArray dynamicArray = new DynamicArray(n);

        //    Console.WriteLine("How many Queries?");
        //    int q = Convert.ToInt32(Console.ReadLine());
        //    for(int i=0; i<q; i++)
        //    {
        //        Console.WriteLine($"==== QUERY {i+1} =========");
        //        Console.WriteLine("Input (QueryType) (Number X) (Number Y)");
        //        string inputString = Console.ReadLine();
        //        var inputs = inputString.Split(' ');
        //        dynamicArray.Execute(Convert.ToInt32(inputs[0]), Convert.ToInt32(inputs[1]), Convert.ToInt32(inputs[2]));
        //    }

        //    dynamicArray.ShowResult();

        //}

        //public void ShowResult()
        //{
        //    lastAnswerList.ForEach(x => Console.WriteLine(x));
        //}
    }
}
