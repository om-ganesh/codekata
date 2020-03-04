using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// Source:
    /// https://www.hackerrank.com/challenges/dynamic-array/problem
    /// </summary>
    class DynamicArray
    {
        int lastAnswer = 0;
        List<int> lastAnswerList;
        int N;
        List<int>[] seqList;

        public DynamicArray(int size)
        {
            this.N = size;
            seqList = new List<int>[N];
            lastAnswerList = new List<int>();
        }

        public List<int> Execute(List<List<int>> queries)
        {
            foreach (List<int> line in queries)
            {
                Process(line[0], line[1], line[2]);
            }
            return lastAnswerList;
        }

        //Query1: 1 0 5 => Apply Query1 with logic: Append y/5 to sequence (x/0 xor lastAnswer/0) % N/2
        //Query1: 1 1 7 =>  Apply Query1 with logic: Append 7 to sequence (1 xor 0)%2
        void Process(int choice, int x, int y)
        {
            int sequence = (x ^ lastAnswer) % N;
            switch (choice)
            {
                case 1:
                    if(seqList[sequence] == null)
                    {
                        seqList[sequence] = new List<int>();
                    }
                    seqList[sequence].Add(y);
                    break;
                case 2:
                    var sequenceSize = seqList[sequence].Count;
                    lastAnswer = seqList[sequence][y % sequenceSize];
                    lastAnswerList.Add(lastAnswer);
                    break;
            }
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
