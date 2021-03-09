using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// The client sends a wildcard query that is sent to the server. The only wildcard entry you need to support is the ones with one or multiple
    /// question marks (?), where ? stands for any arbitary letter. 
    /// Example: query=a?t, words=art, eat,arm, will return you ["art"] as this word only satisfies the query
    /// </summary>
    class WildcardWordProcess : IProblem
    {
        List<(string, List<string>)> dataSet;

        public WildcardWordProcess()
        {
            dataSet = new List<(string, List<string>)>();
            dataSet.Add(("a?t", new List<string>() { "art", "ab", "arc", "ant", "pls", "apt"}));
            dataSet.Add(("m??o", new List<string>() { "most", "mero", "momo", "my"  }));
            dataSet.Add(("zyo", new List<string>() { "ost", "ero", "omo", "my"  }));
            dataSet.Add(("g?d", new List<string>() { "ram", "demo", "hello", "hel", "cake", "vim", "rom", "rkm"  }));
            dataSet.Add(("??m", new List<string>() { "ram", "demo", "hello", "hel", "cake", "vim", "rom", "rkm"  }));
            dataSet.Add(("ra?", new List<string>() { "ram", "demo", "hello", "hel", "cake", "vim", "rom", "rkm"  }));
        }

        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                var result = FindAllMatchings(data.Item1, data.Item2);
                Console.WriteLine($"The words matching {data.Item1} => {string.Join(",", result)}");
            });
        }

        private List<string> FindAllMatchings(string wildcard, List<string> words)
        {
            List<string> result = new List<string>();
            foreach(string word in words)
            {
                if(IsMatched(wildcard, word))
                {
                    result.Add(word);
                }
            }
            return result;
        }

        /// Approach2: We can find either end offsets and only check chars from 0th index to firstoffset and lastoffset to end of string
        private bool IsMatched(string wildcard, string word)
        {
            if (wildcard.Length != word.Length)
            {
                return false;
            }

            int firstIndex = wildcard.IndexOf('?');
            int lastIndex = wildcard.LastIndexOf('?');

            // Edge cases: If there are no any wildcards then firstIndex will be -ve and we need to check all chars
            if(firstIndex<0)
            {
                return wildcard.Equals(word);
            }

            // Edge case2: If there is wildcard(s) at the first char  only
            // no worries first pass will not execute, and all tests will be done by second pass 
            for (int i = 0; i<firstIndex; i++)
            {
                if (wildcard[i] != word[i])
                {
                    return false;
                }
            }

            // Edge case2: If there is wildcard(s) at the last char only
            // no worries second pass will not execute, and all tests will be done by first pass
            for (int i = lastIndex+1; i < wildcard.Length; i++)
            {
                if (wildcard[i] != word[i])
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsMatchedOld(string wildcard, string word)
        {
            if(wildcard.Length != word.Length)
            {
                return false;
            }

            for(int i=0; i<wildcard.Length;i++)
            {
                if (wildcard[i] == '?')
                {
                    continue;
                }
                if(wildcard[i] != word[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
