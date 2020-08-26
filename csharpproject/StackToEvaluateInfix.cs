using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    class StackToEvaluateInfix : IProblem
    {
        string[] input;
        StackArray<int> operands;
        StackArray<string> operators;

        public StackToEvaluateInfix()
        {
            operands = new StackArray<int>();
            operators = new StackArray<string>();
        }
        public void Execute()
        {
            foreach(string str in input)
            {
                if( str == "(")
                {
                    continue;
                }
                else if(str== ")")
                {
                    int x = operands.pop();
                    int y = operands.pop();
                    string opr = operators.pop();
                    operands.push(Operation(y,opr,x));
                }
                else if(IsOperator(str))
                {
                    operators.push(str);
                }
                else
                {
                    operands.push(Int32.Parse(str));
                }
            }
            while(!operators.isEmpty())
            {
                int x = operands.pop();
                int y = operands.pop();
                string opr = operators.pop();
                operands.push(Operation(y, opr, x));
            }
        }

        private int Operation(int x, string opr, int y)
        {
            int result=-1;
            switch(opr)
            {
                case "+":
                    result =  x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result =  x * y;
                    break;
            }
            return result;
        }

        private bool IsOperator(string str)
        {
            return str == "+" || str == "-" || str == "*";
        }

        public void ReadInput()
        {
            Console.WriteLine("Evaluate expression: 2+(12-2)*(3+(4+5))"); 
            input = new string[] { "2", "+", "(", "12", "-", "2", ")", "*", "(", "3", "+", "(", "4", "+", "5", ")", ")" };
        }

        public void ShowResult()
        {
            Console.WriteLine($"The expression result is {operands.pop()}");
        }
    }
    
}
