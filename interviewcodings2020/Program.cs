using System;
using System.Collections.Generic;
using System.Linq;

using interviewcodings2020.Amazon;
using interviewcodings2020.Microsoft;
using interviewcodings2020.Facebook;

namespace interviewcodings2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Interview questions asked this season");

            // Just replace the name of the class to execute
            IProblem problem = new FirstAndLastElementInArray();
            problem.Execute();

            Console.Read();
        }
    }
}
