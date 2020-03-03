using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    class SparseArray
    {
        internal int[] MatchingStrings(string[] strings, string[] queries)
        {
            int[] result = new int[queries.Length];

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

            return result;
        }
    }
}
