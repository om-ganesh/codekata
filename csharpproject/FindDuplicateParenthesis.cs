using csharpproject.Utility;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-expression-duplicate-parenthesis-not/
    /// </summary>
    class FindDuplicateParenthesis : IProblem
    {
        List<string> dataset = new List<string>();

        public FindDuplicateParenthesis()
        {
            dataset.Add("(a+b)+((c+d))");
            dataset.Add("((a+b)+(c+d))");
            dataset.Add("(((a+(b)))+(c+d))");
            dataset.Add("((a+(b))+(c+d))");
            dataset.Add("(((a+(b))+c+d))");
            dataset.Add("((a+(b))+(c+d))");
            dataset.Add("(((a)))");
            //Scenario: If stack top is also closing and input expression is opening at same instance its duplicate
        }

        public void Execute()
        {
            dataset.ForEach(data =>
            {
                sbyte result = ContainsAnyDuplicateParenthesis(data);

                if(result == -1)
                {
                    Console.WriteLine($"The array {data} is invalid expression");
                }
                else
                {
                    //string postfix = ConvertInfixToPostfix(input);
                    //Console.WriteLine($"The infix {input} expression for which postfix is {postfix}");
                    Console.WriteLine($"The array {data} contains duplicate parenthesis ? {result}");
                }
            });
        }

        /// <summary>
        /// LOGIC: When we encounter Closing bracket, and if there exists Opening bracket at top, not expression its duplicate
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private sbyte ContainsAnyDuplicateParenthesis(string input)
        {
            sbyte count = 0;
            Stack<char> stack = new Stack<char>();
            foreach (char c in input.ToCharArray())
            {
                //Push the opening brackets to stack
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if(stack.Count == 0)
                    {
                        return -1;
                    }
                    if(stack.Peek() == 'e')
                    {
                       // For all ) encountered, there must have been ( followed by expression
                        if(stack.Count < 2)
                        {
                            return -1;
                        }
                        stack.Pop();
                        stack.Pop();
                    }
                    else if (stack.Peek() == '(')
                    {
                        //Just return true if just need to know yes/no
                        count++;
                    }
                }
                else
                {
                    //If input is not opening/closing bracket, push 'e' to represent expression
                    if (stack.Count == 0 || stack.Peek() != 'e')
                    {
                        stack.Push('e');
                    }
                }
            }
            return count;
        }

        // Not part of the solution
        //public string ConvertInfixToPostfix(string input)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    char[] postfix = new char[input.Length];
        //    foreach (char c in input.ToCharArray())
        //    {
        //        if (IsOperand(c))
        //        {
        //            postfix.Append(c);
        //        }
        //        else if (IsOpeningBracket(c))
        //        {
        //            stack.Push(c);
        //        }
        //        else if (IsClosingBracket(c))
        //        {
        //            while (stack.Count > 0 && !IsOpeningBracket(stack.Peek()))
        //            {
        //                postfix.Append(stack.Pop());
        //            }
        //            stack.Pop();//remove that opening bracket from stack
        //        }
        //        else
        //        {
        //            while (stack.Count > 0 && HasLessPrecedence(c, stack.Peek()))
        //            {
        //                postfix.Append(stack.Pop());
        //            }
        //            stack.Push(c);
        //        }
        //    }
        //    while (stack.Count > 0)
        //    {
        //        postfix.Append(stack.Pop());
        //    }
        //    return postfix.ToString();
        //}


        //private bool HasLessPrecedence(char c, char charAtStackTop)
        //{
        //    return true;
        //}

        //private bool IsOperand(char element)
        //{
        //    return !(element == '+' || element == '-' || element == '*' || element == '(' || element == ')');
        //}
    }
}
