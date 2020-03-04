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

            // RunLowerBoundSTL();
            // RunDynamicArray();
            RunSparseArray();

            Console.ReadLine();
        }

        static void RunSparseArray()
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            SparseArray sparseArray = new SparseArray();
            int[] result = sparseArray.MatchingStrings(strings, queries);
            Console.WriteLine(string.Join("\n", result));
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
