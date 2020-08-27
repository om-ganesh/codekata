using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class FindDuplicateParenthesis : IProblem
    {
        List<string> inputs = new List<string>();
        public void ReadInput()
        {
            inputs.Add("(a+b)+((c+d))");
            inputs.Add("((a+b)+(c+d))");
        }

        public void Execute()
        {
            inputs.ForEach(input =>
            {
                bool result = ContainsAnyDuplicateParenthesis(input);
                Console.WriteLine($"The array {input} contains duplicate parenthesis ? {result}");
            });
        }

        private bool ContainsAnyDuplicateParenthesis(string input)
        {
            return true;
        }

        public void ShowResult()
        {
            throw new NotImplementedException();
        }
    }
}
