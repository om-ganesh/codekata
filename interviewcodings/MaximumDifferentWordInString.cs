using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings
{
    /// <summary>
    /// Write a program to find the word with maximum different letters in given string.
    /// </summary>
    public class MaximumDifferentWordInString
    {

        public static void Init()
        {
            string given = "Hello this is the ibm interview question extracted from g2g";
            Console.WriteLine("The word with maximum different letters is " + GiveMaximumLetterWord(given));
        }

        private static string GiveMaximumLetterWord(string given)
        {
            string[] arr = given.Split(' ');
            int count = 0;
            string result = "";
            foreach (string str in arr)
            {
                HashSet<char> temp = new HashSet<char>();
                foreach (char c in str.ToCharArray())
                {
                    temp.Add(c);
                }
                if (temp.Count > count)
                {
                    count = temp.Count;
                    result = str;
                }
            }
            return result;
        }
    }
}
