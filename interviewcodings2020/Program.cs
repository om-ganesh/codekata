using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Interview questions asked this season");

            // Just replace the name of the class to execute
            IProblem problem = new GoatLatin();
            problem.Execute();

            Console.Read();
        }
    }
}
