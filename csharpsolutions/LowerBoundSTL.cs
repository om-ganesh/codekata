using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharpsolutions
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

    class LowerBoundSTL : IProblem
    {
        // Input/Output variables
        List<int> m_inputList = new List<int>();
        List<int> m_queryList = new List<int>();
        List<Tuple<string, int>> m_resultList;

        public LowerBoundSTL()
        {
            //LowerBoundSTL Problem
            Console.WriteLine("Input 8 integer array in sorted order");
            m_inputList.AddRange(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(t => Convert.ToInt32(t)));

            Console.WriteLine("Test Array size:4");
            m_queryList.AddRange(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(t => Convert.ToInt32(t)));

        }
        
        public void Execute()
        {
            m_resultList = new List<Tuple<string, int>>();
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

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            //Show results
            Console.WriteLine($"The elements {string.Join(',', m_queryList)} appears(YES/NO with index) in {string.Join(',', m_inputList)}");
            foreach (Tuple<string, int> item in m_resultList)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
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
    }
}
