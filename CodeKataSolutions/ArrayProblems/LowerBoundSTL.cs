using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProblems
{
    /// <summary>
    /// Source:
    /// https://www.hackerrank.com/challenges/cpp-lower-bound/problem
    /// Input: 
    /// N integers in sorted order
    /// Q queries, with an integer in each query
    /// Problem:
    /// If the given query integer is present in array, return the index. If multiple, return first one
    /// If the given query integer is not present in array, return index at which the smallest integer that is greater than the 
    /// given number is present
    /// Hint:
    /// Use Lower bound functino with sorted vector
    /// Assumption:
    /// There will always be an answer for the query
    /// </summary>

    class LowerBoundSTL
    {
        int m_inputCount = 0;
        int[] m_inputList;
        int m_queryCount = 0;
        int[] m_queryList;
        List<Tuple<string, int>> m_resultList;

        public LowerBoundSTL(int n, int[] nList, int q, int[] qList)
        {
            this.m_inputCount = n;
            this.m_inputList = nList;
            this.m_queryCount = q;
            this.m_queryList = qList;
            this.m_resultList = new List<Tuple<string, int>>();
        }

        public void Execute()
        {
            foreach(int q in m_queryList)
            {
                for(int i=0; i< m_inputList.Length; i++)
                {
                    if(m_inputList[i]>=q)
                    {
                        m_resultList.Add(new Tuple<string, int>((m_inputList[i] == q) ? "Yes" : "No", i+1));
                        break;
                    }
                }
            }
        }

        public void ShowResult()
        {
            foreach(Tuple<string, int> item in m_resultList)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }
        }
    }
}
