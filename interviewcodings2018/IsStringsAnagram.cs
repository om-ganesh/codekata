using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    public class IsStringsAnagram
    {
        public static void Init()
        {
            String s1 = "subash";
            String s2 = "HSABUS";
            Console.WriteLine($"Are {s1} and {s2} anagram? {IsAnagram(s1, s2)}");
            Console.WriteLine($"Are {s1} and {s2} anagram? {IsAnagramRaw(s1, s2)}");

        }

        //Will have O
        public static bool IsAnagram(String s1, String s2)
        {
            char[] s1Array = s1.ToUpper().ToCharArray();
            Array.Sort(s1Array);
            char[] s2Array = s2.ToUpper().ToCharArray();
            Array.Sort(s2Array);
            return new String(s1Array).Equals(new String(s2Array));
        }

        public static bool IsAnagramRaw(String s1, String s2)
        {
            int[] arr = new int[26];    //97+26-1-65
            foreach(char c in s1)
            {
                if (c < 97)
                    arr[c - 65]++;
                else
                    arr[c - 97]++;
            }
            foreach (char c in s2)
            {
                if (c < 97)
                    arr[c - 65]--;
                else
                    arr[c - 97]--;
            }
            foreach(int x in arr)
            {
                if (x != 0)
                    return false;
            }
            return true;
        }
    }
}
