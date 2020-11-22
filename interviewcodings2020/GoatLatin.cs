using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020
{
    /// <summary>
    /// https://leetcode.com/problems/goat-latin/
    /// </summary>
    class GoatLatin : IProblem
    {
        List<string> dataSet = new List<string>();

        public GoatLatin()
        {
            dataSet.Add("I speak Goat Latin");
            dataSet.Add("The quick brown fox jumped over the lazy dog");
        }
        
        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                var result = ToGoatLatin(data);
                Console.WriteLine($"The goat latin for {data} => {result}");
            });
        }

        /// <summary>
        /// 
        /// </summary>
        private String ToGoatLatin(String S)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder wordend = new StringBuilder("ma");

            int startIndex = 0;
            int endIndex = 0;
            while(endIndex<S.Length)
            {
                //Move ahead until the word is finished
                while(endIndex < S.Length && S[endIndex] != ' ')
                {
                    endIndex++;
                }

                wordend = wordend.Append("a");
                if (!IsVowelCharacter(S[startIndex]))
                {
                    result.Append(string.Concat(S.Substring(startIndex + 1, endIndex - startIndex - 1), S[startIndex], wordend, endIndex < S.Length ? " " : ""));
                }
                else
                {
                    result.Append(string.Concat(S.Substring(startIndex, endIndex - startIndex), wordend, endIndex < S.Length ? " " : ""));
                }

                //reset startindex for next word
                endIndex++;
                startIndex = endIndex;
            }
            return result.ToString();
        }

        /// <summary>
        /// 100ms (faster than only 7%) and 24MB (lower than only 40%)
        /// </summary>
        private String ToGoatLatin1(String S)
        {
            List<string> goatList = new List<string>();
            int wordIndex = 1;
            foreach(string str in S.Split(new char[] { ' ' }))
            {
                if(IsVowelCharacter(str[0]))
                {
                    goatList.Add(new StringBuilder(str).Append("ma").Append(GetSuffix(wordIndex++)).ToString());
                }
                else
                {
                    goatList.Add(new StringBuilder(str.Substring(1)).Append(str[0]).Append("ma").Append(GetSuffix(wordIndex++)).ToString());
                }
            }
            
            return string.Join(" ", goatList.ToArray());
        }

        private string GetSuffix(int counter)
        {
            StringBuilder aStr = new StringBuilder();
            while (counter-- > 0)
            {
                aStr.Append("a");
            }
            return aStr.ToString();
        }
        private bool IsVowelCharacter(char ch)
        {
            return ch == 'a' || ch == 'A'
                || ch == 'e' || ch == 'E'
                || ch == 'i' || ch == 'I'
                || ch == 'o' || ch == 'O'
                || ch == 'u' || ch == 'U';
        }
    }
}
