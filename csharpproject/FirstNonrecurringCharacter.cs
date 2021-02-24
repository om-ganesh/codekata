using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class FirstNonrecurringCharacter:IProblem
    {
        List<string> dataSet;
        public FirstNonrecurringCharacter()
        {
            dataSet = new List<string>();
            dataSet.Add("leetcode");
            dataSet.Add("loveleetcode");
            dataSet.Add("abacabad");
            dataSet.Add("abacabaabacaba");
        }

        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                Console.WriteLine($"First non-recurring character is {FirstUniqChar(data)}");
            });
        }


        private char FirstUniqChar(string s)
        {
            int[] hist = new int[26];
            foreach (char ch in s)
            {
                hist[ch - 97]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (hist[s[i]-97] == 1)
                {
                    return s[i];
                }
            }
            return '_';
        }

        private char FirstNotRepeatingCharacter(string s)
        {
            Dictionary<char, bool> dict = new Dictionary<char, bool>();
            foreach (char ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = false;
                }
                else
                {
                    dict.Add(ch, true);
                }
            }
            foreach (char ch in s)
            {
                if (dict[ch] == true)
                {
                    return ch;
                }
            }
            return '_';
        }

    }
}
