using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020
{
    /// <summary>
    /// https://stackoverflow.com/questions/30178172/check-for-palindrome-ignore-special-characters-whitespace-and-capitalization
    /// </summary>
    class PalindromeAlphaCharacters : IProblem
    {
        List<string> dataSet = new List<string>();

        public PalindromeAlphaCharacters()
        {
            dataSet.Add("ABCcba");
            dataSet.Add("A45B!**Ccb$a#$");
            dataSet.Add("45B!**Ccb$a#$");
            dataSet.Add("A45B!**Cdecb$a#$");
            dataSet.Add("A45B!**CDcb$a#$");
        }
        public void Execute()
        {
            dataSet.ForEach(data =>
            {
                var result = isPalindrome(data);
                Console.WriteLine($"Is {data} is Palindrome? => {result}");
            });
        }

        private bool isPalindrome(String s)
        {
            int leftPtr = 0;
            int rightPtr = s.Length - 1;
            while (leftPtr<rightPtr)
            {
                //Skip the non-alphanumeric characters
                while(!Char.IsLetter(s[leftPtr]))
                {
                    leftPtr++;
                }

                while (!Char.IsLetter(s[rightPtr]))
                {
                    rightPtr--;
                }

                if(Char.ToLower(s[leftPtr]) != Char.ToLower(s[rightPtr]))
                {
                    return false;
                }
                leftPtr++;
                rightPtr--;
            }
            return true;
        }
    }
}
