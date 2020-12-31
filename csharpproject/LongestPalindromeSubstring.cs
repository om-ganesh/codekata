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
            dataset.Add("o");
            dataset.Add("mm");
            dataset.Add("lol");
            dataset.Add("aaaabbaa");
            dataset.Add("abcvfaafx");
            dataset.Add("rfkqyuqfjkxy");
            dataset.Add("rfafkqyuqaqjkxy");
            dataset.Add("babad");
            dataset.Add("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");

        }
        public void Execute()
        {
            dataset.ForEach(data =>
            {
                Console.WriteLine($"For given string {data}, the longest palindrome substring is {LongestPalindrome(data)}");
            });
        }

        private string LongestPalindrome(string s)
        {
            if (s.Length <= 0)
            {
                return string.Empty;
            }
            else if (s.Length == 1)
            {
                return s;
            }

            string longestPalindrome = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                var str1 = expandAroundCenter(s, i, i + 2);
                var str2 = expandAroundCenter(s, i, i + 1);
                var longest = str2.Length > str1.Length ? str2 : str1;
                if (longest.Length > longestPalindrome.Length)
                {
                    longestPalindrome = longest;
                }
            }
            return longestPalindrome;
        }

        private string expandAroundCenter(string s, int left, int right)
        {
            int L = left;
            int R = right;
            while(L>=0 && R <s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            if(L == left && R == right)
            {
                return string.Empty;
            }
            return s.Substring(L+1, R - L - 1);
        }

        private string LongestPalindrome_Old(string s)
        {
            string longestPalindrome = string.Empty; 
            if (s.Length==1)
            {
                return s;
            }
            
            int step = 1;
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            while(step <= s.Length)
            {
                for (int i = 0; i + step <= s.Length; i++)
                {
                    string substring = s.Substring(i, step);
                    // Step=1, IN this step we go through each character by character and put them in dictionary with value true 
                    //Palindrome = TRUE (always true for single character)
                    if(step == 1)
                    {
                        if(!dict.ContainsKey(substring))
                        {
                            dict.Add(substring, true);
                            if (substring.Length > longestPalindrome.Length)
                            {
                                longestPalindrome = substring;
                            }
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
                                if (substring.Length > longestPalindrome.Length)
                                {
                                    longestPalindrome = substring;
                                }
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
                                if (substring.Length > longestPalindrome.Length)
                                {
                                    longestPalindrome = substring;
                                }
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
            }
            return longestPalindrome;
        }
    }
}