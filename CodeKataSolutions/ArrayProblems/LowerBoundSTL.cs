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
        List<int> m_inputList;
        List<int> m_queryList;
        List<Tuple<string, int>> m_resultList;

        public LowerBoundSTL(List<int> nList, List<int> qList)
        {
            this.m_inputList = nList;
            this.m_queryList = qList;
            this.m_resultList = new List<Tuple<string, int>>();
        }

        public void Execute()
        {
            foreach(int q in m_queryList)
            {
                var lb = LowerBound(m_inputList, q); 
                var ub = UpperBound(m_inputList, q);
                if(q < m_queryList[0])
                    m_resultList.Add(new Tuple<string, int>("No", 1));
                else if (q == m_queryList[0])
                    m_resultList.Add(new Tuple<string, int>("Yes", 1));
                else if (q > m_queryList[m_queryList.Count-1])
                    m_resultList.Add(new Tuple<string, int>("No", -1));
                else
                {
                    m_resultList.Add(new Tuple<string, int>(ub[0] == q ? "Yes": "No", lb.Count+1));
                }
            }
        }

        private List<int> LowerBound(List<int> input, int query)
        {
            List<int> lower = new List<int>();
            foreach(int x in input)
            {
                if (x >= query)
                    break;
                lower.Add(x);
            }
            return lower;
        }

        private List<int> UpperBound(List<int> input, int query)
        {
            List<int> upper = new List<int>();
            foreach (int x in input)
            {
                if (x < query)
                    continue;
                upper.Add(x);
            }
            return upper;
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
