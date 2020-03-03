using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array Problems!");

            //Problem1: LowerBoundSTL
            // RunLowerBoundSTL();

            //Problem2: DynamicArray
            RunDynamicArray();

            Console.ReadLine();
        }


        static void RunLowerBoundSTL()
        {
            //LowerBoundSTL Problem
            int n = 8;
            int[] nArray = { 1,1,2,3,6,9,9,15};
            int q = 4;
            int[] qArray = { 1,4,9,15};

            LowerBoundSTL lBoundSTL = new LowerBoundSTL(n, nArray, q, qArray);
            lBoundSTL.Execute();
            lBoundSTL.ShowResult();
        }



        static void RunDynamicArray()
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            DynamicArray dynamicArray = new DynamicArray(n);
            List<int> result = dynamicArray.Execute(queries);
            Console.WriteLine(String.Join("\n", result));
        }

    }
}
