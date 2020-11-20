using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://interviewing.io/recordings/Python-JPMorgan-1/
    /// </summary>
    class MinimumSubstring : IProblem
    {
        List<Tuple<char[], string>> dataset = new List<Tuple<char[], string>>();
        public MinimumSubstring()
        {
            char[] arr = new char[] { 'a', 'b', 'c' };
            string str = "aboycame";
            dataset.Add(new Tuple<char[], string>(arr, str));
        }

        public void Execute()
        {
            dataset.ForEach(data =>
            {
                var result = MinSubString(data.Item1, data.Item2);
                Console.WriteLine($"The minimum substring from {data.Item2} with characters {string.Join(",",data.Item1)} is {result}");
            });
        }
       
        private string MinSubString(char[] arr, string str)
        {
            int[] visited = new int[arr.Length];

            HashSet<char> remainingChars = new HashSet<char>(arr);

            //TODO 
            //for(int left=0,right=0; ;)
            //{
            //    if(remainingChars.Count>0)
            //    {
            //        if (remainingChars.Contains(arr[right]))
            //        {
            //            remainingChars.Remove(arr[right]);
            //        }
            //        right++;
            //    }
            //    else if()


            //}

            return null;
        }

        public void ShowResult()
        {
        }
    }
}
