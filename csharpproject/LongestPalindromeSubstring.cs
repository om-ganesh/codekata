using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/longest-palindrome-in-a-string/0
    /// </summary>
    class LongestPalindromeSubstring : IProblem
    {
        List<string> dataset = new List<string>();

        public LongestPalindromeSubstring()
        {
            //dataset.Add("o");
            //dataset.Add("mm");
            dataset.Add("lol");
            //dataset.Add("aaaabbaa");
            //dataset.Add("abcvfaafx");
            //dataset.Add("rfkqyuqfjkxy");
            //dataset.Add("rfafkqyuqaqjkxy");

        }
        public void Execute()
        {
            dataset.ForEach(data =>
            {
                Console.WriteLine($"For given string {data}, the longest substring is {GetMaxPalindrome(data)}");
            });
        }

        private string GetMaxPalindrome(string input)
        {
            if(input.Length==1)
            {
                return input;
            }
            string longestPalindrome = "";
            int step = 1;
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            List<string> results;
            while(step <= input.Length)
            {
                results = new List<string>();
                for (int start = 0; start + step <= input.Length; start++)
                {
                    string substring = input.Substring(start, step);
                    // Step=1, IN this step we go through each character by character and put them in dictionary with value true 
                    //Palindrome = TRUE (always true for single character)
                    if(step == 1)
                    {
                        if(!dict.ContainsKey(substring))
                        {
                            dict.Add(substring, true);
                            results.Add(substring);
                        }
                    }
                    else if (step == 2)
                    {
                        //Step=2; In this step we increase left index by 1, and processing two characters each time
                        //Palindrome = TRUE (if character 1 equals character 2)
                        if (substring[0] == substring[1])
                        {
                            if (!dict.ContainsKey(substring))
                            {
                                dict.Add(substring, true);
                                results.Add(substring);
                            }
                        }
                        else
                        {
                            if (!dict.ContainsKey(substring))
                            {
                                dict.Add(substring, false);
                            }
                        }
                        
                    }
                    else
                    {
                        //Step3: When checking palindrome of 2+ characters, Just check if first and last character equals + inner substring palindrome?
                        dict.TryGetValue(substring.Substring(1, substring.Length - 2), out bool isInnerPalindrome);
                        if (substring[0] == substring[substring.Length-1] && isInnerPalindrome)
                        {
                            if (!dict.ContainsKey(substring))
                            {
                                dict.Add(substring, true);
                                results.Add(substring);
                            }
                        }
                        else
                        {
                            if (!dict.ContainsKey(substring))
                            {
                                dict.Add(substring, false);
                            }
                        }
                    }
                }
                step++;
                if(results.Count>0)
                    longestPalindrome = results[0];
            }
            return longestPalindrome;
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            throw new NotImplementedException();
        }
    }
}
