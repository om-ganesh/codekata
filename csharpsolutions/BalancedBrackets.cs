using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace csharpsolutions
{
    class BalancedBrackets: IProblem
    {
        char[] openingBrackets = new char[]{ '{', '[', '(' };
        char[] closingBrackets = new char[]{ '}', ']', ')' };

        string[] data;
        bool[] result;
        public BalancedBrackets()
        {
            data = new string[]{ " ", "( ", " (]", "[||]", "((((()", "()))", "(()]", "{}[","[]{}","{[]}","[]{(}","({[}])","{{[[(())]]}}" };
            result = new bool[data.Length];
        }

        public void ReadInput()
        {
            Console.WriteLine("Give input strings separated by , e.g. {]{}((,[]");
            data = Console.ReadLine().TrimEnd().Split(',');
            result = new Boolean[data.Length]; 
        }

        public void Execute()
        {
            for(int i=0; i <data.Length; i++)
            {
                result[i] = isBalanced(data[i]);
            }
        }

        // Complete the isBalanced function below.
        Boolean isBalanced(string str) {

            Stack<char> stack = new Stack<char>();
            //Corner Cases that can be avoided initially
            var s = str.Trim();
            if(s.Length == 0 || s.Length%2 ==1 
                || closingBrackets.Contains(s[0]) || openingBrackets.Contains(s[s.Length-1]))
            {
                return false;
            }
        
            for(int j=0; j< s.Length; j++)
            {
                char current = s[j];
                
                if(openingBrackets.Contains(current))
                {
                    stack.Push(current);
                }
                else if(closingBrackets.Contains(current))
                {
                    if(stack.Count==0 || Array.IndexOf(openingBrackets, stack.Pop()) != Array.IndexOf(closingBrackets, current))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return stack.Count==0;
        }

        public void ShowResult()
        {
            for(int i=0;i <data.Length;i++)
            {
                Console.WriteLine($"Balance Bracket Check: {data[i]} = {result[i]}");
            }
        }
    }
}
