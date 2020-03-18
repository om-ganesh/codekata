using System;
using System.Collections.Generic;
using System.Text;

namespace csharpsolutions
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sparse-arrays/problem
    /// </summary>
    class SparseArray : IProblem
    {
        string[] strings;
        string[] queries;
        int[] result;

        public SparseArray()
        {
            Console.WriteLine("Size of source array?");
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            strings = new string[stringsCount];

            Console.WriteLine($"Input {stringsCount} strings");
            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            Console.WriteLine("Size of target array?");
            int queriesCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {stringsCount} target strings");

            queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }
        }

        public void Execute()
        {
            result = new int[queries.Length];

            Array.Sort(strings);
            for(int i=0; i< queries.Length;i++)
            {
                int index = Array.IndexOf(strings, queries[i]);
                if (index < 0)
                    result[i] = 0;
                else if (index == strings.Length-1)
                    result[i] = 1;
                else
                {
                    var count = 0;
                    while(index < strings.Length && strings[index++].Equals(queries[i]))
                    {
                        count++;
                    }
                    result[i] = count;
                }
            }
        }

        public void ShowResult()
        {
            Console.WriteLine($"The array {string.Join(',',queries)} appears these times in {string.Join(',', strings)}");
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
