using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    /// <summary>
    /// Given two char sequences, find the length of longest subsequence present in both of them.
    /// </summary>
    class LongestSequenceBetweenStrings
    {
        static Dictionary<WordPair, int> memory;
        public static void Init()
        {
            string word1 = "SUBASH GITA";
            string word2 = "SUGITA";

            int length = FindLongestSubString(word1, word2);
            Console.WriteLine($"The longest substring length for {word1} and {word2} is {length}");
        }

        private static int FindLongestSubString(string word1, string word2)
        {
            if(memory == null)
            {
                memory = new Dictionary<WordPair, int>();
            }
            
            if(word1.Length<1 || word2.Length<1)
            {
                return 0;
            }
            if (word1[word1.Length-1].Equals(word2[word2.Length - 1]))
            {
                word1 = word1.Substring(0, word1.Length - 1);
                word2 = word2.Substring(0, word2.Length - 1);
                int length;
                if (memory.ContainsKey(new WordPair(word1, word2)))
                {
                    length = memory[new WordPair(word1, word2)];
                }
                else
                {
                    length = FindLongestSubString(word1, word2);
                    memory.Add(new WordPair(word1, word2), length);
                }
                return 1 + length;
            } else
            {
                string word1new = word1.Substring(0, word1.Length - 1);
                string word2new = word2.Substring(0, word2.Length - 1);
                int length1;
                int length2;
                if (memory.ContainsKey(new WordPair(word1, word2new)))
                {
                    length1 = memory[new WordPair(word1, word2new)];
                }
                else
                {
                    length1 = FindLongestSubString(word1, word2new);
                    memory.Add(new WordPair(word1, word2new), length1);
                }
                if (memory.ContainsKey(new WordPair(word1new, word2)))
                {
                    length2 = memory[new WordPair(word1new, word2)];
                }
                else
                {
                    length2 = FindLongestSubString(word1new, word2);
                    memory.Add(new WordPair(word1new, word2), length2);
                }
                return length1 > length2 ? length1 : length2;
            }
        }

        private class WordPair
        {
            string word1;
            string word2;

            public WordPair(string word1, string word2)
            {
                this.word1 = word1;
                this.word2 = word2;
            }
        }
    }
}
